using Dwin_poker.BLL.LoadSvc;

namespace Dwin_poker.BLL
{
    public class CollectIpo
    {
        public string UserId { get; set; }
        public string CurrencyId { get; set; }
    }
    public class CollectDto
    {
        public PlayerInfo PlayerInfo { get; set; } = new();
        public GameInfo GameInfo { get; set; } = new();
        public List<History> historyList { get; set; } = new();
        public JPInfo JpInfo { get; set; } = new();
    }
}