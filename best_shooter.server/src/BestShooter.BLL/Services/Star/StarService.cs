using BestShooter.BLL.BetSvc;
using BestShooter.BLL.Caching;
using BestShooter.BLL.Common;
using BestShooter.DAL;

namespace BestShooter.BLL.Services.Star
{
    public class StarService
    {
        //球星缓存
        private StarDCache _starDCache = new();
        //随机数服务
        private GenerateRandomService _generateRandomService = new();

        /// <summary>
        /// 获取一个随机球星
        /// </summary>
        /// <returns></returns>
        public async Task<Bs_config_starEO> GetOneRandomStar(string operatorId)
        {
            var starList = (await _starDCache.GetOrLoadAsync(operatorId)).Value;

            if (starList == null || !starList.Any())
                throw new Exception($"未找到{operatorId}的球星配置数据");

            var random = 0;

            do
            {
                random = _generateRandomService.NextInt(starList.Min(d => d.StarID), starList.Max(d => d.StarID) + 1);

            } while (!starList.Any(d => d.StarID == random));

            var star = starList.Where(d => d.Status == 1 && d.OperatorID.Equals(operatorId) && d.StarID == random).FirstOrDefault();

            return star;
        }

        /// <summary>
        /// 计算下注是否进球
        /// </summary>
        /// <param name="starEo">用户选中的球星</param>
        /// <param name="starOddsEoList">球星对应的中奖几率数据</param>
        /// <param name="betAmount">下注金额</param>
        /// <returns></returns>
        public async Task<BetOddsResult> CalculationBetResult(Bs_config_starEO starEo, List<Bs_config_star_oddsEO> starOddsEoList, decimal betAmount)
        {
            var result = new BetOddsResult();

            //中奖几率随机数
            var random = _generateRandomService.NextInt(1, 100001);

            var startNum = 1;
            foreach (var item in starOddsEoList)
            {
                if (random >= startNum && random <= (item.Odds + startNum - 1))
                {
                    result.WinAmount = (long)(betAmount * ((decimal)item.Multiple / 100));
                    //判断是否为惊喜奖励
                    if (item.Surprise == 1)
                        result.IsSurprise = true;
                    break;
                }
                startNum += item.Odds;
            }

            if (result.WinAmount > 0)
                result.IsWin = true;

            return result;
        }


    }
}
