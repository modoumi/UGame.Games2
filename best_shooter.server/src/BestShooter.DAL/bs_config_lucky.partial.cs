using System;
using System.Linq;
using System.Text;
using SqlSugar;
using TinyFx.Data.SqlSugar;

namespace BestShooter.DAL
{
    
    [SugarConfigId("gdb")]
    public partial class Bs_config_luckyPO
    {
        #region tinyfx
        public static implicit operator Bs_config_luckyEO(Bs_config_luckyPO value)
        {
            if (value==null) return null;
            return new Bs_config_luckyEO
            {
		        OperatorID = value.OperatorID,
		        CurrencyID = value.CurrencyID,
		        MultipList = value.MultipList,
		        MultipWeightList = value.MultipWeightList,
		        NumList = value.NumList,
		        NumWeightList = value.NumWeightList,
            };
        }
        public static implicit operator Bs_config_luckyPO(Bs_config_luckyEO value)
        {
            if (value==null) return null;
            return new Bs_config_luckyPO
            {
		        OperatorID = value.OperatorID,
		        CurrencyID = value.CurrencyID,
		        MultipList = value.MultipList,
		        MultipWeightList = value.MultipWeightList,
		        NumList = value.NumList,
		        NumWeightList = value.NumWeightList,
            };
        }
        #endregion
    }
}