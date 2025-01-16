using Mines.BLL.Caching;
using Mines.BLL.Core;
using Mines.BLL.LoadSvc;
using Mines.DAL;
using TinyFx;
using TinyFx.Data;
using Xxyy.Common.Caching.Partner;
using Xxyy.GameEAPI.Common.Enum;

namespace Mines.BLL
{
    public static class MinesUtil
    {
        /// <summary>
        /// 总格子数
        /// </summary>
        public const int CELLNUMS = 25;
        #region Properties
        private static readonly Mines_user_extMO _extMo = new();
        private static readonly Mines_bet_detailMO _betMo = new();
        private static readonly Mines_pool_returnMO _poolMo = new();

        #endregion

        public static List<CellInfo> CellInit()
        {
            List<CellInfo> list = new();
            for (int i = 0; i < CELLNUMS; i++)
            {
                list.Add(new CellInfo() { Id = i + 1, IsOpen = 0, Type = 0 });
            }
            return list;
        }

        public static async Task<Mines_user_extEO> CheckAndInitUserData(AppLoginTokenDO appToken)
        {

            //反奖池
            var poolItem = await _poolMo.GetByPKAsync(appToken.OperatorId, appToken.CurrencyId);
            if (poolItem == null)
            {
                await _poolMo.AddAsync(new Mines_pool_returnEO
                {
                    OperatorID = appToken.OperatorId,
                    CurrencyID = appToken.CurrencyId,
                    PoolVal = 50000000
                });
            }

            var extEo = await _extMo.GetByPKAsync(appToken.UserId);
            if (extEo == null)
            {
                var config = DBCacheUtil.GetConfig(appToken.OperatorId, appToken.CurrencyId);
                extEo = UserExtInit(appToken.UserId, config.MinMine, config.MinBet);
                await _extMo.AddAsync(extEo);
            }
            return extEo;
        }

        public static Mines_user_extEO UserExtInit(string userId, int mines, long betAmount)
        {
            return new Mines_user_extEO()
            {
                BetBaseAmount = betAmount,
                Mines = mines,
                NoCellDiamod = CELLNUMS - mines,
                CellInfo = SerializerUtil.SerializeJsonNet(CellInit()),
                GameStatus = (int)GameStatus.Init,
                RoundNum = 0,
                UserID = userId,
                WinAmount = 0,
                LastRecDate = DateTime.UtcNow,
            };
        }

        public static async Task AddBetDetail(BetContext context, long betId, TransactionManager tm)
        {
            var item = new Mines_bet_detailEO
            {
                BetID = betId,
                UserID = context.UserId,
                RoundNum = context.UserExt.RoundNum,
                BetAmount = context.UserExt.RoundNum > 1 ? context.PreWinAmount : context.UserExt.BetBaseAmount,
                IsWin = context.IsWin,
                WinAmount = context.UserExt.WinAmount,
                Multip = context.Multip,
                CellOpenNum = context.CellOpenNum,
                CellType = (int)context.CellType,
                OrderStatus = (int)OrderStatus.Initial,
                RecDate = DateTime.UtcNow
            };
            await _betMo.AddAsync(item, tm);
        }
        public static List<CellInfo> BuildList(List<CellInfo> cellInfoList, int mine)
        {
            var mineCount = cellInfoList.Count(x => x.Type == (int)CellType.Mine);
            var syMines = mine - mineCount;
            cellInfoList = cellInfoList.OrderBy(x => Guid.NewGuid()).ToList();

            foreach (var item in cellInfoList)
            {
                if (item.IsOpen == 0)
                {
                    if (syMines > 0)
                    {
                        item.Type = (int)CellType.Mine;
                        syMines--;
                    }
                    else
                    {
                        item.Type = (int)CellType.Diamod;
                    }
                }
            }
            return cellInfoList.OrderBy(x => x.Id).ToList();
        }


        public static void SetGameInfoMultip(Mines_user_extEO extEo, GameInfo gameInfo)
        {
            if (extEo.RoundNum == 0)
            {
                gameInfo.CurRate = 1;
            }
            else
            {
                var preChips = DBCacheUtil.GetChips(extEo.Mines, extEo.NoCellDiamod + 1);
                gameInfo.CurRate = preChips != null ? preChips.Multip : 0;

            }
            if (extEo.NoCellDiamod == 0)
            {
                gameInfo.NextRate = 0;
            }
            else
            {
                var chipsEo = DBCacheUtil.GetChips(extEo.Mines, extEo.NoCellDiamod);
                gameInfo.NextRate = chipsEo.Multip;
            }

        }
        public static double GetCurrMultip(Mines_user_extEO extEo)
        {
            double currMultip = 0;
            if (extEo.RoundNum == 0)
            {
                currMultip = 1;
            }
            else
            {
                var chipsEo = DBCacheUtil.GetChips(extEo.Mines, extEo.NoCellDiamod + 1);
                currMultip = chipsEo != null ? chipsEo.Multip : 0;

            }
            return currMultip;
        }

        public static double GetNextMultip(Mines_user_extEO extEo)
        {
            if (extEo.NoCellDiamod == 0)
            {
                return 0;
            }
            else
            {
                var chipsEo = DBCacheUtil.GetChips(extEo.Mines, extEo.NoCellDiamod);
                return chipsEo.Multip;
            }
        }
    }
}
