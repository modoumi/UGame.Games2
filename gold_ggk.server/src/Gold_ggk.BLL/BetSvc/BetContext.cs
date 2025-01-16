using Gold_ggk.BLL.LoadSvc;
using Gold_ggk.DAL;
using Xxyy.Common.Caching.Partner;
using static Gold_ggk.BLL.Caching.MemoryUtil;

namespace Gold_ggk.BLL.BetSvc
{
    public class BetContext
    {
        public BetIpo Ipo { get; set; }
        public string UserId => Ipo.UserId;
        public string CurrencyId => Ipo.CurrencyId;
        public AppLoginTokenDO LoginTokenDo { get; }
        public string OperatorId => LoginTokenDo.OperatorId;
        public string AppId => LoginTokenDo.AppId;
        public string ProviderId => LoginTokenDo.ProviderId;
        public long BetId { get; set; }
        public BetPartAmount PartAmount { get; } = new();
        public double IncomeRatio { get; set; }
        public ResultInfo ResultInfo { get; set; } = new();
        /// <summary>
        /// 是否操作过用户账户
        /// </summary>
        public bool IsChangeBalance { get; set; }
        /// <summary>
        /// 赢得总奖金，包含JP奖金
        /// </summary>
        public long WinTotalAmount { get; set; }
        public Config_Chips Config_Chips { get; set; }
        public Ggk_user_extEO UserExt { get; set; }
        public List<Chips> MetaChips { get; set; }
        public string AllNumList { get; set; }
        public bool isFreeSpin { get; }
        public string HistoryList { get; set; }
        public long JPRewardValue { get; set; }
        public long RealBetAmount { get; set; }
        public List<long> YesAmount { get; set; }
        public BetContext(BetIpo ipo, AppLoginTokenDO token)
        {
            Ipo = ipo;
            LoginTokenDo = token;
            Config_Chips = GetChips(ipo.ChipsId);
            MetaChips = GetMetaChips(ipo.CurrencyId);
            UserExt = GetUserExt(ipo.UserId, ipo.ChipsId);
            isFreeSpin = false;// UserExt.FreeSpinCount > 0;
        }

        public class BetPartAmount
        {
            public long PartJpAmount { get; set; }
            public long PartBaseAmount { get; set; }
            public long PartIncomeAmount { get; set; }
        }
    }
}
