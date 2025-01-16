using BestShooter.DAL;
using Google.Protobuf.WellKnownTypes;
using TinyFx.Caching;
using TinyFx.Extensions.StackExchangeRedis;

namespace BestShooter.BLL.Caching
{
    /// <summary>
    /// gbs_star_odds缓存
    /// </summary>
    public class StarOddsDCache : RedisHashExpireClient<List<Bs_config_star_oddsEO>>
    {
        private const int EXPIRE_MINUTES = 1;

        public StarOddsDCache()
        {
            RedisKey = GetProjectRedisKey();
        }

        protected override async Task<CacheValue<CacheItem<List<Bs_config_star_oddsEO>>>> LoadValueWhenRedisNotExistsAsync(string field)
        {
            var ret = new Bs_config_star_oddsMO().GetSort("OperatorID = @OperatorID", "StarID", field);

            if (ret == null || !ret.Any())
                ret = new Bs_config_star_oddsMO().GetSort("OperatorID = '' or OperatorID = null", "StarID");

            if (ret == null || !ret.Any())
                throw new Exception($"gbs_star_odds中OperatorID不存在。OperatorID:{field}");
            var result = new CacheValue<CacheItem<List<Bs_config_star_oddsEO>>>
            {
                Value = new CacheItem<List<Bs_config_star_oddsEO>>(ret)
            };
            result.Value.SetExpire(TimeSpan.FromDays(EXPIRE_MINUTES));
            result.HasValue = ret != null && ret.Any();
            return result;
        }
    }

}
