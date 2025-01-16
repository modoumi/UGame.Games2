using System;
using System.Linq;
using System.Text;
using SqlSugar;
using TinyFx.Data.SqlSugar;

namespace Dwin_poker.DAL
{
    
    [SugarConfigId("gdb")]
    public partial class Dwp_config_rankPO
    {
        #region tinyfx
        public static implicit operator Dwp_config_rankEO(Dwp_config_rankPO value)
        {
            if (value==null) return null;
            return new Dwp_config_rankEO
            {
		        RankNo = value.RankNo,
		        RankReward = value.RankReward,
            };
        }
        public static implicit operator Dwp_config_rankPO(Dwp_config_rankEO value)
        {
            if (value==null) return null;
            return new Dwp_config_rankPO
            {
		        RankNo = value.RankNo,
		        RankReward = value.RankReward,
            };
        }
        #endregion
    }
}