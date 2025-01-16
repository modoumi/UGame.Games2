

namespace BestShooter.BLL.Services.Jackpot
{
    /// <summary>
    /// Jackpot抽奖结果
    /// </summary>
    public class JackpotRaffleResult
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
        /// 用户本次增加的Jackpot累计值
        /// </summary>
        public long JackpotValue { get; set; } = 0;
    }
}
