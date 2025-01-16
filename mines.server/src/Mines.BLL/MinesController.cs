using Microsoft.AspNetCore.Mvc;
using Mines.BLL.LoadSvc;
using TinyFx.AspNet;

namespace Mines.BLL
{
    public class MinesController : TinyFxControllerBase
    {
        #region init
        private LoadService _loadSvc = new();
        private BetService _slotSvc = new();
        private StartGameService _startGameDto = new();
        private CollectService _collectSvc = new();
        #endregion

        [HttpPost]
        public async Task<LoadDto> Load(LoadIpo ipo)
        {
            return await _loadSvc.Load(ipo);
        }

        [HttpPost]
        public async Task<StartGameDto> StartGame(StartGameIpo ipo)
        {
            return await _startGameDto.StartGame(ipo);
        }

        [HttpPost]
        public async Task<BetDto> Bet(BetIpo ipo)
        {
            return await _slotSvc.Bet(ipo);
        }
        [HttpPost]
        public async Task<CollectDto> Collect(CollectIpo ipo)
        {
            return await _collectSvc.Collect(ipo);
        }
    }
}