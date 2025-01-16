namespace Dwin_poker.BLL
{
    public class LoadIpo
    {
        public string UserId { get; set; }
        public string CurrencyId { get; set; }
    }
    public class LoadDto
    {
        public PlayerInfo PlayerInfo { get; set; } = new();
        public GameInfo GameInfo { get; set; } = new();
        public int BetResetStatus { get; set; }
        public List<History> HistoryList { get; set; } = new();
        public JPInfo JpInfo { get; set; } = new();
        public PokerMeta Meta { get; set; } = new();
    }

    public class PlayerInfo
    {
        public decimal Balance { get; set; }
    }

    public class GameInfo
    {
        public long OriChipsId { get; set; } //上一次的第一轮基础下注ID
        public int RoundIdx { get; set; }//游戏轮数，每bet一次+1
        public int CardIdx { get; set; }//卡牌idx，每轮只抽10张牌，抽完或gameStatus>0时重新洗牌，cardIdx归0
        public decimal BaseBet { get; set; }//上一轮的基础下注
        public double Multi { get; set; }//上一轮的倍数
        public decimal TotalBet { get; set; }//上一轮总下注
        public decimal BetResult { get; set; }//上一轮结果，赢了就是totalBet*2，输了就是0
        public int GameStatus { get; set; }//游戏状态，初始为0，roundIdx>0时，需要判断4种状态，1-star达到最大，2-betResult达到maxBet，3-balance小于baseBet，4-balance小于betJpBonus中最小的下注值
        public int Star { get; set; }//星星数

    }

    public class History
    {
        public int Card { get; set; }
        public bool IsTriggerJpReward { get; set; }
        public decimal BetResult { get; set; }
    }

    public class JPInfo
    {
        public decimal Value { get; set; }

    }
    public class PokerMeta
    {
        public List<Chips> ChipsList { get; set; } = new();
        public int MaxStar { get; set; }
        public decimal MaxBet { get; set; }
        public decimal RankReward { get; set; }

    }

    public class Chips
    {
        public int ChipsId { get; set; }
        public decimal Bet { get; set; }
        public List<decimal> JpRewardList { get; set; } = new();
    }
}