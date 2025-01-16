using Dwin_poker.BLL.Caching;
using Dwin_poker.DAL;
using TinyFx;
using Xxyy.Common.Caching.Partner;
using Xxyy.GameEAPI.Common;
using Xxyy.GameEAPI.Core;

namespace Dwin_poker.BLL.BetSvc
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
        /// <summary>
        /// 每颗星对应的中奖概率
        /// </summary>
        public double StarRatio { get; }
        /// <summary>
        /// JP阈值
        /// </summary>
        public int JPValTH { get; set; }
        public ResultInfo ResultInfo { get; set; } = new();
        public Dwp_config_chipsEO Chips { get; }
        public long MaxBetAmount { get; set; }
        public int MaxStar { get; set; }
        public int MaxCardNum { get; set; }
        public long JPInventedAmount { get; set; }
        public string NickName { get; set; }
        /// <summary>
        /// 是否操作过用户账户
        /// </summary>
        public bool IsChangeBalance { get; set; }
        public double JPTotalRatio { get; set; }
        public UserDataRedis UserRedis { get; }
        public UserDataDO UserDataDo { get; }
        public Dwp_config_star_weightEO Star_WeightEO { get; }
        public BetContext(BetIpo ipo, AppLoginTokenDO token)
        {
            Ipo = ipo;
            LoginTokenDo = token;
            Chips = MemoryUtil.GetChips(ipo.ChipsId);

            UserRedis = new UserDataRedis(UserId, ipo.ChipsId);
            UserDataDo = UserRedis.GetUserDataDo();
            Star_WeightEO = MemoryUtil.GetStarWeight(UserDataDo.Ext.Star);
            StarRatio = Star_WeightEO == null ? 0 : Star_WeightEO.HitRatio;
          
            if (UserDataDo.Ext.UserStatus != (int)PokerUserStatus.Normal)
                throw new CustomException(CommonCodes.UserStatusError, $"BetService用户状态异常。userId: {UserId}");
        }

        public class BetPartAmount
        {
            public long PartJpAmount { get; set; }
            public long PartRankAmount { get; set; }
            public long PartBaseAmount { get; set; }
            public long PartIncomeAmount { get; set; }
        }
    }
}
