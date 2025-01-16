

namespace BestShooter.BLL.Services.Lucky
{
    public class LuckyRaffleDto
    {
        public bool IsWin { get; set; }

        /// <summary>
        /// lucky中奖金额
        /// </summary>
        public decimal WinAmount { get; set; }

        /// <summary>
        /// 余额
        /// </summary>
        public decimal Balance { get; set; }
    }
}
