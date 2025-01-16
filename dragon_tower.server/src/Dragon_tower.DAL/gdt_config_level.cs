using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace Dragon_tower.DAL
{
    ///<summary>
    ///下注筹码表
    ///</summary>
    [SugarTable("gdt_config_level")]
    public partial class Gdt_config_levelPO
    {
           public Gdt_config_levelPO(){

            this.CellNum =0;
            this.MineNum =0;
            this.DiamodNum =0;

           }
           /// <summary>
           /// Desc:难度ID
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public int LevelID {get;set;}

           /// <summary>
           /// Desc:格子数
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int CellNum {get;set;}

           /// <summary>
           /// Desc:炸弹数
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int MineNum {get;set;}

           /// <summary>
           /// Desc:钻石数
           /// Default:0
           /// Nullable:False
           /// </summary>           
           public int DiamodNum {get;set;}

    }
}
