using System;
using System.Linq;
using System.Text;
using SqlSugar;
using TinyFx.Data.SqlSugar;

namespace Mines.DAL
{
    
    [SugarConfigId("gdb")]
    public partial class Mines_config_chipsPO
    {
        #region tinyfx
        public static implicit operator Mines_config_chipsEO(Mines_config_chipsPO value)
        {
            if (value==null) return null;
            return new Mines_config_chipsEO
            {
		        MinesNum = value.MinesNum,
		        Diamod = value.Diamod,
		        Rate = value.Rate,
		        Multip = value.Multip,
            };
        }
        public static implicit operator Mines_config_chipsPO(Mines_config_chipsEO value)
        {
            if (value==null) return null;
            return new Mines_config_chipsPO
            {
		        MinesNum = value.MinesNum,
		        Diamod = value.Diamod,
		        Rate = value.Rate,
		        Multip = value.Multip,
            };
        }
        #endregion
    }
}