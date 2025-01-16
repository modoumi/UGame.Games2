using System;
using System.Linq;
using System.Text;
using SqlSugar;
using TinyFx.Data.SqlSugar;

namespace Dwin_poker.DAL
{
    
    [SugarConfigId("gdb")]
    public partial class Dwp_configPO
    {
        #region tinyfx
        public static implicit operator Dwp_configEO(Dwp_configPO value)
        {
            if (value==null) return null;
            return new Dwp_configEO
            {
		        OperatorID = value.OperatorID,
		        CurrencyID = value.CurrencyID,
		        JPRatio = value.JPRatio,
		        IncomeRatio = value.IncomeRatio,
		        RankRatio = value.RankRatio,
		        JPValTH = value.JPValTH,
		        MaxBetAmount = value.MaxBetAmount,
		        MaxStar = value.MaxStar,
		        MaxCardNum = value.MaxCardNum,
		        JPTotalRatio = value.JPTotalRatio,
		        JPInventedAmount = value.JPInventedAmount,
            };
        }
        public static implicit operator Dwp_configPO(Dwp_configEO value)
        {
            if (value==null) return null;
            return new Dwp_configPO
            {
		        OperatorID = value.OperatorID,
		        CurrencyID = value.CurrencyID,
		        JPRatio = value.JPRatio,
		        IncomeRatio = value.IncomeRatio,
		        RankRatio = value.RankRatio,
		        JPValTH = value.JPValTH,
		        MaxBetAmount = value.MaxBetAmount,
		        MaxStar = value.MaxStar,
		        MaxCardNum = value.MaxCardNum,
		        JPTotalRatio = value.JPTotalRatio,
		        JPInventedAmount = value.JPInventedAmount,
            };
        }
        #endregion
    }
}