using Dragon_tower.BLL.Caching;
using Dragon_tower.BLL.Core;
using Dragon_tower.DAL;
using TinyFx;
using TinyFx.Data;
using Xxyy.Common.Caching;
using Xxyy.Common.Caching.Partner;
using Xxyy.GameEAPI.Common.Enum;

namespace Dragon_tower.BLL
{
    public static class GdtUtil
    {
        /// <summary>
        /// 塔总层数
        /// </summary>
        public const int FLOORNUMS = 9;
        #region Properties
        //public static GameSection Options { get; private set; }
        private static readonly Gdt_user_extMO _extMo = new();
        private static readonly Gdt_bet_detailMO _betMo = new();
        private static readonly Gdt_pool_returnMO _poolMo = new();
        #endregion

        public static async Task<Gdt_user_extEO> CheckAndInitUserData(AppLoginTokenDO appToken)
        {
            //反奖池
            var poolItem = await _poolMo.GetByPKAsync(appToken.OperatorId, appToken.CurrencyId);
            if (poolItem == null)
            {
                await _poolMo.AddAsync(new Gdt_pool_returnEO
                {
                    OperatorID = appToken.OperatorId,
                    CurrencyID = appToken.CurrencyId,
                    PoolVal = 50000000
                });
            }
            var extEo = await _extMo.GetByPKAsync(appToken.UserId);
            if (extEo == null)
            {
                var config = MemoryUtil.GetConfig(appToken.OperatorId, appToken.CurrencyId);
                extEo = UserExtInit(appToken.UserId, config.LevelId, config.MinBet);
                await _extMo.AddAsync(extEo);
            }
            return extEo;
        }
        public static Gdt_user_extEO UserExtInit(string userId, int levelId, long betAmount)
        {
            var level = MemoryUtil.GetLevelByPk(levelId);
            return new Gdt_user_extEO()
            {
                UserID = userId,
                BetBaseAmount = betAmount,
                WinAmount = 0,
                LevelId = levelId,
                FloorNum = 0,
                FloorInfo = SerializerUtil.SerializeJsonNet(FloorInit(level.CellNum)),
                GameStatus = (int)GameStatus.Init,
                LastRecDate = DateTime.UtcNow,
            };
        }
        public static List<FloorInfo> FloorInit(int cellNum)
        {
            List<FloorInfo> list = new();
            for (int i = 0; i < FLOORNUMS; i++)
            {
                list.Add(new FloorInfo() { Id = i + 1, OpenCellId = 0, CellTypeList = (new int[cellNum]).ToList() });
            }
            return list;
        }
        public static async Task AddBetDetail(BetContext context, long betId, TransactionManager tm = null)
        {
            var item = new Gdt_bet_detailEO
            {
                BetID = betId,
                UserID = context.UserId,
                BetAmount = context.UserExt.FloorNum > 1 ? context.PreWinAmount : context.UserExt.BetBaseAmount,
                WinAmount = context.UserExt.WinAmount,
                FloorNum = context.UserExt.FloorNum,
                IsWin = context.IsWin,
                Multip = context.Multip,
                CellOpenId = context.Ipo.CellId,
                CellType = (int)context.CellType,
                OrderStatus = (int)OrderStatus.Initial,
                RecDate = DateTime.UtcNow
            };
            await _betMo.AddAsync(item, tm);
        }
        public static List<FloorInfo> BuildList(List<FloorInfo> cellInfoList, int levelId)
        {
            var level = MemoryUtil.GetLevelByPk(levelId);
            var showFloor = cellInfoList.Where(x => x.OpenCellId == 0);
            foreach (var floor in showFloor)
            {
                List<int> ints = new();
                for (int i = 0; i < level.DiamodNum; i++)
                {
                    ints.Add((int)CellType.Diamod);
                }
                for (int i = 0; i < level.MineNum; i++)
                {
                    ints.Add((int)CellType.Mine);
                }
                floor.CellTypeList = ints.OrderBy(x => Guid.NewGuid()).ToList();
            }
            //已开启的楼层
            var openFloor = cellInfoList.Where(x => x.OpenCellId > 0);
            foreach (var open in openFloor)
            {
                var hasMine = open.CellTypeList.Count(x => x == (int)CellType.Mine) > 0;
                if (!hasMine)
                {
                    List<int> _cellTypeList = new(open.CellTypeList);
                    var diamodIndex = _cellTypeList.FindIndex(x => x == (int)CellType.Diamod);
                    _cellTypeList.RemoveAt(diamodIndex);
                    //余下地雷
                    int _mine = level.MineNum;
                    for (int i = 0; i < _cellTypeList.Count; i++)
                    {
                        if (_cellTypeList[i] == 0)
                        {
                            if (_mine > 0)
                            {
                                _cellTypeList[i] = (int)CellType.Mine;
                                _mine--;
                            }
                            else
                            {
                                _cellTypeList[i] = (int)CellType.Diamod;
                            }
                        }
                    }
                    _cellTypeList = _cellTypeList.OrderBy(x => Guid.NewGuid()).ToList();
                    _cellTypeList.Insert(diamodIndex, (int)CellType.Diamod);
                    open.CellTypeList = _cellTypeList;
                }
                else
                {
                    for (int i = 0; i < open.CellTypeList.Count; i++)
                    {
                        if (open.CellTypeList[i] == (int)CellType.No)
                        {
                            open.CellTypeList[i] = (int)CellType.Diamod;
                        }
                    }

                }
            }
            return cellInfoList.OrderBy(x => x.Id).ToList();
        }
        /// <summary>
        /// 按权重生成值
        /// </summary>
        /// <returns>索引</returns>
        public static int GetWeightByAvg()
        {
            List<int> weightList = new() { 10, 10, 10 };
            //中奖几率随机数 [0,100)
            var count = weightList.Sum();
            var random = new Random().Next(count);
            int startNum = 0;
            int index = 0;
            foreach (var w in weightList)
            {
                if (random >= startNum && random < (w + startNum))
                {
                    return index;
                }
                startNum += w;
                index++;
            }
            return 0;
        }
    }
}
