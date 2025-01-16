using Gold_ggk.BLL.BetSvc.Process;
using Gold_ggk.DAL;
using TinyFx;
using TinyFx.Data;
using TinyFx.SnowflakeId;
using TinyFx.Extensions.StackExchangeRedis;
using Xxyy.GameEAPI.Common;
using Xxyy.GameEAPI.Common.Enum;
using Xxyy.GameEAPI.Core;
using Xxyy.GameEAPI.Services;

namespace Gold_ggk.BLL.BetSvc
{
    public class BetService : BaseApiGameService
    {
        private Ggk_user_extMO _extMO = new();
        private Ggk_bet_detailMO _betDetailMo = new();
        private Ggk_pool_returnMO _poolReturnMo = new();
        private readonly All_pool_change_detailMO _poolChangeMo = new();
        public async Task<BetDto> Bet(BetIpo ipo)
        {
            var appToken = GetLoginTokenDo(ipo.UserId) ?? throw new CustomException(CommonCodes.RS_TOKEN_EXPIRED, $"tolen 超时{ipo.UserId}");
            await CheckIdentityAndMock(ipo.UserId);
            var context = new BetContext(ipo, appToken);
            var lockKey = $"{appToken.AppId}:{ipo.UserId}";
            using (var redlock = await RedisUtil.LockAsync(lockKey, CommonCodes.LockTime))
            {
                if (!redlock.IsLocked)
                {
                    redlock.Release();
                    throw new CustomException(CommonCodes.UserConcurrent, $"{lockKey}:请求分布式锁失败!");
                }
                var betId = context.BetId = SnowflakeIdUtil.NextId();
                //算法逻辑
                await ExecuteContext(context);
                long balance = 0;
                //先插入数据
                await GoldUtil.AddBetDetail(context, betId, null);

                var tm = new TransactionManager();
                try
                {

                    if (!context.isFreeSpin)
                    {
                        balance = await GameEAPIUtil.GetBalance(context.UserId, context.AppId);
                        if (balance < context.Config_Chips.BetAmount)
                        {
                            throw new CustomException(CommonCodes.RS_NOT_ENOUGH_MONEY, "余额不足");
                        }
                        balance = (await GameEAPIUtil.BetWin(context.UserId, context.AppId, betId.ToString()
                                 , context.Config_Chips.BetAmount, context.WinTotalAmount)).Balance;
                        context.IsChangeBalance = true;
                        //更新基础奖池
                        await PutPool(context, context.PartAmount.PartBaseAmount, tm);
                    }
                    else
                    {
                        balance = (await GameEAPIUtil.BetWin(context.UserId, context.AppId, betId.ToString()
                                 , 0, context.WinTotalAmount)).Balance;
                        context.IsChangeBalance = true;
                    }
                    //更新下注表
                    await _betDetailMo.PutOrderStatusByPKAsync(betId, (int)OrderStatus.Success, tm);
                    //更新用户ext
                    await _extMO.PutAsync(context.UserExt, tm);
                    tm.Commit();
                }
                catch (Exception ex)
                {
                    tm.Rollback();
                    var status = context.IsChangeBalance ? OrderStatus.Exception : OrderStatus.Fail;
                    await _betDetailMo.PutOrderStatusByPKAsync(betId, (int)status, tm);
                    throw;
                }
                return await BuildDto(context, balance);
            }
        }
        public async Task PutPool(BetContext context, long changeAmount, TransactionManager tm)
        {
            var beforeAmount = await _poolReturnMo.GetPoolValByPKAsync(context.OperatorId, context.CurrencyId, tm);
            await _poolReturnMo.PutByPKAsync(context.OperatorId, context.CurrencyId, $"PoolVal=PoolVal+{changeAmount}", tm);
            var afterAmount = await _poolReturnMo.GetPoolValByPKAsync(context.OperatorId, context.CurrencyId, tm);
            await _poolChangeMo.AddAsync(new All_pool_change_detailEO
            {
                ChangeID = SnowflakeIdUtil.NextId(),
                AppID = context.AppId,
                OperatorID = context.OperatorId,
                CurrencyID = context.CurrencyId,
                BetID = context.BetId,
                UserID = context.UserId,
                BeforeAmount = beforeAmount,
                ChangeAmount = changeAmount,
                AfterAmount = afterAmount,
                RecDate = DateTime.UtcNow,
            }, tm);

        }

        private async Task ExecuteContext(BetContext context)
        {
            await new BetInitProcess().Execute(context);
            await new BetProcess().Execute(context);

        }

        private async Task<BetDto> BuildDto(BetContext context, long balance)
        {
            var ret = new BetDto();
            ret.PlayerInfo.Balance = balance.AToM(context.CurrencyId);
            ret.ResultInfo = context.ResultInfo;
            return ret;
        }

    }
}