using Microsoft.Extensions.Configuration;
using Xxyy.GameEAPI;

namespace BestShooter.BLL
{
    public class GameSection : GameSectionBase
    {
        public override void Bind(IConfiguration configuration)
        {
            base.Bind(configuration);
        }
    }
}
