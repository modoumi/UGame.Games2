/******************************************************
 * 此代码由代码生成器工具自动生成，请不要修改
 * TinyFx代码生成器核心库版本号：1.0.0.0
 * git: https://github.com/jh98net/TinyFx
 * 文档生成时间：2023-12-09 15: 11:25
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
	/// lucky抽奖、jackpot抽奖订单表
	/// 【表 bs_order_raffle 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class Bs_order_raffleEO : IRowMapper<Bs_order_raffleEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public Bs_order_raffleEO()
		{
			this.OrderType = 0;
			this.LuckySumAmount = 0;
			this.LuckyAmount = 0;
			this.JackpotCount = 0;
			this.WinAmount = 0;
			this.Status = 0;
			this.RecDate = DateTime.Now;
		}
		#region 主键原始值 & 主键集合
	    
		/// <summary>
		/// 当前对象是否保存原始主键值，当修改了主键值时为 true
		/// </summary>
		public bool HasOriginal { get; protected set; }
		
		private string _originalRaffleOrderID;
		/// <summary>
		/// 【数据库中的原始主键 RaffleOrderID 值的副本，用于主键值更新】
		/// </summary>
		public string OriginalRaffleOrderID
		{
			get { return _originalRaffleOrderID; }
			set { HasOriginal = true; _originalRaffleOrderID = value; }
		}
	    /// <summary>
	    /// 获取主键集合。key: 数据库字段名称, value: 主键值
	    /// </summary>
	    /// <returns></returns>
	    public Dictionary<string, object> GetPrimaryKeys()
	    {
	        return new Dictionary<string, object>() { { "RaffleOrderID", RaffleOrderID }, };
	    }
	    /// <summary>
	    /// 获取主键集合JSON格式
	    /// </summary>
	    /// <returns></returns>
	    public string GetPrimaryKeysJson() => SerializerUtil.SerializeJson(GetPrimaryKeys());
		#endregion // 主键原始值
		#region 所有字段
		/// <summary>
		/// lucky|Jackpot抽奖订单号
		/// 【主键 varchar(50)】
		/// </summary>
		[DataMember(Order = 1)]
		public string RaffleOrderID { get; set; }
		/// <summary>
		/// 订单编号GUID
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 2)]
		public string OrderID { get; set; }
		/// <summary>
		/// 订单类型（1-Lucky抽奖2-Jackpot抽奖）
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 3)]
		public int OrderType { get; set; }
		/// <summary>
		/// 用户Id
		/// 【字段 varchar(38)】
		/// </summary>
		[DataMember(Order = 4)]
		public string UserID { get; set; }
		/// <summary>
		/// 用户通用显示昵称
		/// 【字段 varchar(38)】
		/// </summary>
		[DataMember(Order = 5)]
		public string UserNickName { get; set; }
		/// <summary>
		/// 抽奖时个人lucky总奖池金额
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 6)]
		public long LuckySumAmount { get; set; }
		/// <summary>
		/// 抽奖时个人Lucky奖池金额
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 7)]
		public long LuckyAmount { get; set; }
		/// <summary>
		/// 抽奖时个人Jackpot累计值
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 8)]
		public long JackpotCount { get; set; }
		/// <summary>
		/// 中奖金额
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 9)]
		public long WinAmount { get; set; }
		/// <summary>
		/// 状态（0-无效1-有效）
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 10)]
		public int Status { get; set; }
		/// <summary>
		/// 创建时间
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 11)]
		public DateTime RecDate { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public Bs_order_raffleEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static Bs_order_raffleEO MapDataReader(IDataReader reader)
		{
		    Bs_order_raffleEO ret = new Bs_order_raffleEO();
			ret.RaffleOrderID = reader.ToString("RaffleOrderID");
			ret.OriginalRaffleOrderID = ret.RaffleOrderID;
			ret.OrderID = reader.ToString("OrderID");
			ret.OrderType = reader.ToInt32("OrderType");
			ret.UserID = reader.ToString("UserID");
			ret.UserNickName = reader.ToString("UserNickName");
			ret.LuckySumAmount = reader.ToInt64("LuckySumAmount");
			ret.LuckyAmount = reader.ToInt64("LuckyAmount");
			ret.JackpotCount = reader.ToInt64("JackpotCount");
			ret.WinAmount = reader.ToInt64("WinAmount");
			ret.Status = reader.ToInt32("Status");
			ret.RecDate = reader.ToDateTime("RecDate");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// lucky抽奖、jackpot抽奖订单表
	/// 【表 bs_order_raffle 的操作类】
	/// </summary>
	[Obsolete]
	public class Bs_order_raffleMO : MySqlTableMO<Bs_order_raffleEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`bs_order_raffle`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public Bs_order_raffleMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public Bs_order_raffleMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public Bs_order_raffleMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(Bs_order_raffleEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(Bs_order_raffleEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(Bs_order_raffleEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`RaffleOrderID`, `OrderID`, `OrderType`, `UserID`, `UserNickName`, `LuckySumAmount`, `LuckyAmount`, `JackpotCount`, `WinAmount`, `Status`, `RecDate`) VALUE (@RaffleOrderID, @OrderID, @OrderType, @UserID, @UserNickName, @LuckySumAmount, @LuckyAmount, @JackpotCount, @WinAmount, @Status, @RecDate);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RaffleOrderID", item.RaffleOrderID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OrderID", item.OrderID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OrderType", item.OrderType, MySqlDbType.Int32),
				Database.CreateInParameter("@UserID", item.UserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserNickName", item.UserNickName, MySqlDbType.VarChar),
				Database.CreateInParameter("@LuckySumAmount", item.LuckySumAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@LuckyAmount", item.LuckyAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@JackpotCount", item.JackpotCount, MySqlDbType.Int64),
				Database.CreateInParameter("@WinAmount", item.WinAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@Status", item.Status, MySqlDbType.Int32),
				Database.CreateInParameter("@RecDate", item.RecDate, MySqlDbType.DateTime),
			};
		}
		public int AddByBatch(IEnumerable<Bs_order_raffleEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<Bs_order_raffleEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<Bs_order_raffleEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`RaffleOrderID`, `OrderID`, `OrderType`, `UserID`, `UserNickName`, `LuckySumAmount`, `LuckyAmount`, `JackpotCount`, `WinAmount`, `Status`, `RecDate`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"('{item.RaffleOrderID}','{item.OrderID}',{item.OrderType},'{item.UserID}','{item.UserNickName}',{item.LuckySumAmount},{item.LuckyAmount},{item.JackpotCount},{item.WinAmount},{item.Status},'{item.RecDate.ToString("yyyy-MM-dd HH:mm:ss")}'),");
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
		/// /// <param name = "raffleOrderID">lucky|Jackpot抽奖订单号</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(string raffleOrderID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(raffleOrderID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(string raffleOrderID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(raffleOrderID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(string raffleOrderID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `RaffleOrderID` = @RaffleOrderID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RaffleOrderID", raffleOrderID, MySqlDbType.VarChar),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(Bs_order_raffleEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.RaffleOrderID, tm_);
		}
		public async Task<int> RemoveAsync(Bs_order_raffleEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.RaffleOrderID, tm_);
		}
		#endregion // RemoveByPK
		
		#region RemoveByXXX
		#region RemoveByOrderID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "orderID">订单编号GUID</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByOrderID(string orderID, TransactionManager tm_ = null)
		{
			RepairRemoveByOrderIDData(orderID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByOrderIDAsync(string orderID, TransactionManager tm_ = null)
		{
			RepairRemoveByOrderIDData(orderID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByOrderIDData(string orderID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `OrderID` = @OrderID";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar));
		}
		#endregion // RemoveByOrderID
		#region RemoveByOrderType
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "orderType">订单类型（1-Lucky抽奖2-Jackpot抽奖）</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByOrderType(int orderType, TransactionManager tm_ = null)
		{
			RepairRemoveByOrderTypeData(orderType, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByOrderTypeAsync(int orderType, TransactionManager tm_ = null)
		{
			RepairRemoveByOrderTypeData(orderType, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByOrderTypeData(int orderType, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `OrderType` = @OrderType";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OrderType", orderType, MySqlDbType.Int32));
		}
		#endregion // RemoveByOrderType
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
		#region RemoveByUserNickName
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "userNickName">用户通用显示昵称</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByUserNickName(string userNickName, TransactionManager tm_ = null)
		{
			RepairRemoveByUserNickNameData(userNickName, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByUserNickNameAsync(string userNickName, TransactionManager tm_ = null)
		{
			RepairRemoveByUserNickNameData(userNickName, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByUserNickNameData(string userNickName, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `UserNickName` = @UserNickName";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserNickName", userNickName, MySqlDbType.VarChar));
		}
		#endregion // RemoveByUserNickName
		#region RemoveByLuckySumAmount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "luckySumAmount">抽奖时个人lucky总奖池金额</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByLuckySumAmount(long luckySumAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByLuckySumAmountData(luckySumAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByLuckySumAmountAsync(long luckySumAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByLuckySumAmountData(luckySumAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByLuckySumAmountData(long luckySumAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `LuckySumAmount` = @LuckySumAmount";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@LuckySumAmount", luckySumAmount, MySqlDbType.Int64));
		}
		#endregion // RemoveByLuckySumAmount
		#region RemoveByLuckyAmount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "luckyAmount">抽奖时个人Lucky奖池金额</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByLuckyAmount(long luckyAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByLuckyAmountData(luckyAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByLuckyAmountAsync(long luckyAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByLuckyAmountData(luckyAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByLuckyAmountData(long luckyAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `LuckyAmount` = @LuckyAmount";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@LuckyAmount", luckyAmount, MySqlDbType.Int64));
		}
		#endregion // RemoveByLuckyAmount
		#region RemoveByJackpotCount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "jackpotCount">抽奖时个人Jackpot累计值</param>
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
		#region RemoveByWinAmount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "winAmount">中奖金额</param>
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
		#region RemoveByStatus
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "status">状态（0-无效1-有效）</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByStatus(int status, TransactionManager tm_ = null)
		{
			RepairRemoveByStatusData(status, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByStatusAsync(int status, TransactionManager tm_ = null)
		{
			RepairRemoveByStatusData(status, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByStatusData(int status, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `Status` = @Status";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Status", status, MySqlDbType.Int32));
		}
		#endregion // RemoveByStatus
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
		public int Put(Bs_order_raffleEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(Bs_order_raffleEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(Bs_order_raffleEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `RaffleOrderID` = @RaffleOrderID, `OrderID` = @OrderID, `OrderType` = @OrderType, `UserID` = @UserID, `UserNickName` = @UserNickName, `LuckySumAmount` = @LuckySumAmount, `LuckyAmount` = @LuckyAmount, `JackpotCount` = @JackpotCount, `WinAmount` = @WinAmount, `Status` = @Status WHERE `RaffleOrderID` = @RaffleOrderID_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RaffleOrderID", item.RaffleOrderID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OrderID", item.OrderID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OrderType", item.OrderType, MySqlDbType.Int32),
				Database.CreateInParameter("@UserID", item.UserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserNickName", item.UserNickName, MySqlDbType.VarChar),
				Database.CreateInParameter("@LuckySumAmount", item.LuckySumAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@LuckyAmount", item.LuckyAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@JackpotCount", item.JackpotCount, MySqlDbType.Int64),
				Database.CreateInParameter("@WinAmount", item.WinAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@Status", item.Status, MySqlDbType.Int32),
				Database.CreateInParameter("@RaffleOrderID_Original", item.HasOriginal ? item.OriginalRaffleOrderID : item.RaffleOrderID, MySqlDbType.VarChar),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<Bs_order_raffleEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<Bs_order_raffleEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "raffleOrderID">lucky|Jackpot抽奖订单号</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string raffleOrderID, string set_, params object[] values_)
		{
			return Put(set_, "`RaffleOrderID` = @RaffleOrderID", ConcatValues(values_, raffleOrderID));
		}
		public async Task<int> PutByPKAsync(string raffleOrderID, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`RaffleOrderID` = @RaffleOrderID", ConcatValues(values_, raffleOrderID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "raffleOrderID">lucky|Jackpot抽奖订单号</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string raffleOrderID, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`RaffleOrderID` = @RaffleOrderID", tm_, ConcatValues(values_, raffleOrderID));
		}
		public async Task<int> PutByPKAsync(string raffleOrderID, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`RaffleOrderID` = @RaffleOrderID", tm_, ConcatValues(values_, raffleOrderID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "raffleOrderID">lucky|Jackpot抽奖订单号</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string raffleOrderID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@RaffleOrderID", raffleOrderID, MySqlDbType.VarChar),
	        };
			return Put(set_, "`RaffleOrderID` = @RaffleOrderID", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(string raffleOrderID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@RaffleOrderID", raffleOrderID, MySqlDbType.VarChar),
	        };
			return await PutAsync(set_, "`RaffleOrderID` = @RaffleOrderID", ConcatParameters(paras_, newParas_), tm_);
		}
		#endregion // PutByPK
		
		#region PutXXX
		#region PutOrderID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "raffleOrderID">lucky|Jackpot抽奖订单号</param>
		/// /// <param name = "orderID">订单编号GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOrderIDByPK(string raffleOrderID, string orderID, TransactionManager tm_ = null)
		{
			RepairPutOrderIDByPKData(raffleOrderID, orderID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutOrderIDByPKAsync(string raffleOrderID, string orderID, TransactionManager tm_ = null)
		{
			RepairPutOrderIDByPKData(raffleOrderID, orderID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutOrderIDByPKData(string raffleOrderID, string orderID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `OrderID` = @OrderID  WHERE `RaffleOrderID` = @RaffleOrderID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
				Database.CreateInParameter("@RaffleOrderID", raffleOrderID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "orderID">订单编号GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOrderID(string orderID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `OrderID` = @OrderID";
			var parameter_ = Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutOrderIDAsync(string orderID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `OrderID` = @OrderID";
			var parameter_ = Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutOrderID
		#region PutOrderType
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "raffleOrderID">lucky|Jackpot抽奖订单号</param>
		/// /// <param name = "orderType">订单类型（1-Lucky抽奖2-Jackpot抽奖）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOrderTypeByPK(string raffleOrderID, int orderType, TransactionManager tm_ = null)
		{
			RepairPutOrderTypeByPKData(raffleOrderID, orderType, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutOrderTypeByPKAsync(string raffleOrderID, int orderType, TransactionManager tm_ = null)
		{
			RepairPutOrderTypeByPKData(raffleOrderID, orderType, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutOrderTypeByPKData(string raffleOrderID, int orderType, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `OrderType` = @OrderType  WHERE `RaffleOrderID` = @RaffleOrderID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OrderType", orderType, MySqlDbType.Int32),
				Database.CreateInParameter("@RaffleOrderID", raffleOrderID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "orderType">订单类型（1-Lucky抽奖2-Jackpot抽奖）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOrderType(int orderType, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `OrderType` = @OrderType";
			var parameter_ = Database.CreateInParameter("@OrderType", orderType, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutOrderTypeAsync(int orderType, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `OrderType` = @OrderType";
			var parameter_ = Database.CreateInParameter("@OrderType", orderType, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutOrderType
		#region PutUserID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "raffleOrderID">lucky|Jackpot抽奖订单号</param>
		/// /// <param name = "userID">用户Id</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutUserIDByPK(string raffleOrderID, string userID, TransactionManager tm_ = null)
		{
			RepairPutUserIDByPKData(raffleOrderID, userID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutUserIDByPKAsync(string raffleOrderID, string userID, TransactionManager tm_ = null)
		{
			RepairPutUserIDByPKData(raffleOrderID, userID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutUserIDByPKData(string raffleOrderID, string userID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `UserID` = @UserID  WHERE `RaffleOrderID` = @RaffleOrderID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
				Database.CreateInParameter("@RaffleOrderID", raffleOrderID, MySqlDbType.VarChar),
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
		#region PutUserNickName
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "raffleOrderID">lucky|Jackpot抽奖订单号</param>
		/// /// <param name = "userNickName">用户通用显示昵称</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutUserNickNameByPK(string raffleOrderID, string userNickName, TransactionManager tm_ = null)
		{
			RepairPutUserNickNameByPKData(raffleOrderID, userNickName, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutUserNickNameByPKAsync(string raffleOrderID, string userNickName, TransactionManager tm_ = null)
		{
			RepairPutUserNickNameByPKData(raffleOrderID, userNickName, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutUserNickNameByPKData(string raffleOrderID, string userNickName, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `UserNickName` = @UserNickName  WHERE `RaffleOrderID` = @RaffleOrderID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserNickName", userNickName, MySqlDbType.VarChar),
				Database.CreateInParameter("@RaffleOrderID", raffleOrderID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "userNickName">用户通用显示昵称</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutUserNickName(string userNickName, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `UserNickName` = @UserNickName";
			var parameter_ = Database.CreateInParameter("@UserNickName", userNickName, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutUserNickNameAsync(string userNickName, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `UserNickName` = @UserNickName";
			var parameter_ = Database.CreateInParameter("@UserNickName", userNickName, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutUserNickName
		#region PutLuckySumAmount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "raffleOrderID">lucky|Jackpot抽奖订单号</param>
		/// /// <param name = "luckySumAmount">抽奖时个人lucky总奖池金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutLuckySumAmountByPK(string raffleOrderID, long luckySumAmount, TransactionManager tm_ = null)
		{
			RepairPutLuckySumAmountByPKData(raffleOrderID, luckySumAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutLuckySumAmountByPKAsync(string raffleOrderID, long luckySumAmount, TransactionManager tm_ = null)
		{
			RepairPutLuckySumAmountByPKData(raffleOrderID, luckySumAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutLuckySumAmountByPKData(string raffleOrderID, long luckySumAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `LuckySumAmount` = @LuckySumAmount  WHERE `RaffleOrderID` = @RaffleOrderID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LuckySumAmount", luckySumAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@RaffleOrderID", raffleOrderID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "luckySumAmount">抽奖时个人lucky总奖池金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutLuckySumAmount(long luckySumAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `LuckySumAmount` = @LuckySumAmount";
			var parameter_ = Database.CreateInParameter("@LuckySumAmount", luckySumAmount, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutLuckySumAmountAsync(long luckySumAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `LuckySumAmount` = @LuckySumAmount";
			var parameter_ = Database.CreateInParameter("@LuckySumAmount", luckySumAmount, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutLuckySumAmount
		#region PutLuckyAmount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "raffleOrderID">lucky|Jackpot抽奖订单号</param>
		/// /// <param name = "luckyAmount">抽奖时个人Lucky奖池金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutLuckyAmountByPK(string raffleOrderID, long luckyAmount, TransactionManager tm_ = null)
		{
			RepairPutLuckyAmountByPKData(raffleOrderID, luckyAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutLuckyAmountByPKAsync(string raffleOrderID, long luckyAmount, TransactionManager tm_ = null)
		{
			RepairPutLuckyAmountByPKData(raffleOrderID, luckyAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutLuckyAmountByPKData(string raffleOrderID, long luckyAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `LuckyAmount` = @LuckyAmount  WHERE `RaffleOrderID` = @RaffleOrderID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LuckyAmount", luckyAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@RaffleOrderID", raffleOrderID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "luckyAmount">抽奖时个人Lucky奖池金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutLuckyAmount(long luckyAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `LuckyAmount` = @LuckyAmount";
			var parameter_ = Database.CreateInParameter("@LuckyAmount", luckyAmount, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutLuckyAmountAsync(long luckyAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `LuckyAmount` = @LuckyAmount";
			var parameter_ = Database.CreateInParameter("@LuckyAmount", luckyAmount, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutLuckyAmount
		#region PutJackpotCount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "raffleOrderID">lucky|Jackpot抽奖订单号</param>
		/// /// <param name = "jackpotCount">抽奖时个人Jackpot累计值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutJackpotCountByPK(string raffleOrderID, long jackpotCount, TransactionManager tm_ = null)
		{
			RepairPutJackpotCountByPKData(raffleOrderID, jackpotCount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutJackpotCountByPKAsync(string raffleOrderID, long jackpotCount, TransactionManager tm_ = null)
		{
			RepairPutJackpotCountByPKData(raffleOrderID, jackpotCount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutJackpotCountByPKData(string raffleOrderID, long jackpotCount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `JackpotCount` = @JackpotCount  WHERE `RaffleOrderID` = @RaffleOrderID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@JackpotCount", jackpotCount, MySqlDbType.Int64),
				Database.CreateInParameter("@RaffleOrderID", raffleOrderID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "jackpotCount">抽奖时个人Jackpot累计值</param>
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
		#region PutWinAmount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "raffleOrderID">lucky|Jackpot抽奖订单号</param>
		/// /// <param name = "winAmount">中奖金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutWinAmountByPK(string raffleOrderID, long winAmount, TransactionManager tm_ = null)
		{
			RepairPutWinAmountByPKData(raffleOrderID, winAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutWinAmountByPKAsync(string raffleOrderID, long winAmount, TransactionManager tm_ = null)
		{
			RepairPutWinAmountByPKData(raffleOrderID, winAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutWinAmountByPKData(string raffleOrderID, long winAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `WinAmount` = @WinAmount  WHERE `RaffleOrderID` = @RaffleOrderID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@WinAmount", winAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@RaffleOrderID", raffleOrderID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "winAmount">中奖金额</param>
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
		#region PutStatus
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "raffleOrderID">lucky|Jackpot抽奖订单号</param>
		/// /// <param name = "status">状态（0-无效1-有效）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutStatusByPK(string raffleOrderID, int status, TransactionManager tm_ = null)
		{
			RepairPutStatusByPKData(raffleOrderID, status, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutStatusByPKAsync(string raffleOrderID, int status, TransactionManager tm_ = null)
		{
			RepairPutStatusByPKData(raffleOrderID, status, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutStatusByPKData(string raffleOrderID, int status, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Status` = @Status  WHERE `RaffleOrderID` = @RaffleOrderID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Status", status, MySqlDbType.Int32),
				Database.CreateInParameter("@RaffleOrderID", raffleOrderID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "status">状态（0-无效1-有效）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutStatus(int status, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Status` = @Status";
			var parameter_ = Database.CreateInParameter("@Status", status, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutStatusAsync(int status, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Status` = @Status";
			var parameter_ = Database.CreateInParameter("@Status", status, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutStatus
		#region PutRecDate
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "raffleOrderID">lucky|Jackpot抽奖订单号</param>
		/// /// <param name = "recDate">创建时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRecDateByPK(string raffleOrderID, DateTime recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(raffleOrderID, recDate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutRecDateByPKAsync(string raffleOrderID, DateTime recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(raffleOrderID, recDate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutRecDateByPKData(string raffleOrderID, DateTime recDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `RecDate` = @RecDate  WHERE `RaffleOrderID` = @RaffleOrderID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime),
				Database.CreateInParameter("@RaffleOrderID", raffleOrderID, MySqlDbType.VarChar),
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
		public bool Set(Bs_order_raffleEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.RaffleOrderID) == null)
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
		public async Task<bool> SetAsync(Bs_order_raffleEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.RaffleOrderID) == null)
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
		/// /// <param name = "raffleOrderID">lucky|Jackpot抽奖订单号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public Bs_order_raffleEO GetByPK(string raffleOrderID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(raffleOrderID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, Bs_order_raffleEO.MapDataReader);
		}
		public async Task<Bs_order_raffleEO> GetByPKAsync(string raffleOrderID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(raffleOrderID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Bs_order_raffleEO.MapDataReader);
		}
		private void RepairGetByPKData(string raffleOrderID, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`RaffleOrderID` = @RaffleOrderID", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RaffleOrderID", raffleOrderID, MySqlDbType.VarChar),
			};
		}
		#endregion // GetByPK
		
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 OrderID（字段）
		/// </summary>
		/// /// <param name = "raffleOrderID">lucky|Jackpot抽奖订单号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetOrderIDByPK(string raffleOrderID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RaffleOrderID", raffleOrderID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`OrderID`", "`RaffleOrderID` = @RaffleOrderID", paras_, tm_);
		}
		public async Task<string> GetOrderIDByPKAsync(string raffleOrderID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RaffleOrderID", raffleOrderID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`OrderID`", "`RaffleOrderID` = @RaffleOrderID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 OrderType（字段）
		/// </summary>
		/// /// <param name = "raffleOrderID">lucky|Jackpot抽奖订单号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetOrderTypeByPK(string raffleOrderID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RaffleOrderID", raffleOrderID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`OrderType`", "`RaffleOrderID` = @RaffleOrderID", paras_, tm_);
		}
		public async Task<int> GetOrderTypeByPKAsync(string raffleOrderID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RaffleOrderID", raffleOrderID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`OrderType`", "`RaffleOrderID` = @RaffleOrderID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 UserID（字段）
		/// </summary>
		/// /// <param name = "raffleOrderID">lucky|Jackpot抽奖订单号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetUserIDByPK(string raffleOrderID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RaffleOrderID", raffleOrderID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`UserID`", "`RaffleOrderID` = @RaffleOrderID", paras_, tm_);
		}
		public async Task<string> GetUserIDByPKAsync(string raffleOrderID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RaffleOrderID", raffleOrderID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`UserID`", "`RaffleOrderID` = @RaffleOrderID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 UserNickName（字段）
		/// </summary>
		/// /// <param name = "raffleOrderID">lucky|Jackpot抽奖订单号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetUserNickNameByPK(string raffleOrderID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RaffleOrderID", raffleOrderID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`UserNickName`", "`RaffleOrderID` = @RaffleOrderID", paras_, tm_);
		}
		public async Task<string> GetUserNickNameByPKAsync(string raffleOrderID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RaffleOrderID", raffleOrderID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`UserNickName`", "`RaffleOrderID` = @RaffleOrderID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 LuckySumAmount（字段）
		/// </summary>
		/// /// <param name = "raffleOrderID">lucky|Jackpot抽奖订单号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetLuckySumAmountByPK(string raffleOrderID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RaffleOrderID", raffleOrderID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`LuckySumAmount`", "`RaffleOrderID` = @RaffleOrderID", paras_, tm_);
		}
		public async Task<long> GetLuckySumAmountByPKAsync(string raffleOrderID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RaffleOrderID", raffleOrderID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`LuckySumAmount`", "`RaffleOrderID` = @RaffleOrderID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 LuckyAmount（字段）
		/// </summary>
		/// /// <param name = "raffleOrderID">lucky|Jackpot抽奖订单号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetLuckyAmountByPK(string raffleOrderID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RaffleOrderID", raffleOrderID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`LuckyAmount`", "`RaffleOrderID` = @RaffleOrderID", paras_, tm_);
		}
		public async Task<long> GetLuckyAmountByPKAsync(string raffleOrderID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RaffleOrderID", raffleOrderID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`LuckyAmount`", "`RaffleOrderID` = @RaffleOrderID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 JackpotCount（字段）
		/// </summary>
		/// /// <param name = "raffleOrderID">lucky|Jackpot抽奖订单号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetJackpotCountByPK(string raffleOrderID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RaffleOrderID", raffleOrderID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`JackpotCount`", "`RaffleOrderID` = @RaffleOrderID", paras_, tm_);
		}
		public async Task<long> GetJackpotCountByPKAsync(string raffleOrderID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RaffleOrderID", raffleOrderID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`JackpotCount`", "`RaffleOrderID` = @RaffleOrderID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 WinAmount（字段）
		/// </summary>
		/// /// <param name = "raffleOrderID">lucky|Jackpot抽奖订单号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetWinAmountByPK(string raffleOrderID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RaffleOrderID", raffleOrderID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`WinAmount`", "`RaffleOrderID` = @RaffleOrderID", paras_, tm_);
		}
		public async Task<long> GetWinAmountByPKAsync(string raffleOrderID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RaffleOrderID", raffleOrderID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`WinAmount`", "`RaffleOrderID` = @RaffleOrderID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Status（字段）
		/// </summary>
		/// /// <param name = "raffleOrderID">lucky|Jackpot抽奖订单号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetStatusByPK(string raffleOrderID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RaffleOrderID", raffleOrderID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`Status`", "`RaffleOrderID` = @RaffleOrderID", paras_, tm_);
		}
		public async Task<int> GetStatusByPKAsync(string raffleOrderID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RaffleOrderID", raffleOrderID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`Status`", "`RaffleOrderID` = @RaffleOrderID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 RecDate（字段）
		/// </summary>
		/// /// <param name = "raffleOrderID">lucky|Jackpot抽奖订单号</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime GetRecDateByPK(string raffleOrderID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RaffleOrderID", raffleOrderID, MySqlDbType.VarChar),
			};
			return (DateTime)GetScalar("`RecDate`", "`RaffleOrderID` = @RaffleOrderID", paras_, tm_);
		}
		public async Task<DateTime> GetRecDateByPKAsync(string raffleOrderID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RaffleOrderID", raffleOrderID, MySqlDbType.VarChar),
			};
			return (DateTime)await GetScalarAsync("`RecDate`", "`RaffleOrderID` = @RaffleOrderID", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByOrderID
		
		/// <summary>
		/// 按 OrderID（字段） 查询
		/// </summary>
		/// /// <param name = "orderID">订单编号GUID</param>
		/// <return>实体对象集合</return>
		public List<Bs_order_raffleEO> GetByOrderID(string orderID)
		{
			return GetByOrderID(orderID, 0, string.Empty, null);
		}
		public async Task<List<Bs_order_raffleEO>> GetByOrderIDAsync(string orderID)
		{
			return await GetByOrderIDAsync(orderID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OrderID（字段） 查询
		/// </summary>
		/// /// <param name = "orderID">订单编号GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_order_raffleEO> GetByOrderID(string orderID, TransactionManager tm_)
		{
			return GetByOrderID(orderID, 0, string.Empty, tm_);
		}
		public async Task<List<Bs_order_raffleEO>> GetByOrderIDAsync(string orderID, TransactionManager tm_)
		{
			return await GetByOrderIDAsync(orderID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OrderID（字段） 查询
		/// </summary>
		/// /// <param name = "orderID">订单编号GUID</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Bs_order_raffleEO> GetByOrderID(string orderID, int top_)
		{
			return GetByOrderID(orderID, top_, string.Empty, null);
		}
		public async Task<List<Bs_order_raffleEO>> GetByOrderIDAsync(string orderID, int top_)
		{
			return await GetByOrderIDAsync(orderID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OrderID（字段） 查询
		/// </summary>
		/// /// <param name = "orderID">订单编号GUID</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_order_raffleEO> GetByOrderID(string orderID, int top_, TransactionManager tm_)
		{
			return GetByOrderID(orderID, top_, string.Empty, tm_);
		}
		public async Task<List<Bs_order_raffleEO>> GetByOrderIDAsync(string orderID, int top_, TransactionManager tm_)
		{
			return await GetByOrderIDAsync(orderID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OrderID（字段） 查询
		/// </summary>
		/// /// <param name = "orderID">订单编号GUID</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Bs_order_raffleEO> GetByOrderID(string orderID, string sort_)
		{
			return GetByOrderID(orderID, 0, sort_, null);
		}
		public async Task<List<Bs_order_raffleEO>> GetByOrderIDAsync(string orderID, string sort_)
		{
			return await GetByOrderIDAsync(orderID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 OrderID（字段） 查询
		/// </summary>
		/// /// <param name = "orderID">订单编号GUID</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_order_raffleEO> GetByOrderID(string orderID, string sort_, TransactionManager tm_)
		{
			return GetByOrderID(orderID, 0, sort_, tm_);
		}
		public async Task<List<Bs_order_raffleEO>> GetByOrderIDAsync(string orderID, string sort_, TransactionManager tm_)
		{
			return await GetByOrderIDAsync(orderID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 OrderID（字段） 查询
		/// </summary>
		/// /// <param name = "orderID">订单编号GUID</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_order_raffleEO> GetByOrderID(string orderID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OrderID` = @OrderID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Bs_order_raffleEO.MapDataReader);
		}
		public async Task<List<Bs_order_raffleEO>> GetByOrderIDAsync(string orderID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OrderID` = @OrderID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Bs_order_raffleEO.MapDataReader);
		}
		#endregion // GetByOrderID
		#region GetByOrderType
		
		/// <summary>
		/// 按 OrderType（字段） 查询
		/// </summary>
		/// /// <param name = "orderType">订单类型（1-Lucky抽奖2-Jackpot抽奖）</param>
		/// <return>实体对象集合</return>
		public List<Bs_order_raffleEO> GetByOrderType(int orderType)
		{
			return GetByOrderType(orderType, 0, string.Empty, null);
		}
		public async Task<List<Bs_order_raffleEO>> GetByOrderTypeAsync(int orderType)
		{
			return await GetByOrderTypeAsync(orderType, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OrderType（字段） 查询
		/// </summary>
		/// /// <param name = "orderType">订单类型（1-Lucky抽奖2-Jackpot抽奖）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_order_raffleEO> GetByOrderType(int orderType, TransactionManager tm_)
		{
			return GetByOrderType(orderType, 0, string.Empty, tm_);
		}
		public async Task<List<Bs_order_raffleEO>> GetByOrderTypeAsync(int orderType, TransactionManager tm_)
		{
			return await GetByOrderTypeAsync(orderType, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OrderType（字段） 查询
		/// </summary>
		/// /// <param name = "orderType">订单类型（1-Lucky抽奖2-Jackpot抽奖）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Bs_order_raffleEO> GetByOrderType(int orderType, int top_)
		{
			return GetByOrderType(orderType, top_, string.Empty, null);
		}
		public async Task<List<Bs_order_raffleEO>> GetByOrderTypeAsync(int orderType, int top_)
		{
			return await GetByOrderTypeAsync(orderType, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OrderType（字段） 查询
		/// </summary>
		/// /// <param name = "orderType">订单类型（1-Lucky抽奖2-Jackpot抽奖）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_order_raffleEO> GetByOrderType(int orderType, int top_, TransactionManager tm_)
		{
			return GetByOrderType(orderType, top_, string.Empty, tm_);
		}
		public async Task<List<Bs_order_raffleEO>> GetByOrderTypeAsync(int orderType, int top_, TransactionManager tm_)
		{
			return await GetByOrderTypeAsync(orderType, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OrderType（字段） 查询
		/// </summary>
		/// /// <param name = "orderType">订单类型（1-Lucky抽奖2-Jackpot抽奖）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Bs_order_raffleEO> GetByOrderType(int orderType, string sort_)
		{
			return GetByOrderType(orderType, 0, sort_, null);
		}
		public async Task<List<Bs_order_raffleEO>> GetByOrderTypeAsync(int orderType, string sort_)
		{
			return await GetByOrderTypeAsync(orderType, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 OrderType（字段） 查询
		/// </summary>
		/// /// <param name = "orderType">订单类型（1-Lucky抽奖2-Jackpot抽奖）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_order_raffleEO> GetByOrderType(int orderType, string sort_, TransactionManager tm_)
		{
			return GetByOrderType(orderType, 0, sort_, tm_);
		}
		public async Task<List<Bs_order_raffleEO>> GetByOrderTypeAsync(int orderType, string sort_, TransactionManager tm_)
		{
			return await GetByOrderTypeAsync(orderType, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 OrderType（字段） 查询
		/// </summary>
		/// /// <param name = "orderType">订单类型（1-Lucky抽奖2-Jackpot抽奖）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_order_raffleEO> GetByOrderType(int orderType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OrderType` = @OrderType", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OrderType", orderType, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Bs_order_raffleEO.MapDataReader);
		}
		public async Task<List<Bs_order_raffleEO>> GetByOrderTypeAsync(int orderType, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OrderType` = @OrderType", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OrderType", orderType, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Bs_order_raffleEO.MapDataReader);
		}
		#endregion // GetByOrderType
		#region GetByUserID
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户Id</param>
		/// <return>实体对象集合</return>
		public List<Bs_order_raffleEO> GetByUserID(string userID)
		{
			return GetByUserID(userID, 0, string.Empty, null);
		}
		public async Task<List<Bs_order_raffleEO>> GetByUserIDAsync(string userID)
		{
			return await GetByUserIDAsync(userID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户Id</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_order_raffleEO> GetByUserID(string userID, TransactionManager tm_)
		{
			return GetByUserID(userID, 0, string.Empty, tm_);
		}
		public async Task<List<Bs_order_raffleEO>> GetByUserIDAsync(string userID, TransactionManager tm_)
		{
			return await GetByUserIDAsync(userID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户Id</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Bs_order_raffleEO> GetByUserID(string userID, int top_)
		{
			return GetByUserID(userID, top_, string.Empty, null);
		}
		public async Task<List<Bs_order_raffleEO>> GetByUserIDAsync(string userID, int top_)
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
		public List<Bs_order_raffleEO> GetByUserID(string userID, int top_, TransactionManager tm_)
		{
			return GetByUserID(userID, top_, string.Empty, tm_);
		}
		public async Task<List<Bs_order_raffleEO>> GetByUserIDAsync(string userID, int top_, TransactionManager tm_)
		{
			return await GetByUserIDAsync(userID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户Id</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Bs_order_raffleEO> GetByUserID(string userID, string sort_)
		{
			return GetByUserID(userID, 0, sort_, null);
		}
		public async Task<List<Bs_order_raffleEO>> GetByUserIDAsync(string userID, string sort_)
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
		public List<Bs_order_raffleEO> GetByUserID(string userID, string sort_, TransactionManager tm_)
		{
			return GetByUserID(userID, 0, sort_, tm_);
		}
		public async Task<List<Bs_order_raffleEO>> GetByUserIDAsync(string userID, string sort_, TransactionManager tm_)
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
		public List<Bs_order_raffleEO> GetByUserID(string userID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UserID` = @UserID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Bs_order_raffleEO.MapDataReader);
		}
		public async Task<List<Bs_order_raffleEO>> GetByUserIDAsync(string userID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UserID` = @UserID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Bs_order_raffleEO.MapDataReader);
		}
		#endregion // GetByUserID
		#region GetByUserNickName
		
		/// <summary>
		/// 按 UserNickName（字段） 查询
		/// </summary>
		/// /// <param name = "userNickName">用户通用显示昵称</param>
		/// <return>实体对象集合</return>
		public List<Bs_order_raffleEO> GetByUserNickName(string userNickName)
		{
			return GetByUserNickName(userNickName, 0, string.Empty, null);
		}
		public async Task<List<Bs_order_raffleEO>> GetByUserNickNameAsync(string userNickName)
		{
			return await GetByUserNickNameAsync(userNickName, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UserNickName（字段） 查询
		/// </summary>
		/// /// <param name = "userNickName">用户通用显示昵称</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_order_raffleEO> GetByUserNickName(string userNickName, TransactionManager tm_)
		{
			return GetByUserNickName(userNickName, 0, string.Empty, tm_);
		}
		public async Task<List<Bs_order_raffleEO>> GetByUserNickNameAsync(string userNickName, TransactionManager tm_)
		{
			return await GetByUserNickNameAsync(userNickName, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserNickName（字段） 查询
		/// </summary>
		/// /// <param name = "userNickName">用户通用显示昵称</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Bs_order_raffleEO> GetByUserNickName(string userNickName, int top_)
		{
			return GetByUserNickName(userNickName, top_, string.Empty, null);
		}
		public async Task<List<Bs_order_raffleEO>> GetByUserNickNameAsync(string userNickName, int top_)
		{
			return await GetByUserNickNameAsync(userNickName, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UserNickName（字段） 查询
		/// </summary>
		/// /// <param name = "userNickName">用户通用显示昵称</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_order_raffleEO> GetByUserNickName(string userNickName, int top_, TransactionManager tm_)
		{
			return GetByUserNickName(userNickName, top_, string.Empty, tm_);
		}
		public async Task<List<Bs_order_raffleEO>> GetByUserNickNameAsync(string userNickName, int top_, TransactionManager tm_)
		{
			return await GetByUserNickNameAsync(userNickName, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserNickName（字段） 查询
		/// </summary>
		/// /// <param name = "userNickName">用户通用显示昵称</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Bs_order_raffleEO> GetByUserNickName(string userNickName, string sort_)
		{
			return GetByUserNickName(userNickName, 0, sort_, null);
		}
		public async Task<List<Bs_order_raffleEO>> GetByUserNickNameAsync(string userNickName, string sort_)
		{
			return await GetByUserNickNameAsync(userNickName, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 UserNickName（字段） 查询
		/// </summary>
		/// /// <param name = "userNickName">用户通用显示昵称</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_order_raffleEO> GetByUserNickName(string userNickName, string sort_, TransactionManager tm_)
		{
			return GetByUserNickName(userNickName, 0, sort_, tm_);
		}
		public async Task<List<Bs_order_raffleEO>> GetByUserNickNameAsync(string userNickName, string sort_, TransactionManager tm_)
		{
			return await GetByUserNickNameAsync(userNickName, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 UserNickName（字段） 查询
		/// </summary>
		/// /// <param name = "userNickName">用户通用显示昵称</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_order_raffleEO> GetByUserNickName(string userNickName, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UserNickName` = @UserNickName", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserNickName", userNickName, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Bs_order_raffleEO.MapDataReader);
		}
		public async Task<List<Bs_order_raffleEO>> GetByUserNickNameAsync(string userNickName, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UserNickName` = @UserNickName", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserNickName", userNickName, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Bs_order_raffleEO.MapDataReader);
		}
		#endregion // GetByUserNickName
		#region GetByLuckySumAmount
		
		/// <summary>
		/// 按 LuckySumAmount（字段） 查询
		/// </summary>
		/// /// <param name = "luckySumAmount">抽奖时个人lucky总奖池金额</param>
		/// <return>实体对象集合</return>
		public List<Bs_order_raffleEO> GetByLuckySumAmount(long luckySumAmount)
		{
			return GetByLuckySumAmount(luckySumAmount, 0, string.Empty, null);
		}
		public async Task<List<Bs_order_raffleEO>> GetByLuckySumAmountAsync(long luckySumAmount)
		{
			return await GetByLuckySumAmountAsync(luckySumAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LuckySumAmount（字段） 查询
		/// </summary>
		/// /// <param name = "luckySumAmount">抽奖时个人lucky总奖池金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_order_raffleEO> GetByLuckySumAmount(long luckySumAmount, TransactionManager tm_)
		{
			return GetByLuckySumAmount(luckySumAmount, 0, string.Empty, tm_);
		}
		public async Task<List<Bs_order_raffleEO>> GetByLuckySumAmountAsync(long luckySumAmount, TransactionManager tm_)
		{
			return await GetByLuckySumAmountAsync(luckySumAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LuckySumAmount（字段） 查询
		/// </summary>
		/// /// <param name = "luckySumAmount">抽奖时个人lucky总奖池金额</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Bs_order_raffleEO> GetByLuckySumAmount(long luckySumAmount, int top_)
		{
			return GetByLuckySumAmount(luckySumAmount, top_, string.Empty, null);
		}
		public async Task<List<Bs_order_raffleEO>> GetByLuckySumAmountAsync(long luckySumAmount, int top_)
		{
			return await GetByLuckySumAmountAsync(luckySumAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LuckySumAmount（字段） 查询
		/// </summary>
		/// /// <param name = "luckySumAmount">抽奖时个人lucky总奖池金额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_order_raffleEO> GetByLuckySumAmount(long luckySumAmount, int top_, TransactionManager tm_)
		{
			return GetByLuckySumAmount(luckySumAmount, top_, string.Empty, tm_);
		}
		public async Task<List<Bs_order_raffleEO>> GetByLuckySumAmountAsync(long luckySumAmount, int top_, TransactionManager tm_)
		{
			return await GetByLuckySumAmountAsync(luckySumAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LuckySumAmount（字段） 查询
		/// </summary>
		/// /// <param name = "luckySumAmount">抽奖时个人lucky总奖池金额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Bs_order_raffleEO> GetByLuckySumAmount(long luckySumAmount, string sort_)
		{
			return GetByLuckySumAmount(luckySumAmount, 0, sort_, null);
		}
		public async Task<List<Bs_order_raffleEO>> GetByLuckySumAmountAsync(long luckySumAmount, string sort_)
		{
			return await GetByLuckySumAmountAsync(luckySumAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 LuckySumAmount（字段） 查询
		/// </summary>
		/// /// <param name = "luckySumAmount">抽奖时个人lucky总奖池金额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_order_raffleEO> GetByLuckySumAmount(long luckySumAmount, string sort_, TransactionManager tm_)
		{
			return GetByLuckySumAmount(luckySumAmount, 0, sort_, tm_);
		}
		public async Task<List<Bs_order_raffleEO>> GetByLuckySumAmountAsync(long luckySumAmount, string sort_, TransactionManager tm_)
		{
			return await GetByLuckySumAmountAsync(luckySumAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 LuckySumAmount（字段） 查询
		/// </summary>
		/// /// <param name = "luckySumAmount">抽奖时个人lucky总奖池金额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_order_raffleEO> GetByLuckySumAmount(long luckySumAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`LuckySumAmount` = @LuckySumAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@LuckySumAmount", luckySumAmount, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Bs_order_raffleEO.MapDataReader);
		}
		public async Task<List<Bs_order_raffleEO>> GetByLuckySumAmountAsync(long luckySumAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`LuckySumAmount` = @LuckySumAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@LuckySumAmount", luckySumAmount, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Bs_order_raffleEO.MapDataReader);
		}
		#endregion // GetByLuckySumAmount
		#region GetByLuckyAmount
		
		/// <summary>
		/// 按 LuckyAmount（字段） 查询
		/// </summary>
		/// /// <param name = "luckyAmount">抽奖时个人Lucky奖池金额</param>
		/// <return>实体对象集合</return>
		public List<Bs_order_raffleEO> GetByLuckyAmount(long luckyAmount)
		{
			return GetByLuckyAmount(luckyAmount, 0, string.Empty, null);
		}
		public async Task<List<Bs_order_raffleEO>> GetByLuckyAmountAsync(long luckyAmount)
		{
			return await GetByLuckyAmountAsync(luckyAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LuckyAmount（字段） 查询
		/// </summary>
		/// /// <param name = "luckyAmount">抽奖时个人Lucky奖池金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_order_raffleEO> GetByLuckyAmount(long luckyAmount, TransactionManager tm_)
		{
			return GetByLuckyAmount(luckyAmount, 0, string.Empty, tm_);
		}
		public async Task<List<Bs_order_raffleEO>> GetByLuckyAmountAsync(long luckyAmount, TransactionManager tm_)
		{
			return await GetByLuckyAmountAsync(luckyAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LuckyAmount（字段） 查询
		/// </summary>
		/// /// <param name = "luckyAmount">抽奖时个人Lucky奖池金额</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Bs_order_raffleEO> GetByLuckyAmount(long luckyAmount, int top_)
		{
			return GetByLuckyAmount(luckyAmount, top_, string.Empty, null);
		}
		public async Task<List<Bs_order_raffleEO>> GetByLuckyAmountAsync(long luckyAmount, int top_)
		{
			return await GetByLuckyAmountAsync(luckyAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LuckyAmount（字段） 查询
		/// </summary>
		/// /// <param name = "luckyAmount">抽奖时个人Lucky奖池金额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_order_raffleEO> GetByLuckyAmount(long luckyAmount, int top_, TransactionManager tm_)
		{
			return GetByLuckyAmount(luckyAmount, top_, string.Empty, tm_);
		}
		public async Task<List<Bs_order_raffleEO>> GetByLuckyAmountAsync(long luckyAmount, int top_, TransactionManager tm_)
		{
			return await GetByLuckyAmountAsync(luckyAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LuckyAmount（字段） 查询
		/// </summary>
		/// /// <param name = "luckyAmount">抽奖时个人Lucky奖池金额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Bs_order_raffleEO> GetByLuckyAmount(long luckyAmount, string sort_)
		{
			return GetByLuckyAmount(luckyAmount, 0, sort_, null);
		}
		public async Task<List<Bs_order_raffleEO>> GetByLuckyAmountAsync(long luckyAmount, string sort_)
		{
			return await GetByLuckyAmountAsync(luckyAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 LuckyAmount（字段） 查询
		/// </summary>
		/// /// <param name = "luckyAmount">抽奖时个人Lucky奖池金额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_order_raffleEO> GetByLuckyAmount(long luckyAmount, string sort_, TransactionManager tm_)
		{
			return GetByLuckyAmount(luckyAmount, 0, sort_, tm_);
		}
		public async Task<List<Bs_order_raffleEO>> GetByLuckyAmountAsync(long luckyAmount, string sort_, TransactionManager tm_)
		{
			return await GetByLuckyAmountAsync(luckyAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 LuckyAmount（字段） 查询
		/// </summary>
		/// /// <param name = "luckyAmount">抽奖时个人Lucky奖池金额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_order_raffleEO> GetByLuckyAmount(long luckyAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`LuckyAmount` = @LuckyAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@LuckyAmount", luckyAmount, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Bs_order_raffleEO.MapDataReader);
		}
		public async Task<List<Bs_order_raffleEO>> GetByLuckyAmountAsync(long luckyAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`LuckyAmount` = @LuckyAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@LuckyAmount", luckyAmount, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Bs_order_raffleEO.MapDataReader);
		}
		#endregion // GetByLuckyAmount
		#region GetByJackpotCount
		
		/// <summary>
		/// 按 JackpotCount（字段） 查询
		/// </summary>
		/// /// <param name = "jackpotCount">抽奖时个人Jackpot累计值</param>
		/// <return>实体对象集合</return>
		public List<Bs_order_raffleEO> GetByJackpotCount(long jackpotCount)
		{
			return GetByJackpotCount(jackpotCount, 0, string.Empty, null);
		}
		public async Task<List<Bs_order_raffleEO>> GetByJackpotCountAsync(long jackpotCount)
		{
			return await GetByJackpotCountAsync(jackpotCount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 JackpotCount（字段） 查询
		/// </summary>
		/// /// <param name = "jackpotCount">抽奖时个人Jackpot累计值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_order_raffleEO> GetByJackpotCount(long jackpotCount, TransactionManager tm_)
		{
			return GetByJackpotCount(jackpotCount, 0, string.Empty, tm_);
		}
		public async Task<List<Bs_order_raffleEO>> GetByJackpotCountAsync(long jackpotCount, TransactionManager tm_)
		{
			return await GetByJackpotCountAsync(jackpotCount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 JackpotCount（字段） 查询
		/// </summary>
		/// /// <param name = "jackpotCount">抽奖时个人Jackpot累计值</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Bs_order_raffleEO> GetByJackpotCount(long jackpotCount, int top_)
		{
			return GetByJackpotCount(jackpotCount, top_, string.Empty, null);
		}
		public async Task<List<Bs_order_raffleEO>> GetByJackpotCountAsync(long jackpotCount, int top_)
		{
			return await GetByJackpotCountAsync(jackpotCount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 JackpotCount（字段） 查询
		/// </summary>
		/// /// <param name = "jackpotCount">抽奖时个人Jackpot累计值</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_order_raffleEO> GetByJackpotCount(long jackpotCount, int top_, TransactionManager tm_)
		{
			return GetByJackpotCount(jackpotCount, top_, string.Empty, tm_);
		}
		public async Task<List<Bs_order_raffleEO>> GetByJackpotCountAsync(long jackpotCount, int top_, TransactionManager tm_)
		{
			return await GetByJackpotCountAsync(jackpotCount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 JackpotCount（字段） 查询
		/// </summary>
		/// /// <param name = "jackpotCount">抽奖时个人Jackpot累计值</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Bs_order_raffleEO> GetByJackpotCount(long jackpotCount, string sort_)
		{
			return GetByJackpotCount(jackpotCount, 0, sort_, null);
		}
		public async Task<List<Bs_order_raffleEO>> GetByJackpotCountAsync(long jackpotCount, string sort_)
		{
			return await GetByJackpotCountAsync(jackpotCount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 JackpotCount（字段） 查询
		/// </summary>
		/// /// <param name = "jackpotCount">抽奖时个人Jackpot累计值</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_order_raffleEO> GetByJackpotCount(long jackpotCount, string sort_, TransactionManager tm_)
		{
			return GetByJackpotCount(jackpotCount, 0, sort_, tm_);
		}
		public async Task<List<Bs_order_raffleEO>> GetByJackpotCountAsync(long jackpotCount, string sort_, TransactionManager tm_)
		{
			return await GetByJackpotCountAsync(jackpotCount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 JackpotCount（字段） 查询
		/// </summary>
		/// /// <param name = "jackpotCount">抽奖时个人Jackpot累计值</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_order_raffleEO> GetByJackpotCount(long jackpotCount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`JackpotCount` = @JackpotCount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@JackpotCount", jackpotCount, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Bs_order_raffleEO.MapDataReader);
		}
		public async Task<List<Bs_order_raffleEO>> GetByJackpotCountAsync(long jackpotCount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`JackpotCount` = @JackpotCount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@JackpotCount", jackpotCount, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Bs_order_raffleEO.MapDataReader);
		}
		#endregion // GetByJackpotCount
		#region GetByWinAmount
		
		/// <summary>
		/// 按 WinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "winAmount">中奖金额</param>
		/// <return>实体对象集合</return>
		public List<Bs_order_raffleEO> GetByWinAmount(long winAmount)
		{
			return GetByWinAmount(winAmount, 0, string.Empty, null);
		}
		public async Task<List<Bs_order_raffleEO>> GetByWinAmountAsync(long winAmount)
		{
			return await GetByWinAmountAsync(winAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 WinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "winAmount">中奖金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_order_raffleEO> GetByWinAmount(long winAmount, TransactionManager tm_)
		{
			return GetByWinAmount(winAmount, 0, string.Empty, tm_);
		}
		public async Task<List<Bs_order_raffleEO>> GetByWinAmountAsync(long winAmount, TransactionManager tm_)
		{
			return await GetByWinAmountAsync(winAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 WinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "winAmount">中奖金额</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Bs_order_raffleEO> GetByWinAmount(long winAmount, int top_)
		{
			return GetByWinAmount(winAmount, top_, string.Empty, null);
		}
		public async Task<List<Bs_order_raffleEO>> GetByWinAmountAsync(long winAmount, int top_)
		{
			return await GetByWinAmountAsync(winAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 WinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "winAmount">中奖金额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_order_raffleEO> GetByWinAmount(long winAmount, int top_, TransactionManager tm_)
		{
			return GetByWinAmount(winAmount, top_, string.Empty, tm_);
		}
		public async Task<List<Bs_order_raffleEO>> GetByWinAmountAsync(long winAmount, int top_, TransactionManager tm_)
		{
			return await GetByWinAmountAsync(winAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 WinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "winAmount">中奖金额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Bs_order_raffleEO> GetByWinAmount(long winAmount, string sort_)
		{
			return GetByWinAmount(winAmount, 0, sort_, null);
		}
		public async Task<List<Bs_order_raffleEO>> GetByWinAmountAsync(long winAmount, string sort_)
		{
			return await GetByWinAmountAsync(winAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 WinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "winAmount">中奖金额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_order_raffleEO> GetByWinAmount(long winAmount, string sort_, TransactionManager tm_)
		{
			return GetByWinAmount(winAmount, 0, sort_, tm_);
		}
		public async Task<List<Bs_order_raffleEO>> GetByWinAmountAsync(long winAmount, string sort_, TransactionManager tm_)
		{
			return await GetByWinAmountAsync(winAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 WinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "winAmount">中奖金额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_order_raffleEO> GetByWinAmount(long winAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`WinAmount` = @WinAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@WinAmount", winAmount, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Bs_order_raffleEO.MapDataReader);
		}
		public async Task<List<Bs_order_raffleEO>> GetByWinAmountAsync(long winAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`WinAmount` = @WinAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@WinAmount", winAmount, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Bs_order_raffleEO.MapDataReader);
		}
		#endregion // GetByWinAmount
		#region GetByStatus
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态（0-无效1-有效）</param>
		/// <return>实体对象集合</return>
		public List<Bs_order_raffleEO> GetByStatus(int status)
		{
			return GetByStatus(status, 0, string.Empty, null);
		}
		public async Task<List<Bs_order_raffleEO>> GetByStatusAsync(int status)
		{
			return await GetByStatusAsync(status, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态（0-无效1-有效）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_order_raffleEO> GetByStatus(int status, TransactionManager tm_)
		{
			return GetByStatus(status, 0, string.Empty, tm_);
		}
		public async Task<List<Bs_order_raffleEO>> GetByStatusAsync(int status, TransactionManager tm_)
		{
			return await GetByStatusAsync(status, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态（0-无效1-有效）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Bs_order_raffleEO> GetByStatus(int status, int top_)
		{
			return GetByStatus(status, top_, string.Empty, null);
		}
		public async Task<List<Bs_order_raffleEO>> GetByStatusAsync(int status, int top_)
		{
			return await GetByStatusAsync(status, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态（0-无效1-有效）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_order_raffleEO> GetByStatus(int status, int top_, TransactionManager tm_)
		{
			return GetByStatus(status, top_, string.Empty, tm_);
		}
		public async Task<List<Bs_order_raffleEO>> GetByStatusAsync(int status, int top_, TransactionManager tm_)
		{
			return await GetByStatusAsync(status, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态（0-无效1-有效）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Bs_order_raffleEO> GetByStatus(int status, string sort_)
		{
			return GetByStatus(status, 0, sort_, null);
		}
		public async Task<List<Bs_order_raffleEO>> GetByStatusAsync(int status, string sort_)
		{
			return await GetByStatusAsync(status, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态（0-无效1-有效）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_order_raffleEO> GetByStatus(int status, string sort_, TransactionManager tm_)
		{
			return GetByStatus(status, 0, sort_, tm_);
		}
		public async Task<List<Bs_order_raffleEO>> GetByStatusAsync(int status, string sort_, TransactionManager tm_)
		{
			return await GetByStatusAsync(status, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态（0-无效1-有效）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_order_raffleEO> GetByStatus(int status, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Status` = @Status", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Status", status, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Bs_order_raffleEO.MapDataReader);
		}
		public async Task<List<Bs_order_raffleEO>> GetByStatusAsync(int status, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Status` = @Status", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Status", status, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Bs_order_raffleEO.MapDataReader);
		}
		#endregion // GetByStatus
		#region GetByRecDate
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">创建时间</param>
		/// <return>实体对象集合</return>
		public List<Bs_order_raffleEO> GetByRecDate(DateTime recDate)
		{
			return GetByRecDate(recDate, 0, string.Empty, null);
		}
		public async Task<List<Bs_order_raffleEO>> GetByRecDateAsync(DateTime recDate)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">创建时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_order_raffleEO> GetByRecDate(DateTime recDate, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, string.Empty, tm_);
		}
		public async Task<List<Bs_order_raffleEO>> GetByRecDateAsync(DateTime recDate, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">创建时间</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Bs_order_raffleEO> GetByRecDate(DateTime recDate, int top_)
		{
			return GetByRecDate(recDate, top_, string.Empty, null);
		}
		public async Task<List<Bs_order_raffleEO>> GetByRecDateAsync(DateTime recDate, int top_)
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
		public List<Bs_order_raffleEO> GetByRecDate(DateTime recDate, int top_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, top_, string.Empty, tm_);
		}
		public async Task<List<Bs_order_raffleEO>> GetByRecDateAsync(DateTime recDate, int top_, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">创建时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Bs_order_raffleEO> GetByRecDate(DateTime recDate, string sort_)
		{
			return GetByRecDate(recDate, 0, sort_, null);
		}
		public async Task<List<Bs_order_raffleEO>> GetByRecDateAsync(DateTime recDate, string sort_)
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
		public List<Bs_order_raffleEO> GetByRecDate(DateTime recDate, string sort_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, sort_, tm_);
		}
		public async Task<List<Bs_order_raffleEO>> GetByRecDateAsync(DateTime recDate, string sort_, TransactionManager tm_)
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
		public List<Bs_order_raffleEO> GetByRecDate(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return Database.ExecSqlList(sql_, paras_, tm_, Bs_order_raffleEO.MapDataReader);
		}
		public async Task<List<Bs_order_raffleEO>> GetByRecDateAsync(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Bs_order_raffleEO.MapDataReader);
		}
		#endregion // GetByRecDate
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
