using Dragon_tower.BLL.Core;
using Dragon_tower.DAL;
using Mines.BLL.Core;
using TinyFx;
using Xxyy.GameEAPI.Common;
using Xxyy.GameEAPI.Core;
using Xxyy.GameEAPI.Services;

namespace Dragon_tower.BLL
{
    public class StartGameService : BaseApiGameService
    {
        private readonly Gdt_user_extMO _extMo = new();
        public async Task<StartGameDto> StartGame(StartGameIpo ipo)
        {
            await CheckIdentityAndMock(ipo.UserId);
            var appToken = GetLoginTokenDo(ipo.UserId);
            var extEo = await _extMo.GetByPKAsync(ipo.UserId);
            if (extEo == null)
            {
                throw new CustomException(GameCodes.RS_USERINITEXCEP, "user_ext is null 初始化异常");
            }
            var balance = await GameEAPIUtil.GetBalanceMoney(ipo.UserId, appToken.AppId, appToken.CurrencyId);
            if (balance < ipo.BaseBet)
            {
                throw new CustomException(CommonCodes.RS_NOT_ENOUGH_MONEY, "余额不足");
            }
            extEo = GdtUtil.UserExtInit(ipo.UserId, ipo.Level, ipo.BaseBet.MToA(appToken.CurrencyId));
            extEo.GameStatus = (int)GameStatus.Start;
            var result = await _extMo.PutAsync(extEo);
            var ret = new StartGameDto();
            if (result > 0)
            {
                ret.ResultInfo.GameInfo.BaseBet = extEo.BetBaseAmount.AToM(appToken.CurrencyId);
                ret.ResultInfo.GameInfo.FloorInfoList = SerializerUtil.DeserializeJsonNet<List<FloorInfo>>(extEo.FloorInfo);
                ret.ResultInfo.GameInfo.GameStatus = extEo.GameStatus;
                ret.ResultInfo.GameInfo.Level = extEo.LevelId;
                ret.ResultInfo.GameInfo.Win = extEo.WinAmount.AToM(appToken.CurrencyId);
            }
            return ret;
        }
    }
}