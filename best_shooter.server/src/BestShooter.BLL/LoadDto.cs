using BestShooter.BLL.Services.UserDCaches;
using BestShooter.DAL;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using TinyFx.Extensions.AutoMapper;
using Xxyy.GameEAPI.Common;

namespace BestShooter.BLL
{
    public class LoadDto : IMapFrom<UserDCache>
    {
        /// <summary>
        /// 上一次踢球结果
        /// </summary>
        public bool IsWin { get; set; } = false;
        /// <summary>
        /// 上一次下注结果金额
        /// </summary>
        public decimal PreResultAmount { get; set; }
        /// <summary>
        /// 中奖金额（不包含JP奖金）
        /// </summary>
        public decimal WinAmount { get; set; }
        /// <summary>
        /// 用户基础下注额
        /// </summary>
        public decimal BaseBet { get; set; }
        /// <summary>
        /// 上一次下注基础金额
        /// </summary>
        public decimal PreBaseBet { get; set; } = 0;
        /// <summary>
        /// 上一次下注金额
        /// </summary>
        public decimal PreBet { get; set; } = 0;
        /// <summary>
        /// 赌注倍数
        /// </summary>
        public decimal PreBetMultiple { get; set; }
        /// <summary>
        /// 用户当前lucky值
        /// </summary>
        public int LuckyValue { get; set; }
        /// <summary>
        /// lucky抽奖阈值
        /// </summary>
        public int LuckyValueLimit { get; set; }
        /// <summary>
        /// 是否可触发Lucky抽奖
        /// </summary>
        public bool IsTriggerLuck { get; set; }
        /// <summary>
        /// 目标进度
        /// </summary>
        public int GoalProgress { get; set; } = 0;
        /// <summary>
        /// 最大Goal值
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
        /// 当前第几次踢球，最小值为0
        /// </summary>
        public int SumBetNum { get; set; } = 0;

        /// <summary>
        /// 最大下注值
        /// </summary>
        public decimal MaxStake { get; set; }
        /// <summary>
        /// 国家编码
        /// </summary>
        public string CountryId { get; set; }
        /// <summary>
        /// 球星等级
        /// </summary>
        public int PreStarGrade { get; set; }
        /// <summary>
        /// 当前用户Jackpot累计值
        /// </summary>
        public decimal JackpotValue { get; set; }
        /// <summary>
        /// 触发Jackpot抽奖阈值
        /// </summary>
        public decimal JackpotCfgValue { get; set; }
        /// <summary>
        /// 是否触发了Jackpot抽奖
        /// </summary>
        public bool IsTriggerJackpotRaffle { get; set; }

        /// <summary>
        /// 所有球星球星位置、倍数
        /// </summary>
        public Dictionary<int, List<StarPositionMultiples>> starPositionMultiples { get; set; }
        /// <summary>
        /// 基础下注额对应的Jackpot奖金数据
        /// </summary>
        [DataMember(Order = 23)]
        public Dictionary<decimal, List<decimal>> BetAmountMapJackpotBonus { get; set; }

        public void MapFrom(UserDCache source)
        {

        }
    }

    /// <summary>
    /// 游戏初始化，球星位置、倍数缓存
    /// </summary>
    public class StarPositionMultiples : IMapFrom<Bs_config_star_oddsEO>
    {
        /// <summary>
        /// 键Key
        /// 【主键 varchar(50)】
        /// </summary>
        [JsonIgnore]
        [DataMember(Order = 1)]
        public int StarID { get; set; }
        /// <summary>
        /// 位置
        /// </summary>
        [DataMember(Order = 2)]
        public int Position { get; set; }
        /// <summary>
        /// 倍数（倍数值*100）
        /// </summary>
        [JsonIgnore]
        public int Multiple { get; set; }
        /// <summary>
        /// 倍数（实际值，保留两位小数）
        /// </summary>
        [DataMember(Order = 3)]
        public string Multiples { get; set; }

        public void MapFrom(Bs_config_star_oddsEO source)
        {
            Multiples = Math.Round((decimal)Multiple / 100, 2).ToString("0.00");
        }
    }

    /// <summary>
    /// 游戏初始化，基础下注额对应的Jackpot奖金数据
    /// </summary>
    public class BetAmountMapJackpotBonus : IMapFrom<Bs_config_jackpot_oddsEO>
    {

        /// <summary>
        /// 国家编码3位
        /// 【字段 varchar(5)】
        /// </summary>
        [JsonIgnore]
        [DataMember(Order = 1)]
        public string OperatorID { get; set; }
        /// <summary>
        /// 语言编码（小写）
        /// 【字段 varchar(20)】
        /// </summary>
        [JsonIgnore]
        [DataMember(Order = 2)]
        public string LangID { get; set; }
        /// <summary>
        /// 基础投注额（值*10000）
        /// 【字段 int】
        /// </summary>
        [DataMember(Order = 3)]
        public decimal BetAmount { get; set; }
        /// <summary>
        /// 奖金金额（值*10000）
        /// 【字段 int】
        /// </summary>
        [DataMember(Order = 4)]
        public decimal BonusAmount { get; set; }


        public void MapFrom(Bs_config_jackpot_oddsEO source)
        {
            BetAmount = source.BetAmount.AToM(source.CurrencyID);
            BonusAmount = source.BonusAmount.AToM(source.CurrencyID);
        }
    }

}
