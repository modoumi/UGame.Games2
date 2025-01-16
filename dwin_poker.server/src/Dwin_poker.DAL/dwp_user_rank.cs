using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace Dwin_poker.DAL
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("dwp_user_rank")]
    public partial class Dwp_user_rankPO
    {
           public Dwp_user_rankPO(){

            this.RecDate =DateTime.Now;

           }
           /// <summary>
           /// Desc:运营商编码
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string OperatorID {get;set;}

           /// <summary>
           /// Desc:货币编码（ISO 4217大写）
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string CurrencyID {get;set;}

           /// <summary>
           /// Desc:每期ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string RankID {get;set;}

           /// <summary>
           /// Desc:用户Id
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string UserID {get;set;}

           /// <summary>
           /// Desc:用户手机号
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string UserMobile {get;set;}

           /// <summary>
           /// Desc:记录时间
           /// Default:CURRENT_TIMESTAMP
           /// Nullable:False
           /// </summary>           
           public DateTime RecDate {get;set;}

    }
}
