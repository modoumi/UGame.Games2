using BestShooter.BLL.Caching;
using Dwin_poker.DAL;
using TinyFx.Data;
using TinyFx.SnowflakeId;
using TinyFx.Extensions.RabbitMQ;
using TinyFx.Logging;

namespace Dwin_poker.BLL.BetSvc.Process
{
    internal interface IBetProcess
    {
        Task Execute(BetContext context);
    }

    internal abstract class BetProcessBase : IBetProcess
    {
        private Dwp_pool_jackpotMO _poolJPMo = new();
        private Dwp_pool_returnMO _poolReturnMo = new();
        private readonly All_pool_change_detailMO _poolChangeMo = new();

        public abstract Task Execute(BetContext context);
        protected async Task<bool> CheckPoolReturn(BetContext context, long changeAmount)
        {
            var tm = new TransactionManager();
            try
            {
                var beforeAmount = (await _poolReturnMo.GetByPKAsync(context.OperatorId, context.CurrencyId, tm, true)).PoolVal;
                var afterAmount = beforeAmount - changeAmount;
                if (afterAmount < 0)
                {
                    tm.Rollback();
                    return false;
                }
                await _poolReturnMo.PutPoolValByPKAsync(context.OperatorId, context.CurrencyId, afterAmount, tm);
                await _poolChangeMo.AddAsync(new All_pool_change_detailEO
                {
                    ChangeID = SnowflakeIdUtil.NextId(),
                    AppID = context.AppId,
                    OperatorID = context.OperatorId,
                    CurrencyID = context.CurrencyId,
                    BetID = context.BetId,
                    UserID = context.UserId,
                    BeforeAmount = beforeAmount,
                    ChangeAmount = -changeAmount,
                    AfterAmount = afterAmount,
                    RecDate = DateTime.UtcNow,
                }, tm);
                tm.Commit();
                return true;
            }
            catch (Exception ex)
            {
                tm.Rollback();
                LogUtil.Error(ex, $"CheckPoolReturn检查锁定奖金池时异常! userId:{context.UserId}");
                return false;
            }
        }

        protected async Task<bool> CheckPoolJP(BetContext context, long winAmount)
        {
            var tm = new TransactionManager();
            try
            {
                var poolJPValue = (await _poolJPMo.GetByPKAsync(context.OperatorId, context.CurrencyId, tm, true)).PoolVal;
                if (poolJPValue - winAmount < 0)
                {
                    tm.Rollback();
                    return false;
                }
                await _poolJPMo.PutPoolValByPKAsync(context.OperatorId, context.CurrencyId, poolJPValue - winAmount, tm);
                tm.Commit();
                return true;
            }
            catch (Exception ex)
            {
                tm.Rollback();
                LogUtil.Error(ex, $"CheckPoolJP检查锁定JP奖金池时异常! userId:{context.UserId}");
                return false;
            }
        }

        /// <summary>
        /// JP奖池发送MQ
        /// </summary>
        /// <param name="countryId"></param>
        /// <returns></returns>
        /*private async Task SyncJackpot(BetContext context, long poolJPValue)
        {
            //获取上次同步JP奖池时间
            var field = SyncJackpotTimeDCache.GetFieldAsync(context.CurrencyId);
            var syncJackpotTimeDCache = new SyncJackpotTimeDCache();
            var preSendMqTime = await syncJackpotTimeDCache.GetOrLoadAsync(field);

            //如果缓存中没有上次发送MQ时间，或上次发送时间+时间间隔小于当前时间
            //则发送MQ，并更新
            if (preSendMqTime.HasValue && (preSendMqTime.Value == DateTime.MinValue || preSendMqTime.Value.AddMinutes(5) < DateTime.UtcNow))
            {
                var msg = new SyncJackpotMsg()
                {
                    OperatorId = context.OperatorId,
                    CountryId = context.CurrencyId,
                    CurrencyId = context.CurrencyId,
                    AppId = context.AppId,
                    Jackpot = poolJPValue
                };
                await MQUtil.PublishAsync<SyncJackpotMsg>(msg);
                await syncJackpotTimeDCache.GetOrLoadAsync(field, true);
            }
            return;
        }*/
    }
}
