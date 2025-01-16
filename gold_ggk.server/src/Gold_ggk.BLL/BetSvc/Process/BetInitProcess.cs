using Gold_ggk.BLL.Caching;

namespace Gold_ggk.BLL.BetSvc.Process
{
    internal class BetInitProcess : IBetProcess
    {
        public Task Execute(BetContext context)
        {
            var config = MemoryUtil.GetConfig(context.OperatorId, context.CurrencyId);
            context.IncomeRatio = config.IncomeRatio;
            var partAmount = context.PartAmount;
            partAmount.PartIncomeAmount = (long)(config.IncomeRatio * context.Config_Chips.BetAmount);
            partAmount.PartBaseAmount = context.Config_Chips.BetAmount - partAmount.PartIncomeAmount;

            if (partAmount.PartBaseAmount < 0)
            {
                throw new Exception("配置PartBaseRatio等数据异常");
            }
            return Task.CompletedTask;
        }
    }


}