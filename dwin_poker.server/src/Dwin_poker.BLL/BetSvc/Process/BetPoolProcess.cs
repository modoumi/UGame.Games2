using Dwin_poker.BLL.Caching;

namespace Dwin_poker.BLL.BetSvc.Process
{
    internal class BetPoolProcess : IBetProcess
    {
        public Task Execute(BetContext context)
        {
            var config = MemoryUtil.GetConfig(context.OperatorId, context.CurrencyId);
            var partAmount = context.PartAmount;
            partAmount.PartJpAmount = (long)(config.JPRatio * context.UserDataDo.BetTotalAmount);
            partAmount.PartIncomeAmount = (long)(config.IncomeRatio * context.UserDataDo.BetTotalAmount);
            partAmount.PartRankAmount = (long)(config.RankRatio * context.UserDataDo.BetTotalAmount);
            partAmount.PartBaseAmount = context.UserDataDo.BetTotalAmount - partAmount.PartJpAmount - partAmount.PartIncomeAmount - partAmount.PartRankAmount;

            if (partAmount.PartBaseAmount < 0)
            {
                throw new Exception("配置PartBaseRatio等数据异常");
            }
            return Task.CompletedTask;
        }
    }
}