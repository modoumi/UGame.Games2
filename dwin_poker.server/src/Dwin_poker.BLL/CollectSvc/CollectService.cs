using Dwin_poker.BLL.Caching;
using Dwin_poker.DAL;
using TinyFx;
using Xxyy.Common;
using Xxyy.GameEAPI.Common;
using Xxyy.GameEAPI.Core;
using Xxyy.GameEAPI.Services;

namespace Dwin_poker.BLL.CollectSvc
{
    public class CollectService : BaseApiGameService
    {
        private Dwp_pool_jackpotMO _poolJpMo = new();
        private Dwp_bet_detailMO _detailMo = new();
        public async Task<CollectDto> Collect(CollectIpo ipo)
        {
            await CheckIdentityAndMock(ipo.UserId);
            var context = GetLoginTokenDo(ipo.UserId);
            var currencyId = context.CurrencyId;
            var ret = new CollectDto();
            var list = _detailMo.GetByUserID(ipo.UserId);
            var item = list.OrderByDescending(o => o.RecDate).First();
            UserDataRedis cache = new UserDataRedis(ipo.UserId, item.ChipsID);
            UserDataDO userDataDo = cache.GetUserDataDo();
            userDataDo = cache.UserDataDoInit(userDataDo.Ext).Value;
            await PokerUtil.PutUserExt(userDataDo.Ext);
            ret.historyList = SerializerUtil.DeserializeJsonNet<List<History>>(userDataDo.History);

            ret.PlayerInfo.Balance = await GameEAPIUtil.GetBalanceMoney(ipo.UserId, context.AppId, currencyId);
            ret.GameInfo = new GameInfo
            {
                OriChipsId = userDataDo.ChipsId,
                RoundIdx = userDataDo.Ext.RoundIdx,
                CardIdx = userDataDo.CardIdx,
                BaseBet = XxyyUtil.AToM(userDataDo.BetBaseAmount, currencyId),
                Multi = userDataDo.Multip,
                TotalBet = XxyyUtil.AToM(userDataDo.BetTotalAmount, currencyId),
                BetResult = XxyyUtil.AToM(userDataDo.BetResultAmount, currencyId),
                GameStatus = (int)userDataDo.GameStatus,
                Star = userDataDo.Ext.Star,
            };

            ret.JpInfo.Value = await PokerUtil.GetPoolValByPKAsync(context.OperatorId, ipo.CurrencyId);
            return ret;
        }
    }
}
