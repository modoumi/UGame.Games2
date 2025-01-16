using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace Dwin_poker.DAL
{
    ///<summary>
    ///jp中奖记录
    ///</summary>
    [SugarTable("dwp_user_jphistory")]
    public partial class Dwp_user_jphistoryPO
    {
           public Dwp_user_jphistoryPO(){

            this.WinAmount =0;
            this.RecDate =DateTime.Now;

           }
           /// <summary>
           /// Desc:主键
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public long HID {get;set;}

           /// <summary>
           /// Desc:货币编码（ISO 4217大写）
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string CurrencyID {get;set;}

           /// <summary>
           /// Desc:用户Id
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string UserID {get;set;}

           /// <summary>
           /// Desc:用户昵称或者手机号
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string UserMobile {get;set;}

           /// <summary>
           /// Desc:奖金
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long WinAmount {get;set;}

           /// <summary>
           /// Desc:记录时间
           /// Default:CURRENT_TIMESTAMP
           /// Nullable:False
           /// </summary>           
           public DateTime RecDate {get;set;}

    }
}
