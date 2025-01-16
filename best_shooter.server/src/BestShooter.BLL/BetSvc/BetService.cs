using BestShooter.BLL.Caching;
using BestShooter.BLL.Common;
using BestShooter.BLL.LoadSvc;
using BestShooter.BLL.Services.Jackpot;
using BestShooter.BLL.Services.Lucky;
using BestShooter.BLL.Services.MainPool;
using BestShooter.BLL.Services.Order;
using BestShooter.BLL.Services.platform;
using BestShooter.BLL.Services.Star;
using BestShooter.BLL.Services.UserDCaches;
using BestShooter.BLL.Services.UserEx;
using BestShooter.DAL;
using TinyFx;
using TinyFx.Configuration;
using TinyFx.Data;
using TinyFx.Extensions.AutoMapper;
using TinyFx.Extensions.RabbitMQ;
using TinyFx.Logging;
using Xxyy.Common.Caching.Partner;
using Xxyy.GameEAPI.Common;
using Xxyy.GameEAPI.Common.Const;
using Xxyy.GameEAPI.Common.Enum;
using Xxyy.GameEAPI.Core;
using Xxyy.GameEAPI.Services;

namespace BestShooter.BLL.BetSvc
{
    public class BetService : BaseApiGameService
    {
        //缓存用户
        private AppUserDCache _appUserDCache;
        //球星服务
        private StarService _starService = new();
        //lucky服务
        private LuckyService _luckyService;
        //用户服务
        private UserExService _userExService = new();
        //Jackpot奖池服务
        private JackpotService _jackpotService = new();
        //订单服务
        private OrderService _orderService = new();
        //初始化服务
        private LoadService _initLoadService;
        //球星缓存
        private StarDCache _starDCache = new();
        //球星中奖几率缓存
        private StarOddsDCache _starOddsDCache = new();
        //主奖池服务
        private MainPoolService _mainPoolService = new();

        //平台服务
        private PlatformService _platFormService;

        //AppOption配置
        //private BestShooterOptionsSection _bestShooterOptions;
        private Bs_bet_orderMO _betOrderMo = new();
        bool IsChangeBalance = false;
        public BetService(string userId)
        {
            _appUserDCache = new AppUserDCache(userId);
            _initLoadService = new LoadService(userId);
            _platFormService = new PlatformService(userId);
            _luckyService = new LuckyService(userId);
           // _bestShooterOptions = ConfigUtil.GetSection<BestShooterOptionsSection>();
        }

        /// <summary>
        /// 下注
        /// </summary>
        /// <param name="ipo"></param>
        /// <returns></returns>
        public async Task<BetDto> Bet(BetIpo ipo)
        {
            var appToken = GetLoginTokenDo(ipo.UserId);
            BetDto ret = new();

            //用户余额
            long balance = await GameEAPIUtil.GetBalance(ipo.UserId, appToken.AppId);
            if (ipo.TotalBet > balance)
            {
                await Reset(ret);
                throw new CustomException(PartnerCode.RS_NOT_ENOUGH_MONEY, "用户余额不足", result: ret);
            }

            //1、获取当前用户
            var userExEo = await _userExService.GetUserExByPK(ipo.UserId);

            //2、获取全部奖池配置
            var _config = MemoryUtil.GetConfig(appToken.OperatorId, appToken.CurrencyId);
            //强制结算
            //如果当前下注值 > 最大可下注值
            if (ipo.TotalBet > _config.MaxStake)
                return ret;
            //4、如果下注额大于最大下注额
            if (ipo.TotalBet > _config.MaxStake)
            {
                await Reset(ret);
                throw new CustomException("", "下注额超出最大下注额", result: ret);
            }
            //计算lucky、Jackpot累计值
            var addLuckyAmount = (long)(ipo.TotalBet * ((decimal)_config.InLucky / 100));
            var addJackpotAmount = (long)(ipo.TotalBet * ((decimal)_config.InJackpot / 100));
            //运营商Id
            var operatorId = await _appUserDCache.GetOperatorIdAsync();
            var currencyId = await _appUserDCache.GetCurrencyIdAsync();
            var preStarId = await _appUserDCache.GetPreStarIDAsync();

            //3、获取所有奖池值（主奖池、JP奖池）
            var mainPool = await _mainPoolService.GetByOperatorIDAsync(operatorId);
            var jackpot = await _jackpotService.GetJackpotPool(operatorId, currencyId);

            //5、获取用户选中的球星
            var starAsync = await _starDCache.GetOrLoadAsync(await _appUserDCache.GetOperatorIdAsync());
            
            var star = starAsync.Value.Where(d => d.OperatorID.Equals(operatorId) && d.StarID == preStarId).FirstOrDefault();

            //6、获取当前球星对应位置的中奖几率
            var starOddsListAsync = await _starOddsDCache.GetOrLoadAsync(operatorId);
            var starOddsList = starOddsListAsync.Value.Where(d => d.OperatorID.Equals(star.OperatorID) && d.StarID == star.StarID && d.Goal == userExEo.Goal && d.Position == ipo.place).OrderBy(d => d.Odds).ToList();

            //7、是否进球、奖金
            var betResult = await _starService.CalculationBetResult(star, starOddsList, ipo.TotalBet);

            //8、如果进球了，并且奖金（中奖金额+奖励金额）大于主奖池金额，则属于没进球
            if (betResult.IsWin && betResult.WinAmount > mainPool.Amount || !betResult.IsWin)
            {
                betResult = new BetOddsResult();
                betResult.WinAmount -= (long)ipo.TotalBet;
            }

            //9、计算获得luckyNum次数
            var luckyNumDto = new LuckyNumDto();
            if (ipo.TotalBet > _config.LuckyStartBet)
                luckyNumDto = await _luckyService.CalculationLuckyNum(appToken.OperatorId, appToken.CurrencyId);

            //10、计算JP是否中奖
            var jackpotRaffleResult = new JackpotRaffleResult();
            var isTriggerJackpotRaffle = false;
            //如果当前用户Jackpot累计值大于Jackpot抽奖阈值，或当前下注所获得的Jackpot累计值大于Jackpot抽奖阈值
            if (userExEo.JackpotValue >= _config.JackpotCount || addJackpotAmount >= _config.JackpotCount || userExEo.JackpotValue + addJackpotAmount >= _config.JackpotCount)
            {
                isTriggerJackpotRaffle = true;
                jackpotRaffleResult = await _jackpotService.CalcJpOdds(appToken, userExEo, jackpot, await _appUserDCache.GetBaseBetAsync(), (long)ipo.TotalBet);
            }

            //12、下注、JP中奖金额汇总，BetWin接口需要
            var sumWinAmount = betResult.WinAmount + jackpotRaffleResult.WinAmount;

            //11、订单初始化
            await AddOrders(ipo, appToken, jackpotRaffleResult, starOddsList, betResult, betResult.WinAmount);

            var tm = new TransactionManager();

            try
            {
                balance = (await GameEAPIUtil.BetWin(
                    ipo.UserId,
                    appToken.AppId,
                ipo.OrderID,
                (long)ipo.TotalBet,
                betResult.IsWin ? betResult.WinAmount + jackpotRaffleResult.WinAmount : 0 + jackpotRaffleResult.WinAmount
                )).Balance;
                IsChangeBalance = true;

                //2、为了加锁，重新获取
                mainPool = await _mainPoolService.GetByOperatorIDAsync(operatorId, tm);
                jackpot = await _jackpotService.GetJackpotPool(operatorId, currencyId, tm);

                //3、更新主奖池
                var poolMainAmount = (long)(ipo.TotalBet * ((decimal)_config.InPublic / 100));
                if (betResult.IsWin)
                    poolMainAmount -= betResult.WinAmount;
                await _mainPoolService.PutMainPool(poolMainAmount, operatorId, currencyId, tm);
                //4、更新JP奖池
                var poolJpAmount = (long)(ipo.TotalBet * ((decimal)_config.InJackpot / 100));
                if (jackpotRaffleResult.IsWin)
                    poolJpAmount -= jackpotRaffleResult.WinAmount;
                var updateJPPoolAmountResult = await _jackpotService.PutJPPool(poolJpAmount, operatorId, currencyId, tm);

                //5、更新gbs_user_ex
                var IsClearJackpotValue = jackpotRaffleResult.WinAmount > 0 || isTriggerJackpotRaffle;
                var updateUserEx = await _userExService.UpdateUserExForBetAfter(betResult.IsWin, _config.LuckyCount, _config.MaxGoal, luckyNumDto.LuckyNum, addLuckyAmount, addJackpotAmount, userExEo.UserID, IsClearJackpotValue, tm);

                //6、更新订单表状态
                await _betOrderMo.PutStatusByPKAsync(ipo.OrderID, (int)OrderStatus.Success, tm);
                userExEo = await _userExService.GetUserExByPK(userExEo.UserID, tm);

                tm.Commit();

                //Jackpot变更发送MQ消息
                //await SyncJackpot(ipo.OperatorID);
            }
            catch (Exception ex)
            {
                tm.Rollback();
                betResult.IsWin = false;
                betResult.IsSurprise = false;
                luckyNumDto.IsWin = false;
                luckyNumDto.LuckyNum = 0;
                jackpotRaffleResult.IsWin = false;
                jackpotRaffleResult.JackpotValue = 0;
                var status = IsChangeBalance ? OrderStatus.Exception : OrderStatus.Fail;
                await _betOrderMo.PutStatusByPKAsync(ipo.OrderID, (int)status, tm);
                LogUtil.Info($" ex.Message:{ex.Message}");
            }

            //用户缓存
            //重新生成球星
            star = await _starService.GetOneRandomStar(await _appUserDCache.GetOperatorIdAsync());

            await _appUserDCache.SetPreStarIDAsync(star.StarID);
            await _appUserDCache.SetPreBaseBetAsync((long)ipo.Bet);
            await _appUserDCache.SetPreBetAsync((long)ipo.TotalBet);
            await _appUserDCache.SetPreBetMultipleAsync(ipo.BetMultiple);
            await _appUserDCache.SetPrePlaceAsync(ipo.place);
            await _appUserDCache.SetPreResultAmountAsync(betResult.IsWin ? sumWinAmount - (long)ipo.TotalBet : sumWinAmount);
            await _appUserDCache.SetWinAmountAsync(betResult.WinAmount);
            await _appUserDCache.SetGoalProgressAsync(userExEo.Goal);
            var appUserDCacheLuckyValue = await _appUserDCache.GetLuckyValueAsync();
            await _appUserDCache.SetLuckyValueAsync(appUserDCacheLuckyValue >= _config.LuckyCount || appUserDCacheLuckyValue + luckyNumDto.LuckyNum > _config.LuckyCount ? _config.LuckyCount : appUserDCacheLuckyValue + luckyNumDto.LuckyNum);
            await _appUserDCache.SetIsWinAsync();

            await _appUserDCache.SetSumBetNumAsync((await _appUserDCache.GetSumBetNumAsync()) + 1);
            await _appUserDCache.SetJackpotRaffleAmountAsync(Math.Round(jackpotRaffleResult.WinAmount.AToM(currencyId), 2, MidpointRounding.ToZero));

            if (betResult.IsWin && userExEo.Goal + 1 >= _config.MaxGoal || balance < ipo.TotalBet * 1 || betResult.WinAmount > _config.MaxStake)
                await _appUserDCache.SetIsCollectAsync(true);

            //用户余额
            ret.Balance = Math.Round(balance.AToM(currencyId), 2, MidpointRounding.ToZero);
            ret.IsWin = betResult.IsWin;
            ret.PreResultAmount = Math.Round((await _appUserDCache.GetPreResultAmountAsync()).AToM(currencyId), 2, MidpointRounding.ToZero);
            ret.WinAmount = Math.Round(betResult.WinAmount.AToM(currencyId), 2, MidpointRounding.ToZero);
            ret.PreBaseBet = Math.Round(((long)ipo.Bet).AToM(currencyId), 2, MidpointRounding.ToZero);
            ret.PreBet = Math.Round(((long)ipo.TotalBet).AToM(currencyId), 2, MidpointRounding.ToZero);
            ret.PreBetMultiple = ipo.BetMultiple;
            ret.LuckyValue = await _appUserDCache.GetLuckyValueAsync();
            ret.luckyValueLimit = _config.LuckyCount;
            ret.IsTriggerLuck = ret.LuckyValue >= _config.LuckyCount ? true : false;
            ret.GoalProgress = await _appUserDCache.GetGoalProgressAsync();
            ret.MaxGoal = _config.MaxGoal;
            ret.IsSurprise = betResult.IsSurprise;
            ret.IsCollect = await _appUserDCache.GetIsCollectAsync();
            //获取最新奖池数值
            jackpot = await _jackpotService.GetJackpotPool(operatorId, currencyId);
            ret.JackpotAmount = Math.Round(jackpot.Amount.AToM(currencyId), 2, MidpointRounding.ToZero);
            ret.IsWinJackpot = jackpotRaffleResult.IsWin;
            ret.JackpotRaffleAmount = Math.Round(jackpotRaffleResult.WinAmount.AToM(currencyId), 2, MidpointRounding.ToZero);
            ret.PreStarID = star.StarID;
            ret.SumBetNum = await _appUserDCache.GetSumBetNumAsync();
            ret.MaxStake = Math.Round(_config.MaxStake.AToM(currencyId), 2, MidpointRounding.ToZero);
            ret.CountryId = appToken.CountryId;
            ret.JackpotValue = Math.Round(userExEo.JackpotValue.AToM(currencyId), 2, MidpointRounding.ToZero);
            ret.JackpotCfgValue = Math.Round(_config.JackpotCount.AToM(currencyId), 2, MidpointRounding.ToZero);
            ret.IsTriggerJackpotRaffle = isTriggerJackpotRaffle;
            ret.BaseBet = Math.Round((await _appUserDCache.GetBaseBetAsync()).AToM(currencyId), 2, MidpointRounding.ToZero);
            if ((await _appUserDCache.GetGoalProgressAsync()) == 0)
                ret.BaseBet = 0;

            //if (_appUserDCache.GoalProgress == 0 && _appUserDCache.SumBetNum > 1)
            //    return await Reset(ret);
            return ret;
        }

        /// <summary>
        /// 游戏初始化
        /// </summary>
        /// <returns></returns>
        private async Task<BetDto> Reset(BetDto dto)
        {
            var result = new BetDto();
            UserDCache userDCache = new();
            var _config = MemoryUtil.GetConfig(userDCache.OperatorId, userDCache.CurrencyId);
            userDCache.UserId = await _appUserDCache.GetUserIdAsync();
            userDCache.AppId = await _appUserDCache.GetAppIdAsync();
            userDCache.PlatformToken = await _appUserDCache.GetPlatformTokenAsync();
            userDCache.OperatorId = await _appUserDCache.GetOperatorIdAsync();
            userDCache.ProviderId = await _appUserDCache.GetProviderIdAsync();
            userDCache.CurrencyId = await _appUserDCache.GetCurrencyIdAsync();
            userDCache.PreStarID = dto.PreStarID == 0 ? await _appUserDCache.GetPreStarIDAsync() : dto.PreStarID;
            userDCache.IsCollect = await _appUserDCache.GetIsCollectAsync();
            userDCache.LuckyValue = await _appUserDCache.GetLuckyValueAsync();
            userDCache.IsTriggerLuck = (await _appUserDCache.GetLuckyValueAsync()) >= _config.LuckyCount ? true : false;

            await _appUserDCache.SetValues(userDCache);

            dto = userDCache.Map<BetDto>();

            var currencyId = userDCache.CurrencyId;

            //7、获取当前Jackpot奖池数据
            var jackpot = await _jackpotService.GetJackpotPool(userDCache.OperatorId, userDCache.CurrencyId);
            //1、获取当前用户余额
            var balance = await GameEAPIUtil.GetBalance(userDCache.UserId, userDCache.AppId);
            dto.Balance = Math.Round(balance.AToM(currencyId), 2, MidpointRounding.ToZero);
            dto.luckyValueLimit = _config.LuckyCount;
            dto.MaxGoal = _config.MaxGoal;
            dto.MaxStake = Math.Round(_config.MaxStake.AToM(currencyId), 2, MidpointRounding.ToZero);
            dto.JackpotAmount = Math.Round(jackpot.Amount.AToM(currencyId), 2, MidpointRounding.ToZero);

            var userExEo = await _userExService.GetUserExByPK(await _appUserDCache.GetCurrencyIdAsync());

            dto.JackpotValue = Math.Round(userExEo.JackpotValue.AToM(currencyId), 2, MidpointRounding.ToZero);
            dto.JackpotCfgValue = Math.Round(_config.JackpotCount.AToM(currencyId), 2, MidpointRounding.ToZero);

            return dto;
        }

        /// <summary>
        /// 订单初始化
        /// </summary>
        /// <param name="ipo"></param>
        /// <param name="jackpotRaffleResult">JP抽奖结果</param>
        /// <param name="starOddsList"></param>
        /// <param name="betResult">下注结果</param>
        /// <param name="betWinAmount">进球后奖金</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        private async Task AddOrders(BetIpo ipo, AppLoginTokenDO appToken, JackpotRaffleResult jackpotRaffleResult, List<Bs_config_star_oddsEO> starOddsList, BetOddsResult betResult, long betWinAmount)
        {
            var timeNow = DateTime.UtcNow;

            var betOrder = new Bs_bet_orderEO()
            {
                BetOrderID = ipo.BetOrderID,
                OrderID = ipo.OrderID,
                Bet = (long)ipo.TotalBet,
                BetDouble = (int)(ipo.BetMultiple * 100),
                Place = ipo.place,
                Multiple = starOddsList.Where(d => d.IsBaseMultiple == 1).FirstOrDefault().Multiple,
                IsSurprise = betResult.IsSurprise ? 1 : 0,
                Status = 1,
                Amount = betWinAmount,
                RecDate = timeNow
            };

            Bs_order_raffleEO raffleOrder = null;
            if (jackpotRaffleResult.IsWin)
            {
                raffleOrder = new();
                raffleOrder.RaffleOrderID = ipo.RaffleOrderID;
                raffleOrder.OrderID = ipo.OrderID;
                raffleOrder.OrderType = (int)RaffleType.Jackpot;
                raffleOrder.JackpotCount = jackpotRaffleResult.JackpotValue;
                raffleOrder.WinAmount = jackpotRaffleResult.WinAmount;
                raffleOrder.Status = 1;
                raffleOrder.UserID = ipo.UserId;
                raffleOrder.UserNickName = await GameEAPIUtil.GetNickName(ipo.UserId);
                raffleOrder.RecDate = timeNow;
            }
            if (!await _orderService.AddBetOrder(betOrder))
                throw new Exception("Failed to add raffle order.");
            if (raffleOrder != null)
            {
                if (!await _orderService.AddRaffleOrder(raffleOrder))
                    throw new Exception("Failed to add raffle order.");
            }
        }

        /// <summary>
        /// JP奖池发送MQ
        /// </summary>
        /// <param name="operatorId"></param>
        /// <returns></returns>
       /* private async Task SyncJackpot(string operatorId)
        {
            //获取上次同步JP奖池时间
            var field = SyncJackpotTimeDCache.GetFieldAsync(operatorId);
            var syncJackpotTimeDCache = new SyncJackpotTimeDCache();
            var preSendMqTime = await syncJackpotTimeDCache.GetOrLoadAsync(field);

            //如果缓存中没有上次发送MQ时间，或上次发送时间+时间间隔小于当前时间
            //则发送MQ，并更新
            if (preSendMqTime.HasValue && (preSendMqTime.Value == DateTime.MinValue || preSendMqTime.Value.AddMinutes(Convert.ToInt32(_bestShooterOptions.SyncJackpotIntervalTime)) < DateTime.UtcNow))
            {
                //获取当前JP奖池
                var jackpotPool = await new Bs_pool_jackpotMO().GetSingleAsync("OperatorID = @OperatorID", operatorId);

                if (jackpotPool == null)
                {
                    LogUtil.Error($"SyncJackpot,未找到gbs_jackpot_pool,CountryId{operatorId}");
                    return;
                }

                var msg = new SyncJackpotMsg()
                {
                    OperatorId = jackpotPool.OperatorID,
                    CurrencyId = jackpotPool.CurrencyID,
                    AppId = _bestShooterOptions.AppId,
                    Jackpot = jackpotPool.Amount
                };
                await MQUtil.PublishAsync(msg);
                await syncJackpotTimeDCache.GetOrLoadAsync(field, true);
            }

            return;
        }*/

    }
}
