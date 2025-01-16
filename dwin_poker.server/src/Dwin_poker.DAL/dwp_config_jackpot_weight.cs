using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace Dwin_poker.DAL
{
    ///<summary>
    ///JP奖池对应权重
    ///</summary>
    [SugarTable("dwp_config_jackpot_weight")]
    public partial class Dwp_config_jackpot_weightPO
    {
           public Dwp_config_jackpot_weightPO(){

            this.ChipsId =0;
            this.JPTotalValMin =0;
            this.JPTotalValMax =0;
            this.Weight =0;
            this.JPRewardIndex =0;

           }
           /// <summary>
           /// Desc:主键
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public int JPWeightID {get;set;}

           /// <summary>
           /// Desc:下注id
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int ChipsId {get;set;}

           /// <summary>
           /// Desc:累计值最小区间(包含下限)
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int JPTotalValMin {get;set;}

           /// <summary>
           /// Desc:累计值最大区间(不包含上限)
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int JPTotalValMax {get;set;}

           /// <summary>
           /// Desc:权重
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int Weight {get;set;}

           /// <summary>
           /// Desc:JP索引 （0-JPMini，1-JPMajor，2-JPMega）
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int JPRewardIndex {get;set;}

    }
}
