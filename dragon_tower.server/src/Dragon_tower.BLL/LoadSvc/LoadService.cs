using Dragon_tower.BLL.Caching;
using Dragon_tower.DAL;
using TinyFx;
using Xxyy.GameEAPI.Common;
using Xxyy.GameEAPI.Core;
using Xxyy.GameEAPI.Services;

namespace Dragon_tower.BLL.LoadSvc
{
    public class LoadService : BaseApiGameService
    {
        private readonly Gdt_user_extMO _extMo = new();
        public async Task<LoadDto> Load(LoadIpo ipo)
        {
            await CheckIdentityAndMock(ipo.UserId);
            var appToken = GetLoginTokenDo(ipo.UserId);
            var config = MemoryUtil.GetConfig(appToken.OperatorId, appToken.CurrencyId);
            var extEo = await GdtUtil.CheckAndInitUserData(appToken);

            //余额不足强制结算
            var blance = await GameEAPIUtil.GetBalance(ipo.UserId, appToken.AppId);
            if (blance < extEo.WinAmount)
            {
                extEo = GdtUtil.UserExtInit(ipo.UserId, extEo.LevelId, extEo.BetBaseAmount);
                await _extMo.PutAsync(extEo);
            }


            var ret = new LoadDto();
            ret.PlayerInfo.Balance = await GameEAPIUtil.GetBalanceMoney(ipo.UserId, appToken.AppId, appToken.CurrencyId);
            ret.GameInfo.BaseBet = extEo.BetBaseAmount.AToM(ipo.CurrencyId);
            ret.GameInfo.Level = extEo.LevelId;
            ret.GameInfo.Win = extEo.WinAmount.AToM(ipo.CurrencyId);
            ret.GameInfo.FloorInfoList = SerializerUtil.DeserializeJsonNet<List<FloorInfo>>(extEo.FloorInfo);
            ret.GameInfo.GameStatus = extEo.GameStatus;

            foreach (var item in MemoryUtil.GetLevelList)
            {
                ret.Meta.LevelMeta.Add(new LevelMeta { Level = item.LevelID, CellAmount = item.CellNum, MineAmount = item.MineNum });
            }

            ret.Meta.MinBet = config.MinBet.AToM(appToken.CurrencyId);
            ret.Meta.MaxBet = config.MaxBet.AToM(appToken.CurrencyId);

            return ret;
        }
    }
}
