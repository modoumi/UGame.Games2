using BestShooter.BLL.Services.UserDCaches;
using BestShooter.DAL;
using System.Text.Json.Serialization;
using TinyFx.Extensions.AutoMapper;

namespace BestShooter.BLL
{

    #region Ipo
    /// <summary>
    /// 踢球Ipo
    /// </summary>
    public class BetIpo
    {
        /// <summary>
        /// 下注总额（this.Bet * this.BetMultiple）
        /// </summary>
        public decimal TotalBet { get; set; }

        /// <summary>
        /// 赌注
        /// </summary>
        public decimal Bet { get; set; }

        /// <summary>
        /// 赌注倍数
        /// </summary>
        public decimal BetMultiple { get; set; }

        /// <summary>
        /// 位置
        /// </summary>
        public int place { get; set; }

        /// <summary>
        /// 位置对应的倍数
        /// </summary>
        public decimal PlaceMultiple { get; set; }

        /// <summary>
        /// 程序内部使用，用户id
        /// </summary>
        [JsonIgnore]
        public string UserId { get; set; }

        /// <summary>
        /// gbs_Order表OrderID
        /// </summary>
        [JsonIgnore]
        public string OrderID { get; set; } = Guid.NewGuid().ToString();

        /// <summary>
        /// gbs_bet_order.BetOrderID
        /// </summary>
        [JsonIgnore]
        public string BetOrderID { get; set; } = Guid.NewGuid().ToString();

        /// <summary>
        /// gbs_raffle_order.RaffleOrderID
        /// </summary>
        [JsonIgnore]
        public string RaffleOrderID { get; set; } = Guid.NewGuid().ToString();

        /// <summary>
        /// 国家编码
        /// </summary>
        public string OperatorID { get; set; }

        /// <summary>
        /// 当前奖池数据
        /// </summary>
        public Bs_pool_jackpotEO JackpotPool { get; set; }

    }

    #endregion

    #region Dto
    public class BetDto : IMapFrom<UserDCache>
    {
        /// <summary>
        /// 是否进球
        /// </summary>
        public bool IsWin { get; set; }
        /// <summary>
        /// 上一次下注结果金额
        /// </summary>
        public decimal PreResultAmount { get; set; }
        /// <summary>
        /// 中奖金额（不包含JP奖金）
        /// </summary>
        public decimal WinAmount { get; set; }
        /// <summary>
        /// 上一次赌注基础金额
        /// </summary>
        public decimal PreBaseBet { get; set; }
        /// <summary>
        /// 上一次赌注金额
        /// </summary>
        public decimal PreBet { get; set; }
        /// <summary>
        /// 上一次下注加倍数
        /// </summary>
        public decimal PreBetMultiple { get; set; }
        /// <summary>
        /// Lucky值
        /// </summary>
        public int LuckyValue { get; set; }
        /// <summary>
        /// lucky抽奖阈值
        /// </summary>
        public int luckyValueLimit { get; set; }
        /// <summary>
        /// 是否可触发Lucky抽奖
        /// </summary>
        public bool IsTriggerLuck { get; set; }
        /// <summary>
        /// Goal进度
        /// </summary>
        public int GoalProgress { get; set; }
        /// <summary>
        /// Goal最大值
        /// </summary>
        public int MaxGoal { get; set; }
        /// <summary>
        /// 用户账户余额
        /// </summary>
        public decimal Balance { get; set; }
        /// <summary>
        /// 是否惊喜奖励
        /// </summary>
        public bool IsSurprise { get; set; }
        /// <summary>
        /// 是否强制结算
        /// </summary>
        public bool IsCollect { get; set; }
        /// <summary>
        /// Jackpot奖池金额
        /// </summary>
        public decimal JackpotAmount { get; set; }
        /// <summary>
        /// Jackpot抽奖是否中奖
        /// </summary>
        public bool IsWinJackpot { get; set; }
        /// <summary>
        /// Jackpot奖励金额
        /// </summary>
        public decimal JackpotRaffleAmount { get; set; }
        /// <summary>
        /// 上一个球星id
        /// </summary>
        public int PreStarID { get; set; }
        /// <summary>
        /// 当前是第几次踢球
        /// </summary>
        public int SumBetNum { get; set; }
        /// <summary>
        /// 最大下注值
        /// </summary>
        public decimal MaxStake { get; set; }
        /// <summary>
        /// 国家编码
        /// </summary>
        public string CountryId { get; set; }
        /// <summary>
        /// 当前用户Jackpot累计值
        /// </summary>
        public decimal JackpotValue { get; set; }
        /// <summary>
        /// 触发Jackpot抽奖阈值
        /// </summary>
        public decimal JackpotCfgValue { get; set; }
        /// <summary>
        /// 是否触发Jackpot抽奖
        /// </summary>
        public bool IsTriggerJackpotRaffle { get; set; }
        /// <summary>
        /// 用户基础下注额
        /// </summary>
        public decimal BaseBet { get; set; }

        public void MapFrom(UserDCache source)
        {

        }
    }

    #endregion

}
