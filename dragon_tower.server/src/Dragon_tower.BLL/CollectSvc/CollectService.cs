using Dragon_tower.BLL.Core;
using Dragon_tower.DAL;
using Mines.BLL.Core;
using TinyFx;
using Xxyy.GameEAPI.Common;
using Xxyy.GameEAPI.Core;
using Xxyy.GameEAPI.Services;

namespace Dragon_tower.BLL
{
    public class CollectService : BaseApiGameService
    {
        private Gdt_user_extMO _extMo = new();
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
            ret.PlayerInfo.Balance = await GameEAPIUtil.GetBalanceMoney(ipo.UserId, appToken.AppId, appToken.CurrencyId);

            ret.GameInfo.BaseBet = extEo.BetBaseAmount.AToM(appToken.CurrencyId);
            ret.GameInfo.FloorInfoList = GdtUtil.BuildList(SerializerUtil.DeserializeJsonNet<List<FloorInfo>>(extEo.FloorInfo), extEo.LevelId);
            ret.GameInfo.GameStatus = extEo.GameStatus;
            ret.GameInfo.Level = extEo.LevelId;
            ret.GameInfo.Win = extEo.WinAmount.AToM(appToken.CurrencyId);

            extEo = GdtUtil.UserExtInit(ipo.UserId, extEo.LevelId, extEo.BetBaseAmount);
            await _extMo.PutAsync(extEo);

            return ret;
        }

    }
}