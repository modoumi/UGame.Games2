using Mines.BLL.LoadSvc;

namespace Mines.BLL
{
    public class BetIpo
    {
        public string UserId { get; set; }
        public string CurrencyId { get; set; }
        public int CellId { get; set; }
    }
    public class BetDto
    {
        public PlayerInfo PlayerInfo { get; set; } = new();
        public ResultInfo ResultInfo { get; set; } = new();
    }
}