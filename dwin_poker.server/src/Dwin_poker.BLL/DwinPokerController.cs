using Dwin_poker.BLL.BetSvc;
using Dwin_poker.BLL.CollectSvc;
using Dwin_poker.BLL.JackpotSvc;
using Dwin_poker.BLL.JpHistorySvc;
using Dwin_poker.BLL.LoadSvc;
using Dwin_poker.BLL.RankSvc;
using Microsoft.AspNetCore.Mvc;
using TinyFx.AspNet;

namespace Dwin_poker.BLL
{
    public class DwinPokerController : TinyFxControllerBase
    {
        #region init
        private LoadService _loadSvc = new();
        private BetService _betSvc = new();
        private JackpotService _JpSvc = new();
        private CollectService _collectSvc = new();
        private RankService _rankSvc = new();
        private JpHistoryService _jpHistorySvc = new();
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
        [HttpPost]
        public async Task<CollectDto> Collect(CollectIpo ipo)
        {
            return await _collectSvc.Collect(ipo);
        }
        [HttpPost]
        public async Task<JackpotDto> Jackpot(JackpotIpo ipo)
        {
            return await _JpSvc.Jackpot(ipo);
        }
        [HttpPost]
        public async Task<RankDto> Rank(RankIpo ipo)
        {
            return await _rankSvc.Rank(ipo);
        }
        [HttpPost]
        public async Task<JpHistoryDto> JpHistory(JpHistoryIpo ipo)
        {
            return await _jpHistorySvc.JpHistory(ipo);
        }
    }
}