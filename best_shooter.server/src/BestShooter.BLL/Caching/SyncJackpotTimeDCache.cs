using TinyFx.Caching;
using TinyFx.Extensions.StackExchangeRedis;

namespace BestShooter.BLL.Caching
{

    public class SyncJackpotTimeDCache : RedisHashExpireClient<DateTime>
    {


        public SyncJackpotTimeDCache()
        {
            RedisKey = GetProjectRedisKey();
        }

        public static string GetFieldAsync(string operatorId) => $"{operatorId}";


        protected override async Task<CacheValue<CacheItem<DateTime>>> LoadValueWhenRedisNotExistsAsync(string field)
        {
            var ret = new CacheValue<CacheItem<DateTime>>();
            ret.Value = new CacheItem<DateTime>(DateTime.UtcNow);
            ret.HasValue = true;
            return ret;
        }
    }
}
