using Mines.BLL.Caching;
using Mines.BLL.Core;
using Mines.BLL.LoadSvc;
using TinyFx;
using TinyFx.Randoms;
using Xxyy.GameEAPI.Common;
using static Mines.BLL.MinesUtil;

namespace Mines.BLL
{
    internal class BetProcess : BetProcessBase
    {
        public override async Task Execute(BetContext context)
        {
            await Calc(context);
            await Task.CompletedTask;
        }
        /// <summary>
        /// 一. 中奖公式
        /// 是否中奖 = 炸弹数/(炸弹数+当前钻石)*0.95
        /// 当前赔率 = 1+ 炸弹数/(炸弹数+当前钻石)
        /// 下一档赔率 = 1+ 炸弹数/(炸弹数+当前钻石-1)
        /// 中奖金额 = 下注额* 当前赔率
        /// 二.反奖池走统一逻辑
        /// </summary>
        /// <param name="context"></param>
        public async Task Calc(BetContext context)
        {
            if (context.UserExt.GameStatus != (int)GameStatus.Start)
            {
                throw new CustomException(GameCodes.RS_GAMESTATUSEXCEP, $"先startGame, GameStatus:{context.UserExt.GameStatus}");
            }
            List<CellInfo> cellInfos = SerializerUtil.DeserializeJsonNet<List<CellInfo>>(context.UserExt.CellInfo);
            int count = cellInfos.Count(x => x.Id == context.Ipo.CellId && x.IsOpen == 1);
            if (count > 0)
            {
                throw new CustomException(GameCodes.RS_CELLREPEAT, $"不能重复开启格子 cellId:{context.Ipo.CellId}");
            }

            var chipsEo = DBCacheUtil.GetChips(context.UserExt.Mines, context.UserExt.NoCellDiamod);
            context.Multip = GetCurrMultip(context.UserExt);
            context.NextMultip = GetNextMultip(context.UserExt);

            foreach (var cell in cellInfos)
            {
                if (cell.Id == context.Ipo.CellId)
                {
                    cell.Type = (int)context.CellType;
                    cell.IsOpen = 1;
                    break;
                }
            }

            int noCount = cellInfos.Count(x => x.IsOpen == 0);
            context.CellOpenNum = CELLNUMS - noCount;

            context.IsRateWin = IsRateWin(chipsEo.Rate);
            //中奖,查询反奖池
            if (context.IsRateWin)
            {
                var _winAmount = (context.UserExt.BetBaseAmount.AToM(context.CurrencyId) * (decimal)context.NextMultip).MToA(context.CurrencyId);
                var isWin = await CheckPoolReturn(context, _winAmount);
                context.IsWin = isWin ? 1 : 0;
                if (isWin)
                {
                    context.UserExt.WinAmount = _winAmount;
                    context.UserExt.NoCellDiamod--;
                }
                else
                {
                    context.IsRateWin = false;
                }
            }
            context.CellType = context.IsRateWin ? CellType.Diamod : CellType.Mine;
            foreach (var cell in cellInfos)
            {
                if (cell.Id == context.Ipo.CellId)
                {
                    cell.Type = (int)context.CellType;
                    cell.IsOpen = 1;
                    break;
                }
            }
            if (!context.IsRateWin)
            {
                //游戏结束构造未显示的坑
                cellInfos = BuildList(cellInfos, context.UserExt.Mines);
                context.UserExt.WinAmount = 0;
                context.UserExt.GameStatus = (int)GameStatus.End;//本轮已结束
            }
            else
            {
                //中奖
                if (context.CellOpenNum >= (CELLNUMS - context.UserExt.Mines))
                {
                    context.UserExt.GameStatus = (int)GameStatus.End;//本轮已结束
                }

            }
            context.UserExt.CellInfo = SerializerUtil.SerializeJsonNet(cellInfos);
            context.UserExt.RoundNum++;
        }
        /// <summary>
        /// 是否爆炸
        /// </summary>
        /// <param name="mimeNum">地雷数</param>
        /// <param name="cellNum">未开启格子数</param>
        /// <returns></returns>
        public bool IsRateWin(double mineRate)
        {
            return RandomUtil.IsOdds((decimal)mineRate);
        }
    }
}