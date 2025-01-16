using System;
using System.Linq;
using System.Text;
using SqlSugar;
using TinyFx.Data.SqlSugar;

namespace Gold_ggk.DAL
{
    
    [SugarConfigId("gdb")]
    public partial class Ggk_config_weight_jackpotPO
    {
        #region tinyfx
        public static implicit operator Ggk_config_weight_jackpotEO(Ggk_config_weight_jackpotPO value)
        {
            if (value==null) return null;
            return new Ggk_config_weight_jackpotEO
            {
		        JPID = value.JPID,
		        Mulitp = value.Mulitp,
		        Weight = value.Weight,
		        Group = value.Group,
            };
        }
        public static implicit operator Ggk_config_weight_jackpotPO(Ggk_config_weight_jackpotEO value)
        {
            if (value==null) return null;
            return new Ggk_config_weight_jackpotPO
            {
		        JPID = value.JPID,
		        Mulitp = value.Mulitp,
		        Weight = value.Weight,
		        Group = value.Group,
            };
        }
        #endregion
    }
}