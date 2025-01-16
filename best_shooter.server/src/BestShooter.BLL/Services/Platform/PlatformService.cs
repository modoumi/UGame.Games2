using BestShooter.BLL.Caching;

namespace BestShooter.BLL.Services.platform
{
    public class PlatformService
    {
        //用户缓存
        private AppUserDCache _appUserDCache;

        private string _userId;
        public PlatformService(string userId)
        {
            _userId = userId;
            _appUserDCache = new AppUserDCache(userId);
        }
    }
}
