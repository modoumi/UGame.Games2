/******************************************************
 * 此代码由代码生成器工具自动生成，请不要修改
 * TinyFx代码生成器核心库版本号：1.0.0.0
 * git: https://github.com/jh98net/TinyFx
 * 文档生成时间：2023-12-09 15: 12:43
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
	/// 下注详情
	/// 【表 ggk_bet_detail 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class Ggk_bet_detailEO : IRowMapper<Ggk_bet_detailEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public Ggk_bet_detailEO()
		{
			this.ChipsID = 0;
			this.BetBaseAmount = 0;
			this.RoundIdx = 0;
			this.FreeSpinCount = 0;
			this.WinAmount = 0;
			this.AllNumList = "0";
			this.RewardNumList = "0";
			this.JPRewardValue = 0;
			this.OrderStatus = 0;
			this.RecDate = DateTime.Now;
		}
		#region 主键原始值 & 主键集合
	    
		/// <summary>
		/// 当前对象是否保存原始主键值，当修改了主键值时为 true
		/// </summary>
		public bool HasOriginal { get; protected set; }
		
		private long _originalBetID;
		/// <summary>
		/// 【数据库中的原始主键 BetID 值的副本，用于主键值更新】
		/// </summary>
		public long OriginalBetID
		{
			get { return _originalBetID; }
			set { HasOriginal = true; _originalBetID = value; }
		}
	    /// <summary>
	    /// 获取主键集合。key: 数据库字段名称, value: 主键值
	    /// </summary>
	    /// <returns></returns>
	    public Dictionary<string, object> GetPrimaryKeys()
	    {
	        return new Dictionary<string, object>() { { "BetID", BetID }, };
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
		/// 【主键 bigint】
		/// </summary>
		[DataMember(Order = 1)]
		public long BetID { get; set; }
		/// <summary>
		/// 用户Id
		/// 【字段 varchar(38)】
		/// </summary>
		[DataMember(Order = 2)]
		public string UserID { get; set; }
		/// <summary>
		/// 下注配置ID
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 3)]
		public int ChipsID { get; set; }
		/// <summary>
		/// 实际下注金额
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 4)]
		public long BetBaseAmount { get; set; }
		/// <summary>
		/// 抽过多少次，到10清空，转换一次freeSpinCount
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 5)]
		public int RoundIdx { get; set; }
		/// <summary>
		/// 免费摇奖次数
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 6)]
		public int FreeSpinCount { get; set; }
		/// <summary>
		/// 所有彩票的奖励总和
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 7)]
		public long WinAmount { get; set; }
		/// <summary>
		/// 生成的组合
		/// 【字段 varchar(1000)】
		/// </summary>
		[DataMember(Order = 8)]
		public string HistoryList { get; set; }
		/// <summary>
		/// 本期生成所有数字
		/// 【字段 varchar(100)】
		/// </summary>
		[DataMember(Order = 9)]
		public string AllNumList { get; set; }
		/// <summary>
		/// 彩票中奖数字
		/// 【字段 varchar(100)】
		/// </summary>
		[DataMember(Order = 10)]
		public string RewardNumList { get; set; }
		/// <summary>
		/// JP 金额
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 11)]
		public long JPRewardValue { get; set; }
		/// <summary>
		/// 状态0-初始1-处理中2-成功3-失败4-已回滚5-异常且需处理6-异常已处理
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 12)]
		public int OrderStatus { get; set; }
		/// <summary>
		/// 记录时间
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 13)]
		public DateTime? RecDate { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public Ggk_bet_detailEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static Ggk_bet_detailEO MapDataReader(IDataReader reader)
		{
		    Ggk_bet_detailEO ret = new Ggk_bet_detailEO();
			ret.BetID = reader.ToInt64("BetID");
			ret.OriginalBetID = ret.BetID;
			ret.UserID = reader.ToString("UserID");
			ret.ChipsID = reader.ToInt32("ChipsID");
			ret.BetBaseAmount = reader.ToInt64("BetBaseAmount");
			ret.RoundIdx = reader.ToInt32("RoundIdx");
			ret.FreeSpinCount = reader.ToInt32("FreeSpinCount");
			ret.WinAmount = reader.ToInt64("WinAmount");
			ret.HistoryList = reader.ToString("HistoryList");
			ret.AllNumList = reader.ToString("AllNumList");
			ret.RewardNumList = reader.ToString("RewardNumList");
			ret.JPRewardValue = reader.ToInt64("JPRewardValue");
			ret.OrderStatus = reader.ToInt32("OrderStatus");
			ret.RecDate = reader.ToDateTimeN("RecDate");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 下注详情
	/// 【表 ggk_bet_detail 的操作类】
	/// </summary>
	[Obsolete]
	public class Ggk_bet_detailMO : MySqlTableMO<Ggk_bet_detailEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`ggk_bet_detail`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public Ggk_bet_detailMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public Ggk_bet_detailMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public Ggk_bet_detailMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(Ggk_bet_detailEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(Ggk_bet_detailEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(Ggk_bet_detailEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`BetID`, `UserID`, `ChipsID`, `BetBaseAmount`, `RoundIdx`, `FreeSpinCount`, `WinAmount`, `HistoryList`, `AllNumList`, `RewardNumList`, `JPRewardValue`, `OrderStatus`, `RecDate`) VALUE (@BetID, @UserID, @ChipsID, @BetBaseAmount, @RoundIdx, @FreeSpinCount, @WinAmount, @HistoryList, @AllNumList, @RewardNumList, @JPRewardValue, @OrderStatus, @RecDate);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", item.BetID, MySqlDbType.Int64),
				Database.CreateInParameter("@UserID", item.UserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@ChipsID", item.ChipsID, MySqlDbType.Int32),
				Database.CreateInParameter("@BetBaseAmount", item.BetBaseAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@RoundIdx", item.RoundIdx, MySqlDbType.Int32),
				Database.CreateInParameter("@FreeSpinCount", item.FreeSpinCount, MySqlDbType.Int32),
				Database.CreateInParameter("@WinAmount", item.WinAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@HistoryList", item.HistoryList, MySqlDbType.VarChar),
				Database.CreateInParameter("@AllNumList", item.AllNumList, MySqlDbType.VarChar),
				Database.CreateInParameter("@RewardNumList", item.RewardNumList, MySqlDbType.VarChar),
				Database.CreateInParameter("@JPRewardValue", item.JPRewardValue, MySqlDbType.Int64),
				Database.CreateInParameter("@OrderStatus", item.OrderStatus, MySqlDbType.Int32),
				Database.CreateInParameter("@RecDate", item.RecDate.HasValue ? item.RecDate.Value : (object)DBNull.Value, MySqlDbType.DateTime),
			};
		}
		public int AddByBatch(IEnumerable<Ggk_bet_detailEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<Ggk_bet_detailEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<Ggk_bet_detailEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`BetID`, `UserID`, `ChipsID`, `BetBaseAmount`, `RoundIdx`, `FreeSpinCount`, `WinAmount`, `HistoryList`, `AllNumList`, `RewardNumList`, `JPRewardValue`, `OrderStatus`, `RecDate`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"({item.BetID},'{item.UserID}',{item.ChipsID},{item.BetBaseAmount},{item.RoundIdx},{item.FreeSpinCount},{item.WinAmount},'{item.HistoryList}','{item.AllNumList}','{item.RewardNumList}',{item.JPRewardValue},{item.OrderStatus},'{item.RecDate?.ToString("yyyy-MM-dd HH:mm:ss")}'),");
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
		/// /// <param name = "betID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(long betID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(betID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(long betID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(betID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(long betID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `BetID` = @BetID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(Ggk_bet_detailEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.BetID, tm_);
		}
		public async Task<int> RemoveAsync(Ggk_bet_detailEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.BetID, tm_);
		}
		#endregion // RemoveByPK
		
		#region RemoveByXXX
		#region RemoveByUserID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "userID">用户Id</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByUserID(string userID, TransactionManager tm_ = null)
		{
			RepairRemoveByUserIDData(userID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByUserIDAsync(string userID, TransactionManager tm_ = null)
		{
			RepairRemoveByUserIDData(userID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByUserIDData(string userID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar));
		}
		#endregion // RemoveByUserID
		#region RemoveByChipsID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "chipsID">下注配置ID</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByChipsID(int chipsID, TransactionManager tm_ = null)
		{
			RepairRemoveByChipsIDData(chipsID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByChipsIDAsync(int chipsID, TransactionManager tm_ = null)
		{
			RepairRemoveByChipsIDData(chipsID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByChipsIDData(int chipsID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `ChipsID` = @ChipsID";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32));
		}
		#endregion // RemoveByChipsID
		#region RemoveByBetBaseAmount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "betBaseAmount">实际下注金额</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByBetBaseAmount(long betBaseAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByBetBaseAmountData(betBaseAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByBetBaseAmountAsync(long betBaseAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByBetBaseAmountData(betBaseAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByBetBaseAmountData(long betBaseAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `BetBaseAmount` = @BetBaseAmount";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BetBaseAmount", betBaseAmount, MySqlDbType.Int64));
		}
		#endregion // RemoveByBetBaseAmount
		#region RemoveByRoundIdx
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "roundIdx">抽过多少次，到10清空，转换一次freeSpinCount</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByRoundIdx(int roundIdx, TransactionManager tm_ = null)
		{
			RepairRemoveByRoundIdxData(roundIdx, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByRoundIdxAsync(int roundIdx, TransactionManager tm_ = null)
		{
			RepairRemoveByRoundIdxData(roundIdx, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByRoundIdxData(int roundIdx, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `RoundIdx` = @RoundIdx";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RoundIdx", roundIdx, MySqlDbType.Int32));
		}
		#endregion // RemoveByRoundIdx
		#region RemoveByFreeSpinCount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "freeSpinCount">免费摇奖次数</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByFreeSpinCount(int freeSpinCount, TransactionManager tm_ = null)
		{
			RepairRemoveByFreeSpinCountData(freeSpinCount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByFreeSpinCountAsync(int freeSpinCount, TransactionManager tm_ = null)
		{
			RepairRemoveByFreeSpinCountData(freeSpinCount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByFreeSpinCountData(int freeSpinCount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `FreeSpinCount` = @FreeSpinCount";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FreeSpinCount", freeSpinCount, MySqlDbType.Int32));
		}
		#endregion // RemoveByFreeSpinCount
		#region RemoveByWinAmount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "winAmount">所有彩票的奖励总和</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByWinAmount(long winAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByWinAmountData(winAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByWinAmountAsync(long winAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByWinAmountData(winAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByWinAmountData(long winAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `WinAmount` = @WinAmount";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@WinAmount", winAmount, MySqlDbType.Int64));
		}
		#endregion // RemoveByWinAmount
		#region RemoveByHistoryList
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "historyList">生成的组合</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByHistoryList(string historyList, TransactionManager tm_ = null)
		{
			RepairRemoveByHistoryListData(historyList, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByHistoryListAsync(string historyList, TransactionManager tm_ = null)
		{
			RepairRemoveByHistoryListData(historyList, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByHistoryListData(string historyList, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `HistoryList` = @HistoryList";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@HistoryList", historyList, MySqlDbType.VarChar));
		}
		#endregion // RemoveByHistoryList
		#region RemoveByAllNumList
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "allNumList">本期生成所有数字</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByAllNumList(string allNumList, TransactionManager tm_ = null)
		{
			RepairRemoveByAllNumListData(allNumList, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByAllNumListAsync(string allNumList, TransactionManager tm_ = null)
		{
			RepairRemoveByAllNumListData(allNumList, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByAllNumListData(string allNumList, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `AllNumList` = @AllNumList";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@AllNumList", allNumList, MySqlDbType.VarChar));
		}
		#endregion // RemoveByAllNumList
		#region RemoveByRewardNumList
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "rewardNumList">彩票中奖数字</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByRewardNumList(string rewardNumList, TransactionManager tm_ = null)
		{
			RepairRemoveByRewardNumListData(rewardNumList, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByRewardNumListAsync(string rewardNumList, TransactionManager tm_ = null)
		{
			RepairRemoveByRewardNumListData(rewardNumList, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByRewardNumListData(string rewardNumList, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `RewardNumList` = @RewardNumList";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RewardNumList", rewardNumList, MySqlDbType.VarChar));
		}
		#endregion // RemoveByRewardNumList
		#region RemoveByJPRewardValue
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "jPRewardValue">JP 金额</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByJPRewardValue(long jPRewardValue, TransactionManager tm_ = null)
		{
			RepairRemoveByJPRewardValueData(jPRewardValue, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByJPRewardValueAsync(long jPRewardValue, TransactionManager tm_ = null)
		{
			RepairRemoveByJPRewardValueData(jPRewardValue, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByJPRewardValueData(long jPRewardValue, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `JPRewardValue` = @JPRewardValue";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@JPRewardValue", jPRewardValue, MySqlDbType.Int64));
		}
		#endregion // RemoveByJPRewardValue
		#region RemoveByOrderStatus
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "orderStatus">状态0-初始1-处理中2-成功3-失败4-已回滚5-异常且需处理6-异常已处理</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByOrderStatus(int orderStatus, TransactionManager tm_ = null)
		{
			RepairRemoveByOrderStatusData(orderStatus, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByOrderStatusAsync(int orderStatus, TransactionManager tm_ = null)
		{
			RepairRemoveByOrderStatusData(orderStatus, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByOrderStatusData(int orderStatus, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `OrderStatus` = @OrderStatus";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OrderStatus", orderStatus, MySqlDbType.Int32));
		}
		#endregion // RemoveByOrderStatus
		#region RemoveByRecDate
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByRecDate(DateTime? recDate, TransactionManager tm_ = null)
		{
			RepairRemoveByRecDateData(recDate.Value, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByRecDateAsync(DateTime? recDate, TransactionManager tm_ = null)
		{
			RepairRemoveByRecDateData(recDate.Value, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByRecDateData(DateTime? recDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (recDate.HasValue ? "`RecDate` = @RecDate" : "`RecDate` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (recDate.HasValue)
				paras_.Add(Database.CreateInParameter("@RecDate", recDate.Value, MySqlDbType.DateTime));
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
		public int Put(Ggk_bet_detailEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(Ggk_bet_detailEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(Ggk_bet_detailEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `BetID` = @BetID, `UserID` = @UserID, `ChipsID` = @ChipsID, `BetBaseAmount` = @BetBaseAmount, `RoundIdx` = @RoundIdx, `FreeSpinCount` = @FreeSpinCount, `WinAmount` = @WinAmount, `HistoryList` = @HistoryList, `AllNumList` = @AllNumList, `RewardNumList` = @RewardNumList, `JPRewardValue` = @JPRewardValue, `OrderStatus` = @OrderStatus WHERE `BetID` = @BetID_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", item.BetID, MySqlDbType.Int64),
				Database.CreateInParameter("@UserID", item.UserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@ChipsID", item.ChipsID, MySqlDbType.Int32),
				Database.CreateInParameter("@BetBaseAmount", item.BetBaseAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@RoundIdx", item.RoundIdx, MySqlDbType.Int32),
				Database.CreateInParameter("@FreeSpinCount", item.FreeSpinCount, MySqlDbType.Int32),
				Database.CreateInParameter("@WinAmount", item.WinAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@HistoryList", item.HistoryList, MySqlDbType.VarChar),
				Database.CreateInParameter("@AllNumList", item.AllNumList, MySqlDbType.VarChar),
				Database.CreateInParameter("@RewardNumList", item.RewardNumList, MySqlDbType.VarChar),
				Database.CreateInParameter("@JPRewardValue", item.JPRewardValue, MySqlDbType.Int64),
				Database.CreateInParameter("@OrderStatus", item.OrderStatus, MySqlDbType.Int32),
				Database.CreateInParameter("@BetID_Original", item.HasOriginal ? item.OriginalBetID : item.BetID, MySqlDbType.Int64),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<Ggk_bet_detailEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<Ggk_bet_detailEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "betID">主键</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(long betID, string set_, params object[] values_)
		{
			return Put(set_, "`BetID` = @BetID", ConcatValues(values_, betID));
		}
		public async Task<int> PutByPKAsync(long betID, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`BetID` = @BetID", ConcatValues(values_, betID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(long betID, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`BetID` = @BetID", tm_, ConcatValues(values_, betID));
		}
		public async Task<int> PutByPKAsync(long betID, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`BetID` = @BetID", tm_, ConcatValues(values_, betID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(long betID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
	        };
			return Put(set_, "`BetID` = @BetID", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(long betID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
	        };
			return await PutAsync(set_, "`BetID` = @BetID", ConcatParameters(paras_, newParas_), tm_);
		}
		#endregion // PutByPK
		
		#region PutXXX
		#region PutUserID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// /// <param name = "userID">用户Id</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutUserIDByPK(long betID, string userID, TransactionManager tm_ = null)
		{
			RepairPutUserIDByPKData(betID, userID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutUserIDByPKAsync(long betID, string userID, TransactionManager tm_ = null)
		{
			RepairPutUserIDByPKData(betID, userID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutUserIDByPKData(long betID, string userID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `UserID` = @UserID  WHERE `BetID` = @BetID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "userID">用户Id</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutUserID(string userID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `UserID` = @UserID";
			var parameter_ = Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutUserIDAsync(string userID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `UserID` = @UserID";
			var parameter_ = Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutUserID
		#region PutChipsID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// /// <param name = "chipsID">下注配置ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutChipsIDByPK(long betID, int chipsID, TransactionManager tm_ = null)
		{
			RepairPutChipsIDByPKData(betID, chipsID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutChipsIDByPKAsync(long betID, int chipsID, TransactionManager tm_ = null)
		{
			RepairPutChipsIDByPKData(betID, chipsID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutChipsIDByPKData(long betID, int chipsID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `ChipsID` = @ChipsID  WHERE `BetID` = @BetID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "chipsID">下注配置ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutChipsID(int chipsID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ChipsID` = @ChipsID";
			var parameter_ = Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutChipsIDAsync(int chipsID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ChipsID` = @ChipsID";
			var parameter_ = Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutChipsID
		#region PutBetBaseAmount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// /// <param name = "betBaseAmount">实际下注金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBetBaseAmountByPK(long betID, long betBaseAmount, TransactionManager tm_ = null)
		{
			RepairPutBetBaseAmountByPKData(betID, betBaseAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutBetBaseAmountByPKAsync(long betID, long betBaseAmount, TransactionManager tm_ = null)
		{
			RepairPutBetBaseAmountByPKData(betID, betBaseAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutBetBaseAmountByPKData(long betID, long betBaseAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `BetBaseAmount` = @BetBaseAmount  WHERE `BetID` = @BetID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetBaseAmount", betBaseAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "betBaseAmount">实际下注金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBetBaseAmount(long betBaseAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `BetBaseAmount` = @BetBaseAmount";
			var parameter_ = Database.CreateInParameter("@BetBaseAmount", betBaseAmount, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutBetBaseAmountAsync(long betBaseAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `BetBaseAmount` = @BetBaseAmount";
			var parameter_ = Database.CreateInParameter("@BetBaseAmount", betBaseAmount, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutBetBaseAmount
		#region PutRoundIdx
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// /// <param name = "roundIdx">抽过多少次，到10清空，转换一次freeSpinCount</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRoundIdxByPK(long betID, int roundIdx, TransactionManager tm_ = null)
		{
			RepairPutRoundIdxByPKData(betID, roundIdx, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutRoundIdxByPKAsync(long betID, int roundIdx, TransactionManager tm_ = null)
		{
			RepairPutRoundIdxByPKData(betID, roundIdx, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutRoundIdxByPKData(long betID, int roundIdx, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `RoundIdx` = @RoundIdx  WHERE `BetID` = @BetID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RoundIdx", roundIdx, MySqlDbType.Int32),
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "roundIdx">抽过多少次，到10清空，转换一次freeSpinCount</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRoundIdx(int roundIdx, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `RoundIdx` = @RoundIdx";
			var parameter_ = Database.CreateInParameter("@RoundIdx", roundIdx, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutRoundIdxAsync(int roundIdx, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `RoundIdx` = @RoundIdx";
			var parameter_ = Database.CreateInParameter("@RoundIdx", roundIdx, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutRoundIdx
		#region PutFreeSpinCount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// /// <param name = "freeSpinCount">免费摇奖次数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutFreeSpinCountByPK(long betID, int freeSpinCount, TransactionManager tm_ = null)
		{
			RepairPutFreeSpinCountByPKData(betID, freeSpinCount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutFreeSpinCountByPKAsync(long betID, int freeSpinCount, TransactionManager tm_ = null)
		{
			RepairPutFreeSpinCountByPKData(betID, freeSpinCount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutFreeSpinCountByPKData(long betID, int freeSpinCount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `FreeSpinCount` = @FreeSpinCount  WHERE `BetID` = @BetID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@FreeSpinCount", freeSpinCount, MySqlDbType.Int32),
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "freeSpinCount">免费摇奖次数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutFreeSpinCount(int freeSpinCount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `FreeSpinCount` = @FreeSpinCount";
			var parameter_ = Database.CreateInParameter("@FreeSpinCount", freeSpinCount, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutFreeSpinCountAsync(int freeSpinCount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `FreeSpinCount` = @FreeSpinCount";
			var parameter_ = Database.CreateInParameter("@FreeSpinCount", freeSpinCount, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutFreeSpinCount
		#region PutWinAmount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// /// <param name = "winAmount">所有彩票的奖励总和</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutWinAmountByPK(long betID, long winAmount, TransactionManager tm_ = null)
		{
			RepairPutWinAmountByPKData(betID, winAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutWinAmountByPKAsync(long betID, long winAmount, TransactionManager tm_ = null)
		{
			RepairPutWinAmountByPKData(betID, winAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutWinAmountByPKData(long betID, long winAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `WinAmount` = @WinAmount  WHERE `BetID` = @BetID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@WinAmount", winAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "winAmount">所有彩票的奖励总和</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutWinAmount(long winAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `WinAmount` = @WinAmount";
			var parameter_ = Database.CreateInParameter("@WinAmount", winAmount, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutWinAmountAsync(long winAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `WinAmount` = @WinAmount";
			var parameter_ = Database.CreateInParameter("@WinAmount", winAmount, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutWinAmount
		#region PutHistoryList
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// /// <param name = "historyList">生成的组合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutHistoryListByPK(long betID, string historyList, TransactionManager tm_ = null)
		{
			RepairPutHistoryListByPKData(betID, historyList, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutHistoryListByPKAsync(long betID, string historyList, TransactionManager tm_ = null)
		{
			RepairPutHistoryListByPKData(betID, historyList, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutHistoryListByPKData(long betID, string historyList, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `HistoryList` = @HistoryList  WHERE `BetID` = @BetID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@HistoryList", historyList, MySqlDbType.VarChar),
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "historyList">生成的组合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutHistoryList(string historyList, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `HistoryList` = @HistoryList";
			var parameter_ = Database.CreateInParameter("@HistoryList", historyList, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutHistoryListAsync(string historyList, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `HistoryList` = @HistoryList";
			var parameter_ = Database.CreateInParameter("@HistoryList", historyList, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutHistoryList
		#region PutAllNumList
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// /// <param name = "allNumList">本期生成所有数字</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutAllNumListByPK(long betID, string allNumList, TransactionManager tm_ = null)
		{
			RepairPutAllNumListByPKData(betID, allNumList, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAllNumListByPKAsync(long betID, string allNumList, TransactionManager tm_ = null)
		{
			RepairPutAllNumListByPKData(betID, allNumList, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutAllNumListByPKData(long betID, string allNumList, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `AllNumList` = @AllNumList  WHERE `BetID` = @BetID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@AllNumList", allNumList, MySqlDbType.VarChar),
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "allNumList">本期生成所有数字</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutAllNumList(string allNumList, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `AllNumList` = @AllNumList";
			var parameter_ = Database.CreateInParameter("@AllNumList", allNumList, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutAllNumListAsync(string allNumList, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `AllNumList` = @AllNumList";
			var parameter_ = Database.CreateInParameter("@AllNumList", allNumList, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutAllNumList
		#region PutRewardNumList
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// /// <param name = "rewardNumList">彩票中奖数字</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRewardNumListByPK(long betID, string rewardNumList, TransactionManager tm_ = null)
		{
			RepairPutRewardNumListByPKData(betID, rewardNumList, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutRewardNumListByPKAsync(long betID, string rewardNumList, TransactionManager tm_ = null)
		{
			RepairPutRewardNumListByPKData(betID, rewardNumList, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutRewardNumListByPKData(long betID, string rewardNumList, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `RewardNumList` = @RewardNumList  WHERE `BetID` = @BetID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RewardNumList", rewardNumList, MySqlDbType.VarChar),
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "rewardNumList">彩票中奖数字</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRewardNumList(string rewardNumList, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `RewardNumList` = @RewardNumList";
			var parameter_ = Database.CreateInParameter("@RewardNumList", rewardNumList, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutRewardNumListAsync(string rewardNumList, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `RewardNumList` = @RewardNumList";
			var parameter_ = Database.CreateInParameter("@RewardNumList", rewardNumList, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutRewardNumList
		#region PutJPRewardValue
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// /// <param name = "jPRewardValue">JP 金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutJPRewardValueByPK(long betID, long jPRewardValue, TransactionManager tm_ = null)
		{
			RepairPutJPRewardValueByPKData(betID, jPRewardValue, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutJPRewardValueByPKAsync(long betID, long jPRewardValue, TransactionManager tm_ = null)
		{
			RepairPutJPRewardValueByPKData(betID, jPRewardValue, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutJPRewardValueByPKData(long betID, long jPRewardValue, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `JPRewardValue` = @JPRewardValue  WHERE `BetID` = @BetID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@JPRewardValue", jPRewardValue, MySqlDbType.Int64),
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "jPRewardValue">JP 金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutJPRewardValue(long jPRewardValue, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `JPRewardValue` = @JPRewardValue";
			var parameter_ = Database.CreateInParameter("@JPRewardValue", jPRewardValue, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutJPRewardValueAsync(long jPRewardValue, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `JPRewardValue` = @JPRewardValue";
			var parameter_ = Database.CreateInParameter("@JPRewardValue", jPRewardValue, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutJPRewardValue
		#region PutOrderStatus
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// /// <param name = "orderStatus">状态0-初始1-处理中2-成功3-失败4-已回滚5-异常且需处理6-异常已处理</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOrderStatusByPK(long betID, int orderStatus, TransactionManager tm_ = null)
		{
			RepairPutOrderStatusByPKData(betID, orderStatus, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutOrderStatusByPKAsync(long betID, int orderStatus, TransactionManager tm_ = null)
		{
			RepairPutOrderStatusByPKData(betID, orderStatus, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutOrderStatusByPKData(long betID, int orderStatus, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `OrderStatus` = @OrderStatus  WHERE `BetID` = @BetID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OrderStatus", orderStatus, MySqlDbType.Int32),
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "orderStatus">状态0-初始1-处理中2-成功3-失败4-已回滚5-异常且需处理6-异常已处理</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOrderStatus(int orderStatus, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `OrderStatus` = @OrderStatus";
			var parameter_ = Database.CreateInParameter("@OrderStatus", orderStatus, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutOrderStatusAsync(int orderStatus, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `OrderStatus` = @OrderStatus";
			var parameter_ = Database.CreateInParameter("@OrderStatus", orderStatus, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutOrderStatus
		#region PutRecDate
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRecDateByPK(long betID, DateTime? recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(betID, recDate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutRecDateByPKAsync(long betID, DateTime? recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(betID, recDate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutRecDateByPKData(long betID, DateTime? recDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `RecDate` = @RecDate  WHERE `BetID` = @BetID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RecDate", recDate.HasValue ? recDate.Value : (object)DBNull.Value, MySqlDbType.DateTime),
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRecDate(DateTime? recDate, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `RecDate` = @RecDate";
			var parameter_ = Database.CreateInParameter("@RecDate", recDate.HasValue ? recDate.Value : (object)DBNull.Value, MySqlDbType.DateTime);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutRecDateAsync(DateTime? recDate, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `RecDate` = @RecDate";
			var parameter_ = Database.CreateInParameter("@RecDate", recDate.HasValue ? recDate.Value : (object)DBNull.Value, MySqlDbType.DateTime);
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
		public bool Set(Ggk_bet_detailEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.BetID) == null)
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
		public async Task<bool> SetAsync(Ggk_bet_detailEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.BetID) == null)
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
		/// /// <param name = "betID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public Ggk_bet_detailEO GetByPK(long betID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(betID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, Ggk_bet_detailEO.MapDataReader);
		}
		public async Task<Ggk_bet_detailEO> GetByPKAsync(long betID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(betID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Ggk_bet_detailEO.MapDataReader);
		}
		private void RepairGetByPKData(long betID, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`BetID` = @BetID", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
		}
		#endregion // GetByPK
		
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 UserID（字段）
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetUserIDByPK(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (string)GetScalar("`UserID`", "`BetID` = @BetID", paras_, tm_);
		}
		public async Task<string> GetUserIDByPKAsync(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (string)await GetScalarAsync("`UserID`", "`BetID` = @BetID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 ChipsID（字段）
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetChipsIDByPK(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (int)GetScalar("`ChipsID`", "`BetID` = @BetID", paras_, tm_);
		}
		public async Task<int> GetChipsIDByPKAsync(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (int)await GetScalarAsync("`ChipsID`", "`BetID` = @BetID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 BetBaseAmount（字段）
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetBetBaseAmountByPK(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (long)GetScalar("`BetBaseAmount`", "`BetID` = @BetID", paras_, tm_);
		}
		public async Task<long> GetBetBaseAmountByPKAsync(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (long)await GetScalarAsync("`BetBaseAmount`", "`BetID` = @BetID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 RoundIdx（字段）
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetRoundIdxByPK(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (int)GetScalar("`RoundIdx`", "`BetID` = @BetID", paras_, tm_);
		}
		public async Task<int> GetRoundIdxByPKAsync(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (int)await GetScalarAsync("`RoundIdx`", "`BetID` = @BetID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 FreeSpinCount（字段）
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetFreeSpinCountByPK(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (int)GetScalar("`FreeSpinCount`", "`BetID` = @BetID", paras_, tm_);
		}
		public async Task<int> GetFreeSpinCountByPKAsync(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (int)await GetScalarAsync("`FreeSpinCount`", "`BetID` = @BetID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 WinAmount（字段）
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetWinAmountByPK(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (long)GetScalar("`WinAmount`", "`BetID` = @BetID", paras_, tm_);
		}
		public async Task<long> GetWinAmountByPKAsync(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (long)await GetScalarAsync("`WinAmount`", "`BetID` = @BetID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 HistoryList（字段）
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetHistoryListByPK(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (string)GetScalar("`HistoryList`", "`BetID` = @BetID", paras_, tm_);
		}
		public async Task<string> GetHistoryListByPKAsync(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (string)await GetScalarAsync("`HistoryList`", "`BetID` = @BetID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 AllNumList（字段）
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetAllNumListByPK(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (string)GetScalar("`AllNumList`", "`BetID` = @BetID", paras_, tm_);
		}
		public async Task<string> GetAllNumListByPKAsync(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (string)await GetScalarAsync("`AllNumList`", "`BetID` = @BetID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 RewardNumList（字段）
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetRewardNumListByPK(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (string)GetScalar("`RewardNumList`", "`BetID` = @BetID", paras_, tm_);
		}
		public async Task<string> GetRewardNumListByPKAsync(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (string)await GetScalarAsync("`RewardNumList`", "`BetID` = @BetID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 JPRewardValue（字段）
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetJPRewardValueByPK(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (long)GetScalar("`JPRewardValue`", "`BetID` = @BetID", paras_, tm_);
		}
		public async Task<long> GetJPRewardValueByPKAsync(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (long)await GetScalarAsync("`JPRewardValue`", "`BetID` = @BetID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 OrderStatus（字段）
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetOrderStatusByPK(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (int)GetScalar("`OrderStatus`", "`BetID` = @BetID", paras_, tm_);
		}
		public async Task<int> GetOrderStatusByPKAsync(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (int)await GetScalarAsync("`OrderStatus`", "`BetID` = @BetID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 RecDate（字段）
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime? GetRecDateByPK(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (DateTime?)GetScalar("`RecDate`", "`BetID` = @BetID", paras_, tm_);
		}
		public async Task<DateTime?> GetRecDateByPKAsync(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (DateTime?)await GetScalarAsync("`RecDate`", "`BetID` = @BetID", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByUserID
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户Id</param>
		/// <return>实体对象集合</return>
		public List<Ggk_bet_detailEO> GetByUserID(string userID)
		{
			return GetByUserID(userID, 0, string.Empty, null);
		}
		public async Task<List<Ggk_bet_detailEO>> GetByUserIDAsync(string userID)
		{
			return await GetByUserIDAsync(userID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户Id</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Ggk_bet_detailEO> GetByUserID(string userID, TransactionManager tm_)
		{
			return GetByUserID(userID, 0, string.Empty, tm_);
		}
		public async Task<List<Ggk_bet_detailEO>> GetByUserIDAsync(string userID, TransactionManager tm_)
		{
			return await GetByUserIDAsync(userID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户Id</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Ggk_bet_detailEO> GetByUserID(string userID, int top_)
		{
			return GetByUserID(userID, top_, string.Empty, null);
		}
		public async Task<List<Ggk_bet_detailEO>> GetByUserIDAsync(string userID, int top_)
		{
			return await GetByUserIDAsync(userID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户Id</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Ggk_bet_detailEO> GetByUserID(string userID, int top_, TransactionManager tm_)
		{
			return GetByUserID(userID, top_, string.Empty, tm_);
		}
		public async Task<List<Ggk_bet_detailEO>> GetByUserIDAsync(string userID, int top_, TransactionManager tm_)
		{
			return await GetByUserIDAsync(userID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户Id</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Ggk_bet_detailEO> GetByUserID(string userID, string sort_)
		{
			return GetByUserID(userID, 0, sort_, null);
		}
		public async Task<List<Ggk_bet_detailEO>> GetByUserIDAsync(string userID, string sort_)
		{
			return await GetByUserIDAsync(userID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户Id</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Ggk_bet_detailEO> GetByUserID(string userID, string sort_, TransactionManager tm_)
		{
			return GetByUserID(userID, 0, sort_, tm_);
		}
		public async Task<List<Ggk_bet_detailEO>> GetByUserIDAsync(string userID, string sort_, TransactionManager tm_)
		{
			return await GetByUserIDAsync(userID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户Id</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Ggk_bet_detailEO> GetByUserID(string userID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UserID` = @UserID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Ggk_bet_detailEO.MapDataReader);
		}
		public async Task<List<Ggk_bet_detailEO>> GetByUserIDAsync(string userID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UserID` = @UserID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Ggk_bet_detailEO.MapDataReader);
		}
		#endregion // GetByUserID
		#region GetByChipsID
		
		/// <summary>
		/// 按 ChipsID（字段） 查询
		/// </summary>
		/// /// <param name = "chipsID">下注配置ID</param>
		/// <return>实体对象集合</return>
		public List<Ggk_bet_detailEO> GetByChipsID(int chipsID)
		{
			return GetByChipsID(chipsID, 0, string.Empty, null);
		}
		public async Task<List<Ggk_bet_detailEO>> GetByChipsIDAsync(int chipsID)
		{
			return await GetByChipsIDAsync(chipsID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ChipsID（字段） 查询
		/// </summary>
		/// /// <param name = "chipsID">下注配置ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Ggk_bet_detailEO> GetByChipsID(int chipsID, TransactionManager tm_)
		{
			return GetByChipsID(chipsID, 0, string.Empty, tm_);
		}
		public async Task<List<Ggk_bet_detailEO>> GetByChipsIDAsync(int chipsID, TransactionManager tm_)
		{
			return await GetByChipsIDAsync(chipsID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ChipsID（字段） 查询
		/// </summary>
		/// /// <param name = "chipsID">下注配置ID</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Ggk_bet_detailEO> GetByChipsID(int chipsID, int top_)
		{
			return GetByChipsID(chipsID, top_, string.Empty, null);
		}
		public async Task<List<Ggk_bet_detailEO>> GetByChipsIDAsync(int chipsID, int top_)
		{
			return await GetByChipsIDAsync(chipsID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ChipsID（字段） 查询
		/// </summary>
		/// /// <param name = "chipsID">下注配置ID</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Ggk_bet_detailEO> GetByChipsID(int chipsID, int top_, TransactionManager tm_)
		{
			return GetByChipsID(chipsID, top_, string.Empty, tm_);
		}
		public async Task<List<Ggk_bet_detailEO>> GetByChipsIDAsync(int chipsID, int top_, TransactionManager tm_)
		{
			return await GetByChipsIDAsync(chipsID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ChipsID（字段） 查询
		/// </summary>
		/// /// <param name = "chipsID">下注配置ID</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Ggk_bet_detailEO> GetByChipsID(int chipsID, string sort_)
		{
			return GetByChipsID(chipsID, 0, sort_, null);
		}
		public async Task<List<Ggk_bet_detailEO>> GetByChipsIDAsync(int chipsID, string sort_)
		{
			return await GetByChipsIDAsync(chipsID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 ChipsID（字段） 查询
		/// </summary>
		/// /// <param name = "chipsID">下注配置ID</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Ggk_bet_detailEO> GetByChipsID(int chipsID, string sort_, TransactionManager tm_)
		{
			return GetByChipsID(chipsID, 0, sort_, tm_);
		}
		public async Task<List<Ggk_bet_detailEO>> GetByChipsIDAsync(int chipsID, string sort_, TransactionManager tm_)
		{
			return await GetByChipsIDAsync(chipsID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 ChipsID（字段） 查询
		/// </summary>
		/// /// <param name = "chipsID">下注配置ID</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Ggk_bet_detailEO> GetByChipsID(int chipsID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ChipsID` = @ChipsID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Ggk_bet_detailEO.MapDataReader);
		}
		public async Task<List<Ggk_bet_detailEO>> GetByChipsIDAsync(int chipsID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ChipsID` = @ChipsID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Ggk_bet_detailEO.MapDataReader);
		}
		#endregion // GetByChipsID
		#region GetByBetBaseAmount
		
		/// <summary>
		/// 按 BetBaseAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betBaseAmount">实际下注金额</param>
		/// <return>实体对象集合</return>
		public List<Ggk_bet_detailEO> GetByBetBaseAmount(long betBaseAmount)
		{
			return GetByBetBaseAmount(betBaseAmount, 0, string.Empty, null);
		}
		public async Task<List<Ggk_bet_detailEO>> GetByBetBaseAmountAsync(long betBaseAmount)
		{
			return await GetByBetBaseAmountAsync(betBaseAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BetBaseAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betBaseAmount">实际下注金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Ggk_bet_detailEO> GetByBetBaseAmount(long betBaseAmount, TransactionManager tm_)
		{
			return GetByBetBaseAmount(betBaseAmount, 0, string.Empty, tm_);
		}
		public async Task<List<Ggk_bet_detailEO>> GetByBetBaseAmountAsync(long betBaseAmount, TransactionManager tm_)
		{
			return await GetByBetBaseAmountAsync(betBaseAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BetBaseAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betBaseAmount">实际下注金额</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Ggk_bet_detailEO> GetByBetBaseAmount(long betBaseAmount, int top_)
		{
			return GetByBetBaseAmount(betBaseAmount, top_, string.Empty, null);
		}
		public async Task<List<Ggk_bet_detailEO>> GetByBetBaseAmountAsync(long betBaseAmount, int top_)
		{
			return await GetByBetBaseAmountAsync(betBaseAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BetBaseAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betBaseAmount">实际下注金额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Ggk_bet_detailEO> GetByBetBaseAmount(long betBaseAmount, int top_, TransactionManager tm_)
		{
			return GetByBetBaseAmount(betBaseAmount, top_, string.Empty, tm_);
		}
		public async Task<List<Ggk_bet_detailEO>> GetByBetBaseAmountAsync(long betBaseAmount, int top_, TransactionManager tm_)
		{
			return await GetByBetBaseAmountAsync(betBaseAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BetBaseAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betBaseAmount">实际下注金额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Ggk_bet_detailEO> GetByBetBaseAmount(long betBaseAmount, string sort_)
		{
			return GetByBetBaseAmount(betBaseAmount, 0, sort_, null);
		}
		public async Task<List<Ggk_bet_detailEO>> GetByBetBaseAmountAsync(long betBaseAmount, string sort_)
		{
			return await GetByBetBaseAmountAsync(betBaseAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 BetBaseAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betBaseAmount">实际下注金额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Ggk_bet_detailEO> GetByBetBaseAmount(long betBaseAmount, string sort_, TransactionManager tm_)
		{
			return GetByBetBaseAmount(betBaseAmount, 0, sort_, tm_);
		}
		public async Task<List<Ggk_bet_detailEO>> GetByBetBaseAmountAsync(long betBaseAmount, string sort_, TransactionManager tm_)
		{
			return await GetByBetBaseAmountAsync(betBaseAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 BetBaseAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betBaseAmount">实际下注金额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Ggk_bet_detailEO> GetByBetBaseAmount(long betBaseAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BetBaseAmount` = @BetBaseAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BetBaseAmount", betBaseAmount, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Ggk_bet_detailEO.MapDataReader);
		}
		public async Task<List<Ggk_bet_detailEO>> GetByBetBaseAmountAsync(long betBaseAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BetBaseAmount` = @BetBaseAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BetBaseAmount", betBaseAmount, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Ggk_bet_detailEO.MapDataReader);
		}
		#endregion // GetByBetBaseAmount
		#region GetByRoundIdx
		
		/// <summary>
		/// 按 RoundIdx（字段） 查询
		/// </summary>
		/// /// <param name = "roundIdx">抽过多少次，到10清空，转换一次freeSpinCount</param>
		/// <return>实体对象集合</return>
		public List<Ggk_bet_detailEO> GetByRoundIdx(int roundIdx)
		{
			return GetByRoundIdx(roundIdx, 0, string.Empty, null);
		}
		public async Task<List<Ggk_bet_detailEO>> GetByRoundIdxAsync(int roundIdx)
		{
			return await GetByRoundIdxAsync(roundIdx, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RoundIdx（字段） 查询
		/// </summary>
		/// /// <param name = "roundIdx">抽过多少次，到10清空，转换一次freeSpinCount</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Ggk_bet_detailEO> GetByRoundIdx(int roundIdx, TransactionManager tm_)
		{
			return GetByRoundIdx(roundIdx, 0, string.Empty, tm_);
		}
		public async Task<List<Ggk_bet_detailEO>> GetByRoundIdxAsync(int roundIdx, TransactionManager tm_)
		{
			return await GetByRoundIdxAsync(roundIdx, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RoundIdx（字段） 查询
		/// </summary>
		/// /// <param name = "roundIdx">抽过多少次，到10清空，转换一次freeSpinCount</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Ggk_bet_detailEO> GetByRoundIdx(int roundIdx, int top_)
		{
			return GetByRoundIdx(roundIdx, top_, string.Empty, null);
		}
		public async Task<List<Ggk_bet_detailEO>> GetByRoundIdxAsync(int roundIdx, int top_)
		{
			return await GetByRoundIdxAsync(roundIdx, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RoundIdx（字段） 查询
		/// </summary>
		/// /// <param name = "roundIdx">抽过多少次，到10清空，转换一次freeSpinCount</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Ggk_bet_detailEO> GetByRoundIdx(int roundIdx, int top_, TransactionManager tm_)
		{
			return GetByRoundIdx(roundIdx, top_, string.Empty, tm_);
		}
		public async Task<List<Ggk_bet_detailEO>> GetByRoundIdxAsync(int roundIdx, int top_, TransactionManager tm_)
		{
			return await GetByRoundIdxAsync(roundIdx, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RoundIdx（字段） 查询
		/// </summary>
		/// /// <param name = "roundIdx">抽过多少次，到10清空，转换一次freeSpinCount</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Ggk_bet_detailEO> GetByRoundIdx(int roundIdx, string sort_)
		{
			return GetByRoundIdx(roundIdx, 0, sort_, null);
		}
		public async Task<List<Ggk_bet_detailEO>> GetByRoundIdxAsync(int roundIdx, string sort_)
		{
			return await GetByRoundIdxAsync(roundIdx, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 RoundIdx（字段） 查询
		/// </summary>
		/// /// <param name = "roundIdx">抽过多少次，到10清空，转换一次freeSpinCount</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Ggk_bet_detailEO> GetByRoundIdx(int roundIdx, string sort_, TransactionManager tm_)
		{
			return GetByRoundIdx(roundIdx, 0, sort_, tm_);
		}
		public async Task<List<Ggk_bet_detailEO>> GetByRoundIdxAsync(int roundIdx, string sort_, TransactionManager tm_)
		{
			return await GetByRoundIdxAsync(roundIdx, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 RoundIdx（字段） 查询
		/// </summary>
		/// /// <param name = "roundIdx">抽过多少次，到10清空，转换一次freeSpinCount</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Ggk_bet_detailEO> GetByRoundIdx(int roundIdx, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RoundIdx` = @RoundIdx", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RoundIdx", roundIdx, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Ggk_bet_detailEO.MapDataReader);
		}
		public async Task<List<Ggk_bet_detailEO>> GetByRoundIdxAsync(int roundIdx, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RoundIdx` = @RoundIdx", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RoundIdx", roundIdx, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Ggk_bet_detailEO.MapDataReader);
		}
		#endregion // GetByRoundIdx
		#region GetByFreeSpinCount
		
		/// <summary>
		/// 按 FreeSpinCount（字段） 查询
		/// </summary>
		/// /// <param name = "freeSpinCount">免费摇奖次数</param>
		/// <return>实体对象集合</return>
		public List<Ggk_bet_detailEO> GetByFreeSpinCount(int freeSpinCount)
		{
			return GetByFreeSpinCount(freeSpinCount, 0, string.Empty, null);
		}
		public async Task<List<Ggk_bet_detailEO>> GetByFreeSpinCountAsync(int freeSpinCount)
		{
			return await GetByFreeSpinCountAsync(freeSpinCount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 FreeSpinCount（字段） 查询
		/// </summary>
		/// /// <param name = "freeSpinCount">免费摇奖次数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Ggk_bet_detailEO> GetByFreeSpinCount(int freeSpinCount, TransactionManager tm_)
		{
			return GetByFreeSpinCount(freeSpinCount, 0, string.Empty, tm_);
		}
		public async Task<List<Ggk_bet_detailEO>> GetByFreeSpinCountAsync(int freeSpinCount, TransactionManager tm_)
		{
			return await GetByFreeSpinCountAsync(freeSpinCount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FreeSpinCount（字段） 查询
		/// </summary>
		/// /// <param name = "freeSpinCount">免费摇奖次数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Ggk_bet_detailEO> GetByFreeSpinCount(int freeSpinCount, int top_)
		{
			return GetByFreeSpinCount(freeSpinCount, top_, string.Empty, null);
		}
		public async Task<List<Ggk_bet_detailEO>> GetByFreeSpinCountAsync(int freeSpinCount, int top_)
		{
			return await GetByFreeSpinCountAsync(freeSpinCount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 FreeSpinCount（字段） 查询
		/// </summary>
		/// /// <param name = "freeSpinCount">免费摇奖次数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Ggk_bet_detailEO> GetByFreeSpinCount(int freeSpinCount, int top_, TransactionManager tm_)
		{
			return GetByFreeSpinCount(freeSpinCount, top_, string.Empty, tm_);
		}
		public async Task<List<Ggk_bet_detailEO>> GetByFreeSpinCountAsync(int freeSpinCount, int top_, TransactionManager tm_)
		{
			return await GetByFreeSpinCountAsync(freeSpinCount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FreeSpinCount（字段） 查询
		/// </summary>
		/// /// <param name = "freeSpinCount">免费摇奖次数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Ggk_bet_detailEO> GetByFreeSpinCount(int freeSpinCount, string sort_)
		{
			return GetByFreeSpinCount(freeSpinCount, 0, sort_, null);
		}
		public async Task<List<Ggk_bet_detailEO>> GetByFreeSpinCountAsync(int freeSpinCount, string sort_)
		{
			return await GetByFreeSpinCountAsync(freeSpinCount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 FreeSpinCount（字段） 查询
		/// </summary>
		/// /// <param name = "freeSpinCount">免费摇奖次数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Ggk_bet_detailEO> GetByFreeSpinCount(int freeSpinCount, string sort_, TransactionManager tm_)
		{
			return GetByFreeSpinCount(freeSpinCount, 0, sort_, tm_);
		}
		public async Task<List<Ggk_bet_detailEO>> GetByFreeSpinCountAsync(int freeSpinCount, string sort_, TransactionManager tm_)
		{
			return await GetByFreeSpinCountAsync(freeSpinCount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 FreeSpinCount（字段） 查询
		/// </summary>
		/// /// <param name = "freeSpinCount">免费摇奖次数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Ggk_bet_detailEO> GetByFreeSpinCount(int freeSpinCount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`FreeSpinCount` = @FreeSpinCount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FreeSpinCount", freeSpinCount, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Ggk_bet_detailEO.MapDataReader);
		}
		public async Task<List<Ggk_bet_detailEO>> GetByFreeSpinCountAsync(int freeSpinCount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`FreeSpinCount` = @FreeSpinCount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FreeSpinCount", freeSpinCount, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Ggk_bet_detailEO.MapDataReader);
		}
		#endregion // GetByFreeSpinCount
		#region GetByWinAmount
		
		/// <summary>
		/// 按 WinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "winAmount">所有彩票的奖励总和</param>
		/// <return>实体对象集合</return>
		public List<Ggk_bet_detailEO> GetByWinAmount(long winAmount)
		{
			return GetByWinAmount(winAmount, 0, string.Empty, null);
		}
		public async Task<List<Ggk_bet_detailEO>> GetByWinAmountAsync(long winAmount)
		{
			return await GetByWinAmountAsync(winAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 WinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "winAmount">所有彩票的奖励总和</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Ggk_bet_detailEO> GetByWinAmount(long winAmount, TransactionManager tm_)
		{
			return GetByWinAmount(winAmount, 0, string.Empty, tm_);
		}
		public async Task<List<Ggk_bet_detailEO>> GetByWinAmountAsync(long winAmount, TransactionManager tm_)
		{
			return await GetByWinAmountAsync(winAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 WinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "winAmount">所有彩票的奖励总和</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Ggk_bet_detailEO> GetByWinAmount(long winAmount, int top_)
		{
			return GetByWinAmount(winAmount, top_, string.Empty, null);
		}
		public async Task<List<Ggk_bet_detailEO>> GetByWinAmountAsync(long winAmount, int top_)
		{
			return await GetByWinAmountAsync(winAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 WinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "winAmount">所有彩票的奖励总和</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Ggk_bet_detailEO> GetByWinAmount(long winAmount, int top_, TransactionManager tm_)
		{
			return GetByWinAmount(winAmount, top_, string.Empty, tm_);
		}
		public async Task<List<Ggk_bet_detailEO>> GetByWinAmountAsync(long winAmount, int top_, TransactionManager tm_)
		{
			return await GetByWinAmountAsync(winAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 WinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "winAmount">所有彩票的奖励总和</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Ggk_bet_detailEO> GetByWinAmount(long winAmount, string sort_)
		{
			return GetByWinAmount(winAmount, 0, sort_, null);
		}
		public async Task<List<Ggk_bet_detailEO>> GetByWinAmountAsync(long winAmount, string sort_)
		{
			return await GetByWinAmountAsync(winAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 WinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "winAmount">所有彩票的奖励总和</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Ggk_bet_detailEO> GetByWinAmount(long winAmount, string sort_, TransactionManager tm_)
		{
			return GetByWinAmount(winAmount, 0, sort_, tm_);
		}
		public async Task<List<Ggk_bet_detailEO>> GetByWinAmountAsync(long winAmount, string sort_, TransactionManager tm_)
		{
			return await GetByWinAmountAsync(winAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 WinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "winAmount">所有彩票的奖励总和</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Ggk_bet_detailEO> GetByWinAmount(long winAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`WinAmount` = @WinAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@WinAmount", winAmount, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Ggk_bet_detailEO.MapDataReader);
		}
		public async Task<List<Ggk_bet_detailEO>> GetByWinAmountAsync(long winAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`WinAmount` = @WinAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@WinAmount", winAmount, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Ggk_bet_detailEO.MapDataReader);
		}
		#endregion // GetByWinAmount
		#region GetByHistoryList
		
		/// <summary>
		/// 按 HistoryList（字段） 查询
		/// </summary>
		/// /// <param name = "historyList">生成的组合</param>
		/// <return>实体对象集合</return>
		public List<Ggk_bet_detailEO> GetByHistoryList(string historyList)
		{
			return GetByHistoryList(historyList, 0, string.Empty, null);
		}
		public async Task<List<Ggk_bet_detailEO>> GetByHistoryListAsync(string historyList)
		{
			return await GetByHistoryListAsync(historyList, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 HistoryList（字段） 查询
		/// </summary>
		/// /// <param name = "historyList">生成的组合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Ggk_bet_detailEO> GetByHistoryList(string historyList, TransactionManager tm_)
		{
			return GetByHistoryList(historyList, 0, string.Empty, tm_);
		}
		public async Task<List<Ggk_bet_detailEO>> GetByHistoryListAsync(string historyList, TransactionManager tm_)
		{
			return await GetByHistoryListAsync(historyList, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 HistoryList（字段） 查询
		/// </summary>
		/// /// <param name = "historyList">生成的组合</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Ggk_bet_detailEO> GetByHistoryList(string historyList, int top_)
		{
			return GetByHistoryList(historyList, top_, string.Empty, null);
		}
		public async Task<List<Ggk_bet_detailEO>> GetByHistoryListAsync(string historyList, int top_)
		{
			return await GetByHistoryListAsync(historyList, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 HistoryList（字段） 查询
		/// </summary>
		/// /// <param name = "historyList">生成的组合</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Ggk_bet_detailEO> GetByHistoryList(string historyList, int top_, TransactionManager tm_)
		{
			return GetByHistoryList(historyList, top_, string.Empty, tm_);
		}
		public async Task<List<Ggk_bet_detailEO>> GetByHistoryListAsync(string historyList, int top_, TransactionManager tm_)
		{
			return await GetByHistoryListAsync(historyList, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 HistoryList（字段） 查询
		/// </summary>
		/// /// <param name = "historyList">生成的组合</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Ggk_bet_detailEO> GetByHistoryList(string historyList, string sort_)
		{
			return GetByHistoryList(historyList, 0, sort_, null);
		}
		public async Task<List<Ggk_bet_detailEO>> GetByHistoryListAsync(string historyList, string sort_)
		{
			return await GetByHistoryListAsync(historyList, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 HistoryList（字段） 查询
		/// </summary>
		/// /// <param name = "historyList">生成的组合</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Ggk_bet_detailEO> GetByHistoryList(string historyList, string sort_, TransactionManager tm_)
		{
			return GetByHistoryList(historyList, 0, sort_, tm_);
		}
		public async Task<List<Ggk_bet_detailEO>> GetByHistoryListAsync(string historyList, string sort_, TransactionManager tm_)
		{
			return await GetByHistoryListAsync(historyList, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 HistoryList（字段） 查询
		/// </summary>
		/// /// <param name = "historyList">生成的组合</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Ggk_bet_detailEO> GetByHistoryList(string historyList, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`HistoryList` = @HistoryList", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@HistoryList", historyList, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Ggk_bet_detailEO.MapDataReader);
		}
		public async Task<List<Ggk_bet_detailEO>> GetByHistoryListAsync(string historyList, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`HistoryList` = @HistoryList", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@HistoryList", historyList, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Ggk_bet_detailEO.MapDataReader);
		}
		#endregion // GetByHistoryList
		#region GetByAllNumList
		
		/// <summary>
		/// 按 AllNumList（字段） 查询
		/// </summary>
		/// /// <param name = "allNumList">本期生成所有数字</param>
		/// <return>实体对象集合</return>
		public List<Ggk_bet_detailEO> GetByAllNumList(string allNumList)
		{
			return GetByAllNumList(allNumList, 0, string.Empty, null);
		}
		public async Task<List<Ggk_bet_detailEO>> GetByAllNumListAsync(string allNumList)
		{
			return await GetByAllNumListAsync(allNumList, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 AllNumList（字段） 查询
		/// </summary>
		/// /// <param name = "allNumList">本期生成所有数字</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Ggk_bet_detailEO> GetByAllNumList(string allNumList, TransactionManager tm_)
		{
			return GetByAllNumList(allNumList, 0, string.Empty, tm_);
		}
		public async Task<List<Ggk_bet_detailEO>> GetByAllNumListAsync(string allNumList, TransactionManager tm_)
		{
			return await GetByAllNumListAsync(allNumList, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 AllNumList（字段） 查询
		/// </summary>
		/// /// <param name = "allNumList">本期生成所有数字</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Ggk_bet_detailEO> GetByAllNumList(string allNumList, int top_)
		{
			return GetByAllNumList(allNumList, top_, string.Empty, null);
		}
		public async Task<List<Ggk_bet_detailEO>> GetByAllNumListAsync(string allNumList, int top_)
		{
			return await GetByAllNumListAsync(allNumList, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 AllNumList（字段） 查询
		/// </summary>
		/// /// <param name = "allNumList">本期生成所有数字</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Ggk_bet_detailEO> GetByAllNumList(string allNumList, int top_, TransactionManager tm_)
		{
			return GetByAllNumList(allNumList, top_, string.Empty, tm_);
		}
		public async Task<List<Ggk_bet_detailEO>> GetByAllNumListAsync(string allNumList, int top_, TransactionManager tm_)
		{
			return await GetByAllNumListAsync(allNumList, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 AllNumList（字段） 查询
		/// </summary>
		/// /// <param name = "allNumList">本期生成所有数字</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Ggk_bet_detailEO> GetByAllNumList(string allNumList, string sort_)
		{
			return GetByAllNumList(allNumList, 0, sort_, null);
		}
		public async Task<List<Ggk_bet_detailEO>> GetByAllNumListAsync(string allNumList, string sort_)
		{
			return await GetByAllNumListAsync(allNumList, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 AllNumList（字段） 查询
		/// </summary>
		/// /// <param name = "allNumList">本期生成所有数字</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Ggk_bet_detailEO> GetByAllNumList(string allNumList, string sort_, TransactionManager tm_)
		{
			return GetByAllNumList(allNumList, 0, sort_, tm_);
		}
		public async Task<List<Ggk_bet_detailEO>> GetByAllNumListAsync(string allNumList, string sort_, TransactionManager tm_)
		{
			return await GetByAllNumListAsync(allNumList, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 AllNumList（字段） 查询
		/// </summary>
		/// /// <param name = "allNumList">本期生成所有数字</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Ggk_bet_detailEO> GetByAllNumList(string allNumList, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`AllNumList` = @AllNumList", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@AllNumList", allNumList, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Ggk_bet_detailEO.MapDataReader);
		}
		public async Task<List<Ggk_bet_detailEO>> GetByAllNumListAsync(string allNumList, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`AllNumList` = @AllNumList", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@AllNumList", allNumList, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Ggk_bet_detailEO.MapDataReader);
		}
		#endregion // GetByAllNumList
		#region GetByRewardNumList
		
		/// <summary>
		/// 按 RewardNumList（字段） 查询
		/// </summary>
		/// /// <param name = "rewardNumList">彩票中奖数字</param>
		/// <return>实体对象集合</return>
		public List<Ggk_bet_detailEO> GetByRewardNumList(string rewardNumList)
		{
			return GetByRewardNumList(rewardNumList, 0, string.Empty, null);
		}
		public async Task<List<Ggk_bet_detailEO>> GetByRewardNumListAsync(string rewardNumList)
		{
			return await GetByRewardNumListAsync(rewardNumList, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RewardNumList（字段） 查询
		/// </summary>
		/// /// <param name = "rewardNumList">彩票中奖数字</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Ggk_bet_detailEO> GetByRewardNumList(string rewardNumList, TransactionManager tm_)
		{
			return GetByRewardNumList(rewardNumList, 0, string.Empty, tm_);
		}
		public async Task<List<Ggk_bet_detailEO>> GetByRewardNumListAsync(string rewardNumList, TransactionManager tm_)
		{
			return await GetByRewardNumListAsync(rewardNumList, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RewardNumList（字段） 查询
		/// </summary>
		/// /// <param name = "rewardNumList">彩票中奖数字</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Ggk_bet_detailEO> GetByRewardNumList(string rewardNumList, int top_)
		{
			return GetByRewardNumList(rewardNumList, top_, string.Empty, null);
		}
		public async Task<List<Ggk_bet_detailEO>> GetByRewardNumListAsync(string rewardNumList, int top_)
		{
			return await GetByRewardNumListAsync(rewardNumList, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RewardNumList（字段） 查询
		/// </summary>
		/// /// <param name = "rewardNumList">彩票中奖数字</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Ggk_bet_detailEO> GetByRewardNumList(string rewardNumList, int top_, TransactionManager tm_)
		{
			return GetByRewardNumList(rewardNumList, top_, string.Empty, tm_);
		}
		public async Task<List<Ggk_bet_detailEO>> GetByRewardNumListAsync(string rewardNumList, int top_, TransactionManager tm_)
		{
			return await GetByRewardNumListAsync(rewardNumList, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RewardNumList（字段） 查询
		/// </summary>
		/// /// <param name = "rewardNumList">彩票中奖数字</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Ggk_bet_detailEO> GetByRewardNumList(string rewardNumList, string sort_)
		{
			return GetByRewardNumList(rewardNumList, 0, sort_, null);
		}
		public async Task<List<Ggk_bet_detailEO>> GetByRewardNumListAsync(string rewardNumList, string sort_)
		{
			return await GetByRewardNumListAsync(rewardNumList, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 RewardNumList（字段） 查询
		/// </summary>
		/// /// <param name = "rewardNumList">彩票中奖数字</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Ggk_bet_detailEO> GetByRewardNumList(string rewardNumList, string sort_, TransactionManager tm_)
		{
			return GetByRewardNumList(rewardNumList, 0, sort_, tm_);
		}
		public async Task<List<Ggk_bet_detailEO>> GetByRewardNumListAsync(string rewardNumList, string sort_, TransactionManager tm_)
		{
			return await GetByRewardNumListAsync(rewardNumList, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 RewardNumList（字段） 查询
		/// </summary>
		/// /// <param name = "rewardNumList">彩票中奖数字</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Ggk_bet_detailEO> GetByRewardNumList(string rewardNumList, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RewardNumList` = @RewardNumList", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RewardNumList", rewardNumList, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Ggk_bet_detailEO.MapDataReader);
		}
		public async Task<List<Ggk_bet_detailEO>> GetByRewardNumListAsync(string rewardNumList, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RewardNumList` = @RewardNumList", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RewardNumList", rewardNumList, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Ggk_bet_detailEO.MapDataReader);
		}
		#endregion // GetByRewardNumList
		#region GetByJPRewardValue
		
		/// <summary>
		/// 按 JPRewardValue（字段） 查询
		/// </summary>
		/// /// <param name = "jPRewardValue">JP 金额</param>
		/// <return>实体对象集合</return>
		public List<Ggk_bet_detailEO> GetByJPRewardValue(long jPRewardValue)
		{
			return GetByJPRewardValue(jPRewardValue, 0, string.Empty, null);
		}
		public async Task<List<Ggk_bet_detailEO>> GetByJPRewardValueAsync(long jPRewardValue)
		{
			return await GetByJPRewardValueAsync(jPRewardValue, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 JPRewardValue（字段） 查询
		/// </summary>
		/// /// <param name = "jPRewardValue">JP 金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Ggk_bet_detailEO> GetByJPRewardValue(long jPRewardValue, TransactionManager tm_)
		{
			return GetByJPRewardValue(jPRewardValue, 0, string.Empty, tm_);
		}
		public async Task<List<Ggk_bet_detailEO>> GetByJPRewardValueAsync(long jPRewardValue, TransactionManager tm_)
		{
			return await GetByJPRewardValueAsync(jPRewardValue, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 JPRewardValue（字段） 查询
		/// </summary>
		/// /// <param name = "jPRewardValue">JP 金额</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Ggk_bet_detailEO> GetByJPRewardValue(long jPRewardValue, int top_)
		{
			return GetByJPRewardValue(jPRewardValue, top_, string.Empty, null);
		}
		public async Task<List<Ggk_bet_detailEO>> GetByJPRewardValueAsync(long jPRewardValue, int top_)
		{
			return await GetByJPRewardValueAsync(jPRewardValue, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 JPRewardValue（字段） 查询
		/// </summary>
		/// /// <param name = "jPRewardValue">JP 金额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Ggk_bet_detailEO> GetByJPRewardValue(long jPRewardValue, int top_, TransactionManager tm_)
		{
			return GetByJPRewardValue(jPRewardValue, top_, string.Empty, tm_);
		}
		public async Task<List<Ggk_bet_detailEO>> GetByJPRewardValueAsync(long jPRewardValue, int top_, TransactionManager tm_)
		{
			return await GetByJPRewardValueAsync(jPRewardValue, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 JPRewardValue（字段） 查询
		/// </summary>
		/// /// <param name = "jPRewardValue">JP 金额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Ggk_bet_detailEO> GetByJPRewardValue(long jPRewardValue, string sort_)
		{
			return GetByJPRewardValue(jPRewardValue, 0, sort_, null);
		}
		public async Task<List<Ggk_bet_detailEO>> GetByJPRewardValueAsync(long jPRewardValue, string sort_)
		{
			return await GetByJPRewardValueAsync(jPRewardValue, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 JPRewardValue（字段） 查询
		/// </summary>
		/// /// <param name = "jPRewardValue">JP 金额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Ggk_bet_detailEO> GetByJPRewardValue(long jPRewardValue, string sort_, TransactionManager tm_)
		{
			return GetByJPRewardValue(jPRewardValue, 0, sort_, tm_);
		}
		public async Task<List<Ggk_bet_detailEO>> GetByJPRewardValueAsync(long jPRewardValue, string sort_, TransactionManager tm_)
		{
			return await GetByJPRewardValueAsync(jPRewardValue, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 JPRewardValue（字段） 查询
		/// </summary>
		/// /// <param name = "jPRewardValue">JP 金额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Ggk_bet_detailEO> GetByJPRewardValue(long jPRewardValue, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`JPRewardValue` = @JPRewardValue", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@JPRewardValue", jPRewardValue, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Ggk_bet_detailEO.MapDataReader);
		}
		public async Task<List<Ggk_bet_detailEO>> GetByJPRewardValueAsync(long jPRewardValue, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`JPRewardValue` = @JPRewardValue", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@JPRewardValue", jPRewardValue, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Ggk_bet_detailEO.MapDataReader);
		}
		#endregion // GetByJPRewardValue
		#region GetByOrderStatus
		
		/// <summary>
		/// 按 OrderStatus（字段） 查询
		/// </summary>
		/// /// <param name = "orderStatus">状态0-初始1-处理中2-成功3-失败4-已回滚5-异常且需处理6-异常已处理</param>
		/// <return>实体对象集合</return>
		public List<Ggk_bet_detailEO> GetByOrderStatus(int orderStatus)
		{
			return GetByOrderStatus(orderStatus, 0, string.Empty, null);
		}
		public async Task<List<Ggk_bet_detailEO>> GetByOrderStatusAsync(int orderStatus)
		{
			return await GetByOrderStatusAsync(orderStatus, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OrderStatus（字段） 查询
		/// </summary>
		/// /// <param name = "orderStatus">状态0-初始1-处理中2-成功3-失败4-已回滚5-异常且需处理6-异常已处理</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Ggk_bet_detailEO> GetByOrderStatus(int orderStatus, TransactionManager tm_)
		{
			return GetByOrderStatus(orderStatus, 0, string.Empty, tm_);
		}
		public async Task<List<Ggk_bet_detailEO>> GetByOrderStatusAsync(int orderStatus, TransactionManager tm_)
		{
			return await GetByOrderStatusAsync(orderStatus, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OrderStatus（字段） 查询
		/// </summary>
		/// /// <param name = "orderStatus">状态0-初始1-处理中2-成功3-失败4-已回滚5-异常且需处理6-异常已处理</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Ggk_bet_detailEO> GetByOrderStatus(int orderStatus, int top_)
		{
			return GetByOrderStatus(orderStatus, top_, string.Empty, null);
		}
		public async Task<List<Ggk_bet_detailEO>> GetByOrderStatusAsync(int orderStatus, int top_)
		{
			return await GetByOrderStatusAsync(orderStatus, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OrderStatus（字段） 查询
		/// </summary>
		/// /// <param name = "orderStatus">状态0-初始1-处理中2-成功3-失败4-已回滚5-异常且需处理6-异常已处理</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Ggk_bet_detailEO> GetByOrderStatus(int orderStatus, int top_, TransactionManager tm_)
		{
			return GetByOrderStatus(orderStatus, top_, string.Empty, tm_);
		}
		public async Task<List<Ggk_bet_detailEO>> GetByOrderStatusAsync(int orderStatus, int top_, TransactionManager tm_)
		{
			return await GetByOrderStatusAsync(orderStatus, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OrderStatus（字段） 查询
		/// </summary>
		/// /// <param name = "orderStatus">状态0-初始1-处理中2-成功3-失败4-已回滚5-异常且需处理6-异常已处理</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Ggk_bet_detailEO> GetByOrderStatus(int orderStatus, string sort_)
		{
			return GetByOrderStatus(orderStatus, 0, sort_, null);
		}
		public async Task<List<Ggk_bet_detailEO>> GetByOrderStatusAsync(int orderStatus, string sort_)
		{
			return await GetByOrderStatusAsync(orderStatus, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 OrderStatus（字段） 查询
		/// </summary>
		/// /// <param name = "orderStatus">状态0-初始1-处理中2-成功3-失败4-已回滚5-异常且需处理6-异常已处理</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Ggk_bet_detailEO> GetByOrderStatus(int orderStatus, string sort_, TransactionManager tm_)
		{
			return GetByOrderStatus(orderStatus, 0, sort_, tm_);
		}
		public async Task<List<Ggk_bet_detailEO>> GetByOrderStatusAsync(int orderStatus, string sort_, TransactionManager tm_)
		{
			return await GetByOrderStatusAsync(orderStatus, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 OrderStatus（字段） 查询
		/// </summary>
		/// /// <param name = "orderStatus">状态0-初始1-处理中2-成功3-失败4-已回滚5-异常且需处理6-异常已处理</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Ggk_bet_detailEO> GetByOrderStatus(int orderStatus, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OrderStatus` = @OrderStatus", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OrderStatus", orderStatus, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Ggk_bet_detailEO.MapDataReader);
		}
		public async Task<List<Ggk_bet_detailEO>> GetByOrderStatusAsync(int orderStatus, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OrderStatus` = @OrderStatus", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OrderStatus", orderStatus, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Ggk_bet_detailEO.MapDataReader);
		}
		#endregion // GetByOrderStatus
		#region GetByRecDate
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <return>实体对象集合</return>
		public List<Ggk_bet_detailEO> GetByRecDate(DateTime? recDate)
		{
			return GetByRecDate(recDate, 0, string.Empty, null);
		}
		public async Task<List<Ggk_bet_detailEO>> GetByRecDateAsync(DateTime? recDate)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Ggk_bet_detailEO> GetByRecDate(DateTime? recDate, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, string.Empty, tm_);
		}
		public async Task<List<Ggk_bet_detailEO>> GetByRecDateAsync(DateTime? recDate, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Ggk_bet_detailEO> GetByRecDate(DateTime? recDate, int top_)
		{
			return GetByRecDate(recDate, top_, string.Empty, null);
		}
		public async Task<List<Ggk_bet_detailEO>> GetByRecDateAsync(DateTime? recDate, int top_)
		{
			return await GetByRecDateAsync(recDate, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Ggk_bet_detailEO> GetByRecDate(DateTime? recDate, int top_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, top_, string.Empty, tm_);
		}
		public async Task<List<Ggk_bet_detailEO>> GetByRecDateAsync(DateTime? recDate, int top_, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Ggk_bet_detailEO> GetByRecDate(DateTime? recDate, string sort_)
		{
			return GetByRecDate(recDate, 0, sort_, null);
		}
		public async Task<List<Ggk_bet_detailEO>> GetByRecDateAsync(DateTime? recDate, string sort_)
		{
			return await GetByRecDateAsync(recDate, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Ggk_bet_detailEO> GetByRecDate(DateTime? recDate, string sort_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, sort_, tm_);
		}
		public async Task<List<Ggk_bet_detailEO>> GetByRecDateAsync(DateTime? recDate, string sort_, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Ggk_bet_detailEO> GetByRecDate(DateTime? recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(recDate.HasValue ? "`RecDate` = @RecDate" : "`RecDate` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (recDate.HasValue)
				paras_.Add(Database.CreateInParameter("@RecDate", recDate.Value, MySqlDbType.DateTime));
			return Database.ExecSqlList(sql_, paras_, tm_, Ggk_bet_detailEO.MapDataReader);
		}
		public async Task<List<Ggk_bet_detailEO>> GetByRecDateAsync(DateTime? recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(recDate.HasValue ? "`RecDate` = @RecDate" : "`RecDate` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (recDate.HasValue)
				paras_.Add(Database.CreateInParameter("@RecDate", recDate.Value, MySqlDbType.DateTime));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Ggk_bet_detailEO.MapDataReader);
		}
		#endregion // GetByRecDate
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
