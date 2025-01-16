using Microsoft.Extensions.Configuration;
using Xxyy.GameEAPI.Common;

namespace BestShooter.BLL.Common
{
    public class AppOptions : AppSectionBase
    {
        public override void Bind(IConfiguration configuration)
        {
            base.Bind(configuration);
        }
    }
}
