namespace BestShooter.BLL.Services.UserDCaches
{
    public class UserDCache
    {
        /// <summary>
        /// 上一次win or lose
        /// </summary>
        public bool IsWin { get; set; }

        /// <summary>
        /// 上一次踢球结果金额（踢球+JP奖励）
        /// </summary>
        public long PreResultAmount { get; set; }

        /// <summary>
        /// 上一次踢球结果金额（单踢球）
        /// </summary>
        public long WinAmount { get; set; }

        /// <summary>
        /// 用户基础下注额
        /// </summary>
        public long BaseBet { get; set; }

        /// <summary>
        /// 上一次基础下注额
        /// </summary>
        public long PreBaseBet { get; set; }

        /// <summary>
        /// 用户上一次下注金额
        /// </summary>
        public long PreBet { get; set; }

        /// <summary>
        /// 上一次下注加倍数
        /// </summary>
        public decimal PreBetMultiple { get; set; }

        /// <summary>
        /// 当前用户Lucky值
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
        public int GoalProgress { get; set; }

        /// <summary>
        /// 目标进度
        /// </summary>
        public int MaxGoal { get; set; }

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
        /// 是否获得JP奖励
        /// </summary>
        public bool IsWinJackpot { get; set; }

        /// <summary>
        /// 获得JP奖励金额
        /// </summary>
        public decimal JackpotRaffleAmount { get; set; }

        /// <summary>
        /// 上一次下注位置
        /// </summary>
        public int PrePlace { get; set; }

        /// <summary>
        /// 上一个球星id
        /// </summary>
        public int PreStarID { get; set; }

        /// <summary>
        /// 累计踢球次数
        /// </summary>
        public int SumBetNum { get; set; }

        /// <summary>
        /// 最大下注值
        /// </summary>
        public decimal MaxStake { get; set; }

        /// <summary>
        /// userId
        /// </summary>
        public string UserId { get; set; }
        /// <summary>
        /// 访问平台的token
        /// </summary>
        public string PlatformToken { get; set; }

        /// <summary>
        /// AppId
        /// </summary>
        public string AppId { get; set; }

        /// <summary>
        /// OperatorId
        /// </summary>
        public string OperatorId { get; set; }

        /// <summary>
        /// ProviderId
        /// </summary>
        public string ProviderId { get; set; }

        /// <summary>
        /// CurrencyId
        /// </summary>
        public string CurrencyId { get; set; }

        /// <summary>
        /// 是否触发Jackpot抽奖
        /// </summary>
        public bool IsTriggerJackpotRaffle { get; set; }
    }
}
