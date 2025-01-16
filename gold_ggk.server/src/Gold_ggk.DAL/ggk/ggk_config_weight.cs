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
	/// 【表 ggk_config_weight 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class Ggk_config_weightEO : IRowMapper<Ggk_config_weightEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public Ggk_config_weightEO()
		{
			this.Mulitp = 0d;
			this.Weight = 0;
			this.RewardType = 1;
		}
		#region 主键原始值 & 主键集合
	    
		/// <summary>
		/// 当前对象是否保存原始主键值，当修改了主键值时为 true
		/// </summary>
		public bool HasOriginal { get; protected set; }
		
		private int _originalWeightID;
		/// <summary>
		/// 【数据库中的原始主键 WeightID 值的副本，用于主键值更新】
		/// </summary>
		public int OriginalWeightID
		{
			get { return _originalWeightID; }
			set { HasOriginal = true; _originalWeightID = value; }
		}
	    /// <summary>
	    /// 获取主键集合。key: 数据库字段名称, value: 主键值
	    /// </summary>
	    /// <returns></returns>
	    public Dictionary<string, object> GetPrimaryKeys()
	    {
	        return new Dictionary<string, object>() { { "WeightID", WeightID }, };
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
		public int WeightID { get; set; }
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
		/// 奖金类型1-基础,2-JP奖金
		/// 【字段 tinyint】
		/// </summary>
		[DataMember(Order = 4)]
		public int RewardType { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public Ggk_config_weightEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static Ggk_config_weightEO MapDataReader(IDataReader reader)
		{
		    Ggk_config_weightEO ret = new Ggk_config_weightEO();
			ret.WeightID = reader.ToInt32("WeightID");
			ret.OriginalWeightID = ret.WeightID;
			ret.Mulitp = reader.ToDouble("Mulitp");
			ret.Weight = reader.ToInt32("Weight");
			ret.RewardType = reader.ToInt32("RewardType");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 奖池权重
	/// 【表 ggk_config_weight 的操作类】
	/// </summary>
	[Obsolete]
	public class Ggk_config_weightMO : MySqlTableMO<Ggk_config_weightEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`ggk_config_weight`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public Ggk_config_weightMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public Ggk_config_weightMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public Ggk_config_weightMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(Ggk_config_weightEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(Ggk_config_weightEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(Ggk_config_weightEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`WeightID`, `Mulitp`, `Weight`, `RewardType`) VALUE (@WeightID, @Mulitp, @Weight, @RewardType);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@WeightID", item.WeightID, MySqlDbType.Int32),
				Database.CreateInParameter("@Mulitp", item.Mulitp, MySqlDbType.Double),
				Database.CreateInParameter("@Weight", item.Weight, MySqlDbType.Int32),
				Database.CreateInParameter("@RewardType", item.RewardType, MySqlDbType.Byte),
			};
		}
		public int AddByBatch(IEnumerable<Ggk_config_weightEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<Ggk_config_weightEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<Ggk_config_weightEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`WeightID`, `Mulitp`, `Weight`, `RewardType`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"({item.WeightID},{item.Mulitp},{item.Weight},{item.RewardType}),");
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
		/// /// <param name = "weightID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(int weightID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(weightID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(int weightID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(weightID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(int weightID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `WeightID` = @WeightID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@WeightID", weightID, MySqlDbType.Int32),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(Ggk_config_weightEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.WeightID, tm_);
		}
		public async Task<int> RemoveAsync(Ggk_config_weightEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.WeightID, tm_);
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
		#region RemoveByRewardType
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "rewardType">奖金类型1-基础,2-JP奖金</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByRewardType(int rewardType, TransactionManager tm_ = null)
		{
			RepairRemoveByRewardTypeData(rewardType, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByRewardTypeAsync(int rewardType, TransactionManager tm_ = null)
		{
			RepairRemoveByRewardTypeData(rewardType, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByRewardTypeData(int rewardType, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `RewardType` = @RewardType";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RewardType", rewardType, MySqlDbType.Byte));
		}
		#endregion // RemoveByRewardType
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
		public int Put(Ggk_config_weightEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(Ggk_config_weightEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(Ggk_config_weightEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `WeightID` = @WeightID, `Mulitp` = @Mulitp, `Weight` = @Weight, `RewardType` = @RewardType WHERE `WeightID` = @WeightID_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@WeightID", item.WeightID, MySqlDbType.Int32),
				Database.CreateInParameter("@Mulitp", item.Mulitp, MySqlDbType.Double),
				Database.CreateInParameter("@Weight", item.Weight, MySqlDbType.Int32),
				Database.CreateInParameter("@RewardType", item.RewardType, MySqlDbType.Byte),
				Database.CreateInParameter("@WeightID_Original", item.HasOriginal ? item.OriginalWeightID : item.WeightID, MySqlDbType.Int32),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<Ggk_config_weightEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<Ggk_config_weightEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "weightID">主键</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(int weightID, string set_, params object[] values_)
		{
			return Put(set_, "`WeightID` = @WeightID", ConcatValues(values_, weightID));
		}
		public async Task<int> PutByPKAsync(int weightID, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`WeightID` = @WeightID", ConcatValues(values_, weightID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "weightID">主键</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(int weightID, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`WeightID` = @WeightID", tm_, ConcatValues(values_, weightID));
		}
		public async Task<int> PutByPKAsync(int weightID, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`WeightID` = @WeightID", tm_, ConcatValues(values_, weightID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "weightID">主键</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(int weightID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@WeightID", weightID, MySqlDbType.Int32),
	        };
			return Put(set_, "`WeightID` = @WeightID", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(int weightID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@WeightID", weightID, MySqlDbType.Int32),
	        };
			return await PutAsync(set_, "`WeightID` = @WeightID", ConcatParameters(paras_, newParas_), tm_);
		}
		#endregion // PutByPK
		
		#region PutXXX
		#region PutMulitp
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "weightID">主键</param>
		/// /// <param name = "mulitp">倍数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutMulitpByPK(int weightID, double mulitp, TransactionManager tm_ = null)
		{
			RepairPutMulitpByPKData(weightID, mulitp, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutMulitpByPKAsync(int weightID, double mulitp, TransactionManager tm_ = null)
		{
			RepairPutMulitpByPKData(weightID, mulitp, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutMulitpByPKData(int weightID, double mulitp, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Mulitp` = @Mulitp  WHERE `WeightID` = @WeightID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Mulitp", mulitp, MySqlDbType.Double),
				Database.CreateInParameter("@WeightID", weightID, MySqlDbType.Int32),
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
		/// /// <param name = "weightID">主键</param>
		/// /// <param name = "weight">权重</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutWeightByPK(int weightID, int weight, TransactionManager tm_ = null)
		{
			RepairPutWeightByPKData(weightID, weight, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutWeightByPKAsync(int weightID, int weight, TransactionManager tm_ = null)
		{
			RepairPutWeightByPKData(weightID, weight, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutWeightByPKData(int weightID, int weight, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Weight` = @Weight  WHERE `WeightID` = @WeightID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Weight", weight, MySqlDbType.Int32),
				Database.CreateInParameter("@WeightID", weightID, MySqlDbType.Int32),
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
		#region PutRewardType
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "weightID">主键</param>
		/// /// <param name = "rewardType">奖金类型1-基础,2-JP奖金</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRewardTypeByPK(int weightID, int rewardType, TransactionManager tm_ = null)
		{
			RepairPutRewardTypeByPKData(weightID, rewardType, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutRewardTypeByPKAsync(int weightID, int rewardType, TransactionManager tm_ = null)
		{
			RepairPutRewardTypeByPKData(weightID, rewardType, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutRewardTypeByPKData(int weightID, int rewardType, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `RewardType` = @RewardType  WHERE `WeightID` = @WeightID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RewardType", rewardType, MySqlDbType.Byte),
				Database.CreateInParameter("@WeightID", weightID, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "rewardType">奖金类型1-基础,2-JP奖金</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRewardType(int rewardType, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `RewardType` = @RewardType";
			var parameter_ = Database.CreateInParameter("@RewardType", rewardType, MySqlDbType.Byte);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutRewardTypeAsync(int rewardType, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `RewardType` = @RewardType";
			var parameter_ = Database.CreateInParameter("@RewardType", rewardType, MySqlDbType.Byte);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutRewardType
		#endregion // PutXXX
		#endregion // Put
	   
		#region Set
		
		/// <summary>
		/// 插入或者更新数据
		/// </summary>
		/// <param name = "item">要更新的实体对象</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>true:插入操作；false:更新操作</return>
		public bool Set(Ggk_config_weightEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.WeightID) == null)
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
		public async Task<bool> SetAsync(Ggk_config_weightEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.WeightID) == null)
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
		/// /// <param name = "weightID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public Ggk_config_weightEO GetByPK(int weightID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(weightID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, Ggk_config_weightEO.MapDataReader);
		}
		public async Task<Ggk_config_weightEO> GetByPKAsync(int weightID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(weightID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Ggk_config_weightEO.MapDataReader);
		}
		private void RepairGetByPKData(int weightID, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`WeightID` = @WeightID", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@WeightID", weightID, MySqlDbType.Int32),
			};
		}
		#endregion // GetByPK
		
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 Mulitp（字段）
		/// </summary>
		/// /// <param name = "weightID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public double GetMulitpByPK(int weightID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@WeightID", weightID, MySqlDbType.Int32),
			};
			return (double)GetScalar("`Mulitp`", "`WeightID` = @WeightID", paras_, tm_);
		}
		public async Task<double> GetMulitpByPKAsync(int weightID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@WeightID", weightID, MySqlDbType.Int32),
			};
			return (double)await GetScalarAsync("`Mulitp`", "`WeightID` = @WeightID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Weight（字段）
		/// </summary>
		/// /// <param name = "weightID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetWeightByPK(int weightID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@WeightID", weightID, MySqlDbType.Int32),
			};
			return (int)GetScalar("`Weight`", "`WeightID` = @WeightID", paras_, tm_);
		}
		public async Task<int> GetWeightByPKAsync(int weightID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@WeightID", weightID, MySqlDbType.Int32),
			};
			return (int)await GetScalarAsync("`Weight`", "`WeightID` = @WeightID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 RewardType（字段）
		/// </summary>
		/// /// <param name = "weightID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetRewardTypeByPK(int weightID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@WeightID", weightID, MySqlDbType.Int32),
			};
			return (int)GetScalar("`RewardType`", "`WeightID` = @WeightID", paras_, tm_);
		}
		public async Task<int> GetRewardTypeByPKAsync(int weightID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@WeightID", weightID, MySqlDbType.Int32),
			};
			return (int)await GetScalarAsync("`RewardType`", "`WeightID` = @WeightID", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByMulitp
		
		/// <summary>
		/// 按 Mulitp（字段） 查询
		/// </summary>
		/// /// <param name = "mulitp">倍数</param>
		/// <return>实体对象集合</return>
		public List<Ggk_config_weightEO> GetByMulitp(double mulitp)
		{
			return GetByMulitp(mulitp, 0, string.Empty, null);
		}
		public async Task<List<Ggk_config_weightEO>> GetByMulitpAsync(double mulitp)
		{
			return await GetByMulitpAsync(mulitp, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Mulitp（字段） 查询
		/// </summary>
		/// /// <param name = "mulitp">倍数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Ggk_config_weightEO> GetByMulitp(double mulitp, TransactionManager tm_)
		{
			return GetByMulitp(mulitp, 0, string.Empty, tm_);
		}
		public async Task<List<Ggk_config_weightEO>> GetByMulitpAsync(double mulitp, TransactionManager tm_)
		{
			return await GetByMulitpAsync(mulitp, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Mulitp（字段） 查询
		/// </summary>
		/// /// <param name = "mulitp">倍数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Ggk_config_weightEO> GetByMulitp(double mulitp, int top_)
		{
			return GetByMulitp(mulitp, top_, string.Empty, null);
		}
		public async Task<List<Ggk_config_weightEO>> GetByMulitpAsync(double mulitp, int top_)
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
		public List<Ggk_config_weightEO> GetByMulitp(double mulitp, int top_, TransactionManager tm_)
		{
			return GetByMulitp(mulitp, top_, string.Empty, tm_);
		}
		public async Task<List<Ggk_config_weightEO>> GetByMulitpAsync(double mulitp, int top_, TransactionManager tm_)
		{
			return await GetByMulitpAsync(mulitp, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Mulitp（字段） 查询
		/// </summary>
		/// /// <param name = "mulitp">倍数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Ggk_config_weightEO> GetByMulitp(double mulitp, string sort_)
		{
			return GetByMulitp(mulitp, 0, sort_, null);
		}
		public async Task<List<Ggk_config_weightEO>> GetByMulitpAsync(double mulitp, string sort_)
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
		public List<Ggk_config_weightEO> GetByMulitp(double mulitp, string sort_, TransactionManager tm_)
		{
			return GetByMulitp(mulitp, 0, sort_, tm_);
		}
		public async Task<List<Ggk_config_weightEO>> GetByMulitpAsync(double mulitp, string sort_, TransactionManager tm_)
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
		public List<Ggk_config_weightEO> GetByMulitp(double mulitp, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Mulitp` = @Mulitp", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Mulitp", mulitp, MySqlDbType.Double));
			return Database.ExecSqlList(sql_, paras_, tm_, Ggk_config_weightEO.MapDataReader);
		}
		public async Task<List<Ggk_config_weightEO>> GetByMulitpAsync(double mulitp, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Mulitp` = @Mulitp", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Mulitp", mulitp, MySqlDbType.Double));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Ggk_config_weightEO.MapDataReader);
		}
		#endregion // GetByMulitp
		#region GetByWeight
		
		/// <summary>
		/// 按 Weight（字段） 查询
		/// </summary>
		/// /// <param name = "weight">权重</param>
		/// <return>实体对象集合</return>
		public List<Ggk_config_weightEO> GetByWeight(int weight)
		{
			return GetByWeight(weight, 0, string.Empty, null);
		}
		public async Task<List<Ggk_config_weightEO>> GetByWeightAsync(int weight)
		{
			return await GetByWeightAsync(weight, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Weight（字段） 查询
		/// </summary>
		/// /// <param name = "weight">权重</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Ggk_config_weightEO> GetByWeight(int weight, TransactionManager tm_)
		{
			return GetByWeight(weight, 0, string.Empty, tm_);
		}
		public async Task<List<Ggk_config_weightEO>> GetByWeightAsync(int weight, TransactionManager tm_)
		{
			return await GetByWeightAsync(weight, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Weight（字段） 查询
		/// </summary>
		/// /// <param name = "weight">权重</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Ggk_config_weightEO> GetByWeight(int weight, int top_)
		{
			return GetByWeight(weight, top_, string.Empty, null);
		}
		public async Task<List<Ggk_config_weightEO>> GetByWeightAsync(int weight, int top_)
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
		public List<Ggk_config_weightEO> GetByWeight(int weight, int top_, TransactionManager tm_)
		{
			return GetByWeight(weight, top_, string.Empty, tm_);
		}
		public async Task<List<Ggk_config_weightEO>> GetByWeightAsync(int weight, int top_, TransactionManager tm_)
		{
			return await GetByWeightAsync(weight, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Weight（字段） 查询
		/// </summary>
		/// /// <param name = "weight">权重</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Ggk_config_weightEO> GetByWeight(int weight, string sort_)
		{
			return GetByWeight(weight, 0, sort_, null);
		}
		public async Task<List<Ggk_config_weightEO>> GetByWeightAsync(int weight, string sort_)
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
		public List<Ggk_config_weightEO> GetByWeight(int weight, string sort_, TransactionManager tm_)
		{
			return GetByWeight(weight, 0, sort_, tm_);
		}
		public async Task<List<Ggk_config_weightEO>> GetByWeightAsync(int weight, string sort_, TransactionManager tm_)
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
		public List<Ggk_config_weightEO> GetByWeight(int weight, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Weight` = @Weight", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Weight", weight, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Ggk_config_weightEO.MapDataReader);
		}
		public async Task<List<Ggk_config_weightEO>> GetByWeightAsync(int weight, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Weight` = @Weight", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Weight", weight, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Ggk_config_weightEO.MapDataReader);
		}
		#endregion // GetByWeight
		#region GetByRewardType
		
		/// <summary>
		/// 按 RewardType（字段） 查询
		/// </summary>
		/// /// <param name = "rewardType">奖金类型1-基础,2-JP奖金</param>
		/// <return>实体对象集合</return>
		public List<Ggk_config_weightEO> GetByRewardType(int rewardType)
		{
			return GetByRewardType(rewardType, 0, string.Empty, null);
		}
		public async Task<List<Ggk_config_weightEO>> GetByRewardTypeAsync(int rewardType)
		{
			return await GetByRewardTypeAsync(rewardType, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RewardType（字段） 查询
		/// </summary>
		/// /// <param name = "rewardType">奖金类型1-基础,2-JP奖金</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Ggk_config_weightEO> GetByRewardType(int rewardType, TransactionManager tm_)
		{
			return GetByRewardType(rewardType, 0, string.Empty, tm_);
		}
		public async Task<List<Ggk_config_weightEO>> GetByRewardTypeAsync(int rewardType, TransactionManager tm_)
		{
			return await GetByRewardTypeAsync(rewardType, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RewardType（字段） 查询
		/// </summary>
		/// /// <param name = "rewardType">奖金类型1-基础,2-JP奖金</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Ggk_config_weightEO> GetByRewardType(int rewardType, int top_)
		{
			return GetByRewardType(rewardType, top_, string.Empty, null);
		}
		public async Task<List<Ggk_config_weightEO>> GetByRewardTypeAsync(int rewardType, int top_)
		{
			return await GetByRewardTypeAsync(rewardType, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RewardType（字段） 查询
		/// </summary>
		/// /// <param name = "rewardType">奖金类型1-基础,2-JP奖金</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Ggk_config_weightEO> GetByRewardType(int rewardType, int top_, TransactionManager tm_)
		{
			return GetByRewardType(rewardType, top_, string.Empty, tm_);
		}
		public async Task<List<Ggk_config_weightEO>> GetByRewardTypeAsync(int rewardType, int top_, TransactionManager tm_)
		{
			return await GetByRewardTypeAsync(rewardType, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RewardType（字段） 查询
		/// </summary>
		/// /// <param name = "rewardType">奖金类型1-基础,2-JP奖金</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Ggk_config_weightEO> GetByRewardType(int rewardType, string sort_)
		{
			return GetByRewardType(rewardType, 0, sort_, null);
		}
		public async Task<List<Ggk_config_weightEO>> GetByRewardTypeAsync(int rewardType, string sort_)
		{
			return await GetByRewardTypeAsync(rewardType, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 RewardType（字段） 查询
		/// </summary>
		/// /// <param name = "rewardType">奖金类型1-基础,2-JP奖金</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Ggk_config_weightEO> GetByRewardType(int rewardType, string sort_, TransactionManager tm_)
		{
			return GetByRewardType(rewardType, 0, sort_, tm_);
		}
		public async Task<List<Ggk_config_weightEO>> GetByRewardTypeAsync(int rewardType, string sort_, TransactionManager tm_)
		{
			return await GetByRewardTypeAsync(rewardType, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 RewardType（字段） 查询
		/// </summary>
		/// /// <param name = "rewardType">奖金类型1-基础,2-JP奖金</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Ggk_config_weightEO> GetByRewardType(int rewardType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RewardType` = @RewardType", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RewardType", rewardType, MySqlDbType.Byte));
			return Database.ExecSqlList(sql_, paras_, tm_, Ggk_config_weightEO.MapDataReader);
		}
		public async Task<List<Ggk_config_weightEO>> GetByRewardTypeAsync(int rewardType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RewardType` = @RewardType", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RewardType", rewardType, MySqlDbType.Byte));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Ggk_config_weightEO.MapDataReader);
		}
		#endregion // GetByRewardType
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
