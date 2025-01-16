using BestShooter.DAL;
using TinyFx.Data;

namespace BestShooter.BLL.Services.MainPool
{
    public class MainPoolService
    {
        private Bs_pool_returnMO _poolReturnMo = new();

        /*  protected async Task<bool> CheckPoolReturn(BetContext context, long winAmount)
          {
              var tm = new TransactionManager();
              try
              {
                  var poolValue = (await _poolReturnMo.GetByPKAsync(context.OperatorId, context.CurrencyId, tm, true)).PoolVal;
                  if (poolValue - winAmount < 0)
                  {
                      tm.Rollback();
                      return false;
                  }
                  await _poolReturnMo.PutAmountAsync(context.OperatorId, context.CurrencyId, poolValue - winAmount, tm);

                  tm.Commit();
                  return true;
              }
              catch (Exception ex)
              {
                  tm.Rollback();
                  LogUtil.Error(ex, $"CheckPoolReturn检查锁定奖金池时异常! userId:{context.UserId}");
                  return false;
              }
          }*/
        /// <summary>
        /// 获取一条主奖池数据
        /// </summary>
        /// <param name="operatorId"></param>
        /// <returns></returns>
        public async Task<Bs_pool_returnEO> GetByOperatorIDAsync(string operatorId = null, TransactionManager tm = null)
        {
            return (await _poolReturnMo.GetByOperatorIDAsync(operatorId, tm)).FirstOrDefault();
        }

        /// <summary>
        /// 下注进球后，更新主奖池金额
        /// </summary>
        /// <returns></returns>
        public async Task<bool> PutMainPool(long amount, string operatorId, string currencyId, TransactionManager tm = null)
        {
            return (await _poolReturnMo.PutByPKAsync(operatorId, currencyId, $"Amount = Amount + {amount}", tm) > 0);
        }

    }
}
