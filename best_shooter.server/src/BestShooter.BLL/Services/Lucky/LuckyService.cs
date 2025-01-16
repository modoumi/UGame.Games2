using BestShooter.BLL.Caching;
using BestShooter.BLL.Common;
using BestShooter.BLL.Services.Order;
using BestShooter.BLL.Services.platform;
using BestShooter.BLL.Services.UserEx;
using BestShooter.DAL;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Super_phoenix.BLL;
using TinyFx.Data;
using TinyFx.Logging;
using Xxyy.Common.Caching.Partner;
using Xxyy.GameEAPI.Common;
using Xxyy.GameEAPI.Common.Enum;
using Xxyy.GameEAPI.Core;
using Xxyy.GameEAPI.Services;

namespace BestShooter.BLL.Services.Lucky
{
    public class LuckyService : BaseApiGameService
    {
        private UserExService _userExService = new();

        private OrderService _orderService = new();

        private AppUserDCache _appUserDCache;
        private AppLoginTokenDO appToken;
        private Bs_bet_orderMO _betOrderMo = new();
        bool IsChangeBalance = false;
        //平台服务
        private PlatformService _platFormService;

        public LuckyService(string userId)
        {
            _platFormService = new PlatformService(userId);
            _appUserDCache = new AppUserDCache(userId);
            appToken = GetLoginTokenDo(userId);
        }

        /// <summary>
        /// 计算获得luckyNum次数
        /// </summary>
        /// <param name="bet"></param>
        /// <returns></returns>
        public async Task<LuckyNumDto> CalculationLuckyNum(string operatorId, string currencyId)
        {
            var result = new LuckyNumDto();

            //2、获取Lucky次数几率
            var luckNumOddsList = MemoryUtil.GetLuckyNumList(operatorId, currencyId);

            var count = luckNumOddsList.Sum(x => x.Weight);
            var random = new Random().Next(count);
            int startNum = 0;

            foreach (var item in luckNumOddsList)
            {
                if (random >= startNum && random <= (item.Weight + startNum - 1))
                {
                    result.LuckyNum = item.Val;
                    break;
                }
                startNum += item.Weight;
            }

            if (result.LuckyNum > 0)
                result.IsWin = true;

            return result;
        }

        /// <summary>
        /// lucky值抽奖
        /// </summary>
        /// <param name="userExEoIpo"></param>
        /// <returns></returns>
        public async Task<LuckyRaffleDto> CalculationLuckyRaffle(LuckyIpo ipo)
        {
            var ret = new LuckyRaffleDto();
            //1、获取当前用户userEx
            var userExEo = await _userExService.GetUserExByPK(ipo.UserId);
            //获取用户余额
            long balance = await GameEAPIUtil.GetBalance(ipo.UserId, appToken.AppId);
            ret.Balance = Math.Round(balance.AToM(await _appUserDCache.GetCurrencyIdAsync()), 2, MidpointRounding.ToZero);

            //如果个人lucky奖池为0，则强制结果为不中奖
            if (userExEo.LuckySumAmount == 0 || userExEo.ThisLuckyAmount == 0)
                return ret;

            //2、获取奖池配置
            var _config = MemoryUtil.GetConfig(appToken.OperatorId, appToken.CurrencyId);
            //3、如果用户lucky值小于lucky抽奖阈值，则强制结果为不中奖
            if (userExEo.LuckyValue < _config.LuckyCount)
                return ret;

            //计算lucky抽奖中奖金额，此处lucky中奖金额为乘10000后
            await LuckRaffle(appToken, userExEo, ret);

            var tm = new TransactionManager();

            //订单初始化
            await AddOrders(ipo, ret, userExEo);

            try
            {
                ipo.UpdateTimeNow = DateTime.UtcNow;

                var betWinDto = await GameEAPIUtil.BetWin(ipo.OrderId, appToken.AppId, ipo.RaffleOrderId, 0, (long)ret.WinAmount);

                if (betWinDto == null)
                    throw new Exception($"OperatorClient的BetWin接口异常.{JsonConvert.SerializeObject(betWinDto)}");

                ret.Balance = betWinDto.Balance;

                //更新gbs_user_ex与lucky相关字段
                var updateUserEx = _userExService.UpdateUserExForLuckyDraw(ipo.UserId, (long)ret.WinAmount, tm);

                //更新订单-Win
                await _betOrderMo.PutStatusByPKAsync(ipo.OrderId, (int)OrderStatus.Success, tm);

                //重新获取用户gbs_user_ex
                userExEo = await _userExService.GetUserExByPK(ipo.UserId, tm);

                tm.Commit();
            }
            catch (Exception ex)
            {
                tm.Rollback();
                LogUtil.DefaultLogger.LogError(ex.Message);
                ret = new LuckyRaffleDto();
                var status = IsChangeBalance ? OrderStatus.Exception : OrderStatus.Fail;
                await _betOrderMo.PutStatusByPKAsync(ipo.OrderId, (int)status, tm);
                return ret;
            }
            ret.IsWin = true;
            ret.WinAmount = Math.Round(((long)ret.WinAmount).AToM(await _appUserDCache.GetCurrencyIdAsync()), 2, MidpointRounding.ToZero);
            ret.Balance = Math.Round(((long)ret.Balance).AToM(await _appUserDCache.GetCurrencyIdAsync()), 2, MidpointRounding.ToZero);

            await _appUserDCache.SetLuckyValueAsync(userExEo.LuckyValue);
            return ret;
        }

        /// <summary>
        /// lucky值抽奖几率计算
        /// </summary>
        /// <param name="userExEo"></param>
        /// <param name="luckyRaffleDto"></param>
        /// <returns></returns>
        private async Task LuckRaffle(AppLoginTokenDO appToken, Bs_user_extEO userExEo, LuckyRaffleDto luckyRaffleDto)
        {
            //2、获取Lucky次数几率
            var luckyOddsList = MemoryUtil.GetLuckyMultipList(appToken.OperatorId, appToken.CurrencyId);

            var count = luckyOddsList.Sum(x => x.Weight);
            var random = new Random().Next(count);
            int startNum = 0;
            foreach (var item in luckyOddsList)
            {
                if (random >= startNum && random <= (item.Weight + startNum - 1))
                {
                    //实际中奖金额
                    luckyRaffleDto.WinAmount = (long)(userExEo.ThisLuckyAmount * ((decimal)item.Val / 100));
                    break;
                }
                startNum += item.Weight;
            }

            //如果中奖金额大于用户个人lucky奖池金额，则强制中奖最小倍数
            if (luckyRaffleDto.WinAmount > userExEo.LuckySumAmount)
            {
                var minMultiple = luckyOddsList.Min(d => d.Val);
                luckyRaffleDto.WinAmount = (long)(userExEo.ThisLuckyAmount * ((decimal)minMultiple / 100));
                if (luckyRaffleDto.WinAmount > userExEo.LuckySumAmount)
                    luckyRaffleDto.WinAmount = 0;
            }

            luckyRaffleDto.IsWin = true;
        }

        /// <summary>
        /// Lucky抽奖订单初始化
        /// </summary>
        /// <param name="isWin"></param>
        /// <param name="ipo"></param>
        /// <param name="userExEo"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        private async Task AddOrders(LuckyIpo ipo, LuckyRaffleDto dto, Bs_user_extEO userExEo)
        {
            //抽奖订单
            Bs_order_raffleEO raffleOrder = null;

            if (dto.IsWin)
            {
                raffleOrder = new Bs_order_raffleEO();
                raffleOrder.RaffleOrderID = Guid.NewGuid().ToString();
                raffleOrder.UserID = ipo.UserId;
                raffleOrder.UserNickName = await GameEAPIUtil.GetNickName(ipo.UserId);
                raffleOrder.OrderID = ipo.OrderId;
                raffleOrder.OrderType = (int)RaffleType.Lucky;
                raffleOrder.LuckySumAmount = userExEo.LuckySumAmount;
                raffleOrder.LuckyAmount = userExEo.ThisLuckyAmount;
                raffleOrder.WinAmount = (long)dto.WinAmount;
                raffleOrder.Status = 1;
                raffleOrder.RecDate = ipo.AddTimeNow;
            }

            if (raffleOrder != null)
            {
                if (!await _orderService.AddRaffleOrder(raffleOrder))
                    throw new Exception("Failed to add raffle order.");
            }
        }

    }
}
