using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace Dwin_poker.DAL
{
    ///<summary>
    ///用户扩展数据
    ///</summary>
    [SugarTable("dwp_user_ext")]
    public partial class Dwp_user_extPO
    {
           public Dwp_user_extPO(){

            this.RoundIdx =0;
            this.Star =0;
            this.JPTotalVal =0;
            this.UserStatus =0;
            this.LastUpdateDate =DateTime.Now;

           }
           /// <summary>
           /// Desc:用户Id
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public string UserID {get;set;}

           /// <summary>
           /// Desc:回合数，总翻拍次数
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int RoundIdx {get;set;}

           /// <summary>
           /// Desc:星星数
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int Star {get;set;}

           /// <summary>
           /// Desc:JP累计值
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int JPTotalVal {get;set;}

           /// <summary>
           /// Desc:1-正常 2-锁定3-异常
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int UserStatus {get;set;}

           /// <summary>
           /// Desc:记录最后更新时间
           /// Default:CURRENT_TIMESTAMP
           /// Nullable:True
           /// </summary>           
           public DateTime? LastUpdateDate {get;set;}

    }
}
