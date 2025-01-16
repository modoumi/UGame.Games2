using Xxyy.GameEAPI;

namespace Gold_ggk.BLL
{
    public class GameServer : GameServerBase<GameSection>
    {
        protected override Task DoStartAsync(CancellationToken stoppingToken)
        {
            return Task.CompletedTask;
        }

        protected override Task DoStopAsync(CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}
