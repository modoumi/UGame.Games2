using System;
using System.Linq;
using System.Text;
using SqlSugar;
using TinyFx.Data.SqlSugar;

namespace Dwin_poker.DAL
{
    
    [SugarConfigId("gdb")]
    public partial class Dwp_config_star_weightPO
    {
        #region tinyfx
        public static implicit operator Dwp_config_star_weightEO(Dwp_config_star_weightPO value)
        {
            if (value==null) return null;
            return new Dwp_config_star_weightEO
            {
		        StarNum = value.StarNum,
		        Multip = value.Multip,
		        HitRatio = value.HitRatio,
            };
        }
        public static implicit operator Dwp_config_star_weightPO(Dwp_config_star_weightEO value)
        {
            if (value==null) return null;
            return new Dwp_config_star_weightPO
            {
		        StarNum = value.StarNum,
		        Multip = value.Multip,
		        HitRatio = value.HitRatio,
            };
        }
        #endregion
    }
}