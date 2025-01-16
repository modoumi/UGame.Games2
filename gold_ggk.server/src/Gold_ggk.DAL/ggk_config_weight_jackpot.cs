using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace Gold_ggk.DAL
{
    ///<summary>
    ///奖池权重
    ///</summary>
    [SugarTable("ggk_config_weight_jackpot")]
    public partial class Ggk_config_weight_jackpotPO
    {
           public Ggk_config_weight_jackpotPO(){

            this.Mulitp =0d;
            this.Weight =0;
            this.Group ="1";

           }
           /// <summary>
           /// Desc:主键
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public int JPID {get;set;}

           /// <summary>
           /// Desc:倍数
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public double Mulitp {get;set;}

           /// <summary>
           /// Desc:权重
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int Weight {get;set;}

           /// <summary>
           /// Desc:组合
           /// Default:1
           /// Nullable:False
           /// </summary>           
           public string Group {get;set;}

    }
}
