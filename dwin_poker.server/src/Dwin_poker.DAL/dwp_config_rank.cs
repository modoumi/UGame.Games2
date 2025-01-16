using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace Dwin_poker.DAL
{
    ///<summary>
    ///排行榜配置
    ///</summary>
    [SugarTable("dwp_config_rank")]
    public partial class Dwp_config_rankPO
    {
           public Dwp_config_rankPO(){

            this.RankNo =0;
            this.RankReward =0;

           }
           /// <summary>
           /// Desc:排名
           /// Default:0
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public int RankNo {get;set;}

           /// <summary>
           /// Desc:排名奖金
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long RankReward {get;set;}

    }
}
