using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace Gold_ggk.DAL
{
    ///<summary>
    ///奖池权重
    ///</summary>
    [SugarTable("ggk_config_weight")]
    public partial class Ggk_config_weightPO
    {
           public Ggk_config_weightPO(){

            this.Mulitp =0d;
            this.Weight =0;
            this.RewardType =1;

           }
           /// <summary>
           /// Desc:主键
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public int WeightID {get;set;}

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
           /// Desc:奖金类型1-基础,2-JP奖金
           /// Default:1
           /// Nullable:False
           /// </summary>           
           public int RewardType {get;set;}

    }
}
