using Dwin_poker.BLL.BetSvc;
using Dwin_poker.BLL.Caching;
using Dwin_poker.BLL.LoadSvc;
using Dwin_poker.DAL;
using TinyFx;
using TinyFx.Data;
using TinyFx.Logging;
using TinyFx.Randoms;
using Xxyy.Common.Caching;
using Xxyy.GameEAPI.Common;
using Xxyy.GameEAPI.Common.Enum;

namespace Dwin_poker.BLL
{
    public static class PokerUtil
    {
        public static List<int> CardGlobalList
        {
            get
            {
                List<int> list = new List<int>();
                for (int i = 0; i < 52; i++)
                {
                    list.Add(i);
                }
                return list;
            }
        }
        private static Dwp_bet_detailMO _betMo = new();
        private static Dwp_user_extMO _extMo = new();
        private static Dwp_pool_jackpotMO _poolJpMo = new();

        //更新user_ext表
        public static async Task PutUserExt(Dwp_user_extEO ext, TransactionManager tm = null)
        {
            int count = await _extMo.PutAsync(ext, tm);
            LogUtil.Info($"PutUserExt:{count},ext:{SerializerUtil.SerializeJsonNet(ext)}");
        }
        /// <summary>
        /// 获取JP奖池虚假奖金
        /// </summary>
        /// <param name="operatorId"></param>
        /// <param name="currencyId"></param>
        /// <returns></returns>
        public static async Task<decimal> GetPoolValByPKAsync(string operatorId, string currencyId)
        {
            var config = MemoryUtil.GetConfig(operatorId, currencyId);
            long poolVal = await _poolJpMo.GetPoolValByPKAsync(operatorId, currencyId) + config.JPInventedAmount;
            return XxyyUtil.AToM(poolVal, currencyId);
        }

        public static async Task AddBetDetail(BetContext context, long betId, TransactionManager tm)
        {
            var item = new Dwp_bet_detailEO
            {
                BetID = betId,
                UserID = context.UserId,
                ChipsID = context.UserDataDo.ChipsId,
                BetBaseAmount = context.UserDataDo.BetBaseAmount,
                BetMulitp = context.Ipo.Multi,
                BetTotalAmount = context.UserDataDo.BetTotalAmount,
                IsWin = context.UserDataDo.IsWin,
                BetResultAmount = context.UserDataDo.BetResultAmount,
                Star = context.UserDataDo.Ext.Star,
                CardIdx = context.UserDataDo.CardIdx,
                Card = context.ResultInfo.Card,
                RoundIdx = context.UserDataDo.Ext.RoundIdx,
                JPTotalValue = context.UserDataDo.Ext.JPTotalVal,
                IsTriggerJP = context.ResultInfo.JpRewardInfo.IsTriggerJpReward,
                JPRewardIndex = context.ResultInfo.JpRewardInfo.JpRewardIndex,
                JPRewardValue = context.ResultInfo.JpRewardInfo.JpReward.MToA(context.CurrencyId),
                GameStatus = (int)context.UserDataDo.GameStatus,
                History = context.UserDataDo.History,
                OrderStatus = (int)OrderStatus.Initial,
                RecDate = DateTime.UtcNow
            };
            await _betMo.AddAsync(item, tm);
        }

        public static List<int> BlackList = new();
        public static List<int> RedList = new();

        public static int CardRandom(List<History> removeList, CardType cardType, bool isWin = true)
        {
            int[] card;
            CardListInit(removeList);
            if (cardType == CardType.Black)
            {
                if (isWin) card = RandomUtil.RandomNotRepeat(BlackList.ToArray(), 1);
                else card = RandomUtil.RandomNotRepeat(RedList.ToArray(), 1);
            }
            else if (cardType == CardType.Red)
            {
                if (isWin) card = RandomUtil.RandomNotRepeat(RedList.ToArray(), 1);
                else card = RandomUtil.RandomNotRepeat(BlackList.ToArray(), 1);
            }
            else
            {
                card = RandomUtil.RandomNotRepeat(BlackList.ToArray(), 1);
                /*todo
                throw new Exception("参数类型错误:cardType->" + cardType);*/
            }
            if (card != null && card.Length > 0)
            {
                return card[0];
            }
            return -1;
        }

        private static void CardListInit(List<History> removeList)
        {
            BlackList.Clear();
            RedList.Clear();
            BuildRandomList(removeList);
            for (int i = 0; i < CardGlobalList.Count; i++)
            {
                var color = Math.Floor((double)i / 13);
                var point = i % 13;
                if (color == 0 || color == 2)
                {
                    BlackList.Add(i);
                }
                else if (color == 1 || color == 3)
                {
                    RedList.Add(i);
                }
            }
        }

        public static void BuildRandomList(List<History> removeList)
        {
            if (removeList.Count == 0) return;
            for (int i = 0; i < CardGlobalList.Count; i++)
            {
                for (int j = 0; j < removeList.Count; j++)
                {
                    if (CardGlobalList[i] == removeList[j].Card)
                    {
                        CardGlobalList.Remove(CardGlobalList[i]);
                    }
                }
            }
        }

        public static Dwp_config_jackpot_weightEO GetJpRewardByWeight(int chipsId, int jpVal)
        {
            //中奖几率随机数 [0,100)
            List<Dwp_config_jackpot_weightPO> list = MemoryUtil.GeJPWeightList(chipsId, jpVal);
            var count = list.Sum(x => x.Weight);
            var random = new Random().Next(count);
            int startNum = 0;
            foreach (var item in list)
            {
                if (random >= startNum && random < (item.Weight + startNum))
                {
                    return item;
                }
                startNum += item.Weight;
            }
            return null;
        }
        /// <summary>
        /// Math.floor(card/13)//0123-黑红梅方，card%13, 0123456789101112-A23456789,10,j,q,k
        /// </summary>
        /// <param name="card"></param>
        /// <returns></returns>
        public static string GetCardName(int card)
        {
            string cardName = string.Empty;
            switch (Math.Floor((decimal)card / 13))
            {
                case 0:
                    cardName = "黑桃";
                    break;
                case 1:
                    cardName = "红桃";
                    break;
                case 2:
                    cardName = "梅花";
                    break;
                case 3:
                    cardName = "方片";
                    break;
            }
            var cardVal = card % 13;
            if (cardVal == 0)
            {
                cardName += "A";
            }
            else if (cardVal == 10)
            {
                cardName += "J";
            }
            else if (cardVal == 11)
            {
                cardName += "Q";
            }
            else if (cardVal == 12)
            {
                cardName += "K";
            }
            else
            {
                cardName += cardVal + 1;
            }

            return cardName;
        }
    }
}
