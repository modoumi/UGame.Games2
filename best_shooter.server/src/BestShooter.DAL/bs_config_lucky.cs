using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace BestShooter.DAL
{
    ///<summary>
    ///lucky值奖励倍数几率表
    ///</summary>
    [SugarTable("bs_config_lucky")]
    public partial class Bs_config_luckyPO
    {
           public Bs_config_luckyPO(){


           }
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
           /// Desc:倍数
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? MultipList {get;set;}

           /// <summary>
           /// Desc:倍数权重
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? MultipWeightList {get;set;}

           /// <summary>
           /// Desc:lucky奖励次数值
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? NumList {get;set;}

           /// <summary>
           /// Desc:lucky奖励次数值权重
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? NumWeightList {get;set;}

    }
}
