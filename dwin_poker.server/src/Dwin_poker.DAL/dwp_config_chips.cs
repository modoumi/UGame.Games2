using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace Dwin_poker.DAL
{
    ///<summary>
    ///下注筹码表
    ///</summary>
    [SugarTable("dwp_config_chips")]
    public partial class Dwp_config_chipsPO
    {
           public Dwp_config_chipsPO(){

            this.BetBaseAmount =0;
            this.JPMini =0;
            this.JPMajor =0;
            this.JPMega =0;

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
           public long BetBaseAmount {get;set;}

           /// <summary>
           /// Desc:jackpot奖池Mini
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long JPMini {get;set;}

           /// <summary>
           /// Desc:jackpot奖池Major
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long JPMajor {get;set;}

           /// <summary>
           /// Desc:jackpot奖池Mega
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long JPMega {get;set;}

    }
}
