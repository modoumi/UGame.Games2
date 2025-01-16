using Dwin_poker.BLL.Caching;

namespace Dwin_poker.BLL.BetSvc.Process
{
    internal class BetInitProcess : IBetProcess
    {
        public Task Execute(BetContext context)
        {
            var config = MemoryUtil.GetConfig(context.OperatorId, context.CurrencyId);
            context.JPValTH = config.JPValTH;
            context.MaxStar = config.MaxStar;
            context.MaxCardNum = config.MaxCardNum;
            context.MaxBetAmount = config.MaxBetAmount;
            context.JPTotalRatio = config.JPTotalRatio;
            context.JPInventedAmount = config.JPInventedAmount;
            return Task.CompletedTask;
        }
    }
}