/******************************************************
 * 此代码由代码生成器工具自动生成，请不要修改
 * TinyFx代码生成器核心库版本号：1.0.0.0
 * git: https://github.com/jh98net/TinyFx
 * 文档生成时间：2023-12-09 15: 09:27
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

namespace Dragon_tower.DAL
{
	#region EO
	/// <summary>
	/// 初始基础配置
	/// 【表 gdt_config 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class Gdt_configEO : IRowMapper<Gdt_configEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public Gdt_configEO()
		{
			this.IncomeRatio = 0d;
			this.LevelId = 0;
			this.MaxBet = 0;
		}
		#region 主键原始值 & 主键集合
	    
		/// <summary>
		/// 当前对象是否保存原始主键值，当修改了主键值时为 true
		/// </summary>
		public bool HasOriginal { get; protected set; }
		
		private string _originalOperatorID;
		/// <summary>
		/// 【数据库中的原始主键 OperatorID 值的副本，用于主键值更新】
		/// </summary>
		public string OriginalOperatorID
		{
			get { return _originalOperatorID; }
			set { HasOriginal = true; _originalOperatorID = value; }
		}
		
		private string _originalCurrencyID;
		/// <summary>
		/// 【数据库中的原始主键 CurrencyID 值的副本，用于主键值更新】
		/// </summary>
		public string OriginalCurrencyID
		{
			get { return _originalCurrencyID; }
			set { HasOriginal = true; _originalCurrencyID = value; }
		}
	    /// <summary>
	    /// 获取主键集合。key: 数据库字段名称, value: 主键值
	    /// </summary>
	    /// <returns></returns>
	    public Dictionary<string, object> GetPrimaryKeys()
	    {
	        return new Dictionary<string, object>() { { "OperatorID", OperatorID },  { "CurrencyID", CurrencyID }, };
	    }
	    /// <summary>
	    /// 获取主键集合JSON格式
	    /// </summary>
	    /// <returns></returns>
	    public string GetPrimaryKeysJson() => SerializerUtil.SerializeJson(GetPrimaryKeys());
		#endregion // 主键原始值
		#region 所有字段
		/// <summary>
		/// 运营商编码
		/// 【主键 varchar(50)】
		/// </summary>
		[DataMember(Order = 1)]
		public string OperatorID { get; set; }
		/// <summary>
		/// 货币编码（ISO 4217大写）
		/// 【主键 varchar(5)】
		/// </summary>
		[DataMember(Order = 2)]
		public string CurrencyID { get; set; }
		/// <summary>
		/// 税收分配
		/// 【字段 double】
		/// </summary>
		[DataMember(Order = 3)]
		public double IncomeRatio { get; set; }
		/// <summary>
		/// 初始难度ID
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 4)]
		public int LevelId { get; set; }
		/// <summary>
		/// 最小下注额
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 5)]
		public long MinBet { get; set; }
		/// <summary>
		/// 最大下注额
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 6)]
		public long MaxBet { get; set; }
		/// <summary>
		/// 返奖系数
		/// 【字段 double】
		/// </summary>
		[DataMember(Order = 7)]
		public double ReturnRatio { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public Gdt_configEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static Gdt_configEO MapDataReader(IDataReader reader)
		{
		    Gdt_configEO ret = new Gdt_configEO();
			ret.OperatorID = reader.ToString("OperatorID");
			ret.OriginalOperatorID = ret.OperatorID;
			ret.CurrencyID = reader.ToString("CurrencyID");
			ret.OriginalCurrencyID = ret.CurrencyID;
			ret.IncomeRatio = reader.ToDouble("IncomeRatio");
			ret.LevelId = reader.ToInt32("LevelId");
			ret.MinBet = reader.ToInt64("MinBet");
			ret.MaxBet = reader.ToInt64("MaxBet");
			ret.ReturnRatio = reader.ToDouble("ReturnRatio");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 初始基础配置
	/// 【表 gdt_config 的操作类】
	/// </summary>
	[Obsolete]
	public class Gdt_configMO : MySqlTableMO<Gdt_configEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`gdt_config`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public Gdt_configMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public Gdt_configMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public Gdt_configMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(Gdt_configEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(Gdt_configEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(Gdt_configEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`OperatorID`, `CurrencyID`, `IncomeRatio`, `LevelId`, `MinBet`, `MaxBet`, `ReturnRatio`) VALUE (@OperatorID, @CurrencyID, @IncomeRatio, @LevelId, @MinBet, @MaxBet, @ReturnRatio);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", item.OperatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", item.CurrencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@IncomeRatio", item.IncomeRatio, MySqlDbType.Double),
				Database.CreateInParameter("@LevelId", item.LevelId, MySqlDbType.Int32),
				Database.CreateInParameter("@MinBet", item.MinBet, MySqlDbType.Int64),
				Database.CreateInParameter("@MaxBet", item.MaxBet, MySqlDbType.Int64),
				Database.CreateInParameter("@ReturnRatio", item.ReturnRatio, MySqlDbType.Double),
			};
		}
		public int AddByBatch(IEnumerable<Gdt_configEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<Gdt_configEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<Gdt_configEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`OperatorID`, `CurrencyID`, `IncomeRatio`, `LevelId`, `MinBet`, `MaxBet`, `ReturnRatio`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"('{item.OperatorID}','{item.CurrencyID}',{item.IncomeRatio},{item.LevelId},{item.MinBet},{item.MaxBet},{item.ReturnRatio}),");
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
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(operatorID, currencyID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(operatorID, currencyID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(string operatorID, string currencyID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(Gdt_configEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.OperatorID, item.CurrencyID, tm_);
		}
		public async Task<int> RemoveAsync(Gdt_configEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.OperatorID, item.CurrencyID, tm_);
		}
		#endregion // RemoveByPK
		
		#region RemoveByXXX
		#region RemoveByOperatorID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByOperatorID(string operatorID, TransactionManager tm_ = null)
		{
			RepairRemoveByOperatorIDData(operatorID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByOperatorIDAsync(string operatorID, TransactionManager tm_ = null)
		{
			RepairRemoveByOperatorIDData(operatorID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByOperatorIDData(string operatorID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `OperatorID` = @OperatorID";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
		}
		#endregion // RemoveByOperatorID
		#region RemoveByCurrencyID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByCurrencyID(string currencyID, TransactionManager tm_ = null)
		{
			RepairRemoveByCurrencyIDData(currencyID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByCurrencyIDAsync(string currencyID, TransactionManager tm_ = null)
		{
			RepairRemoveByCurrencyIDData(currencyID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByCurrencyIDData(string currencyID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `CurrencyID` = @CurrencyID";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
		}
		#endregion // RemoveByCurrencyID
		#region RemoveByIncomeRatio
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "incomeRatio">税收分配</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByIncomeRatio(double incomeRatio, TransactionManager tm_ = null)
		{
			RepairRemoveByIncomeRatioData(incomeRatio, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByIncomeRatioAsync(double incomeRatio, TransactionManager tm_ = null)
		{
			RepairRemoveByIncomeRatioData(incomeRatio, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByIncomeRatioData(double incomeRatio, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `IncomeRatio` = @IncomeRatio";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IncomeRatio", incomeRatio, MySqlDbType.Double));
		}
		#endregion // RemoveByIncomeRatio
		#region RemoveByLevelId
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "levelId">初始难度ID</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByLevelId(int levelId, TransactionManager tm_ = null)
		{
			RepairRemoveByLevelIdData(levelId, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByLevelIdAsync(int levelId, TransactionManager tm_ = null)
		{
			RepairRemoveByLevelIdData(levelId, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByLevelIdData(int levelId, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `LevelId` = @LevelId";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@LevelId", levelId, MySqlDbType.Int32));
		}
		#endregion // RemoveByLevelId
		#region RemoveByMinBet
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "minBet">最小下注额</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByMinBet(long minBet, TransactionManager tm_ = null)
		{
			RepairRemoveByMinBetData(minBet, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByMinBetAsync(long minBet, TransactionManager tm_ = null)
		{
			RepairRemoveByMinBetData(minBet, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByMinBetData(long minBet, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `MinBet` = @MinBet";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@MinBet", minBet, MySqlDbType.Int64));
		}
		#endregion // RemoveByMinBet
		#region RemoveByMaxBet
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "maxBet">最大下注额</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByMaxBet(long maxBet, TransactionManager tm_ = null)
		{
			RepairRemoveByMaxBetData(maxBet, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByMaxBetAsync(long maxBet, TransactionManager tm_ = null)
		{
			RepairRemoveByMaxBetData(maxBet, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByMaxBetData(long maxBet, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `MaxBet` = @MaxBet";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@MaxBet", maxBet, MySqlDbType.Int64));
		}
		#endregion // RemoveByMaxBet
		#region RemoveByReturnRatio
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "returnRatio">返奖系数</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByReturnRatio(double returnRatio, TransactionManager tm_ = null)
		{
			RepairRemoveByReturnRatioData(returnRatio, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByReturnRatioAsync(double returnRatio, TransactionManager tm_ = null)
		{
			RepairRemoveByReturnRatioData(returnRatio, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByReturnRatioData(double returnRatio, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `ReturnRatio` = @ReturnRatio";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ReturnRatio", returnRatio, MySqlDbType.Double));
		}
		#endregion // RemoveByReturnRatio
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
		public int Put(Gdt_configEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(Gdt_configEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(Gdt_configEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `OperatorID` = @OperatorID, `CurrencyID` = @CurrencyID, `IncomeRatio` = @IncomeRatio, `LevelId` = @LevelId, `MinBet` = @MinBet, `MaxBet` = @MaxBet, `ReturnRatio` = @ReturnRatio WHERE `OperatorID` = @OperatorID_Original AND `CurrencyID` = @CurrencyID_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", item.OperatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", item.CurrencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@IncomeRatio", item.IncomeRatio, MySqlDbType.Double),
				Database.CreateInParameter("@LevelId", item.LevelId, MySqlDbType.Int32),
				Database.CreateInParameter("@MinBet", item.MinBet, MySqlDbType.Int64),
				Database.CreateInParameter("@MaxBet", item.MaxBet, MySqlDbType.Int64),
				Database.CreateInParameter("@ReturnRatio", item.ReturnRatio, MySqlDbType.Double),
				Database.CreateInParameter("@OperatorID_Original", item.HasOriginal ? item.OriginalOperatorID : item.OperatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID_Original", item.HasOriginal ? item.OriginalCurrencyID : item.CurrencyID, MySqlDbType.VarChar),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<Gdt_configEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<Gdt_configEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string operatorID, string currencyID, string set_, params object[] values_)
		{
			return Put(set_, "`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", ConcatValues(values_, operatorID, currencyID));
		}
		public async Task<int> PutByPKAsync(string operatorID, string currencyID, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", ConcatValues(values_, operatorID, currencyID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string operatorID, string currencyID, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", tm_, ConcatValues(values_, operatorID, currencyID));
		}
		public async Task<int> PutByPKAsync(string operatorID, string currencyID, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", tm_, ConcatValues(values_, operatorID, currencyID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string operatorID, string currencyID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
	        };
			return Put(set_, "`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(string operatorID, string currencyID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
	        };
			return await PutAsync(set_, "`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", ConcatParameters(paras_, newParas_), tm_);
		}
		#endregion // PutByPK
		
		#region PutXXX
		#region PutOperatorID
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOperatorID(string operatorID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `OperatorID` = @OperatorID";
			var parameter_ = Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutOperatorIDAsync(string operatorID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `OperatorID` = @OperatorID";
			var parameter_ = Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutOperatorID
		#region PutCurrencyID
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCurrencyID(string currencyID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CurrencyID` = @CurrencyID";
			var parameter_ = Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutCurrencyIDAsync(string currencyID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CurrencyID` = @CurrencyID";
			var parameter_ = Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutCurrencyID
		#region PutIncomeRatio
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// /// <param name = "incomeRatio">税收分配</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutIncomeRatioByPK(string operatorID, string currencyID, double incomeRatio, TransactionManager tm_ = null)
		{
			RepairPutIncomeRatioByPKData(operatorID, currencyID, incomeRatio, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutIncomeRatioByPKAsync(string operatorID, string currencyID, double incomeRatio, TransactionManager tm_ = null)
		{
			RepairPutIncomeRatioByPKData(operatorID, currencyID, incomeRatio, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutIncomeRatioByPKData(string operatorID, string currencyID, double incomeRatio, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `IncomeRatio` = @IncomeRatio  WHERE `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@IncomeRatio", incomeRatio, MySqlDbType.Double),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "incomeRatio">税收分配</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutIncomeRatio(double incomeRatio, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `IncomeRatio` = @IncomeRatio";
			var parameter_ = Database.CreateInParameter("@IncomeRatio", incomeRatio, MySqlDbType.Double);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutIncomeRatioAsync(double incomeRatio, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `IncomeRatio` = @IncomeRatio";
			var parameter_ = Database.CreateInParameter("@IncomeRatio", incomeRatio, MySqlDbType.Double);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutIncomeRatio
		#region PutLevelId
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// /// <param name = "levelId">初始难度ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutLevelIdByPK(string operatorID, string currencyID, int levelId, TransactionManager tm_ = null)
		{
			RepairPutLevelIdByPKData(operatorID, currencyID, levelId, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutLevelIdByPKAsync(string operatorID, string currencyID, int levelId, TransactionManager tm_ = null)
		{
			RepairPutLevelIdByPKData(operatorID, currencyID, levelId, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutLevelIdByPKData(string operatorID, string currencyID, int levelId, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `LevelId` = @LevelId  WHERE `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LevelId", levelId, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "levelId">初始难度ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutLevelId(int levelId, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `LevelId` = @LevelId";
			var parameter_ = Database.CreateInParameter("@LevelId", levelId, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutLevelIdAsync(int levelId, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `LevelId` = @LevelId";
			var parameter_ = Database.CreateInParameter("@LevelId", levelId, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutLevelId
		#region PutMinBet
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// /// <param name = "minBet">最小下注额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutMinBetByPK(string operatorID, string currencyID, long minBet, TransactionManager tm_ = null)
		{
			RepairPutMinBetByPKData(operatorID, currencyID, minBet, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutMinBetByPKAsync(string operatorID, string currencyID, long minBet, TransactionManager tm_ = null)
		{
			RepairPutMinBetByPKData(operatorID, currencyID, minBet, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutMinBetByPKData(string operatorID, string currencyID, long minBet, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `MinBet` = @MinBet  WHERE `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MinBet", minBet, MySqlDbType.Int64),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "minBet">最小下注额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutMinBet(long minBet, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `MinBet` = @MinBet";
			var parameter_ = Database.CreateInParameter("@MinBet", minBet, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutMinBetAsync(long minBet, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `MinBet` = @MinBet";
			var parameter_ = Database.CreateInParameter("@MinBet", minBet, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutMinBet
		#region PutMaxBet
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// /// <param name = "maxBet">最大下注额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutMaxBetByPK(string operatorID, string currencyID, long maxBet, TransactionManager tm_ = null)
		{
			RepairPutMaxBetByPKData(operatorID, currencyID, maxBet, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutMaxBetByPKAsync(string operatorID, string currencyID, long maxBet, TransactionManager tm_ = null)
		{
			RepairPutMaxBetByPKData(operatorID, currencyID, maxBet, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutMaxBetByPKData(string operatorID, string currencyID, long maxBet, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `MaxBet` = @MaxBet  WHERE `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MaxBet", maxBet, MySqlDbType.Int64),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "maxBet">最大下注额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutMaxBet(long maxBet, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `MaxBet` = @MaxBet";
			var parameter_ = Database.CreateInParameter("@MaxBet", maxBet, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutMaxBetAsync(long maxBet, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `MaxBet` = @MaxBet";
			var parameter_ = Database.CreateInParameter("@MaxBet", maxBet, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutMaxBet
		#region PutReturnRatio
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// /// <param name = "returnRatio">返奖系数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutReturnRatioByPK(string operatorID, string currencyID, double returnRatio, TransactionManager tm_ = null)
		{
			RepairPutReturnRatioByPKData(operatorID, currencyID, returnRatio, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutReturnRatioByPKAsync(string operatorID, string currencyID, double returnRatio, TransactionManager tm_ = null)
		{
			RepairPutReturnRatioByPKData(operatorID, currencyID, returnRatio, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutReturnRatioByPKData(string operatorID, string currencyID, double returnRatio, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `ReturnRatio` = @ReturnRatio  WHERE `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ReturnRatio", returnRatio, MySqlDbType.Double),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "returnRatio">返奖系数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutReturnRatio(double returnRatio, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ReturnRatio` = @ReturnRatio";
			var parameter_ = Database.CreateInParameter("@ReturnRatio", returnRatio, MySqlDbType.Double);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutReturnRatioAsync(double returnRatio, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ReturnRatio` = @ReturnRatio";
			var parameter_ = Database.CreateInParameter("@ReturnRatio", returnRatio, MySqlDbType.Double);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutReturnRatio
		#endregion // PutXXX
		#endregion // Put
	   
		#region Set
		
		/// <summary>
		/// 插入或者更新数据
		/// </summary>
		/// <param name = "item">要更新的实体对象</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>true:插入操作；false:更新操作</return>
		public bool Set(Gdt_configEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.OperatorID, item.CurrencyID) == null)
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
		public async Task<bool> SetAsync(Gdt_configEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.OperatorID, item.CurrencyID) == null)
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
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public Gdt_configEO GetByPK(string operatorID, string currencyID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(operatorID, currencyID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, Gdt_configEO.MapDataReader);
		}
		public async Task<Gdt_configEO> GetByPKAsync(string operatorID, string currencyID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(operatorID, currencyID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Gdt_configEO.MapDataReader);
		}
		private void RepairGetByPKData(string operatorID, string currencyID, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
		}
		#endregion // GetByPK
		
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 OperatorID（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetOperatorIDByPK(string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`OperatorID`", "`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		public async Task<string> GetOperatorIDByPKAsync(string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`OperatorID`", "`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 CurrencyID（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetCurrencyIDByPK(string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`CurrencyID`", "`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		public async Task<string> GetCurrencyIDByPKAsync(string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`CurrencyID`", "`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 IncomeRatio（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public double GetIncomeRatioByPK(string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (double)GetScalar("`IncomeRatio`", "`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		public async Task<double> GetIncomeRatioByPKAsync(string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (double)await GetScalarAsync("`IncomeRatio`", "`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 LevelId（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetLevelIdByPK(string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`LevelId`", "`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		public async Task<int> GetLevelIdByPKAsync(string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`LevelId`", "`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 MinBet（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetMinBetByPK(string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`MinBet`", "`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		public async Task<long> GetMinBetByPKAsync(string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`MinBet`", "`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 MaxBet（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetMaxBetByPK(string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`MaxBet`", "`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		public async Task<long> GetMaxBetByPKAsync(string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`MaxBet`", "`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 ReturnRatio（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public double GetReturnRatioByPK(string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (double)GetScalar("`ReturnRatio`", "`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		public async Task<double> GetReturnRatioByPKAsync(string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (double)await GetScalarAsync("`ReturnRatio`", "`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByOperatorID
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <return>实体对象集合</return>
		public List<Gdt_configEO> GetByOperatorID(string operatorID)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, null);
		}
		public async Task<List<Gdt_configEO>> GetByOperatorIDAsync(string operatorID)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gdt_configEO> GetByOperatorID(string operatorID, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, tm_);
		}
		public async Task<List<Gdt_configEO>> GetByOperatorIDAsync(string operatorID, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Gdt_configEO> GetByOperatorID(string operatorID, int top_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, null);
		}
		public async Task<List<Gdt_configEO>> GetByOperatorIDAsync(string operatorID, int top_)
		{
			return await GetByOperatorIDAsync(operatorID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gdt_configEO> GetByOperatorID(string operatorID, int top_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, tm_);
		}
		public async Task<List<Gdt_configEO>> GetByOperatorIDAsync(string operatorID, int top_, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Gdt_configEO> GetByOperatorID(string operatorID, string sort_)
		{
			return GetByOperatorID(operatorID, 0, sort_, null);
		}
		public async Task<List<Gdt_configEO>> GetByOperatorIDAsync(string operatorID, string sort_)
		{
			return await GetByOperatorIDAsync(operatorID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gdt_configEO> GetByOperatorID(string operatorID, string sort_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, sort_, tm_);
		}
		public async Task<List<Gdt_configEO>> GetByOperatorIDAsync(string operatorID, string sort_, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gdt_configEO> GetByOperatorID(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorID` = @OperatorID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Gdt_configEO.MapDataReader);
		}
		public async Task<List<Gdt_configEO>> GetByOperatorIDAsync(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorID` = @OperatorID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gdt_configEO.MapDataReader);
		}
		#endregion // GetByOperatorID
		#region GetByCurrencyID
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// <return>实体对象集合</return>
		public List<Gdt_configEO> GetByCurrencyID(string currencyID)
		{
			return GetByCurrencyID(currencyID, 0, string.Empty, null);
		}
		public async Task<List<Gdt_configEO>> GetByCurrencyIDAsync(string currencyID)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gdt_configEO> GetByCurrencyID(string currencyID, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, 0, string.Empty, tm_);
		}
		public async Task<List<Gdt_configEO>> GetByCurrencyIDAsync(string currencyID, TransactionManager tm_)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Gdt_configEO> GetByCurrencyID(string currencyID, int top_)
		{
			return GetByCurrencyID(currencyID, top_, string.Empty, null);
		}
		public async Task<List<Gdt_configEO>> GetByCurrencyIDAsync(string currencyID, int top_)
		{
			return await GetByCurrencyIDAsync(currencyID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gdt_configEO> GetByCurrencyID(string currencyID, int top_, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, top_, string.Empty, tm_);
		}
		public async Task<List<Gdt_configEO>> GetByCurrencyIDAsync(string currencyID, int top_, TransactionManager tm_)
		{
			return await GetByCurrencyIDAsync(currencyID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Gdt_configEO> GetByCurrencyID(string currencyID, string sort_)
		{
			return GetByCurrencyID(currencyID, 0, sort_, null);
		}
		public async Task<List<Gdt_configEO>> GetByCurrencyIDAsync(string currencyID, string sort_)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gdt_configEO> GetByCurrencyID(string currencyID, string sort_, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, 0, sort_, tm_);
		}
		public async Task<List<Gdt_configEO>> GetByCurrencyIDAsync(string currencyID, string sort_, TransactionManager tm_)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gdt_configEO> GetByCurrencyID(string currencyID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CurrencyID` = @CurrencyID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Gdt_configEO.MapDataReader);
		}
		public async Task<List<Gdt_configEO>> GetByCurrencyIDAsync(string currencyID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CurrencyID` = @CurrencyID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gdt_configEO.MapDataReader);
		}
		#endregion // GetByCurrencyID
		#region GetByIncomeRatio
		
		/// <summary>
		/// 按 IncomeRatio（字段） 查询
		/// </summary>
		/// /// <param name = "incomeRatio">税收分配</param>
		/// <return>实体对象集合</return>
		public List<Gdt_configEO> GetByIncomeRatio(double incomeRatio)
		{
			return GetByIncomeRatio(incomeRatio, 0, string.Empty, null);
		}
		public async Task<List<Gdt_configEO>> GetByIncomeRatioAsync(double incomeRatio)
		{
			return await GetByIncomeRatioAsync(incomeRatio, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 IncomeRatio（字段） 查询
		/// </summary>
		/// /// <param name = "incomeRatio">税收分配</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gdt_configEO> GetByIncomeRatio(double incomeRatio, TransactionManager tm_)
		{
			return GetByIncomeRatio(incomeRatio, 0, string.Empty, tm_);
		}
		public async Task<List<Gdt_configEO>> GetByIncomeRatioAsync(double incomeRatio, TransactionManager tm_)
		{
			return await GetByIncomeRatioAsync(incomeRatio, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IncomeRatio（字段） 查询
		/// </summary>
		/// /// <param name = "incomeRatio">税收分配</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Gdt_configEO> GetByIncomeRatio(double incomeRatio, int top_)
		{
			return GetByIncomeRatio(incomeRatio, top_, string.Empty, null);
		}
		public async Task<List<Gdt_configEO>> GetByIncomeRatioAsync(double incomeRatio, int top_)
		{
			return await GetByIncomeRatioAsync(incomeRatio, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 IncomeRatio（字段） 查询
		/// </summary>
		/// /// <param name = "incomeRatio">税收分配</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gdt_configEO> GetByIncomeRatio(double incomeRatio, int top_, TransactionManager tm_)
		{
			return GetByIncomeRatio(incomeRatio, top_, string.Empty, tm_);
		}
		public async Task<List<Gdt_configEO>> GetByIncomeRatioAsync(double incomeRatio, int top_, TransactionManager tm_)
		{
			return await GetByIncomeRatioAsync(incomeRatio, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IncomeRatio（字段） 查询
		/// </summary>
		/// /// <param name = "incomeRatio">税收分配</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Gdt_configEO> GetByIncomeRatio(double incomeRatio, string sort_)
		{
			return GetByIncomeRatio(incomeRatio, 0, sort_, null);
		}
		public async Task<List<Gdt_configEO>> GetByIncomeRatioAsync(double incomeRatio, string sort_)
		{
			return await GetByIncomeRatioAsync(incomeRatio, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 IncomeRatio（字段） 查询
		/// </summary>
		/// /// <param name = "incomeRatio">税收分配</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gdt_configEO> GetByIncomeRatio(double incomeRatio, string sort_, TransactionManager tm_)
		{
			return GetByIncomeRatio(incomeRatio, 0, sort_, tm_);
		}
		public async Task<List<Gdt_configEO>> GetByIncomeRatioAsync(double incomeRatio, string sort_, TransactionManager tm_)
		{
			return await GetByIncomeRatioAsync(incomeRatio, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 IncomeRatio（字段） 查询
		/// </summary>
		/// /// <param name = "incomeRatio">税收分配</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gdt_configEO> GetByIncomeRatio(double incomeRatio, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`IncomeRatio` = @IncomeRatio", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IncomeRatio", incomeRatio, MySqlDbType.Double));
			return Database.ExecSqlList(sql_, paras_, tm_, Gdt_configEO.MapDataReader);
		}
		public async Task<List<Gdt_configEO>> GetByIncomeRatioAsync(double incomeRatio, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`IncomeRatio` = @IncomeRatio", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IncomeRatio", incomeRatio, MySqlDbType.Double));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gdt_configEO.MapDataReader);
		}
		#endregion // GetByIncomeRatio
		#region GetByLevelId
		
		/// <summary>
		/// 按 LevelId（字段） 查询
		/// </summary>
		/// /// <param name = "levelId">初始难度ID</param>
		/// <return>实体对象集合</return>
		public List<Gdt_configEO> GetByLevelId(int levelId)
		{
			return GetByLevelId(levelId, 0, string.Empty, null);
		}
		public async Task<List<Gdt_configEO>> GetByLevelIdAsync(int levelId)
		{
			return await GetByLevelIdAsync(levelId, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LevelId（字段） 查询
		/// </summary>
		/// /// <param name = "levelId">初始难度ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gdt_configEO> GetByLevelId(int levelId, TransactionManager tm_)
		{
			return GetByLevelId(levelId, 0, string.Empty, tm_);
		}
		public async Task<List<Gdt_configEO>> GetByLevelIdAsync(int levelId, TransactionManager tm_)
		{
			return await GetByLevelIdAsync(levelId, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LevelId（字段） 查询
		/// </summary>
		/// /// <param name = "levelId">初始难度ID</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Gdt_configEO> GetByLevelId(int levelId, int top_)
		{
			return GetByLevelId(levelId, top_, string.Empty, null);
		}
		public async Task<List<Gdt_configEO>> GetByLevelIdAsync(int levelId, int top_)
		{
			return await GetByLevelIdAsync(levelId, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LevelId（字段） 查询
		/// </summary>
		/// /// <param name = "levelId">初始难度ID</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gdt_configEO> GetByLevelId(int levelId, int top_, TransactionManager tm_)
		{
			return GetByLevelId(levelId, top_, string.Empty, tm_);
		}
		public async Task<List<Gdt_configEO>> GetByLevelIdAsync(int levelId, int top_, TransactionManager tm_)
		{
			return await GetByLevelIdAsync(levelId, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LevelId（字段） 查询
		/// </summary>
		/// /// <param name = "levelId">初始难度ID</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Gdt_configEO> GetByLevelId(int levelId, string sort_)
		{
			return GetByLevelId(levelId, 0, sort_, null);
		}
		public async Task<List<Gdt_configEO>> GetByLevelIdAsync(int levelId, string sort_)
		{
			return await GetByLevelIdAsync(levelId, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 LevelId（字段） 查询
		/// </summary>
		/// /// <param name = "levelId">初始难度ID</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gdt_configEO> GetByLevelId(int levelId, string sort_, TransactionManager tm_)
		{
			return GetByLevelId(levelId, 0, sort_, tm_);
		}
		public async Task<List<Gdt_configEO>> GetByLevelIdAsync(int levelId, string sort_, TransactionManager tm_)
		{
			return await GetByLevelIdAsync(levelId, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 LevelId（字段） 查询
		/// </summary>
		/// /// <param name = "levelId">初始难度ID</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gdt_configEO> GetByLevelId(int levelId, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`LevelId` = @LevelId", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@LevelId", levelId, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Gdt_configEO.MapDataReader);
		}
		public async Task<List<Gdt_configEO>> GetByLevelIdAsync(int levelId, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`LevelId` = @LevelId", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@LevelId", levelId, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gdt_configEO.MapDataReader);
		}
		#endregion // GetByLevelId
		#region GetByMinBet
		
		/// <summary>
		/// 按 MinBet（字段） 查询
		/// </summary>
		/// /// <param name = "minBet">最小下注额</param>
		/// <return>实体对象集合</return>
		public List<Gdt_configEO> GetByMinBet(long minBet)
		{
			return GetByMinBet(minBet, 0, string.Empty, null);
		}
		public async Task<List<Gdt_configEO>> GetByMinBetAsync(long minBet)
		{
			return await GetByMinBetAsync(minBet, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 MinBet（字段） 查询
		/// </summary>
		/// /// <param name = "minBet">最小下注额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gdt_configEO> GetByMinBet(long minBet, TransactionManager tm_)
		{
			return GetByMinBet(minBet, 0, string.Empty, tm_);
		}
		public async Task<List<Gdt_configEO>> GetByMinBetAsync(long minBet, TransactionManager tm_)
		{
			return await GetByMinBetAsync(minBet, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 MinBet（字段） 查询
		/// </summary>
		/// /// <param name = "minBet">最小下注额</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Gdt_configEO> GetByMinBet(long minBet, int top_)
		{
			return GetByMinBet(minBet, top_, string.Empty, null);
		}
		public async Task<List<Gdt_configEO>> GetByMinBetAsync(long minBet, int top_)
		{
			return await GetByMinBetAsync(minBet, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 MinBet（字段） 查询
		/// </summary>
		/// /// <param name = "minBet">最小下注额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gdt_configEO> GetByMinBet(long minBet, int top_, TransactionManager tm_)
		{
			return GetByMinBet(minBet, top_, string.Empty, tm_);
		}
		public async Task<List<Gdt_configEO>> GetByMinBetAsync(long minBet, int top_, TransactionManager tm_)
		{
			return await GetByMinBetAsync(minBet, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 MinBet（字段） 查询
		/// </summary>
		/// /// <param name = "minBet">最小下注额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Gdt_configEO> GetByMinBet(long minBet, string sort_)
		{
			return GetByMinBet(minBet, 0, sort_, null);
		}
		public async Task<List<Gdt_configEO>> GetByMinBetAsync(long minBet, string sort_)
		{
			return await GetByMinBetAsync(minBet, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 MinBet（字段） 查询
		/// </summary>
		/// /// <param name = "minBet">最小下注额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gdt_configEO> GetByMinBet(long minBet, string sort_, TransactionManager tm_)
		{
			return GetByMinBet(minBet, 0, sort_, tm_);
		}
		public async Task<List<Gdt_configEO>> GetByMinBetAsync(long minBet, string sort_, TransactionManager tm_)
		{
			return await GetByMinBetAsync(minBet, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 MinBet（字段） 查询
		/// </summary>
		/// /// <param name = "minBet">最小下注额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gdt_configEO> GetByMinBet(long minBet, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`MinBet` = @MinBet", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@MinBet", minBet, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Gdt_configEO.MapDataReader);
		}
		public async Task<List<Gdt_configEO>> GetByMinBetAsync(long minBet, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`MinBet` = @MinBet", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@MinBet", minBet, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gdt_configEO.MapDataReader);
		}
		#endregion // GetByMinBet
		#region GetByMaxBet
		
		/// <summary>
		/// 按 MaxBet（字段） 查询
		/// </summary>
		/// /// <param name = "maxBet">最大下注额</param>
		/// <return>实体对象集合</return>
		public List<Gdt_configEO> GetByMaxBet(long maxBet)
		{
			return GetByMaxBet(maxBet, 0, string.Empty, null);
		}
		public async Task<List<Gdt_configEO>> GetByMaxBetAsync(long maxBet)
		{
			return await GetByMaxBetAsync(maxBet, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 MaxBet（字段） 查询
		/// </summary>
		/// /// <param name = "maxBet">最大下注额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gdt_configEO> GetByMaxBet(long maxBet, TransactionManager tm_)
		{
			return GetByMaxBet(maxBet, 0, string.Empty, tm_);
		}
		public async Task<List<Gdt_configEO>> GetByMaxBetAsync(long maxBet, TransactionManager tm_)
		{
			return await GetByMaxBetAsync(maxBet, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 MaxBet（字段） 查询
		/// </summary>
		/// /// <param name = "maxBet">最大下注额</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Gdt_configEO> GetByMaxBet(long maxBet, int top_)
		{
			return GetByMaxBet(maxBet, top_, string.Empty, null);
		}
		public async Task<List<Gdt_configEO>> GetByMaxBetAsync(long maxBet, int top_)
		{
			return await GetByMaxBetAsync(maxBet, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 MaxBet（字段） 查询
		/// </summary>
		/// /// <param name = "maxBet">最大下注额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gdt_configEO> GetByMaxBet(long maxBet, int top_, TransactionManager tm_)
		{
			return GetByMaxBet(maxBet, top_, string.Empty, tm_);
		}
		public async Task<List<Gdt_configEO>> GetByMaxBetAsync(long maxBet, int top_, TransactionManager tm_)
		{
			return await GetByMaxBetAsync(maxBet, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 MaxBet（字段） 查询
		/// </summary>
		/// /// <param name = "maxBet">最大下注额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Gdt_configEO> GetByMaxBet(long maxBet, string sort_)
		{
			return GetByMaxBet(maxBet, 0, sort_, null);
		}
		public async Task<List<Gdt_configEO>> GetByMaxBetAsync(long maxBet, string sort_)
		{
			return await GetByMaxBetAsync(maxBet, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 MaxBet（字段） 查询
		/// </summary>
		/// /// <param name = "maxBet">最大下注额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gdt_configEO> GetByMaxBet(long maxBet, string sort_, TransactionManager tm_)
		{
			return GetByMaxBet(maxBet, 0, sort_, tm_);
		}
		public async Task<List<Gdt_configEO>> GetByMaxBetAsync(long maxBet, string sort_, TransactionManager tm_)
		{
			return await GetByMaxBetAsync(maxBet, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 MaxBet（字段） 查询
		/// </summary>
		/// /// <param name = "maxBet">最大下注额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gdt_configEO> GetByMaxBet(long maxBet, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`MaxBet` = @MaxBet", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@MaxBet", maxBet, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Gdt_configEO.MapDataReader);
		}
		public async Task<List<Gdt_configEO>> GetByMaxBetAsync(long maxBet, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`MaxBet` = @MaxBet", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@MaxBet", maxBet, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gdt_configEO.MapDataReader);
		}
		#endregion // GetByMaxBet
		#region GetByReturnRatio
		
		/// <summary>
		/// 按 ReturnRatio（字段） 查询
		/// </summary>
		/// /// <param name = "returnRatio">返奖系数</param>
		/// <return>实体对象集合</return>
		public List<Gdt_configEO> GetByReturnRatio(double returnRatio)
		{
			return GetByReturnRatio(returnRatio, 0, string.Empty, null);
		}
		public async Task<List<Gdt_configEO>> GetByReturnRatioAsync(double returnRatio)
		{
			return await GetByReturnRatioAsync(returnRatio, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ReturnRatio（字段） 查询
		/// </summary>
		/// /// <param name = "returnRatio">返奖系数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gdt_configEO> GetByReturnRatio(double returnRatio, TransactionManager tm_)
		{
			return GetByReturnRatio(returnRatio, 0, string.Empty, tm_);
		}
		public async Task<List<Gdt_configEO>> GetByReturnRatioAsync(double returnRatio, TransactionManager tm_)
		{
			return await GetByReturnRatioAsync(returnRatio, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ReturnRatio（字段） 查询
		/// </summary>
		/// /// <param name = "returnRatio">返奖系数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Gdt_configEO> GetByReturnRatio(double returnRatio, int top_)
		{
			return GetByReturnRatio(returnRatio, top_, string.Empty, null);
		}
		public async Task<List<Gdt_configEO>> GetByReturnRatioAsync(double returnRatio, int top_)
		{
			return await GetByReturnRatioAsync(returnRatio, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ReturnRatio（字段） 查询
		/// </summary>
		/// /// <param name = "returnRatio">返奖系数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gdt_configEO> GetByReturnRatio(double returnRatio, int top_, TransactionManager tm_)
		{
			return GetByReturnRatio(returnRatio, top_, string.Empty, tm_);
		}
		public async Task<List<Gdt_configEO>> GetByReturnRatioAsync(double returnRatio, int top_, TransactionManager tm_)
		{
			return await GetByReturnRatioAsync(returnRatio, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ReturnRatio（字段） 查询
		/// </summary>
		/// /// <param name = "returnRatio">返奖系数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Gdt_configEO> GetByReturnRatio(double returnRatio, string sort_)
		{
			return GetByReturnRatio(returnRatio, 0, sort_, null);
		}
		public async Task<List<Gdt_configEO>> GetByReturnRatioAsync(double returnRatio, string sort_)
		{
			return await GetByReturnRatioAsync(returnRatio, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 ReturnRatio（字段） 查询
		/// </summary>
		/// /// <param name = "returnRatio">返奖系数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gdt_configEO> GetByReturnRatio(double returnRatio, string sort_, TransactionManager tm_)
		{
			return GetByReturnRatio(returnRatio, 0, sort_, tm_);
		}
		public async Task<List<Gdt_configEO>> GetByReturnRatioAsync(double returnRatio, string sort_, TransactionManager tm_)
		{
			return await GetByReturnRatioAsync(returnRatio, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 ReturnRatio（字段） 查询
		/// </summary>
		/// /// <param name = "returnRatio">返奖系数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gdt_configEO> GetByReturnRatio(double returnRatio, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ReturnRatio` = @ReturnRatio", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ReturnRatio", returnRatio, MySqlDbType.Double));
			return Database.ExecSqlList(sql_, paras_, tm_, Gdt_configEO.MapDataReader);
		}
		public async Task<List<Gdt_configEO>> GetByReturnRatioAsync(double returnRatio, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ReturnRatio` = @ReturnRatio", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ReturnRatio", returnRatio, MySqlDbType.Double));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gdt_configEO.MapDataReader);
		}
		#endregion // GetByReturnRatio
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
