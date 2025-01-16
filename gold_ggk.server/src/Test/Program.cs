using System.Data;
using System.Security.Policy;
using TinyFx.Extensions.EPPlus;
using TinyFx.Randoms;

namespace SumCombinations
{
    class Program
    {
        public static List<int[]> BuildTablePoolNo()
        {
            List<int[]> all = new();
            var ItemList = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            List<int> ItemIds = new();
            foreach (var item in ItemList)
            {
                if (item != 11)
                {
                    ItemIds.Add(item);
                }
            }
            var nums = RandomUtil.RandomNotRepeat(ItemIds.ToArray(), 6);
            var noRandom = RandomUtil.NextInts(9, 1, 10);
            var allNums = nums.Concat(noRandom).ToList();

            List<int> column = new();
            List<int> column2 = new();
            List<int> column3 = new();
            List<int> column4 = new();
            List<int> column5 = new();
            for (int i = 0; i < allNums.Count; i++)
            {
                if (i >= 0 && i < 3)
                {
                    column.Add(allNums[i]);
                }
                else if (i >= 3 && i < 6)
                {
                    column2.Add(allNums[i]);
                }
                else if (i >= 6 && i < 9)
                {
                    column3.Add(allNums[i]);
                }
                else if (i >= 9 && i < 12)
                {
                    column4.Add(allNums[i]);
                }
                else if (i >= 12 && i < 15)
                {
                    column5.Add(allNums[i]);
                }
            }

            all.Add(column.ToArray());
            all.Add(column2.ToArray());
            all.Add(column3.ToArray());
            all.Add(column4.ToArray());
            all.Add(column5.ToArray());
            all[(int)0 + 1][0] = 10;
            all[(int)0 + 1][1] = 10;
            all[(int)0 + 1][2] = 10;

            Console.WriteLine(string.Join(",", column));
            Console.WriteLine(string.Join(",", column2));
            Console.WriteLine(string.Join(",", column3));
            Console.WriteLine(string.Join(",", column4));
            Console.WriteLine(string.Join(",", column5));
            return all;
        }
        public static bool IsOdds(decimal ratio, int precision = 100)
        {
            int num = new Random().Next(precision);
            int num2 = (int)(ratio * (decimal)precision);
            return num2 > num;
        }

        static void Main(string[] args)
        {
          List<int> all = new  ();
            for (int i = 1; i <= 24; i++)
            {
                all.Add(i);
            }
            Console.WriteLine(Guid.NewGuid());
            return;

            var 已开钻石 = 0;
            for (int j = 1; j <= 25; j++)
            {
                //未开启格子
                var cellNum = 25 - j;

                var mines = 1;
                var diamond = cellNum - mines;

                decimal retunOdds = 0.95M;
                var isMines = (decimal)mines / cellNum * retunOdds;
                var 赔率 = Math.Round(1 + (decimal)j / cellNum, 2);
                var sa = IsOdds(isMines, 1000);
                if (!sa) 已开钻石++;
                Console.WriteLine($"第{j}次开,已开钻石:{已开钻石},炸弹概率:{isMines},是否爆炸:{sa},赔率:{赔率},中奖金额:{10 * 赔率}");
                if (sa)
                {
                    Console.WriteLine("已爆炸,退出");
                    break;
                }
                if (cellNum - 1 > 0)
                {
                    var 下一档赔率 = 1 + (decimal)mines / cellNum - 1;
                    Console.WriteLine(下一档赔率);
                }
            }
            return;
        }

        public static void aaa()
        {
            DataTable dt = EPPlusUtil.ReadToTable("D:\\ing-repos\\gold_ggk.server\\src\\Gold_ggk.DAL\\init.xlsx", "ggk_config_weight_jackpot");
            List<string> ll = new();
            int i = 0;
            foreach (DataRow row in dt.Rows)
            {
                if (i > 1)
                {
                    string[] group = row[4].ToString().Split("|");
                    foreach (string s in group)
                    {
                        string[] vv = s.Split("+");
                        string vvvv = "";
                        foreach (var v in vv)
                        {
                            var vvv = (long.Parse(v) * 10000).ToString();
                            vvvv += vvv + "|";
                        }
                        vvvv = vvvv.Substring(0, vvvv.LastIndexOf("|"));
                        Console.WriteLine(vvvv);
                        //    var v= long.Parse(s) * 10000;
                    }
                    //   ll.Add(row[4].ToString().Split("|").ToList();
                }
                i++;
            }
            foreach (var k in ll)
            {
                Console.WriteLine(k);
            }
        }


        static void CalculateCombinations(long[] numbers, long target, string combination, long sum, List<string> combinations)
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
    }
}