using System;
using System.Linq;
using System.Text;
using SqlSugar;
using TinyFx.Data.SqlSugar;

namespace Mines.DAL
{
    
    [SugarConfigId("gdb")]
    public partial class Mines_configPO
    {
        #region tinyfx
        public static implicit operator Mines_configEO(Mines_configPO value)
        {
            if (value==null) return null;
            return new Mines_configEO
            {
		        OperatorID = value.OperatorID,
		        CurrencyID = value.CurrencyID,
		        IncomeRatio = value.IncomeRatio,
		        MinMine = value.MinMine,
		        MaxMine = value.MaxMine,
		        MinBet = value.MinBet,
		        MaxBet = value.MaxBet,
            };
        }
        public static implicit operator Mines_configPO(Mines_configEO value)
        {
            if (value==null) return null;
            return new Mines_configPO
            {
		        OperatorID = value.OperatorID,
		        CurrencyID = value.CurrencyID,
		        IncomeRatio = value.IncomeRatio,
		        MinMine = value.MinMine,
		        MaxMine = value.MaxMine,
		        MinBet = value.MinBet,
		        MaxBet = value.MaxBet,
            };
        }
        #endregion
    }
}