using BestShooter.BLL.Caching;
using BestShooter.DAL;
using System.Diagnostics;
using TinyFx.Configuration;

namespace BestShooter.BLL.Common
{
    public class DCacheServices
    {
        //球星缓存
        private StarDCache _starDCache = new();
        //球星中奖几率缓存
        private StarOddsDCache _starOddsDCache = new();
        //jackpot奖励几率缓存
        private JackpotOddsDCache _jackpotOddsDCache = new();
        //全局随机数服务
        private GenerateRandomService _generateRandom = new();
        //用户缓存
        private AppUserDCache _appUserDCache;
        //用户Id
        private string _userId;

        public DCacheServices(string userId)
        {
            _appUserDCache = new AppUserDCache(userId);
            _userId = userId;
        }

        /// <summary>
        /// 获取一个随机球星
        /// </summary>
        /// <returns></returns>
        public async Task<Bs_config_starEO> GetRandomStar()
        {
            //获取所有球星
            List<Bs_config_starEO> allStars = (await _starDCache.GetOrLoadAsync(await _appUserDCache.GetCurrencyIdAsync())).Value;

            //生成1<= n <= 3之间的随机数
            var randomInt = _generateRandom.NextInt(1, 4);

            var star = new Bs_config_starEO();

            return allStars.Where(d => d.StarID == randomInt).FirstOrDefault();
        }

        /// <summary>
        /// 获取所有球星
        /// </summary>
        /// <returns></returns>
        public async Task<List<Bs_config_starEO>> GetAllStars(string operatorId)
        {
            return (await _starDCache.GetOrLoadAsync(operatorId)).Value;
        }

        /// <summary>
        /// 获取所有球星位置、倍数
        /// </summary>
        /// <returns></returns>
        public async Task<List<Bs_config_star_oddsEO>> GetAllStarOdds(string operatorId)
        {
            var starOddsDCache = await _starOddsDCache.GetOrLoadAsync(operatorId);
            if (starOddsDCache.HasValue)
                return starOddsDCache.Value;
            return new List<Bs_config_star_oddsEO>();
        }

        /// <summary>
        /// 获取当前随机球星中奖几率
        /// </summary>
        /// <returns></returns>
        public async Task<List<Bs_config_star_oddsEO>> GetStarOdds(Bs_config_starEO starEoIpo = null)
        {
            var starEo = starEoIpo ?? await GetRandomStar();

            var allStarOdds = (await _starOddsDCache.GetOrLoadAsync(await _appUserDCache.GetCurrencyIdAsync())).Value;

            return allStarOdds.Where(d => d.StarID.Equals(starEo.StarID)).ToList();
        }
        /// <summary>
        /// 获取jackpot奖励几率
        /// </summary>
        /// <returns></returns>
        public async Task<List<Bs_config_jackpot_oddsEO>> GetAllJackpotOdds()
        {
            var jackpotOddsDCache = await _jackpotOddsDCache.GetOrLoadAsync(await _appUserDCache.GetCurrencyIdAsync());

            if (jackpotOddsDCache.HasValue)
                return jackpotOddsDCache.Value;

            return new List<Bs_config_jackpot_oddsEO>();
        }

    }
}
