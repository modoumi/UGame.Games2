using Gold_ggk.BLL.LoadSvc;

namespace Gold_ggk.BLL.BetSvc
{
    public class BetIpo
    {
        public string UserId { get; set; }
        public string CurrencyId { get; set; }
        public int ChipsId { get; set; }
    }
    public class BetDto
    {
        public PlayerInfo PlayerInfo { get; set; } = new();
        public ResultInfo ResultInfo { get; set; } = new();
    }

    public class ResultInfo
    {
        public List<ResultNum> ResultNumList { get; set; } = new();
        /// <summary>
        /// 所有彩票的奖励总和
        /// </summary>
        public decimal TotalReward { get; set; }
        public GameInfo GameItemInfo { get; set; } = new();
        /// <summary>
        /// 彩票中奖数字
        /// </summary>
        public List<int> RewardNumList { get; set; } = new();
        public JpRewardInfo JpRewardInfo { get; set; } = new();
    }

    public class ResultNum
    {
        public int Num { get; set; }
        public int RewardType { get; set; }//1-基础奖金,2-jp奖金
        public int RewardIdx { get; set; }
    }
    public class JpRewardInfo
    {
        public bool IsTriggerJpReward { get; set; }
    }
}