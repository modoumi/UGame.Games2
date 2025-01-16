using System;
using System.Linq;
using System.Text;
using SqlSugar;
using TinyFx.Data.SqlSugar;

namespace Dragon_tower.DAL
{
    
    [SugarConfigId("gdb")]
    public partial class Gdt_config_levelPO
    {
        #region tinyfx
        public static implicit operator Gdt_config_levelEO(Gdt_config_levelPO value)
        {
            if (value==null) return null;
            return new Gdt_config_levelEO
            {
		        LevelID = value.LevelID,
		        CellNum = value.CellNum,
		        MineNum = value.MineNum,
		        DiamodNum = value.DiamodNum,
            };
        }
        public static implicit operator Gdt_config_levelPO(Gdt_config_levelEO value)
        {
            if (value==null) return null;
            return new Gdt_config_levelPO
            {
		        LevelID = value.LevelID,
		        CellNum = value.CellNum,
		        MineNum = value.MineNum,
		        DiamodNum = value.DiamodNum,
            };
        }
        #endregion
    }
}