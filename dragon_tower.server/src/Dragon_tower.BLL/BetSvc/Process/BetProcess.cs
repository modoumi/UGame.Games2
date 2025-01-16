using Dragon_tower.BLL.Core;
using Mines.BLL.Core;
using TinyFx;
using TinyFx.Randoms;
using Xxyy.GameEAPI.Common;
using static Dragon_tower.BLL.GdtUtil;

namespace Dragon_tower.BLL
{
    internal class BetProcess : BetProcessBase
    {
        public override async Task Execute(BetContext context)
        {
            await Calc(context);
            await Task.CompletedTask;
        }
        public async Task Calc(BetContext context)
        {
            if (context.UserExt.GameStatus != (int)GameStatus.Start)
            {
                throw new CustomException(GameCodes.RS_GAMESTATUSEXCEP, $"先startGame, GameStatus:{context.UserExt.GameStatus}");
            }
            List<FloorInfo> floorInfos = SerializerUtil.DeserializeJsonNet<List<FloorInfo>>(context.UserExt.FloorInfo);
            if (context.Ipo.FloorId - context.UserExt.FloorNum != 1)
            {
                throw new CustomException(GameCodes.RS_FLOOREXCEP, $"不能越级爬塔 floor:{context.Ipo.FloorId}");
            }

            var floor = floorInfos.Where(x => x.Id == context.Ipo.FloorId).First();
            floor.OpenCellId = context.Ipo.CellId;
            context.UserExt.FloorNum++;
            context.IsOver = IsOver(context.Config_Level.DiamodNum, context.Config_Level.CellNum, context.Config.ReturnRatio);

            if (context.UserExt.FloorNum == FLOORNUMS)
            {
                context.UserExt.GameStatus = (int)GameStatus.End;
            }
            //游戏未结束,查询反奖池
            if (!context.IsOver)
            {
                //查询反奖池
                var mutilp = (double)context.Config_Level.CellNum / context.Config_Level.DiamodNum;
                mutilp = Math.Pow(mutilp, context.UserExt.FloorNum);
                context.Multip = mutilp;
                var _winAmount = (context.UserExt.BetBaseAmount.AToM(context.CurrencyId) * (decimal)mutilp).MToA(context.CurrencyId);
                var isWin = await CheckPoolReturn(context, _winAmount);
                context.IsWin = isWin ? 1 : 0;
                if (isWin)
                {
                    context.UserExt.WinAmount = _winAmount;
                }
                else
                {
                    context.IsOver = true;
                }
            }
            context.CellType = context.IsOver ? CellType.Mine : CellType.Diamod;
            floor.CellTypeList[floor.OpenCellId - 1] = (int)context.CellType;

            if (context.IsOver)
            {
                //游戏结束构造未显示的坑
                floorInfos = BuildList(floorInfos, context.Config_Level.LevelID);
                context.UserExt.WinAmount = 0;
                context.UserExt.GameStatus = (int)GameStatus.End;//本轮已结束
            }
            context.UserExt.FloorInfo = SerializerUtil.SerializeJsonNet(floorInfos);
        }
        /// <summary>
        /// 是否爆炸
        /// </summary>
        /// <param name="diamodNum">钻石数</param>
        /// <param name="cellNum">未开启格子数</param>
        /// <returns></returns>
        public bool IsOver(int diamodNum, int cellNum, double rate)
        {
            //返奖率
            decimal retunOdds = (decimal)rate;
            decimal overRate = 1 - ((decimal)diamodNum / cellNum * retunOdds);
            return RandomUtil.IsOdds(overRate);
        }
    }
}