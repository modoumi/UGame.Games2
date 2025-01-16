using Microsoft.Extensions.Configuration;
using Xxyy.GameEAPI.Common;

namespace BestShooter.BLL
{
    public class BestShooterOptionsSection : AppSectionBase
    {
        #region 环境变量可配置

        private const string ENV_AppId = "ENV_AppId";

        private const string ENV_ServerType = "ENV_ServerType";

        private const string ENV_SyncJackpotIntervalTime = "ENV_SyncJackpotIntervalTime";

        /// <summary>
        /// 优先级：环境变量ENV_MarqueeLangKey > 配置文件
        /// </summary>
        public string AppId { get; set; }

        /// <summary>
        /// 优先级：环境变量ENV_MarqueeLangKey > 配置文件
        /// </summary>
        public string ServerType { get; set; }

        /// <summary>
        /// 同步JP奖池数据到大厅时间间隔，单位：minutes
        /// </summary>
        public string SyncJackpotIntervalTime { get; set; }

        #endregion

        public override void Bind(IConfiguration configuration)
        {
            base.Bind(configuration);

            // AppId
            var appId = Environment.GetEnvironmentVariable(ENV_AppId);
            if (!string.IsNullOrEmpty(appId))
                AppId = appId;

            // ServerType
            var serverType = Environment.GetEnvironmentVariable(ENV_ServerType);
            if (!string.IsNullOrEmpty(serverType))
                ServerType = serverType;

            // SyncJackpotIntervalTime
            var syncJackpotIntervalTime = Environment.GetEnvironmentVariable(ENV_SyncJackpotIntervalTime);
            if (!string.IsNullOrEmpty(syncJackpotIntervalTime))
                ServerType = syncJackpotIntervalTime;
        }

    }
}
