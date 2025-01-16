/******************************************************
 * 此代码由代码生成器工具自动生成，请不要修改
 * TinyFx代码生成器核心库版本号：1.0.0.0
 * git: https://github.com/jh98net/TinyFx
 * 文档生成时间：2023-12-09 15: 12:45
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

namespace Gold_ggk.DAL
{
	#region EO
	/// <summary>
	/// 奖池权重
	/// 【表 ggk_config_weight_jackpot 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class Ggk_config_weight_jackpotEO : IRowMapper<Ggk_config_weight_jackpotEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public Ggk_config_weight_jackpotEO()
		{
			this.Mulitp = 0d;
			this.Weight = 0;
			this.Group = "1";
		}
		#region 主键原始值 & 主键集合
	    
		/// <summary>
		/// 当前对象是否保存原始主键值，当修改了主键值时为 true
		/// </summary>
		public bool HasOriginal { get; protected set; }
		
		private int _originalJPID;
		/// <summary>
		/// 【数据库中的原始主键 JPID 值的副本，用于主键值更新】
		/// </summary>
		public int OriginalJPID
		{
			get { return _originalJPID; }
			set { HasOriginal = true; _originalJPID = value; }
		}
	    /// <summary>
	    /// 获取主键集合。key: 数据库字段名称, value: 主键值
	    /// </summary>
	    /// <returns></returns>
	    public Dictionary<string, object> GetPrimaryKeys()
	    {
	        return new Dictionary<string, object>() { { "JPID", JPID }, };
	    }
	    /// <summary>
	    /// 获取主键集合JSON格式
	    /// </summary>
	    /// <returns></returns>
	    public string GetPrimaryKeysJson() => SerializerUtil.SerializeJson(GetPrimaryKeys());
		#endregion // 主键原始值
		#region 所有字段
		/// <summary>
		/// 主键
		/// 【主键 int】
		/// </summary>
		[DataMember(Order = 1)]
		public int JPID { get; set; }
		/// <summary>
		/// 倍数
		/// 【字段 double】
		/// </summary>
		[DataMember(Order = 2)]
		public double Mulitp { get; set; }
		/// <summary>
		/// 权重
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 3)]
		public int Weight { get; set; }
		/// <summary>
		/// 组合
		/// 【字段 varchar(1000)】
		/// </summary>
		[DataMember(Order = 4)]
		public string Group { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public Ggk_config_weight_jackpotEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static Ggk_config_weight_jackpotEO MapDataReader(IDataReader reader)
		{
		    Ggk_config_weight_jackpotEO ret = new Ggk_config_weight_jackpotEO();
			ret.JPID = reader.ToInt32("JPID");
			ret.OriginalJPID = ret.JPID;
			ret.Mulitp = reader.ToDouble("Mulitp");
			ret.Weight = reader.ToInt32("Weight");
			ret.Group = reader.ToString("Group");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 奖池权重
	/// 【表 ggk_config_weight_jackpot 的操作类】
	/// </summary>
	[Obsolete]
	public class Ggk_config_weight_jackpotMO : MySqlTableMO<Ggk_config_weight_jackpotEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`ggk_config_weight_jackpot`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public Ggk_config_weight_jackpotMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public Ggk_config_weight_jackpotMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public Ggk_config_weight_jackpotMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(Ggk_config_weight_jackpotEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(Ggk_config_weight_jackpotEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(Ggk_config_weight_jackpotEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`JPID`, `Mulitp`, `Weight`, `Group`) VALUE (@JPID, @Mulitp, @Weight, @Group);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@JPID", item.JPID, MySqlDbType.Int32),
				Database.CreateInParameter("@Mulitp", item.Mulitp, MySqlDbType.Double),
				Database.CreateInParameter("@Weight", item.Weight, MySqlDbType.Int32),
				Database.CreateInParameter("@Group", item.Group, MySqlDbType.VarChar),
			};
		}
		public int AddByBatch(IEnumerable<Ggk_config_weight_jackpotEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<Ggk_config_weight_jackpotEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<Ggk_config_weight_jackpotEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`JPID`, `Mulitp`, `Weight`, `Group`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"({item.JPID},{item.Mulitp},{item.Weight},'{item.Group}'),");
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
		/// /// <param name = "jPID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(int jPID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(jPID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(int jPID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(jPID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(int jPID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `JPID` = @JPID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@JPID", jPID, MySqlDbType.Int32),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(Ggk_config_weight_jackpotEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.JPID, tm_);
		}
		public async Task<int> RemoveAsync(Ggk_config_weight_jackpotEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.JPID, tm_);
		}
		#endregion // RemoveByPK
		
		#region RemoveByXXX
		#region RemoveByMulitp
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "mulitp">倍数</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByMulitp(double mulitp, TransactionManager tm_ = null)
		{
			RepairRemoveByMulitpData(mulitp, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByMulitpAsync(double mulitp, TransactionManager tm_ = null)
		{
			RepairRemoveByMulitpData(mulitp, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByMulitpData(double mulitp, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `Mulitp` = @Mulitp";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Mulitp", mulitp, MySqlDbType.Double));
		}
		#endregion // RemoveByMulitp
		#region RemoveByWeight
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "weight">权重</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByWeight(int weight, TransactionManager tm_ = null)
		{
			RepairRemoveByWeightData(weight, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByWeightAsync(int weight, TransactionManager tm_ = null)
		{
			RepairRemoveByWeightData(weight, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByWeightData(int weight, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `Weight` = @Weight";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Weight", weight, MySqlDbType.Int32));
		}
		#endregion // RemoveByWeight
		#region RemoveByGroup
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "group">组合</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByGroup(string group, TransactionManager tm_ = null)
		{
			RepairRemoveByGroupData(group, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByGroupAsync(string group, TransactionManager tm_ = null)
		{
			RepairRemoveByGroupData(group, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByGroupData(string group, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `Group` = @Group";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Group", group, MySqlDbType.VarChar));
		}
		#endregion // RemoveByGroup
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
		public int Put(Ggk_config_weight_jackpotEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(Ggk_config_weight_jackpotEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(Ggk_config_weight_jackpotEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `JPID` = @JPID, `Mulitp` = @Mulitp, `Weight` = @Weight, `Group` = @Group WHERE `JPID` = @JPID_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@JPID", item.JPID, MySqlDbType.Int32),
				Database.CreateInParameter("@Mulitp", item.Mulitp, MySqlDbType.Double),
				Database.CreateInParameter("@Weight", item.Weight, MySqlDbType.Int32),
				Database.CreateInParameter("@Group", item.Group, MySqlDbType.VarChar),
				Database.CreateInParameter("@JPID_Original", item.HasOriginal ? item.OriginalJPID : item.JPID, MySqlDbType.Int32),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<Ggk_config_weight_jackpotEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<Ggk_config_weight_jackpotEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "jPID">主键</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(int jPID, string set_, params object[] values_)
		{
			return Put(set_, "`JPID` = @JPID", ConcatValues(values_, jPID));
		}
		public async Task<int> PutByPKAsync(int jPID, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`JPID` = @JPID", ConcatValues(values_, jPID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "jPID">主键</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(int jPID, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`JPID` = @JPID", tm_, ConcatValues(values_, jPID));
		}
		public async Task<int> PutByPKAsync(int jPID, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`JPID` = @JPID", tm_, ConcatValues(values_, jPID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "jPID">主键</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(int jPID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@JPID", jPID, MySqlDbType.Int32),
	        };
			return Put(set_, "`JPID` = @JPID", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(int jPID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@JPID", jPID, MySqlDbType.Int32),
	        };
			return await PutAsync(set_, "`JPID` = @JPID", ConcatParameters(paras_, newParas_), tm_);
		}
		#endregion // PutByPK
		
		#region PutXXX
		#region PutMulitp
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "jPID">主键</param>
		/// /// <param name = "mulitp">倍数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutMulitpByPK(int jPID, double mulitp, TransactionManager tm_ = null)
		{
			RepairPutMulitpByPKData(jPID, mulitp, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutMulitpByPKAsync(int jPID, double mulitp, TransactionManager tm_ = null)
		{
			RepairPutMulitpByPKData(jPID, mulitp, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutMulitpByPKData(int jPID, double mulitp, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Mulitp` = @Mulitp  WHERE `JPID` = @JPID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Mulitp", mulitp, MySqlDbType.Double),
				Database.CreateInParameter("@JPID", jPID, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "mulitp">倍数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutMulitp(double mulitp, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Mulitp` = @Mulitp";
			var parameter_ = Database.CreateInParameter("@Mulitp", mulitp, MySqlDbType.Double);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutMulitpAsync(double mulitp, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Mulitp` = @Mulitp";
			var parameter_ = Database.CreateInParameter("@Mulitp", mulitp, MySqlDbType.Double);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutMulitp
		#region PutWeight
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "jPID">主键</param>
		/// /// <param name = "weight">权重</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutWeightByPK(int jPID, int weight, TransactionManager tm_ = null)
		{
			RepairPutWeightByPKData(jPID, weight, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutWeightByPKAsync(int jPID, int weight, TransactionManager tm_ = null)
		{
			RepairPutWeightByPKData(jPID, weight, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutWeightByPKData(int jPID, int weight, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Weight` = @Weight  WHERE `JPID` = @JPID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Weight", weight, MySqlDbType.Int32),
				Database.CreateInParameter("@JPID", jPID, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "weight">权重</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutWeight(int weight, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Weight` = @Weight";
			var parameter_ = Database.CreateInParameter("@Weight", weight, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutWeightAsync(int weight, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Weight` = @Weight";
			var parameter_ = Database.CreateInParameter("@Weight", weight, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutWeight
		#region PutGroup
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "jPID">主键</param>
		/// /// <param name = "group">组合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutGroupByPK(int jPID, string group, TransactionManager tm_ = null)
		{
			RepairPutGroupByPKData(jPID, group, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutGroupByPKAsync(int jPID, string group, TransactionManager tm_ = null)
		{
			RepairPutGroupByPKData(jPID, group, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutGroupByPKData(int jPID, string group, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Group` = @Group  WHERE `JPID` = @JPID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Group", group, MySqlDbType.VarChar),
				Database.CreateInParameter("@JPID", jPID, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "group">组合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutGroup(string group, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Group` = @Group";
			var parameter_ = Database.CreateInParameter("@Group", group, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutGroupAsync(string group, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Group` = @Group";
			var parameter_ = Database.CreateInParameter("@Group", group, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutGroup
		#endregion // PutXXX
		#endregion // Put
	   
		#region Set
		
		/// <summary>
		/// 插入或者更新数据
		/// </summary>
		/// <param name = "item">要更新的实体对象</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>true:插入操作；false:更新操作</return>
		public bool Set(Ggk_config_weight_jackpotEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.JPID) == null)
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
		public async Task<bool> SetAsync(Ggk_config_weight_jackpotEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.JPID) == null)
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
		/// /// <param name = "jPID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public Ggk_config_weight_jackpotEO GetByPK(int jPID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(jPID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, Ggk_config_weight_jackpotEO.MapDataReader);
		}
		public async Task<Ggk_config_weight_jackpotEO> GetByPKAsync(int jPID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(jPID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Ggk_config_weight_jackpotEO.MapDataReader);
		}
		private void RepairGetByPKData(int jPID, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`JPID` = @JPID", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@JPID", jPID, MySqlDbType.Int32),
			};
		}
		#endregion // GetByPK
		
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 Mulitp（字段）
		/// </summary>
		/// /// <param name = "jPID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public double GetMulitpByPK(int jPID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@JPID", jPID, MySqlDbType.Int32),
			};
			return (double)GetScalar("`Mulitp`", "`JPID` = @JPID", paras_, tm_);
		}
		public async Task<double> GetMulitpByPKAsync(int jPID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@JPID", jPID, MySqlDbType.Int32),
			};
			return (double)await GetScalarAsync("`Mulitp`", "`JPID` = @JPID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Weight（字段）
		/// </summary>
		/// /// <param name = "jPID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetWeightByPK(int jPID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@JPID", jPID, MySqlDbType.Int32),
			};
			return (int)GetScalar("`Weight`", "`JPID` = @JPID", paras_, tm_);
		}
		public async Task<int> GetWeightByPKAsync(int jPID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@JPID", jPID, MySqlDbType.Int32),
			};
			return (int)await GetScalarAsync("`Weight`", "`JPID` = @JPID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Group（字段）
		/// </summary>
		/// /// <param name = "jPID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetGroupByPK(int jPID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@JPID", jPID, MySqlDbType.Int32),
			};
			return (string)GetScalar("`Group`", "`JPID` = @JPID", paras_, tm_);
		}
		public async Task<string> GetGroupByPKAsync(int jPID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@JPID", jPID, MySqlDbType.Int32),
			};
			return (string)await GetScalarAsync("`Group`", "`JPID` = @JPID", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByMulitp
		
		/// <summary>
		/// 按 Mulitp（字段） 查询
		/// </summary>
		/// /// <param name = "mulitp">倍数</param>
		/// <return>实体对象集合</return>
		public List<Ggk_config_weight_jackpotEO> GetByMulitp(double mulitp)
		{
			return GetByMulitp(mulitp, 0, string.Empty, null);
		}
		public async Task<List<Ggk_config_weight_jackpotEO>> GetByMulitpAsync(double mulitp)
		{
			return await GetByMulitpAsync(mulitp, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Mulitp（字段） 查询
		/// </summary>
		/// /// <param name = "mulitp">倍数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Ggk_config_weight_jackpotEO> GetByMulitp(double mulitp, TransactionManager tm_)
		{
			return GetByMulitp(mulitp, 0, string.Empty, tm_);
		}
		public async Task<List<Ggk_config_weight_jackpotEO>> GetByMulitpAsync(double mulitp, TransactionManager tm_)
		{
			return await GetByMulitpAsync(mulitp, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Mulitp（字段） 查询
		/// </summary>
		/// /// <param name = "mulitp">倍数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Ggk_config_weight_jackpotEO> GetByMulitp(double mulitp, int top_)
		{
			return GetByMulitp(mulitp, top_, string.Empty, null);
		}
		public async Task<List<Ggk_config_weight_jackpotEO>> GetByMulitpAsync(double mulitp, int top_)
		{
			return await GetByMulitpAsync(mulitp, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Mulitp（字段） 查询
		/// </summary>
		/// /// <param name = "mulitp">倍数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Ggk_config_weight_jackpotEO> GetByMulitp(double mulitp, int top_, TransactionManager tm_)
		{
			return GetByMulitp(mulitp, top_, string.Empty, tm_);
		}
		public async Task<List<Ggk_config_weight_jackpotEO>> GetByMulitpAsync(double mulitp, int top_, TransactionManager tm_)
		{
			return await GetByMulitpAsync(mulitp, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Mulitp（字段） 查询
		/// </summary>
		/// /// <param name = "mulitp">倍数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Ggk_config_weight_jackpotEO> GetByMulitp(double mulitp, string sort_)
		{
			return GetByMulitp(mulitp, 0, sort_, null);
		}
		public async Task<List<Ggk_config_weight_jackpotEO>> GetByMulitpAsync(double mulitp, string sort_)
		{
			return await GetByMulitpAsync(mulitp, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Mulitp（字段） 查询
		/// </summary>
		/// /// <param name = "mulitp">倍数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Ggk_config_weight_jackpotEO> GetByMulitp(double mulitp, string sort_, TransactionManager tm_)
		{
			return GetByMulitp(mulitp, 0, sort_, tm_);
		}
		public async Task<List<Ggk_config_weight_jackpotEO>> GetByMulitpAsync(double mulitp, string sort_, TransactionManager tm_)
		{
			return await GetByMulitpAsync(mulitp, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Mulitp（字段） 查询
		/// </summary>
		/// /// <param name = "mulitp">倍数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Ggk_config_weight_jackpotEO> GetByMulitp(double mulitp, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Mulitp` = @Mulitp", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Mulitp", mulitp, MySqlDbType.Double));
			return Database.ExecSqlList(sql_, paras_, tm_, Ggk_config_weight_jackpotEO.MapDataReader);
		}
		public async Task<List<Ggk_config_weight_jackpotEO>> GetByMulitpAsync(double mulitp, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Mulitp` = @Mulitp", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Mulitp", mulitp, MySqlDbType.Double));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Ggk_config_weight_jackpotEO.MapDataReader);
		}
		#endregion // GetByMulitp
		#region GetByWeight
		
		/// <summary>
		/// 按 Weight（字段） 查询
		/// </summary>
		/// /// <param name = "weight">权重</param>
		/// <return>实体对象集合</return>
		public List<Ggk_config_weight_jackpotEO> GetByWeight(int weight)
		{
			return GetByWeight(weight, 0, string.Empty, null);
		}
		public async Task<List<Ggk_config_weight_jackpotEO>> GetByWeightAsync(int weight)
		{
			return await GetByWeightAsync(weight, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Weight（字段） 查询
		/// </summary>
		/// /// <param name = "weight">权重</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Ggk_config_weight_jackpotEO> GetByWeight(int weight, TransactionManager tm_)
		{
			return GetByWeight(weight, 0, string.Empty, tm_);
		}
		public async Task<List<Ggk_config_weight_jackpotEO>> GetByWeightAsync(int weight, TransactionManager tm_)
		{
			return await GetByWeightAsync(weight, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Weight（字段） 查询
		/// </summary>
		/// /// <param name = "weight">权重</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Ggk_config_weight_jackpotEO> GetByWeight(int weight, int top_)
		{
			return GetByWeight(weight, top_, string.Empty, null);
		}
		public async Task<List<Ggk_config_weight_jackpotEO>> GetByWeightAsync(int weight, int top_)
		{
			return await GetByWeightAsync(weight, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Weight（字段） 查询
		/// </summary>
		/// /// <param name = "weight">权重</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Ggk_config_weight_jackpotEO> GetByWeight(int weight, int top_, TransactionManager tm_)
		{
			return GetByWeight(weight, top_, string.Empty, tm_);
		}
		public async Task<List<Ggk_config_weight_jackpotEO>> GetByWeightAsync(int weight, int top_, TransactionManager tm_)
		{
			return await GetByWeightAsync(weight, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Weight（字段） 查询
		/// </summary>
		/// /// <param name = "weight">权重</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Ggk_config_weight_jackpotEO> GetByWeight(int weight, string sort_)
		{
			return GetByWeight(weight, 0, sort_, null);
		}
		public async Task<List<Ggk_config_weight_jackpotEO>> GetByWeightAsync(int weight, string sort_)
		{
			return await GetByWeightAsync(weight, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Weight（字段） 查询
		/// </summary>
		/// /// <param name = "weight">权重</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Ggk_config_weight_jackpotEO> GetByWeight(int weight, string sort_, TransactionManager tm_)
		{
			return GetByWeight(weight, 0, sort_, tm_);
		}
		public async Task<List<Ggk_config_weight_jackpotEO>> GetByWeightAsync(int weight, string sort_, TransactionManager tm_)
		{
			return await GetByWeightAsync(weight, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Weight（字段） 查询
		/// </summary>
		/// /// <param name = "weight">权重</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Ggk_config_weight_jackpotEO> GetByWeight(int weight, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Weight` = @Weight", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Weight", weight, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Ggk_config_weight_jackpotEO.MapDataReader);
		}
		public async Task<List<Ggk_config_weight_jackpotEO>> GetByWeightAsync(int weight, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Weight` = @Weight", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Weight", weight, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Ggk_config_weight_jackpotEO.MapDataReader);
		}
		#endregion // GetByWeight
		#region GetByGroup
		
		/// <summary>
		/// 按 Group（字段） 查询
		/// </summary>
		/// /// <param name = "group">组合</param>
		/// <return>实体对象集合</return>
		public List<Ggk_config_weight_jackpotEO> GetByGroup(string group)
		{
			return GetByGroup(group, 0, string.Empty, null);
		}
		public async Task<List<Ggk_config_weight_jackpotEO>> GetByGroupAsync(string group)
		{
			return await GetByGroupAsync(group, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Group（字段） 查询
		/// </summary>
		/// /// <param name = "group">组合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Ggk_config_weight_jackpotEO> GetByGroup(string group, TransactionManager tm_)
		{
			return GetByGroup(group, 0, string.Empty, tm_);
		}
		public async Task<List<Ggk_config_weight_jackpotEO>> GetByGroupAsync(string group, TransactionManager tm_)
		{
			return await GetByGroupAsync(group, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Group（字段） 查询
		/// </summary>
		/// /// <param name = "group">组合</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Ggk_config_weight_jackpotEO> GetByGroup(string group, int top_)
		{
			return GetByGroup(group, top_, string.Empty, null);
		}
		public async Task<List<Ggk_config_weight_jackpotEO>> GetByGroupAsync(string group, int top_)
		{
			return await GetByGroupAsync(group, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Group（字段） 查询
		/// </summary>
		/// /// <param name = "group">组合</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Ggk_config_weight_jackpotEO> GetByGroup(string group, int top_, TransactionManager tm_)
		{
			return GetByGroup(group, top_, string.Empty, tm_);
		}
		public async Task<List<Ggk_config_weight_jackpotEO>> GetByGroupAsync(string group, int top_, TransactionManager tm_)
		{
			return await GetByGroupAsync(group, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Group（字段） 查询
		/// </summary>
		/// /// <param name = "group">组合</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Ggk_config_weight_jackpotEO> GetByGroup(string group, string sort_)
		{
			return GetByGroup(group, 0, sort_, null);
		}
		public async Task<List<Ggk_config_weight_jackpotEO>> GetByGroupAsync(string group, string sort_)
		{
			return await GetByGroupAsync(group, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Group（字段） 查询
		/// </summary>
		/// /// <param name = "group">组合</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Ggk_config_weight_jackpotEO> GetByGroup(string group, string sort_, TransactionManager tm_)
		{
			return GetByGroup(group, 0, sort_, tm_);
		}
		public async Task<List<Ggk_config_weight_jackpotEO>> GetByGroupAsync(string group, string sort_, TransactionManager tm_)
		{
			return await GetByGroupAsync(group, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Group（字段） 查询
		/// </summary>
		/// /// <param name = "group">组合</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Ggk_config_weight_jackpotEO> GetByGroup(string group, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Group` = @Group", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Group", group, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Ggk_config_weight_jackpotEO.MapDataReader);
		}
		public async Task<List<Ggk_config_weight_jackpotEO>> GetByGroupAsync(string group, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Group` = @Group", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Group", group, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Ggk_config_weight_jackpotEO.MapDataReader);
		}
		#endregion // GetByGroup
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
