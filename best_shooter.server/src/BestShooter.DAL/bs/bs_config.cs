/******************************************************
 * 此代码由代码生成器工具自动生成，请不要修改
 * TinyFx代码生成器核心库版本号：1.0.0.0
 * git: https://github.com/jh98net/TinyFx
 * 文档生成时间：2023-12-09 15: 11:24
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

namespace BestShooter.DAL
{
	#region EO
	/// <summary>
	/// 奖池配置表
	/// 【表 bs_config 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class Bs_configEO : IRowMapper<Bs_configEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public Bs_configEO()
		{
			this.MaxStake = 0;
			this.MaxGoal = 0;
			this.RecDate = DateTime.Now;
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
		/// 进入公共奖池Jackpot比例（值*100）
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 3)]
		public int InPublic { get; set; }
		/// <summary>
		/// 进入个人Jackpot累计值比例（值*100）
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 4)]
		public int InJackpot { get; set; }
		/// <summary>
		/// 进入个人lucky累计值比例（值*100）
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 5)]
		public int InLucky { get; set; }
		/// <summary>
		/// 触发Jackpot抽奖阈值（值*100000）
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 6)]
		public long JackpotCount { get; set; }
		/// <summary>
		/// Jackpot抽奖时扣完税的比例（值*100）
		/// 中奖值乘以这个值就是得到的金额
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 7)]
		public int JackpotRaffleAfterTax { get; set; }
		/// <summary>
		/// 触发Lucky抽奖阈值
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 8)]
		public int LuckyCount { get; set; }
		/// <summary>
		/// 触发累计lucky值的投注金额（值*100000）
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 9)]
		public int LuckyStartBet { get; set; }
		/// <summary>
		/// 最大下注值
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 10)]
		public long MaxStake { get; set; }
		/// <summary>
		/// 进球最大累计值
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 11)]
		public int MaxGoal { get; set; }
		/// <summary>
		/// 创建时间
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 12)]
		public DateTime RecDate { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public Bs_configEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static Bs_configEO MapDataReader(IDataReader reader)
		{
		    Bs_configEO ret = new Bs_configEO();
			ret.OperatorID = reader.ToString("OperatorID");
			ret.OriginalOperatorID = ret.OperatorID;
			ret.CurrencyID = reader.ToString("CurrencyID");
			ret.OriginalCurrencyID = ret.CurrencyID;
			ret.InPublic = reader.ToInt32("InPublic");
			ret.InJackpot = reader.ToInt32("InJackpot");
			ret.InLucky = reader.ToInt32("InLucky");
			ret.JackpotCount = reader.ToInt64("JackpotCount");
			ret.JackpotRaffleAfterTax = reader.ToInt32("JackpotRaffleAfterTax");
			ret.LuckyCount = reader.ToInt32("LuckyCount");
			ret.LuckyStartBet = reader.ToInt32("LuckyStartBet");
			ret.MaxStake = reader.ToInt64("MaxStake");
			ret.MaxGoal = reader.ToInt32("MaxGoal");
			ret.RecDate = reader.ToDateTime("RecDate");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 奖池配置表
	/// 【表 bs_config 的操作类】
	/// </summary>
	[Obsolete]
	public class Bs_configMO : MySqlTableMO<Bs_configEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`bs_config`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public Bs_configMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public Bs_configMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public Bs_configMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(Bs_configEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(Bs_configEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(Bs_configEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`OperatorID`, `CurrencyID`, `InPublic`, `InJackpot`, `InLucky`, `JackpotCount`, `JackpotRaffleAfterTax`, `LuckyCount`, `LuckyStartBet`, `MaxStake`, `MaxGoal`, `RecDate`) VALUE (@OperatorID, @CurrencyID, @InPublic, @InJackpot, @InLucky, @JackpotCount, @JackpotRaffleAfterTax, @LuckyCount, @LuckyStartBet, @MaxStake, @MaxGoal, @RecDate);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", item.OperatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", item.CurrencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@InPublic", item.InPublic, MySqlDbType.Int32),
				Database.CreateInParameter("@InJackpot", item.InJackpot, MySqlDbType.Int32),
				Database.CreateInParameter("@InLucky", item.InLucky, MySqlDbType.Int32),
				Database.CreateInParameter("@JackpotCount", item.JackpotCount, MySqlDbType.Int64),
				Database.CreateInParameter("@JackpotRaffleAfterTax", item.JackpotRaffleAfterTax, MySqlDbType.Int32),
				Database.CreateInParameter("@LuckyCount", item.LuckyCount, MySqlDbType.Int32),
				Database.CreateInParameter("@LuckyStartBet", item.LuckyStartBet, MySqlDbType.Int32),
				Database.CreateInParameter("@MaxStake", item.MaxStake, MySqlDbType.Int64),
				Database.CreateInParameter("@MaxGoal", item.MaxGoal, MySqlDbType.Int32),
				Database.CreateInParameter("@RecDate", item.RecDate, MySqlDbType.DateTime),
			};
		}
		public int AddByBatch(IEnumerable<Bs_configEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<Bs_configEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<Bs_configEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`OperatorID`, `CurrencyID`, `InPublic`, `InJackpot`, `InLucky`, `JackpotCount`, `JackpotRaffleAfterTax`, `LuckyCount`, `LuckyStartBet`, `MaxStake`, `MaxGoal`, `RecDate`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"('{item.OperatorID}','{item.CurrencyID}',{item.InPublic},{item.InJackpot},{item.InLucky},{item.JackpotCount},{item.JackpotRaffleAfterTax},{item.LuckyCount},{item.LuckyStartBet},{item.MaxStake},{item.MaxGoal},'{item.RecDate.ToString("yyyy-MM-dd HH:mm:ss")}'),");
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
		public int Remove(Bs_configEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.OperatorID, item.CurrencyID, tm_);
		}
		public async Task<int> RemoveAsync(Bs_configEO item, TransactionManager tm_ = null)
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
		#region RemoveByInPublic
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "inPublic">进入公共奖池Jackpot比例（值*100）</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByInPublic(int inPublic, TransactionManager tm_ = null)
		{
			RepairRemoveByInPublicData(inPublic, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByInPublicAsync(int inPublic, TransactionManager tm_ = null)
		{
			RepairRemoveByInPublicData(inPublic, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByInPublicData(int inPublic, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `InPublic` = @InPublic";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@InPublic", inPublic, MySqlDbType.Int32));
		}
		#endregion // RemoveByInPublic
		#region RemoveByInJackpot
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "inJackpot">进入个人Jackpot累计值比例（值*100）</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByInJackpot(int inJackpot, TransactionManager tm_ = null)
		{
			RepairRemoveByInJackpotData(inJackpot, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByInJackpotAsync(int inJackpot, TransactionManager tm_ = null)
		{
			RepairRemoveByInJackpotData(inJackpot, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByInJackpotData(int inJackpot, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `InJackpot` = @InJackpot";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@InJackpot", inJackpot, MySqlDbType.Int32));
		}
		#endregion // RemoveByInJackpot
		#region RemoveByInLucky
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "inLucky">进入个人lucky累计值比例（值*100）</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByInLucky(int inLucky, TransactionManager tm_ = null)
		{
			RepairRemoveByInLuckyData(inLucky, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByInLuckyAsync(int inLucky, TransactionManager tm_ = null)
		{
			RepairRemoveByInLuckyData(inLucky, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByInLuckyData(int inLucky, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `InLucky` = @InLucky";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@InLucky", inLucky, MySqlDbType.Int32));
		}
		#endregion // RemoveByInLucky
		#region RemoveByJackpotCount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "jackpotCount">触发Jackpot抽奖阈值（值*100000）</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByJackpotCount(long jackpotCount, TransactionManager tm_ = null)
		{
			RepairRemoveByJackpotCountData(jackpotCount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByJackpotCountAsync(long jackpotCount, TransactionManager tm_ = null)
		{
			RepairRemoveByJackpotCountData(jackpotCount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByJackpotCountData(long jackpotCount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `JackpotCount` = @JackpotCount";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@JackpotCount", jackpotCount, MySqlDbType.Int64));
		}
		#endregion // RemoveByJackpotCount
		#region RemoveByJackpotRaffleAfterTax
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "jackpotRaffleAfterTax">Jackpot抽奖时扣完税的比例（值*100）</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByJackpotRaffleAfterTax(int jackpotRaffleAfterTax, TransactionManager tm_ = null)
		{
			RepairRemoveByJackpotRaffleAfterTaxData(jackpotRaffleAfterTax, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByJackpotRaffleAfterTaxAsync(int jackpotRaffleAfterTax, TransactionManager tm_ = null)
		{
			RepairRemoveByJackpotRaffleAfterTaxData(jackpotRaffleAfterTax, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByJackpotRaffleAfterTaxData(int jackpotRaffleAfterTax, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `JackpotRaffleAfterTax` = @JackpotRaffleAfterTax";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@JackpotRaffleAfterTax", jackpotRaffleAfterTax, MySqlDbType.Int32));
		}
		#endregion // RemoveByJackpotRaffleAfterTax
		#region RemoveByLuckyCount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "luckyCount">触发Lucky抽奖阈值</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByLuckyCount(int luckyCount, TransactionManager tm_ = null)
		{
			RepairRemoveByLuckyCountData(luckyCount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByLuckyCountAsync(int luckyCount, TransactionManager tm_ = null)
		{
			RepairRemoveByLuckyCountData(luckyCount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByLuckyCountData(int luckyCount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `LuckyCount` = @LuckyCount";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@LuckyCount", luckyCount, MySqlDbType.Int32));
		}
		#endregion // RemoveByLuckyCount
		#region RemoveByLuckyStartBet
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "luckyStartBet">触发累计lucky值的投注金额（值*100000）</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByLuckyStartBet(int luckyStartBet, TransactionManager tm_ = null)
		{
			RepairRemoveByLuckyStartBetData(luckyStartBet, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByLuckyStartBetAsync(int luckyStartBet, TransactionManager tm_ = null)
		{
			RepairRemoveByLuckyStartBetData(luckyStartBet, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByLuckyStartBetData(int luckyStartBet, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `LuckyStartBet` = @LuckyStartBet";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@LuckyStartBet", luckyStartBet, MySqlDbType.Int32));
		}
		#endregion // RemoveByLuckyStartBet
		#region RemoveByMaxStake
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "maxStake">最大下注值</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByMaxStake(long maxStake, TransactionManager tm_ = null)
		{
			RepairRemoveByMaxStakeData(maxStake, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByMaxStakeAsync(long maxStake, TransactionManager tm_ = null)
		{
			RepairRemoveByMaxStakeData(maxStake, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByMaxStakeData(long maxStake, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `MaxStake` = @MaxStake";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@MaxStake", maxStake, MySqlDbType.Int64));
		}
		#endregion // RemoveByMaxStake
		#region RemoveByMaxGoal
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "maxGoal">进球最大累计值</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByMaxGoal(int maxGoal, TransactionManager tm_ = null)
		{
			RepairRemoveByMaxGoalData(maxGoal, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByMaxGoalAsync(int maxGoal, TransactionManager tm_ = null)
		{
			RepairRemoveByMaxGoalData(maxGoal, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByMaxGoalData(int maxGoal, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `MaxGoal` = @MaxGoal";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@MaxGoal", maxGoal, MySqlDbType.Int32));
		}
		#endregion // RemoveByMaxGoal
		#region RemoveByRecDate
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "recDate">创建时间</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByRecDate(DateTime recDate, TransactionManager tm_ = null)
		{
			RepairRemoveByRecDateData(recDate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByRecDateAsync(DateTime recDate, TransactionManager tm_ = null)
		{
			RepairRemoveByRecDateData(recDate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByRecDateData(DateTime recDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `RecDate` = @RecDate";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
		}
		#endregion // RemoveByRecDate
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
		public int Put(Bs_configEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(Bs_configEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(Bs_configEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `OperatorID` = @OperatorID, `CurrencyID` = @CurrencyID, `InPublic` = @InPublic, `InJackpot` = @InJackpot, `InLucky` = @InLucky, `JackpotCount` = @JackpotCount, `JackpotRaffleAfterTax` = @JackpotRaffleAfterTax, `LuckyCount` = @LuckyCount, `LuckyStartBet` = @LuckyStartBet, `MaxStake` = @MaxStake, `MaxGoal` = @MaxGoal WHERE `OperatorID` = @OperatorID_Original AND `CurrencyID` = @CurrencyID_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", item.OperatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", item.CurrencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@InPublic", item.InPublic, MySqlDbType.Int32),
				Database.CreateInParameter("@InJackpot", item.InJackpot, MySqlDbType.Int32),
				Database.CreateInParameter("@InLucky", item.InLucky, MySqlDbType.Int32),
				Database.CreateInParameter("@JackpotCount", item.JackpotCount, MySqlDbType.Int64),
				Database.CreateInParameter("@JackpotRaffleAfterTax", item.JackpotRaffleAfterTax, MySqlDbType.Int32),
				Database.CreateInParameter("@LuckyCount", item.LuckyCount, MySqlDbType.Int32),
				Database.CreateInParameter("@LuckyStartBet", item.LuckyStartBet, MySqlDbType.Int32),
				Database.CreateInParameter("@MaxStake", item.MaxStake, MySqlDbType.Int64),
				Database.CreateInParameter("@MaxGoal", item.MaxGoal, MySqlDbType.Int32),
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
		public int Put(IEnumerable<Bs_configEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<Bs_configEO> items, TransactionManager tm_ = null)
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
		#region PutInPublic
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// /// <param name = "inPublic">进入公共奖池Jackpot比例（值*100）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutInPublicByPK(string operatorID, string currencyID, int inPublic, TransactionManager tm_ = null)
		{
			RepairPutInPublicByPKData(operatorID, currencyID, inPublic, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutInPublicByPKAsync(string operatorID, string currencyID, int inPublic, TransactionManager tm_ = null)
		{
			RepairPutInPublicByPKData(operatorID, currencyID, inPublic, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutInPublicByPKData(string operatorID, string currencyID, int inPublic, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `InPublic` = @InPublic  WHERE `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@InPublic", inPublic, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "inPublic">进入公共奖池Jackpot比例（值*100）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutInPublic(int inPublic, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `InPublic` = @InPublic";
			var parameter_ = Database.CreateInParameter("@InPublic", inPublic, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutInPublicAsync(int inPublic, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `InPublic` = @InPublic";
			var parameter_ = Database.CreateInParameter("@InPublic", inPublic, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutInPublic
		#region PutInJackpot
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// /// <param name = "inJackpot">进入个人Jackpot累计值比例（值*100）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutInJackpotByPK(string operatorID, string currencyID, int inJackpot, TransactionManager tm_ = null)
		{
			RepairPutInJackpotByPKData(operatorID, currencyID, inJackpot, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutInJackpotByPKAsync(string operatorID, string currencyID, int inJackpot, TransactionManager tm_ = null)
		{
			RepairPutInJackpotByPKData(operatorID, currencyID, inJackpot, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutInJackpotByPKData(string operatorID, string currencyID, int inJackpot, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `InJackpot` = @InJackpot  WHERE `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@InJackpot", inJackpot, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "inJackpot">进入个人Jackpot累计值比例（值*100）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutInJackpot(int inJackpot, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `InJackpot` = @InJackpot";
			var parameter_ = Database.CreateInParameter("@InJackpot", inJackpot, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutInJackpotAsync(int inJackpot, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `InJackpot` = @InJackpot";
			var parameter_ = Database.CreateInParameter("@InJackpot", inJackpot, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutInJackpot
		#region PutInLucky
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// /// <param name = "inLucky">进入个人lucky累计值比例（值*100）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutInLuckyByPK(string operatorID, string currencyID, int inLucky, TransactionManager tm_ = null)
		{
			RepairPutInLuckyByPKData(operatorID, currencyID, inLucky, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutInLuckyByPKAsync(string operatorID, string currencyID, int inLucky, TransactionManager tm_ = null)
		{
			RepairPutInLuckyByPKData(operatorID, currencyID, inLucky, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutInLuckyByPKData(string operatorID, string currencyID, int inLucky, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `InLucky` = @InLucky  WHERE `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@InLucky", inLucky, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "inLucky">进入个人lucky累计值比例（值*100）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutInLucky(int inLucky, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `InLucky` = @InLucky";
			var parameter_ = Database.CreateInParameter("@InLucky", inLucky, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutInLuckyAsync(int inLucky, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `InLucky` = @InLucky";
			var parameter_ = Database.CreateInParameter("@InLucky", inLucky, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutInLucky
		#region PutJackpotCount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// /// <param name = "jackpotCount">触发Jackpot抽奖阈值（值*100000）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutJackpotCountByPK(string operatorID, string currencyID, long jackpotCount, TransactionManager tm_ = null)
		{
			RepairPutJackpotCountByPKData(operatorID, currencyID, jackpotCount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutJackpotCountByPKAsync(string operatorID, string currencyID, long jackpotCount, TransactionManager tm_ = null)
		{
			RepairPutJackpotCountByPKData(operatorID, currencyID, jackpotCount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutJackpotCountByPKData(string operatorID, string currencyID, long jackpotCount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `JackpotCount` = @JackpotCount  WHERE `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@JackpotCount", jackpotCount, MySqlDbType.Int64),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "jackpotCount">触发Jackpot抽奖阈值（值*100000）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutJackpotCount(long jackpotCount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `JackpotCount` = @JackpotCount";
			var parameter_ = Database.CreateInParameter("@JackpotCount", jackpotCount, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutJackpotCountAsync(long jackpotCount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `JackpotCount` = @JackpotCount";
			var parameter_ = Database.CreateInParameter("@JackpotCount", jackpotCount, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutJackpotCount
		#region PutJackpotRaffleAfterTax
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// /// <param name = "jackpotRaffleAfterTax">Jackpot抽奖时扣完税的比例（值*100）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutJackpotRaffleAfterTaxByPK(string operatorID, string currencyID, int jackpotRaffleAfterTax, TransactionManager tm_ = null)
		{
			RepairPutJackpotRaffleAfterTaxByPKData(operatorID, currencyID, jackpotRaffleAfterTax, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutJackpotRaffleAfterTaxByPKAsync(string operatorID, string currencyID, int jackpotRaffleAfterTax, TransactionManager tm_ = null)
		{
			RepairPutJackpotRaffleAfterTaxByPKData(operatorID, currencyID, jackpotRaffleAfterTax, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutJackpotRaffleAfterTaxByPKData(string operatorID, string currencyID, int jackpotRaffleAfterTax, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `JackpotRaffleAfterTax` = @JackpotRaffleAfterTax  WHERE `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@JackpotRaffleAfterTax", jackpotRaffleAfterTax, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "jackpotRaffleAfterTax">Jackpot抽奖时扣完税的比例（值*100）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutJackpotRaffleAfterTax(int jackpotRaffleAfterTax, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `JackpotRaffleAfterTax` = @JackpotRaffleAfterTax";
			var parameter_ = Database.CreateInParameter("@JackpotRaffleAfterTax", jackpotRaffleAfterTax, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutJackpotRaffleAfterTaxAsync(int jackpotRaffleAfterTax, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `JackpotRaffleAfterTax` = @JackpotRaffleAfterTax";
			var parameter_ = Database.CreateInParameter("@JackpotRaffleAfterTax", jackpotRaffleAfterTax, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutJackpotRaffleAfterTax
		#region PutLuckyCount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// /// <param name = "luckyCount">触发Lucky抽奖阈值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutLuckyCountByPK(string operatorID, string currencyID, int luckyCount, TransactionManager tm_ = null)
		{
			RepairPutLuckyCountByPKData(operatorID, currencyID, luckyCount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutLuckyCountByPKAsync(string operatorID, string currencyID, int luckyCount, TransactionManager tm_ = null)
		{
			RepairPutLuckyCountByPKData(operatorID, currencyID, luckyCount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutLuckyCountByPKData(string operatorID, string currencyID, int luckyCount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `LuckyCount` = @LuckyCount  WHERE `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LuckyCount", luckyCount, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "luckyCount">触发Lucky抽奖阈值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutLuckyCount(int luckyCount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `LuckyCount` = @LuckyCount";
			var parameter_ = Database.CreateInParameter("@LuckyCount", luckyCount, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutLuckyCountAsync(int luckyCount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `LuckyCount` = @LuckyCount";
			var parameter_ = Database.CreateInParameter("@LuckyCount", luckyCount, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutLuckyCount
		#region PutLuckyStartBet
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// /// <param name = "luckyStartBet">触发累计lucky值的投注金额（值*100000）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutLuckyStartBetByPK(string operatorID, string currencyID, int luckyStartBet, TransactionManager tm_ = null)
		{
			RepairPutLuckyStartBetByPKData(operatorID, currencyID, luckyStartBet, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutLuckyStartBetByPKAsync(string operatorID, string currencyID, int luckyStartBet, TransactionManager tm_ = null)
		{
			RepairPutLuckyStartBetByPKData(operatorID, currencyID, luckyStartBet, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutLuckyStartBetByPKData(string operatorID, string currencyID, int luckyStartBet, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `LuckyStartBet` = @LuckyStartBet  WHERE `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LuckyStartBet", luckyStartBet, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "luckyStartBet">触发累计lucky值的投注金额（值*100000）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutLuckyStartBet(int luckyStartBet, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `LuckyStartBet` = @LuckyStartBet";
			var parameter_ = Database.CreateInParameter("@LuckyStartBet", luckyStartBet, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutLuckyStartBetAsync(int luckyStartBet, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `LuckyStartBet` = @LuckyStartBet";
			var parameter_ = Database.CreateInParameter("@LuckyStartBet", luckyStartBet, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutLuckyStartBet
		#region PutMaxStake
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// /// <param name = "maxStake">最大下注值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutMaxStakeByPK(string operatorID, string currencyID, long maxStake, TransactionManager tm_ = null)
		{
			RepairPutMaxStakeByPKData(operatorID, currencyID, maxStake, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutMaxStakeByPKAsync(string operatorID, string currencyID, long maxStake, TransactionManager tm_ = null)
		{
			RepairPutMaxStakeByPKData(operatorID, currencyID, maxStake, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutMaxStakeByPKData(string operatorID, string currencyID, long maxStake, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `MaxStake` = @MaxStake  WHERE `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MaxStake", maxStake, MySqlDbType.Int64),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "maxStake">最大下注值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutMaxStake(long maxStake, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `MaxStake` = @MaxStake";
			var parameter_ = Database.CreateInParameter("@MaxStake", maxStake, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutMaxStakeAsync(long maxStake, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `MaxStake` = @MaxStake";
			var parameter_ = Database.CreateInParameter("@MaxStake", maxStake, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutMaxStake
		#region PutMaxGoal
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// /// <param name = "maxGoal">进球最大累计值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutMaxGoalByPK(string operatorID, string currencyID, int maxGoal, TransactionManager tm_ = null)
		{
			RepairPutMaxGoalByPKData(operatorID, currencyID, maxGoal, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutMaxGoalByPKAsync(string operatorID, string currencyID, int maxGoal, TransactionManager tm_ = null)
		{
			RepairPutMaxGoalByPKData(operatorID, currencyID, maxGoal, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutMaxGoalByPKData(string operatorID, string currencyID, int maxGoal, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `MaxGoal` = @MaxGoal  WHERE `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MaxGoal", maxGoal, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "maxGoal">进球最大累计值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutMaxGoal(int maxGoal, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `MaxGoal` = @MaxGoal";
			var parameter_ = Database.CreateInParameter("@MaxGoal", maxGoal, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutMaxGoalAsync(int maxGoal, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `MaxGoal` = @MaxGoal";
			var parameter_ = Database.CreateInParameter("@MaxGoal", maxGoal, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutMaxGoal
		#region PutRecDate
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// /// <param name = "recDate">创建时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRecDateByPK(string operatorID, string currencyID, DateTime recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(operatorID, currencyID, recDate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutRecDateByPKAsync(string operatorID, string currencyID, DateTime recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(operatorID, currencyID, recDate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutRecDateByPKData(string operatorID, string currencyID, DateTime recDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `RecDate` = @RecDate  WHERE `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "recDate">创建时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRecDate(DateTime recDate, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `RecDate` = @RecDate";
			var parameter_ = Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutRecDateAsync(DateTime recDate, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `RecDate` = @RecDate";
			var parameter_ = Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutRecDate
		#endregion // PutXXX
		#endregion // Put
	   
		#region Set
		
		/// <summary>
		/// 插入或者更新数据
		/// </summary>
		/// <param name = "item">要更新的实体对象</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>true:插入操作；false:更新操作</return>
		public bool Set(Bs_configEO item, TransactionManager tm = null)
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
		public async Task<bool> SetAsync(Bs_configEO item, TransactionManager tm = null)
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
		public Bs_configEO GetByPK(string operatorID, string currencyID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(operatorID, currencyID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, Bs_configEO.MapDataReader);
		}
		public async Task<Bs_configEO> GetByPKAsync(string operatorID, string currencyID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(operatorID, currencyID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Bs_configEO.MapDataReader);
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
		/// 按主键查询 InPublic（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetInPublicByPK(string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`InPublic`", "`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		public async Task<int> GetInPublicByPKAsync(string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`InPublic`", "`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 InJackpot（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetInJackpotByPK(string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`InJackpot`", "`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		public async Task<int> GetInJackpotByPKAsync(string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`InJackpot`", "`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 InLucky（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetInLuckyByPK(string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`InLucky`", "`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		public async Task<int> GetInLuckyByPKAsync(string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`InLucky`", "`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 JackpotCount（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetJackpotCountByPK(string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`JackpotCount`", "`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		public async Task<long> GetJackpotCountByPKAsync(string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`JackpotCount`", "`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 JackpotRaffleAfterTax（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetJackpotRaffleAfterTaxByPK(string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`JackpotRaffleAfterTax`", "`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		public async Task<int> GetJackpotRaffleAfterTaxByPKAsync(string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`JackpotRaffleAfterTax`", "`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 LuckyCount（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetLuckyCountByPK(string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`LuckyCount`", "`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		public async Task<int> GetLuckyCountByPKAsync(string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`LuckyCount`", "`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 LuckyStartBet（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetLuckyStartBetByPK(string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`LuckyStartBet`", "`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		public async Task<int> GetLuckyStartBetByPKAsync(string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`LuckyStartBet`", "`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 MaxStake（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetMaxStakeByPK(string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`MaxStake`", "`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		public async Task<long> GetMaxStakeByPKAsync(string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`MaxStake`", "`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 MaxGoal（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetMaxGoalByPK(string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`MaxGoal`", "`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		public async Task<int> GetMaxGoalByPKAsync(string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`MaxGoal`", "`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 RecDate（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime GetRecDateByPK(string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (DateTime)GetScalar("`RecDate`", "`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		public async Task<DateTime> GetRecDateByPKAsync(string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (DateTime)await GetScalarAsync("`RecDate`", "`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByOperatorID
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <return>实体对象集合</return>
		public List<Bs_configEO> GetByOperatorID(string operatorID)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, null);
		}
		public async Task<List<Bs_configEO>> GetByOperatorIDAsync(string operatorID)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_configEO> GetByOperatorID(string operatorID, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, tm_);
		}
		public async Task<List<Bs_configEO>> GetByOperatorIDAsync(string operatorID, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Bs_configEO> GetByOperatorID(string operatorID, int top_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, null);
		}
		public async Task<List<Bs_configEO>> GetByOperatorIDAsync(string operatorID, int top_)
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
		public List<Bs_configEO> GetByOperatorID(string operatorID, int top_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, tm_);
		}
		public async Task<List<Bs_configEO>> GetByOperatorIDAsync(string operatorID, int top_, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Bs_configEO> GetByOperatorID(string operatorID, string sort_)
		{
			return GetByOperatorID(operatorID, 0, sort_, null);
		}
		public async Task<List<Bs_configEO>> GetByOperatorIDAsync(string operatorID, string sort_)
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
		public List<Bs_configEO> GetByOperatorID(string operatorID, string sort_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, sort_, tm_);
		}
		public async Task<List<Bs_configEO>> GetByOperatorIDAsync(string operatorID, string sort_, TransactionManager tm_)
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
		public List<Bs_configEO> GetByOperatorID(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorID` = @OperatorID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Bs_configEO.MapDataReader);
		}
		public async Task<List<Bs_configEO>> GetByOperatorIDAsync(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorID` = @OperatorID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Bs_configEO.MapDataReader);
		}
		#endregion // GetByOperatorID
		#region GetByCurrencyID
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// <return>实体对象集合</return>
		public List<Bs_configEO> GetByCurrencyID(string currencyID)
		{
			return GetByCurrencyID(currencyID, 0, string.Empty, null);
		}
		public async Task<List<Bs_configEO>> GetByCurrencyIDAsync(string currencyID)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_configEO> GetByCurrencyID(string currencyID, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, 0, string.Empty, tm_);
		}
		public async Task<List<Bs_configEO>> GetByCurrencyIDAsync(string currencyID, TransactionManager tm_)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Bs_configEO> GetByCurrencyID(string currencyID, int top_)
		{
			return GetByCurrencyID(currencyID, top_, string.Empty, null);
		}
		public async Task<List<Bs_configEO>> GetByCurrencyIDAsync(string currencyID, int top_)
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
		public List<Bs_configEO> GetByCurrencyID(string currencyID, int top_, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, top_, string.Empty, tm_);
		}
		public async Task<List<Bs_configEO>> GetByCurrencyIDAsync(string currencyID, int top_, TransactionManager tm_)
		{
			return await GetByCurrencyIDAsync(currencyID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币编码（ISO 4217大写）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Bs_configEO> GetByCurrencyID(string currencyID, string sort_)
		{
			return GetByCurrencyID(currencyID, 0, sort_, null);
		}
		public async Task<List<Bs_configEO>> GetByCurrencyIDAsync(string currencyID, string sort_)
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
		public List<Bs_configEO> GetByCurrencyID(string currencyID, string sort_, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, 0, sort_, tm_);
		}
		public async Task<List<Bs_configEO>> GetByCurrencyIDAsync(string currencyID, string sort_, TransactionManager tm_)
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
		public List<Bs_configEO> GetByCurrencyID(string currencyID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CurrencyID` = @CurrencyID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Bs_configEO.MapDataReader);
		}
		public async Task<List<Bs_configEO>> GetByCurrencyIDAsync(string currencyID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CurrencyID` = @CurrencyID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Bs_configEO.MapDataReader);
		}
		#endregion // GetByCurrencyID
		#region GetByInPublic
		
		/// <summary>
		/// 按 InPublic（字段） 查询
		/// </summary>
		/// /// <param name = "inPublic">进入公共奖池Jackpot比例（值*100）</param>
		/// <return>实体对象集合</return>
		public List<Bs_configEO> GetByInPublic(int inPublic)
		{
			return GetByInPublic(inPublic, 0, string.Empty, null);
		}
		public async Task<List<Bs_configEO>> GetByInPublicAsync(int inPublic)
		{
			return await GetByInPublicAsync(inPublic, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 InPublic（字段） 查询
		/// </summary>
		/// /// <param name = "inPublic">进入公共奖池Jackpot比例（值*100）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_configEO> GetByInPublic(int inPublic, TransactionManager tm_)
		{
			return GetByInPublic(inPublic, 0, string.Empty, tm_);
		}
		public async Task<List<Bs_configEO>> GetByInPublicAsync(int inPublic, TransactionManager tm_)
		{
			return await GetByInPublicAsync(inPublic, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 InPublic（字段） 查询
		/// </summary>
		/// /// <param name = "inPublic">进入公共奖池Jackpot比例（值*100）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Bs_configEO> GetByInPublic(int inPublic, int top_)
		{
			return GetByInPublic(inPublic, top_, string.Empty, null);
		}
		public async Task<List<Bs_configEO>> GetByInPublicAsync(int inPublic, int top_)
		{
			return await GetByInPublicAsync(inPublic, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 InPublic（字段） 查询
		/// </summary>
		/// /// <param name = "inPublic">进入公共奖池Jackpot比例（值*100）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_configEO> GetByInPublic(int inPublic, int top_, TransactionManager tm_)
		{
			return GetByInPublic(inPublic, top_, string.Empty, tm_);
		}
		public async Task<List<Bs_configEO>> GetByInPublicAsync(int inPublic, int top_, TransactionManager tm_)
		{
			return await GetByInPublicAsync(inPublic, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 InPublic（字段） 查询
		/// </summary>
		/// /// <param name = "inPublic">进入公共奖池Jackpot比例（值*100）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Bs_configEO> GetByInPublic(int inPublic, string sort_)
		{
			return GetByInPublic(inPublic, 0, sort_, null);
		}
		public async Task<List<Bs_configEO>> GetByInPublicAsync(int inPublic, string sort_)
		{
			return await GetByInPublicAsync(inPublic, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 InPublic（字段） 查询
		/// </summary>
		/// /// <param name = "inPublic">进入公共奖池Jackpot比例（值*100）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_configEO> GetByInPublic(int inPublic, string sort_, TransactionManager tm_)
		{
			return GetByInPublic(inPublic, 0, sort_, tm_);
		}
		public async Task<List<Bs_configEO>> GetByInPublicAsync(int inPublic, string sort_, TransactionManager tm_)
		{
			return await GetByInPublicAsync(inPublic, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 InPublic（字段） 查询
		/// </summary>
		/// /// <param name = "inPublic">进入公共奖池Jackpot比例（值*100）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_configEO> GetByInPublic(int inPublic, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`InPublic` = @InPublic", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@InPublic", inPublic, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Bs_configEO.MapDataReader);
		}
		public async Task<List<Bs_configEO>> GetByInPublicAsync(int inPublic, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`InPublic` = @InPublic", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@InPublic", inPublic, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Bs_configEO.MapDataReader);
		}
		#endregion // GetByInPublic
		#region GetByInJackpot
		
		/// <summary>
		/// 按 InJackpot（字段） 查询
		/// </summary>
		/// /// <param name = "inJackpot">进入个人Jackpot累计值比例（值*100）</param>
		/// <return>实体对象集合</return>
		public List<Bs_configEO> GetByInJackpot(int inJackpot)
		{
			return GetByInJackpot(inJackpot, 0, string.Empty, null);
		}
		public async Task<List<Bs_configEO>> GetByInJackpotAsync(int inJackpot)
		{
			return await GetByInJackpotAsync(inJackpot, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 InJackpot（字段） 查询
		/// </summary>
		/// /// <param name = "inJackpot">进入个人Jackpot累计值比例（值*100）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_configEO> GetByInJackpot(int inJackpot, TransactionManager tm_)
		{
			return GetByInJackpot(inJackpot, 0, string.Empty, tm_);
		}
		public async Task<List<Bs_configEO>> GetByInJackpotAsync(int inJackpot, TransactionManager tm_)
		{
			return await GetByInJackpotAsync(inJackpot, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 InJackpot（字段） 查询
		/// </summary>
		/// /// <param name = "inJackpot">进入个人Jackpot累计值比例（值*100）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Bs_configEO> GetByInJackpot(int inJackpot, int top_)
		{
			return GetByInJackpot(inJackpot, top_, string.Empty, null);
		}
		public async Task<List<Bs_configEO>> GetByInJackpotAsync(int inJackpot, int top_)
		{
			return await GetByInJackpotAsync(inJackpot, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 InJackpot（字段） 查询
		/// </summary>
		/// /// <param name = "inJackpot">进入个人Jackpot累计值比例（值*100）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_configEO> GetByInJackpot(int inJackpot, int top_, TransactionManager tm_)
		{
			return GetByInJackpot(inJackpot, top_, string.Empty, tm_);
		}
		public async Task<List<Bs_configEO>> GetByInJackpotAsync(int inJackpot, int top_, TransactionManager tm_)
		{
			return await GetByInJackpotAsync(inJackpot, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 InJackpot（字段） 查询
		/// </summary>
		/// /// <param name = "inJackpot">进入个人Jackpot累计值比例（值*100）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Bs_configEO> GetByInJackpot(int inJackpot, string sort_)
		{
			return GetByInJackpot(inJackpot, 0, sort_, null);
		}
		public async Task<List<Bs_configEO>> GetByInJackpotAsync(int inJackpot, string sort_)
		{
			return await GetByInJackpotAsync(inJackpot, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 InJackpot（字段） 查询
		/// </summary>
		/// /// <param name = "inJackpot">进入个人Jackpot累计值比例（值*100）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_configEO> GetByInJackpot(int inJackpot, string sort_, TransactionManager tm_)
		{
			return GetByInJackpot(inJackpot, 0, sort_, tm_);
		}
		public async Task<List<Bs_configEO>> GetByInJackpotAsync(int inJackpot, string sort_, TransactionManager tm_)
		{
			return await GetByInJackpotAsync(inJackpot, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 InJackpot（字段） 查询
		/// </summary>
		/// /// <param name = "inJackpot">进入个人Jackpot累计值比例（值*100）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_configEO> GetByInJackpot(int inJackpot, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`InJackpot` = @InJackpot", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@InJackpot", inJackpot, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Bs_configEO.MapDataReader);
		}
		public async Task<List<Bs_configEO>> GetByInJackpotAsync(int inJackpot, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`InJackpot` = @InJackpot", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@InJackpot", inJackpot, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Bs_configEO.MapDataReader);
		}
		#endregion // GetByInJackpot
		#region GetByInLucky
		
		/// <summary>
		/// 按 InLucky（字段） 查询
		/// </summary>
		/// /// <param name = "inLucky">进入个人lucky累计值比例（值*100）</param>
		/// <return>实体对象集合</return>
		public List<Bs_configEO> GetByInLucky(int inLucky)
		{
			return GetByInLucky(inLucky, 0, string.Empty, null);
		}
		public async Task<List<Bs_configEO>> GetByInLuckyAsync(int inLucky)
		{
			return await GetByInLuckyAsync(inLucky, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 InLucky（字段） 查询
		/// </summary>
		/// /// <param name = "inLucky">进入个人lucky累计值比例（值*100）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_configEO> GetByInLucky(int inLucky, TransactionManager tm_)
		{
			return GetByInLucky(inLucky, 0, string.Empty, tm_);
		}
		public async Task<List<Bs_configEO>> GetByInLuckyAsync(int inLucky, TransactionManager tm_)
		{
			return await GetByInLuckyAsync(inLucky, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 InLucky（字段） 查询
		/// </summary>
		/// /// <param name = "inLucky">进入个人lucky累计值比例（值*100）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Bs_configEO> GetByInLucky(int inLucky, int top_)
		{
			return GetByInLucky(inLucky, top_, string.Empty, null);
		}
		public async Task<List<Bs_configEO>> GetByInLuckyAsync(int inLucky, int top_)
		{
			return await GetByInLuckyAsync(inLucky, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 InLucky（字段） 查询
		/// </summary>
		/// /// <param name = "inLucky">进入个人lucky累计值比例（值*100）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_configEO> GetByInLucky(int inLucky, int top_, TransactionManager tm_)
		{
			return GetByInLucky(inLucky, top_, string.Empty, tm_);
		}
		public async Task<List<Bs_configEO>> GetByInLuckyAsync(int inLucky, int top_, TransactionManager tm_)
		{
			return await GetByInLuckyAsync(inLucky, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 InLucky（字段） 查询
		/// </summary>
		/// /// <param name = "inLucky">进入个人lucky累计值比例（值*100）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Bs_configEO> GetByInLucky(int inLucky, string sort_)
		{
			return GetByInLucky(inLucky, 0, sort_, null);
		}
		public async Task<List<Bs_configEO>> GetByInLuckyAsync(int inLucky, string sort_)
		{
			return await GetByInLuckyAsync(inLucky, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 InLucky（字段） 查询
		/// </summary>
		/// /// <param name = "inLucky">进入个人lucky累计值比例（值*100）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_configEO> GetByInLucky(int inLucky, string sort_, TransactionManager tm_)
		{
			return GetByInLucky(inLucky, 0, sort_, tm_);
		}
		public async Task<List<Bs_configEO>> GetByInLuckyAsync(int inLucky, string sort_, TransactionManager tm_)
		{
			return await GetByInLuckyAsync(inLucky, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 InLucky（字段） 查询
		/// </summary>
		/// /// <param name = "inLucky">进入个人lucky累计值比例（值*100）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_configEO> GetByInLucky(int inLucky, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`InLucky` = @InLucky", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@InLucky", inLucky, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Bs_configEO.MapDataReader);
		}
		public async Task<List<Bs_configEO>> GetByInLuckyAsync(int inLucky, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`InLucky` = @InLucky", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@InLucky", inLucky, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Bs_configEO.MapDataReader);
		}
		#endregion // GetByInLucky
		#region GetByJackpotCount
		
		/// <summary>
		/// 按 JackpotCount（字段） 查询
		/// </summary>
		/// /// <param name = "jackpotCount">触发Jackpot抽奖阈值（值*100000）</param>
		/// <return>实体对象集合</return>
		public List<Bs_configEO> GetByJackpotCount(long jackpotCount)
		{
			return GetByJackpotCount(jackpotCount, 0, string.Empty, null);
		}
		public async Task<List<Bs_configEO>> GetByJackpotCountAsync(long jackpotCount)
		{
			return await GetByJackpotCountAsync(jackpotCount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 JackpotCount（字段） 查询
		/// </summary>
		/// /// <param name = "jackpotCount">触发Jackpot抽奖阈值（值*100000）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_configEO> GetByJackpotCount(long jackpotCount, TransactionManager tm_)
		{
			return GetByJackpotCount(jackpotCount, 0, string.Empty, tm_);
		}
		public async Task<List<Bs_configEO>> GetByJackpotCountAsync(long jackpotCount, TransactionManager tm_)
		{
			return await GetByJackpotCountAsync(jackpotCount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 JackpotCount（字段） 查询
		/// </summary>
		/// /// <param name = "jackpotCount">触发Jackpot抽奖阈值（值*100000）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Bs_configEO> GetByJackpotCount(long jackpotCount, int top_)
		{
			return GetByJackpotCount(jackpotCount, top_, string.Empty, null);
		}
		public async Task<List<Bs_configEO>> GetByJackpotCountAsync(long jackpotCount, int top_)
		{
			return await GetByJackpotCountAsync(jackpotCount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 JackpotCount（字段） 查询
		/// </summary>
		/// /// <param name = "jackpotCount">触发Jackpot抽奖阈值（值*100000）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_configEO> GetByJackpotCount(long jackpotCount, int top_, TransactionManager tm_)
		{
			return GetByJackpotCount(jackpotCount, top_, string.Empty, tm_);
		}
		public async Task<List<Bs_configEO>> GetByJackpotCountAsync(long jackpotCount, int top_, TransactionManager tm_)
		{
			return await GetByJackpotCountAsync(jackpotCount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 JackpotCount（字段） 查询
		/// </summary>
		/// /// <param name = "jackpotCount">触发Jackpot抽奖阈值（值*100000）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Bs_configEO> GetByJackpotCount(long jackpotCount, string sort_)
		{
			return GetByJackpotCount(jackpotCount, 0, sort_, null);
		}
		public async Task<List<Bs_configEO>> GetByJackpotCountAsync(long jackpotCount, string sort_)
		{
			return await GetByJackpotCountAsync(jackpotCount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 JackpotCount（字段） 查询
		/// </summary>
		/// /// <param name = "jackpotCount">触发Jackpot抽奖阈值（值*100000）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_configEO> GetByJackpotCount(long jackpotCount, string sort_, TransactionManager tm_)
		{
			return GetByJackpotCount(jackpotCount, 0, sort_, tm_);
		}
		public async Task<List<Bs_configEO>> GetByJackpotCountAsync(long jackpotCount, string sort_, TransactionManager tm_)
		{
			return await GetByJackpotCountAsync(jackpotCount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 JackpotCount（字段） 查询
		/// </summary>
		/// /// <param name = "jackpotCount">触发Jackpot抽奖阈值（值*100000）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_configEO> GetByJackpotCount(long jackpotCount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`JackpotCount` = @JackpotCount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@JackpotCount", jackpotCount, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Bs_configEO.MapDataReader);
		}
		public async Task<List<Bs_configEO>> GetByJackpotCountAsync(long jackpotCount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`JackpotCount` = @JackpotCount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@JackpotCount", jackpotCount, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Bs_configEO.MapDataReader);
		}
		#endregion // GetByJackpotCount
		#region GetByJackpotRaffleAfterTax
		
		/// <summary>
		/// 按 JackpotRaffleAfterTax（字段） 查询
		/// </summary>
		/// /// <param name = "jackpotRaffleAfterTax">Jackpot抽奖时扣完税的比例（值*100）</param>
		/// <return>实体对象集合</return>
		public List<Bs_configEO> GetByJackpotRaffleAfterTax(int jackpotRaffleAfterTax)
		{
			return GetByJackpotRaffleAfterTax(jackpotRaffleAfterTax, 0, string.Empty, null);
		}
		public async Task<List<Bs_configEO>> GetByJackpotRaffleAfterTaxAsync(int jackpotRaffleAfterTax)
		{
			return await GetByJackpotRaffleAfterTaxAsync(jackpotRaffleAfterTax, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 JackpotRaffleAfterTax（字段） 查询
		/// </summary>
		/// /// <param name = "jackpotRaffleAfterTax">Jackpot抽奖时扣完税的比例（值*100）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_configEO> GetByJackpotRaffleAfterTax(int jackpotRaffleAfterTax, TransactionManager tm_)
		{
			return GetByJackpotRaffleAfterTax(jackpotRaffleAfterTax, 0, string.Empty, tm_);
		}
		public async Task<List<Bs_configEO>> GetByJackpotRaffleAfterTaxAsync(int jackpotRaffleAfterTax, TransactionManager tm_)
		{
			return await GetByJackpotRaffleAfterTaxAsync(jackpotRaffleAfterTax, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 JackpotRaffleAfterTax（字段） 查询
		/// </summary>
		/// /// <param name = "jackpotRaffleAfterTax">Jackpot抽奖时扣完税的比例（值*100）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Bs_configEO> GetByJackpotRaffleAfterTax(int jackpotRaffleAfterTax, int top_)
		{
			return GetByJackpotRaffleAfterTax(jackpotRaffleAfterTax, top_, string.Empty, null);
		}
		public async Task<List<Bs_configEO>> GetByJackpotRaffleAfterTaxAsync(int jackpotRaffleAfterTax, int top_)
		{
			return await GetByJackpotRaffleAfterTaxAsync(jackpotRaffleAfterTax, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 JackpotRaffleAfterTax（字段） 查询
		/// </summary>
		/// /// <param name = "jackpotRaffleAfterTax">Jackpot抽奖时扣完税的比例（值*100）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_configEO> GetByJackpotRaffleAfterTax(int jackpotRaffleAfterTax, int top_, TransactionManager tm_)
		{
			return GetByJackpotRaffleAfterTax(jackpotRaffleAfterTax, top_, string.Empty, tm_);
		}
		public async Task<List<Bs_configEO>> GetByJackpotRaffleAfterTaxAsync(int jackpotRaffleAfterTax, int top_, TransactionManager tm_)
		{
			return await GetByJackpotRaffleAfterTaxAsync(jackpotRaffleAfterTax, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 JackpotRaffleAfterTax（字段） 查询
		/// </summary>
		/// /// <param name = "jackpotRaffleAfterTax">Jackpot抽奖时扣完税的比例（值*100）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Bs_configEO> GetByJackpotRaffleAfterTax(int jackpotRaffleAfterTax, string sort_)
		{
			return GetByJackpotRaffleAfterTax(jackpotRaffleAfterTax, 0, sort_, null);
		}
		public async Task<List<Bs_configEO>> GetByJackpotRaffleAfterTaxAsync(int jackpotRaffleAfterTax, string sort_)
		{
			return await GetByJackpotRaffleAfterTaxAsync(jackpotRaffleAfterTax, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 JackpotRaffleAfterTax（字段） 查询
		/// </summary>
		/// /// <param name = "jackpotRaffleAfterTax">Jackpot抽奖时扣完税的比例（值*100）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_configEO> GetByJackpotRaffleAfterTax(int jackpotRaffleAfterTax, string sort_, TransactionManager tm_)
		{
			return GetByJackpotRaffleAfterTax(jackpotRaffleAfterTax, 0, sort_, tm_);
		}
		public async Task<List<Bs_configEO>> GetByJackpotRaffleAfterTaxAsync(int jackpotRaffleAfterTax, string sort_, TransactionManager tm_)
		{
			return await GetByJackpotRaffleAfterTaxAsync(jackpotRaffleAfterTax, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 JackpotRaffleAfterTax（字段） 查询
		/// </summary>
		/// /// <param name = "jackpotRaffleAfterTax">Jackpot抽奖时扣完税的比例（值*100）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_configEO> GetByJackpotRaffleAfterTax(int jackpotRaffleAfterTax, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`JackpotRaffleAfterTax` = @JackpotRaffleAfterTax", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@JackpotRaffleAfterTax", jackpotRaffleAfterTax, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Bs_configEO.MapDataReader);
		}
		public async Task<List<Bs_configEO>> GetByJackpotRaffleAfterTaxAsync(int jackpotRaffleAfterTax, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`JackpotRaffleAfterTax` = @JackpotRaffleAfterTax", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@JackpotRaffleAfterTax", jackpotRaffleAfterTax, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Bs_configEO.MapDataReader);
		}
		#endregion // GetByJackpotRaffleAfterTax
		#region GetByLuckyCount
		
		/// <summary>
		/// 按 LuckyCount（字段） 查询
		/// </summary>
		/// /// <param name = "luckyCount">触发Lucky抽奖阈值</param>
		/// <return>实体对象集合</return>
		public List<Bs_configEO> GetByLuckyCount(int luckyCount)
		{
			return GetByLuckyCount(luckyCount, 0, string.Empty, null);
		}
		public async Task<List<Bs_configEO>> GetByLuckyCountAsync(int luckyCount)
		{
			return await GetByLuckyCountAsync(luckyCount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LuckyCount（字段） 查询
		/// </summary>
		/// /// <param name = "luckyCount">触发Lucky抽奖阈值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_configEO> GetByLuckyCount(int luckyCount, TransactionManager tm_)
		{
			return GetByLuckyCount(luckyCount, 0, string.Empty, tm_);
		}
		public async Task<List<Bs_configEO>> GetByLuckyCountAsync(int luckyCount, TransactionManager tm_)
		{
			return await GetByLuckyCountAsync(luckyCount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LuckyCount（字段） 查询
		/// </summary>
		/// /// <param name = "luckyCount">触发Lucky抽奖阈值</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Bs_configEO> GetByLuckyCount(int luckyCount, int top_)
		{
			return GetByLuckyCount(luckyCount, top_, string.Empty, null);
		}
		public async Task<List<Bs_configEO>> GetByLuckyCountAsync(int luckyCount, int top_)
		{
			return await GetByLuckyCountAsync(luckyCount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LuckyCount（字段） 查询
		/// </summary>
		/// /// <param name = "luckyCount">触发Lucky抽奖阈值</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_configEO> GetByLuckyCount(int luckyCount, int top_, TransactionManager tm_)
		{
			return GetByLuckyCount(luckyCount, top_, string.Empty, tm_);
		}
		public async Task<List<Bs_configEO>> GetByLuckyCountAsync(int luckyCount, int top_, TransactionManager tm_)
		{
			return await GetByLuckyCountAsync(luckyCount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LuckyCount（字段） 查询
		/// </summary>
		/// /// <param name = "luckyCount">触发Lucky抽奖阈值</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Bs_configEO> GetByLuckyCount(int luckyCount, string sort_)
		{
			return GetByLuckyCount(luckyCount, 0, sort_, null);
		}
		public async Task<List<Bs_configEO>> GetByLuckyCountAsync(int luckyCount, string sort_)
		{
			return await GetByLuckyCountAsync(luckyCount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 LuckyCount（字段） 查询
		/// </summary>
		/// /// <param name = "luckyCount">触发Lucky抽奖阈值</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_configEO> GetByLuckyCount(int luckyCount, string sort_, TransactionManager tm_)
		{
			return GetByLuckyCount(luckyCount, 0, sort_, tm_);
		}
		public async Task<List<Bs_configEO>> GetByLuckyCountAsync(int luckyCount, string sort_, TransactionManager tm_)
		{
			return await GetByLuckyCountAsync(luckyCount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 LuckyCount（字段） 查询
		/// </summary>
		/// /// <param name = "luckyCount">触发Lucky抽奖阈值</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_configEO> GetByLuckyCount(int luckyCount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`LuckyCount` = @LuckyCount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@LuckyCount", luckyCount, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Bs_configEO.MapDataReader);
		}
		public async Task<List<Bs_configEO>> GetByLuckyCountAsync(int luckyCount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`LuckyCount` = @LuckyCount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@LuckyCount", luckyCount, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Bs_configEO.MapDataReader);
		}
		#endregion // GetByLuckyCount
		#region GetByLuckyStartBet
		
		/// <summary>
		/// 按 LuckyStartBet（字段） 查询
		/// </summary>
		/// /// <param name = "luckyStartBet">触发累计lucky值的投注金额（值*100000）</param>
		/// <return>实体对象集合</return>
		public List<Bs_configEO> GetByLuckyStartBet(int luckyStartBet)
		{
			return GetByLuckyStartBet(luckyStartBet, 0, string.Empty, null);
		}
		public async Task<List<Bs_configEO>> GetByLuckyStartBetAsync(int luckyStartBet)
		{
			return await GetByLuckyStartBetAsync(luckyStartBet, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LuckyStartBet（字段） 查询
		/// </summary>
		/// /// <param name = "luckyStartBet">触发累计lucky值的投注金额（值*100000）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_configEO> GetByLuckyStartBet(int luckyStartBet, TransactionManager tm_)
		{
			return GetByLuckyStartBet(luckyStartBet, 0, string.Empty, tm_);
		}
		public async Task<List<Bs_configEO>> GetByLuckyStartBetAsync(int luckyStartBet, TransactionManager tm_)
		{
			return await GetByLuckyStartBetAsync(luckyStartBet, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LuckyStartBet（字段） 查询
		/// </summary>
		/// /// <param name = "luckyStartBet">触发累计lucky值的投注金额（值*100000）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Bs_configEO> GetByLuckyStartBet(int luckyStartBet, int top_)
		{
			return GetByLuckyStartBet(luckyStartBet, top_, string.Empty, null);
		}
		public async Task<List<Bs_configEO>> GetByLuckyStartBetAsync(int luckyStartBet, int top_)
		{
			return await GetByLuckyStartBetAsync(luckyStartBet, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LuckyStartBet（字段） 查询
		/// </summary>
		/// /// <param name = "luckyStartBet">触发累计lucky值的投注金额（值*100000）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_configEO> GetByLuckyStartBet(int luckyStartBet, int top_, TransactionManager tm_)
		{
			return GetByLuckyStartBet(luckyStartBet, top_, string.Empty, tm_);
		}
		public async Task<List<Bs_configEO>> GetByLuckyStartBetAsync(int luckyStartBet, int top_, TransactionManager tm_)
		{
			return await GetByLuckyStartBetAsync(luckyStartBet, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LuckyStartBet（字段） 查询
		/// </summary>
		/// /// <param name = "luckyStartBet">触发累计lucky值的投注金额（值*100000）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Bs_configEO> GetByLuckyStartBet(int luckyStartBet, string sort_)
		{
			return GetByLuckyStartBet(luckyStartBet, 0, sort_, null);
		}
		public async Task<List<Bs_configEO>> GetByLuckyStartBetAsync(int luckyStartBet, string sort_)
		{
			return await GetByLuckyStartBetAsync(luckyStartBet, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 LuckyStartBet（字段） 查询
		/// </summary>
		/// /// <param name = "luckyStartBet">触发累计lucky值的投注金额（值*100000）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_configEO> GetByLuckyStartBet(int luckyStartBet, string sort_, TransactionManager tm_)
		{
			return GetByLuckyStartBet(luckyStartBet, 0, sort_, tm_);
		}
		public async Task<List<Bs_configEO>> GetByLuckyStartBetAsync(int luckyStartBet, string sort_, TransactionManager tm_)
		{
			return await GetByLuckyStartBetAsync(luckyStartBet, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 LuckyStartBet（字段） 查询
		/// </summary>
		/// /// <param name = "luckyStartBet">触发累计lucky值的投注金额（值*100000）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_configEO> GetByLuckyStartBet(int luckyStartBet, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`LuckyStartBet` = @LuckyStartBet", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@LuckyStartBet", luckyStartBet, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Bs_configEO.MapDataReader);
		}
		public async Task<List<Bs_configEO>> GetByLuckyStartBetAsync(int luckyStartBet, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`LuckyStartBet` = @LuckyStartBet", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@LuckyStartBet", luckyStartBet, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Bs_configEO.MapDataReader);
		}
		#endregion // GetByLuckyStartBet
		#region GetByMaxStake
		
		/// <summary>
		/// 按 MaxStake（字段） 查询
		/// </summary>
		/// /// <param name = "maxStake">最大下注值</param>
		/// <return>实体对象集合</return>
		public List<Bs_configEO> GetByMaxStake(long maxStake)
		{
			return GetByMaxStake(maxStake, 0, string.Empty, null);
		}
		public async Task<List<Bs_configEO>> GetByMaxStakeAsync(long maxStake)
		{
			return await GetByMaxStakeAsync(maxStake, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 MaxStake（字段） 查询
		/// </summary>
		/// /// <param name = "maxStake">最大下注值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_configEO> GetByMaxStake(long maxStake, TransactionManager tm_)
		{
			return GetByMaxStake(maxStake, 0, string.Empty, tm_);
		}
		public async Task<List<Bs_configEO>> GetByMaxStakeAsync(long maxStake, TransactionManager tm_)
		{
			return await GetByMaxStakeAsync(maxStake, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 MaxStake（字段） 查询
		/// </summary>
		/// /// <param name = "maxStake">最大下注值</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Bs_configEO> GetByMaxStake(long maxStake, int top_)
		{
			return GetByMaxStake(maxStake, top_, string.Empty, null);
		}
		public async Task<List<Bs_configEO>> GetByMaxStakeAsync(long maxStake, int top_)
		{
			return await GetByMaxStakeAsync(maxStake, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 MaxStake（字段） 查询
		/// </summary>
		/// /// <param name = "maxStake">最大下注值</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_configEO> GetByMaxStake(long maxStake, int top_, TransactionManager tm_)
		{
			return GetByMaxStake(maxStake, top_, string.Empty, tm_);
		}
		public async Task<List<Bs_configEO>> GetByMaxStakeAsync(long maxStake, int top_, TransactionManager tm_)
		{
			return await GetByMaxStakeAsync(maxStake, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 MaxStake（字段） 查询
		/// </summary>
		/// /// <param name = "maxStake">最大下注值</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Bs_configEO> GetByMaxStake(long maxStake, string sort_)
		{
			return GetByMaxStake(maxStake, 0, sort_, null);
		}
		public async Task<List<Bs_configEO>> GetByMaxStakeAsync(long maxStake, string sort_)
		{
			return await GetByMaxStakeAsync(maxStake, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 MaxStake（字段） 查询
		/// </summary>
		/// /// <param name = "maxStake">最大下注值</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_configEO> GetByMaxStake(long maxStake, string sort_, TransactionManager tm_)
		{
			return GetByMaxStake(maxStake, 0, sort_, tm_);
		}
		public async Task<List<Bs_configEO>> GetByMaxStakeAsync(long maxStake, string sort_, TransactionManager tm_)
		{
			return await GetByMaxStakeAsync(maxStake, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 MaxStake（字段） 查询
		/// </summary>
		/// /// <param name = "maxStake">最大下注值</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_configEO> GetByMaxStake(long maxStake, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`MaxStake` = @MaxStake", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@MaxStake", maxStake, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Bs_configEO.MapDataReader);
		}
		public async Task<List<Bs_configEO>> GetByMaxStakeAsync(long maxStake, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`MaxStake` = @MaxStake", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@MaxStake", maxStake, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Bs_configEO.MapDataReader);
		}
		#endregion // GetByMaxStake
		#region GetByMaxGoal
		
		/// <summary>
		/// 按 MaxGoal（字段） 查询
		/// </summary>
		/// /// <param name = "maxGoal">进球最大累计值</param>
		/// <return>实体对象集合</return>
		public List<Bs_configEO> GetByMaxGoal(int maxGoal)
		{
			return GetByMaxGoal(maxGoal, 0, string.Empty, null);
		}
		public async Task<List<Bs_configEO>> GetByMaxGoalAsync(int maxGoal)
		{
			return await GetByMaxGoalAsync(maxGoal, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 MaxGoal（字段） 查询
		/// </summary>
		/// /// <param name = "maxGoal">进球最大累计值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_configEO> GetByMaxGoal(int maxGoal, TransactionManager tm_)
		{
			return GetByMaxGoal(maxGoal, 0, string.Empty, tm_);
		}
		public async Task<List<Bs_configEO>> GetByMaxGoalAsync(int maxGoal, TransactionManager tm_)
		{
			return await GetByMaxGoalAsync(maxGoal, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 MaxGoal（字段） 查询
		/// </summary>
		/// /// <param name = "maxGoal">进球最大累计值</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Bs_configEO> GetByMaxGoal(int maxGoal, int top_)
		{
			return GetByMaxGoal(maxGoal, top_, string.Empty, null);
		}
		public async Task<List<Bs_configEO>> GetByMaxGoalAsync(int maxGoal, int top_)
		{
			return await GetByMaxGoalAsync(maxGoal, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 MaxGoal（字段） 查询
		/// </summary>
		/// /// <param name = "maxGoal">进球最大累计值</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_configEO> GetByMaxGoal(int maxGoal, int top_, TransactionManager tm_)
		{
			return GetByMaxGoal(maxGoal, top_, string.Empty, tm_);
		}
		public async Task<List<Bs_configEO>> GetByMaxGoalAsync(int maxGoal, int top_, TransactionManager tm_)
		{
			return await GetByMaxGoalAsync(maxGoal, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 MaxGoal（字段） 查询
		/// </summary>
		/// /// <param name = "maxGoal">进球最大累计值</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Bs_configEO> GetByMaxGoal(int maxGoal, string sort_)
		{
			return GetByMaxGoal(maxGoal, 0, sort_, null);
		}
		public async Task<List<Bs_configEO>> GetByMaxGoalAsync(int maxGoal, string sort_)
		{
			return await GetByMaxGoalAsync(maxGoal, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 MaxGoal（字段） 查询
		/// </summary>
		/// /// <param name = "maxGoal">进球最大累计值</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_configEO> GetByMaxGoal(int maxGoal, string sort_, TransactionManager tm_)
		{
			return GetByMaxGoal(maxGoal, 0, sort_, tm_);
		}
		public async Task<List<Bs_configEO>> GetByMaxGoalAsync(int maxGoal, string sort_, TransactionManager tm_)
		{
			return await GetByMaxGoalAsync(maxGoal, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 MaxGoal（字段） 查询
		/// </summary>
		/// /// <param name = "maxGoal">进球最大累计值</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_configEO> GetByMaxGoal(int maxGoal, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`MaxGoal` = @MaxGoal", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@MaxGoal", maxGoal, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Bs_configEO.MapDataReader);
		}
		public async Task<List<Bs_configEO>> GetByMaxGoalAsync(int maxGoal, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`MaxGoal` = @MaxGoal", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@MaxGoal", maxGoal, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Bs_configEO.MapDataReader);
		}
		#endregion // GetByMaxGoal
		#region GetByRecDate
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">创建时间</param>
		/// <return>实体对象集合</return>
		public List<Bs_configEO> GetByRecDate(DateTime recDate)
		{
			return GetByRecDate(recDate, 0, string.Empty, null);
		}
		public async Task<List<Bs_configEO>> GetByRecDateAsync(DateTime recDate)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">创建时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_configEO> GetByRecDate(DateTime recDate, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, string.Empty, tm_);
		}
		public async Task<List<Bs_configEO>> GetByRecDateAsync(DateTime recDate, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">创建时间</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Bs_configEO> GetByRecDate(DateTime recDate, int top_)
		{
			return GetByRecDate(recDate, top_, string.Empty, null);
		}
		public async Task<List<Bs_configEO>> GetByRecDateAsync(DateTime recDate, int top_)
		{
			return await GetByRecDateAsync(recDate, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">创建时间</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_configEO> GetByRecDate(DateTime recDate, int top_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, top_, string.Empty, tm_);
		}
		public async Task<List<Bs_configEO>> GetByRecDateAsync(DateTime recDate, int top_, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">创建时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Bs_configEO> GetByRecDate(DateTime recDate, string sort_)
		{
			return GetByRecDate(recDate, 0, sort_, null);
		}
		public async Task<List<Bs_configEO>> GetByRecDateAsync(DateTime recDate, string sort_)
		{
			return await GetByRecDateAsync(recDate, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">创建时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_configEO> GetByRecDate(DateTime recDate, string sort_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, sort_, tm_);
		}
		public async Task<List<Bs_configEO>> GetByRecDateAsync(DateTime recDate, string sort_, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">创建时间</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_configEO> GetByRecDate(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return Database.ExecSqlList(sql_, paras_, tm_, Bs_configEO.MapDataReader);
		}
		public async Task<List<Bs_configEO>> GetByRecDateAsync(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Bs_configEO.MapDataReader);
		}
		#endregion // GetByRecDate
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
