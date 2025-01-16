using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace Mines.DAL
{
    ///<summary>
    ///初始基础配置
    ///</summary>
    [SugarTable("mines_config")]
    public partial class Mines_configPO
    {
           public Mines_configPO(){

            this.IncomeRatio =0d;
            this.MinMine =0;
            this.MaxMine =0;
            this.MaxBet =0;

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
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public double IncomeRatio {get;set;}

           /// <summary>
           /// Desc:最小地雷数
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int MinMine {get;set;}

           /// <summary>
           /// Desc:最大地雷数
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int MaxMine {get;set;}

           /// <summary>
           /// Desc:最小下注额
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long MinBet {get;set;}

           /// <summary>
           /// Desc:最大下注额
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long MaxBet {get;set;}

    }
}
