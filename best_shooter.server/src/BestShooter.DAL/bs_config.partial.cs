using System;
using System.Linq;
using System.Text;
using SqlSugar;
using TinyFx.Data.SqlSugar;

namespace BestShooter.DAL
{
    
    [SugarConfigId("gdb")]
    public partial class Bs_configPO
    {
        #region tinyfx
        public static implicit operator Bs_configEO(Bs_configPO value)
        {
            if (value==null) return null;
            return new Bs_configEO
            {
		        OperatorID = value.OperatorID,
		        CurrencyID = value.CurrencyID,
		        InPublic = value.InPublic,
		        InJackpot = value.InJackpot,
		        InLucky = value.InLucky,
		        JackpotCount = value.JackpotCount,
		        JackpotRaffleAfterTax = value.JackpotRaffleAfterTax,
		        LuckyCount = value.LuckyCount,
		        LuckyStartBet = value.LuckyStartBet,
		        MaxStake = value.MaxStake,
		        MaxGoal = value.MaxGoal,
		        RecDate = value.RecDate,
            };
        }
        public static implicit operator Bs_configPO(Bs_configEO value)
        {
            if (value==null) return null;
            return new Bs_configPO
            {
		        OperatorID = value.OperatorID,
		        CurrencyID = value.CurrencyID,
		        InPublic = value.InPublic,
		        InJackpot = value.InJackpot,
		        InLucky = value.InLucky,
		        JackpotCount = value.JackpotCount,
		        JackpotRaffleAfterTax = value.JackpotRaffleAfterTax,
		        LuckyCount = value.LuckyCount,
		        LuckyStartBet = value.LuckyStartBet,
		        MaxStake = value.MaxStake,
		        MaxGoal = value.MaxGoal,
		        RecDate = value.RecDate,
            };
        }
        #endregion
    }
}