using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace Dwin_poker.DAL
{
    ///<summary>
    ///星星对应权重
    ///</summary>
    [SugarTable("dwp_config_star_weight")]
    public partial class Dwp_config_star_weightPO
    {
           public Dwp_config_star_weightPO(){

            this.Multip =0;
            this.HitRatio =0d;

           }
           /// <summary>
           /// Desc:星星数-主键
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public int StarNum {get;set;}

           /// <summary>
           /// Desc:倍数
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int Multip {get;set;}

           /// <summary>
           /// Desc:中奖率
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public double HitRatio {get;set;}

    }
}
