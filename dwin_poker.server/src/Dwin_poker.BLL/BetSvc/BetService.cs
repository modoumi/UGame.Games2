using Dwin_poker.BLL.BetSvc.Process;
using Dwin_poker.DAL;
using TinyFx;
using TinyFx.Data;
using TinyFx.SnowflakeId;
using TinyFx.Extensions.StackExchangeRedis;
using Xxyy.GameEAPI.Common;
using Xxyy.GameEAPI.Common.Enum;
using Xxyy.GameEAPI.Core;
using Xxyy.GameEAPI.Services;

namespace Dwin_poker.BLL.BetSvc
{
    public class BetService : BaseApiGameService
    {
        private readonly Dwp_user_jphistoryMO _JphistoryMO = new();
        private readonly Dwp_bet_detailMO _betDetailMo = new();
        private readonly Dwp_pool_returnMO _poolReturnMo = new();
        private readonly Dwp_pool_jackpotMO _poolJpMo = new();
        private readonly Dwp_pool_rankMO _poolRankMo = new();
        private readonly All_pool_change_detailMO _poolChangeMo = new();
        public async Task<BetDto> Bet(BetIpo ipo)
        {
            await CheckIdentityAndMock(ipo.UserId);
            var appToken = GetLoginTokenDo(ipo.UserId) ?? throw new CustomException(CommonCodes.RS_TOKEN_EXPIRED, $"从redis获取token 超时,{ipo.UserId}");
            var context = new BetContext(ipo, appToken);
            context.NickName = await GameEAPIUtil.GetNickName(ipo.UserId);

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
                await PokerUtil.AddBetDetail(context, betId, null);

                var tm = new TransactionManager();
                try
                {
                    long winAmount = 0;
                    //插入JP记录 todo
                    if (context.ResultInfo.JpRewardInfo.IsTriggerJpReward)
                    {
                        winAmount = XxyyUtil.MToA(context.ResultInfo.JpRewardInfo.JpReward, context.CurrencyId);
                        await _JphistoryMO.AddAsync(new Dwp_user_jphistoryEO
                        {
                            HID = SnowflakeIdUtil.NextId(),
                            CurrencyID = context.CurrencyId,
                            UserID = context.UserId,
                            WinAmount = winAmount,
                            UserMobile = context.NickName,
                            RecDate = DateTime.UtcNow,
                        }, tm); ;
                    }
                    balance = (await GameEAPIUtil.BetWin(context.UserId, context.AppId, betId.ToString()
                          , context.UserDataDo.BetTotalAmount, context.UserDataDo.BetResultAmount + winAmount)).Balance;
                    context.IsChangeBalance = true;
                    //更新JP奖池跟基础奖池
                    await _poolJpMo.PutByPKAsync(context.OperatorId, context.CurrencyId, $"PoolVal=PoolVal+{context.PartAmount.PartJpAmount}", tm);
                    await PutPool(context, context.PartAmount.PartBaseAmount, tm);
                    await _poolRankMo.PutByPKAsync(context.OperatorId, context.CurrencyId, $"PoolVal=PoolVal+{context.PartAmount.PartRankAmount}", tm);
                    //更新下注表
                    await _betDetailMo.PutOrderStatusByPKAsync(betId, (int)OrderStatus.Success, tm);
                    //更新user_ext
                    await PokerUtil.PutUserExt(context.UserDataDo.Ext, tm);
                    //更新userRedis
                    context.UserRedis.SetUserDataDo(context.UserDataDo);

                    tm.Commit();
                }
                catch (Exception ex)
                {
                    tm.Rollback();
                    var status = context.IsChangeBalance ? OrderStatus.Exception : OrderStatus.Fail;
                    await _betDetailMo.PutOrderStatusByPKAsync(betId, (int)status, tm);
                    await context.UserRedis.KeyDeleteAsync();
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
        private async Task<BetDto> BuildDto(BetContext context, long balance)
        {
            var ret = new BetDto();
            ret.PlayerInfo.Balance = XxyyUtil.AToM(balance, context.CurrencyId);
            if (context.UserDataDo.Ext.Star >= context.MaxStar)
            {
                context.UserDataDo.GameStatus = GameStatus.MaxStar;
            }
            else if (context.MaxBetAmount < context.UserDataDo.BetResultAmount)
            {
                context.UserDataDo.GameStatus = GameStatus.MaxBet;
            }
            else if ((context.UserDataDo.BetResultAmount == 0 && balance < context.UserDataDo.BetBaseAmount) || (context.UserDataDo.BetResultAmount > 0 && balance < context.UserDataDo.BetTotalAmount))
            {
                context.UserDataDo.GameStatus = GameStatus.NoBalance;
            }
            else if (balance < context.Chips.BetBaseAmount)
            {
                context.UserDataDo.GameStatus = GameStatus.LessBaseBetAmount;
            }
            context.ResultInfo.GameInfo.GameStatus = (int)context.UserDataDo.GameStatus;
            ret.ResultInfo = context.ResultInfo;
            ret.JpInfo.Value = await PokerUtil.GetPoolValByPKAsync(context.OperatorId, context.CurrencyId);
            return ret;
        }

        private async Task ExecuteContext(BetContext context)
        {
            await new BetInitProcess().Execute(context);
            await new BetProcess().Execute(context);
            await new BetPoolProcess().Execute(context);
        }
    }
}