namespace Dragon_tower.BLL
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
        public int Level { get; set; }//选择的难度
        public decimal Win { get; set; }//总共赢的钱数

        public List<FloorInfo> FloorInfoList { get; set; } = new();
        public int GameStatus { get; set; } //1-进行中, 2-已结束
    }

    public class FloorInfo
    {
        public int Id { get; set; }//层数id
        public int OpenCellId { get; set; }//1-4为具体格子，0位未开
        public List<int> CellTypeList { get; set; } = new();
    }

    public class Meta
    {
        public List<LevelMeta> LevelMeta { get; set; } = new();
        public decimal MinBet { get; set; }
        public decimal MaxBet { get; set; }
    }

    public class LevelMeta
    {
        public int Level { get; set; }

        public int CellAmount { get; set; }

        public int MineAmount { get; set; }
    }
}