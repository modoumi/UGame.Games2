

using System.Text.Json.Serialization;

namespace BestShooter.BLL.Services.KickBall
{
    /// <summary>
    /// 踢球Ipo
    /// </summary>
    public class BetIpo
    {
        /// <summary>
        /// 赌注
        /// </summary>
        public double Bet { get; set; }

        /// <summary>
        /// 赌注倍数
        /// </summary>
        public double BetMultiple { get; set; }

        /// <summary>
        /// 位置
        /// </summary>
        public int place { get; set; }

        /// <summary>
        /// 位置对应的倍数
        /// </summary>
        public double PlaceMultiple { get; set; }

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

    }
}
