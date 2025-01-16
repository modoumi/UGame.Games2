using Gold_ggk.BLL.BetSvc;
using Gold_ggk.DAL;
using Newtonsoft.Json;
using TinyFx;
using TinyFx.Data;
using TinyFx.Logging;
using Xxyy.Common;
using Xxyy.GameEAPI.Common;
using Xxyy.GameEAPI.Common.Enum;
using Xxyy.Partners.Client;
using Xxyy.Partners.Model;

namespace Gold_ggk.BLL
{
    internal static class GoldUtil
    {
        #region Properties
       // public static GameSection Options { get; private set; }
        private static readonly Ggk_user_extMO _extMo = new();
        private static readonly Ggk_bet_detailMO _betMo = new();
        private static readonly Ggk_pool_returnMO _poolMo = new();
        private static readonly Ggk_config_chipsMO _chipsMo = new();
        #endregion

        public static async Task CheckAndInitUserData(string userId, string operatorId, string currencyId)
        {
            //反奖池
            var poolItem = await _poolMo.GetByPKAsync(operatorId, currencyId);
            if (poolItem == null)
            {
                await _poolMo.AddAsync(new Ggk_pool_returnEO
                {
                    OperatorID = operatorId,
                    CurrencyID = currencyId,
                    PoolVal = 0
                });
            }

            var count = await _extMo.GetCountAsync($"UserID=@UserID", userId);
            var chipsList = await _chipsMo.GetAllAsync();
            if (count == chipsList.Count)
                return;
            if (count != 0)
                throw new Exception($"ggk_user_chips表数据错误。userId:{userId} currencyId:{currencyId} chips: {chipsList.Count} count:{count}");
            var list = new List<Ggk_user_extEO>();
            foreach (var chips in chipsList)
            {
                var item = new Ggk_user_extEO
                {
                    UserID = userId,
                    ChipsID = chips.ChipsID,
                    RoundIdx = 0,
                    FreeSpinCount = 0,
                    UserStatus = (int)UserStatus.Normal,
                    LastRecDate = DateTime.UtcNow,
                };
                list.Add(item);
            }
            await _extMo.AddAsync(list);
        }
        public static async Task AddBetDetail(BetContext context, long betId, TransactionManager tm)
        {
            var item = new Ggk_bet_detailEO
            {
                BetID = betId,
                UserID = context.UserId,
                ChipsID = context.Ipo.ChipsId,
                FreeSpinCount = context.UserExt.FreeSpinCount,
                BetBaseAmount = context.RealBetAmount,
                RoundIdx = context.UserExt.RoundIdx,
                WinAmount = context.ResultInfo.TotalReward.MToA(context.CurrencyId),
                RewardNumList = string.Join("|", context.ResultInfo.RewardNumList),
                HistoryList = context.HistoryList,
                AllNumList = context.AllNumList,
                JPRewardValue = context.JPRewardValue,
                OrderStatus = (int)OrderStatus.Initial,
                RecDate = DateTime.UtcNow
            };
            await _betMo.AddAsync(item, tm);
        }

        public static void CalculateCombinations(long[] numbers, long target, string combination, long sum, List<string> combinations)
        {
            if (sum == target && combination.Count(c => c == '+') <= 4)
            {
                combinations.Add(combination.TrimEnd('+'));
                return;
            }

            if (sum > target || combination.Count(c => c == '+') > 4)
                return;

            for (int i = 0; i < numbers.Length; i++)
            {
                long currentNumber = numbers[i];
                long[] remainingNumbers = new long[numbers.Length - i - 1];
                Array.Copy(numbers, i + 1, remainingNumbers, 0, remainingNumbers.Length);

                CalculateCombinations(remainingNumbers, target, combination + currentNumber.ToString() + "+", sum + currentNumber, combinations);
            }
        }
        public static List<string> GetRandom(List<long> dtoParam, long num)
        {
            List<string> reust = new();
            List<long> d = new();
            if (dtoParam.Where(x => x == num).Any())
            {
                reust.Add(num.ToString());
            }
            int a = 1;
            int c = 1;
            for (int i = 0; i < dtoParam.Count; i++)
            {
                long s = dtoParam[i];
                bool bb = true;
                while (bb)
                {
                    if (!bb)
                    {
                        break;
                    }
                    if (dtoParam.Count == a)
                    {
                        break;
                    }
                    bool b = true;
                    while (b)
                    {
                        if (dtoParam.Count == c)
                        {
                            a++;
                            c = a;
                            break;
                        }
                        d.Add(dtoParam[i]);
                        for (int j = c; j < dtoParam.Count; j++)
                        {
                            s += dtoParam[j];
                            d.Add(dtoParam[j]);
                            if (s == num)
                            {
                                var sss = string.Join("|", d);
                                if (!reust.Contains(sss))
                                    reust.Add(sss);
                                break;
                            }

                            if (dtoParam.Count - j == 1)
                            {
                                s = dtoParam[i];
                                c++;
                                break;
                            }
                        }
                    }
                }
            }
            return reust;
        }
    }
}
