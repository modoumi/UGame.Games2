using TinyFx;
using Xxyy.GameEAPI.Services;

namespace Dwin_poker.BLL.RankSvc
{
    public class RankService : BaseApiGameService
    {
        public async Task<RankDto> Rank(RankIpo ipo)
        {
            var ret = new RankDto();
            List<RankInfo> rInfo = new List<RankInfo>();
            //本期数据
            rInfo.Add(new RankInfo
            {
                EndTime = DateTime.UtcNow.ToTimestamp(false,false),
                RankDetailList = new List<RankDetail>() {
                   new RankDetail
                   {
                         Mobile="150xxxx1234",
                         Rank =1,
                         Win = 1234.56m,
                   }
                  }
            });
            //上一期的数据
            rInfo.Add(new RankInfo
            {
                EndTime = DateTime.UtcNow.ToTimestamp(false, false),
                RankDetailList = new List<RankDetail>() {
                   new RankDetail
                   {
                         Mobile="150xxxx1234",
                         Rank =1,
                         Win = 1234.56m,
                   }
                  }
            });
            ret.RankInfoArr = rInfo;
            return ret;
        }
    }
}
