using System;
using System.Linq;
using System.Text;
using SqlSugar;
using TinyFx.Data.SqlSugar;

namespace Dwin_poker.DAL
{
    
    [SugarConfigId("gdb")]
    public partial class Dwp_config_jackpot_weightPO
    {
        #region tinyfx
        public static implicit operator Dwp_config_jackpot_weightEO(Dwp_config_jackpot_weightPO value)
        {
            if (value==null) return null;
            return new Dwp_config_jackpot_weightEO
            {
		        JPWeightID = value.JPWeightID,
		        ChipsId = value.ChipsId,
		        JPTotalValMin = value.JPTotalValMin,
		        JPTotalValMax = value.JPTotalValMax,
		        Weight = value.Weight,
		        JPRewardIndex = value.JPRewardIndex,
            };
        }
        public static implicit operator Dwp_config_jackpot_weightPO(Dwp_config_jackpot_weightEO value)
        {
            if (value==null) return null;
            return new Dwp_config_jackpot_weightPO
            {
		        JPWeightID = value.JPWeightID,
		        ChipsId = value.ChipsId,
		        JPTotalValMin = value.JPTotalValMin,
		        JPTotalValMax = value.JPTotalValMax,
		        Weight = value.Weight,
		        JPRewardIndex = value.JPRewardIndex,
            };
        }
        #endregion
    }
}