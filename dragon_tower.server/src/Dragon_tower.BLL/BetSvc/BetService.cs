using Dragon_tower.DAL;
using TinyFx;
using TinyFx.Data;
using TinyFx.SnowflakeId;
using TinyFx.Extensions.StackExchangeRedis;
using TinyFx.SnowflakeId;
using Xxyy.GameEAPI.Common;
using Xxyy.GameEAPI.Common.Enum;
using Xxyy.GameEAPI.Core;
using Xxyy.GameEAPI.Services;

namespace Dragon_tower.BLL
{
    public class BetService : BaseApiGameService
    {
        private readonly Gdt_user_extMO _extMO = new();
        private readonly Gdt_bet_detailMO _betDetailMo = new();
        private readonly Gdt_pool_returnMO _poolReturnMo = new();
        private readonly All_pool_change_detailMO _poolChangeMo = new();
        public async Task<BetDto> Bet(BetIpo ipo)
        {
            await CheckIdentityAndMock(ipo.UserId);
            var appToken = GetLoginTokenDo(ipo.UserId) ?? throw new CustomException(CommonCodes.RS_TOKEN_EXPIRED, $"从redis获取token 超时,{ipo.UserId}");
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
                long balance = 0;
                //算法逻辑
                await ExecuteContext(context);
                //先插入数据
                await GdtUtil.AddBetDetail(context, betId);

                var tm = new TransactionManager();
                try
                {
                    balance = await GameEAPIUtil.GetBalance(context.UserId, context.AppId);
                    var RealBetAmount = context.UserExt.FloorNum == 1 ? context.UserExt.BetBaseAmount : context.PreWinAmount;
                    if (balance < RealBetAmount)
                    {
                        throw new CustomException(CommonCodes.RS_NOT_ENOUGH_MONEY, "余额不足");
                    }
                    if (context.UserExt.FloorNum == 1)
                    {
                        balance = (await GameEAPIUtil.BetWin(context.UserId, context.AppId, betId.ToString()
                             , context.UserExt.BetBaseAmount, context.RealWinAmount)).Balance;
                        context.IsChangeBalance = true;
                        //更新基础奖池,第一次下注的时候增加奖池
                        await PutPool(context, context.PartAmount.PartBaseAmount, tm);
                    }
                    else
                    {
                        balance = (await GameEAPIUtil.BetWin(context.UserId, context.AppId, betId.ToString()
                           , context.PreWinAmount, context.RealWinAmount)).Balance;
                        context.IsChangeBalance = true;

                        //更新基础奖池,无税收
                        await PutPool(context, (long)(context.PreWinAmount * (1 - context.Config.IncomeRatio)), tm);
                    }
                    //更新下注表
                    await _betDetailMo.PutOrderStatusByPKAsync(betId, (int)OrderStatus.Success, tm);
                    //更新用户
                    await _extMO.PutAsync(context.UserExt, tm);

                    tm.Commit();
                }
                catch (Exception ex)
                {
                    tm.Rollback();
                    await BetRollback(context, betId, tm);
                    throw;
                }
                return await BuildDto(context, balance);
            }
        }
        private async Task PutPool(BetContext context, long changeAmount, TransactionManager tm)
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
        private async Task BetRollback(BetContext context, long betId, TransactionManager tm)
        {
            var status = context.IsChangeBalance ? OrderStatus.Exception : OrderStatus.Fail;
            await _betDetailMo.PutOrderStatusByPKAsync(betId, (int)status, tm);
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

            ret.ResultInfo.GameInfo.BaseBet = context.UserExt.BetBaseAmount.AToM(context.CurrencyId);
            ret.ResultInfo.GameInfo.Level = context.UserExt.LevelId;
            ret.ResultInfo.GameInfo.Win = context.UserExt.WinAmount.AToM(context.CurrencyId);
            ret.ResultInfo.GameInfo.GameStatus = context.UserExt.GameStatus;
            ret.ResultInfo.GameInfo.FloorInfoList = SerializerUtil.DeserializeJsonNet<List<FloorInfo>>(context.UserExt.FloorInfo);
            return ret;
        }

    }
}