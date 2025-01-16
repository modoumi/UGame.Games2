using Mines.BLL.Caching;
using Mines.BLL.Core;
using Mines.DAL;
using TinyFx;
using Xxyy.GameEAPI.Common;
using Xxyy.GameEAPI.Core;
using Xxyy.GameEAPI.Services;

namespace Mines.BLL.LoadSvc
{
    public class LoadService : BaseApiGameService
    {
        private readonly Mines_user_extMO _extMo = new();
        public async Task<LoadDto> Load(LoadIpo ipo)
        {
            await CheckIdentityAndMock(ipo.UserId);
            var appToken = GetLoginTokenDo(ipo.UserId);
            var config = DBCacheUtil.GetConfig(appToken.OperatorId, appToken.CurrencyId);
            var extEo = await MinesUtil.CheckAndInitUserData(appToken);
            var blance = await GameEAPIUtil.GetBalance(ipo.UserId, appToken.AppId);
            if (blance < extEo.WinAmount)
            {
                extEo.GameStatus = (int)GameStatus.Init;
                await _extMo.PutGameStatusByPKAsync(extEo.UserID, extEo.GameStatus);
            }

            var ret = new LoadDto();

            ret.PlayerInfo.Balance = await GameEAPIUtil.GetBalanceMoney(ipo.UserId, appToken.AppId, ipo.CurrencyId);
            ret.GameInfo.BaseBet = extEo.BetBaseAmount.AToM(ipo.CurrencyId);
            ret.GameInfo.Mines = extEo.Mines;
            ret.GameInfo.Win = extEo.WinAmount.AToM(ipo.CurrencyId);
            ret.GameInfo.GameStatus = extEo.GameStatus;
            ret.GameInfo.CellInfo = SerializerUtil.DeserializeJsonNet<List<CellInfo>>(extEo.CellInfo);
            MinesUtil.SetGameInfoMultip(extEo, ret.GameInfo);

            ret.Meta.MinMine = config.MinMine;
            ret.Meta.MaxMine = config.MaxMine;
            ret.Meta.MinBet = config.MinBet.AToM(appToken.CurrencyId);
            ret.Meta.MaxBet = config.MaxBet.AToM(appToken.CurrencyId);

            return ret;
        }
    }
}
