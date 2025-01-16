using System;
using System.Linq;
using System.Text;
using SqlSugar;
using TinyFx.Data.SqlSugar;

namespace Dragon_tower.DAL
{
    
    [SugarConfigId("gdb")]
    public partial class Gdt_configPO
    {
        #region tinyfx
        public static implicit operator Gdt_configEO(Gdt_configPO value)
        {
            if (value==null) return null;
            return new Gdt_configEO
            {
		        OperatorID = value.OperatorID,
		        CurrencyID = value.CurrencyID,
		        IncomeRatio = value.IncomeRatio,
		        LevelId = value.LevelId,
		        MinBet = value.MinBet,
		        MaxBet = value.MaxBet,
		        ReturnRatio = value.ReturnRatio,
            };
        }
        public static implicit operator Gdt_configPO(Gdt_configEO value)
        {
            if (value==null) return null;
            return new Gdt_configPO
            {
		        OperatorID = value.OperatorID,
		        CurrencyID = value.CurrencyID,
		        IncomeRatio = value.IncomeRatio,
		        LevelId = value.LevelId,
		        MinBet = value.MinBet,
		        MaxBet = value.MaxBet,
		        ReturnRatio = value.ReturnRatio,
            };
        }
        #endregion
    }
}