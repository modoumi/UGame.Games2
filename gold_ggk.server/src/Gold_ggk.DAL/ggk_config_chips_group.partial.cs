using System;
using System.Linq;
using System.Text;
using SqlSugar;
using TinyFx.Data.SqlSugar;

namespace Gold_ggk.DAL
{
    
    [SugarConfigId("gdb")]
    public partial class Ggk_config_chips_groupPO
    {
        #region tinyfx
        public static implicit operator Ggk_config_chips_groupEO(Ggk_config_chips_groupPO value)
        {
            if (value==null) return null;
            return new Ggk_config_chips_groupEO
            {
		        ChipsID = value.ChipsID,
		        BetTotalAmount = value.BetTotalAmount,
		        Group = value.Group,
            };
        }
        public static implicit operator Ggk_config_chips_groupPO(Ggk_config_chips_groupEO value)
        {
            if (value==null) return null;
            return new Ggk_config_chips_groupPO
            {
		        ChipsID = value.ChipsID,
		        BetTotalAmount = value.BetTotalAmount,
		        Group = value.Group,
            };
        }
        #endregion
    }
}