using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace Gold_ggk.DAL
{
    ///<summary>
    ///初始基础配置
    ///</summary>
    [SugarTable("ggk_config")]
    public partial class Ggk_configPO
    {
           public Ggk_configPO(){


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
           /// Desc:税收分配
           /// Default:
           /// Nullable:False
           /// </summary>           
           public double IncomeRatio {get;set;}

    }
}
