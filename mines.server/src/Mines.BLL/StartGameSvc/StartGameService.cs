using Mines.BLL.Core;
using Mines.BLL.LoadSvc;
using Mines.DAL;
using TinyFx;
using Xxyy.GameEAPI.Common;
using Xxyy.GameEAPI.Core;
using Xxyy.GameEAPI.Services;

namespace Mines.BLL
{
    public class StartGameService : BaseApiGameService
    {
        private readonly Mines_user_extMO _extMo = new();
        public async Task<StartGameDto> StartGame(StartGameIpo ipo)
        {
            await CheckIdentityAndMock(ipo.UserId);
            var appToken = GetLoginTokenDo(ipo.UserId);
            var extEo = await _extMo.GetByPKAsync(ipo.UserId);
            if (extEo == null)
            {
                throw new CustomException(GameCodes.RS_USERINITEXCEP, "user_ext is null 初始化异常");
            }
            var balance = await GameEAPIUtil.GetBalanceMoney(ipo.UserId, appToken.AppId, ipo.CurrencyId);
            if (balance < ipo.BaseBet)
            {
                throw new CustomException(CommonCodes.RS_NOT_ENOUGH_MONEY, "余额不足");
            }
            extEo = MinesUtil.UserExtInit(ipo.UserId, ipo.Mines, ipo.BaseBet.MToA(appToken.CurrencyId));
            extEo.GameStatus = (int)GameStatus.Start;
            var result = await _extMo.PutAsync(extEo);
            var ret = new StartGameDto();
            if (result > 0)
            {
                ret.ResultInfo.GameInfo.BaseBet = extEo.BetBaseAmount.AToM(appToken.CurrencyId);
                ret.ResultInfo.GameInfo.CellInfo = SerializerUtil.DeserializeJsonNet<List<CellInfo>>(extEo.CellInfo);
                ret.ResultInfo.GameInfo.GameStatus = extEo.GameStatus;
                ret.ResultInfo.GameInfo.Mines = extEo.Mines;
                ret.ResultInfo.GameInfo.Win = extEo.WinAmount.AToM(appToken.CurrencyId);
                MinesUtil.SetGameInfoMultip(extEo, ret.ResultInfo.GameInfo);
            }
            return ret;
        }
    }
}