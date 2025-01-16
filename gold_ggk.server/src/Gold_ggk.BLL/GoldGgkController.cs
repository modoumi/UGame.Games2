using Gold_ggk.BLL.BetSvc;
using Gold_ggk.BLL.LoadSvc;
using Microsoft.AspNetCore.Mvc;
using TinyFx.AspNet;

namespace Gold_ggk.BLL
{
    public class GoldGgkController : TinyFxControllerBase
    {
        #region init
        private LoadService _loadSvc = new();
        private BetService _betSvc = new();
        #endregion

        [HttpPost]
        public async Task<LoadDto> Load(LoadIpo ipo)
        {
            return await _loadSvc.Load(ipo);
        }

        [HttpPost]
        public async Task<BetDto> Bet(BetIpo ipo)
        {
            return await _betSvc.Bet(ipo);
        }
    }
}