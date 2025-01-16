using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace Dwin_poker.DAL
{
    ///<summary>
    ///初始基础配置
    ///</summary>
    [SugarTable("dwp_config")]
    public partial class Dwp_configPO
    {
           public Dwp_configPO(){

            this.JPValTH =0;
            this.MaxBetAmount =0;
            this.MaxStar =0;
            this.MaxCardNum =0;

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
           /// Desc:JP分配
           /// Default:
           /// Nullable:False
           /// </summary>           
           public double JPRatio {get;set;}

           /// <summary>
           /// Desc:税收分配
           /// Default:
           /// Nullable:False
           /// </summary>           
           public double IncomeRatio {get;set;}

           /// <summary>
           /// Desc:排行分配
           /// Default:
           /// Nullable:False
           /// </summary>           
           public double RankRatio {get;set;}

           /// <summary>
           /// Desc:JP阈值
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int JPValTH {get;set;}

           /// <summary>
           /// Desc:下注上限
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long MaxBetAmount {get;set;}

           /// <summary>
           /// Desc:星级上限
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int MaxStar {get;set;}

           /// <summary>
           /// Desc:卡牌回合上限
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int MaxCardNum {get;set;}

           /// <summary>
           /// Desc:JP按下注额分配百分比
           /// Default:
           /// Nullable:False
           /// </summary>           
           public double JPTotalRatio {get;set;}

           /// <summary>
           /// Desc:JP虚拟值
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long JPInventedAmount {get;set;}

    }
}
