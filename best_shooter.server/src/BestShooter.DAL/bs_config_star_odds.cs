using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace BestShooter.DAL
{
    ///<summary>
    ///球星概率表
    ///</summary>
    [SugarTable("bs_config_star_odds")]
    public partial class Bs_config_star_oddsPO
    {
           public Bs_config_star_oddsPO(){

            this.Goal =0;
            this.IsBaseMultiple =0;
            this.Surprise =0;
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
           /// Desc:用户进球累计值
           /// Default:0
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public int Goal {get;set;}

           /// <summary>
           /// Desc:位置
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public int Position {get;set;}

           /// <summary>
           /// Desc:倍数（倍数值*100）
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public int Multiple {get;set;}

           /// <summary>
           /// Desc:概率（概率值*100000）
           /// Default:
           /// Nullable:False
           /// </summary>           
           public int Odds {get;set;}

           /// <summary>
           /// Desc:是否基础倍数
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int IsBaseMultiple {get;set;}

           /// <summary>
           /// Desc:是否双倍奖励
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int Surprise {get;set;}

           /// <summary>
           /// Desc:创建时间
           /// Default:CURRENT_TIMESTAMP
           /// Nullable:False
           /// </summary>           
           public DateTime RecDate {get;set;}

    }
}
