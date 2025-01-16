namespace Mines.BLL
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
        public Meta Meta { get; set; } = new();
    }

    public class PlayerInfo
    {
        public decimal Balance { get; set; }
    }

    public class GameInfo
    {
        public decimal BaseBet { get; set; } //游戏下注金额
        public int Mines { get; set; }//选择的地雷总数
        public decimal Win { get; set; }//总共赢的钱数
        public List<CellInfo> CellInfo { get; set; } = new();
        public int GameStatus { get; set; } //1-进行中, 2-已结束
        public double CurRate { get; set; } //当前赔率
        public double NextRate { get; set; } //下次赔率
    }

    public class CellInfo
    {
        public int Id { get; set; }//
        public int IsOpen { get; set; }//1-开
        public int Type { get; set; }//1-钻石, 2-炸弹
    }

    public class Meta
    {
        public int MinMine { get; set; }
        public int MaxMine { get; set; }
        public decimal MinBet { get; set; }
        public decimal MaxBet { get; set; }
    }
}