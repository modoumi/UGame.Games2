using BestShooter.DAL;
using TinyFx.Data;

namespace BestShooter.BLL.Services.Order
{
    public class OrderService
    {
        //下注订单
        private Bs_bet_orderMO _betOrderMo = new();

        //抽奖订单
        private Bs_order_raffleMO _raffleOrderMo = new();

        /// <summary>
        /// 初始化抽奖订单表gbs_raffle_order
        /// </summary>
        /// <returns></returns>
        public async Task<Bs_order_raffleEO> InitRaffleOrder()
        {
            return new Bs_order_raffleEO()
            {
                RaffleOrderID = Guid.NewGuid().ToString(),
                Status = 1
            };
        }
        /// <summary>
        /// 新增gbs_bet_order
        /// </summary>
        /// <param name="betOrderEo"></param>
        /// <param name="tm"></param>
        /// <returns></returns>
        public async Task<bool> AddBetOrder(Bs_bet_orderEO betOrderEo, TransactionManager tm = null)
        {
            return await _betOrderMo.AddAsync(betOrderEo, tm) > 0;
        }

        /// <summary>
        /// 新增gbs_raffle_order
        /// </summary>
        /// <param name="raffleOrderEo"></param>
        /// <param name="tm"></param>
        /// <returns></returns>
        public async Task<bool> AddRaffleOrder(Bs_order_raffleEO raffleOrderEo, TransactionManager tm = null)
        {
            return await _raffleOrderMo.AddAsync(raffleOrderEo, tm) > 0;
        }
        /// <summary>
        /// 更新gbs_raffle_order
        /// </summary>
        /// <param name="raffleOrderEo"></param>
        /// <param name="tm"></param>
        /// <returns></returns>
        public async Task<bool> UpdateRaffleOrderForLucky(Bs_order_raffleEO raffleOrderEo, TransactionManager tm)
        {
            return await _raffleOrderMo.PutAsync(raffleOrderEo, tm) > 0;
        }

        /// <summary>
        /// 抽奖后更新gbs_order
        /// </summary>
      /*  /// <returns></returns>
        public async Task<bool> UpdateOrderForBetAfter(int orderStatus, string orderId, TransactionManager tm)
        {
            return await u_orderMo.PutAsync("Status = @Status", "OrderID = @OrderID", tm, orderStatus, orderId) > 0;
        }*/

    }
}
