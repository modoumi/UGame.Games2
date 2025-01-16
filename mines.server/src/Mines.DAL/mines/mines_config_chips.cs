/******************************************************
 * 此代码由代码生成器工具自动生成，请不要修改
 * TinyFx代码生成器核心库版本号：1.0.0.0
 * git: https://github.com/jh98net/TinyFx
 * 文档生成时间：2023-12-09 15: 13:44
 ******************************************************/
using System;
using System.Data;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using TinyFx;
using TinyFx.Data;
using MySql.Data.MySqlClient;
using System.Text;
using TinyFx.Data.MySql;

namespace Mines.DAL
{
	#region EO
	/// <summary>
	/// 下注筹码表
	/// 【表 mines_config_chips 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class Mines_config_chipsEO : IRowMapper<Mines_config_chipsEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public Mines_config_chipsEO()
		{
			this.Diamod = 0;
			this.Rate = 0d;
			this.Multip = 0d;
		}
		#region 主键原始值 & 主键集合
	    
		/// <summary>
		/// 当前对象是否保存原始主键值，当修改了主键值时为 true
		/// </summary>
		public bool HasOriginal { get; protected set; }
		
		private int _originalMinesNum;
		/// <summary>
		/// 【数据库中的原始主键 MinesNum 值的副本，用于主键值更新】
		/// </summary>
		public int OriginalMinesNum
		{
			get { return _originalMinesNum; }
			set { HasOriginal = true; _originalMinesNum = value; }
		}
		
		private int _originalDiamod;
		/// <summary>
		/// 【数据库中的原始主键 Diamod 值的副本，用于主键值更新】
		/// </summary>
		public int OriginalDiamod
		{
			get { return _originalDiamod; }
			set { HasOriginal = true; _originalDiamod = value; }
		}
	    /// <summary>
	    /// 获取主键集合。key: 数据库字段名称, value: 主键值
	    /// </summary>
	    /// <returns></returns>
	    public Dictionary<string, object> GetPrimaryKeys()
	    {
	        return new Dictionary<string, object>() { { "MinesNum", MinesNum },  { "Diamod", Diamod }, };
	    }
	    /// <summary>
	    /// 获取主键集合JSON格式
	    /// </summary>
	    /// <returns></returns>
	    public string GetPrimaryKeysJson() => SerializerUtil.SerializeJson(GetPrimaryKeys());
		#endregion // 主键原始值
		#region 所有字段
		/// <summary>
		/// 地雷数
		/// 【主键 int】
		/// </summary>
		[DataMember(Order = 1)]
		public int MinesNum { get; set; }
		/// <summary>
		/// 钻石
		/// 【主键 int】
		/// </summary>
		[DataMember(Order = 2)]
		public int Diamod { get; set; }
		/// <summary>
		/// 中奖率
		/// 【字段 double】
		/// </summary>
		[DataMember(Order = 3)]
		public double Rate { get; set; }
		/// <summary>
		/// 赔率
		/// 【字段 double】
		/// </summary>
		[DataMember(Order = 4)]
		public double Multip { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public Mines_config_chipsEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static Mines_config_chipsEO MapDataReader(IDataReader reader)
		{
		    Mines_config_chipsEO ret = new Mines_config_chipsEO();
			ret.MinesNum = reader.ToInt32("MinesNum");
			ret.OriginalMinesNum = ret.MinesNum;
			ret.Diamod = reader.ToInt32("Diamod");
			ret.OriginalDiamod = ret.Diamod;
			ret.Rate = reader.ToDouble("Rate");
			ret.Multip = reader.ToDouble("Multip");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 下注筹码表
	/// 【表 mines_config_chips 的操作类】
	/// </summary>
	[Obsolete]
	public class Mines_config_chipsMO : MySqlTableMO<Mines_config_chipsEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`mines_config_chips`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public Mines_config_chipsMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public Mines_config_chipsMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public Mines_config_chipsMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(Mines_config_chipsEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(Mines_config_chipsEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(Mines_config_chipsEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`MinesNum`, `Diamod`, `Rate`, `Multip`) VALUE (@MinesNum, @Diamod, @Rate, @Multip);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MinesNum", item.MinesNum, MySqlDbType.Int32),
				Database.CreateInParameter("@Diamod", item.Diamod, MySqlDbType.Int32),
				Database.CreateInParameter("@Rate", item.Rate, MySqlDbType.Double),
				Database.CreateInParameter("@Multip", item.Multip, MySqlDbType.Double),
			};
		}
		public int AddByBatch(IEnumerable<Mines_config_chipsEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<Mines_config_chipsEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<Mines_config_chipsEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`MinesNum`, `Diamod`, `Rate`, `Multip`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"({item.MinesNum},{item.Diamod},{item.Rate},{item.Multip}),");
				if (count == batchCount)
				{
					count = 0;
					sql.Insert(0, insertSql);
					var ret = sql.ToString().TrimEnd(',');
					sql.Clear();
	                yield return ret;
				}
			}
			if (sql.Length > 0)
			{
	            sql.Insert(0, insertSql);
	            yield return sql.ToString().TrimEnd(',');
	        }
	    }
	    #endregion // Add
	    
		#region Remove
		#region RemoveByPK
		/// <summary>
		/// 按主键删除
		/// </summary>
		/// /// <param name = "minesNum">地雷数</param>
		/// /// <param name = "diamod">钻石</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(int minesNum, int diamod, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(minesNum, diamod, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(int minesNum, int diamod, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(minesNum, diamod, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(int minesNum, int diamod, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `MinesNum` = @MinesNum AND `Diamod` = @Diamod";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MinesNum", minesNum, MySqlDbType.Int32),
				Database.CreateInParameter("@Diamod", diamod, MySqlDbType.Int32),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(Mines_config_chipsEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.MinesNum, item.Diamod, tm_);
		}
		public async Task<int> RemoveAsync(Mines_config_chipsEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.MinesNum, item.Diamod, tm_);
		}
		#endregion // RemoveByPK
		
		#region RemoveByXXX
		#region RemoveByMinesNum
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "minesNum">地雷数</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByMinesNum(int minesNum, TransactionManager tm_ = null)
		{
			RepairRemoveByMinesNumData(minesNum, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByMinesNumAsync(int minesNum, TransactionManager tm_ = null)
		{
			RepairRemoveByMinesNumData(minesNum, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByMinesNumData(int minesNum, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `MinesNum` = @MinesNum";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@MinesNum", minesNum, MySqlDbType.Int32));
		}
		#endregion // RemoveByMinesNum
		#region RemoveByDiamod
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "diamod">钻石</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByDiamod(int diamod, TransactionManager tm_ = null)
		{
			RepairRemoveByDiamodData(diamod, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByDiamodAsync(int diamod, TransactionManager tm_ = null)
		{
			RepairRemoveByDiamodData(diamod, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByDiamodData(int diamod, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `Diamod` = @Diamod";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Diamod", diamod, MySqlDbType.Int32));
		}
		#endregion // RemoveByDiamod
		#region RemoveByRate
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "rate">中奖率</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByRate(double rate, TransactionManager tm_ = null)
		{
			RepairRemoveByRateData(rate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByRateAsync(double rate, TransactionManager tm_ = null)
		{
			RepairRemoveByRateData(rate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByRateData(double rate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `Rate` = @Rate";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Rate", rate, MySqlDbType.Double));
		}
		#endregion // RemoveByRate
		#region RemoveByMultip
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "multip">赔率</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByMultip(double multip, TransactionManager tm_ = null)
		{
			RepairRemoveByMultipData(multip, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByMultipAsync(double multip, TransactionManager tm_ = null)
		{
			RepairRemoveByMultipData(multip, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByMultipData(double multip, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `Multip` = @Multip";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Multip", multip, MySqlDbType.Double));
		}
		#endregion // RemoveByMultip
		#endregion // RemoveByXXX
	    
		#region RemoveByFKOrUnique
		#endregion // RemoveByFKOrUnique
		#endregion //Remove
	    
		#region Put
		#region PutItem
		/// <summary>
		/// 更新实体到数据库
		/// </summary>
		/// <param name = "item">要更新的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(Mines_config_chipsEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(Mines_config_chipsEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(Mines_config_chipsEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `MinesNum` = @MinesNum, `Diamod` = @Diamod, `Rate` = @Rate, `Multip` = @Multip WHERE `MinesNum` = @MinesNum_Original AND `Diamod` = @Diamod_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MinesNum", item.MinesNum, MySqlDbType.Int32),
				Database.CreateInParameter("@Diamod", item.Diamod, MySqlDbType.Int32),
				Database.CreateInParameter("@Rate", item.Rate, MySqlDbType.Double),
				Database.CreateInParameter("@Multip", item.Multip, MySqlDbType.Double),
				Database.CreateInParameter("@MinesNum_Original", item.HasOriginal ? item.OriginalMinesNum : item.MinesNum, MySqlDbType.Int32),
				Database.CreateInParameter("@Diamod_Original", item.HasOriginal ? item.OriginalDiamod : item.Diamod, MySqlDbType.Int32),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<Mines_config_chipsEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<Mines_config_chipsEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += await PutAsync(item, tm_);
			}
			return ret;
		}
		#endregion // PutItem
		
		#region PutByPK
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "minesNum">地雷数</param>
		/// /// <param name = "diamod">钻石</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(int minesNum, int diamod, string set_, params object[] values_)
		{
			return Put(set_, "`MinesNum` = @MinesNum AND `Diamod` = @Diamod", ConcatValues(values_, minesNum, diamod));
		}
		public async Task<int> PutByPKAsync(int minesNum, int diamod, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`MinesNum` = @MinesNum AND `Diamod` = @Diamod", ConcatValues(values_, minesNum, diamod));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "minesNum">地雷数</param>
		/// /// <param name = "diamod">钻石</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(int minesNum, int diamod, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`MinesNum` = @MinesNum AND `Diamod` = @Diamod", tm_, ConcatValues(values_, minesNum, diamod));
		}
		public async Task<int> PutByPKAsync(int minesNum, int diamod, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`MinesNum` = @MinesNum AND `Diamod` = @Diamod", tm_, ConcatValues(values_, minesNum, diamod));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "minesNum">地雷数</param>
		/// /// <param name = "diamod">钻石</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(int minesNum, int diamod, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@MinesNum", minesNum, MySqlDbType.Int32),
				Database.CreateInParameter("@Diamod", diamod, MySqlDbType.Int32),
	        };
			return Put(set_, "`MinesNum` = @MinesNum AND `Diamod` = @Diamod", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(int minesNum, int diamod, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@MinesNum", minesNum, MySqlDbType.Int32),
				Database.CreateInParameter("@Diamod", diamod, MySqlDbType.Int32),
	        };
			return await PutAsync(set_, "`MinesNum` = @MinesNum AND `Diamod` = @Diamod", ConcatParameters(paras_, newParas_), tm_);
		}
		#endregion // PutByPK
		
		#region PutXXX
		#region PutMinesNum
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "minesNum">地雷数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutMinesNum(int minesNum, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `MinesNum` = @MinesNum";
			var parameter_ = Database.CreateInParameter("@MinesNum", minesNum, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutMinesNumAsync(int minesNum, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `MinesNum` = @MinesNum";
			var parameter_ = Database.CreateInParameter("@MinesNum", minesNum, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutMinesNum
		#region PutDiamod
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "diamod">钻石</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutDiamod(int diamod, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Diamod` = @Diamod";
			var parameter_ = Database.CreateInParameter("@Diamod", diamod, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutDiamodAsync(int diamod, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Diamod` = @Diamod";
			var parameter_ = Database.CreateInParameter("@Diamod", diamod, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutDiamod
		#region PutRate
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "minesNum">地雷数</param>
		/// /// <param name = "diamod">钻石</param>
		/// /// <param name = "rate">中奖率</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRateByPK(int minesNum, int diamod, double rate, TransactionManager tm_ = null)
		{
			RepairPutRateByPKData(minesNum, diamod, rate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutRateByPKAsync(int minesNum, int diamod, double rate, TransactionManager tm_ = null)
		{
			RepairPutRateByPKData(minesNum, diamod, rate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutRateByPKData(int minesNum, int diamod, double rate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Rate` = @Rate  WHERE `MinesNum` = @MinesNum AND `Diamod` = @Diamod";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Rate", rate, MySqlDbType.Double),
				Database.CreateInParameter("@MinesNum", minesNum, MySqlDbType.Int32),
				Database.CreateInParameter("@Diamod", diamod, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "rate">中奖率</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRate(double rate, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Rate` = @Rate";
			var parameter_ = Database.CreateInParameter("@Rate", rate, MySqlDbType.Double);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutRateAsync(double rate, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Rate` = @Rate";
			var parameter_ = Database.CreateInParameter("@Rate", rate, MySqlDbType.Double);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutRate
		#region PutMultip
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "minesNum">地雷数</param>
		/// /// <param name = "diamod">钻石</param>
		/// /// <param name = "multip">赔率</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutMultipByPK(int minesNum, int diamod, double multip, TransactionManager tm_ = null)
		{
			RepairPutMultipByPKData(minesNum, diamod, multip, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutMultipByPKAsync(int minesNum, int diamod, double multip, TransactionManager tm_ = null)
		{
			RepairPutMultipByPKData(minesNum, diamod, multip, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutMultipByPKData(int minesNum, int diamod, double multip, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Multip` = @Multip  WHERE `MinesNum` = @MinesNum AND `Diamod` = @Diamod";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Multip", multip, MySqlDbType.Double),
				Database.CreateInParameter("@MinesNum", minesNum, MySqlDbType.Int32),
				Database.CreateInParameter("@Diamod", diamod, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "multip">赔率</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutMultip(double multip, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Multip` = @Multip";
			var parameter_ = Database.CreateInParameter("@Multip", multip, MySqlDbType.Double);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutMultipAsync(double multip, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Multip` = @Multip";
			var parameter_ = Database.CreateInParameter("@Multip", multip, MySqlDbType.Double);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutMultip
		#endregion // PutXXX
		#endregion // Put
	   
		#region Set
		
		/// <summary>
		/// 插入或者更新数据
		/// </summary>
		/// <param name = "item">要更新的实体对象</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>true:插入操作；false:更新操作</return>
		public bool Set(Mines_config_chipsEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.MinesNum, item.Diamod) == null)
			{
				Add(item, tm);
			}
			else
			{
				Put(item, tm);
				ret = false;
			}
			return ret;
		}
		public async Task<bool> SetAsync(Mines_config_chipsEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.MinesNum, item.Diamod) == null)
			{
				await AddAsync(item, tm);
			}
			else
			{
				await PutAsync(item, tm);
				ret = false;
			}
			return ret;
		}
		
		#endregion // Set
		
		#region Get
		#region GetByPK
		/// <summary>
		/// 按 PK（主键） 查询
		/// </summary>
		/// /// <param name = "minesNum">地雷数</param>
		/// /// <param name = "diamod">钻石</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public Mines_config_chipsEO GetByPK(int minesNum, int diamod, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(minesNum, diamod, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, Mines_config_chipsEO.MapDataReader);
		}
		public async Task<Mines_config_chipsEO> GetByPKAsync(int minesNum, int diamod, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(minesNum, diamod, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Mines_config_chipsEO.MapDataReader);
		}
		private void RepairGetByPKData(int minesNum, int diamod, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`MinesNum` = @MinesNum AND `Diamod` = @Diamod", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MinesNum", minesNum, MySqlDbType.Int32),
				Database.CreateInParameter("@Diamod", diamod, MySqlDbType.Int32),
			};
		}
		#endregion // GetByPK
		
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 MinesNum（字段）
		/// </summary>
		/// /// <param name = "minesNum">地雷数</param>
		/// /// <param name = "diamod">钻石</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetMinesNumByPK(int minesNum, int diamod, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MinesNum", minesNum, MySqlDbType.Int32),
				Database.CreateInParameter("@Diamod", diamod, MySqlDbType.Int32),
			};
			return (int)GetScalar("`MinesNum`", "`MinesNum` = @MinesNum AND `Diamod` = @Diamod", paras_, tm_);
		}
		public async Task<int> GetMinesNumByPKAsync(int minesNum, int diamod, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MinesNum", minesNum, MySqlDbType.Int32),
				Database.CreateInParameter("@Diamod", diamod, MySqlDbType.Int32),
			};
			return (int)await GetScalarAsync("`MinesNum`", "`MinesNum` = @MinesNum AND `Diamod` = @Diamod", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Diamod（字段）
		/// </summary>
		/// /// <param name = "minesNum">地雷数</param>
		/// /// <param name = "diamod">钻石</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetDiamodByPK(int minesNum, int diamod, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MinesNum", minesNum, MySqlDbType.Int32),
				Database.CreateInParameter("@Diamod", diamod, MySqlDbType.Int32),
			};
			return (int)GetScalar("`Diamod`", "`MinesNum` = @MinesNum AND `Diamod` = @Diamod", paras_, tm_);
		}
		public async Task<int> GetDiamodByPKAsync(int minesNum, int diamod, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MinesNum", minesNum, MySqlDbType.Int32),
				Database.CreateInParameter("@Diamod", diamod, MySqlDbType.Int32),
			};
			return (int)await GetScalarAsync("`Diamod`", "`MinesNum` = @MinesNum AND `Diamod` = @Diamod", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Rate（字段）
		/// </summary>
		/// /// <param name = "minesNum">地雷数</param>
		/// /// <param name = "diamod">钻石</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public double GetRateByPK(int minesNum, int diamod, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MinesNum", minesNum, MySqlDbType.Int32),
				Database.CreateInParameter("@Diamod", diamod, MySqlDbType.Int32),
			};
			return (double)GetScalar("`Rate`", "`MinesNum` = @MinesNum AND `Diamod` = @Diamod", paras_, tm_);
		}
		public async Task<double> GetRateByPKAsync(int minesNum, int diamod, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MinesNum", minesNum, MySqlDbType.Int32),
				Database.CreateInParameter("@Diamod", diamod, MySqlDbType.Int32),
			};
			return (double)await GetScalarAsync("`Rate`", "`MinesNum` = @MinesNum AND `Diamod` = @Diamod", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Multip（字段）
		/// </summary>
		/// /// <param name = "minesNum">地雷数</param>
		/// /// <param name = "diamod">钻石</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public double GetMultipByPK(int minesNum, int diamod, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MinesNum", minesNum, MySqlDbType.Int32),
				Database.CreateInParameter("@Diamod", diamod, MySqlDbType.Int32),
			};
			return (double)GetScalar("`Multip`", "`MinesNum` = @MinesNum AND `Diamod` = @Diamod", paras_, tm_);
		}
		public async Task<double> GetMultipByPKAsync(int minesNum, int diamod, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MinesNum", minesNum, MySqlDbType.Int32),
				Database.CreateInParameter("@Diamod", diamod, MySqlDbType.Int32),
			};
			return (double)await GetScalarAsync("`Multip`", "`MinesNum` = @MinesNum AND `Diamod` = @Diamod", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByMinesNum
		
		/// <summary>
		/// 按 MinesNum（字段） 查询
		/// </summary>
		/// /// <param name = "minesNum">地雷数</param>
		/// <return>实体对象集合</return>
		public List<Mines_config_chipsEO> GetByMinesNum(int minesNum)
		{
			return GetByMinesNum(minesNum, 0, string.Empty, null);
		}
		public async Task<List<Mines_config_chipsEO>> GetByMinesNumAsync(int minesNum)
		{
			return await GetByMinesNumAsync(minesNum, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 MinesNum（字段） 查询
		/// </summary>
		/// /// <param name = "minesNum">地雷数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Mines_config_chipsEO> GetByMinesNum(int minesNum, TransactionManager tm_)
		{
			return GetByMinesNum(minesNum, 0, string.Empty, tm_);
		}
		public async Task<List<Mines_config_chipsEO>> GetByMinesNumAsync(int minesNum, TransactionManager tm_)
		{
			return await GetByMinesNumAsync(minesNum, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 MinesNum（字段） 查询
		/// </summary>
		/// /// <param name = "minesNum">地雷数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Mines_config_chipsEO> GetByMinesNum(int minesNum, int top_)
		{
			return GetByMinesNum(minesNum, top_, string.Empty, null);
		}
		public async Task<List<Mines_config_chipsEO>> GetByMinesNumAsync(int minesNum, int top_)
		{
			return await GetByMinesNumAsync(minesNum, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 MinesNum（字段） 查询
		/// </summary>
		/// /// <param name = "minesNum">地雷数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Mines_config_chipsEO> GetByMinesNum(int minesNum, int top_, TransactionManager tm_)
		{
			return GetByMinesNum(minesNum, top_, string.Empty, tm_);
		}
		public async Task<List<Mines_config_chipsEO>> GetByMinesNumAsync(int minesNum, int top_, TransactionManager tm_)
		{
			return await GetByMinesNumAsync(minesNum, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 MinesNum（字段） 查询
		/// </summary>
		/// /// <param name = "minesNum">地雷数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Mines_config_chipsEO> GetByMinesNum(int minesNum, string sort_)
		{
			return GetByMinesNum(minesNum, 0, sort_, null);
		}
		public async Task<List<Mines_config_chipsEO>> GetByMinesNumAsync(int minesNum, string sort_)
		{
			return await GetByMinesNumAsync(minesNum, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 MinesNum（字段） 查询
		/// </summary>
		/// /// <param name = "minesNum">地雷数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Mines_config_chipsEO> GetByMinesNum(int minesNum, string sort_, TransactionManager tm_)
		{
			return GetByMinesNum(minesNum, 0, sort_, tm_);
		}
		public async Task<List<Mines_config_chipsEO>> GetByMinesNumAsync(int minesNum, string sort_, TransactionManager tm_)
		{
			return await GetByMinesNumAsync(minesNum, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 MinesNum（字段） 查询
		/// </summary>
		/// /// <param name = "minesNum">地雷数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Mines_config_chipsEO> GetByMinesNum(int minesNum, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`MinesNum` = @MinesNum", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@MinesNum", minesNum, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Mines_config_chipsEO.MapDataReader);
		}
		public async Task<List<Mines_config_chipsEO>> GetByMinesNumAsync(int minesNum, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`MinesNum` = @MinesNum", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@MinesNum", minesNum, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Mines_config_chipsEO.MapDataReader);
		}
		#endregion // GetByMinesNum
		#region GetByDiamod
		
		/// <summary>
		/// 按 Diamod（字段） 查询
		/// </summary>
		/// /// <param name = "diamod">钻石</param>
		/// <return>实体对象集合</return>
		public List<Mines_config_chipsEO> GetByDiamod(int diamod)
		{
			return GetByDiamod(diamod, 0, string.Empty, null);
		}
		public async Task<List<Mines_config_chipsEO>> GetByDiamodAsync(int diamod)
		{
			return await GetByDiamodAsync(diamod, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Diamod（字段） 查询
		/// </summary>
		/// /// <param name = "diamod">钻石</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Mines_config_chipsEO> GetByDiamod(int diamod, TransactionManager tm_)
		{
			return GetByDiamod(diamod, 0, string.Empty, tm_);
		}
		public async Task<List<Mines_config_chipsEO>> GetByDiamodAsync(int diamod, TransactionManager tm_)
		{
			return await GetByDiamodAsync(diamod, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Diamod（字段） 查询
		/// </summary>
		/// /// <param name = "diamod">钻石</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Mines_config_chipsEO> GetByDiamod(int diamod, int top_)
		{
			return GetByDiamod(diamod, top_, string.Empty, null);
		}
		public async Task<List<Mines_config_chipsEO>> GetByDiamodAsync(int diamod, int top_)
		{
			return await GetByDiamodAsync(diamod, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Diamod（字段） 查询
		/// </summary>
		/// /// <param name = "diamod">钻石</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Mines_config_chipsEO> GetByDiamod(int diamod, int top_, TransactionManager tm_)
		{
			return GetByDiamod(diamod, top_, string.Empty, tm_);
		}
		public async Task<List<Mines_config_chipsEO>> GetByDiamodAsync(int diamod, int top_, TransactionManager tm_)
		{
			return await GetByDiamodAsync(diamod, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Diamod（字段） 查询
		/// </summary>
		/// /// <param name = "diamod">钻石</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Mines_config_chipsEO> GetByDiamod(int diamod, string sort_)
		{
			return GetByDiamod(diamod, 0, sort_, null);
		}
		public async Task<List<Mines_config_chipsEO>> GetByDiamodAsync(int diamod, string sort_)
		{
			return await GetByDiamodAsync(diamod, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Diamod（字段） 查询
		/// </summary>
		/// /// <param name = "diamod">钻石</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Mines_config_chipsEO> GetByDiamod(int diamod, string sort_, TransactionManager tm_)
		{
			return GetByDiamod(diamod, 0, sort_, tm_);
		}
		public async Task<List<Mines_config_chipsEO>> GetByDiamodAsync(int diamod, string sort_, TransactionManager tm_)
		{
			return await GetByDiamodAsync(diamod, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Diamod（字段） 查询
		/// </summary>
		/// /// <param name = "diamod">钻石</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Mines_config_chipsEO> GetByDiamod(int diamod, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Diamod` = @Diamod", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Diamod", diamod, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Mines_config_chipsEO.MapDataReader);
		}
		public async Task<List<Mines_config_chipsEO>> GetByDiamodAsync(int diamod, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Diamod` = @Diamod", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Diamod", diamod, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Mines_config_chipsEO.MapDataReader);
		}
		#endregion // GetByDiamod
		#region GetByRate
		
		/// <summary>
		/// 按 Rate（字段） 查询
		/// </summary>
		/// /// <param name = "rate">中奖率</param>
		/// <return>实体对象集合</return>
		public List<Mines_config_chipsEO> GetByRate(double rate)
		{
			return GetByRate(rate, 0, string.Empty, null);
		}
		public async Task<List<Mines_config_chipsEO>> GetByRateAsync(double rate)
		{
			return await GetByRateAsync(rate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Rate（字段） 查询
		/// </summary>
		/// /// <param name = "rate">中奖率</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Mines_config_chipsEO> GetByRate(double rate, TransactionManager tm_)
		{
			return GetByRate(rate, 0, string.Empty, tm_);
		}
		public async Task<List<Mines_config_chipsEO>> GetByRateAsync(double rate, TransactionManager tm_)
		{
			return await GetByRateAsync(rate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Rate（字段） 查询
		/// </summary>
		/// /// <param name = "rate">中奖率</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Mines_config_chipsEO> GetByRate(double rate, int top_)
		{
			return GetByRate(rate, top_, string.Empty, null);
		}
		public async Task<List<Mines_config_chipsEO>> GetByRateAsync(double rate, int top_)
		{
			return await GetByRateAsync(rate, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Rate（字段） 查询
		/// </summary>
		/// /// <param name = "rate">中奖率</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Mines_config_chipsEO> GetByRate(double rate, int top_, TransactionManager tm_)
		{
			return GetByRate(rate, top_, string.Empty, tm_);
		}
		public async Task<List<Mines_config_chipsEO>> GetByRateAsync(double rate, int top_, TransactionManager tm_)
		{
			return await GetByRateAsync(rate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Rate（字段） 查询
		/// </summary>
		/// /// <param name = "rate">中奖率</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Mines_config_chipsEO> GetByRate(double rate, string sort_)
		{
			return GetByRate(rate, 0, sort_, null);
		}
		public async Task<List<Mines_config_chipsEO>> GetByRateAsync(double rate, string sort_)
		{
			return await GetByRateAsync(rate, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Rate（字段） 查询
		/// </summary>
		/// /// <param name = "rate">中奖率</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Mines_config_chipsEO> GetByRate(double rate, string sort_, TransactionManager tm_)
		{
			return GetByRate(rate, 0, sort_, tm_);
		}
		public async Task<List<Mines_config_chipsEO>> GetByRateAsync(double rate, string sort_, TransactionManager tm_)
		{
			return await GetByRateAsync(rate, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Rate（字段） 查询
		/// </summary>
		/// /// <param name = "rate">中奖率</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Mines_config_chipsEO> GetByRate(double rate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Rate` = @Rate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Rate", rate, MySqlDbType.Double));
			return Database.ExecSqlList(sql_, paras_, tm_, Mines_config_chipsEO.MapDataReader);
		}
		public async Task<List<Mines_config_chipsEO>> GetByRateAsync(double rate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Rate` = @Rate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Rate", rate, MySqlDbType.Double));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Mines_config_chipsEO.MapDataReader);
		}
		#endregion // GetByRate
		#region GetByMultip
		
		/// <summary>
		/// 按 Multip（字段） 查询
		/// </summary>
		/// /// <param name = "multip">赔率</param>
		/// <return>实体对象集合</return>
		public List<Mines_config_chipsEO> GetByMultip(double multip)
		{
			return GetByMultip(multip, 0, string.Empty, null);
		}
		public async Task<List<Mines_config_chipsEO>> GetByMultipAsync(double multip)
		{
			return await GetByMultipAsync(multip, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Multip（字段） 查询
		/// </summary>
		/// /// <param name = "multip">赔率</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Mines_config_chipsEO> GetByMultip(double multip, TransactionManager tm_)
		{
			return GetByMultip(multip, 0, string.Empty, tm_);
		}
		public async Task<List<Mines_config_chipsEO>> GetByMultipAsync(double multip, TransactionManager tm_)
		{
			return await GetByMultipAsync(multip, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Multip（字段） 查询
		/// </summary>
		/// /// <param name = "multip">赔率</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Mines_config_chipsEO> GetByMultip(double multip, int top_)
		{
			return GetByMultip(multip, top_, string.Empty, null);
		}
		public async Task<List<Mines_config_chipsEO>> GetByMultipAsync(double multip, int top_)
		{
			return await GetByMultipAsync(multip, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Multip（字段） 查询
		/// </summary>
		/// /// <param name = "multip">赔率</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Mines_config_chipsEO> GetByMultip(double multip, int top_, TransactionManager tm_)
		{
			return GetByMultip(multip, top_, string.Empty, tm_);
		}
		public async Task<List<Mines_config_chipsEO>> GetByMultipAsync(double multip, int top_, TransactionManager tm_)
		{
			return await GetByMultipAsync(multip, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Multip（字段） 查询
		/// </summary>
		/// /// <param name = "multip">赔率</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Mines_config_chipsEO> GetByMultip(double multip, string sort_)
		{
			return GetByMultip(multip, 0, sort_, null);
		}
		public async Task<List<Mines_config_chipsEO>> GetByMultipAsync(double multip, string sort_)
		{
			return await GetByMultipAsync(multip, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Multip（字段） 查询
		/// </summary>
		/// /// <param name = "multip">赔率</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Mines_config_chipsEO> GetByMultip(double multip, string sort_, TransactionManager tm_)
		{
			return GetByMultip(multip, 0, sort_, tm_);
		}
		public async Task<List<Mines_config_chipsEO>> GetByMultipAsync(double multip, string sort_, TransactionManager tm_)
		{
			return await GetByMultipAsync(multip, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Multip（字段） 查询
		/// </summary>
		/// /// <param name = "multip">赔率</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Mines_config_chipsEO> GetByMultip(double multip, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Multip` = @Multip", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Multip", multip, MySqlDbType.Double));
			return Database.ExecSqlList(sql_, paras_, tm_, Mines_config_chipsEO.MapDataReader);
		}
		public async Task<List<Mines_config_chipsEO>> GetByMultipAsync(double multip, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Multip` = @Multip", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Multip", multip, MySqlDbType.Double));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Mines_config_chipsEO.MapDataReader);
		}
		#endregion // GetByMultip
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
