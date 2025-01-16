using Dwin_poker.DAL;
using TinyFx;
using Xxyy.GameEAPI.Common;
using Xxyy.GameEAPI.Services;

namespace Dwin_poker.BLL.JpHistorySvc
{
    public class JpHistoryService : BaseApiGameService
    {
        Dwp_user_jphistoryMO _JphistoryMO = new();
        public async Task<JpHistoryDto> JpHistory(JpHistoryIpo ipo)
        {
            List<Dwp_user_jphistoryEO> jphistoryEO = _JphistoryMO.GetPagerList(10, ipo.PageIdx, "CurrencyId=@CurrencyId", "RecDate DESC", new object[] { ipo.CurrencyId });
            List<JpHistory> JpHistoryList = new();
            foreach (var item in jphistoryEO)
            {
                JpHistoryList.Add(new JpHistory
                {
                    Mobile = ipo.UserId,
                    RecDate = item.RecDate.ToTimestamp(false, false),
                    Win = XxyyUtil.AToM(item.WinAmount, ipo.CurrencyId)
                });
            }
            var ret = new JpHistoryDto
            {
                PageIdx = ipo.PageIdx,
                JpHistoryList = JpHistoryList,
            };
            return ret;
        }
    }
}
