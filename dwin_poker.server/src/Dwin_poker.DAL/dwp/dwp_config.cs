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
	/// 初始基础配置
	/// 【表 dwp_config 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class Dwp_configEO : IRowMapper<Dwp_configEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public Dwp_configEO()
		{
			this.JPValTH = 0;
			this.MaxBetAmount = 0;
			this.MaxStar = 0;
			this.MaxCardNum = 0;
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
		/// JP分配
		/// 【字段 double】
		/// </summary>
		[DataMember(Order = 3)]
		public double JPRatio { get; set; }
		/// <summary>
		/// 税收分配
		/// 【字段 double】
		/// </summary>
		[DataMember(Order = 4)]
		public double IncomeRatio { get; set; }
		/// <summary>
		/// 排行分配
		/// 【字段 double】
		/// </summary>
		[DataMember(Order = 5)]
		public double RankRatio { get; set; }
		/// <summary>
		/// JP阈值
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 6)]
		public int JPValTH { get; set; }
		/// <summary>
		/// 下注上限
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 7)]
		public long MaxBetAmount { get; set; }
		/// <summary>
		/// 星级上限
		/// 【字段 tinyint】
		/// </summary>
		[DataMember(Order = 8)]
		public int MaxStar { get; set; }
		/// <summary>
		/// 卡牌回合上限
		/// 【字段 tinyint】
		/// </summary>
		[DataMember(Order = 9)]
		public int MaxCardNum { get; set; }
		/// <summary>
		/// JP按下注额分配百分比
		/// 【字段 double】
		/// </summary>
		[DataMember(Order = 10)]
		public double JPTotalRatio { get; set; }
		/// <summary>
		/// JP虚拟值
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 11)]
		public long JPInventedAmount { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public Dwp_configEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static Dwp_configEO MapDataReader(IDataReader reader)
		{
		    Dwp_configEO ret = new Dwp_configEO();
			ret.OperatorID = reader.ToString("OperatorID");
			ret.OriginalOperatorID = ret.OperatorID;
			ret.CurrencyID = reader.ToString("CurrencyID");
			ret.OriginalCurrencyID = ret.CurrencyID;
			ret.JPRatio = reader.ToDouble("JPRatio");
			ret.IncomeRatio = reader.ToDouble("IncomeRatio");
			ret.RankRatio = reader.ToDouble("RankRatio");
			ret.JPValTH = reader.ToInt32("JPValTH");
			ret.MaxBetAmount = reader.ToInt64("MaxBetAmount");
			ret.MaxStar = reader.ToInt32("MaxStar");
			ret.MaxCardNum = reader.ToInt32("MaxCardNum");
			ret.JPTotalRatio = reader.ToDouble("JPTotalRatio");
			ret.JPInventedAmount = reader.ToInt64("JPInventedAmount");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 初始基础配置
	/// 【表 dwp_config 的操作类】
	/// </summary>
	[Obsolete]
	public class Dwp_configMO : MySqlTableMO<Dwp_configEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`dwp_config`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public Dwp_configMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public Dwp_configMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public Dwp_configMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(Dwp_configEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(Dwp_configEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(Dwp_configEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`OperatorID`, `CurrencyID`, `JPRatio`, `IncomeRatio`, `RankRatio`, `JPValTH`, `MaxBetAmount`, `MaxStar`, `MaxCardNum`, `JPTotalRatio`, `JPInventedAmount`) VALUE (@OperatorID, @CurrencyID, @JPRatio, @IncomeRatio, @RankRatio, @JPValTH, @MaxBetAmount, @MaxStar, @MaxCardNum, @JPTotalRatio, @JPInventedAmount);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", item.OperatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", item.CurrencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@JPRatio", item.JPRatio, MySqlDbType.Double),
				Database.CreateInParameter("@IncomeRatio", item.IncomeRatio, MySqlDbType.Double),
				Database.CreateInParameter("@RankRatio", item.RankRatio, MySqlDbType.Double),
				Database.CreateInParameter("@JPValTH", item.JPValTH, MySqlDbType.Int32),
				Database.CreateInParameter("@MaxBetAmount", item.MaxBetAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@MaxStar", item.MaxStar, MySqlDbType.Byte),
				Database.CreateInParameter("@MaxCardNum", item.MaxCardNum, MySqlDbType.Byte),
				Database.CreateInParameter("@JPTotalRatio", item.JPTotalRatio, MySqlDbType.Double),
				Database.CreateInParameter("@JPInventedAmount", item.JPInventedAmount, MySqlDbType.Int64),
			};
		}
		public int AddByBatch(IEnumerable<Dwp_configEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<Dwp_configEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<Dwp_configEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`OperatorID`, `CurrencyID`, `JPRatio`, `IncomeRatio`, `RankRatio`, `JPValTH`, `MaxBetAmount`, `MaxStar`, `MaxCardNum`, `JPTotalRatio`, `JPInventedAmount`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"('{item.OperatorID}','{item.CurrencyID}',{item.JPRatio},{item.IncomeRatio},{item.RankRatio},{item.JPValTH},{item.MaxBetAmount},{item.MaxStar},{item.MaxCardNum},{item.JPTotalRatio},{item.JPInventedAmount}),");
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
		public int Remove(Dwp_configEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.OperatorID, item.CurrencyID, tm_);
		}
		public async Task<int> RemoveAsync(Dwp_configEO item, TransactionManager tm_ = null)
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
		#region RemoveByJPRatio
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "jPRatio">JP分配</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByJPRatio(double jPRatio, TransactionManager tm_ = null)
		{
			RepairRemoveByJPRatioData(jPRatio, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByJPRatioAsync(double jPRatio, TransactionManager tm_ = null)
		{
			RepairRemoveByJPRatioData(jPRatio, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByJPRatioData(double jPRatio, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `JPRatio` = @JPRatio";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@JPRatio", jPRatio, MySqlDbType.Double));
		}
		#endregion // RemoveByJPRatio
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
		#region RemoveByRankRatio
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "rankRatio">排行分配</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByRankRatio(double rankRatio, TransactionManager tm_ = null)
		{
			RepairRemoveByRankRatioData(rankRatio, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByRankRatioAsync(double rankRatio, TransactionManager tm_ = null)
		{
			RepairRemoveByRankRatioData(rankRatio, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByRankRatioData(double rankRatio, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `RankRatio` = @RankRatio";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RankRatio", rankRatio, MySqlDbType.Double));
		}
		#endregion // RemoveByRankRatio
		#region RemoveByJPValTH
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "jPValTH">JP阈值</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByJPValTH(int jPValTH, TransactionManager tm_ = null)
		{
			RepairRemoveByJPValTHData(jPValTH, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByJPValTHAsync(int jPValTH, TransactionManager tm_ = null)
		{
			RepairRemoveByJPValTHData(jPValTH, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByJPValTHData(int jPValTH, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `JPValTH` = @JPValTH";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@JPValTH", jPValTH, MySqlDbType.Int32));
		}
		#endregion // RemoveByJPValTH
		#region RemoveByMaxBetAmount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "maxBetAmount">下注上限</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByMaxBetAmount(long maxBetAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByMaxBetAmountData(maxBetAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByMaxBetAmountAsync(long maxBetAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByMaxBetAmountData(maxBetAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByMaxBetAmountData(long maxBetAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `MaxBetAmount` = @MaxBetAmount";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@MaxBetAmount", maxBetAmount, MySqlDbType.Int64));
		}
		#endregion // RemoveByMaxBetAmount
		#region RemoveByMaxStar
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "maxStar">星级上限</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByMaxStar(int maxStar, TransactionManager tm_ = null)
		{
			RepairRemoveByMaxStarData(maxStar, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByMaxStarAsync(int maxStar, TransactionManager tm_ = null)
		{
			RepairRemoveByMaxStarData(maxStar, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByMaxStarData(int maxStar, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `MaxStar` = @MaxStar";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@MaxStar", maxStar, MySqlDbType.Byte));
		}
		#endregion // RemoveByMaxStar
		#region RemoveByMaxCardNum
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "maxCardNum">卡牌回合上限</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByMaxCardNum(int maxCardNum, TransactionManager tm_ = null)
		{
			RepairRemoveByMaxCardNumData(maxCardNum, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByMaxCardNumAsync(int maxCardNum, TransactionManager tm_ = null)
		{
			RepairRemoveByMaxCardNumData(maxCardNum, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByMaxCardNumData(int maxCardNum, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `MaxCardNum` = @MaxCardNum";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@MaxCardNum", maxCardNum, MySqlDbType.Byte));
		}
		#endregion // RemoveByMaxCardNum
		#region RemoveByJPTotalRatio
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "jPTotalRatio">JP按下注额分配百分比</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByJPTotalRatio(double jPTotalRatio, TransactionManager tm_ = null)
		{
			RepairRemoveByJPTotalRatioData(jPTotalRatio, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByJPTotalRatioAsync(double jPTotalRatio, TransactionManager tm_ = null)
		{
			RepairRemoveByJPTotalRatioData(jPTotalRatio, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByJPTotalRatioData(double jPTotalRatio, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `JPTotalRatio` = @JPTotalRatio";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@JPTotalRatio", jPTotalRatio, MySqlDbType.Double));
		}
		#endregion // RemoveByJPTotalRatio
		#region RemoveByJPInventedAmount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "jPInventedAmount">JP虚拟值</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByJPInventedAmount(long jPInventedAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByJPInventedAmountData(jPInventedAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByJPInventedAmountAsync(long jPInventedAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByJPInventedAmountData(jPInventedAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByJPInventedAmountData(long jPInventedAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `JPInventedAmount` = @JPInventedAmount";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@JPInventedAmount", jPInventedAmount, MySqlDbType.Int64));
		}
		#endregion // RemoveByJPInventedAmount
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
		public int Put(Dwp_configEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(Dwp_configEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(Dwp_configEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `OperatorID` = @OperatorID, `CurrencyID` = @CurrencyID, `JPRatio` = @JPRatio, `IncomeRatio` = @IncomeRatio, `RankRatio` = @RankRatio, `JPValTH` = @JPValTH, `MaxBetAmount` = @MaxBetAmount, `MaxStar` = @MaxStar, `MaxCardNum` = @MaxCardNum, `JPTotalRatio` = @JPTotalRatio, `JPInventedAmount` = @JPInventedAmount WHERE `OperatorID` = @OperatorID_Original AND `CurrencyID` = @CurrencyID_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", item.OperatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", item.CurrencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@JPRatio", item.JPRatio, MySqlDbType.Double),
				Database.CreateInParameter("@IncomeRatio", item.IncomeRatio, MySqlDbType.Double),
				Database.CreateInParameter("@RankRatio", item.RankRatio, MySqlDbType.Double),
				Database.CreateInParameter("@JPValTH", item.JPValTH, MySqlDbType.Int32),
				Database.CreateInParameter("@MaxBetAmount", item.MaxBetAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@MaxStar", item.MaxStar, MySqlDbType.Byte),
				Database.CreateInParameter("@MaxCardNum", item.MaxCardNum, MySqlDbType.Byte),
				Database.CreateInParameter("@JPTotalRatio", item.JPTotalRatio, MySqlDbType.Double),
				Database.CreateInParameter("@JPInventedAmount", item.JPInventedAmount, MySqlDbType.Int64),
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
		public int Put(IEnumerable<Dwp_configEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<Dwp_configEO> items, TransactionManager tm_ = null)
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
		#region PutJPRatio
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// /// <param name = "jPRatio">JP分配</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutJPRatioByPK(string operatorID, string currencyID, double jPRatio, TransactionManager tm_ = null)
		{
			RepairPutJPRatioByPKData(operatorID, currencyID, jPRatio, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutJPRatioByPKAsync(string operatorID, string currencyID, double jPRatio, TransactionManager tm_ = null)
		{
			RepairPutJPRatioByPKData(operatorID, currencyID, jPRatio, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutJPRatioByPKData(string operatorID, string currencyID, double jPRatio, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `JPRatio` = @JPRatio  WHERE `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@JPRatio", jPRatio, MySqlDbType.Double),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "jPRatio">JP分配</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutJPRatio(double jPRatio, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `JPRatio` = @JPRatio";
			var parameter_ = Database.CreateInParameter("@JPRatio", jPRatio, MySqlDbType.Double);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutJPRatioAsync(double jPRatio, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `JPRatio` = @JPRatio";
			var parameter_ = Database.CreateInParameter("@JPRatio", jPRatio, MySqlDbType.Double);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutJPRatio
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
		#region PutRankRatio
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// /// <param name = "rankRatio">排行分配</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRankRatioByPK(string operatorID, string currencyID, double rankRatio, TransactionManager tm_ = null)
		{
			RepairPutRankRatioByPKData(operatorID, currencyID, rankRatio, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutRankRatioByPKAsync(string operatorID, string currencyID, double rankRatio, TransactionManager tm_ = null)
		{
			RepairPutRankRatioByPKData(operatorID, currencyID, rankRatio, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutRankRatioByPKData(string operatorID, string currencyID, double rankRatio, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `RankRatio` = @RankRatio  WHERE `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RankRatio", rankRatio, MySqlDbType.Double),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "rankRatio">排行分配</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRankRatio(double rankRatio, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `RankRatio` = @RankRatio";
			var parameter_ = Database.CreateInParameter("@RankRatio", rankRatio, MySqlDbType.Double);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutRankRatioAsync(double rankRatio, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `RankRatio` = @RankRatio";
			var parameter_ = Database.CreateInParameter("@RankRatio", rankRatio, MySqlDbType.Double);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutRankRatio
		#region PutJPValTH
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// /// <param name = "jPValTH">JP阈值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutJPValTHByPK(string operatorID, string currencyID, int jPValTH, TransactionManager tm_ = null)
		{
			RepairPutJPValTHByPKData(operatorID, currencyID, jPValTH, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutJPValTHByPKAsync(string operatorID, string currencyID, int jPValTH, TransactionManager tm_ = null)
		{
			RepairPutJPValTHByPKData(operatorID, currencyID, jPValTH, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutJPValTHByPKData(string operatorID, string currencyID, int jPValTH, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `JPValTH` = @JPValTH  WHERE `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@JPValTH", jPValTH, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "jPValTH">JP阈值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutJPValTH(int jPValTH, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `JPValTH` = @JPValTH";
			var parameter_ = Database.CreateInParameter("@JPValTH", jPValTH, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutJPValTHAsync(int jPValTH, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `JPValTH` = @JPValTH";
			var parameter_ = Database.CreateInParameter("@JPValTH", jPValTH, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutJPValTH
		#region PutMaxBetAmount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// /// <param name = "maxBetAmount">下注上限</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutMaxBetAmountByPK(string operatorID, string currencyID, long maxBetAmount, TransactionManager tm_ = null)
		{
			RepairPutMaxBetAmountByPKData(operatorID, currencyID, maxBetAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutMaxBetAmountByPKAsync(string operatorID, string currencyID, long maxBetAmount, TransactionManager tm_ = null)
		{
			RepairPutMaxBetAmountByPKData(operatorID, currencyID, maxBetAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutMaxBetAmountByPKData(string operatorID, string currencyID, long maxBetAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `MaxBetAmount` = @MaxBetAmount  WHERE `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MaxBetAmount", maxBetAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "maxBetAmount">下注上限</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutMaxBetAmount(long maxBetAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `MaxBetAmount` = @MaxBetAmount";
			var parameter_ = Database.CreateInParameter("@MaxBetAmount", maxBetAmount, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutMaxBetAmountAsync(long maxBetAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `MaxBetAmount` = @MaxBetAmount";
			var parameter_ = Database.CreateInParameter("@MaxBetAmount", maxBetAmount, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutMaxBetAmount
		#region PutMaxStar
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// /// <param name = "maxStar">星级上限</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutMaxStarByPK(string operatorID, string currencyID, int maxStar, TransactionManager tm_ = null)
		{
			RepairPutMaxStarByPKData(operatorID, currencyID, maxStar, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutMaxStarByPKAsync(string operatorID, string currencyID, int maxStar, TransactionManager tm_ = null)
		{
			RepairPutMaxStarByPKData(operatorID, currencyID, maxStar, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutMaxStarByPKData(string operatorID, string currencyID, int maxStar, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `MaxStar` = @MaxStar  WHERE `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MaxStar", maxStar, MySqlDbType.Byte),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "maxStar">星级上限</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutMaxStar(int maxStar, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `MaxStar` = @MaxStar";
			var parameter_ = Database.CreateInParameter("@MaxStar", maxStar, MySqlDbType.Byte);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutMaxStarAsync(int maxStar, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `MaxStar` = @MaxStar";
			var parameter_ = Database.CreateInParameter("@MaxStar", maxStar, MySqlDbType.Byte);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutMaxStar
		#region PutMaxCardNum
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// /// <param name = "maxCardNum">卡牌回合上限</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutMaxCardNumByPK(string operatorID, string currencyID, int maxCardNum, TransactionManager tm_ = null)
		{
			RepairPutMaxCardNumByPKData(operatorID, currencyID, maxCardNum, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutMaxCardNumByPKAsync(string operatorID, string currencyID, int maxCardNum, TransactionManager tm_ = null)
		{
			RepairPutMaxCardNumByPKData(operatorID, currencyID, maxCardNum, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutMaxCardNumByPKData(string operatorID, string currencyID, int maxCardNum, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `MaxCardNum` = @MaxCardNum  WHERE `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MaxCardNum", maxCardNum, MySqlDbType.Byte),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "maxCardNum">卡牌回合上限</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutMaxCardNum(int maxCardNum, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `MaxCardNum` = @MaxCardNum";
			var parameter_ = Database.CreateInParameter("@MaxCardNum", maxCardNum, MySqlDbType.Byte);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutMaxCardNumAsync(int maxCardNum, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `MaxCardNum` = @MaxCardNum";
			var parameter_ = Database.CreateInParameter("@MaxCardNum", maxCardNum, MySqlDbType.Byte);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutMaxCardNum
		#region PutJPTotalRatio
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// /// <param name = "jPTotalRatio">JP按下注额分配百分比</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutJPTotalRatioByPK(string operatorID, string currencyID, double jPTotalRatio, TransactionManager tm_ = null)
		{
			RepairPutJPTotalRatioByPKData(operatorID, currencyID, jPTotalRatio, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutJPTotalRatioByPKAsync(string operatorID, string currencyID, double jPTotalRatio, TransactionManager tm_ = null)
		{
			RepairPutJPTotalRatioByPKData(operatorID, currencyID, jPTotalRatio, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutJPTotalRatioByPKData(string operatorID, string currencyID, double jPTotalRatio, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `JPTotalRatio` = @JPTotalRatio  WHERE `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@JPTotalRatio", jPTotalRatio, MySqlDbType.Double),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "jPTotalRatio">JP按下注额分配百分比</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutJPTotalRatio(double jPTotalRatio, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `JPTotalRatio` = @JPTotalRatio";
			var parameter_ = Database.CreateInParameter("@JPTotalRatio", jPTotalRatio, MySqlDbType.Double);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutJPTotalRatioAsync(double jPTotalRatio, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `JPTotalRatio` = @JPTotalRatio";
			var parameter_ = Database.CreateInParameter("@JPTotalRatio", jPTotalRatio, MySqlDbType.Double);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutJPTotalRatio
		#region PutJPInventedAmount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// /// <param name = "jPInventedAmount">JP虚拟值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutJPInventedAmountByPK(string operatorID, string currencyID, long jPInventedAmount, TransactionManager tm_ = null)
		{
			RepairPutJPInventedAmountByPKData(operatorID, currencyID, jPInventedAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutJPInventedAmountByPKAsync(string operatorID, string currencyID, long jPInventedAmount, TransactionManager tm_ = null)
		{
			RepairPutJPInventedAmountByPKData(operatorID, currencyID, jPInventedAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutJPInventedAmountByPKData(string operatorID, string currencyID, long jPInventedAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `JPInventedAmount` = @JPInventedAmount  WHERE `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@JPInventedAmount", jPInventedAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "jPInventedAmount">JP虚拟值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutJPInventedAmount(long jPInventedAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `JPInventedAmount` = @JPInventedAmount";
			var parameter_ = Database.CreateInParameter("@JPInventedAmount", jPInventedAmount, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutJPInventedAmountAsync(long jPInventedAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `JPInventedAmount` = @JPInventedAmount";
			var parameter_ = Database.CreateInParameter("@JPInventedAmount", jPInventedAmount, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutJPInventedAmount
		#endregion // PutXXX
		#endregion // Put
	   
		#region Set
		
		/// <summary>
		/// 插入或者更新数据
		/// </summary>
		/// <param name = "item">要更新的实体对象</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>true:插入操作；false:更新操作</return>
		public bool Set(Dwp_configEO item, TransactionManager tm = null)
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
		public async Task<bool> SetAsync(Dwp_configEO item, TransactionManager tm = null)
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
		public Dwp_configEO GetByPK(string operatorID, string currencyID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(operatorID, currencyID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, Dwp_configEO.MapDataReader);
		}
		public async Task<Dwp_configEO> GetByPKAsync(string operatorID, string currencyID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(operatorID, currencyID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Dwp_configEO.MapDataReader);
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
		/// 按主键查询 JPRatio（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public double GetJPRatioByPK(string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (double)GetScalar("`JPRatio`", "`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		public async Task<double> GetJPRatioByPKAsync(string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (double)await GetScalarAsync("`JPRatio`", "`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
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
		/// 按主键查询 RankRatio（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public double GetRankRatioByPK(string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (double)GetScalar("`RankRatio`", "`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		public async Task<double> GetRankRatioByPKAsync(string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (double)await GetScalarAsync("`RankRatio`", "`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 JPValTH（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetJPValTHByPK(string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`JPValTH`", "`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		public async Task<int> GetJPValTHByPKAsync(string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`JPValTH`", "`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 MaxBetAmount（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetMaxBetAmountByPK(string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`MaxBetAmount`", "`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		public async Task<long> GetMaxBetAmountByPKAsync(string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`MaxBetAmount`", "`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 MaxStar（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetMaxStarByPK(string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`MaxStar`", "`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		public async Task<int> GetMaxStarByPKAsync(string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`MaxStar`", "`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 MaxCardNum（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetMaxCardNumByPK(string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`MaxCardNum`", "`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		public async Task<int> GetMaxCardNumByPKAsync(string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`MaxCardNum`", "`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 JPTotalRatio（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public double GetJPTotalRatioByPK(string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (double)GetScalar("`JPTotalRatio`", "`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		public async Task<double> GetJPTotalRatioByPKAsync(string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (double)await GetScalarAsync("`JPTotalRatio`", "`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 JPInventedAmount（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetJPInventedAmountByPK(string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`JPInventedAmount`", "`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		public async Task<long> GetJPInventedAmountByPKAsync(string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`JPInventedAmount`", "`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByOperatorID
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <return>实体对象集合</return>
		public List<Dwp_configEO> GetByOperatorID(string operatorID)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, null);
		}
		public async Task<List<Dwp_configEO>> GetByOperatorIDAsync(string operatorID)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Dwp_configEO> GetByOperatorID(string operatorID, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, tm_);
		}
		public async Task<List<Dwp_configEO>> GetByOperatorIDAsync(string operatorID, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Dwp_configEO> GetByOperatorID(string operatorID, int top_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, null);
		}
		public async Task<List<Dwp_configEO>> GetByOperatorIDAsync(string operatorID, int top_)
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
		public List<Dwp_configEO> GetByOperatorID(string operatorID, int top_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, tm_);
		}
		public async Task<List<Dwp_configEO>> GetByOperatorIDAsync(string operatorID, int top_, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Dwp_configEO> GetByOperatorID(string operatorID, string sort_)
		{
			return GetByOperatorID(operatorID, 0, sort_, null);
		}
		public async Task<List<Dwp_configEO>> GetByOperatorIDAsync(string operatorID, string sort_)
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
		public List<Dwp_configEO> GetByOperatorID(string operatorID, string sort_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, sort_, tm_);
		}
		public async Task<List<Dwp_configEO>> GetByOperatorIDAsync(string operatorID, string sort_, TransactionManager tm_)
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
		public List<Dwp_configEO> GetByOperatorID(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorID` = @OperatorID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Dwp_configEO.MapDataReader);
		}
		public async Task<List<Dwp_configEO>> GetByOperatorIDAsync(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorID` = @OperatorID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Dwp_configEO.MapDataReader);
		}
		#endregion // GetByOperatorID
		#region GetByCurrencyID
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// <return>实体对象集合</return>
		public List<Dwp_configEO> GetByCurrencyID(string currencyID)
		{
			return GetByCurrencyID(currencyID, 0, string.Empty, null);
		}
		public async Task<List<Dwp_configEO>> GetByCurrencyIDAsync(string currencyID)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Dwp_configEO> GetByCurrencyID(string currencyID, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, 0, string.Empty, tm_);
		}
		public async Task<List<Dwp_configEO>> GetByCurrencyIDAsync(string currencyID, TransactionManager tm_)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Dwp_configEO> GetByCurrencyID(string currencyID, int top_)
		{
			return GetByCurrencyID(currencyID, top_, string.Empty, null);
		}
		public async Task<List<Dwp_configEO>> GetByCurrencyIDAsync(string currencyID, int top_)
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
		public List<Dwp_configEO> GetByCurrencyID(string currencyID, int top_, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, top_, string.Empty, tm_);
		}
		public async Task<List<Dwp_configEO>> GetByCurrencyIDAsync(string currencyID, int top_, TransactionManager tm_)
		{
			return await GetByCurrencyIDAsync(currencyID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Dwp_configEO> GetByCurrencyID(string currencyID, string sort_)
		{
			return GetByCurrencyID(currencyID, 0, sort_, null);
		}
		public async Task<List<Dwp_configEO>> GetByCurrencyIDAsync(string currencyID, string sort_)
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
		public List<Dwp_configEO> GetByCurrencyID(string currencyID, string sort_, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, 0, sort_, tm_);
		}
		public async Task<List<Dwp_configEO>> GetByCurrencyIDAsync(string currencyID, string sort_, TransactionManager tm_)
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
		public List<Dwp_configEO> GetByCurrencyID(string currencyID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CurrencyID` = @CurrencyID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Dwp_configEO.MapDataReader);
		}
		public async Task<List<Dwp_configEO>> GetByCurrencyIDAsync(string currencyID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CurrencyID` = @CurrencyID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Dwp_configEO.MapDataReader);
		}
		#endregion // GetByCurrencyID
		#region GetByJPRatio
		
		/// <summary>
		/// 按 JPRatio（字段） 查询
		/// </summary>
		/// /// <param name = "jPRatio">JP分配</param>
		/// <return>实体对象集合</return>
		public List<Dwp_configEO> GetByJPRatio(double jPRatio)
		{
			return GetByJPRatio(jPRatio, 0, string.Empty, null);
		}
		public async Task<List<Dwp_configEO>> GetByJPRatioAsync(double jPRatio)
		{
			return await GetByJPRatioAsync(jPRatio, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 JPRatio（字段） 查询
		/// </summary>
		/// /// <param name = "jPRatio">JP分配</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Dwp_configEO> GetByJPRatio(double jPRatio, TransactionManager tm_)
		{
			return GetByJPRatio(jPRatio, 0, string.Empty, tm_);
		}
		public async Task<List<Dwp_configEO>> GetByJPRatioAsync(double jPRatio, TransactionManager tm_)
		{
			return await GetByJPRatioAsync(jPRatio, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 JPRatio（字段） 查询
		/// </summary>
		/// /// <param name = "jPRatio">JP分配</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Dwp_configEO> GetByJPRatio(double jPRatio, int top_)
		{
			return GetByJPRatio(jPRatio, top_, string.Empty, null);
		}
		public async Task<List<Dwp_configEO>> GetByJPRatioAsync(double jPRatio, int top_)
		{
			return await GetByJPRatioAsync(jPRatio, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 JPRatio（字段） 查询
		/// </summary>
		/// /// <param name = "jPRatio">JP分配</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Dwp_configEO> GetByJPRatio(double jPRatio, int top_, TransactionManager tm_)
		{
			return GetByJPRatio(jPRatio, top_, string.Empty, tm_);
		}
		public async Task<List<Dwp_configEO>> GetByJPRatioAsync(double jPRatio, int top_, TransactionManager tm_)
		{
			return await GetByJPRatioAsync(jPRatio, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 JPRatio（字段） 查询
		/// </summary>
		/// /// <param name = "jPRatio">JP分配</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Dwp_configEO> GetByJPRatio(double jPRatio, string sort_)
		{
			return GetByJPRatio(jPRatio, 0, sort_, null);
		}
		public async Task<List<Dwp_configEO>> GetByJPRatioAsync(double jPRatio, string sort_)
		{
			return await GetByJPRatioAsync(jPRatio, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 JPRatio（字段） 查询
		/// </summary>
		/// /// <param name = "jPRatio">JP分配</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Dwp_configEO> GetByJPRatio(double jPRatio, string sort_, TransactionManager tm_)
		{
			return GetByJPRatio(jPRatio, 0, sort_, tm_);
		}
		public async Task<List<Dwp_configEO>> GetByJPRatioAsync(double jPRatio, string sort_, TransactionManager tm_)
		{
			return await GetByJPRatioAsync(jPRatio, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 JPRatio（字段） 查询
		/// </summary>
		/// /// <param name = "jPRatio">JP分配</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Dwp_configEO> GetByJPRatio(double jPRatio, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`JPRatio` = @JPRatio", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@JPRatio", jPRatio, MySqlDbType.Double));
			return Database.ExecSqlList(sql_, paras_, tm_, Dwp_configEO.MapDataReader);
		}
		public async Task<List<Dwp_configEO>> GetByJPRatioAsync(double jPRatio, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`JPRatio` = @JPRatio", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@JPRatio", jPRatio, MySqlDbType.Double));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Dwp_configEO.MapDataReader);
		}
		#endregion // GetByJPRatio
		#region GetByIncomeRatio
		
		/// <summary>
		/// 按 IncomeRatio（字段） 查询
		/// </summary>
		/// /// <param name = "incomeRatio">税收分配</param>
		/// <return>实体对象集合</return>
		public List<Dwp_configEO> GetByIncomeRatio(double incomeRatio)
		{
			return GetByIncomeRatio(incomeRatio, 0, string.Empty, null);
		}
		public async Task<List<Dwp_configEO>> GetByIncomeRatioAsync(double incomeRatio)
		{
			return await GetByIncomeRatioAsync(incomeRatio, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 IncomeRatio（字段） 查询
		/// </summary>
		/// /// <param name = "incomeRatio">税收分配</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Dwp_configEO> GetByIncomeRatio(double incomeRatio, TransactionManager tm_)
		{
			return GetByIncomeRatio(incomeRatio, 0, string.Empty, tm_);
		}
		public async Task<List<Dwp_configEO>> GetByIncomeRatioAsync(double incomeRatio, TransactionManager tm_)
		{
			return await GetByIncomeRatioAsync(incomeRatio, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IncomeRatio（字段） 查询
		/// </summary>
		/// /// <param name = "incomeRatio">税收分配</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Dwp_configEO> GetByIncomeRatio(double incomeRatio, int top_)
		{
			return GetByIncomeRatio(incomeRatio, top_, string.Empty, null);
		}
		public async Task<List<Dwp_configEO>> GetByIncomeRatioAsync(double incomeRatio, int top_)
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
		public List<Dwp_configEO> GetByIncomeRatio(double incomeRatio, int top_, TransactionManager tm_)
		{
			return GetByIncomeRatio(incomeRatio, top_, string.Empty, tm_);
		}
		public async Task<List<Dwp_configEO>> GetByIncomeRatioAsync(double incomeRatio, int top_, TransactionManager tm_)
		{
			return await GetByIncomeRatioAsync(incomeRatio, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IncomeRatio（字段） 查询
		/// </summary>
		/// /// <param name = "incomeRatio">税收分配</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Dwp_configEO> GetByIncomeRatio(double incomeRatio, string sort_)
		{
			return GetByIncomeRatio(incomeRatio, 0, sort_, null);
		}
		public async Task<List<Dwp_configEO>> GetByIncomeRatioAsync(double incomeRatio, string sort_)
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
		public List<Dwp_configEO> GetByIncomeRatio(double incomeRatio, string sort_, TransactionManager tm_)
		{
			return GetByIncomeRatio(incomeRatio, 0, sort_, tm_);
		}
		public async Task<List<Dwp_configEO>> GetByIncomeRatioAsync(double incomeRatio, string sort_, TransactionManager tm_)
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
		public List<Dwp_configEO> GetByIncomeRatio(double incomeRatio, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`IncomeRatio` = @IncomeRatio", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IncomeRatio", incomeRatio, MySqlDbType.Double));
			return Database.ExecSqlList(sql_, paras_, tm_, Dwp_configEO.MapDataReader);
		}
		public async Task<List<Dwp_configEO>> GetByIncomeRatioAsync(double incomeRatio, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`IncomeRatio` = @IncomeRatio", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IncomeRatio", incomeRatio, MySqlDbType.Double));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Dwp_configEO.MapDataReader);
		}
		#endregion // GetByIncomeRatio
		#region GetByRankRatio
		
		/// <summary>
		/// 按 RankRatio（字段） 查询
		/// </summary>
		/// /// <param name = "rankRatio">排行分配</param>
		/// <return>实体对象集合</return>
		public List<Dwp_configEO> GetByRankRatio(double rankRatio)
		{
			return GetByRankRatio(rankRatio, 0, string.Empty, null);
		}
		public async Task<List<Dwp_configEO>> GetByRankRatioAsync(double rankRatio)
		{
			return await GetByRankRatioAsync(rankRatio, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RankRatio（字段） 查询
		/// </summary>
		/// /// <param name = "rankRatio">排行分配</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Dwp_configEO> GetByRankRatio(double rankRatio, TransactionManager tm_)
		{
			return GetByRankRatio(rankRatio, 0, string.Empty, tm_);
		}
		public async Task<List<Dwp_configEO>> GetByRankRatioAsync(double rankRatio, TransactionManager tm_)
		{
			return await GetByRankRatioAsync(rankRatio, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RankRatio（字段） 查询
		/// </summary>
		/// /// <param name = "rankRatio">排行分配</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Dwp_configEO> GetByRankRatio(double rankRatio, int top_)
		{
			return GetByRankRatio(rankRatio, top_, string.Empty, null);
		}
		public async Task<List<Dwp_configEO>> GetByRankRatioAsync(double rankRatio, int top_)
		{
			return await GetByRankRatioAsync(rankRatio, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RankRatio（字段） 查询
		/// </summary>
		/// /// <param name = "rankRatio">排行分配</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Dwp_configEO> GetByRankRatio(double rankRatio, int top_, TransactionManager tm_)
		{
			return GetByRankRatio(rankRatio, top_, string.Empty, tm_);
		}
		public async Task<List<Dwp_configEO>> GetByRankRatioAsync(double rankRatio, int top_, TransactionManager tm_)
		{
			return await GetByRankRatioAsync(rankRatio, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RankRatio（字段） 查询
		/// </summary>
		/// /// <param name = "rankRatio">排行分配</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Dwp_configEO> GetByRankRatio(double rankRatio, string sort_)
		{
			return GetByRankRatio(rankRatio, 0, sort_, null);
		}
		public async Task<List<Dwp_configEO>> GetByRankRatioAsync(double rankRatio, string sort_)
		{
			return await GetByRankRatioAsync(rankRatio, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 RankRatio（字段） 查询
		/// </summary>
		/// /// <param name = "rankRatio">排行分配</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Dwp_configEO> GetByRankRatio(double rankRatio, string sort_, TransactionManager tm_)
		{
			return GetByRankRatio(rankRatio, 0, sort_, tm_);
		}
		public async Task<List<Dwp_configEO>> GetByRankRatioAsync(double rankRatio, string sort_, TransactionManager tm_)
		{
			return await GetByRankRatioAsync(rankRatio, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 RankRatio（字段） 查询
		/// </summary>
		/// /// <param name = "rankRatio">排行分配</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Dwp_configEO> GetByRankRatio(double rankRatio, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RankRatio` = @RankRatio", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RankRatio", rankRatio, MySqlDbType.Double));
			return Database.ExecSqlList(sql_, paras_, tm_, Dwp_configEO.MapDataReader);
		}
		public async Task<List<Dwp_configEO>> GetByRankRatioAsync(double rankRatio, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RankRatio` = @RankRatio", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RankRatio", rankRatio, MySqlDbType.Double));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Dwp_configEO.MapDataReader);
		}
		#endregion // GetByRankRatio
		#region GetByJPValTH
		
		/// <summary>
		/// 按 JPValTH（字段） 查询
		/// </summary>
		/// /// <param name = "jPValTH">JP阈值</param>
		/// <return>实体对象集合</return>
		public List<Dwp_configEO> GetByJPValTH(int jPValTH)
		{
			return GetByJPValTH(jPValTH, 0, string.Empty, null);
		}
		public async Task<List<Dwp_configEO>> GetByJPValTHAsync(int jPValTH)
		{
			return await GetByJPValTHAsync(jPValTH, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 JPValTH（字段） 查询
		/// </summary>
		/// /// <param name = "jPValTH">JP阈值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Dwp_configEO> GetByJPValTH(int jPValTH, TransactionManager tm_)
		{
			return GetByJPValTH(jPValTH, 0, string.Empty, tm_);
		}
		public async Task<List<Dwp_configEO>> GetByJPValTHAsync(int jPValTH, TransactionManager tm_)
		{
			return await GetByJPValTHAsync(jPValTH, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 JPValTH（字段） 查询
		/// </summary>
		/// /// <param name = "jPValTH">JP阈值</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Dwp_configEO> GetByJPValTH(int jPValTH, int top_)
		{
			return GetByJPValTH(jPValTH, top_, string.Empty, null);
		}
		public async Task<List<Dwp_configEO>> GetByJPValTHAsync(int jPValTH, int top_)
		{
			return await GetByJPValTHAsync(jPValTH, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 JPValTH（字段） 查询
		/// </summary>
		/// /// <param name = "jPValTH">JP阈值</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Dwp_configEO> GetByJPValTH(int jPValTH, int top_, TransactionManager tm_)
		{
			return GetByJPValTH(jPValTH, top_, string.Empty, tm_);
		}
		public async Task<List<Dwp_configEO>> GetByJPValTHAsync(int jPValTH, int top_, TransactionManager tm_)
		{
			return await GetByJPValTHAsync(jPValTH, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 JPValTH（字段） 查询
		/// </summary>
		/// /// <param name = "jPValTH">JP阈值</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Dwp_configEO> GetByJPValTH(int jPValTH, string sort_)
		{
			return GetByJPValTH(jPValTH, 0, sort_, null);
		}
		public async Task<List<Dwp_configEO>> GetByJPValTHAsync(int jPValTH, string sort_)
		{
			return await GetByJPValTHAsync(jPValTH, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 JPValTH（字段） 查询
		/// </summary>
		/// /// <param name = "jPValTH">JP阈值</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Dwp_configEO> GetByJPValTH(int jPValTH, string sort_, TransactionManager tm_)
		{
			return GetByJPValTH(jPValTH, 0, sort_, tm_);
		}
		public async Task<List<Dwp_configEO>> GetByJPValTHAsync(int jPValTH, string sort_, TransactionManager tm_)
		{
			return await GetByJPValTHAsync(jPValTH, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 JPValTH（字段） 查询
		/// </summary>
		/// /// <param name = "jPValTH">JP阈值</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Dwp_configEO> GetByJPValTH(int jPValTH, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`JPValTH` = @JPValTH", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@JPValTH", jPValTH, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Dwp_configEO.MapDataReader);
		}
		public async Task<List<Dwp_configEO>> GetByJPValTHAsync(int jPValTH, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`JPValTH` = @JPValTH", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@JPValTH", jPValTH, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Dwp_configEO.MapDataReader);
		}
		#endregion // GetByJPValTH
		#region GetByMaxBetAmount
		
		/// <summary>
		/// 按 MaxBetAmount（字段） 查询
		/// </summary>
		/// /// <param name = "maxBetAmount">下注上限</param>
		/// <return>实体对象集合</return>
		public List<Dwp_configEO> GetByMaxBetAmount(long maxBetAmount)
		{
			return GetByMaxBetAmount(maxBetAmount, 0, string.Empty, null);
		}
		public async Task<List<Dwp_configEO>> GetByMaxBetAmountAsync(long maxBetAmount)
		{
			return await GetByMaxBetAmountAsync(maxBetAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 MaxBetAmount（字段） 查询
		/// </summary>
		/// /// <param name = "maxBetAmount">下注上限</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Dwp_configEO> GetByMaxBetAmount(long maxBetAmount, TransactionManager tm_)
		{
			return GetByMaxBetAmount(maxBetAmount, 0, string.Empty, tm_);
		}
		public async Task<List<Dwp_configEO>> GetByMaxBetAmountAsync(long maxBetAmount, TransactionManager tm_)
		{
			return await GetByMaxBetAmountAsync(maxBetAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 MaxBetAmount（字段） 查询
		/// </summary>
		/// /// <param name = "maxBetAmount">下注上限</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Dwp_configEO> GetByMaxBetAmount(long maxBetAmount, int top_)
		{
			return GetByMaxBetAmount(maxBetAmount, top_, string.Empty, null);
		}
		public async Task<List<Dwp_configEO>> GetByMaxBetAmountAsync(long maxBetAmount, int top_)
		{
			return await GetByMaxBetAmountAsync(maxBetAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 MaxBetAmount（字段） 查询
		/// </summary>
		/// /// <param name = "maxBetAmount">下注上限</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Dwp_configEO> GetByMaxBetAmount(long maxBetAmount, int top_, TransactionManager tm_)
		{
			return GetByMaxBetAmount(maxBetAmount, top_, string.Empty, tm_);
		}
		public async Task<List<Dwp_configEO>> GetByMaxBetAmountAsync(long maxBetAmount, int top_, TransactionManager tm_)
		{
			return await GetByMaxBetAmountAsync(maxBetAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 MaxBetAmount（字段） 查询
		/// </summary>
		/// /// <param name = "maxBetAmount">下注上限</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Dwp_configEO> GetByMaxBetAmount(long maxBetAmount, string sort_)
		{
			return GetByMaxBetAmount(maxBetAmount, 0, sort_, null);
		}
		public async Task<List<Dwp_configEO>> GetByMaxBetAmountAsync(long maxBetAmount, string sort_)
		{
			return await GetByMaxBetAmountAsync(maxBetAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 MaxBetAmount（字段） 查询
		/// </summary>
		/// /// <param name = "maxBetAmount">下注上限</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Dwp_configEO> GetByMaxBetAmount(long maxBetAmount, string sort_, TransactionManager tm_)
		{
			return GetByMaxBetAmount(maxBetAmount, 0, sort_, tm_);
		}
		public async Task<List<Dwp_configEO>> GetByMaxBetAmountAsync(long maxBetAmount, string sort_, TransactionManager tm_)
		{
			return await GetByMaxBetAmountAsync(maxBetAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 MaxBetAmount（字段） 查询
		/// </summary>
		/// /// <param name = "maxBetAmount">下注上限</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Dwp_configEO> GetByMaxBetAmount(long maxBetAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`MaxBetAmount` = @MaxBetAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@MaxBetAmount", maxBetAmount, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Dwp_configEO.MapDataReader);
		}
		public async Task<List<Dwp_configEO>> GetByMaxBetAmountAsync(long maxBetAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`MaxBetAmount` = @MaxBetAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@MaxBetAmount", maxBetAmount, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Dwp_configEO.MapDataReader);
		}
		#endregion // GetByMaxBetAmount
		#region GetByMaxStar
		
		/// <summary>
		/// 按 MaxStar（字段） 查询
		/// </summary>
		/// /// <param name = "maxStar">星级上限</param>
		/// <return>实体对象集合</return>
		public List<Dwp_configEO> GetByMaxStar(int maxStar)
		{
			return GetByMaxStar(maxStar, 0, string.Empty, null);
		}
		public async Task<List<Dwp_configEO>> GetByMaxStarAsync(int maxStar)
		{
			return await GetByMaxStarAsync(maxStar, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 MaxStar（字段） 查询
		/// </summary>
		/// /// <param name = "maxStar">星级上限</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Dwp_configEO> GetByMaxStar(int maxStar, TransactionManager tm_)
		{
			return GetByMaxStar(maxStar, 0, string.Empty, tm_);
		}
		public async Task<List<Dwp_configEO>> GetByMaxStarAsync(int maxStar, TransactionManager tm_)
		{
			return await GetByMaxStarAsync(maxStar, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 MaxStar（字段） 查询
		/// </summary>
		/// /// <param name = "maxStar">星级上限</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Dwp_configEO> GetByMaxStar(int maxStar, int top_)
		{
			return GetByMaxStar(maxStar, top_, string.Empty, null);
		}
		public async Task<List<Dwp_configEO>> GetByMaxStarAsync(int maxStar, int top_)
		{
			return await GetByMaxStarAsync(maxStar, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 MaxStar（字段） 查询
		/// </summary>
		/// /// <param name = "maxStar">星级上限</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Dwp_configEO> GetByMaxStar(int maxStar, int top_, TransactionManager tm_)
		{
			return GetByMaxStar(maxStar, top_, string.Empty, tm_);
		}
		public async Task<List<Dwp_configEO>> GetByMaxStarAsync(int maxStar, int top_, TransactionManager tm_)
		{
			return await GetByMaxStarAsync(maxStar, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 MaxStar（字段） 查询
		/// </summary>
		/// /// <param name = "maxStar">星级上限</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Dwp_configEO> GetByMaxStar(int maxStar, string sort_)
		{
			return GetByMaxStar(maxStar, 0, sort_, null);
		}
		public async Task<List<Dwp_configEO>> GetByMaxStarAsync(int maxStar, string sort_)
		{
			return await GetByMaxStarAsync(maxStar, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 MaxStar（字段） 查询
		/// </summary>
		/// /// <param name = "maxStar">星级上限</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Dwp_configEO> GetByMaxStar(int maxStar, string sort_, TransactionManager tm_)
		{
			return GetByMaxStar(maxStar, 0, sort_, tm_);
		}
		public async Task<List<Dwp_configEO>> GetByMaxStarAsync(int maxStar, string sort_, TransactionManager tm_)
		{
			return await GetByMaxStarAsync(maxStar, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 MaxStar（字段） 查询
		/// </summary>
		/// /// <param name = "maxStar">星级上限</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Dwp_configEO> GetByMaxStar(int maxStar, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`MaxStar` = @MaxStar", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@MaxStar", maxStar, MySqlDbType.Byte));
			return Database.ExecSqlList(sql_, paras_, tm_, Dwp_configEO.MapDataReader);
		}
		public async Task<List<Dwp_configEO>> GetByMaxStarAsync(int maxStar, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`MaxStar` = @MaxStar", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@MaxStar", maxStar, MySqlDbType.Byte));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Dwp_configEO.MapDataReader);
		}
		#endregion // GetByMaxStar
		#region GetByMaxCardNum
		
		/// <summary>
		/// 按 MaxCardNum（字段） 查询
		/// </summary>
		/// /// <param name = "maxCardNum">卡牌回合上限</param>
		/// <return>实体对象集合</return>
		public List<Dwp_configEO> GetByMaxCardNum(int maxCardNum)
		{
			return GetByMaxCardNum(maxCardNum, 0, string.Empty, null);
		}
		public async Task<List<Dwp_configEO>> GetByMaxCardNumAsync(int maxCardNum)
		{
			return await GetByMaxCardNumAsync(maxCardNum, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 MaxCardNum（字段） 查询
		/// </summary>
		/// /// <param name = "maxCardNum">卡牌回合上限</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Dwp_configEO> GetByMaxCardNum(int maxCardNum, TransactionManager tm_)
		{
			return GetByMaxCardNum(maxCardNum, 0, string.Empty, tm_);
		}
		public async Task<List<Dwp_configEO>> GetByMaxCardNumAsync(int maxCardNum, TransactionManager tm_)
		{
			return await GetByMaxCardNumAsync(maxCardNum, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 MaxCardNum（字段） 查询
		/// </summary>
		/// /// <param name = "maxCardNum">卡牌回合上限</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Dwp_configEO> GetByMaxCardNum(int maxCardNum, int top_)
		{
			return GetByMaxCardNum(maxCardNum, top_, string.Empty, null);
		}
		public async Task<List<Dwp_configEO>> GetByMaxCardNumAsync(int maxCardNum, int top_)
		{
			return await GetByMaxCardNumAsync(maxCardNum, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 MaxCardNum（字段） 查询
		/// </summary>
		/// /// <param name = "maxCardNum">卡牌回合上限</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Dwp_configEO> GetByMaxCardNum(int maxCardNum, int top_, TransactionManager tm_)
		{
			return GetByMaxCardNum(maxCardNum, top_, string.Empty, tm_);
		}
		public async Task<List<Dwp_configEO>> GetByMaxCardNumAsync(int maxCardNum, int top_, TransactionManager tm_)
		{
			return await GetByMaxCardNumAsync(maxCardNum, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 MaxCardNum（字段） 查询
		/// </summary>
		/// /// <param name = "maxCardNum">卡牌回合上限</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Dwp_configEO> GetByMaxCardNum(int maxCardNum, string sort_)
		{
			return GetByMaxCardNum(maxCardNum, 0, sort_, null);
		}
		public async Task<List<Dwp_configEO>> GetByMaxCardNumAsync(int maxCardNum, string sort_)
		{
			return await GetByMaxCardNumAsync(maxCardNum, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 MaxCardNum（字段） 查询
		/// </summary>
		/// /// <param name = "maxCardNum">卡牌回合上限</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Dwp_configEO> GetByMaxCardNum(int maxCardNum, string sort_, TransactionManager tm_)
		{
			return GetByMaxCardNum(maxCardNum, 0, sort_, tm_);
		}
		public async Task<List<Dwp_configEO>> GetByMaxCardNumAsync(int maxCardNum, string sort_, TransactionManager tm_)
		{
			return await GetByMaxCardNumAsync(maxCardNum, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 MaxCardNum（字段） 查询
		/// </summary>
		/// /// <param name = "maxCardNum">卡牌回合上限</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Dwp_configEO> GetByMaxCardNum(int maxCardNum, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`MaxCardNum` = @MaxCardNum", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@MaxCardNum", maxCardNum, MySqlDbType.Byte));
			return Database.ExecSqlList(sql_, paras_, tm_, Dwp_configEO.MapDataReader);
		}
		public async Task<List<Dwp_configEO>> GetByMaxCardNumAsync(int maxCardNum, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`MaxCardNum` = @MaxCardNum", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@MaxCardNum", maxCardNum, MySqlDbType.Byte));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Dwp_configEO.MapDataReader);
		}
		#endregion // GetByMaxCardNum
		#region GetByJPTotalRatio
		
		/// <summary>
		/// 按 JPTotalRatio（字段） 查询
		/// </summary>
		/// /// <param name = "jPTotalRatio">JP按下注额分配百分比</param>
		/// <return>实体对象集合</return>
		public List<Dwp_configEO> GetByJPTotalRatio(double jPTotalRatio)
		{
			return GetByJPTotalRatio(jPTotalRatio, 0, string.Empty, null);
		}
		public async Task<List<Dwp_configEO>> GetByJPTotalRatioAsync(double jPTotalRatio)
		{
			return await GetByJPTotalRatioAsync(jPTotalRatio, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 JPTotalRatio（字段） 查询
		/// </summary>
		/// /// <param name = "jPTotalRatio">JP按下注额分配百分比</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Dwp_configEO> GetByJPTotalRatio(double jPTotalRatio, TransactionManager tm_)
		{
			return GetByJPTotalRatio(jPTotalRatio, 0, string.Empty, tm_);
		}
		public async Task<List<Dwp_configEO>> GetByJPTotalRatioAsync(double jPTotalRatio, TransactionManager tm_)
		{
			return await GetByJPTotalRatioAsync(jPTotalRatio, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 JPTotalRatio（字段） 查询
		/// </summary>
		/// /// <param name = "jPTotalRatio">JP按下注额分配百分比</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Dwp_configEO> GetByJPTotalRatio(double jPTotalRatio, int top_)
		{
			return GetByJPTotalRatio(jPTotalRatio, top_, string.Empty, null);
		}
		public async Task<List<Dwp_configEO>> GetByJPTotalRatioAsync(double jPTotalRatio, int top_)
		{
			return await GetByJPTotalRatioAsync(jPTotalRatio, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 JPTotalRatio（字段） 查询
		/// </summary>
		/// /// <param name = "jPTotalRatio">JP按下注额分配百分比</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Dwp_configEO> GetByJPTotalRatio(double jPTotalRatio, int top_, TransactionManager tm_)
		{
			return GetByJPTotalRatio(jPTotalRatio, top_, string.Empty, tm_);
		}
		public async Task<List<Dwp_configEO>> GetByJPTotalRatioAsync(double jPTotalRatio, int top_, TransactionManager tm_)
		{
			return await GetByJPTotalRatioAsync(jPTotalRatio, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 JPTotalRatio（字段） 查询
		/// </summary>
		/// /// <param name = "jPTotalRatio">JP按下注额分配百分比</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Dwp_configEO> GetByJPTotalRatio(double jPTotalRatio, string sort_)
		{
			return GetByJPTotalRatio(jPTotalRatio, 0, sort_, null);
		}
		public async Task<List<Dwp_configEO>> GetByJPTotalRatioAsync(double jPTotalRatio, string sort_)
		{
			return await GetByJPTotalRatioAsync(jPTotalRatio, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 JPTotalRatio（字段） 查询
		/// </summary>
		/// /// <param name = "jPTotalRatio">JP按下注额分配百分比</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Dwp_configEO> GetByJPTotalRatio(double jPTotalRatio, string sort_, TransactionManager tm_)
		{
			return GetByJPTotalRatio(jPTotalRatio, 0, sort_, tm_);
		}
		public async Task<List<Dwp_configEO>> GetByJPTotalRatioAsync(double jPTotalRatio, string sort_, TransactionManager tm_)
		{
			return await GetByJPTotalRatioAsync(jPTotalRatio, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 JPTotalRatio（字段） 查询
		/// </summary>
		/// /// <param name = "jPTotalRatio">JP按下注额分配百分比</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Dwp_configEO> GetByJPTotalRatio(double jPTotalRatio, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`JPTotalRatio` = @JPTotalRatio", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@JPTotalRatio", jPTotalRatio, MySqlDbType.Double));
			return Database.ExecSqlList(sql_, paras_, tm_, Dwp_configEO.MapDataReader);
		}
		public async Task<List<Dwp_configEO>> GetByJPTotalRatioAsync(double jPTotalRatio, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`JPTotalRatio` = @JPTotalRatio", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@JPTotalRatio", jPTotalRatio, MySqlDbType.Double));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Dwp_configEO.MapDataReader);
		}
		#endregion // GetByJPTotalRatio
		#region GetByJPInventedAmount
		
		/// <summary>
		/// 按 JPInventedAmount（字段） 查询
		/// </summary>
		/// /// <param name = "jPInventedAmount">JP虚拟值</param>
		/// <return>实体对象集合</return>
		public List<Dwp_configEO> GetByJPInventedAmount(long jPInventedAmount)
		{
			return GetByJPInventedAmount(jPInventedAmount, 0, string.Empty, null);
		}
		public async Task<List<Dwp_configEO>> GetByJPInventedAmountAsync(long jPInventedAmount)
		{
			return await GetByJPInventedAmountAsync(jPInventedAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 JPInventedAmount（字段） 查询
		/// </summary>
		/// /// <param name = "jPInventedAmount">JP虚拟值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Dwp_configEO> GetByJPInventedAmount(long jPInventedAmount, TransactionManager tm_)
		{
			return GetByJPInventedAmount(jPInventedAmount, 0, string.Empty, tm_);
		}
		public async Task<List<Dwp_configEO>> GetByJPInventedAmountAsync(long jPInventedAmount, TransactionManager tm_)
		{
			return await GetByJPInventedAmountAsync(jPInventedAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 JPInventedAmount（字段） 查询
		/// </summary>
		/// /// <param name = "jPInventedAmount">JP虚拟值</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Dwp_configEO> GetByJPInventedAmount(long jPInventedAmount, int top_)
		{
			return GetByJPInventedAmount(jPInventedAmount, top_, string.Empty, null);
		}
		public async Task<List<Dwp_configEO>> GetByJPInventedAmountAsync(long jPInventedAmount, int top_)
		{
			return await GetByJPInventedAmountAsync(jPInventedAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 JPInventedAmount（字段） 查询
		/// </summary>
		/// /// <param name = "jPInventedAmount">JP虚拟值</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Dwp_configEO> GetByJPInventedAmount(long jPInventedAmount, int top_, TransactionManager tm_)
		{
			return GetByJPInventedAmount(jPInventedAmount, top_, string.Empty, tm_);
		}
		public async Task<List<Dwp_configEO>> GetByJPInventedAmountAsync(long jPInventedAmount, int top_, TransactionManager tm_)
		{
			return await GetByJPInventedAmountAsync(jPInventedAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 JPInventedAmount（字段） 查询
		/// </summary>
		/// /// <param name = "jPInventedAmount">JP虚拟值</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Dwp_configEO> GetByJPInventedAmount(long jPInventedAmount, string sort_)
		{
			return GetByJPInventedAmount(jPInventedAmount, 0, sort_, null);
		}
		public async Task<List<Dwp_configEO>> GetByJPInventedAmountAsync(long jPInventedAmount, string sort_)
		{
			return await GetByJPInventedAmountAsync(jPInventedAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 JPInventedAmount（字段） 查询
		/// </summary>
		/// /// <param name = "jPInventedAmount">JP虚拟值</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Dwp_configEO> GetByJPInventedAmount(long jPInventedAmount, string sort_, TransactionManager tm_)
		{
			return GetByJPInventedAmount(jPInventedAmount, 0, sort_, tm_);
		}
		public async Task<List<Dwp_configEO>> GetByJPInventedAmountAsync(long jPInventedAmount, string sort_, TransactionManager tm_)
		{
			return await GetByJPInventedAmountAsync(jPInventedAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 JPInventedAmount（字段） 查询
		/// </summary>
		/// /// <param name = "jPInventedAmount">JP虚拟值</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Dwp_configEO> GetByJPInventedAmount(long jPInventedAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`JPInventedAmount` = @JPInventedAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@JPInventedAmount", jPInventedAmount, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Dwp_configEO.MapDataReader);
		}
		public async Task<List<Dwp_configEO>> GetByJPInventedAmountAsync(long jPInventedAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`JPInventedAmount` = @JPInventedAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@JPInventedAmount", jPInventedAmount, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Dwp_configEO.MapDataReader);
		}
		#endregion // GetByJPInventedAmount
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
