using Gold_ggk.BLL.Caching;
using Xxyy.GameEAPI.Core;
using Xxyy.GameEAPI.Services;

namespace Gold_ggk.BLL.LoadSvc
{
    public class LoadService : BaseApiGameService
    {

        public async Task<LoadDto> Load(LoadIpo ipo)
        {
            await CheckIdentityAndMock(ipo.UserId);
            var appToken = GetLoginTokenDo(ipo.UserId);

            await GoldUtil.CheckAndInitUserData(ipo.UserId, appToken.OperatorId, ipo.CurrencyId);

            var ret = new LoadDto();
            ret.PlayerInfo.Balance = await GameEAPIUtil.GetBalanceMoney(ipo.UserId, appToken.AppId, ipo.CurrencyId);
            ret.Meta.ChipsList = MemoryUtil.GetMetaChips(ipo.CurrencyId);
            foreach (var item in MemoryUtil.GetUserExtList(ipo.UserId))
            {
                ret.GameInfo.Add(new GameInfo
                {
                    ChipsId = item.ChipsID,
                    BetCounter = item.RoundIdx,
                    FreeSpinCount = item.FreeSpinCount,
                });
            }
            return ret;
        }

    }
}
