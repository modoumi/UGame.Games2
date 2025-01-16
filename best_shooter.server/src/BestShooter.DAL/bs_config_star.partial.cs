using System;
using System.Linq;
using System.Text;
using SqlSugar;
using TinyFx.Data.SqlSugar;

namespace BestShooter.DAL
{
    
    [SugarConfigId("gdb")]
    public partial class Bs_config_starPO
    {
        #region tinyfx
        public static implicit operator Bs_config_starEO(Bs_config_starPO value)
        {
            if (value==null) return null;
            return new Bs_config_starEO
            {
		        StarID = value.StarID,
		        OperatorID = value.OperatorID,
		        CurrencyID = value.CurrencyID,
		        OrderNum = value.OrderNum,
		        Status = value.Status,
		        RecDate = value.RecDate,
            };
        }
        public static implicit operator Bs_config_starPO(Bs_config_starEO value)
        {
            if (value==null) return null;
            return new Bs_config_starPO
            {
		        StarID = value.StarID,
		        OperatorID = value.OperatorID,
		        CurrencyID = value.CurrencyID,
		        OrderNum = value.OrderNum,
		        Status = value.Status,
		        RecDate = value.RecDate,
            };
        }
        #endregion
    }
}