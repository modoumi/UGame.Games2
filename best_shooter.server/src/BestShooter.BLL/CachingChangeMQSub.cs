/*using Xxyy.Common.MQ;
using Xxyy.GameEAPI.Caching;
using Xxyy.MQ.Admin;

namespace BestShooter.BLL
{
    public class CachingChangeMQSub : XxyySubConsumer<CachingChangeMsg>
    {
        protected override bool IsBroadcast => true;
        public CachingChangeMQSub()
        {
            RegisterAction(ClearCaching);
        }
        private async Task ClearCaching(CachingChangeMsg message, CancellationToken cancellationToken)
        {
            if (string.IsNullOrEmpty(message.TableName) || message.TableName.StartsWith("s_"))
                DbCacheUtil.Clear();
        }
    }
}
*/