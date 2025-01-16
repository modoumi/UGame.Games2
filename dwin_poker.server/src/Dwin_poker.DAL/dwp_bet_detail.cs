using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace Dwin_poker.DAL
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("dwp_bet_detail")]
    public partial class Dwp_bet_detailPO
    {
           public Dwp_bet_detailPO(){

            this.ChipsID =0;
            this.BetBaseAmount =0;
            this.BetMulitp =0d;
            this.BetTotalAmount =0;
            this.BetResultAmount =0;
            this.IsWin =false;
            this.Star =0;
            this.CardIdx =0;
            this.Card =0;
            this.RoundIdx =0;
            this.JPTotalValue =0;
            this.IsTriggerJP =false;
            this.JPRewardIndex =0;
            this.JPRewardValue =0;
            this.GameStatus =0;
            this.OrderStatus =0;
            this.RecDate =DateTime.Now;

           }
           /// <summary>
           /// Desc:主键
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public long BetID {get;set;}

           /// <summary>
           /// Desc:用户Id
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string UserID {get;set;}

           /// <summary>
           /// Desc:下注配置ID
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int ChipsID {get;set;}

           /// <summary>
           /// Desc:实际下注金额
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long BetBaseAmount {get;set;}

           /// <summary>
           /// Desc:下注倍数
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public double BetMulitp {get;set;}

           /// <summary>
           /// Desc:本轮总下注
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long BetTotalAmount {get;set;}

           /// <summary>
           /// Desc:本轮结果
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long BetResultAmount {get;set;}

           /// <summary>
           /// Desc:是否中奖
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public bool IsWin {get;set;}

           /// <summary>
           /// Desc:星星数
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int Star {get;set;}

           /// <summary>
           /// Desc:下注索引 10次一洗牌
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int CardIdx {get;set;}

           /// <summary>
           /// Desc:卡牌点数
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int Card {get;set;}

           /// <summary>
           /// Desc:回合数，总翻拍次数
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int RoundIdx {get;set;}

           /// <summary>
           /// Desc:JP累计值
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int JPTotalValue {get;set;}

           /// <summary>
           /// Desc:是否触发JP大奖（触发不一定中）
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public bool IsTriggerJP {get;set;}

           /// <summary>
           /// Desc:JP ID
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int JPRewardIndex {get;set;}

           /// <summary>
           /// Desc:JP 金额
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public long JPRewardValue {get;set;}

           /// <summary>
           /// Desc:roundIdx>0时，需要判断4种状态，1-star达到最大，2-betResult达到maxBet，3-balance小于baseBet，4-balance
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int GameStatus {get;set;}

           /// <summary>
           /// Desc:状态0-初始1-处理中2-成功3-失败4-已回滚5-异常且需处理6-异常已处理
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int OrderStatus {get;set;}

           /// <summary>
           /// Desc:每回合历史记录
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string History {get;set;}

           /// <summary>
           /// Desc:记录时间
           /// Default:CURRENT_TIMESTAMP
           /// Nullable:True
           /// </summary>           
           public DateTime? RecDate {get;set;}

    }
}
