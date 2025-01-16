using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace Dwin_poker.DAL
{
    ///<summary>
    ///返奖奖池变化详情
    ///</summary>
    [SugarTable("all_pool_change_detail")]
    public partial class All_pool_change_detailPO
    {
           public All_pool_change_detailPO(){

            this.RecDate =DateTime.Now;

           }
           /// <summary>
           /// Desc:主键ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public long ChangeID {get;set;}

           /// <summary>
           /// Desc:appid
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string AppID {get;set;}

           /// <summary>
           /// Desc:货币编码（ISO 4217大写）
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string CurrencyID {get;set;}

           /// <summary>
           /// Desc:运营商编码
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string OperatorID {get;set;}

           /// <summary>
           /// Desc:主键
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long BetID {get;set;}

           /// <summary>
           /// Desc:用户Id
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string UserID {get;set;}

           /// <summary>
           /// Desc:奖池变化之前金额
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long BeforeAmount {get;set;}

           /// <summary>
           /// Desc:奖池变化金额
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long ChangeAmount {get;set;}

           /// <summary>
           /// Desc:奖池变化之后金额
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long AfterAmount {get;set;}

           /// <summary>
           /// Desc:记录时间
           /// Default:CURRENT_TIMESTAMP
           /// Nullable:True
           /// </summary>           
           public DateTime? RecDate {get;set;}

    }
}
