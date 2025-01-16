using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace Dwin_poker.DAL
{
    ///<summary>
    ///排行榜奖池
    ///</summary>
    [SugarTable("dwp_pool_rank")]
    public partial class Dwp_pool_rankPO
    {
           public Dwp_pool_rankPO(){

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
