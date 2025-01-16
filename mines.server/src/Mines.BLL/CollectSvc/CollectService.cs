using Mines.BLL.Core;
using Mines.BLL.LoadSvc;
using Mines.DAL;
using TinyFx;
using Xxyy.GameEAPI.Common;
using Xxyy.GameEAPI.Core;
using Xxyy.GameEAPI.Services;

namespace Mines.BLL
{
    public class CollectService : BaseApiGameService
    {
        private Mines_user_extMO _extMo = new();
        public async Task<CollectDto> Collect(CollectIpo ipo)
        {
            await CheckIdentityAndMock(ipo.UserId);
            var appToken = GetLoginTokenDo(ipo.UserId);
            var extEo = await _extMo.GetByPKAsync(ipo.UserId);
            if (extEo == null)
            {
                throw new CustomException(GameCodes.RS_USERINITEXCEP, "user_ext is null 初始化异常");
            }
            extEo.GameStatus = (int)GameStatus.Init;
            var ret = new CollectDto();
            ret.PlayerInfo.Balance = await GameEAPIUtil.GetBalanceMoney(ipo.UserId, appToken.AppId, ipo.CurrencyId);

            ret.GameInfo.BaseBet = extEo.BetBaseAmount.AToM(appToken.CurrencyId);
            ret.GameInfo.CellInfo = MinesUtil.BuildList(SerializerUtil.DeserializeJsonNet<List<CellInfo>>(extEo.CellInfo), extEo.Mines);
            ret.GameInfo.GameStatus = extEo.GameStatus;
            ret.GameInfo.Mines = extEo.Mines;
            ret.GameInfo.Win = extEo.WinAmount.AToM(appToken.CurrencyId);
            MinesUtil.SetGameInfoMultip(extEo, ret.GameInfo);
            extEo = MinesUtil.UserExtInit(ipo.UserId, extEo.Mines, extEo.BetBaseAmount);
            await _extMo.PutAsync(extEo);

            return ret;
        }

    }
}