using Dragon_tower.DAL;
using TinyFx.Data;
using TinyFx.SnowflakeId;
using TinyFx.Logging;

namespace Dragon_tower.BLL
{
    internal interface IBetProcess
    {
        Task Execute(BetContext context);
    }

    internal abstract class BetProcessBase : IBetProcess
    {
        private readonly Gdt_pool_returnMO _poolReturnMo = new();
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
    }
}
