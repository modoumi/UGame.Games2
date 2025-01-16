using Dragon_tower.BLL.Core;
using Dragon_tower.DAL;
using Mines.BLL.Core;
using TinyFx;
using Xxyy.Common.Caching.Partner;
using static Dragon_tower.BLL.Caching.MemoryUtil;

namespace Dragon_tower.BLL
{
    public class BetContext
    {
        public BetIpo Ipo { get; set; }
        public string UserId => Ipo.UserId;
        public string CurrencyId => Ipo.CurrencyId;
        public AppLoginTokenDO AppLoginTokenDo { get; }
        public string OperatorId => AppLoginTokenDo.OperatorId;
        public string AppId => AppLoginTokenDo.AppId;
        public string ProviderId => AppLoginTokenDo.ProviderId;
        public long BetId { get; set; }
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
        public long RealWinAmount => UserExt.WinAmount * IsWin;
        public Gdt_configEO Config { get; }
        public Gdt_config_levelEO Config_Level { get; }
        public Gdt_user_extEO UserExt { get; set; }
        /// <summary>
        /// 上次下注金额
        /// </summary>
        public long PreWinAmount { get; set; }
        public bool IsOver { get; set; }
        public double Multip { get; set; }
        public CellType CellType { get; set; }

        public BetContext(BetIpo ipo, AppLoginTokenDO appToken)
        {
            Ipo = ipo;
            AppLoginTokenDo = appToken;
            Config = GetConfig(OperatorId, CurrencyId);
            UserExt = new Gdt_user_extMO().GetByPK(UserId);
            if (UserExt == null)
            {
                throw new CustomException(GameCodes.RS_USERINITEXCEP, "user_ext is null 初始化异常");
            }
            PreWinAmount = UserExt.WinAmount;
            Config_Level = GetLevelByPk(UserExt.LevelId);
        }

        public class BetPartAmount
        {
            public long PartMiniGameTotalVal { get; set; }
            public long PartBaseAmount { get; set; }
            public long PartIncomeAmount { get; set; }
        }
    }
}
