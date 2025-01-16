namespace Mines.BLL
{
    internal class BetInitProcess : IBetProcess
    {
        public Task Execute(BetContext context)
        {
            var config = context.Config;
            var partAmount = context.PartAmount;
            partAmount.PartIncomeAmount = (long)(config.IncomeRatio * context.UserExt.BetBaseAmount);
            partAmount.PartBaseAmount = context.UserExt.BetBaseAmount - partAmount.PartIncomeAmount;
            if (partAmount.PartBaseAmount < 0)
            {
                throw new Exception("配置PartBaseRatio等数据异常");
            }
            return Task.CompletedTask;
        }
    }


}