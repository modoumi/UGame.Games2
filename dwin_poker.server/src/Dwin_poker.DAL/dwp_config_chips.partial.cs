using System;
using System.Linq;
using System.Text;
using SqlSugar;
using TinyFx.Data.SqlSugar;

namespace Dwin_poker.DAL
{
    
    [SugarConfigId("gdb")]
    public partial class Dwp_config_chipsPO
    {
        #region tinyfx
        public static implicit operator Dwp_config_chipsEO(Dwp_config_chipsPO value)
        {
            if (value==null) return null;
            return new Dwp_config_chipsEO
            {
		        ChipsID = value.ChipsID,
		        BetBaseAmount = value.BetBaseAmount,
		        JPMini = value.JPMini,
		        JPMajor = value.JPMajor,
		        JPMega = value.JPMega,
            };
        }
        public static implicit operator Dwp_config_chipsPO(Dwp_config_chipsEO value)
        {
            if (value==null) return null;
            return new Dwp_config_chipsPO
            {
		        ChipsID = value.ChipsID,
		        BetBaseAmount = value.BetBaseAmount,
		        JPMini = value.JPMini,
		        JPMajor = value.JPMajor,
		        JPMega = value.JPMega,
            };
        }
        #endregion
    }
}