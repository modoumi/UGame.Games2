using System;
using System.Linq;
using System.Text;
using SqlSugar;
using TinyFx.Data.SqlSugar;

namespace Gold_ggk.DAL
{
    
    [SugarConfigId("gdb")]
    public partial class Ggk_config_chipsPO
    {
        #region tinyfx
        public static implicit operator Ggk_config_chipsEO(Ggk_config_chipsPO value)
        {
            if (value==null) return null;
            return new Ggk_config_chipsEO
            {
		        ChipsID = value.ChipsID,
		        BetAmount = value.BetAmount,
		        PrizeAmount = value.PrizeAmount,
		        JackpotAmount = value.JackpotAmount,
		        JpRewardAmount = value.JpRewardAmount,
		        MaxRewardAmount = value.MaxRewardAmount,
            };
        }
        public static implicit operator Ggk_config_chipsPO(Ggk_config_chipsEO value)
        {
            if (value==null) return null;
            return new Ggk_config_chipsPO
            {
		        ChipsID = value.ChipsID,
		        BetAmount = value.BetAmount,
		        PrizeAmount = value.PrizeAmount,
		        JackpotAmount = value.JackpotAmount,
		        JpRewardAmount = value.JpRewardAmount,
		        MaxRewardAmount = value.MaxRewardAmount,
            };
        }
        #endregion
    }
}