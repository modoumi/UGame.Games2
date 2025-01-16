using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace BestShooter.DAL
{
    ///<summary>
    ///Jackpot奖励几率表
    ///</summary>
    [SugarTable("bs_config_jackpot_odds")]
    public partial class Bs_config_jackpot_oddsPO
    {
           public Bs_config_jackpot_oddsPO(){

            this.RecDate =DateTime.Now;

           }
           /// <summary>
           /// Desc:主Key
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string JackpotOddsID {get;set;}

           /// <summary>
           /// Desc:运营商编码
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string OperatorID {get;set;}

           /// <summary>
           /// Desc:货币编码
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string CurrencyID {get;set;}

           /// <summary>
           /// Desc:基础投注额（值*100000）
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int BetAmount {get;set;}

           /// <summary>
           /// Desc:出现中奖概率（概率值*100000）
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int Odds {get;set;}

           /// <summary>
           /// Desc:奖金金额（值*100000）
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long BonusAmount {get;set;}

           /// <summary>
           /// Desc:Jackpot累计值-起始值
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long StartNum {get;set;}

           /// <summary>
           /// Desc:Jackpot累计值-截止值
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long EndNum {get;set;}

           /// <summary>
           /// Desc:创建时间
           /// Default:CURRENT_TIMESTAMP
           /// Nullable:False
           /// </summary>           
           public DateTime RecDate {get;set;}

    }
}
