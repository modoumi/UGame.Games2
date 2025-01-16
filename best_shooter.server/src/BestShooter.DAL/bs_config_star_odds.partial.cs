using System;
using System.Linq;
using System.Text;
using SqlSugar;
using TinyFx.Data.SqlSugar;

namespace BestShooter.DAL
{
    
    [SugarConfigId("gdb")]
    public partial class Bs_config_star_oddsPO
    {
        #region tinyfx
        public static implicit operator Bs_config_star_oddsEO(Bs_config_star_oddsPO value)
        {
            if (value==null) return null;
            return new Bs_config_star_oddsEO
            {
		        StarID = value.StarID,
		        OperatorID = value.OperatorID,
		        CurrencyID = value.CurrencyID,
		        Goal = value.Goal,
		        Position = value.Position,
		        Multiple = value.Multiple,
		        Odds = value.Odds,
		        IsBaseMultiple = value.IsBaseMultiple,
		        Surprise = value.Surprise,
		        RecDate = value.RecDate,
            };
        }
        public static implicit operator Bs_config_star_oddsPO(Bs_config_star_oddsEO value)
        {
            if (value==null) return null;
            return new Bs_config_star_oddsPO
            {
		        StarID = value.StarID,
		        OperatorID = value.OperatorID,
		        CurrencyID = value.CurrencyID,
		        Goal = value.Goal,
		        Position = value.Position,
		        Multiple = value.Multiple,
		        Odds = value.Odds,
		        IsBaseMultiple = value.IsBaseMultiple,
		        Surprise = value.Surprise,
		        RecDate = value.RecDate,
            };
        }
        #endregion
    }
}