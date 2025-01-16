using Dwin_poker.BLL.Caching;
using Dwin_poker.BLL.LoadSvc;
using Dwin_poker.DAL;
using Newtonsoft.Json;
using TinyFx;
using TinyFx.Logging;
using TinyFx.Randoms;
using Xxyy.GameEAPI.Common;

namespace Dwin_poker.BLL.BetSvc.Process
{
    internal class BetProcess : BetProcessBase
    {
        public override async Task Execute(BetContext context)
        {
            CardType cardType = (CardType)context.Ipo.Type;//1-黑,2-红
            var userDataDo = context.UserDataDo;//当前用户星星 - 查询得到

            userDataDo.Multip = context.Ipo.Multi;
            var ratio = context.StarRatio;//对应星级中奖概率
            if (userDataDo.GameStatus != GameStatus.Normal) { throw new Exception("游戏状态异常：" + userDataDo.GameStatus); }
            if (userDataDo.Ext.RoundIdx == 0)
            {
                userDataDo.ChipsId = context.Chips.ChipsID;
                userDataDo.BetBaseAmount = context.Chips.BetBaseAmount;
            }
            else
            {
                //非第一回合， 跟上局胜负判断下注金额
                userDataDo.BetBaseAmount = userDataDo.IsWin ? userDataDo.BetResultAmount : userDataDo.BetBaseAmount;
            }
            userDataDo.Ext.JPTotalVal += (int)(userDataDo.BetTotalAmount.AToM(context.CurrencyId) * (decimal)context.JPTotalRatio);//jp累计值
            userDataDo.Ext.RoundIdx++;
            userDataDo.BetResultAmount = userDataDo.BetTotalAmount * 2;

            var isWin = RandomUtil.IsOdds((decimal)ratio);//是否胜利

            if (isWin)
            {
                isWin = await CheckPoolReturn(context, userDataDo.BetResultAmount);
            }
            if (isWin)
            {
                userDataDo.Ext.Star++;
            }
            else
            {
                userDataDo.BetResultAmount = 0;
            }
            userDataDo.IsWin = isWin;
            var isTriggerWeight = userDataDo.Ext.JPTotalVal >= context.JPValTH;//是否达到JP阈值
            var isTriggerJp = false;
            var jpRewardIndex = 0;
            decimal jpReward = 0;
            //抽卡历史记录
            List<History> historiyList = SerializerUtil.DeserializeJsonNet<List<History>>(userDataDo.History);
            if (userDataDo.CardIdx == context.MaxCardNum)
            {
                userDataDo.CardIdx = 0;
                historiyList.Clear();
            }
            userDataDo.CardIdx++;
            //本次card值
            var cardNum = PokerUtil.CardRandom(historiyList, cardType, isWin);
            LogUtil.Info($"抽卡点数:{cardNum},对应牌：{PokerUtil.GetCardName(cardNum)}");
            if (isTriggerWeight)
            {
                Dwp_config_jackpot_weightEO jpWeight = PokerUtil.GetJpRewardByWeight(context.Ipo.ChipsId, userDataDo.Ext.JPTotalVal);
                long winJP = MemoryUtil.GetJpRewardByIndex(context.Ipo.ChipsId, jpWeight.JPRewardIndex);
                var jpRatio = userDataDo.Ext.JPTotalVal / XxyyUtil.AToM(winJP, context.CurrencyId);
                userDataDo.Ext.JPTotalVal = 0;//清空累计值
                var isEnoughJP = await CheckPoolJP(context, MemoryUtil.GetJpRewardByIndex(context.Ipo.ChipsId, jpWeight.JPRewardIndex));
                //JP命中
                if (RandomUtil.IsOdds(jpRatio, 100) && isEnoughJP)
                {
                    isTriggerJp = true;
                    jpRewardIndex = jpWeight.JPRewardIndex;
                    jpReward = XxyyUtil.AToM(winJP, context.CurrencyId);
                }
            }
            historiyList.Add(new History
            {
                BetResult = userDataDo.BetResultAmount.AToM(context.CurrencyId),
                Card = cardNum,
                IsTriggerJpReward = isTriggerJp,
            });
            userDataDo.History = SerializerUtil.SerializeJsonNet(historiyList, new JsonSerializerSettings() { Formatting = Formatting.None });

            context.ResultInfo.GameInfo = new GameInfo
            {
                OriChipsId = context.Ipo.ChipsId,
                RoundIdx = userDataDo.Ext.RoundIdx,
                CardIdx = userDataDo.CardIdx,
                BaseBet = userDataDo.BetBaseAmount.AToM(context.CurrencyId),
                Multi = context.Ipo.Multi,
                TotalBet = userDataDo.BetTotalAmount.AToM(context.CurrencyId),
                BetResult = userDataDo.BetResultAmount.AToM(context.CurrencyId),
                GameStatus = (int)context.UserDataDo.GameStatus,
                Star = userDataDo.Ext.Star,
            };
            context.ResultInfo.Card = cardNum;
            context.ResultInfo.JpRewardInfo = new JpRewardInfo
            {
                IsTriggerJpReward = isTriggerJp,
                JpRewardIndex = jpRewardIndex,
                JpReward = jpReward,
            };
            userDataDo.Ext.LastUpdateDate = DateTime.UtcNow;
        }
    }
}