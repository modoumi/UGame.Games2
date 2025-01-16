using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace Gold_ggk.DAL
{
    ///<summary>
    ///下注筹码表
    ///</summary>
    [SugarTable("ggk_config_chips")]
    public partial class Ggk_config_chipsPO
    {
           public Ggk_config_chipsPO(){

            this.BetAmount =0;
            this.PrizeAmount ="0";
            this.MaxRewardAmount =0;

           }
           /// <summary>
           /// Desc:筹码编码
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public int ChipsID {get;set;}

           /// <summary>
           /// Desc:下注金额
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long BetAmount {get;set;}

           /// <summary>
           /// Desc:奖金
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public string PrizeAmount {get;set;}

           /// <summary>
           /// Desc:jp奖金
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string JackpotAmount {get;set;}

           /// <summary>
           /// Desc:jp
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long JpRewardAmount {get;set;}

           /// <summary>
           /// Desc:最大可得
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long MaxRewardAmount {get;set;}

    }
}
