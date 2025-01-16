using Mines.BLL.Core;
using Mines.DAL;
using Xxyy.Common.Caching.Partner;
using static Mines.BLL.Caching.DBCacheUtil;

namespace Mines.BLL
{
    public class BetContext
    {
        public BetIpo Ipo { get; set; }
        public string UserId => Ipo.UserId;
        public string CurrencyId => Ipo.CurrencyId;
        public AppLoginTokenDO LoginTokenDo { get; }
        public string OperatorId => LoginTokenDo.OperatorId;
        public string AppId => LoginTokenDo.AppId;
        public BetPartAmount PartAmount { get; } = new();
        public ResultInfo ResultInfo { get; set; } = new();
        /// <summary>
        /// 是否操作过用户账户
        /// </summary>
        public bool IsChangeBalance { get; set; }
        /// <summary>
        /// 是否中奖
        /// </summary>
        public int IsWin { get; set; }
        /// <summary>
        /// 上次下注金额
        /// </summary>
        public long PreWinAmount { get; set; }
        public long BetId { get; set; }
        public long RealWinAmount => UserExt.WinAmount * IsWin;
        public Mines_configEO Config { get; }
        public List<Mines_config_chipsEO> Chips { get; }
        public Mines_user_extEO UserExt { get; set; }
        public double Multip { get; set; }
        public double NextMultip { get; set; }
        public int CellOpenNum { get; set; }
        public CellType CellType { get; set; }
        public bool IsRateWin { get; set; }
        public BetContext(BetIpo ipo, AppLoginTokenDO appToken)
        {
            Ipo = ipo;
            LoginTokenDo = appToken;
            Config = GetConfig(OperatorId, CurrencyId);
            Chips = GetChipsList();
        }

        public class BetPartAmount
        {
            public long PartMiniGameTotalVal { get; set; }
            public long PartBaseAmount { get; set; }
            public long PartIncomeAmount { get; set; }
        }
    }
}
