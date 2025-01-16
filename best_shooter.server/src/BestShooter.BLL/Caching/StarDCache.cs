using BestShooter.DAL;
using Google.Protobuf.WellKnownTypes;
using TinyFx.Caching;
using TinyFx.Extensions.StackExchangeRedis;

namespace BestShooter.BLL.Caching
{
    public class StarDCache : RedisHashExpireClient<List<Bs_config_starEO>>
    {
        private const int EXPIRE_MINUTES = 1;

        public StarDCache()
        {
            RedisKey = GetProjectRedisKey();
        }

        protected override async Task<CacheValue<CacheItem<List<Bs_config_starEO>>>> LoadValueWhenRedisNotExistsAsync(string field)
        {
            var ret = new Bs_config_starMO().GetSort("OperatorID = @OperatorID", "StarID", field);

            if (ret == null || !ret.Any())
                ret = new Bs_config_starMO().GetSort("OperatorID = '' or OperatorID = null", "StarID");

            if (ret == null || !ret.Any())
                throw new Exception($"gbs_star中OperatorID不存在。OperatorID:{field}");
            var result = new CacheValue<CacheItem<List<Bs_config_starEO>>>();
            result.Value = new CacheItem<List<Bs_config_starEO>>(ret);
            result.Value.SetExpire(TimeSpan.FromDays(EXPIRE_MINUTES));
            result.HasValue = ret != null && ret.Any();
            return result;
        }
    }

}
