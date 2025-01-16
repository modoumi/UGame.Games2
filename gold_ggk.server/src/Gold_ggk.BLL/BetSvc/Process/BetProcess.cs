using Gold_ggk.BLL.Caching;
using Gold_ggk.DAL;
using TinyFx.Randoms;
using Xxyy.Common;
using Xxyy.GameEAPI.Common;

namespace Gold_ggk.BLL.BetSvc.Process
{
    internal class BetProcess : BetProcessBase
    {
        public override async Task Execute(BetContext context)
        {
            Ggk_config_weightEO _weght = MemoryUtil.GetMulitp();

            List<int> seedList = new();
            for (int i = 1; i <= 30; i++)
            {
                seedList.Add(i);
            }
            //30选12个号码
            int[] allNumList = RandomUtil.RandomNotRepeat(seedList.ToArray(), 12);
            foreach (var num in allNumList)
            {
                if (seedList.Contains(num))
                    seedList.Remove(num);
            }
            //剩余18个号码
            int[] otherNumList = seedList.ToArray();
            context.RealBetAmount = context.isFreeSpin ? 0 : context.Config_Chips.BetAmount;

            //包含jp
            long winTotalAmount = GetWinAmount(_weght, context);
            //中奖数字对象
            List<ResultNum> resultNums = new();
            for (int i = 0; i < allNumList.Length; i++)
            {
                var num = allNumList[i];
                var type = 1;
                if (i == allNumList.Length - 2 || i == allNumList.Length - 3)
                {
                    type = 2;
                }
                ResultNum resultNum = new()
                {
                    Num = num,
                    RewardType = type,
                    RewardIdx = -1,
                };
                resultNums.Add(resultNum);
            }
            context.HistoryList = string.Empty;
            context.ResultInfo.RewardNumList = RandomUtil.RandomNotRepeat(otherNumList, 5).ToList();
            //中奖
            if (winTotalAmount > 0)
            {
                var isWin = await CheckPoolReturn(context, winTotalAmount);
                if (isWin)
                {
                    List<long> yesAmount = null;
                    if (_weght.RewardType == 3)//jp中奖,走jp规则
                    {
                        context.ResultInfo.JpRewardInfo.IsTriggerJpReward = true;
                        yesAmount = context.YesAmount;
                    }
                    else
                    {   //取中奖金额
                        List<string> selList = MemoryUtil.GetChipsGroup(context.Ipo.ChipsId, winTotalAmount);
                        string[] strings = selList.OrderBy(x => Guid.NewGuid()).First().Split("+");
                        yesAmount = strings.ToList().ConvertAll(s => long.Parse(s));
                        context.ResultInfo.JpRewardInfo.IsTriggerJpReward = false;
                    }
                    context.HistoryList = string.Join("|", yesAmount);

                    //中奖数字
                    List<int> yesNum = new();
                    //随机取N个数并赋值
                    int inx = 0;
                    foreach (var am in yesAmount)
                    {
                        var mm = am.AToM(context.CurrencyId);
                        var metaChips = MemoryUtil.GetMetaChipsByChipsId(context.Ipo.ChipsId, context.Ipo.CurrencyId);
                        var numObj = resultNums[inx];
                        var reidx = -1;
                        reidx = metaChips.JpBonusList.FindIndex(x => x == mm);


                        if (reidx > -1)
                        {
                            numObj.RewardType = 2;
                            numObj.RewardIdx = reidx;
                        }
                        else
                        {
                            reidx = metaChips.BetResultList.FindIndex(x => x == mm);
                            if (reidx > -1)
                            {
                                numObj.RewardType = 1;
                                numObj.RewardIdx = reidx;
                            }
                        }
                        yesNum.Add(numObj.Num);

                        inx++;
                    }
                    var otherNum = RandomUtil.RandomNotRepeat(otherNumList, 5 - yesNum.Count).ToList();
                    context.ResultInfo.RewardNumList = yesNum.Concat(otherNum).OrderBy(x => Guid.NewGuid()).ToList();
                }
                else
                {
                    winTotalAmount = 0;
                }
            }
            else
            {
                winTotalAmount = 0;
            }

            if (context.isFreeSpin)
            {
                context.UserExt.FreeSpinCount = 0;
                context.UserExt.RoundIdx = 0;
            }
            else
            {
                //context.UserExt.RoundIdx++;
            }
            if (context.UserExt.RoundIdx == 10)
            {
                context.UserExt.RoundIdx = 0;
                context.UserExt.FreeSpinCount = 1;
            }
            context.AllNumList = string.Join("|", allNumList);
            context.WinTotalAmount = winTotalAmount;
            context.ResultInfo.TotalReward = (winTotalAmount - context.JPRewardValue).AToM(context.CurrencyId);
            context.ResultInfo.GameItemInfo.ChipsId = context.Ipo.ChipsId;
            context.ResultInfo.GameItemInfo.FreeSpinCount = context.UserExt.FreeSpinCount;
            context.ResultInfo.GameItemInfo.BetCounter = context.UserExt.RoundIdx;
            resultNums = resultNums.OrderBy(x => Guid.NewGuid()).ToList();
            context.ResultInfo.ResultNumList = resultNums;
        }

        private long GetWinAmount(Ggk_config_weightEO _weght, BetContext context)
        {
            long winAmount = 0;
            if (_weght.RewardType == 3)//jp中奖,走jp规则
            {
                List<long> _temp = new();
                //取倍数
                Ggk_config_weight_jackpotEO jpweight = MemoryUtil.GetMulitpJackPot();
                string[] mulitpArrs = jpweight.Group.Split("|").ToList().OrderBy(x => Guid.NewGuid()).First().Split("+");
                foreach (var am in mulitpArrs)
                {
                    long str = (long.Parse(am) * context.Config_Chips.BetAmount);
                    _temp.Add(str);
                }
                context.YesAmount = new(_temp);
                winAmount = _temp.Sum();
                context.JPRewardValue = context.Config_Chips.JpRewardAmount;
            }
            else
            {
                winAmount = (long)(context.Config_Chips.BetAmount * _weght.Mulitp);
                context.JPRewardValue = 0;
            }
            return winAmount + context.JPRewardValue;
        }
    }
}