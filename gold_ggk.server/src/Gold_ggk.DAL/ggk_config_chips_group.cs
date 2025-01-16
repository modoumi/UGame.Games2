using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace Gold_ggk.DAL
{
    ///<summary>
    ///实际下注筹码分组表
    ///</summary>
    [SugarTable("ggk_config_chips_group")]
    public partial class Ggk_config_chips_groupPO
    {
           public Ggk_config_chips_groupPO(){


           }
           /// <summary>
           /// Desc:下注Id
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public int ChipsID {get;set;}

           /// <summary>
           /// Desc:实际下注额
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public long BetTotalAmount {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string? Group {get;set;}

    }
}
