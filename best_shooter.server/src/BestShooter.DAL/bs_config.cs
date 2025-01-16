using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace BestShooter.DAL
{
    ///<summary>
    ///奖池配置表
    ///</summary>
    [SugarTable("bs_config")]
    public partial class Bs_configPO
    {
           public Bs_configPO(){

            this.MaxStake =0;
            this.MaxGoal =0;
            this.RecDate =DateTime.Now;

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
           /// Desc:进入公共奖池Jackpot比例（值*100）
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int InPublic {get;set;}

           /// <summary>
           /// Desc:进入个人Jackpot累计值比例（值*100）
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int InJackpot {get;set;}

           /// <summary>
           /// Desc:进入个人lucky累计值比例（值*100）
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int InLucky {get;set;}

           /// <summary>
           /// Desc:触发Jackpot抽奖阈值（值*100000）
           /// Default:
           /// Nullable:False
           /// </summary>           
           public long JackpotCount {get;set;}

           /// <summary>
           /// Desc:Jackpot抽奖时扣完税的比例（值*100）
			/// 中奖值乘以这个值就是得到的金额
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int JackpotRaffleAfterTax {get;set;}

           /// <summary>
           /// Desc:触发Lucky抽奖阈值
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int LuckyCount {get;set;}

           /// <summary>
           /// Desc:触发累计lucky值的投注金额（值*100000）
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int LuckyStartBet {get;set;}

           /// <summary>
           /// Desc:最大下注值
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long MaxStake {get;set;}

           /// <summary>
           /// Desc:进球最大累计值
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int MaxGoal {get;set;}

           /// <summary>
           /// Desc:创建时间
           /// Default:CURRENT_TIMESTAMP
           /// Nullable:False
           /// </summary>           
           public DateTime RecDate {get;set;}

    }
}
