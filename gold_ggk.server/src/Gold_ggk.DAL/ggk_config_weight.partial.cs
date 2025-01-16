using System;
using System.Linq;
using System.Text;
using SqlSugar;
using TinyFx.Data.SqlSugar;

namespace Gold_ggk.DAL
{
    
    [SugarConfigId("gdb")]
    public partial class Ggk_config_weightPO
    {
        #region tinyfx
        public static implicit operator Ggk_config_weightEO(Ggk_config_weightPO value)
        {
            if (value==null) return null;
            return new Ggk_config_weightEO
            {
		        WeightID = value.WeightID,
		        Mulitp = value.Mulitp,
		        Weight = value.Weight,
		        RewardType = value.RewardType,
            };
        }
        public static implicit operator Ggk_config_weightPO(Ggk_config_weightEO value)
        {
            if (value==null) return null;
            return new Ggk_config_weightPO
            {
		        WeightID = value.WeightID,
		        Mulitp = value.Mulitp,
		        Weight = value.Weight,
		        RewardType = value.RewardType,
            };
        }
        #endregion
    }
}