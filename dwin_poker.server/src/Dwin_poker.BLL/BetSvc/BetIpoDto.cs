using Dwin_poker.BLL.LoadSvc;

namespace Dwin_poker.BLL
{
    public class BetIpo
    {
        public string UserId { get; set; }
        public string CurrencyId { get; set; }
        public int ChipsId { get; set; }
        public double Multi { get; set; }
        public int Type { get; set; }
    }
    public class BetDto
    {
        public PlayerInfo PlayerInfo { get; set; } = new();
        public ResultInfo ResultInfo { get; set; } = new();
        public JPInfo JpInfo { get; set; } = new();
    }

    public class ResultInfo
    {
        public GameInfo GameInfo { get; set; } = new();
        public int Card { get; set; }
        public JpRewardInfo JpRewardInfo { get; set; } = new();
    }

    public class JpRewardInfo
    {
        public bool IsTriggerJpReward { get; set; }
        public int JpRewardIndex { get; set; }
        public decimal JpReward { get; set; }
    }
}