namespace BestShooter.BLL.BetSvc
{
    public class BetOddsResult
    {
        /// <summary>
        /// 是否中奖
        /// </summary>
        public bool IsWin { get; set; } = false;

        /// <summary>
        /// 中奖金额
        /// </summary>
        public long WinAmount { get; set; } = 0;

        /// <summary>
        /// 当下注时候，中奖是否为惊喜奖励
        /// </summary>
        public bool IsSurprise { get; set; } = false;

    }
}
