using Dwin_poker.BLL.Caching;
using TinyFx;
using Xxyy.GameEAPI.Common;
using Xxyy.GameEAPI.Core;
using Xxyy.GameEAPI.Services;

namespace Dwin_poker.BLL.LoadSvc
{
    public class LoadService : BaseApiGameService
    {

        public async Task<LoadDto> Load(LoadIpo ipo)
        {
            await CheckIdentityAndMock(ipo.UserId);
            var appToken = GetLoginTokenDo(ipo.UserId);
            var chips = MemoryUtil.GetLoadChips(ipo.CurrencyId).OrderBy(x => x.Bet).First();

            UserDataRedis _cache = new(ipo.UserId, chips.ChipsId);
            UserDataDO userDataDo = _cache.GetUserDataDo();
            var config = MemoryUtil.GetConfig(appToken.OperatorId, ipo.CurrencyId);
            var ret = new LoadDto();
            if (userDataDo != null && userDataDo.GameStatus != GameStatus.Normal)
            {
                ret.BetResetStatus = (int)userDataDo.GameStatus;
                userDataDo = _cache.UserDataDoInit(userDataDo.Ext).Value;
                await PokerUtil.PutUserExt(userDataDo.Ext);
            }
            ret.PlayerInfo.Balance = await GameEAPIUtil.GetBalanceMoney(ipo.UserId, appToken.AppId, ipo.CurrencyId);

            ret.GameInfo = new GameInfo
            {
                OriChipsId = userDataDo.ChipsId,
                RoundIdx = userDataDo.Ext.RoundIdx,
                CardIdx = userDataDo.CardIdx,
                BaseBet = XxyyUtil.AToM(userDataDo.BetBaseAmount, ipo.CurrencyId),
                Multi = userDataDo.Multip,
                TotalBet = XxyyUtil.AToM(userDataDo.BetTotalAmount, ipo.CurrencyId),
                BetResult = XxyyUtil.AToM(userDataDo.BetResultAmount, ipo.CurrencyId),
                GameStatus = (int)userDataDo.GameStatus,
                Star = userDataDo.Ext.Star,
            };

            ret.HistoryList = SerializerUtil.DeserializeJsonNet<List<History>>(userDataDo.History);
            ret.JpInfo.Value = await PokerUtil.GetPoolValByPKAsync(appToken.OperatorId, ipo.CurrencyId);

            ret.Meta.MaxStar = config.MaxStar;
            ret.Meta.MaxBet = XxyyUtil.AToM(config.MaxBetAmount, ipo.CurrencyId);
            ret.Meta.RankReward = XxyyUtil.AToM(MemoryUtil.GetRankFrist().RankReward, ipo.CurrencyId);
            ret.Meta.ChipsList = MemoryUtil.GetLoadChips(ipo.CurrencyId);

            return ret;
        }
    }
}
