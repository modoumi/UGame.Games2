using BestShooter.BLL.Caching;
using BestShooter.BLL.Common;
using BestShooter.DAL;
using TinyFx.Data;
using Xxyy.Common.Caching.Partner;

namespace BestShooter.BLL.Services.Jackpot
{
    public class JackpotService
    {
        //gbs_jackpotMo
        private Bs_pool_jackpotMO _jackpotPoolMo = new();
        //Jackpot奖池概率
        private JackpotOddsDCache _jackpotOddsDCache = new();
        //随机数服务
        private GenerateRandomService _generateRandomService = new();
        /// <summary>
        /// 计算Jakcpot是否中奖、金额
        /// </summary>
        /// <param name="appToken">登录信息</param>
        /// <param name="userExEo"></param>
        /// <param name="jackpot">所有奖池数据</param>
        /// <param name="baseBet">用户基础下注额，即第一次下注时选择的金额</param>
        /// <param name="bet">当前下注额</param>
        /// <returns></returns>
        public async Task<JackpotRaffleResult> CalcJpOdds(AppLoginTokenDO appToken,
                                                        Bs_user_extEO userExEo,
                                                        Bs_pool_jackpotEO jackpot,
                                                        long baseBet,
                                                        long bet)
        {
            var result = new JackpotRaffleResult();

            var _config = MemoryUtil.GetConfig(appToken.OperatorId, appToken.CurrencyId);

            result.JackpotValue = (long)(bet * ((decimal)_config.InJackpot / 100));

            var nowJackpotValue = userExEo.JackpotValue + (long)(bet * ((decimal)_config.InJackpot / 100));

            //根据用户基础下注额、Jackpot累计值，获取可能出现奖金的概率集合
            var jackpotOddsListAsync = await _jackpotOddsDCache.GetOrLoadAsync(appToken.OperatorId);  
            
            List<Bs_config_jackpot_oddsEO> jackpotOddsList = jackpotOddsListAsync.Value.Where(d => d.OperatorID.Equals(appToken.OperatorId) && d.BetAmount == baseBet && nowJackpotValue >= d.StartNum && nowJackpotValue <= d.EndNum).OrderBy(d => d.BonusAmount).ToList();

            if (jackpotOddsList == null || !jackpotOddsList.Any())
                return new JackpotRaffleResult();

            //可能出现奖金的概率
            var random = _generateRandomService.NextInt(1, 100001);
            int startNum = 1;
            long bonusAmount = 0;

            foreach (var item in jackpotOddsList)
            {
                if (random >= startNum && random <= (item.Odds + startNum - 1))
                {
                    bonusAmount = item.BonusAmount;
                    break;
                }
                startNum += item.Odds;
            }

            //实际中奖概率
            var odds = Math.Round((decimal)(nowJackpotValue * ((decimal)_config.JackpotRaffleAfterTax / 100)) / bonusAmount, 4);
            //如果实际中奖概率大于1，并且JP奖池足够发放奖金
            if (odds > 1 && jackpot.Amount > bonusAmount)
            {
                result.IsWin = true;
                result.WinAmount = bonusAmount;
                return result;
            }

            //中奖随机数
            random = _generateRandomService.NextInt(1, 100001);

            if (random > 0 && random < (odds * 100000))
            {
                //中奖了
                result.IsWin = true;
                result.WinAmount = bonusAmount;
            }

            //奖池不够发奖，则不中奖
            if (bonusAmount > jackpot.Amount)
            {
                result = new JackpotRaffleResult();
            }

            return result;
        }

        /// <summary>
        /// 获取JP奖池
        /// </summary>
        /// <param name="operatorId"></param>
        /// <param name="currencyId"></param>
        /// <param name="tm"></param>
        /// <returns></returns>
        public async Task<Bs_pool_jackpotEO> GetJackpotPool(string operatorId, string currencyId, TransactionManager tm = null)
        {
            return await _jackpotPoolMo.GetSingleAsync("OperatorID = @OperatorID and CurrencyId = @CurrencyId", tm, operatorId, currencyId);
        }
        /// <summary>
        /// 扣减Jackpot奖池金额
        /// </summary>
        /// <param name="amount"></param>
        /// <param name="tm"></param>
        /// <returns></returns>
        public async Task<bool> UpdateJackpotAmount(Bs_pool_jackpotEO jackpotEo, TransactionManager tm = null)
        {
            return await _jackpotPoolMo.PutAsync(jackpotEo, tm) > 0;
        }

        /// <summary>
        /// 下注后更新gbs_jackpot_pool
        /// </summary>
        /// <param name="operatorId"></param>
        /// <param name="currencyId"></param>
        /// <param name="amount">主奖池扣减金额</param>
        /// <param name="tm"></param>
        /// <returns></returns>
        public async Task<bool> PutJPPool(long amount, string operatorId, string currencyId, TransactionManager tm = null)
        {
            return (await _jackpotPoolMo.PutByPKAsync(operatorId, currencyId, $"Amount = Amount + {amount}", tm) > 0);
        }
    }
}
