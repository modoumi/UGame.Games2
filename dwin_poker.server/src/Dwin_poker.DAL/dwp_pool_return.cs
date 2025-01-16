using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace Dwin_poker.DAL
{
    ///<summary>
    ///返奖奖池
    ///</summary>
    [SugarTable("dwp_pool_return")]
    public partial class Dwp_pool_returnPO
    {
           public Dwp_pool_returnPO(){

            this.PoolVal =0;

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
           /// Desc:值
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long PoolVal {get;set;}

    }
}
