using System;
using System.Linq;
using System.Text;
using SqlSugar;
using TinyFx.Data.SqlSugar;

namespace BestShooter.DAL
{
    
    [SugarConfigId("gdb")]
    public partial class Bs_config_jackpot_oddsPO
    {
        #region tinyfx
        public static implicit operator Bs_config_jackpot_oddsEO(Bs_config_jackpot_oddsPO value)
        {
            if (value==null) return null;
            return new Bs_config_jackpot_oddsEO
            {
		        JackpotOddsID = value.JackpotOddsID,
		        OperatorID = value.OperatorID,
		        CurrencyID = value.CurrencyID,
		        BetAmount = value.BetAmount,
		        Odds = value.Odds,
		        BonusAmount = value.BonusAmount,
		        StartNum = value.StartNum,
		        EndNum = value.EndNum,
		        RecDate = value.RecDate,
            };
        }
        public static implicit operator Bs_config_jackpot_oddsPO(Bs_config_jackpot_oddsEO value)
        {
            if (value==null) return null;
            return new Bs_config_jackpot_oddsPO
            {
		        JackpotOddsID = value.JackpotOddsID,
		        OperatorID = value.OperatorID,
		        CurrencyID = value.CurrencyID,
		        BetAmount = value.BetAmount,
		        Odds = value.Odds,
		        BonusAmount = value.BonusAmount,
		        StartNum = value.StartNum,
		        EndNum = value.EndNum,
		        RecDate = value.RecDate,
            };
        }
        #endregion
    }
}