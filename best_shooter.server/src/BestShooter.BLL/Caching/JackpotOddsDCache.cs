using BestShooter.DAL;
using Google.Protobuf.WellKnownTypes;
using TinyFx.Caching;
using TinyFx.Collections;
using TinyFx.Extensions.StackExchangeRedis;

namespace BestShooter.BLL.Caching
{
    /// <summary>
    /// Jackpot奖励倍数几率缓存
    /// </summary>
    public class JackpotOddsDCache : RedisHashExpireClient<List<Bs_config_jackpot_oddsEO>>
    {
        private const int EXPIRE_MINUTES = 1;

        /// <summary>
        /// 
        /// </summary>
        public JackpotOddsDCache()
        {
            RedisKey = GetProjectRedisKey();
        }

        protected override async Task<CacheValue<CacheItem<List<Bs_config_jackpot_oddsEO>>>> LoadValueWhenRedisNotExistsAsync(string field)
        {
            var ret = new Bs_config_jackpot_oddsMO().GetSort("OperatorID = @OperatorID", "BetAmount", field);

            if (ret == null || !ret.Any())
                ret = new Bs_config_jackpot_oddsMO().GetSort("OperatorID = '' or OperatorID = null", "BetAmount");

            if (ret == null || !ret.Any())
                throw new Exception($"gbs_jackpot_odds中OperatorID不存在。OperatorID:{field}");

            var result = new CacheValue<CacheItem<List<Bs_config_jackpot_oddsEO>>>();
            result.Value = new CacheItem<List<Bs_config_jackpot_oddsEO>>(ret);
            result.Value.SetExpire(TimeSpan.FromDays(EXPIRE_MINUTES));
            result.HasValue = ret != null && ret.Any();

            return result;
        }
    }

}
