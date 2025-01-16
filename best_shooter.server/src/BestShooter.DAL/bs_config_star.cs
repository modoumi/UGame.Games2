using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace BestShooter.DAL
{
    ///<summary>
    ///球星表
    ///</summary>
    [SugarTable("bs_config_star")]
    public partial class Bs_config_starPO
    {
           public Bs_config_starPO(){

            this.Status =0;
            this.RecDate =DateTime.Now;

           }
           /// <summary>
           /// Desc:键Key
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public int StarID {get;set;}

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
           /// Desc:排序字段，优先级从小到大
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int OrderNum {get;set;}

           /// <summary>
           /// Desc:状态(0无效,1有效)
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int Status {get;set;}

           /// <summary>
           /// Desc:创建时间
           /// Default:CURRENT_TIMESTAMP
           /// Nullable:False
           /// </summary>           
           public DateTime RecDate {get;set;}

    }
}
