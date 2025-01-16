using Microsoft.Extensions.Hosting;

namespace BestShooter.BLL
{

    public static class BestShooterHostBuilderExtensions
    {
        public static IHostBuilder UseBestShooterServer(this IHostBuilder builder)
        {
            builder.UseXxyyCommonServer<BestShooterOptionsSection>();
            return builder;
        }
    }

}
