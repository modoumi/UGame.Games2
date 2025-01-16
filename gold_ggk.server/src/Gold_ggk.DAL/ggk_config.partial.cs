using System;
using System.Linq;
using System.Text;
using SqlSugar;
using TinyFx.Data.SqlSugar;

namespace Gold_ggk.DAL
{
    
    [SugarConfigId("gdb")]
    public partial class Ggk_configPO
    {
        #region tinyfx
        public static implicit operator Ggk_configEO(Ggk_configPO value)
        {
            if (value==null) return null;
            return new Ggk_configEO
            {
		        OperatorID = value.OperatorID,
		        CurrencyID = value.CurrencyID,
		        IncomeRatio = value.IncomeRatio,
            };
        }
        public static implicit operator Ggk_configPO(Ggk_configEO value)
        {
            if (value==null) return null;
            return new Ggk_configPO
            {
		        OperatorID = value.OperatorID,
		        CurrencyID = value.CurrencyID,
		        IncomeRatio = value.IncomeRatio,
            };
        }
        #endregion
    }
}