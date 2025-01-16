namespace Gold_ggk.BLL.LoadSvc
{
    public class LoadIpo
    {
        public string UserId { get; set; }
        public string CurrencyId { get; set; }
    }
    public class LoadDto
    {
        public PlayerInfo PlayerInfo { get; set; } = new();
        public List<GameInfo> GameInfo { get; set; } = new();
        public GgkMeta Meta { get; set; } = new();
    }

    public class PlayerInfo
    {
        public decimal Balance { get; set; }
    }

    public class GameInfo
    {
        public decimal ChipsId { get; set; } //Chipsid
        public int FreeSpinCount { get; set; }//免费摇奖次数
        public int BetCounter { get; set; }//抽过多少次，到10清空，转换一次freeSpinCount

    }

    public class GgkMeta
    {
        public List<Chips> ChipsList { get; set; } = new();
    }

    public class Chips
    {
        public int ChipsId { get; set; }
        public decimal Bet { get; set; }
        public List<decimal> BetResultList { get; set; } = new();
        public List<decimal> JpBonusList { get; set; } = new();
        public decimal JpReward { get; set; }
        public decimal MaxReward { get; set; }
    }
}