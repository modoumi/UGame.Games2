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
	/// Jackpot奖励几率表
	/// 【表 bs_config_jackpot_odds 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class Bs_config_jackpot_oddsEO : IRowMapper<Bs_config_jackpot_oddsEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public Bs_config_jackpot_oddsEO()
		{
			this.RecDate = DateTime.Now;
		}
		#region 主键原始值 & 主键集合
	    
		/// <summary>
		/// 当前对象是否保存原始主键值，当修改了主键值时为 true
		/// </summary>
		public bool HasOriginal { get; protected set; }
		
		private string _originalJackpotOddsID;
		/// <summary>
		/// 【数据库中的原始主键 JackpotOddsID 值的副本，用于主键值更新】
		/// </summary>
		public string OriginalJackpotOddsID
		{
			get { return _originalJackpotOddsID; }
			set { HasOriginal = true; _originalJackpotOddsID = value; }
		}
		
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
	        return new Dictionary<string, object>() { { "JackpotOddsID", JackpotOddsID },  { "OperatorID", OperatorID },  { "CurrencyID", CurrencyID }, };
	    }
	    /// <summary>
	    /// 获取主键集合JSON格式
	    /// </summary>
	    /// <returns></returns>
	    public string GetPrimaryKeysJson() => SerializerUtil.SerializeJson(GetPrimaryKeys());
		#endregion // 主键原始值
		#region 所有字段
		/// <summary>
		/// 主Key
		/// 【主键 varchar(50)】
		/// </summary>
		[DataMember(Order = 1)]
		public string JackpotOddsID { get; set; }
		/// <summary>
		/// 运营商编码
		/// 【主键 varchar(50)】
		/// </summary>
		[DataMember(Order = 2)]
		public string OperatorID { get; set; }
		/// <summary>
		/// 货币编码
		/// 【主键 varchar(5)】
		/// </summary>
		[DataMember(Order = 3)]
		public string CurrencyID { get; set; }
		/// <summary>
		/// 基础投注额（值*100000）
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 4)]
		public int BetAmount { get; set; }
		/// <summary>
		/// 出现中奖概率（概率值*100000）
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 5)]
		public int Odds { get; set; }
		/// <summary>
		/// 奖金金额（值*100000）
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 6)]
		public long BonusAmount { get; set; }
		/// <summary>
		/// Jackpot累计值-起始值
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 7)]
		public long StartNum { get; set; }
		/// <summary>
		/// Jackpot累计值-截止值
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 8)]
		public long EndNum { get; set; }
		/// <summary>
		/// 创建时间
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 9)]
		public DateTime RecDate { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public Bs_config_jackpot_oddsEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static Bs_config_jackpot_oddsEO MapDataReader(IDataReader reader)
		{
		    Bs_config_jackpot_oddsEO ret = new Bs_config_jackpot_oddsEO();
			ret.JackpotOddsID = reader.ToString("JackpotOddsID");
			ret.OriginalJackpotOddsID = ret.JackpotOddsID;
			ret.OperatorID = reader.ToString("OperatorID");
			ret.OriginalOperatorID = ret.OperatorID;
			ret.CurrencyID = reader.ToString("CurrencyID");
			ret.OriginalCurrencyID = ret.CurrencyID;
			ret.BetAmount = reader.ToInt32("BetAmount");
			ret.Odds = reader.ToInt32("Odds");
			ret.BonusAmount = reader.ToInt64("BonusAmount");
			ret.StartNum = reader.ToInt64("StartNum");
			ret.EndNum = reader.ToInt64("EndNum");
			ret.RecDate = reader.ToDateTime("RecDate");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// Jackpot奖励几率表
	/// 【表 bs_config_jackpot_odds 的操作类】
	/// </summary>
	[Obsolete]
	public class Bs_config_jackpot_oddsMO : MySqlTableMO<Bs_config_jackpot_oddsEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`bs_config_jackpot_odds`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public Bs_config_jackpot_oddsMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public Bs_config_jackpot_oddsMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public Bs_config_jackpot_oddsMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(Bs_config_jackpot_oddsEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(Bs_config_jackpot_oddsEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(Bs_config_jackpot_oddsEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`JackpotOddsID`, `OperatorID`, `CurrencyID`, `BetAmount`, `Odds`, `BonusAmount`, `StartNum`, `EndNum`, `RecDate`) VALUE (@JackpotOddsID, @OperatorID, @CurrencyID, @BetAmount, @Odds, @BonusAmount, @StartNum, @EndNum, @RecDate);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@JackpotOddsID", item.JackpotOddsID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", item.OperatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", item.CurrencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@BetAmount", item.BetAmount, MySqlDbType.Int32),
				Database.CreateInParameter("@Odds", item.Odds, MySqlDbType.Int32),
				Database.CreateInParameter("@BonusAmount", item.BonusAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@StartNum", item.StartNum, MySqlDbType.Int64),
				Database.CreateInParameter("@EndNum", item.EndNum, MySqlDbType.Int64),
				Database.CreateInParameter("@RecDate", item.RecDate, MySqlDbType.DateTime),
			};
		}
		public int AddByBatch(IEnumerable<Bs_config_jackpot_oddsEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<Bs_config_jackpot_oddsEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<Bs_config_jackpot_oddsEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`JackpotOddsID`, `OperatorID`, `CurrencyID`, `BetAmount`, `Odds`, `BonusAmount`, `StartNum`, `EndNum`, `RecDate`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"('{item.JackpotOddsID}','{item.OperatorID}','{item.CurrencyID}',{item.BetAmount},{item.Odds},{item.BonusAmount},{item.StartNum},{item.EndNum},'{item.RecDate.ToString("yyyy-MM-dd HH:mm:ss")}'),");
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
		/// /// <param name = "jackpotOddsID">主Key</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(string jackpotOddsID, string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(jackpotOddsID, operatorID, currencyID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(string jackpotOddsID, string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(jackpotOddsID, operatorID, currencyID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(string jackpotOddsID, string operatorID, string currencyID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `JackpotOddsID` = @JackpotOddsID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@JackpotOddsID", jackpotOddsID, MySqlDbType.VarChar),
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
		public int Remove(Bs_config_jackpot_oddsEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.JackpotOddsID, item.OperatorID, item.CurrencyID, tm_);
		}
		public async Task<int> RemoveAsync(Bs_config_jackpot_oddsEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.JackpotOddsID, item.OperatorID, item.CurrencyID, tm_);
		}
		#endregion // RemoveByPK
		
		#region RemoveByXXX
		#region RemoveByJackpotOddsID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "jackpotOddsID">主Key</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByJackpotOddsID(string jackpotOddsID, TransactionManager tm_ = null)
		{
			RepairRemoveByJackpotOddsIDData(jackpotOddsID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByJackpotOddsIDAsync(string jackpotOddsID, TransactionManager tm_ = null)
		{
			RepairRemoveByJackpotOddsIDData(jackpotOddsID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByJackpotOddsIDData(string jackpotOddsID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `JackpotOddsID` = @JackpotOddsID";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@JackpotOddsID", jackpotOddsID, MySqlDbType.VarChar));
		}
		#endregion // RemoveByJackpotOddsID
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
		/// /// <param name = "currencyID">货币编码</param>
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
		#region RemoveByBetAmount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "betAmount">基础投注额（值*100000）</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByBetAmount(int betAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByBetAmountData(betAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByBetAmountAsync(int betAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByBetAmountData(betAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByBetAmountData(int betAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `BetAmount` = @BetAmount";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BetAmount", betAmount, MySqlDbType.Int32));
		}
		#endregion // RemoveByBetAmount
		#region RemoveByOdds
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "odds">出现中奖概率（概率值*100000）</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByOdds(int odds, TransactionManager tm_ = null)
		{
			RepairRemoveByOddsData(odds, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByOddsAsync(int odds, TransactionManager tm_ = null)
		{
			RepairRemoveByOddsData(odds, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByOddsData(int odds, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `Odds` = @Odds";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Odds", odds, MySqlDbType.Int32));
		}
		#endregion // RemoveByOdds
		#region RemoveByBonusAmount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "bonusAmount">奖金金额（值*100000）</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByBonusAmount(long bonusAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByBonusAmountData(bonusAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByBonusAmountAsync(long bonusAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByBonusAmountData(bonusAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByBonusAmountData(long bonusAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `BonusAmount` = @BonusAmount";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BonusAmount", bonusAmount, MySqlDbType.Int64));
		}
		#endregion // RemoveByBonusAmount
		#region RemoveByStartNum
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "startNum">Jackpot累计值-起始值</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByStartNum(long startNum, TransactionManager tm_ = null)
		{
			RepairRemoveByStartNumData(startNum, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByStartNumAsync(long startNum, TransactionManager tm_ = null)
		{
			RepairRemoveByStartNumData(startNum, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByStartNumData(long startNum, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `StartNum` = @StartNum";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@StartNum", startNum, MySqlDbType.Int64));
		}
		#endregion // RemoveByStartNum
		#region RemoveByEndNum
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "endNum">Jackpot累计值-截止值</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByEndNum(long endNum, TransactionManager tm_ = null)
		{
			RepairRemoveByEndNumData(endNum, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByEndNumAsync(long endNum, TransactionManager tm_ = null)
		{
			RepairRemoveByEndNumData(endNum, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByEndNumData(long endNum, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `EndNum` = @EndNum";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@EndNum", endNum, MySqlDbType.Int64));
		}
		#endregion // RemoveByEndNum
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
		public int Put(Bs_config_jackpot_oddsEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(Bs_config_jackpot_oddsEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(Bs_config_jackpot_oddsEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `JackpotOddsID` = @JackpotOddsID, `OperatorID` = @OperatorID, `CurrencyID` = @CurrencyID, `BetAmount` = @BetAmount, `Odds` = @Odds, `BonusAmount` = @BonusAmount, `StartNum` = @StartNum, `EndNum` = @EndNum WHERE `JackpotOddsID` = @JackpotOddsID_Original AND `OperatorID` = @OperatorID_Original AND `CurrencyID` = @CurrencyID_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@JackpotOddsID", item.JackpotOddsID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", item.OperatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", item.CurrencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@BetAmount", item.BetAmount, MySqlDbType.Int32),
				Database.CreateInParameter("@Odds", item.Odds, MySqlDbType.Int32),
				Database.CreateInParameter("@BonusAmount", item.BonusAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@StartNum", item.StartNum, MySqlDbType.Int64),
				Database.CreateInParameter("@EndNum", item.EndNum, MySqlDbType.Int64),
				Database.CreateInParameter("@JackpotOddsID_Original", item.HasOriginal ? item.OriginalJackpotOddsID : item.JackpotOddsID, MySqlDbType.VarChar),
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
		public int Put(IEnumerable<Bs_config_jackpot_oddsEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<Bs_config_jackpot_oddsEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "jackpotOddsID">主Key</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string jackpotOddsID, string operatorID, string currencyID, string set_, params object[] values_)
		{
			return Put(set_, "`JackpotOddsID` = @JackpotOddsID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", ConcatValues(values_, jackpotOddsID, operatorID, currencyID));
		}
		public async Task<int> PutByPKAsync(string jackpotOddsID, string operatorID, string currencyID, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`JackpotOddsID` = @JackpotOddsID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", ConcatValues(values_, jackpotOddsID, operatorID, currencyID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "jackpotOddsID">主Key</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string jackpotOddsID, string operatorID, string currencyID, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`JackpotOddsID` = @JackpotOddsID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", tm_, ConcatValues(values_, jackpotOddsID, operatorID, currencyID));
		}
		public async Task<int> PutByPKAsync(string jackpotOddsID, string operatorID, string currencyID, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`JackpotOddsID` = @JackpotOddsID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", tm_, ConcatValues(values_, jackpotOddsID, operatorID, currencyID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "jackpotOddsID">主Key</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string jackpotOddsID, string operatorID, string currencyID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@JackpotOddsID", jackpotOddsID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
	        };
			return Put(set_, "`JackpotOddsID` = @JackpotOddsID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(string jackpotOddsID, string operatorID, string currencyID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@JackpotOddsID", jackpotOddsID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
	        };
			return await PutAsync(set_, "`JackpotOddsID` = @JackpotOddsID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", ConcatParameters(paras_, newParas_), tm_);
		}
		#endregion // PutByPK
		
		#region PutXXX
		#region PutJackpotOddsID
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "jackpotOddsID">主Key</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutJackpotOddsID(string jackpotOddsID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `JackpotOddsID` = @JackpotOddsID";
			var parameter_ = Database.CreateInParameter("@JackpotOddsID", jackpotOddsID, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutJackpotOddsIDAsync(string jackpotOddsID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `JackpotOddsID` = @JackpotOddsID";
			var parameter_ = Database.CreateInParameter("@JackpotOddsID", jackpotOddsID, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutJackpotOddsID
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
		/// /// <param name = "currencyID">货币编码</param>
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
		#region PutBetAmount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "jackpotOddsID">主Key</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码</param>
		/// /// <param name = "betAmount">基础投注额（值*100000）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBetAmountByPK(string jackpotOddsID, string operatorID, string currencyID, int betAmount, TransactionManager tm_ = null)
		{
			RepairPutBetAmountByPKData(jackpotOddsID, operatorID, currencyID, betAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutBetAmountByPKAsync(string jackpotOddsID, string operatorID, string currencyID, int betAmount, TransactionManager tm_ = null)
		{
			RepairPutBetAmountByPKData(jackpotOddsID, operatorID, currencyID, betAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutBetAmountByPKData(string jackpotOddsID, string operatorID, string currencyID, int betAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `BetAmount` = @BetAmount  WHERE `JackpotOddsID` = @JackpotOddsID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetAmount", betAmount, MySqlDbType.Int32),
				Database.CreateInParameter("@JackpotOddsID", jackpotOddsID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "betAmount">基础投注额（值*100000）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBetAmount(int betAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `BetAmount` = @BetAmount";
			var parameter_ = Database.CreateInParameter("@BetAmount", betAmount, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutBetAmountAsync(int betAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `BetAmount` = @BetAmount";
			var parameter_ = Database.CreateInParameter("@BetAmount", betAmount, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutBetAmount
		#region PutOdds
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "jackpotOddsID">主Key</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码</param>
		/// /// <param name = "odds">出现中奖概率（概率值*100000）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOddsByPK(string jackpotOddsID, string operatorID, string currencyID, int odds, TransactionManager tm_ = null)
		{
			RepairPutOddsByPKData(jackpotOddsID, operatorID, currencyID, odds, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutOddsByPKAsync(string jackpotOddsID, string operatorID, string currencyID, int odds, TransactionManager tm_ = null)
		{
			RepairPutOddsByPKData(jackpotOddsID, operatorID, currencyID, odds, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutOddsByPKData(string jackpotOddsID, string operatorID, string currencyID, int odds, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Odds` = @Odds  WHERE `JackpotOddsID` = @JackpotOddsID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Odds", odds, MySqlDbType.Int32),
				Database.CreateInParameter("@JackpotOddsID", jackpotOddsID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "odds">出现中奖概率（概率值*100000）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOdds(int odds, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Odds` = @Odds";
			var parameter_ = Database.CreateInParameter("@Odds", odds, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutOddsAsync(int odds, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Odds` = @Odds";
			var parameter_ = Database.CreateInParameter("@Odds", odds, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutOdds
		#region PutBonusAmount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "jackpotOddsID">主Key</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码</param>
		/// /// <param name = "bonusAmount">奖金金额（值*100000）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBonusAmountByPK(string jackpotOddsID, string operatorID, string currencyID, long bonusAmount, TransactionManager tm_ = null)
		{
			RepairPutBonusAmountByPKData(jackpotOddsID, operatorID, currencyID, bonusAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutBonusAmountByPKAsync(string jackpotOddsID, string operatorID, string currencyID, long bonusAmount, TransactionManager tm_ = null)
		{
			RepairPutBonusAmountByPKData(jackpotOddsID, operatorID, currencyID, bonusAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutBonusAmountByPKData(string jackpotOddsID, string operatorID, string currencyID, long bonusAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `BonusAmount` = @BonusAmount  WHERE `JackpotOddsID` = @JackpotOddsID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BonusAmount", bonusAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@JackpotOddsID", jackpotOddsID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "bonusAmount">奖金金额（值*100000）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBonusAmount(long bonusAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `BonusAmount` = @BonusAmount";
			var parameter_ = Database.CreateInParameter("@BonusAmount", bonusAmount, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutBonusAmountAsync(long bonusAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `BonusAmount` = @BonusAmount";
			var parameter_ = Database.CreateInParameter("@BonusAmount", bonusAmount, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutBonusAmount
		#region PutStartNum
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "jackpotOddsID">主Key</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码</param>
		/// /// <param name = "startNum">Jackpot累计值-起始值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutStartNumByPK(string jackpotOddsID, string operatorID, string currencyID, long startNum, TransactionManager tm_ = null)
		{
			RepairPutStartNumByPKData(jackpotOddsID, operatorID, currencyID, startNum, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutStartNumByPKAsync(string jackpotOddsID, string operatorID, string currencyID, long startNum, TransactionManager tm_ = null)
		{
			RepairPutStartNumByPKData(jackpotOddsID, operatorID, currencyID, startNum, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutStartNumByPKData(string jackpotOddsID, string operatorID, string currencyID, long startNum, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `StartNum` = @StartNum  WHERE `JackpotOddsID` = @JackpotOddsID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@StartNum", startNum, MySqlDbType.Int64),
				Database.CreateInParameter("@JackpotOddsID", jackpotOddsID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "startNum">Jackpot累计值-起始值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutStartNum(long startNum, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `StartNum` = @StartNum";
			var parameter_ = Database.CreateInParameter("@StartNum", startNum, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutStartNumAsync(long startNum, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `StartNum` = @StartNum";
			var parameter_ = Database.CreateInParameter("@StartNum", startNum, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutStartNum
		#region PutEndNum
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "jackpotOddsID">主Key</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码</param>
		/// /// <param name = "endNum">Jackpot累计值-截止值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutEndNumByPK(string jackpotOddsID, string operatorID, string currencyID, long endNum, TransactionManager tm_ = null)
		{
			RepairPutEndNumByPKData(jackpotOddsID, operatorID, currencyID, endNum, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutEndNumByPKAsync(string jackpotOddsID, string operatorID, string currencyID, long endNum, TransactionManager tm_ = null)
		{
			RepairPutEndNumByPKData(jackpotOddsID, operatorID, currencyID, endNum, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutEndNumByPKData(string jackpotOddsID, string operatorID, string currencyID, long endNum, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `EndNum` = @EndNum  WHERE `JackpotOddsID` = @JackpotOddsID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@EndNum", endNum, MySqlDbType.Int64),
				Database.CreateInParameter("@JackpotOddsID", jackpotOddsID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "endNum">Jackpot累计值-截止值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutEndNum(long endNum, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `EndNum` = @EndNum";
			var parameter_ = Database.CreateInParameter("@EndNum", endNum, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutEndNumAsync(long endNum, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `EndNum` = @EndNum";
			var parameter_ = Database.CreateInParameter("@EndNum", endNum, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutEndNum
		#region PutRecDate
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "jackpotOddsID">主Key</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码</param>
		/// /// <param name = "recDate">创建时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRecDateByPK(string jackpotOddsID, string operatorID, string currencyID, DateTime recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(jackpotOddsID, operatorID, currencyID, recDate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutRecDateByPKAsync(string jackpotOddsID, string operatorID, string currencyID, DateTime recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(jackpotOddsID, operatorID, currencyID, recDate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutRecDateByPKData(string jackpotOddsID, string operatorID, string currencyID, DateTime recDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `RecDate` = @RecDate  WHERE `JackpotOddsID` = @JackpotOddsID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime),
				Database.CreateInParameter("@JackpotOddsID", jackpotOddsID, MySqlDbType.VarChar),
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
		public bool Set(Bs_config_jackpot_oddsEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.JackpotOddsID, item.OperatorID, item.CurrencyID) == null)
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
		public async Task<bool> SetAsync(Bs_config_jackpot_oddsEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.JackpotOddsID, item.OperatorID, item.CurrencyID) == null)
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
		/// /// <param name = "jackpotOddsID">主Key</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public Bs_config_jackpot_oddsEO GetByPK(string jackpotOddsID, string operatorID, string currencyID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(jackpotOddsID, operatorID, currencyID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, Bs_config_jackpot_oddsEO.MapDataReader);
		}
		public async Task<Bs_config_jackpot_oddsEO> GetByPKAsync(string jackpotOddsID, string operatorID, string currencyID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(jackpotOddsID, operatorID, currencyID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Bs_config_jackpot_oddsEO.MapDataReader);
		}
		private void RepairGetByPKData(string jackpotOddsID, string operatorID, string currencyID, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`JackpotOddsID` = @JackpotOddsID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@JackpotOddsID", jackpotOddsID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
		}
		#endregion // GetByPK
		
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 JackpotOddsID（字段）
		/// </summary>
		/// /// <param name = "jackpotOddsID">主Key</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetJackpotOddsIDByPK(string jackpotOddsID, string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@JackpotOddsID", jackpotOddsID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`JackpotOddsID`", "`JackpotOddsID` = @JackpotOddsID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		public async Task<string> GetJackpotOddsIDByPKAsync(string jackpotOddsID, string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@JackpotOddsID", jackpotOddsID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`JackpotOddsID`", "`JackpotOddsID` = @JackpotOddsID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 OperatorID（字段）
		/// </summary>
		/// /// <param name = "jackpotOddsID">主Key</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetOperatorIDByPK(string jackpotOddsID, string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@JackpotOddsID", jackpotOddsID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`OperatorID`", "`JackpotOddsID` = @JackpotOddsID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		public async Task<string> GetOperatorIDByPKAsync(string jackpotOddsID, string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@JackpotOddsID", jackpotOddsID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`OperatorID`", "`JackpotOddsID` = @JackpotOddsID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 CurrencyID（字段）
		/// </summary>
		/// /// <param name = "jackpotOddsID">主Key</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetCurrencyIDByPK(string jackpotOddsID, string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@JackpotOddsID", jackpotOddsID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`CurrencyID`", "`JackpotOddsID` = @JackpotOddsID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		public async Task<string> GetCurrencyIDByPKAsync(string jackpotOddsID, string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@JackpotOddsID", jackpotOddsID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`CurrencyID`", "`JackpotOddsID` = @JackpotOddsID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 BetAmount（字段）
		/// </summary>
		/// /// <param name = "jackpotOddsID">主Key</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetBetAmountByPK(string jackpotOddsID, string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@JackpotOddsID", jackpotOddsID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`BetAmount`", "`JackpotOddsID` = @JackpotOddsID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		public async Task<int> GetBetAmountByPKAsync(string jackpotOddsID, string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@JackpotOddsID", jackpotOddsID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`BetAmount`", "`JackpotOddsID` = @JackpotOddsID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Odds（字段）
		/// </summary>
		/// /// <param name = "jackpotOddsID">主Key</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetOddsByPK(string jackpotOddsID, string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@JackpotOddsID", jackpotOddsID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`Odds`", "`JackpotOddsID` = @JackpotOddsID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		public async Task<int> GetOddsByPKAsync(string jackpotOddsID, string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@JackpotOddsID", jackpotOddsID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`Odds`", "`JackpotOddsID` = @JackpotOddsID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 BonusAmount（字段）
		/// </summary>
		/// /// <param name = "jackpotOddsID">主Key</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetBonusAmountByPK(string jackpotOddsID, string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@JackpotOddsID", jackpotOddsID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`BonusAmount`", "`JackpotOddsID` = @JackpotOddsID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		public async Task<long> GetBonusAmountByPKAsync(string jackpotOddsID, string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@JackpotOddsID", jackpotOddsID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`BonusAmount`", "`JackpotOddsID` = @JackpotOddsID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 StartNum（字段）
		/// </summary>
		/// /// <param name = "jackpotOddsID">主Key</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetStartNumByPK(string jackpotOddsID, string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@JackpotOddsID", jackpotOddsID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`StartNum`", "`JackpotOddsID` = @JackpotOddsID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		public async Task<long> GetStartNumByPKAsync(string jackpotOddsID, string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@JackpotOddsID", jackpotOddsID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`StartNum`", "`JackpotOddsID` = @JackpotOddsID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 EndNum（字段）
		/// </summary>
		/// /// <param name = "jackpotOddsID">主Key</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetEndNumByPK(string jackpotOddsID, string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@JackpotOddsID", jackpotOddsID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`EndNum`", "`JackpotOddsID` = @JackpotOddsID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		public async Task<long> GetEndNumByPKAsync(string jackpotOddsID, string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@JackpotOddsID", jackpotOddsID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`EndNum`", "`JackpotOddsID` = @JackpotOddsID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 RecDate（字段）
		/// </summary>
		/// /// <param name = "jackpotOddsID">主Key</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime GetRecDateByPK(string jackpotOddsID, string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@JackpotOddsID", jackpotOddsID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (DateTime)GetScalar("`RecDate`", "`JackpotOddsID` = @JackpotOddsID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		public async Task<DateTime> GetRecDateByPKAsync(string jackpotOddsID, string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@JackpotOddsID", jackpotOddsID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (DateTime)await GetScalarAsync("`RecDate`", "`JackpotOddsID` = @JackpotOddsID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByJackpotOddsID
		
		/// <summary>
		/// 按 JackpotOddsID（字段） 查询
		/// </summary>
		/// /// <param name = "jackpotOddsID">主Key</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_jackpot_oddsEO> GetByJackpotOddsID(string jackpotOddsID)
		{
			return GetByJackpotOddsID(jackpotOddsID, 0, string.Empty, null);
		}
		public async Task<List<Bs_config_jackpot_oddsEO>> GetByJackpotOddsIDAsync(string jackpotOddsID)
		{
			return await GetByJackpotOddsIDAsync(jackpotOddsID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 JackpotOddsID（字段） 查询
		/// </summary>
		/// /// <param name = "jackpotOddsID">主Key</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_jackpot_oddsEO> GetByJackpotOddsID(string jackpotOddsID, TransactionManager tm_)
		{
			return GetByJackpotOddsID(jackpotOddsID, 0, string.Empty, tm_);
		}
		public async Task<List<Bs_config_jackpot_oddsEO>> GetByJackpotOddsIDAsync(string jackpotOddsID, TransactionManager tm_)
		{
			return await GetByJackpotOddsIDAsync(jackpotOddsID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 JackpotOddsID（字段） 查询
		/// </summary>
		/// /// <param name = "jackpotOddsID">主Key</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_jackpot_oddsEO> GetByJackpotOddsID(string jackpotOddsID, int top_)
		{
			return GetByJackpotOddsID(jackpotOddsID, top_, string.Empty, null);
		}
		public async Task<List<Bs_config_jackpot_oddsEO>> GetByJackpotOddsIDAsync(string jackpotOddsID, int top_)
		{
			return await GetByJackpotOddsIDAsync(jackpotOddsID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 JackpotOddsID（字段） 查询
		/// </summary>
		/// /// <param name = "jackpotOddsID">主Key</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_jackpot_oddsEO> GetByJackpotOddsID(string jackpotOddsID, int top_, TransactionManager tm_)
		{
			return GetByJackpotOddsID(jackpotOddsID, top_, string.Empty, tm_);
		}
		public async Task<List<Bs_config_jackpot_oddsEO>> GetByJackpotOddsIDAsync(string jackpotOddsID, int top_, TransactionManager tm_)
		{
			return await GetByJackpotOddsIDAsync(jackpotOddsID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 JackpotOddsID（字段） 查询
		/// </summary>
		/// /// <param name = "jackpotOddsID">主Key</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_jackpot_oddsEO> GetByJackpotOddsID(string jackpotOddsID, string sort_)
		{
			return GetByJackpotOddsID(jackpotOddsID, 0, sort_, null);
		}
		public async Task<List<Bs_config_jackpot_oddsEO>> GetByJackpotOddsIDAsync(string jackpotOddsID, string sort_)
		{
			return await GetByJackpotOddsIDAsync(jackpotOddsID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 JackpotOddsID（字段） 查询
		/// </summary>
		/// /// <param name = "jackpotOddsID">主Key</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_jackpot_oddsEO> GetByJackpotOddsID(string jackpotOddsID, string sort_, TransactionManager tm_)
		{
			return GetByJackpotOddsID(jackpotOddsID, 0, sort_, tm_);
		}
		public async Task<List<Bs_config_jackpot_oddsEO>> GetByJackpotOddsIDAsync(string jackpotOddsID, string sort_, TransactionManager tm_)
		{
			return await GetByJackpotOddsIDAsync(jackpotOddsID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 JackpotOddsID（字段） 查询
		/// </summary>
		/// /// <param name = "jackpotOddsID">主Key</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_jackpot_oddsEO> GetByJackpotOddsID(string jackpotOddsID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`JackpotOddsID` = @JackpotOddsID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@JackpotOddsID", jackpotOddsID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Bs_config_jackpot_oddsEO.MapDataReader);
		}
		public async Task<List<Bs_config_jackpot_oddsEO>> GetByJackpotOddsIDAsync(string jackpotOddsID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`JackpotOddsID` = @JackpotOddsID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@JackpotOddsID", jackpotOddsID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Bs_config_jackpot_oddsEO.MapDataReader);
		}
		#endregion // GetByJackpotOddsID
		#region GetByOperatorID
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_jackpot_oddsEO> GetByOperatorID(string operatorID)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, null);
		}
		public async Task<List<Bs_config_jackpot_oddsEO>> GetByOperatorIDAsync(string operatorID)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_jackpot_oddsEO> GetByOperatorID(string operatorID, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, tm_);
		}
		public async Task<List<Bs_config_jackpot_oddsEO>> GetByOperatorIDAsync(string operatorID, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_jackpot_oddsEO> GetByOperatorID(string operatorID, int top_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, null);
		}
		public async Task<List<Bs_config_jackpot_oddsEO>> GetByOperatorIDAsync(string operatorID, int top_)
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
		public List<Bs_config_jackpot_oddsEO> GetByOperatorID(string operatorID, int top_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, tm_);
		}
		public async Task<List<Bs_config_jackpot_oddsEO>> GetByOperatorIDAsync(string operatorID, int top_, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_jackpot_oddsEO> GetByOperatorID(string operatorID, string sort_)
		{
			return GetByOperatorID(operatorID, 0, sort_, null);
		}
		public async Task<List<Bs_config_jackpot_oddsEO>> GetByOperatorIDAsync(string operatorID, string sort_)
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
		public List<Bs_config_jackpot_oddsEO> GetByOperatorID(string operatorID, string sort_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, sort_, tm_);
		}
		public async Task<List<Bs_config_jackpot_oddsEO>> GetByOperatorIDAsync(string operatorID, string sort_, TransactionManager tm_)
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
		public List<Bs_config_jackpot_oddsEO> GetByOperatorID(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorID` = @OperatorID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Bs_config_jackpot_oddsEO.MapDataReader);
		}
		public async Task<List<Bs_config_jackpot_oddsEO>> GetByOperatorIDAsync(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorID` = @OperatorID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Bs_config_jackpot_oddsEO.MapDataReader);
		}
		#endregion // GetByOperatorID
		#region GetByCurrencyID
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币编码</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_jackpot_oddsEO> GetByCurrencyID(string currencyID)
		{
			return GetByCurrencyID(currencyID, 0, string.Empty, null);
		}
		public async Task<List<Bs_config_jackpot_oddsEO>> GetByCurrencyIDAsync(string currencyID)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_jackpot_oddsEO> GetByCurrencyID(string currencyID, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, 0, string.Empty, tm_);
		}
		public async Task<List<Bs_config_jackpot_oddsEO>> GetByCurrencyIDAsync(string currencyID, TransactionManager tm_)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_jackpot_oddsEO> GetByCurrencyID(string currencyID, int top_)
		{
			return GetByCurrencyID(currencyID, top_, string.Empty, null);
		}
		public async Task<List<Bs_config_jackpot_oddsEO>> GetByCurrencyIDAsync(string currencyID, int top_)
		{
			return await GetByCurrencyIDAsync(currencyID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币编码</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_jackpot_oddsEO> GetByCurrencyID(string currencyID, int top_, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, top_, string.Empty, tm_);
		}
		public async Task<List<Bs_config_jackpot_oddsEO>> GetByCurrencyIDAsync(string currencyID, int top_, TransactionManager tm_)
		{
			return await GetByCurrencyIDAsync(currencyID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_jackpot_oddsEO> GetByCurrencyID(string currencyID, string sort_)
		{
			return GetByCurrencyID(currencyID, 0, sort_, null);
		}
		public async Task<List<Bs_config_jackpot_oddsEO>> GetByCurrencyIDAsync(string currencyID, string sort_)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_jackpot_oddsEO> GetByCurrencyID(string currencyID, string sort_, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, 0, sort_, tm_);
		}
		public async Task<List<Bs_config_jackpot_oddsEO>> GetByCurrencyIDAsync(string currencyID, string sort_, TransactionManager tm_)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币编码</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_jackpot_oddsEO> GetByCurrencyID(string currencyID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CurrencyID` = @CurrencyID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Bs_config_jackpot_oddsEO.MapDataReader);
		}
		public async Task<List<Bs_config_jackpot_oddsEO>> GetByCurrencyIDAsync(string currencyID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CurrencyID` = @CurrencyID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Bs_config_jackpot_oddsEO.MapDataReader);
		}
		#endregion // GetByCurrencyID
		#region GetByBetAmount
		
		/// <summary>
		/// 按 BetAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betAmount">基础投注额（值*100000）</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_jackpot_oddsEO> GetByBetAmount(int betAmount)
		{
			return GetByBetAmount(betAmount, 0, string.Empty, null);
		}
		public async Task<List<Bs_config_jackpot_oddsEO>> GetByBetAmountAsync(int betAmount)
		{
			return await GetByBetAmountAsync(betAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BetAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betAmount">基础投注额（值*100000）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_jackpot_oddsEO> GetByBetAmount(int betAmount, TransactionManager tm_)
		{
			return GetByBetAmount(betAmount, 0, string.Empty, tm_);
		}
		public async Task<List<Bs_config_jackpot_oddsEO>> GetByBetAmountAsync(int betAmount, TransactionManager tm_)
		{
			return await GetByBetAmountAsync(betAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BetAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betAmount">基础投注额（值*100000）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_jackpot_oddsEO> GetByBetAmount(int betAmount, int top_)
		{
			return GetByBetAmount(betAmount, top_, string.Empty, null);
		}
		public async Task<List<Bs_config_jackpot_oddsEO>> GetByBetAmountAsync(int betAmount, int top_)
		{
			return await GetByBetAmountAsync(betAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BetAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betAmount">基础投注额（值*100000）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_jackpot_oddsEO> GetByBetAmount(int betAmount, int top_, TransactionManager tm_)
		{
			return GetByBetAmount(betAmount, top_, string.Empty, tm_);
		}
		public async Task<List<Bs_config_jackpot_oddsEO>> GetByBetAmountAsync(int betAmount, int top_, TransactionManager tm_)
		{
			return await GetByBetAmountAsync(betAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BetAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betAmount">基础投注额（值*100000）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_jackpot_oddsEO> GetByBetAmount(int betAmount, string sort_)
		{
			return GetByBetAmount(betAmount, 0, sort_, null);
		}
		public async Task<List<Bs_config_jackpot_oddsEO>> GetByBetAmountAsync(int betAmount, string sort_)
		{
			return await GetByBetAmountAsync(betAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 BetAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betAmount">基础投注额（值*100000）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_jackpot_oddsEO> GetByBetAmount(int betAmount, string sort_, TransactionManager tm_)
		{
			return GetByBetAmount(betAmount, 0, sort_, tm_);
		}
		public async Task<List<Bs_config_jackpot_oddsEO>> GetByBetAmountAsync(int betAmount, string sort_, TransactionManager tm_)
		{
			return await GetByBetAmountAsync(betAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 BetAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betAmount">基础投注额（值*100000）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_jackpot_oddsEO> GetByBetAmount(int betAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BetAmount` = @BetAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BetAmount", betAmount, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Bs_config_jackpot_oddsEO.MapDataReader);
		}
		public async Task<List<Bs_config_jackpot_oddsEO>> GetByBetAmountAsync(int betAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BetAmount` = @BetAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BetAmount", betAmount, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Bs_config_jackpot_oddsEO.MapDataReader);
		}
		#endregion // GetByBetAmount
		#region GetByOdds
		
		/// <summary>
		/// 按 Odds（字段） 查询
		/// </summary>
		/// /// <param name = "odds">出现中奖概率（概率值*100000）</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_jackpot_oddsEO> GetByOdds(int odds)
		{
			return GetByOdds(odds, 0, string.Empty, null);
		}
		public async Task<List<Bs_config_jackpot_oddsEO>> GetByOddsAsync(int odds)
		{
			return await GetByOddsAsync(odds, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Odds（字段） 查询
		/// </summary>
		/// /// <param name = "odds">出现中奖概率（概率值*100000）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_jackpot_oddsEO> GetByOdds(int odds, TransactionManager tm_)
		{
			return GetByOdds(odds, 0, string.Empty, tm_);
		}
		public async Task<List<Bs_config_jackpot_oddsEO>> GetByOddsAsync(int odds, TransactionManager tm_)
		{
			return await GetByOddsAsync(odds, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Odds（字段） 查询
		/// </summary>
		/// /// <param name = "odds">出现中奖概率（概率值*100000）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_jackpot_oddsEO> GetByOdds(int odds, int top_)
		{
			return GetByOdds(odds, top_, string.Empty, null);
		}
		public async Task<List<Bs_config_jackpot_oddsEO>> GetByOddsAsync(int odds, int top_)
		{
			return await GetByOddsAsync(odds, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Odds（字段） 查询
		/// </summary>
		/// /// <param name = "odds">出现中奖概率（概率值*100000）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_jackpot_oddsEO> GetByOdds(int odds, int top_, TransactionManager tm_)
		{
			return GetByOdds(odds, top_, string.Empty, tm_);
		}
		public async Task<List<Bs_config_jackpot_oddsEO>> GetByOddsAsync(int odds, int top_, TransactionManager tm_)
		{
			return await GetByOddsAsync(odds, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Odds（字段） 查询
		/// </summary>
		/// /// <param name = "odds">出现中奖概率（概率值*100000）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_jackpot_oddsEO> GetByOdds(int odds, string sort_)
		{
			return GetByOdds(odds, 0, sort_, null);
		}
		public async Task<List<Bs_config_jackpot_oddsEO>> GetByOddsAsync(int odds, string sort_)
		{
			return await GetByOddsAsync(odds, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Odds（字段） 查询
		/// </summary>
		/// /// <param name = "odds">出现中奖概率（概率值*100000）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_jackpot_oddsEO> GetByOdds(int odds, string sort_, TransactionManager tm_)
		{
			return GetByOdds(odds, 0, sort_, tm_);
		}
		public async Task<List<Bs_config_jackpot_oddsEO>> GetByOddsAsync(int odds, string sort_, TransactionManager tm_)
		{
			return await GetByOddsAsync(odds, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Odds（字段） 查询
		/// </summary>
		/// /// <param name = "odds">出现中奖概率（概率值*100000）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_jackpot_oddsEO> GetByOdds(int odds, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Odds` = @Odds", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Odds", odds, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Bs_config_jackpot_oddsEO.MapDataReader);
		}
		public async Task<List<Bs_config_jackpot_oddsEO>> GetByOddsAsync(int odds, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Odds` = @Odds", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Odds", odds, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Bs_config_jackpot_oddsEO.MapDataReader);
		}
		#endregion // GetByOdds
		#region GetByBonusAmount
		
		/// <summary>
		/// 按 BonusAmount（字段） 查询
		/// </summary>
		/// /// <param name = "bonusAmount">奖金金额（值*100000）</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_jackpot_oddsEO> GetByBonusAmount(long bonusAmount)
		{
			return GetByBonusAmount(bonusAmount, 0, string.Empty, null);
		}
		public async Task<List<Bs_config_jackpot_oddsEO>> GetByBonusAmountAsync(long bonusAmount)
		{
			return await GetByBonusAmountAsync(bonusAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BonusAmount（字段） 查询
		/// </summary>
		/// /// <param name = "bonusAmount">奖金金额（值*100000）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_jackpot_oddsEO> GetByBonusAmount(long bonusAmount, TransactionManager tm_)
		{
			return GetByBonusAmount(bonusAmount, 0, string.Empty, tm_);
		}
		public async Task<List<Bs_config_jackpot_oddsEO>> GetByBonusAmountAsync(long bonusAmount, TransactionManager tm_)
		{
			return await GetByBonusAmountAsync(bonusAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BonusAmount（字段） 查询
		/// </summary>
		/// /// <param name = "bonusAmount">奖金金额（值*100000）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_jackpot_oddsEO> GetByBonusAmount(long bonusAmount, int top_)
		{
			return GetByBonusAmount(bonusAmount, top_, string.Empty, null);
		}
		public async Task<List<Bs_config_jackpot_oddsEO>> GetByBonusAmountAsync(long bonusAmount, int top_)
		{
			return await GetByBonusAmountAsync(bonusAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BonusAmount（字段） 查询
		/// </summary>
		/// /// <param name = "bonusAmount">奖金金额（值*100000）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_jackpot_oddsEO> GetByBonusAmount(long bonusAmount, int top_, TransactionManager tm_)
		{
			return GetByBonusAmount(bonusAmount, top_, string.Empty, tm_);
		}
		public async Task<List<Bs_config_jackpot_oddsEO>> GetByBonusAmountAsync(long bonusAmount, int top_, TransactionManager tm_)
		{
			return await GetByBonusAmountAsync(bonusAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BonusAmount（字段） 查询
		/// </summary>
		/// /// <param name = "bonusAmount">奖金金额（值*100000）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_jackpot_oddsEO> GetByBonusAmount(long bonusAmount, string sort_)
		{
			return GetByBonusAmount(bonusAmount, 0, sort_, null);
		}
		public async Task<List<Bs_config_jackpot_oddsEO>> GetByBonusAmountAsync(long bonusAmount, string sort_)
		{
			return await GetByBonusAmountAsync(bonusAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 BonusAmount（字段） 查询
		/// </summary>
		/// /// <param name = "bonusAmount">奖金金额（值*100000）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_jackpot_oddsEO> GetByBonusAmount(long bonusAmount, string sort_, TransactionManager tm_)
		{
			return GetByBonusAmount(bonusAmount, 0, sort_, tm_);
		}
		public async Task<List<Bs_config_jackpot_oddsEO>> GetByBonusAmountAsync(long bonusAmount, string sort_, TransactionManager tm_)
		{
			return await GetByBonusAmountAsync(bonusAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 BonusAmount（字段） 查询
		/// </summary>
		/// /// <param name = "bonusAmount">奖金金额（值*100000）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_jackpot_oddsEO> GetByBonusAmount(long bonusAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BonusAmount` = @BonusAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BonusAmount", bonusAmount, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Bs_config_jackpot_oddsEO.MapDataReader);
		}
		public async Task<List<Bs_config_jackpot_oddsEO>> GetByBonusAmountAsync(long bonusAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BonusAmount` = @BonusAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BonusAmount", bonusAmount, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Bs_config_jackpot_oddsEO.MapDataReader);
		}
		#endregion // GetByBonusAmount
		#region GetByStartNum
		
		/// <summary>
		/// 按 StartNum（字段） 查询
		/// </summary>
		/// /// <param name = "startNum">Jackpot累计值-起始值</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_jackpot_oddsEO> GetByStartNum(long startNum)
		{
			return GetByStartNum(startNum, 0, string.Empty, null);
		}
		public async Task<List<Bs_config_jackpot_oddsEO>> GetByStartNumAsync(long startNum)
		{
			return await GetByStartNumAsync(startNum, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 StartNum（字段） 查询
		/// </summary>
		/// /// <param name = "startNum">Jackpot累计值-起始值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_jackpot_oddsEO> GetByStartNum(long startNum, TransactionManager tm_)
		{
			return GetByStartNum(startNum, 0, string.Empty, tm_);
		}
		public async Task<List<Bs_config_jackpot_oddsEO>> GetByStartNumAsync(long startNum, TransactionManager tm_)
		{
			return await GetByStartNumAsync(startNum, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 StartNum（字段） 查询
		/// </summary>
		/// /// <param name = "startNum">Jackpot累计值-起始值</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_jackpot_oddsEO> GetByStartNum(long startNum, int top_)
		{
			return GetByStartNum(startNum, top_, string.Empty, null);
		}
		public async Task<List<Bs_config_jackpot_oddsEO>> GetByStartNumAsync(long startNum, int top_)
		{
			return await GetByStartNumAsync(startNum, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 StartNum（字段） 查询
		/// </summary>
		/// /// <param name = "startNum">Jackpot累计值-起始值</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_jackpot_oddsEO> GetByStartNum(long startNum, int top_, TransactionManager tm_)
		{
			return GetByStartNum(startNum, top_, string.Empty, tm_);
		}
		public async Task<List<Bs_config_jackpot_oddsEO>> GetByStartNumAsync(long startNum, int top_, TransactionManager tm_)
		{
			return await GetByStartNumAsync(startNum, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 StartNum（字段） 查询
		/// </summary>
		/// /// <param name = "startNum">Jackpot累计值-起始值</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_jackpot_oddsEO> GetByStartNum(long startNum, string sort_)
		{
			return GetByStartNum(startNum, 0, sort_, null);
		}
		public async Task<List<Bs_config_jackpot_oddsEO>> GetByStartNumAsync(long startNum, string sort_)
		{
			return await GetByStartNumAsync(startNum, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 StartNum（字段） 查询
		/// </summary>
		/// /// <param name = "startNum">Jackpot累计值-起始值</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_jackpot_oddsEO> GetByStartNum(long startNum, string sort_, TransactionManager tm_)
		{
			return GetByStartNum(startNum, 0, sort_, tm_);
		}
		public async Task<List<Bs_config_jackpot_oddsEO>> GetByStartNumAsync(long startNum, string sort_, TransactionManager tm_)
		{
			return await GetByStartNumAsync(startNum, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 StartNum（字段） 查询
		/// </summary>
		/// /// <param name = "startNum">Jackpot累计值-起始值</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_jackpot_oddsEO> GetByStartNum(long startNum, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`StartNum` = @StartNum", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@StartNum", startNum, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Bs_config_jackpot_oddsEO.MapDataReader);
		}
		public async Task<List<Bs_config_jackpot_oddsEO>> GetByStartNumAsync(long startNum, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`StartNum` = @StartNum", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@StartNum", startNum, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Bs_config_jackpot_oddsEO.MapDataReader);
		}
		#endregion // GetByStartNum
		#region GetByEndNum
		
		/// <summary>
		/// 按 EndNum（字段） 查询
		/// </summary>
		/// /// <param name = "endNum">Jackpot累计值-截止值</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_jackpot_oddsEO> GetByEndNum(long endNum)
		{
			return GetByEndNum(endNum, 0, string.Empty, null);
		}
		public async Task<List<Bs_config_jackpot_oddsEO>> GetByEndNumAsync(long endNum)
		{
			return await GetByEndNumAsync(endNum, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 EndNum（字段） 查询
		/// </summary>
		/// /// <param name = "endNum">Jackpot累计值-截止值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_jackpot_oddsEO> GetByEndNum(long endNum, TransactionManager tm_)
		{
			return GetByEndNum(endNum, 0, string.Empty, tm_);
		}
		public async Task<List<Bs_config_jackpot_oddsEO>> GetByEndNumAsync(long endNum, TransactionManager tm_)
		{
			return await GetByEndNumAsync(endNum, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 EndNum（字段） 查询
		/// </summary>
		/// /// <param name = "endNum">Jackpot累计值-截止值</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_jackpot_oddsEO> GetByEndNum(long endNum, int top_)
		{
			return GetByEndNum(endNum, top_, string.Empty, null);
		}
		public async Task<List<Bs_config_jackpot_oddsEO>> GetByEndNumAsync(long endNum, int top_)
		{
			return await GetByEndNumAsync(endNum, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 EndNum（字段） 查询
		/// </summary>
		/// /// <param name = "endNum">Jackpot累计值-截止值</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_jackpot_oddsEO> GetByEndNum(long endNum, int top_, TransactionManager tm_)
		{
			return GetByEndNum(endNum, top_, string.Empty, tm_);
		}
		public async Task<List<Bs_config_jackpot_oddsEO>> GetByEndNumAsync(long endNum, int top_, TransactionManager tm_)
		{
			return await GetByEndNumAsync(endNum, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 EndNum（字段） 查询
		/// </summary>
		/// /// <param name = "endNum">Jackpot累计值-截止值</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_jackpot_oddsEO> GetByEndNum(long endNum, string sort_)
		{
			return GetByEndNum(endNum, 0, sort_, null);
		}
		public async Task<List<Bs_config_jackpot_oddsEO>> GetByEndNumAsync(long endNum, string sort_)
		{
			return await GetByEndNumAsync(endNum, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 EndNum（字段） 查询
		/// </summary>
		/// /// <param name = "endNum">Jackpot累计值-截止值</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_jackpot_oddsEO> GetByEndNum(long endNum, string sort_, TransactionManager tm_)
		{
			return GetByEndNum(endNum, 0, sort_, tm_);
		}
		public async Task<List<Bs_config_jackpot_oddsEO>> GetByEndNumAsync(long endNum, string sort_, TransactionManager tm_)
		{
			return await GetByEndNumAsync(endNum, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 EndNum（字段） 查询
		/// </summary>
		/// /// <param name = "endNum">Jackpot累计值-截止值</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_jackpot_oddsEO> GetByEndNum(long endNum, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`EndNum` = @EndNum", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@EndNum", endNum, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Bs_config_jackpot_oddsEO.MapDataReader);
		}
		public async Task<List<Bs_config_jackpot_oddsEO>> GetByEndNumAsync(long endNum, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`EndNum` = @EndNum", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@EndNum", endNum, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Bs_config_jackpot_oddsEO.MapDataReader);
		}
		#endregion // GetByEndNum
		#region GetByRecDate
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">创建时间</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_jackpot_oddsEO> GetByRecDate(DateTime recDate)
		{
			return GetByRecDate(recDate, 0, string.Empty, null);
		}
		public async Task<List<Bs_config_jackpot_oddsEO>> GetByRecDateAsync(DateTime recDate)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">创建时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_jackpot_oddsEO> GetByRecDate(DateTime recDate, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, string.Empty, tm_);
		}
		public async Task<List<Bs_config_jackpot_oddsEO>> GetByRecDateAsync(DateTime recDate, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">创建时间</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_jackpot_oddsEO> GetByRecDate(DateTime recDate, int top_)
		{
			return GetByRecDate(recDate, top_, string.Empty, null);
		}
		public async Task<List<Bs_config_jackpot_oddsEO>> GetByRecDateAsync(DateTime recDate, int top_)
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
		public List<Bs_config_jackpot_oddsEO> GetByRecDate(DateTime recDate, int top_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, top_, string.Empty, tm_);
		}
		public async Task<List<Bs_config_jackpot_oddsEO>> GetByRecDateAsync(DateTime recDate, int top_, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">创建时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_jackpot_oddsEO> GetByRecDate(DateTime recDate, string sort_)
		{
			return GetByRecDate(recDate, 0, sort_, null);
		}
		public async Task<List<Bs_config_jackpot_oddsEO>> GetByRecDateAsync(DateTime recDate, string sort_)
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
		public List<Bs_config_jackpot_oddsEO> GetByRecDate(DateTime recDate, string sort_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, sort_, tm_);
		}
		public async Task<List<Bs_config_jackpot_oddsEO>> GetByRecDateAsync(DateTime recDate, string sort_, TransactionManager tm_)
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
		public List<Bs_config_jackpot_oddsEO> GetByRecDate(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return Database.ExecSqlList(sql_, paras_, tm_, Bs_config_jackpot_oddsEO.MapDataReader);
		}
		public async Task<List<Bs_config_jackpot_oddsEO>> GetByRecDateAsync(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Bs_config_jackpot_oddsEO.MapDataReader);
		}
		#endregion // GetByRecDate
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
