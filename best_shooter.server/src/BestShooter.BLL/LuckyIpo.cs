namespace BestShooter.BLL
{
    public class LuckyIpo
    {

        /// <summary>
        /// 用户id
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// Lucky主订单Id
        /// </summary>
        public string OrderId { get; set; } = Guid.NewGuid().ToString();

        /// <summary>
        /// lucky抽奖订单id
        /// </summary>
        public string RaffleOrderId { get; set; } = Guid.NewGuid().ToString();


        public DateTime AddTimeNow { get; set; } = DateTime.UtcNow;

        public DateTime UpdateTimeNow { get; set; } = DateTime.UtcNow;

        /// <summary>
        /// 国家编码
        /// </summary>
        public string OperatorID { get; set; }

    }
}
