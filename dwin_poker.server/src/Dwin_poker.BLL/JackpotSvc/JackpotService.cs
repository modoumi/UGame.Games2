using Dwin_poker.DAL;
using Xxyy.GameEAPI.Services;

namespace Dwin_poker.BLL.JackpotSvc
{
    public class JackpotService : BaseApiGameService
    {
        private Dwp_pool_jackpotMO _poolJpMo = new();
        public async Task<JackpotDto> Jackpot(JackpotIpo ipo)
        {
            await CheckIdentityAndMock(ipo.UserId);
            var context = GetLoginTokenDo(ipo.UserId);
            var ret = new JackpotDto();
            ret.JpInfo.Value = await PokerUtil.GetPoolValByPKAsync(context.OperatorId, ipo.CurrencyId);
            return ret;
        }
    }
}
