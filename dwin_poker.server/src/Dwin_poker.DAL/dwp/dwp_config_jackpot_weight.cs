/******************************************************
 * 此代码由代码生成器工具自动生成，请不要修改
 * TinyFx代码生成器核心库版本号：1.0.0.0
 * git: https://github.com/jh98net/TinyFx
 * 文档生成时间：2023-12-09 15: 08:16
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

namespace Dwin_poker.DAL
{
	#region EO
	/// <summary>
	/// JP奖池对应权重
	/// 【表 dwp_config_jackpot_weight 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class Dwp_config_jackpot_weightEO : IRowMapper<Dwp_config_jackpot_weightEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public Dwp_config_jackpot_weightEO()
		{
			this.ChipsId = 0;
			this.JPTotalValMin = 0;
			this.JPTotalValMax = 0;
			this.Weight = 0;
			this.JPRewardIndex = 0;
		}
		#region 主键原始值 & 主键集合
	    
		/// <summary>
		/// 当前对象是否保存原始主键值，当修改了主键值时为 true
		/// </summary>
		public bool HasOriginal { get; protected set; }
		
		private int _originalJPWeightID;
		/// <summary>
		/// 【数据库中的原始主键 JPWeightID 值的副本，用于主键值更新】
		/// </summary>
		public int OriginalJPWeightID
		{
			get { return _originalJPWeightID; }
			set { HasOriginal = true; _originalJPWeightID = value; }
		}
	    /// <summary>
	    /// 获取主键集合。key: 数据库字段名称, value: 主键值
	    /// </summary>
	    /// <returns></returns>
	    public Dictionary<string, object> GetPrimaryKeys()
	    {
	        return new Dictionary<string, object>() { { "JPWeightID", JPWeightID }, };
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
		public int JPWeightID { get; set; }
		/// <summary>
		/// 下注id
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 2)]
		public int ChipsId { get; set; }
		/// <summary>
		/// 累计值最小区间(包含下限)
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 3)]
		public int JPTotalValMin { get; set; }
		/// <summary>
		/// 累计值最大区间(不包含上限)
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 4)]
		public int JPTotalValMax { get; set; }
		/// <summary>
		/// 权重
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 5)]
		public int Weight { get; set; }
		/// <summary>
		/// JP索引 （0-JPMini，1-JPMajor，2-JPMega）
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 6)]
		public int JPRewardIndex { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public Dwp_config_jackpot_weightEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static Dwp_config_jackpot_weightEO MapDataReader(IDataReader reader)
		{
		    Dwp_config_jackpot_weightEO ret = new Dwp_config_jackpot_weightEO();
			ret.JPWeightID = reader.ToInt32("JPWeightID");
			ret.OriginalJPWeightID = ret.JPWeightID;
			ret.ChipsId = reader.ToInt32("ChipsId");
			ret.JPTotalValMin = reader.ToInt32("JPTotalValMin");
			ret.JPTotalValMax = reader.ToInt32("JPTotalValMax");
			ret.Weight = reader.ToInt32("Weight");
			ret.JPRewardIndex = reader.ToInt32("JPRewardIndex");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// JP奖池对应权重
	/// 【表 dwp_config_jackpot_weight 的操作类】
	/// </summary>
	[Obsolete]
	public class Dwp_config_jackpot_weightMO : MySqlTableMO<Dwp_config_jackpot_weightEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`dwp_config_jackpot_weight`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public Dwp_config_jackpot_weightMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public Dwp_config_jackpot_weightMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public Dwp_config_jackpot_weightMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(Dwp_config_jackpot_weightEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(Dwp_config_jackpot_weightEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(Dwp_config_jackpot_weightEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`JPWeightID`, `ChipsId`, `JPTotalValMin`, `JPTotalValMax`, `Weight`, `JPRewardIndex`) VALUE (@JPWeightID, @ChipsId, @JPTotalValMin, @JPTotalValMax, @Weight, @JPRewardIndex);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@JPWeightID", item.JPWeightID, MySqlDbType.Int32),
				Database.CreateInParameter("@ChipsId", item.ChipsId, MySqlDbType.Int32),
				Database.CreateInParameter("@JPTotalValMin", item.JPTotalValMin, MySqlDbType.Int32),
				Database.CreateInParameter("@JPTotalValMax", item.JPTotalValMax, MySqlDbType.Int32),
				Database.CreateInParameter("@Weight", item.Weight, MySqlDbType.Int32),
				Database.CreateInParameter("@JPRewardIndex", item.JPRewardIndex, MySqlDbType.Int32),
			};
		}
		public int AddByBatch(IEnumerable<Dwp_config_jackpot_weightEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<Dwp_config_jackpot_weightEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<Dwp_config_jackpot_weightEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`JPWeightID`, `ChipsId`, `JPTotalValMin`, `JPTotalValMax`, `Weight`, `JPRewardIndex`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"({item.JPWeightID},{item.ChipsId},{item.JPTotalValMin},{item.JPTotalValMax},{item.Weight},{item.JPRewardIndex}),");
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
		/// /// <param name = "jPWeightID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(int jPWeightID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(jPWeightID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(int jPWeightID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(jPWeightID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(int jPWeightID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `JPWeightID` = @JPWeightID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@JPWeightID", jPWeightID, MySqlDbType.Int32),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(Dwp_config_jackpot_weightEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.JPWeightID, tm_);
		}
		public async Task<int> RemoveAsync(Dwp_config_jackpot_weightEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.JPWeightID, tm_);
		}
		#endregion // RemoveByPK
		
		#region RemoveByXXX
		#region RemoveByChipsId
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "chipsId">下注id</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByChipsId(int chipsId, TransactionManager tm_ = null)
		{
			RepairRemoveByChipsIdData(chipsId, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByChipsIdAsync(int chipsId, TransactionManager tm_ = null)
		{
			RepairRemoveByChipsIdData(chipsId, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByChipsIdData(int chipsId, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `ChipsId` = @ChipsId";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ChipsId", chipsId, MySqlDbType.Int32));
		}
		#endregion // RemoveByChipsId
		#region RemoveByJPTotalValMin
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "jPTotalValMin">累计值最小区间(包含下限)</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByJPTotalValMin(int jPTotalValMin, TransactionManager tm_ = null)
		{
			RepairRemoveByJPTotalValMinData(jPTotalValMin, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByJPTotalValMinAsync(int jPTotalValMin, TransactionManager tm_ = null)
		{
			RepairRemoveByJPTotalValMinData(jPTotalValMin, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByJPTotalValMinData(int jPTotalValMin, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `JPTotalValMin` = @JPTotalValMin";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@JPTotalValMin", jPTotalValMin, MySqlDbType.Int32));
		}
		#endregion // RemoveByJPTotalValMin
		#region RemoveByJPTotalValMax
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "jPTotalValMax">累计值最大区间(不包含上限)</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByJPTotalValMax(int jPTotalValMax, TransactionManager tm_ = null)
		{
			RepairRemoveByJPTotalValMaxData(jPTotalValMax, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByJPTotalValMaxAsync(int jPTotalValMax, TransactionManager tm_ = null)
		{
			RepairRemoveByJPTotalValMaxData(jPTotalValMax, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByJPTotalValMaxData(int jPTotalValMax, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `JPTotalValMax` = @JPTotalValMax";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@JPTotalValMax", jPTotalValMax, MySqlDbType.Int32));
		}
		#endregion // RemoveByJPTotalValMax
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
		#region RemoveByJPRewardIndex
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "jPRewardIndex">JP索引 （0-JPMini，1-JPMajor，2-JPMega）</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByJPRewardIndex(int jPRewardIndex, TransactionManager tm_ = null)
		{
			RepairRemoveByJPRewardIndexData(jPRewardIndex, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByJPRewardIndexAsync(int jPRewardIndex, TransactionManager tm_ = null)
		{
			RepairRemoveByJPRewardIndexData(jPRewardIndex, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByJPRewardIndexData(int jPRewardIndex, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `JPRewardIndex` = @JPRewardIndex";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@JPRewardIndex", jPRewardIndex, MySqlDbType.Int32));
		}
		#endregion // RemoveByJPRewardIndex
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
		public int Put(Dwp_config_jackpot_weightEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(Dwp_config_jackpot_weightEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(Dwp_config_jackpot_weightEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `JPWeightID` = @JPWeightID, `ChipsId` = @ChipsId, `JPTotalValMin` = @JPTotalValMin, `JPTotalValMax` = @JPTotalValMax, `Weight` = @Weight, `JPRewardIndex` = @JPRewardIndex WHERE `JPWeightID` = @JPWeightID_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@JPWeightID", item.JPWeightID, MySqlDbType.Int32),
				Database.CreateInParameter("@ChipsId", item.ChipsId, MySqlDbType.Int32),
				Database.CreateInParameter("@JPTotalValMin", item.JPTotalValMin, MySqlDbType.Int32),
				Database.CreateInParameter("@JPTotalValMax", item.JPTotalValMax, MySqlDbType.Int32),
				Database.CreateInParameter("@Weight", item.Weight, MySqlDbType.Int32),
				Database.CreateInParameter("@JPRewardIndex", item.JPRewardIndex, MySqlDbType.Int32),
				Database.CreateInParameter("@JPWeightID_Original", item.HasOriginal ? item.OriginalJPWeightID : item.JPWeightID, MySqlDbType.Int32),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<Dwp_config_jackpot_weightEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<Dwp_config_jackpot_weightEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "jPWeightID">主键</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(int jPWeightID, string set_, params object[] values_)
		{
			return Put(set_, "`JPWeightID` = @JPWeightID", ConcatValues(values_, jPWeightID));
		}
		public async Task<int> PutByPKAsync(int jPWeightID, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`JPWeightID` = @JPWeightID", ConcatValues(values_, jPWeightID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "jPWeightID">主键</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(int jPWeightID, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`JPWeightID` = @JPWeightID", tm_, ConcatValues(values_, jPWeightID));
		}
		public async Task<int> PutByPKAsync(int jPWeightID, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`JPWeightID` = @JPWeightID", tm_, ConcatValues(values_, jPWeightID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "jPWeightID">主键</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(int jPWeightID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@JPWeightID", jPWeightID, MySqlDbType.Int32),
	        };
			return Put(set_, "`JPWeightID` = @JPWeightID", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(int jPWeightID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@JPWeightID", jPWeightID, MySqlDbType.Int32),
	        };
			return await PutAsync(set_, "`JPWeightID` = @JPWeightID", ConcatParameters(paras_, newParas_), tm_);
		}
		#endregion // PutByPK
		
		#region PutXXX
		#region PutChipsId
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "jPWeightID">主键</param>
		/// /// <param name = "chipsId">下注id</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutChipsIdByPK(int jPWeightID, int chipsId, TransactionManager tm_ = null)
		{
			RepairPutChipsIdByPKData(jPWeightID, chipsId, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutChipsIdByPKAsync(int jPWeightID, int chipsId, TransactionManager tm_ = null)
		{
			RepairPutChipsIdByPKData(jPWeightID, chipsId, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutChipsIdByPKData(int jPWeightID, int chipsId, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `ChipsId` = @ChipsId  WHERE `JPWeightID` = @JPWeightID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChipsId", chipsId, MySqlDbType.Int32),
				Database.CreateInParameter("@JPWeightID", jPWeightID, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "chipsId">下注id</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutChipsId(int chipsId, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ChipsId` = @ChipsId";
			var parameter_ = Database.CreateInParameter("@ChipsId", chipsId, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutChipsIdAsync(int chipsId, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ChipsId` = @ChipsId";
			var parameter_ = Database.CreateInParameter("@ChipsId", chipsId, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutChipsId
		#region PutJPTotalValMin
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "jPWeightID">主键</param>
		/// /// <param name = "jPTotalValMin">累计值最小区间(包含下限)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutJPTotalValMinByPK(int jPWeightID, int jPTotalValMin, TransactionManager tm_ = null)
		{
			RepairPutJPTotalValMinByPKData(jPWeightID, jPTotalValMin, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutJPTotalValMinByPKAsync(int jPWeightID, int jPTotalValMin, TransactionManager tm_ = null)
		{
			RepairPutJPTotalValMinByPKData(jPWeightID, jPTotalValMin, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutJPTotalValMinByPKData(int jPWeightID, int jPTotalValMin, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `JPTotalValMin` = @JPTotalValMin  WHERE `JPWeightID` = @JPWeightID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@JPTotalValMin", jPTotalValMin, MySqlDbType.Int32),
				Database.CreateInParameter("@JPWeightID", jPWeightID, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "jPTotalValMin">累计值最小区间(包含下限)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutJPTotalValMin(int jPTotalValMin, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `JPTotalValMin` = @JPTotalValMin";
			var parameter_ = Database.CreateInParameter("@JPTotalValMin", jPTotalValMin, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutJPTotalValMinAsync(int jPTotalValMin, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `JPTotalValMin` = @JPTotalValMin";
			var parameter_ = Database.CreateInParameter("@JPTotalValMin", jPTotalValMin, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutJPTotalValMin
		#region PutJPTotalValMax
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "jPWeightID">主键</param>
		/// /// <param name = "jPTotalValMax">累计值最大区间(不包含上限)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutJPTotalValMaxByPK(int jPWeightID, int jPTotalValMax, TransactionManager tm_ = null)
		{
			RepairPutJPTotalValMaxByPKData(jPWeightID, jPTotalValMax, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutJPTotalValMaxByPKAsync(int jPWeightID, int jPTotalValMax, TransactionManager tm_ = null)
		{
			RepairPutJPTotalValMaxByPKData(jPWeightID, jPTotalValMax, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutJPTotalValMaxByPKData(int jPWeightID, int jPTotalValMax, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `JPTotalValMax` = @JPTotalValMax  WHERE `JPWeightID` = @JPWeightID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@JPTotalValMax", jPTotalValMax, MySqlDbType.Int32),
				Database.CreateInParameter("@JPWeightID", jPWeightID, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "jPTotalValMax">累计值最大区间(不包含上限)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutJPTotalValMax(int jPTotalValMax, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `JPTotalValMax` = @JPTotalValMax";
			var parameter_ = Database.CreateInParameter("@JPTotalValMax", jPTotalValMax, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutJPTotalValMaxAsync(int jPTotalValMax, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `JPTotalValMax` = @JPTotalValMax";
			var parameter_ = Database.CreateInParameter("@JPTotalValMax", jPTotalValMax, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutJPTotalValMax
		#region PutWeight
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "jPWeightID">主键</param>
		/// /// <param name = "weight">权重</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutWeightByPK(int jPWeightID, int weight, TransactionManager tm_ = null)
		{
			RepairPutWeightByPKData(jPWeightID, weight, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutWeightByPKAsync(int jPWeightID, int weight, TransactionManager tm_ = null)
		{
			RepairPutWeightByPKData(jPWeightID, weight, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutWeightByPKData(int jPWeightID, int weight, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Weight` = @Weight  WHERE `JPWeightID` = @JPWeightID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Weight", weight, MySqlDbType.Int32),
				Database.CreateInParameter("@JPWeightID", jPWeightID, MySqlDbType.Int32),
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
		#region PutJPRewardIndex
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "jPWeightID">主键</param>
		/// /// <param name = "jPRewardIndex">JP索引 （0-JPMini，1-JPMajor，2-JPMega）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutJPRewardIndexByPK(int jPWeightID, int jPRewardIndex, TransactionManager tm_ = null)
		{
			RepairPutJPRewardIndexByPKData(jPWeightID, jPRewardIndex, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutJPRewardIndexByPKAsync(int jPWeightID, int jPRewardIndex, TransactionManager tm_ = null)
		{
			RepairPutJPRewardIndexByPKData(jPWeightID, jPRewardIndex, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutJPRewardIndexByPKData(int jPWeightID, int jPRewardIndex, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `JPRewardIndex` = @JPRewardIndex  WHERE `JPWeightID` = @JPWeightID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@JPRewardIndex", jPRewardIndex, MySqlDbType.Int32),
				Database.CreateInParameter("@JPWeightID", jPWeightID, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "jPRewardIndex">JP索引 （0-JPMini，1-JPMajor，2-JPMega）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutJPRewardIndex(int jPRewardIndex, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `JPRewardIndex` = @JPRewardIndex";
			var parameter_ = Database.CreateInParameter("@JPRewardIndex", jPRewardIndex, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutJPRewardIndexAsync(int jPRewardIndex, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `JPRewardIndex` = @JPRewardIndex";
			var parameter_ = Database.CreateInParameter("@JPRewardIndex", jPRewardIndex, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutJPRewardIndex
		#endregion // PutXXX
		#endregion // Put
	   
		#region Set
		
		/// <summary>
		/// 插入或者更新数据
		/// </summary>
		/// <param name = "item">要更新的实体对象</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>true:插入操作；false:更新操作</return>
		public bool Set(Dwp_config_jackpot_weightEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.JPWeightID) == null)
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
		public async Task<bool> SetAsync(Dwp_config_jackpot_weightEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.JPWeightID) == null)
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
		/// /// <param name = "jPWeightID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public Dwp_config_jackpot_weightEO GetByPK(int jPWeightID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(jPWeightID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, Dwp_config_jackpot_weightEO.MapDataReader);
		}
		public async Task<Dwp_config_jackpot_weightEO> GetByPKAsync(int jPWeightID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(jPWeightID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Dwp_config_jackpot_weightEO.MapDataReader);
		}
		private void RepairGetByPKData(int jPWeightID, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`JPWeightID` = @JPWeightID", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@JPWeightID", jPWeightID, MySqlDbType.Int32),
			};
		}
		#endregion // GetByPK
		
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 ChipsId（字段）
		/// </summary>
		/// /// <param name = "jPWeightID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetChipsIdByPK(int jPWeightID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@JPWeightID", jPWeightID, MySqlDbType.Int32),
			};
			return (int)GetScalar("`ChipsId`", "`JPWeightID` = @JPWeightID", paras_, tm_);
		}
		public async Task<int> GetChipsIdByPKAsync(int jPWeightID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@JPWeightID", jPWeightID, MySqlDbType.Int32),
			};
			return (int)await GetScalarAsync("`ChipsId`", "`JPWeightID` = @JPWeightID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 JPTotalValMin（字段）
		/// </summary>
		/// /// <param name = "jPWeightID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetJPTotalValMinByPK(int jPWeightID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@JPWeightID", jPWeightID, MySqlDbType.Int32),
			};
			return (int)GetScalar("`JPTotalValMin`", "`JPWeightID` = @JPWeightID", paras_, tm_);
		}
		public async Task<int> GetJPTotalValMinByPKAsync(int jPWeightID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@JPWeightID", jPWeightID, MySqlDbType.Int32),
			};
			return (int)await GetScalarAsync("`JPTotalValMin`", "`JPWeightID` = @JPWeightID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 JPTotalValMax（字段）
		/// </summary>
		/// /// <param name = "jPWeightID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetJPTotalValMaxByPK(int jPWeightID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@JPWeightID", jPWeightID, MySqlDbType.Int32),
			};
			return (int)GetScalar("`JPTotalValMax`", "`JPWeightID` = @JPWeightID", paras_, tm_);
		}
		public async Task<int> GetJPTotalValMaxByPKAsync(int jPWeightID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@JPWeightID", jPWeightID, MySqlDbType.Int32),
			};
			return (int)await GetScalarAsync("`JPTotalValMax`", "`JPWeightID` = @JPWeightID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Weight（字段）
		/// </summary>
		/// /// <param name = "jPWeightID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetWeightByPK(int jPWeightID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@JPWeightID", jPWeightID, MySqlDbType.Int32),
			};
			return (int)GetScalar("`Weight`", "`JPWeightID` = @JPWeightID", paras_, tm_);
		}
		public async Task<int> GetWeightByPKAsync(int jPWeightID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@JPWeightID", jPWeightID, MySqlDbType.Int32),
			};
			return (int)await GetScalarAsync("`Weight`", "`JPWeightID` = @JPWeightID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 JPRewardIndex（字段）
		/// </summary>
		/// /// <param name = "jPWeightID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetJPRewardIndexByPK(int jPWeightID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@JPWeightID", jPWeightID, MySqlDbType.Int32),
			};
			return (int)GetScalar("`JPRewardIndex`", "`JPWeightID` = @JPWeightID", paras_, tm_);
		}
		public async Task<int> GetJPRewardIndexByPKAsync(int jPWeightID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@JPWeightID", jPWeightID, MySqlDbType.Int32),
			};
			return (int)await GetScalarAsync("`JPRewardIndex`", "`JPWeightID` = @JPWeightID", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByChipsId
		
		/// <summary>
		/// 按 ChipsId（字段） 查询
		/// </summary>
		/// /// <param name = "chipsId">下注id</param>
		/// <return>实体对象集合</return>
		public List<Dwp_config_jackpot_weightEO> GetByChipsId(int chipsId)
		{
			return GetByChipsId(chipsId, 0, string.Empty, null);
		}
		public async Task<List<Dwp_config_jackpot_weightEO>> GetByChipsIdAsync(int chipsId)
		{
			return await GetByChipsIdAsync(chipsId, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ChipsId（字段） 查询
		/// </summary>
		/// /// <param name = "chipsId">下注id</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Dwp_config_jackpot_weightEO> GetByChipsId(int chipsId, TransactionManager tm_)
		{
			return GetByChipsId(chipsId, 0, string.Empty, tm_);
		}
		public async Task<List<Dwp_config_jackpot_weightEO>> GetByChipsIdAsync(int chipsId, TransactionManager tm_)
		{
			return await GetByChipsIdAsync(chipsId, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ChipsId（字段） 查询
		/// </summary>
		/// /// <param name = "chipsId">下注id</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Dwp_config_jackpot_weightEO> GetByChipsId(int chipsId, int top_)
		{
			return GetByChipsId(chipsId, top_, string.Empty, null);
		}
		public async Task<List<Dwp_config_jackpot_weightEO>> GetByChipsIdAsync(int chipsId, int top_)
		{
			return await GetByChipsIdAsync(chipsId, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ChipsId（字段） 查询
		/// </summary>
		/// /// <param name = "chipsId">下注id</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Dwp_config_jackpot_weightEO> GetByChipsId(int chipsId, int top_, TransactionManager tm_)
		{
			return GetByChipsId(chipsId, top_, string.Empty, tm_);
		}
		public async Task<List<Dwp_config_jackpot_weightEO>> GetByChipsIdAsync(int chipsId, int top_, TransactionManager tm_)
		{
			return await GetByChipsIdAsync(chipsId, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ChipsId（字段） 查询
		/// </summary>
		/// /// <param name = "chipsId">下注id</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Dwp_config_jackpot_weightEO> GetByChipsId(int chipsId, string sort_)
		{
			return GetByChipsId(chipsId, 0, sort_, null);
		}
		public async Task<List<Dwp_config_jackpot_weightEO>> GetByChipsIdAsync(int chipsId, string sort_)
		{
			return await GetByChipsIdAsync(chipsId, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 ChipsId（字段） 查询
		/// </summary>
		/// /// <param name = "chipsId">下注id</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Dwp_config_jackpot_weightEO> GetByChipsId(int chipsId, string sort_, TransactionManager tm_)
		{
			return GetByChipsId(chipsId, 0, sort_, tm_);
		}
		public async Task<List<Dwp_config_jackpot_weightEO>> GetByChipsIdAsync(int chipsId, string sort_, TransactionManager tm_)
		{
			return await GetByChipsIdAsync(chipsId, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 ChipsId（字段） 查询
		/// </summary>
		/// /// <param name = "chipsId">下注id</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Dwp_config_jackpot_weightEO> GetByChipsId(int chipsId, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ChipsId` = @ChipsId", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ChipsId", chipsId, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Dwp_config_jackpot_weightEO.MapDataReader);
		}
		public async Task<List<Dwp_config_jackpot_weightEO>> GetByChipsIdAsync(int chipsId, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ChipsId` = @ChipsId", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ChipsId", chipsId, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Dwp_config_jackpot_weightEO.MapDataReader);
		}
		#endregion // GetByChipsId
		#region GetByJPTotalValMin
		
		/// <summary>
		/// 按 JPTotalValMin（字段） 查询
		/// </summary>
		/// /// <param name = "jPTotalValMin">累计值最小区间(包含下限)</param>
		/// <return>实体对象集合</return>
		public List<Dwp_config_jackpot_weightEO> GetByJPTotalValMin(int jPTotalValMin)
		{
			return GetByJPTotalValMin(jPTotalValMin, 0, string.Empty, null);
		}
		public async Task<List<Dwp_config_jackpot_weightEO>> GetByJPTotalValMinAsync(int jPTotalValMin)
		{
			return await GetByJPTotalValMinAsync(jPTotalValMin, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 JPTotalValMin（字段） 查询
		/// </summary>
		/// /// <param name = "jPTotalValMin">累计值最小区间(包含下限)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Dwp_config_jackpot_weightEO> GetByJPTotalValMin(int jPTotalValMin, TransactionManager tm_)
		{
			return GetByJPTotalValMin(jPTotalValMin, 0, string.Empty, tm_);
		}
		public async Task<List<Dwp_config_jackpot_weightEO>> GetByJPTotalValMinAsync(int jPTotalValMin, TransactionManager tm_)
		{
			return await GetByJPTotalValMinAsync(jPTotalValMin, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 JPTotalValMin（字段） 查询
		/// </summary>
		/// /// <param name = "jPTotalValMin">累计值最小区间(包含下限)</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Dwp_config_jackpot_weightEO> GetByJPTotalValMin(int jPTotalValMin, int top_)
		{
			return GetByJPTotalValMin(jPTotalValMin, top_, string.Empty, null);
		}
		public async Task<List<Dwp_config_jackpot_weightEO>> GetByJPTotalValMinAsync(int jPTotalValMin, int top_)
		{
			return await GetByJPTotalValMinAsync(jPTotalValMin, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 JPTotalValMin（字段） 查询
		/// </summary>
		/// /// <param name = "jPTotalValMin">累计值最小区间(包含下限)</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Dwp_config_jackpot_weightEO> GetByJPTotalValMin(int jPTotalValMin, int top_, TransactionManager tm_)
		{
			return GetByJPTotalValMin(jPTotalValMin, top_, string.Empty, tm_);
		}
		public async Task<List<Dwp_config_jackpot_weightEO>> GetByJPTotalValMinAsync(int jPTotalValMin, int top_, TransactionManager tm_)
		{
			return await GetByJPTotalValMinAsync(jPTotalValMin, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 JPTotalValMin（字段） 查询
		/// </summary>
		/// /// <param name = "jPTotalValMin">累计值最小区间(包含下限)</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Dwp_config_jackpot_weightEO> GetByJPTotalValMin(int jPTotalValMin, string sort_)
		{
			return GetByJPTotalValMin(jPTotalValMin, 0, sort_, null);
		}
		public async Task<List<Dwp_config_jackpot_weightEO>> GetByJPTotalValMinAsync(int jPTotalValMin, string sort_)
		{
			return await GetByJPTotalValMinAsync(jPTotalValMin, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 JPTotalValMin（字段） 查询
		/// </summary>
		/// /// <param name = "jPTotalValMin">累计值最小区间(包含下限)</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Dwp_config_jackpot_weightEO> GetByJPTotalValMin(int jPTotalValMin, string sort_, TransactionManager tm_)
		{
			return GetByJPTotalValMin(jPTotalValMin, 0, sort_, tm_);
		}
		public async Task<List<Dwp_config_jackpot_weightEO>> GetByJPTotalValMinAsync(int jPTotalValMin, string sort_, TransactionManager tm_)
		{
			return await GetByJPTotalValMinAsync(jPTotalValMin, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 JPTotalValMin（字段） 查询
		/// </summary>
		/// /// <param name = "jPTotalValMin">累计值最小区间(包含下限)</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Dwp_config_jackpot_weightEO> GetByJPTotalValMin(int jPTotalValMin, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`JPTotalValMin` = @JPTotalValMin", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@JPTotalValMin", jPTotalValMin, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Dwp_config_jackpot_weightEO.MapDataReader);
		}
		public async Task<List<Dwp_config_jackpot_weightEO>> GetByJPTotalValMinAsync(int jPTotalValMin, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`JPTotalValMin` = @JPTotalValMin", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@JPTotalValMin", jPTotalValMin, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Dwp_config_jackpot_weightEO.MapDataReader);
		}
		#endregion // GetByJPTotalValMin
		#region GetByJPTotalValMax
		
		/// <summary>
		/// 按 JPTotalValMax（字段） 查询
		/// </summary>
		/// /// <param name = "jPTotalValMax">累计值最大区间(不包含上限)</param>
		/// <return>实体对象集合</return>
		public List<Dwp_config_jackpot_weightEO> GetByJPTotalValMax(int jPTotalValMax)
		{
			return GetByJPTotalValMax(jPTotalValMax, 0, string.Empty, null);
		}
		public async Task<List<Dwp_config_jackpot_weightEO>> GetByJPTotalValMaxAsync(int jPTotalValMax)
		{
			return await GetByJPTotalValMaxAsync(jPTotalValMax, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 JPTotalValMax（字段） 查询
		/// </summary>
		/// /// <param name = "jPTotalValMax">累计值最大区间(不包含上限)</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Dwp_config_jackpot_weightEO> GetByJPTotalValMax(int jPTotalValMax, TransactionManager tm_)
		{
			return GetByJPTotalValMax(jPTotalValMax, 0, string.Empty, tm_);
		}
		public async Task<List<Dwp_config_jackpot_weightEO>> GetByJPTotalValMaxAsync(int jPTotalValMax, TransactionManager tm_)
		{
			return await GetByJPTotalValMaxAsync(jPTotalValMax, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 JPTotalValMax（字段） 查询
		/// </summary>
		/// /// <param name = "jPTotalValMax">累计值最大区间(不包含上限)</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Dwp_config_jackpot_weightEO> GetByJPTotalValMax(int jPTotalValMax, int top_)
		{
			return GetByJPTotalValMax(jPTotalValMax, top_, string.Empty, null);
		}
		public async Task<List<Dwp_config_jackpot_weightEO>> GetByJPTotalValMaxAsync(int jPTotalValMax, int top_)
		{
			return await GetByJPTotalValMaxAsync(jPTotalValMax, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 JPTotalValMax（字段） 查询
		/// </summary>
		/// /// <param name = "jPTotalValMax">累计值最大区间(不包含上限)</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Dwp_config_jackpot_weightEO> GetByJPTotalValMax(int jPTotalValMax, int top_, TransactionManager tm_)
		{
			return GetByJPTotalValMax(jPTotalValMax, top_, string.Empty, tm_);
		}
		public async Task<List<Dwp_config_jackpot_weightEO>> GetByJPTotalValMaxAsync(int jPTotalValMax, int top_, TransactionManager tm_)
		{
			return await GetByJPTotalValMaxAsync(jPTotalValMax, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 JPTotalValMax（字段） 查询
		/// </summary>
		/// /// <param name = "jPTotalValMax">累计值最大区间(不包含上限)</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Dwp_config_jackpot_weightEO> GetByJPTotalValMax(int jPTotalValMax, string sort_)
		{
			return GetByJPTotalValMax(jPTotalValMax, 0, sort_, null);
		}
		public async Task<List<Dwp_config_jackpot_weightEO>> GetByJPTotalValMaxAsync(int jPTotalValMax, string sort_)
		{
			return await GetByJPTotalValMaxAsync(jPTotalValMax, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 JPTotalValMax（字段） 查询
		/// </summary>
		/// /// <param name = "jPTotalValMax">累计值最大区间(不包含上限)</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Dwp_config_jackpot_weightEO> GetByJPTotalValMax(int jPTotalValMax, string sort_, TransactionManager tm_)
		{
			return GetByJPTotalValMax(jPTotalValMax, 0, sort_, tm_);
		}
		public async Task<List<Dwp_config_jackpot_weightEO>> GetByJPTotalValMaxAsync(int jPTotalValMax, string sort_, TransactionManager tm_)
		{
			return await GetByJPTotalValMaxAsync(jPTotalValMax, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 JPTotalValMax（字段） 查询
		/// </summary>
		/// /// <param name = "jPTotalValMax">累计值最大区间(不包含上限)</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Dwp_config_jackpot_weightEO> GetByJPTotalValMax(int jPTotalValMax, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`JPTotalValMax` = @JPTotalValMax", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@JPTotalValMax", jPTotalValMax, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Dwp_config_jackpot_weightEO.MapDataReader);
		}
		public async Task<List<Dwp_config_jackpot_weightEO>> GetByJPTotalValMaxAsync(int jPTotalValMax, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`JPTotalValMax` = @JPTotalValMax", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@JPTotalValMax", jPTotalValMax, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Dwp_config_jackpot_weightEO.MapDataReader);
		}
		#endregion // GetByJPTotalValMax
		#region GetByWeight
		
		/// <summary>
		/// 按 Weight（字段） 查询
		/// </summary>
		/// /// <param name = "weight">权重</param>
		/// <return>实体对象集合</return>
		public List<Dwp_config_jackpot_weightEO> GetByWeight(int weight)
		{
			return GetByWeight(weight, 0, string.Empty, null);
		}
		public async Task<List<Dwp_config_jackpot_weightEO>> GetByWeightAsync(int weight)
		{
			return await GetByWeightAsync(weight, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Weight（字段） 查询
		/// </summary>
		/// /// <param name = "weight">权重</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Dwp_config_jackpot_weightEO> GetByWeight(int weight, TransactionManager tm_)
		{
			return GetByWeight(weight, 0, string.Empty, tm_);
		}
		public async Task<List<Dwp_config_jackpot_weightEO>> GetByWeightAsync(int weight, TransactionManager tm_)
		{
			return await GetByWeightAsync(weight, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Weight（字段） 查询
		/// </summary>
		/// /// <param name = "weight">权重</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Dwp_config_jackpot_weightEO> GetByWeight(int weight, int top_)
		{
			return GetByWeight(weight, top_, string.Empty, null);
		}
		public async Task<List<Dwp_config_jackpot_weightEO>> GetByWeightAsync(int weight, int top_)
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
		public List<Dwp_config_jackpot_weightEO> GetByWeight(int weight, int top_, TransactionManager tm_)
		{
			return GetByWeight(weight, top_, string.Empty, tm_);
		}
		public async Task<List<Dwp_config_jackpot_weightEO>> GetByWeightAsync(int weight, int top_, TransactionManager tm_)
		{
			return await GetByWeightAsync(weight, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Weight（字段） 查询
		/// </summary>
		/// /// <param name = "weight">权重</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Dwp_config_jackpot_weightEO> GetByWeight(int weight, string sort_)
		{
			return GetByWeight(weight, 0, sort_, null);
		}
		public async Task<List<Dwp_config_jackpot_weightEO>> GetByWeightAsync(int weight, string sort_)
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
		public List<Dwp_config_jackpot_weightEO> GetByWeight(int weight, string sort_, TransactionManager tm_)
		{
			return GetByWeight(weight, 0, sort_, tm_);
		}
		public async Task<List<Dwp_config_jackpot_weightEO>> GetByWeightAsync(int weight, string sort_, TransactionManager tm_)
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
		public List<Dwp_config_jackpot_weightEO> GetByWeight(int weight, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Weight` = @Weight", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Weight", weight, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Dwp_config_jackpot_weightEO.MapDataReader);
		}
		public async Task<List<Dwp_config_jackpot_weightEO>> GetByWeightAsync(int weight, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Weight` = @Weight", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Weight", weight, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Dwp_config_jackpot_weightEO.MapDataReader);
		}
		#endregion // GetByWeight
		#region GetByJPRewardIndex
		
		/// <summary>
		/// 按 JPRewardIndex（字段） 查询
		/// </summary>
		/// /// <param name = "jPRewardIndex">JP索引 （0-JPMini，1-JPMajor，2-JPMega）</param>
		/// <return>实体对象集合</return>
		public List<Dwp_config_jackpot_weightEO> GetByJPRewardIndex(int jPRewardIndex)
		{
			return GetByJPRewardIndex(jPRewardIndex, 0, string.Empty, null);
		}
		public async Task<List<Dwp_config_jackpot_weightEO>> GetByJPRewardIndexAsync(int jPRewardIndex)
		{
			return await GetByJPRewardIndexAsync(jPRewardIndex, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 JPRewardIndex（字段） 查询
		/// </summary>
		/// /// <param name = "jPRewardIndex">JP索引 （0-JPMini，1-JPMajor，2-JPMega）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Dwp_config_jackpot_weightEO> GetByJPRewardIndex(int jPRewardIndex, TransactionManager tm_)
		{
			return GetByJPRewardIndex(jPRewardIndex, 0, string.Empty, tm_);
		}
		public async Task<List<Dwp_config_jackpot_weightEO>> GetByJPRewardIndexAsync(int jPRewardIndex, TransactionManager tm_)
		{
			return await GetByJPRewardIndexAsync(jPRewardIndex, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 JPRewardIndex（字段） 查询
		/// </summary>
		/// /// <param name = "jPRewardIndex">JP索引 （0-JPMini，1-JPMajor，2-JPMega）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Dwp_config_jackpot_weightEO> GetByJPRewardIndex(int jPRewardIndex, int top_)
		{
			return GetByJPRewardIndex(jPRewardIndex, top_, string.Empty, null);
		}
		public async Task<List<Dwp_config_jackpot_weightEO>> GetByJPRewardIndexAsync(int jPRewardIndex, int top_)
		{
			return await GetByJPRewardIndexAsync(jPRewardIndex, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 JPRewardIndex（字段） 查询
		/// </summary>
		/// /// <param name = "jPRewardIndex">JP索引 （0-JPMini，1-JPMajor，2-JPMega）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Dwp_config_jackpot_weightEO> GetByJPRewardIndex(int jPRewardIndex, int top_, TransactionManager tm_)
		{
			return GetByJPRewardIndex(jPRewardIndex, top_, string.Empty, tm_);
		}
		public async Task<List<Dwp_config_jackpot_weightEO>> GetByJPRewardIndexAsync(int jPRewardIndex, int top_, TransactionManager tm_)
		{
			return await GetByJPRewardIndexAsync(jPRewardIndex, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 JPRewardIndex（字段） 查询
		/// </summary>
		/// /// <param name = "jPRewardIndex">JP索引 （0-JPMini，1-JPMajor，2-JPMega）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Dwp_config_jackpot_weightEO> GetByJPRewardIndex(int jPRewardIndex, string sort_)
		{
			return GetByJPRewardIndex(jPRewardIndex, 0, sort_, null);
		}
		public async Task<List<Dwp_config_jackpot_weightEO>> GetByJPRewardIndexAsync(int jPRewardIndex, string sort_)
		{
			return await GetByJPRewardIndexAsync(jPRewardIndex, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 JPRewardIndex（字段） 查询
		/// </summary>
		/// /// <param name = "jPRewardIndex">JP索引 （0-JPMini，1-JPMajor，2-JPMega）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Dwp_config_jackpot_weightEO> GetByJPRewardIndex(int jPRewardIndex, string sort_, TransactionManager tm_)
		{
			return GetByJPRewardIndex(jPRewardIndex, 0, sort_, tm_);
		}
		public async Task<List<Dwp_config_jackpot_weightEO>> GetByJPRewardIndexAsync(int jPRewardIndex, string sort_, TransactionManager tm_)
		{
			return await GetByJPRewardIndexAsync(jPRewardIndex, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 JPRewardIndex（字段） 查询
		/// </summary>
		/// /// <param name = "jPRewardIndex">JP索引 （0-JPMini，1-JPMajor，2-JPMega）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Dwp_config_jackpot_weightEO> GetByJPRewardIndex(int jPRewardIndex, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`JPRewardIndex` = @JPRewardIndex", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@JPRewardIndex", jPRewardIndex, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Dwp_config_jackpot_weightEO.MapDataReader);
		}
		public async Task<List<Dwp_config_jackpot_weightEO>> GetByJPRewardIndexAsync(int jPRewardIndex, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`JPRewardIndex` = @JPRewardIndex", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@JPRewardIndex", jPRewardIndex, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Dwp_config_jackpot_weightEO.MapDataReader);
		}
		#endregion // GetByJPRewardIndex
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
