using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace Dragon_tower.DAL
{
    ///<summary>
    ///初始基础配置
    ///</summary>
    [SugarTable("gdt_config")]
    public partial class Gdt_configPO
    {
           public Gdt_configPO(){

            this.IncomeRatio =0d;
            this.LevelId =0;
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
           /// Desc:初始难度ID
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int LevelId {get;set;}

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

           /// <summary>
           /// Desc:返奖系数
           /// Default:
           /// Nullable:False
           /// </summary>           
           public double ReturnRatio {get;set;}

    }
}
