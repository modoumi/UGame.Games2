using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace Mines.DAL
{
    ///<summary>
    ///下注筹码表
    ///</summary>
    [SugarTable("mines_config_chips")]
    public partial class Mines_config_chipsPO
    {
           public Mines_config_chipsPO(){

            this.Diamod =0;
            this.Rate =0d;
            this.Multip =0d;

           }
           /// <summary>
           /// Desc:地雷数
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public int MinesNum {get;set;}

           /// <summary>
           /// Desc:钻石
           /// Default:0
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public int Diamod {get;set;}

           /// <summary>
           /// Desc:中奖率
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public double Rate {get;set;}

           /// <summary>
           /// Desc:赔率
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public double Multip {get;set;}

    }
}
