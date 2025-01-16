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
	/// 下注筹码表
	/// 【表 ggk_config_chips 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class Ggk_config_chipsEO : IRowMapper<Ggk_config_chipsEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public Ggk_config_chipsEO()
		{
			this.BetAmount = 0;
			this.PrizeAmount = "0";
			this.MaxRewardAmount = 0;
		}
		#region 主键原始值 & 主键集合
	    
		/// <summary>
		/// 当前对象是否保存原始主键值，当修改了主键值时为 true
		/// </summary>
		public bool HasOriginal { get; protected set; }
		
		private int _originalChipsID;
		/// <summary>
		/// 【数据库中的原始主键 ChipsID 值的副本，用于主键值更新】
		/// </summary>
		public int OriginalChipsID
		{
			get { return _originalChipsID; }
			set { HasOriginal = true; _originalChipsID = value; }
		}
	    /// <summary>
	    /// 获取主键集合。key: 数据库字段名称, value: 主键值
	    /// </summary>
	    /// <returns></returns>
	    public Dictionary<string, object> GetPrimaryKeys()
	    {
	        return new Dictionary<string, object>() { { "ChipsID", ChipsID }, };
	    }
	    /// <summary>
	    /// 获取主键集合JSON格式
	    /// </summary>
	    /// <returns></returns>
	    public string GetPrimaryKeysJson() => SerializerUtil.SerializeJson(GetPrimaryKeys());
		#endregion // 主键原始值
		#region 所有字段
		/// <summary>
		/// 筹码编码
		/// 【主键 int】
		/// </summary>
		[DataMember(Order = 1)]
		public int ChipsID { get; set; }
		/// <summary>
		/// 下注金额
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 2)]
		public long BetAmount { get; set; }
		/// <summary>
		/// 奖金
		/// 【字段 varchar(255)】
		/// </summary>
		[DataMember(Order = 3)]
		public string PrizeAmount { get; set; }
		/// <summary>
		/// jp奖金
		/// 【字段 varchar(100)】
		/// </summary>
		[DataMember(Order = 4)]
		public string JackpotAmount { get; set; }
		/// <summary>
		/// jp
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 5)]
		public long JpRewardAmount { get; set; }
		/// <summary>
		/// 最大可得
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 6)]
		public long MaxRewardAmount { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public Ggk_config_chipsEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static Ggk_config_chipsEO MapDataReader(IDataReader reader)
		{
		    Ggk_config_chipsEO ret = new Ggk_config_chipsEO();
			ret.ChipsID = reader.ToInt32("ChipsID");
			ret.OriginalChipsID = ret.ChipsID;
			ret.BetAmount = reader.ToInt64("BetAmount");
			ret.PrizeAmount = reader.ToString("PrizeAmount");
			ret.JackpotAmount = reader.ToString("JackpotAmount");
			ret.JpRewardAmount = reader.ToInt64("JpRewardAmount");
			ret.MaxRewardAmount = reader.ToInt64("MaxRewardAmount");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 下注筹码表
	/// 【表 ggk_config_chips 的操作类】
	/// </summary>
	[Obsolete]
	public class Ggk_config_chipsMO : MySqlTableMO<Ggk_config_chipsEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`ggk_config_chips`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public Ggk_config_chipsMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public Ggk_config_chipsMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public Ggk_config_chipsMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(Ggk_config_chipsEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(Ggk_config_chipsEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(Ggk_config_chipsEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`ChipsID`, `BetAmount`, `PrizeAmount`, `JackpotAmount`, `JpRewardAmount`, `MaxRewardAmount`) VALUE (@ChipsID, @BetAmount, @PrizeAmount, @JackpotAmount, @JpRewardAmount, @MaxRewardAmount);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChipsID", item.ChipsID, MySqlDbType.Int32),
				Database.CreateInParameter("@BetAmount", item.BetAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@PrizeAmount", item.PrizeAmount, MySqlDbType.VarChar),
				Database.CreateInParameter("@JackpotAmount", item.JackpotAmount, MySqlDbType.VarChar),
				Database.CreateInParameter("@JpRewardAmount", item.JpRewardAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@MaxRewardAmount", item.MaxRewardAmount, MySqlDbType.Int64),
			};
		}
		public int AddByBatch(IEnumerable<Ggk_config_chipsEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<Ggk_config_chipsEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<Ggk_config_chipsEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`ChipsID`, `BetAmount`, `PrizeAmount`, `JackpotAmount`, `JpRewardAmount`, `MaxRewardAmount`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"({item.ChipsID},{item.BetAmount},'{item.PrizeAmount}','{item.JackpotAmount}',{item.JpRewardAmount},{item.MaxRewardAmount}),");
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
		/// /// <param name = "chipsID">筹码编码</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(int chipsID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(chipsID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(int chipsID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(chipsID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(int chipsID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `ChipsID` = @ChipsID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(Ggk_config_chipsEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.ChipsID, tm_);
		}
		public async Task<int> RemoveAsync(Ggk_config_chipsEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.ChipsID, tm_);
		}
		#endregion // RemoveByPK
		
		#region RemoveByXXX
		#region RemoveByBetAmount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "betAmount">下注金额</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByBetAmount(long betAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByBetAmountData(betAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByBetAmountAsync(long betAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByBetAmountData(betAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByBetAmountData(long betAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `BetAmount` = @BetAmount";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BetAmount", betAmount, MySqlDbType.Int64));
		}
		#endregion // RemoveByBetAmount
		#region RemoveByPrizeAmount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "prizeAmount">奖金</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPrizeAmount(string prizeAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByPrizeAmountData(prizeAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPrizeAmountAsync(string prizeAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByPrizeAmountData(prizeAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByPrizeAmountData(string prizeAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `PrizeAmount` = @PrizeAmount";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PrizeAmount", prizeAmount, MySqlDbType.VarChar));
		}
		#endregion // RemoveByPrizeAmount
		#region RemoveByJackpotAmount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "jackpotAmount">jp奖金</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByJackpotAmount(string jackpotAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByJackpotAmountData(jackpotAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByJackpotAmountAsync(string jackpotAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByJackpotAmountData(jackpotAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByJackpotAmountData(string jackpotAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `JackpotAmount` = @JackpotAmount";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@JackpotAmount", jackpotAmount, MySqlDbType.VarChar));
		}
		#endregion // RemoveByJackpotAmount
		#region RemoveByJpRewardAmount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "jpRewardAmount">jp</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByJpRewardAmount(long jpRewardAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByJpRewardAmountData(jpRewardAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByJpRewardAmountAsync(long jpRewardAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByJpRewardAmountData(jpRewardAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByJpRewardAmountData(long jpRewardAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `JpRewardAmount` = @JpRewardAmount";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@JpRewardAmount", jpRewardAmount, MySqlDbType.Int64));
		}
		#endregion // RemoveByJpRewardAmount
		#region RemoveByMaxRewardAmount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "maxRewardAmount">最大可得</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByMaxRewardAmount(long maxRewardAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByMaxRewardAmountData(maxRewardAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByMaxRewardAmountAsync(long maxRewardAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByMaxRewardAmountData(maxRewardAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByMaxRewardAmountData(long maxRewardAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `MaxRewardAmount` = @MaxRewardAmount";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@MaxRewardAmount", maxRewardAmount, MySqlDbType.Int64));
		}
		#endregion // RemoveByMaxRewardAmount
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
		public int Put(Ggk_config_chipsEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(Ggk_config_chipsEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(Ggk_config_chipsEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `ChipsID` = @ChipsID, `BetAmount` = @BetAmount, `PrizeAmount` = @PrizeAmount, `JackpotAmount` = @JackpotAmount, `JpRewardAmount` = @JpRewardAmount, `MaxRewardAmount` = @MaxRewardAmount WHERE `ChipsID` = @ChipsID_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChipsID", item.ChipsID, MySqlDbType.Int32),
				Database.CreateInParameter("@BetAmount", item.BetAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@PrizeAmount", item.PrizeAmount, MySqlDbType.VarChar),
				Database.CreateInParameter("@JackpotAmount", item.JackpotAmount, MySqlDbType.VarChar),
				Database.CreateInParameter("@JpRewardAmount", item.JpRewardAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@MaxRewardAmount", item.MaxRewardAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@ChipsID_Original", item.HasOriginal ? item.OriginalChipsID : item.ChipsID, MySqlDbType.Int32),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<Ggk_config_chipsEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<Ggk_config_chipsEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "chipsID">筹码编码</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(int chipsID, string set_, params object[] values_)
		{
			return Put(set_, "`ChipsID` = @ChipsID", ConcatValues(values_, chipsID));
		}
		public async Task<int> PutByPKAsync(int chipsID, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`ChipsID` = @ChipsID", ConcatValues(values_, chipsID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "chipsID">筹码编码</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(int chipsID, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`ChipsID` = @ChipsID", tm_, ConcatValues(values_, chipsID));
		}
		public async Task<int> PutByPKAsync(int chipsID, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`ChipsID` = @ChipsID", tm_, ConcatValues(values_, chipsID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "chipsID">筹码编码</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(int chipsID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
	        };
			return Put(set_, "`ChipsID` = @ChipsID", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(int chipsID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
	        };
			return await PutAsync(set_, "`ChipsID` = @ChipsID", ConcatParameters(paras_, newParas_), tm_);
		}
		#endregion // PutByPK
		
		#region PutXXX
		#region PutBetAmount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "chipsID">筹码编码</param>
		/// /// <param name = "betAmount">下注金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBetAmountByPK(int chipsID, long betAmount, TransactionManager tm_ = null)
		{
			RepairPutBetAmountByPKData(chipsID, betAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutBetAmountByPKAsync(int chipsID, long betAmount, TransactionManager tm_ = null)
		{
			RepairPutBetAmountByPKData(chipsID, betAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutBetAmountByPKData(int chipsID, long betAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `BetAmount` = @BetAmount  WHERE `ChipsID` = @ChipsID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetAmount", betAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "betAmount">下注金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBetAmount(long betAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `BetAmount` = @BetAmount";
			var parameter_ = Database.CreateInParameter("@BetAmount", betAmount, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutBetAmountAsync(long betAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `BetAmount` = @BetAmount";
			var parameter_ = Database.CreateInParameter("@BetAmount", betAmount, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutBetAmount
		#region PutPrizeAmount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "chipsID">筹码编码</param>
		/// /// <param name = "prizeAmount">奖金</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPrizeAmountByPK(int chipsID, string prizeAmount, TransactionManager tm_ = null)
		{
			RepairPutPrizeAmountByPKData(chipsID, prizeAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutPrizeAmountByPKAsync(int chipsID, string prizeAmount, TransactionManager tm_ = null)
		{
			RepairPutPrizeAmountByPKData(chipsID, prizeAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutPrizeAmountByPKData(int chipsID, string prizeAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `PrizeAmount` = @PrizeAmount  WHERE `ChipsID` = @ChipsID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@PrizeAmount", prizeAmount, MySqlDbType.VarChar),
				Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "prizeAmount">奖金</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPrizeAmount(string prizeAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `PrizeAmount` = @PrizeAmount";
			var parameter_ = Database.CreateInParameter("@PrizeAmount", prizeAmount, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutPrizeAmountAsync(string prizeAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `PrizeAmount` = @PrizeAmount";
			var parameter_ = Database.CreateInParameter("@PrizeAmount", prizeAmount, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutPrizeAmount
		#region PutJackpotAmount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "chipsID">筹码编码</param>
		/// /// <param name = "jackpotAmount">jp奖金</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutJackpotAmountByPK(int chipsID, string jackpotAmount, TransactionManager tm_ = null)
		{
			RepairPutJackpotAmountByPKData(chipsID, jackpotAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutJackpotAmountByPKAsync(int chipsID, string jackpotAmount, TransactionManager tm_ = null)
		{
			RepairPutJackpotAmountByPKData(chipsID, jackpotAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutJackpotAmountByPKData(int chipsID, string jackpotAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `JackpotAmount` = @JackpotAmount  WHERE `ChipsID` = @ChipsID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@JackpotAmount", jackpotAmount, MySqlDbType.VarChar),
				Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "jackpotAmount">jp奖金</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutJackpotAmount(string jackpotAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `JackpotAmount` = @JackpotAmount";
			var parameter_ = Database.CreateInParameter("@JackpotAmount", jackpotAmount, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutJackpotAmountAsync(string jackpotAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `JackpotAmount` = @JackpotAmount";
			var parameter_ = Database.CreateInParameter("@JackpotAmount", jackpotAmount, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutJackpotAmount
		#region PutJpRewardAmount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "chipsID">筹码编码</param>
		/// /// <param name = "jpRewardAmount">jp</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutJpRewardAmountByPK(int chipsID, long jpRewardAmount, TransactionManager tm_ = null)
		{
			RepairPutJpRewardAmountByPKData(chipsID, jpRewardAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutJpRewardAmountByPKAsync(int chipsID, long jpRewardAmount, TransactionManager tm_ = null)
		{
			RepairPutJpRewardAmountByPKData(chipsID, jpRewardAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutJpRewardAmountByPKData(int chipsID, long jpRewardAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `JpRewardAmount` = @JpRewardAmount  WHERE `ChipsID` = @ChipsID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@JpRewardAmount", jpRewardAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "jpRewardAmount">jp</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutJpRewardAmount(long jpRewardAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `JpRewardAmount` = @JpRewardAmount";
			var parameter_ = Database.CreateInParameter("@JpRewardAmount", jpRewardAmount, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutJpRewardAmountAsync(long jpRewardAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `JpRewardAmount` = @JpRewardAmount";
			var parameter_ = Database.CreateInParameter("@JpRewardAmount", jpRewardAmount, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutJpRewardAmount
		#region PutMaxRewardAmount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "chipsID">筹码编码</param>
		/// /// <param name = "maxRewardAmount">最大可得</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutMaxRewardAmountByPK(int chipsID, long maxRewardAmount, TransactionManager tm_ = null)
		{
			RepairPutMaxRewardAmountByPKData(chipsID, maxRewardAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutMaxRewardAmountByPKAsync(int chipsID, long maxRewardAmount, TransactionManager tm_ = null)
		{
			RepairPutMaxRewardAmountByPKData(chipsID, maxRewardAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutMaxRewardAmountByPKData(int chipsID, long maxRewardAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `MaxRewardAmount` = @MaxRewardAmount  WHERE `ChipsID` = @ChipsID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MaxRewardAmount", maxRewardAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "maxRewardAmount">最大可得</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutMaxRewardAmount(long maxRewardAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `MaxRewardAmount` = @MaxRewardAmount";
			var parameter_ = Database.CreateInParameter("@MaxRewardAmount", maxRewardAmount, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutMaxRewardAmountAsync(long maxRewardAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `MaxRewardAmount` = @MaxRewardAmount";
			var parameter_ = Database.CreateInParameter("@MaxRewardAmount", maxRewardAmount, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutMaxRewardAmount
		#endregion // PutXXX
		#endregion // Put
	   
		#region Set
		
		/// <summary>
		/// 插入或者更新数据
		/// </summary>
		/// <param name = "item">要更新的实体对象</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>true:插入操作；false:更新操作</return>
		public bool Set(Ggk_config_chipsEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.ChipsID) == null)
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
		public async Task<bool> SetAsync(Ggk_config_chipsEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.ChipsID) == null)
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
		/// /// <param name = "chipsID">筹码编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public Ggk_config_chipsEO GetByPK(int chipsID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(chipsID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, Ggk_config_chipsEO.MapDataReader);
		}
		public async Task<Ggk_config_chipsEO> GetByPKAsync(int chipsID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(chipsID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Ggk_config_chipsEO.MapDataReader);
		}
		private void RepairGetByPKData(int chipsID, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`ChipsID` = @ChipsID", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
			};
		}
		#endregion // GetByPK
		
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 BetAmount（字段）
		/// </summary>
		/// /// <param name = "chipsID">筹码编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetBetAmountByPK(int chipsID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
			};
			return (long)GetScalar("`BetAmount`", "`ChipsID` = @ChipsID", paras_, tm_);
		}
		public async Task<long> GetBetAmountByPKAsync(int chipsID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
			};
			return (long)await GetScalarAsync("`BetAmount`", "`ChipsID` = @ChipsID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 PrizeAmount（字段）
		/// </summary>
		/// /// <param name = "chipsID">筹码编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetPrizeAmountByPK(int chipsID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
			};
			return (string)GetScalar("`PrizeAmount`", "`ChipsID` = @ChipsID", paras_, tm_);
		}
		public async Task<string> GetPrizeAmountByPKAsync(int chipsID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
			};
			return (string)await GetScalarAsync("`PrizeAmount`", "`ChipsID` = @ChipsID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 JackpotAmount（字段）
		/// </summary>
		/// /// <param name = "chipsID">筹码编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetJackpotAmountByPK(int chipsID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
			};
			return (string)GetScalar("`JackpotAmount`", "`ChipsID` = @ChipsID", paras_, tm_);
		}
		public async Task<string> GetJackpotAmountByPKAsync(int chipsID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
			};
			return (string)await GetScalarAsync("`JackpotAmount`", "`ChipsID` = @ChipsID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 JpRewardAmount（字段）
		/// </summary>
		/// /// <param name = "chipsID">筹码编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetJpRewardAmountByPK(int chipsID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
			};
			return (long)GetScalar("`JpRewardAmount`", "`ChipsID` = @ChipsID", paras_, tm_);
		}
		public async Task<long> GetJpRewardAmountByPKAsync(int chipsID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
			};
			return (long)await GetScalarAsync("`JpRewardAmount`", "`ChipsID` = @ChipsID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 MaxRewardAmount（字段）
		/// </summary>
		/// /// <param name = "chipsID">筹码编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetMaxRewardAmountByPK(int chipsID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
			};
			return (long)GetScalar("`MaxRewardAmount`", "`ChipsID` = @ChipsID", paras_, tm_);
		}
		public async Task<long> GetMaxRewardAmountByPKAsync(int chipsID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
			};
			return (long)await GetScalarAsync("`MaxRewardAmount`", "`ChipsID` = @ChipsID", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByBetAmount
		
		/// <summary>
		/// 按 BetAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betAmount">下注金额</param>
		/// <return>实体对象集合</return>
		public List<Ggk_config_chipsEO> GetByBetAmount(long betAmount)
		{
			return GetByBetAmount(betAmount, 0, string.Empty, null);
		}
		public async Task<List<Ggk_config_chipsEO>> GetByBetAmountAsync(long betAmount)
		{
			return await GetByBetAmountAsync(betAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BetAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betAmount">下注金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Ggk_config_chipsEO> GetByBetAmount(long betAmount, TransactionManager tm_)
		{
			return GetByBetAmount(betAmount, 0, string.Empty, tm_);
		}
		public async Task<List<Ggk_config_chipsEO>> GetByBetAmountAsync(long betAmount, TransactionManager tm_)
		{
			return await GetByBetAmountAsync(betAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BetAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betAmount">下注金额</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Ggk_config_chipsEO> GetByBetAmount(long betAmount, int top_)
		{
			return GetByBetAmount(betAmount, top_, string.Empty, null);
		}
		public async Task<List<Ggk_config_chipsEO>> GetByBetAmountAsync(long betAmount, int top_)
		{
			return await GetByBetAmountAsync(betAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BetAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betAmount">下注金额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Ggk_config_chipsEO> GetByBetAmount(long betAmount, int top_, TransactionManager tm_)
		{
			return GetByBetAmount(betAmount, top_, string.Empty, tm_);
		}
		public async Task<List<Ggk_config_chipsEO>> GetByBetAmountAsync(long betAmount, int top_, TransactionManager tm_)
		{
			return await GetByBetAmountAsync(betAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BetAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betAmount">下注金额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Ggk_config_chipsEO> GetByBetAmount(long betAmount, string sort_)
		{
			return GetByBetAmount(betAmount, 0, sort_, null);
		}
		public async Task<List<Ggk_config_chipsEO>> GetByBetAmountAsync(long betAmount, string sort_)
		{
			return await GetByBetAmountAsync(betAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 BetAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betAmount">下注金额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Ggk_config_chipsEO> GetByBetAmount(long betAmount, string sort_, TransactionManager tm_)
		{
			return GetByBetAmount(betAmount, 0, sort_, tm_);
		}
		public async Task<List<Ggk_config_chipsEO>> GetByBetAmountAsync(long betAmount, string sort_, TransactionManager tm_)
		{
			return await GetByBetAmountAsync(betAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 BetAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betAmount">下注金额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Ggk_config_chipsEO> GetByBetAmount(long betAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BetAmount` = @BetAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BetAmount", betAmount, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Ggk_config_chipsEO.MapDataReader);
		}
		public async Task<List<Ggk_config_chipsEO>> GetByBetAmountAsync(long betAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BetAmount` = @BetAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BetAmount", betAmount, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Ggk_config_chipsEO.MapDataReader);
		}
		#endregion // GetByBetAmount
		#region GetByPrizeAmount
		
		/// <summary>
		/// 按 PrizeAmount（字段） 查询
		/// </summary>
		/// /// <param name = "prizeAmount">奖金</param>
		/// <return>实体对象集合</return>
		public List<Ggk_config_chipsEO> GetByPrizeAmount(string prizeAmount)
		{
			return GetByPrizeAmount(prizeAmount, 0, string.Empty, null);
		}
		public async Task<List<Ggk_config_chipsEO>> GetByPrizeAmountAsync(string prizeAmount)
		{
			return await GetByPrizeAmountAsync(prizeAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PrizeAmount（字段） 查询
		/// </summary>
		/// /// <param name = "prizeAmount">奖金</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Ggk_config_chipsEO> GetByPrizeAmount(string prizeAmount, TransactionManager tm_)
		{
			return GetByPrizeAmount(prizeAmount, 0, string.Empty, tm_);
		}
		public async Task<List<Ggk_config_chipsEO>> GetByPrizeAmountAsync(string prizeAmount, TransactionManager tm_)
		{
			return await GetByPrizeAmountAsync(prizeAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PrizeAmount（字段） 查询
		/// </summary>
		/// /// <param name = "prizeAmount">奖金</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Ggk_config_chipsEO> GetByPrizeAmount(string prizeAmount, int top_)
		{
			return GetByPrizeAmount(prizeAmount, top_, string.Empty, null);
		}
		public async Task<List<Ggk_config_chipsEO>> GetByPrizeAmountAsync(string prizeAmount, int top_)
		{
			return await GetByPrizeAmountAsync(prizeAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 PrizeAmount（字段） 查询
		/// </summary>
		/// /// <param name = "prizeAmount">奖金</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Ggk_config_chipsEO> GetByPrizeAmount(string prizeAmount, int top_, TransactionManager tm_)
		{
			return GetByPrizeAmount(prizeAmount, top_, string.Empty, tm_);
		}
		public async Task<List<Ggk_config_chipsEO>> GetByPrizeAmountAsync(string prizeAmount, int top_, TransactionManager tm_)
		{
			return await GetByPrizeAmountAsync(prizeAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 PrizeAmount（字段） 查询
		/// </summary>
		/// /// <param name = "prizeAmount">奖金</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Ggk_config_chipsEO> GetByPrizeAmount(string prizeAmount, string sort_)
		{
			return GetByPrizeAmount(prizeAmount, 0, sort_, null);
		}
		public async Task<List<Ggk_config_chipsEO>> GetByPrizeAmountAsync(string prizeAmount, string sort_)
		{
			return await GetByPrizeAmountAsync(prizeAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 PrizeAmount（字段） 查询
		/// </summary>
		/// /// <param name = "prizeAmount">奖金</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Ggk_config_chipsEO> GetByPrizeAmount(string prizeAmount, string sort_, TransactionManager tm_)
		{
			return GetByPrizeAmount(prizeAmount, 0, sort_, tm_);
		}
		public async Task<List<Ggk_config_chipsEO>> GetByPrizeAmountAsync(string prizeAmount, string sort_, TransactionManager tm_)
		{
			return await GetByPrizeAmountAsync(prizeAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 PrizeAmount（字段） 查询
		/// </summary>
		/// /// <param name = "prizeAmount">奖金</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Ggk_config_chipsEO> GetByPrizeAmount(string prizeAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PrizeAmount` = @PrizeAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PrizeAmount", prizeAmount, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Ggk_config_chipsEO.MapDataReader);
		}
		public async Task<List<Ggk_config_chipsEO>> GetByPrizeAmountAsync(string prizeAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`PrizeAmount` = @PrizeAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@PrizeAmount", prizeAmount, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Ggk_config_chipsEO.MapDataReader);
		}
		#endregion // GetByPrizeAmount
		#region GetByJackpotAmount
		
		/// <summary>
		/// 按 JackpotAmount（字段） 查询
		/// </summary>
		/// /// <param name = "jackpotAmount">jp奖金</param>
		/// <return>实体对象集合</return>
		public List<Ggk_config_chipsEO> GetByJackpotAmount(string jackpotAmount)
		{
			return GetByJackpotAmount(jackpotAmount, 0, string.Empty, null);
		}
		public async Task<List<Ggk_config_chipsEO>> GetByJackpotAmountAsync(string jackpotAmount)
		{
			return await GetByJackpotAmountAsync(jackpotAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 JackpotAmount（字段） 查询
		/// </summary>
		/// /// <param name = "jackpotAmount">jp奖金</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Ggk_config_chipsEO> GetByJackpotAmount(string jackpotAmount, TransactionManager tm_)
		{
			return GetByJackpotAmount(jackpotAmount, 0, string.Empty, tm_);
		}
		public async Task<List<Ggk_config_chipsEO>> GetByJackpotAmountAsync(string jackpotAmount, TransactionManager tm_)
		{
			return await GetByJackpotAmountAsync(jackpotAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 JackpotAmount（字段） 查询
		/// </summary>
		/// /// <param name = "jackpotAmount">jp奖金</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Ggk_config_chipsEO> GetByJackpotAmount(string jackpotAmount, int top_)
		{
			return GetByJackpotAmount(jackpotAmount, top_, string.Empty, null);
		}
		public async Task<List<Ggk_config_chipsEO>> GetByJackpotAmountAsync(string jackpotAmount, int top_)
		{
			return await GetByJackpotAmountAsync(jackpotAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 JackpotAmount（字段） 查询
		/// </summary>
		/// /// <param name = "jackpotAmount">jp奖金</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Ggk_config_chipsEO> GetByJackpotAmount(string jackpotAmount, int top_, TransactionManager tm_)
		{
			return GetByJackpotAmount(jackpotAmount, top_, string.Empty, tm_);
		}
		public async Task<List<Ggk_config_chipsEO>> GetByJackpotAmountAsync(string jackpotAmount, int top_, TransactionManager tm_)
		{
			return await GetByJackpotAmountAsync(jackpotAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 JackpotAmount（字段） 查询
		/// </summary>
		/// /// <param name = "jackpotAmount">jp奖金</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Ggk_config_chipsEO> GetByJackpotAmount(string jackpotAmount, string sort_)
		{
			return GetByJackpotAmount(jackpotAmount, 0, sort_, null);
		}
		public async Task<List<Ggk_config_chipsEO>> GetByJackpotAmountAsync(string jackpotAmount, string sort_)
		{
			return await GetByJackpotAmountAsync(jackpotAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 JackpotAmount（字段） 查询
		/// </summary>
		/// /// <param name = "jackpotAmount">jp奖金</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Ggk_config_chipsEO> GetByJackpotAmount(string jackpotAmount, string sort_, TransactionManager tm_)
		{
			return GetByJackpotAmount(jackpotAmount, 0, sort_, tm_);
		}
		public async Task<List<Ggk_config_chipsEO>> GetByJackpotAmountAsync(string jackpotAmount, string sort_, TransactionManager tm_)
		{
			return await GetByJackpotAmountAsync(jackpotAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 JackpotAmount（字段） 查询
		/// </summary>
		/// /// <param name = "jackpotAmount">jp奖金</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Ggk_config_chipsEO> GetByJackpotAmount(string jackpotAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`JackpotAmount` = @JackpotAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@JackpotAmount", jackpotAmount, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Ggk_config_chipsEO.MapDataReader);
		}
		public async Task<List<Ggk_config_chipsEO>> GetByJackpotAmountAsync(string jackpotAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`JackpotAmount` = @JackpotAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@JackpotAmount", jackpotAmount, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Ggk_config_chipsEO.MapDataReader);
		}
		#endregion // GetByJackpotAmount
		#region GetByJpRewardAmount
		
		/// <summary>
		/// 按 JpRewardAmount（字段） 查询
		/// </summary>
		/// /// <param name = "jpRewardAmount">jp</param>
		/// <return>实体对象集合</return>
		public List<Ggk_config_chipsEO> GetByJpRewardAmount(long jpRewardAmount)
		{
			return GetByJpRewardAmount(jpRewardAmount, 0, string.Empty, null);
		}
		public async Task<List<Ggk_config_chipsEO>> GetByJpRewardAmountAsync(long jpRewardAmount)
		{
			return await GetByJpRewardAmountAsync(jpRewardAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 JpRewardAmount（字段） 查询
		/// </summary>
		/// /// <param name = "jpRewardAmount">jp</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Ggk_config_chipsEO> GetByJpRewardAmount(long jpRewardAmount, TransactionManager tm_)
		{
			return GetByJpRewardAmount(jpRewardAmount, 0, string.Empty, tm_);
		}
		public async Task<List<Ggk_config_chipsEO>> GetByJpRewardAmountAsync(long jpRewardAmount, TransactionManager tm_)
		{
			return await GetByJpRewardAmountAsync(jpRewardAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 JpRewardAmount（字段） 查询
		/// </summary>
		/// /// <param name = "jpRewardAmount">jp</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Ggk_config_chipsEO> GetByJpRewardAmount(long jpRewardAmount, int top_)
		{
			return GetByJpRewardAmount(jpRewardAmount, top_, string.Empty, null);
		}
		public async Task<List<Ggk_config_chipsEO>> GetByJpRewardAmountAsync(long jpRewardAmount, int top_)
		{
			return await GetByJpRewardAmountAsync(jpRewardAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 JpRewardAmount（字段） 查询
		/// </summary>
		/// /// <param name = "jpRewardAmount">jp</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Ggk_config_chipsEO> GetByJpRewardAmount(long jpRewardAmount, int top_, TransactionManager tm_)
		{
			return GetByJpRewardAmount(jpRewardAmount, top_, string.Empty, tm_);
		}
		public async Task<List<Ggk_config_chipsEO>> GetByJpRewardAmountAsync(long jpRewardAmount, int top_, TransactionManager tm_)
		{
			return await GetByJpRewardAmountAsync(jpRewardAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 JpRewardAmount（字段） 查询
		/// </summary>
		/// /// <param name = "jpRewardAmount">jp</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Ggk_config_chipsEO> GetByJpRewardAmount(long jpRewardAmount, string sort_)
		{
			return GetByJpRewardAmount(jpRewardAmount, 0, sort_, null);
		}
		public async Task<List<Ggk_config_chipsEO>> GetByJpRewardAmountAsync(long jpRewardAmount, string sort_)
		{
			return await GetByJpRewardAmountAsync(jpRewardAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 JpRewardAmount（字段） 查询
		/// </summary>
		/// /// <param name = "jpRewardAmount">jp</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Ggk_config_chipsEO> GetByJpRewardAmount(long jpRewardAmount, string sort_, TransactionManager tm_)
		{
			return GetByJpRewardAmount(jpRewardAmount, 0, sort_, tm_);
		}
		public async Task<List<Ggk_config_chipsEO>> GetByJpRewardAmountAsync(long jpRewardAmount, string sort_, TransactionManager tm_)
		{
			return await GetByJpRewardAmountAsync(jpRewardAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 JpRewardAmount（字段） 查询
		/// </summary>
		/// /// <param name = "jpRewardAmount">jp</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Ggk_config_chipsEO> GetByJpRewardAmount(long jpRewardAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`JpRewardAmount` = @JpRewardAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@JpRewardAmount", jpRewardAmount, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Ggk_config_chipsEO.MapDataReader);
		}
		public async Task<List<Ggk_config_chipsEO>> GetByJpRewardAmountAsync(long jpRewardAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`JpRewardAmount` = @JpRewardAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@JpRewardAmount", jpRewardAmount, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Ggk_config_chipsEO.MapDataReader);
		}
		#endregion // GetByJpRewardAmount
		#region GetByMaxRewardAmount
		
		/// <summary>
		/// 按 MaxRewardAmount（字段） 查询
		/// </summary>
		/// /// <param name = "maxRewardAmount">最大可得</param>
		/// <return>实体对象集合</return>
		public List<Ggk_config_chipsEO> GetByMaxRewardAmount(long maxRewardAmount)
		{
			return GetByMaxRewardAmount(maxRewardAmount, 0, string.Empty, null);
		}
		public async Task<List<Ggk_config_chipsEO>> GetByMaxRewardAmountAsync(long maxRewardAmount)
		{
			return await GetByMaxRewardAmountAsync(maxRewardAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 MaxRewardAmount（字段） 查询
		/// </summary>
		/// /// <param name = "maxRewardAmount">最大可得</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Ggk_config_chipsEO> GetByMaxRewardAmount(long maxRewardAmount, TransactionManager tm_)
		{
			return GetByMaxRewardAmount(maxRewardAmount, 0, string.Empty, tm_);
		}
		public async Task<List<Ggk_config_chipsEO>> GetByMaxRewardAmountAsync(long maxRewardAmount, TransactionManager tm_)
		{
			return await GetByMaxRewardAmountAsync(maxRewardAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 MaxRewardAmount（字段） 查询
		/// </summary>
		/// /// <param name = "maxRewardAmount">最大可得</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Ggk_config_chipsEO> GetByMaxRewardAmount(long maxRewardAmount, int top_)
		{
			return GetByMaxRewardAmount(maxRewardAmount, top_, string.Empty, null);
		}
		public async Task<List<Ggk_config_chipsEO>> GetByMaxRewardAmountAsync(long maxRewardAmount, int top_)
		{
			return await GetByMaxRewardAmountAsync(maxRewardAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 MaxRewardAmount（字段） 查询
		/// </summary>
		/// /// <param name = "maxRewardAmount">最大可得</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Ggk_config_chipsEO> GetByMaxRewardAmount(long maxRewardAmount, int top_, TransactionManager tm_)
		{
			return GetByMaxRewardAmount(maxRewardAmount, top_, string.Empty, tm_);
		}
		public async Task<List<Ggk_config_chipsEO>> GetByMaxRewardAmountAsync(long maxRewardAmount, int top_, TransactionManager tm_)
		{
			return await GetByMaxRewardAmountAsync(maxRewardAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 MaxRewardAmount（字段） 查询
		/// </summary>
		/// /// <param name = "maxRewardAmount">最大可得</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Ggk_config_chipsEO> GetByMaxRewardAmount(long maxRewardAmount, string sort_)
		{
			return GetByMaxRewardAmount(maxRewardAmount, 0, sort_, null);
		}
		public async Task<List<Ggk_config_chipsEO>> GetByMaxRewardAmountAsync(long maxRewardAmount, string sort_)
		{
			return await GetByMaxRewardAmountAsync(maxRewardAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 MaxRewardAmount（字段） 查询
		/// </summary>
		/// /// <param name = "maxRewardAmount">最大可得</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Ggk_config_chipsEO> GetByMaxRewardAmount(long maxRewardAmount, string sort_, TransactionManager tm_)
		{
			return GetByMaxRewardAmount(maxRewardAmount, 0, sort_, tm_);
		}
		public async Task<List<Ggk_config_chipsEO>> GetByMaxRewardAmountAsync(long maxRewardAmount, string sort_, TransactionManager tm_)
		{
			return await GetByMaxRewardAmountAsync(maxRewardAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 MaxRewardAmount（字段） 查询
		/// </summary>
		/// /// <param name = "maxRewardAmount">最大可得</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Ggk_config_chipsEO> GetByMaxRewardAmount(long maxRewardAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`MaxRewardAmount` = @MaxRewardAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@MaxRewardAmount", maxRewardAmount, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Ggk_config_chipsEO.MapDataReader);
		}
		public async Task<List<Ggk_config_chipsEO>> GetByMaxRewardAmountAsync(long maxRewardAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`MaxRewardAmount` = @MaxRewardAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@MaxRewardAmount", maxRewardAmount, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Ggk_config_chipsEO.MapDataReader);
		}
		#endregion // GetByMaxRewardAmount
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
