/******************************************************
 * 此代码由代码生成器工具自动生成，请不要修改
 * TinyFx代码生成器核心库版本号：1.0.0.0
 * git: https://github.com/jh98net/TinyFx
 * 文档生成时间：2023-12-09 15: 08:18
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
	/// 
	/// 【表 dwp_bet_detail 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class Dwp_bet_detailEO : IRowMapper<Dwp_bet_detailEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public Dwp_bet_detailEO()
		{
			this.ChipsID = 0;
			this.BetBaseAmount = 0;
			this.BetMulitp = 0d;
			this.BetTotalAmount = 0;
			this.BetResultAmount = 0;
			this.IsWin = false;
			this.Star = 0;
			this.CardIdx = 0;
			this.Card = 0;
			this.RoundIdx = 0;
			this.JPTotalValue = 0;
			this.IsTriggerJP = false;
			this.JPRewardIndex = 0;
			this.JPRewardValue = 0;
			this.GameStatus = 0;
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
		/// 下注倍数
		/// 【字段 double】
		/// </summary>
		[DataMember(Order = 5)]
		public double BetMulitp { get; set; }
		/// <summary>
		/// 本轮总下注
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 6)]
		public long BetTotalAmount { get; set; }
		/// <summary>
		/// 本轮结果
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 7)]
		public long BetResultAmount { get; set; }
		/// <summary>
		/// 是否中奖
		/// 【字段 tinyint(1)】
		/// </summary>
		[DataMember(Order = 8)]
		public bool IsWin { get; set; }
		/// <summary>
		/// 星星数
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 9)]
		public int Star { get; set; }
		/// <summary>
		/// 下注索引 10次一洗牌
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 10)]
		public int CardIdx { get; set; }
		/// <summary>
		/// 卡牌点数
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 11)]
		public int Card { get; set; }
		/// <summary>
		/// 回合数，总翻拍次数
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 12)]
		public int RoundIdx { get; set; }
		/// <summary>
		/// JP累计值
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 13)]
		public int JPTotalValue { get; set; }
		/// <summary>
		/// 是否触发JP大奖（触发不一定中）
		/// 【字段 tinyint(1)】
		/// </summary>
		[DataMember(Order = 14)]
		public bool IsTriggerJP { get; set; }
		/// <summary>
		/// JP ID
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 15)]
		public int JPRewardIndex { get; set; }
		/// <summary>
		/// JP 金额
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 16)]
		public long JPRewardValue { get; set; }
		/// <summary>
		/// roundIdx>0时，需要判断4种状态，1-star达到最大，2-betResult达到maxBet，3-balance小于baseBet，4-balance
		/// 【字段 tinyint】
		/// </summary>
		[DataMember(Order = 17)]
		public int GameStatus { get; set; }
		/// <summary>
		/// 状态0-初始1-处理中2-成功3-失败4-已回滚5-异常且需处理6-异常已处理
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 18)]
		public int OrderStatus { get; set; }
		/// <summary>
		/// 每回合历史记录
		/// 【字段 text】
		/// </summary>
		[DataMember(Order = 19)]
		public string History { get; set; }
		/// <summary>
		/// 记录时间
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 20)]
		public DateTime? RecDate { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public Dwp_bet_detailEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static Dwp_bet_detailEO MapDataReader(IDataReader reader)
		{
		    Dwp_bet_detailEO ret = new Dwp_bet_detailEO();
			ret.BetID = reader.ToInt64("BetID");
			ret.OriginalBetID = ret.BetID;
			ret.UserID = reader.ToString("UserID");
			ret.ChipsID = reader.ToInt32("ChipsID");
			ret.BetBaseAmount = reader.ToInt64("BetBaseAmount");
			ret.BetMulitp = reader.ToDouble("BetMulitp");
			ret.BetTotalAmount = reader.ToInt64("BetTotalAmount");
			ret.BetResultAmount = reader.ToInt64("BetResultAmount");
			ret.IsWin = reader.ToBoolean("IsWin");
			ret.Star = reader.ToInt32("Star");
			ret.CardIdx = reader.ToInt32("CardIdx");
			ret.Card = reader.ToInt32("Card");
			ret.RoundIdx = reader.ToInt32("RoundIdx");
			ret.JPTotalValue = reader.ToInt32("JPTotalValue");
			ret.IsTriggerJP = reader.ToBoolean("IsTriggerJP");
			ret.JPRewardIndex = reader.ToInt32("JPRewardIndex");
			ret.JPRewardValue = reader.ToInt64("JPRewardValue");
			ret.GameStatus = reader.ToInt32("GameStatus");
			ret.OrderStatus = reader.ToInt32("OrderStatus");
			ret.History = reader.ToString("History");
			ret.RecDate = reader.ToDateTimeN("RecDate");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 
	/// 【表 dwp_bet_detail 的操作类】
	/// </summary>
	[Obsolete]
	public class Dwp_bet_detailMO : MySqlTableMO<Dwp_bet_detailEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`dwp_bet_detail`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public Dwp_bet_detailMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public Dwp_bet_detailMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public Dwp_bet_detailMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(Dwp_bet_detailEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(Dwp_bet_detailEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(Dwp_bet_detailEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`BetID`, `UserID`, `ChipsID`, `BetBaseAmount`, `BetMulitp`, `BetTotalAmount`, `BetResultAmount`, `IsWin`, `Star`, `CardIdx`, `Card`, `RoundIdx`, `JPTotalValue`, `IsTriggerJP`, `JPRewardIndex`, `JPRewardValue`, `GameStatus`, `OrderStatus`, `History`, `RecDate`) VALUE (@BetID, @UserID, @ChipsID, @BetBaseAmount, @BetMulitp, @BetTotalAmount, @BetResultAmount, @IsWin, @Star, @CardIdx, @Card, @RoundIdx, @JPTotalValue, @IsTriggerJP, @JPRewardIndex, @JPRewardValue, @GameStatus, @OrderStatus, @History, @RecDate);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", item.BetID, MySqlDbType.Int64),
				Database.CreateInParameter("@UserID", item.UserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@ChipsID", item.ChipsID, MySqlDbType.Int32),
				Database.CreateInParameter("@BetBaseAmount", item.BetBaseAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@BetMulitp", item.BetMulitp, MySqlDbType.Double),
				Database.CreateInParameter("@BetTotalAmount", item.BetTotalAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@BetResultAmount", item.BetResultAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@IsWin", item.IsWin, MySqlDbType.Byte),
				Database.CreateInParameter("@Star", item.Star, MySqlDbType.Int32),
				Database.CreateInParameter("@CardIdx", item.CardIdx, MySqlDbType.Int32),
				Database.CreateInParameter("@Card", item.Card, MySqlDbType.Int32),
				Database.CreateInParameter("@RoundIdx", item.RoundIdx, MySqlDbType.Int32),
				Database.CreateInParameter("@JPTotalValue", item.JPTotalValue, MySqlDbType.Int32),
				Database.CreateInParameter("@IsTriggerJP", item.IsTriggerJP, MySqlDbType.Byte),
				Database.CreateInParameter("@JPRewardIndex", item.JPRewardIndex, MySqlDbType.Int32),
				Database.CreateInParameter("@JPRewardValue", item.JPRewardValue, MySqlDbType.Int64),
				Database.CreateInParameter("@GameStatus", item.GameStatus, MySqlDbType.Byte),
				Database.CreateInParameter("@OrderStatus", item.OrderStatus, MySqlDbType.Int32),
				Database.CreateInParameter("@History", item.History, MySqlDbType.Text),
				Database.CreateInParameter("@RecDate", item.RecDate.HasValue ? item.RecDate.Value : (object)DBNull.Value, MySqlDbType.DateTime),
			};
		}
		public int AddByBatch(IEnumerable<Dwp_bet_detailEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<Dwp_bet_detailEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<Dwp_bet_detailEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`BetID`, `UserID`, `ChipsID`, `BetBaseAmount`, `BetMulitp`, `BetTotalAmount`, `BetResultAmount`, `IsWin`, `Star`, `CardIdx`, `Card`, `RoundIdx`, `JPTotalValue`, `IsTriggerJP`, `JPRewardIndex`, `JPRewardValue`, `GameStatus`, `OrderStatus`, `History`, `RecDate`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"({item.BetID},'{item.UserID}',{item.ChipsID},{item.BetBaseAmount},{item.BetMulitp},{item.BetTotalAmount},{item.BetResultAmount},{item.IsWin},{item.Star},{item.CardIdx},{item.Card},{item.RoundIdx},{item.JPTotalValue},{item.IsTriggerJP},{item.JPRewardIndex},{item.JPRewardValue},{item.GameStatus},{item.OrderStatus},'{item.History}','{item.RecDate?.ToString("yyyy-MM-dd HH:mm:ss")}'),");
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
		public int Remove(Dwp_bet_detailEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.BetID, tm_);
		}
		public async Task<int> RemoveAsync(Dwp_bet_detailEO item, TransactionManager tm_ = null)
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
		#region RemoveByBetMulitp
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "betMulitp">下注倍数</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByBetMulitp(double betMulitp, TransactionManager tm_ = null)
		{
			RepairRemoveByBetMulitpData(betMulitp, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByBetMulitpAsync(double betMulitp, TransactionManager tm_ = null)
		{
			RepairRemoveByBetMulitpData(betMulitp, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByBetMulitpData(double betMulitp, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `BetMulitp` = @BetMulitp";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BetMulitp", betMulitp, MySqlDbType.Double));
		}
		#endregion // RemoveByBetMulitp
		#region RemoveByBetTotalAmount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "betTotalAmount">本轮总下注</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByBetTotalAmount(long betTotalAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByBetTotalAmountData(betTotalAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByBetTotalAmountAsync(long betTotalAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByBetTotalAmountData(betTotalAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByBetTotalAmountData(long betTotalAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `BetTotalAmount` = @BetTotalAmount";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BetTotalAmount", betTotalAmount, MySqlDbType.Int64));
		}
		#endregion // RemoveByBetTotalAmount
		#region RemoveByBetResultAmount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "betResultAmount">本轮结果</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByBetResultAmount(long betResultAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByBetResultAmountData(betResultAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByBetResultAmountAsync(long betResultAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByBetResultAmountData(betResultAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByBetResultAmountData(long betResultAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `BetResultAmount` = @BetResultAmount";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BetResultAmount", betResultAmount, MySqlDbType.Int64));
		}
		#endregion // RemoveByBetResultAmount
		#region RemoveByIsWin
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "isWin">是否中奖</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByIsWin(bool isWin, TransactionManager tm_ = null)
		{
			RepairRemoveByIsWinData(isWin, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByIsWinAsync(bool isWin, TransactionManager tm_ = null)
		{
			RepairRemoveByIsWinData(isWin, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByIsWinData(bool isWin, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `IsWin` = @IsWin";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IsWin", isWin, MySqlDbType.Byte));
		}
		#endregion // RemoveByIsWin
		#region RemoveByStar
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "star">星星数</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByStar(int star, TransactionManager tm_ = null)
		{
			RepairRemoveByStarData(star, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByStarAsync(int star, TransactionManager tm_ = null)
		{
			RepairRemoveByStarData(star, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByStarData(int star, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `Star` = @Star";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Star", star, MySqlDbType.Int32));
		}
		#endregion // RemoveByStar
		#region RemoveByCardIdx
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "cardIdx">下注索引 10次一洗牌</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByCardIdx(int cardIdx, TransactionManager tm_ = null)
		{
			RepairRemoveByCardIdxData(cardIdx, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByCardIdxAsync(int cardIdx, TransactionManager tm_ = null)
		{
			RepairRemoveByCardIdxData(cardIdx, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByCardIdxData(int cardIdx, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `CardIdx` = @CardIdx";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CardIdx", cardIdx, MySqlDbType.Int32));
		}
		#endregion // RemoveByCardIdx
		#region RemoveByCard
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "card">卡牌点数</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByCard(int card, TransactionManager tm_ = null)
		{
			RepairRemoveByCardData(card, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByCardAsync(int card, TransactionManager tm_ = null)
		{
			RepairRemoveByCardData(card, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByCardData(int card, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `Card` = @Card";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Card", card, MySqlDbType.Int32));
		}
		#endregion // RemoveByCard
		#region RemoveByRoundIdx
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "roundIdx">回合数，总翻拍次数</param>
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
		#region RemoveByJPTotalValue
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "jPTotalValue">JP累计值</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByJPTotalValue(int jPTotalValue, TransactionManager tm_ = null)
		{
			RepairRemoveByJPTotalValueData(jPTotalValue, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByJPTotalValueAsync(int jPTotalValue, TransactionManager tm_ = null)
		{
			RepairRemoveByJPTotalValueData(jPTotalValue, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByJPTotalValueData(int jPTotalValue, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `JPTotalValue` = @JPTotalValue";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@JPTotalValue", jPTotalValue, MySqlDbType.Int32));
		}
		#endregion // RemoveByJPTotalValue
		#region RemoveByIsTriggerJP
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "isTriggerJP">是否触发JP大奖（触发不一定中）</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByIsTriggerJP(bool isTriggerJP, TransactionManager tm_ = null)
		{
			RepairRemoveByIsTriggerJPData(isTriggerJP, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByIsTriggerJPAsync(bool isTriggerJP, TransactionManager tm_ = null)
		{
			RepairRemoveByIsTriggerJPData(isTriggerJP, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByIsTriggerJPData(bool isTriggerJP, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `IsTriggerJP` = @IsTriggerJP";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IsTriggerJP", isTriggerJP, MySqlDbType.Byte));
		}
		#endregion // RemoveByIsTriggerJP
		#region RemoveByJPRewardIndex
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "jPRewardIndex">JP ID</param>
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
		#region RemoveByGameStatus
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "gameStatus">roundIdx>0时，需要判断4种状态，1-star达到最大，2-betResult达到maxBet，3-balance小于baseBet，4-balance</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByGameStatus(int gameStatus, TransactionManager tm_ = null)
		{
			RepairRemoveByGameStatusData(gameStatus, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByGameStatusAsync(int gameStatus, TransactionManager tm_ = null)
		{
			RepairRemoveByGameStatusData(gameStatus, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByGameStatusData(int gameStatus, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `GameStatus` = @GameStatus";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@GameStatus", gameStatus, MySqlDbType.Byte));
		}
		#endregion // RemoveByGameStatus
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
		#region RemoveByHistory
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "history">每回合历史记录</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByHistory(string history, TransactionManager tm_ = null)
		{
			RepairRemoveByHistoryData(history, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByHistoryAsync(string history, TransactionManager tm_ = null)
		{
			RepairRemoveByHistoryData(history, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByHistoryData(string history, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `History` = @History";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@History", history, MySqlDbType.Text));
		}
		#endregion // RemoveByHistory
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
		public int Put(Dwp_bet_detailEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(Dwp_bet_detailEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(Dwp_bet_detailEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `BetID` = @BetID, `UserID` = @UserID, `ChipsID` = @ChipsID, `BetBaseAmount` = @BetBaseAmount, `BetMulitp` = @BetMulitp, `BetTotalAmount` = @BetTotalAmount, `BetResultAmount` = @BetResultAmount, `IsWin` = @IsWin, `Star` = @Star, `CardIdx` = @CardIdx, `Card` = @Card, `RoundIdx` = @RoundIdx, `JPTotalValue` = @JPTotalValue, `IsTriggerJP` = @IsTriggerJP, `JPRewardIndex` = @JPRewardIndex, `JPRewardValue` = @JPRewardValue, `GameStatus` = @GameStatus, `OrderStatus` = @OrderStatus, `History` = @History WHERE `BetID` = @BetID_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", item.BetID, MySqlDbType.Int64),
				Database.CreateInParameter("@UserID", item.UserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@ChipsID", item.ChipsID, MySqlDbType.Int32),
				Database.CreateInParameter("@BetBaseAmount", item.BetBaseAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@BetMulitp", item.BetMulitp, MySqlDbType.Double),
				Database.CreateInParameter("@BetTotalAmount", item.BetTotalAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@BetResultAmount", item.BetResultAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@IsWin", item.IsWin, MySqlDbType.Byte),
				Database.CreateInParameter("@Star", item.Star, MySqlDbType.Int32),
				Database.CreateInParameter("@CardIdx", item.CardIdx, MySqlDbType.Int32),
				Database.CreateInParameter("@Card", item.Card, MySqlDbType.Int32),
				Database.CreateInParameter("@RoundIdx", item.RoundIdx, MySqlDbType.Int32),
				Database.CreateInParameter("@JPTotalValue", item.JPTotalValue, MySqlDbType.Int32),
				Database.CreateInParameter("@IsTriggerJP", item.IsTriggerJP, MySqlDbType.Byte),
				Database.CreateInParameter("@JPRewardIndex", item.JPRewardIndex, MySqlDbType.Int32),
				Database.CreateInParameter("@JPRewardValue", item.JPRewardValue, MySqlDbType.Int64),
				Database.CreateInParameter("@GameStatus", item.GameStatus, MySqlDbType.Byte),
				Database.CreateInParameter("@OrderStatus", item.OrderStatus, MySqlDbType.Int32),
				Database.CreateInParameter("@History", item.History, MySqlDbType.Text),
				Database.CreateInParameter("@BetID_Original", item.HasOriginal ? item.OriginalBetID : item.BetID, MySqlDbType.Int64),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<Dwp_bet_detailEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<Dwp_bet_detailEO> items, TransactionManager tm_ = null)
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
		#region PutBetMulitp
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// /// <param name = "betMulitp">下注倍数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBetMulitpByPK(long betID, double betMulitp, TransactionManager tm_ = null)
		{
			RepairPutBetMulitpByPKData(betID, betMulitp, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutBetMulitpByPKAsync(long betID, double betMulitp, TransactionManager tm_ = null)
		{
			RepairPutBetMulitpByPKData(betID, betMulitp, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutBetMulitpByPKData(long betID, double betMulitp, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `BetMulitp` = @BetMulitp  WHERE `BetID` = @BetID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetMulitp", betMulitp, MySqlDbType.Double),
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "betMulitp">下注倍数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBetMulitp(double betMulitp, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `BetMulitp` = @BetMulitp";
			var parameter_ = Database.CreateInParameter("@BetMulitp", betMulitp, MySqlDbType.Double);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutBetMulitpAsync(double betMulitp, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `BetMulitp` = @BetMulitp";
			var parameter_ = Database.CreateInParameter("@BetMulitp", betMulitp, MySqlDbType.Double);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutBetMulitp
		#region PutBetTotalAmount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// /// <param name = "betTotalAmount">本轮总下注</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBetTotalAmountByPK(long betID, long betTotalAmount, TransactionManager tm_ = null)
		{
			RepairPutBetTotalAmountByPKData(betID, betTotalAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutBetTotalAmountByPKAsync(long betID, long betTotalAmount, TransactionManager tm_ = null)
		{
			RepairPutBetTotalAmountByPKData(betID, betTotalAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutBetTotalAmountByPKData(long betID, long betTotalAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `BetTotalAmount` = @BetTotalAmount  WHERE `BetID` = @BetID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetTotalAmount", betTotalAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "betTotalAmount">本轮总下注</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBetTotalAmount(long betTotalAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `BetTotalAmount` = @BetTotalAmount";
			var parameter_ = Database.CreateInParameter("@BetTotalAmount", betTotalAmount, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutBetTotalAmountAsync(long betTotalAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `BetTotalAmount` = @BetTotalAmount";
			var parameter_ = Database.CreateInParameter("@BetTotalAmount", betTotalAmount, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutBetTotalAmount
		#region PutBetResultAmount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// /// <param name = "betResultAmount">本轮结果</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBetResultAmountByPK(long betID, long betResultAmount, TransactionManager tm_ = null)
		{
			RepairPutBetResultAmountByPKData(betID, betResultAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutBetResultAmountByPKAsync(long betID, long betResultAmount, TransactionManager tm_ = null)
		{
			RepairPutBetResultAmountByPKData(betID, betResultAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutBetResultAmountByPKData(long betID, long betResultAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `BetResultAmount` = @BetResultAmount  WHERE `BetID` = @BetID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetResultAmount", betResultAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "betResultAmount">本轮结果</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBetResultAmount(long betResultAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `BetResultAmount` = @BetResultAmount";
			var parameter_ = Database.CreateInParameter("@BetResultAmount", betResultAmount, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutBetResultAmountAsync(long betResultAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `BetResultAmount` = @BetResultAmount";
			var parameter_ = Database.CreateInParameter("@BetResultAmount", betResultAmount, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutBetResultAmount
		#region PutIsWin
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// /// <param name = "isWin">是否中奖</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutIsWinByPK(long betID, bool isWin, TransactionManager tm_ = null)
		{
			RepairPutIsWinByPKData(betID, isWin, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutIsWinByPKAsync(long betID, bool isWin, TransactionManager tm_ = null)
		{
			RepairPutIsWinByPKData(betID, isWin, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutIsWinByPKData(long betID, bool isWin, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `IsWin` = @IsWin  WHERE `BetID` = @BetID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@IsWin", isWin, MySqlDbType.Byte),
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "isWin">是否中奖</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutIsWin(bool isWin, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `IsWin` = @IsWin";
			var parameter_ = Database.CreateInParameter("@IsWin", isWin, MySqlDbType.Byte);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutIsWinAsync(bool isWin, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `IsWin` = @IsWin";
			var parameter_ = Database.CreateInParameter("@IsWin", isWin, MySqlDbType.Byte);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutIsWin
		#region PutStar
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// /// <param name = "star">星星数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutStarByPK(long betID, int star, TransactionManager tm_ = null)
		{
			RepairPutStarByPKData(betID, star, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutStarByPKAsync(long betID, int star, TransactionManager tm_ = null)
		{
			RepairPutStarByPKData(betID, star, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutStarByPKData(long betID, int star, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Star` = @Star  WHERE `BetID` = @BetID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Star", star, MySqlDbType.Int32),
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "star">星星数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutStar(int star, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Star` = @Star";
			var parameter_ = Database.CreateInParameter("@Star", star, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutStarAsync(int star, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Star` = @Star";
			var parameter_ = Database.CreateInParameter("@Star", star, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutStar
		#region PutCardIdx
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// /// <param name = "cardIdx">下注索引 10次一洗牌</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCardIdxByPK(long betID, int cardIdx, TransactionManager tm_ = null)
		{
			RepairPutCardIdxByPKData(betID, cardIdx, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutCardIdxByPKAsync(long betID, int cardIdx, TransactionManager tm_ = null)
		{
			RepairPutCardIdxByPKData(betID, cardIdx, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutCardIdxByPKData(long betID, int cardIdx, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `CardIdx` = @CardIdx  WHERE `BetID` = @BetID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@CardIdx", cardIdx, MySqlDbType.Int32),
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "cardIdx">下注索引 10次一洗牌</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCardIdx(int cardIdx, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CardIdx` = @CardIdx";
			var parameter_ = Database.CreateInParameter("@CardIdx", cardIdx, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutCardIdxAsync(int cardIdx, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `CardIdx` = @CardIdx";
			var parameter_ = Database.CreateInParameter("@CardIdx", cardIdx, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutCardIdx
		#region PutCard
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// /// <param name = "card">卡牌点数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCardByPK(long betID, int card, TransactionManager tm_ = null)
		{
			RepairPutCardByPKData(betID, card, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutCardByPKAsync(long betID, int card, TransactionManager tm_ = null)
		{
			RepairPutCardByPKData(betID, card, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutCardByPKData(long betID, int card, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Card` = @Card  WHERE `BetID` = @BetID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Card", card, MySqlDbType.Int32),
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "card">卡牌点数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutCard(int card, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Card` = @Card";
			var parameter_ = Database.CreateInParameter("@Card", card, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutCardAsync(int card, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Card` = @Card";
			var parameter_ = Database.CreateInParameter("@Card", card, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutCard
		#region PutRoundIdx
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// /// <param name = "roundIdx">回合数，总翻拍次数</param>
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
		/// /// <param name = "roundIdx">回合数，总翻拍次数</param>
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
		#region PutJPTotalValue
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// /// <param name = "jPTotalValue">JP累计值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutJPTotalValueByPK(long betID, int jPTotalValue, TransactionManager tm_ = null)
		{
			RepairPutJPTotalValueByPKData(betID, jPTotalValue, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutJPTotalValueByPKAsync(long betID, int jPTotalValue, TransactionManager tm_ = null)
		{
			RepairPutJPTotalValueByPKData(betID, jPTotalValue, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutJPTotalValueByPKData(long betID, int jPTotalValue, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `JPTotalValue` = @JPTotalValue  WHERE `BetID` = @BetID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@JPTotalValue", jPTotalValue, MySqlDbType.Int32),
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "jPTotalValue">JP累计值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutJPTotalValue(int jPTotalValue, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `JPTotalValue` = @JPTotalValue";
			var parameter_ = Database.CreateInParameter("@JPTotalValue", jPTotalValue, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutJPTotalValueAsync(int jPTotalValue, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `JPTotalValue` = @JPTotalValue";
			var parameter_ = Database.CreateInParameter("@JPTotalValue", jPTotalValue, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutJPTotalValue
		#region PutIsTriggerJP
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// /// <param name = "isTriggerJP">是否触发JP大奖（触发不一定中）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutIsTriggerJPByPK(long betID, bool isTriggerJP, TransactionManager tm_ = null)
		{
			RepairPutIsTriggerJPByPKData(betID, isTriggerJP, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutIsTriggerJPByPKAsync(long betID, bool isTriggerJP, TransactionManager tm_ = null)
		{
			RepairPutIsTriggerJPByPKData(betID, isTriggerJP, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutIsTriggerJPByPKData(long betID, bool isTriggerJP, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `IsTriggerJP` = @IsTriggerJP  WHERE `BetID` = @BetID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@IsTriggerJP", isTriggerJP, MySqlDbType.Byte),
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "isTriggerJP">是否触发JP大奖（触发不一定中）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutIsTriggerJP(bool isTriggerJP, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `IsTriggerJP` = @IsTriggerJP";
			var parameter_ = Database.CreateInParameter("@IsTriggerJP", isTriggerJP, MySqlDbType.Byte);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutIsTriggerJPAsync(bool isTriggerJP, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `IsTriggerJP` = @IsTriggerJP";
			var parameter_ = Database.CreateInParameter("@IsTriggerJP", isTriggerJP, MySqlDbType.Byte);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutIsTriggerJP
		#region PutJPRewardIndex
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// /// <param name = "jPRewardIndex">JP ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutJPRewardIndexByPK(long betID, int jPRewardIndex, TransactionManager tm_ = null)
		{
			RepairPutJPRewardIndexByPKData(betID, jPRewardIndex, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutJPRewardIndexByPKAsync(long betID, int jPRewardIndex, TransactionManager tm_ = null)
		{
			RepairPutJPRewardIndexByPKData(betID, jPRewardIndex, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutJPRewardIndexByPKData(long betID, int jPRewardIndex, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `JPRewardIndex` = @JPRewardIndex  WHERE `BetID` = @BetID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@JPRewardIndex", jPRewardIndex, MySqlDbType.Int32),
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "jPRewardIndex">JP ID</param>
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
		#region PutGameStatus
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// /// <param name = "gameStatus">roundIdx>0时，需要判断4种状态，1-star达到最大，2-betResult达到maxBet，3-balance小于baseBet，4-balance</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutGameStatusByPK(long betID, int gameStatus, TransactionManager tm_ = null)
		{
			RepairPutGameStatusByPKData(betID, gameStatus, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutGameStatusByPKAsync(long betID, int gameStatus, TransactionManager tm_ = null)
		{
			RepairPutGameStatusByPKData(betID, gameStatus, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutGameStatusByPKData(long betID, int gameStatus, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `GameStatus` = @GameStatus  WHERE `BetID` = @BetID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@GameStatus", gameStatus, MySqlDbType.Byte),
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "gameStatus">roundIdx>0时，需要判断4种状态，1-star达到最大，2-betResult达到maxBet，3-balance小于baseBet，4-balance</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutGameStatus(int gameStatus, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `GameStatus` = @GameStatus";
			var parameter_ = Database.CreateInParameter("@GameStatus", gameStatus, MySqlDbType.Byte);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutGameStatusAsync(int gameStatus, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `GameStatus` = @GameStatus";
			var parameter_ = Database.CreateInParameter("@GameStatus", gameStatus, MySqlDbType.Byte);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutGameStatus
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
		#region PutHistory
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// /// <param name = "history">每回合历史记录</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutHistoryByPK(long betID, string history, TransactionManager tm_ = null)
		{
			RepairPutHistoryByPKData(betID, history, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutHistoryByPKAsync(long betID, string history, TransactionManager tm_ = null)
		{
			RepairPutHistoryByPKData(betID, history, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutHistoryByPKData(long betID, string history, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `History` = @History  WHERE `BetID` = @BetID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@History", history, MySqlDbType.Text),
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "history">每回合历史记录</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutHistory(string history, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `History` = @History";
			var parameter_ = Database.CreateInParameter("@History", history, MySqlDbType.Text);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutHistoryAsync(string history, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `History` = @History";
			var parameter_ = Database.CreateInParameter("@History", history, MySqlDbType.Text);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutHistory
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
		public bool Set(Dwp_bet_detailEO item, TransactionManager tm = null)
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
		public async Task<bool> SetAsync(Dwp_bet_detailEO item, TransactionManager tm = null)
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
		public Dwp_bet_detailEO GetByPK(long betID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(betID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, Dwp_bet_detailEO.MapDataReader);
		}
		public async Task<Dwp_bet_detailEO> GetByPKAsync(long betID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(betID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Dwp_bet_detailEO.MapDataReader);
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
		/// 按主键查询 BetMulitp（字段）
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public double GetBetMulitpByPK(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (double)GetScalar("`BetMulitp`", "`BetID` = @BetID", paras_, tm_);
		}
		public async Task<double> GetBetMulitpByPKAsync(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (double)await GetScalarAsync("`BetMulitp`", "`BetID` = @BetID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 BetTotalAmount（字段）
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetBetTotalAmountByPK(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (long)GetScalar("`BetTotalAmount`", "`BetID` = @BetID", paras_, tm_);
		}
		public async Task<long> GetBetTotalAmountByPKAsync(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (long)await GetScalarAsync("`BetTotalAmount`", "`BetID` = @BetID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 BetResultAmount（字段）
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetBetResultAmountByPK(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (long)GetScalar("`BetResultAmount`", "`BetID` = @BetID", paras_, tm_);
		}
		public async Task<long> GetBetResultAmountByPKAsync(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (long)await GetScalarAsync("`BetResultAmount`", "`BetID` = @BetID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 IsWin（字段）
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public bool GetIsWinByPK(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (bool)GetScalar("`IsWin`", "`BetID` = @BetID", paras_, tm_);
		}
		public async Task<bool> GetIsWinByPKAsync(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (bool)await GetScalarAsync("`IsWin`", "`BetID` = @BetID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Star（字段）
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetStarByPK(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (int)GetScalar("`Star`", "`BetID` = @BetID", paras_, tm_);
		}
		public async Task<int> GetStarByPKAsync(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (int)await GetScalarAsync("`Star`", "`BetID` = @BetID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 CardIdx（字段）
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetCardIdxByPK(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (int)GetScalar("`CardIdx`", "`BetID` = @BetID", paras_, tm_);
		}
		public async Task<int> GetCardIdxByPKAsync(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (int)await GetScalarAsync("`CardIdx`", "`BetID` = @BetID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Card（字段）
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetCardByPK(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (int)GetScalar("`Card`", "`BetID` = @BetID", paras_, tm_);
		}
		public async Task<int> GetCardByPKAsync(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (int)await GetScalarAsync("`Card`", "`BetID` = @BetID", paras_, tm_);
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
		/// 按主键查询 JPTotalValue（字段）
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetJPTotalValueByPK(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (int)GetScalar("`JPTotalValue`", "`BetID` = @BetID", paras_, tm_);
		}
		public async Task<int> GetJPTotalValueByPKAsync(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (int)await GetScalarAsync("`JPTotalValue`", "`BetID` = @BetID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 IsTriggerJP（字段）
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public bool GetIsTriggerJPByPK(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (bool)GetScalar("`IsTriggerJP`", "`BetID` = @BetID", paras_, tm_);
		}
		public async Task<bool> GetIsTriggerJPByPKAsync(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (bool)await GetScalarAsync("`IsTriggerJP`", "`BetID` = @BetID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 JPRewardIndex（字段）
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetJPRewardIndexByPK(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (int)GetScalar("`JPRewardIndex`", "`BetID` = @BetID", paras_, tm_);
		}
		public async Task<int> GetJPRewardIndexByPKAsync(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (int)await GetScalarAsync("`JPRewardIndex`", "`BetID` = @BetID", paras_, tm_);
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
		/// 按主键查询 GameStatus（字段）
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetGameStatusByPK(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (int)GetScalar("`GameStatus`", "`BetID` = @BetID", paras_, tm_);
		}
		public async Task<int> GetGameStatusByPKAsync(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (int)await GetScalarAsync("`GameStatus`", "`BetID` = @BetID", paras_, tm_);
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
		/// 按主键查询 History（字段）
		/// </summary>
		/// /// <param name = "betID">主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetHistoryByPK(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (string)GetScalar("`History`", "`BetID` = @BetID", paras_, tm_);
		}
		public async Task<string> GetHistoryByPKAsync(long betID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetID", betID, MySqlDbType.Int64),
			};
			return (string)await GetScalarAsync("`History`", "`BetID` = @BetID", paras_, tm_);
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
		public List<Dwp_bet_detailEO> GetByUserID(string userID)
		{
			return GetByUserID(userID, 0, string.Empty, null);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByUserIDAsync(string userID)
		{
			return await GetByUserIDAsync(userID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户Id</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Dwp_bet_detailEO> GetByUserID(string userID, TransactionManager tm_)
		{
			return GetByUserID(userID, 0, string.Empty, tm_);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByUserIDAsync(string userID, TransactionManager tm_)
		{
			return await GetByUserIDAsync(userID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户Id</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Dwp_bet_detailEO> GetByUserID(string userID, int top_)
		{
			return GetByUserID(userID, top_, string.Empty, null);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByUserIDAsync(string userID, int top_)
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
		public List<Dwp_bet_detailEO> GetByUserID(string userID, int top_, TransactionManager tm_)
		{
			return GetByUserID(userID, top_, string.Empty, tm_);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByUserIDAsync(string userID, int top_, TransactionManager tm_)
		{
			return await GetByUserIDAsync(userID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 UserID（字段） 查询
		/// </summary>
		/// /// <param name = "userID">用户Id</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Dwp_bet_detailEO> GetByUserID(string userID, string sort_)
		{
			return GetByUserID(userID, 0, sort_, null);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByUserIDAsync(string userID, string sort_)
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
		public List<Dwp_bet_detailEO> GetByUserID(string userID, string sort_, TransactionManager tm_)
		{
			return GetByUserID(userID, 0, sort_, tm_);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByUserIDAsync(string userID, string sort_, TransactionManager tm_)
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
		public List<Dwp_bet_detailEO> GetByUserID(string userID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UserID` = @UserID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Dwp_bet_detailEO.MapDataReader);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByUserIDAsync(string userID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`UserID` = @UserID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Dwp_bet_detailEO.MapDataReader);
		}
		#endregion // GetByUserID
		#region GetByChipsID
		
		/// <summary>
		/// 按 ChipsID（字段） 查询
		/// </summary>
		/// /// <param name = "chipsID">下注配置ID</param>
		/// <return>实体对象集合</return>
		public List<Dwp_bet_detailEO> GetByChipsID(int chipsID)
		{
			return GetByChipsID(chipsID, 0, string.Empty, null);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByChipsIDAsync(int chipsID)
		{
			return await GetByChipsIDAsync(chipsID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ChipsID（字段） 查询
		/// </summary>
		/// /// <param name = "chipsID">下注配置ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Dwp_bet_detailEO> GetByChipsID(int chipsID, TransactionManager tm_)
		{
			return GetByChipsID(chipsID, 0, string.Empty, tm_);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByChipsIDAsync(int chipsID, TransactionManager tm_)
		{
			return await GetByChipsIDAsync(chipsID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ChipsID（字段） 查询
		/// </summary>
		/// /// <param name = "chipsID">下注配置ID</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Dwp_bet_detailEO> GetByChipsID(int chipsID, int top_)
		{
			return GetByChipsID(chipsID, top_, string.Empty, null);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByChipsIDAsync(int chipsID, int top_)
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
		public List<Dwp_bet_detailEO> GetByChipsID(int chipsID, int top_, TransactionManager tm_)
		{
			return GetByChipsID(chipsID, top_, string.Empty, tm_);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByChipsIDAsync(int chipsID, int top_, TransactionManager tm_)
		{
			return await GetByChipsIDAsync(chipsID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ChipsID（字段） 查询
		/// </summary>
		/// /// <param name = "chipsID">下注配置ID</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Dwp_bet_detailEO> GetByChipsID(int chipsID, string sort_)
		{
			return GetByChipsID(chipsID, 0, sort_, null);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByChipsIDAsync(int chipsID, string sort_)
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
		public List<Dwp_bet_detailEO> GetByChipsID(int chipsID, string sort_, TransactionManager tm_)
		{
			return GetByChipsID(chipsID, 0, sort_, tm_);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByChipsIDAsync(int chipsID, string sort_, TransactionManager tm_)
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
		public List<Dwp_bet_detailEO> GetByChipsID(int chipsID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ChipsID` = @ChipsID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Dwp_bet_detailEO.MapDataReader);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByChipsIDAsync(int chipsID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ChipsID` = @ChipsID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Dwp_bet_detailEO.MapDataReader);
		}
		#endregion // GetByChipsID
		#region GetByBetBaseAmount
		
		/// <summary>
		/// 按 BetBaseAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betBaseAmount">实际下注金额</param>
		/// <return>实体对象集合</return>
		public List<Dwp_bet_detailEO> GetByBetBaseAmount(long betBaseAmount)
		{
			return GetByBetBaseAmount(betBaseAmount, 0, string.Empty, null);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByBetBaseAmountAsync(long betBaseAmount)
		{
			return await GetByBetBaseAmountAsync(betBaseAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BetBaseAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betBaseAmount">实际下注金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Dwp_bet_detailEO> GetByBetBaseAmount(long betBaseAmount, TransactionManager tm_)
		{
			return GetByBetBaseAmount(betBaseAmount, 0, string.Empty, tm_);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByBetBaseAmountAsync(long betBaseAmount, TransactionManager tm_)
		{
			return await GetByBetBaseAmountAsync(betBaseAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BetBaseAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betBaseAmount">实际下注金额</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Dwp_bet_detailEO> GetByBetBaseAmount(long betBaseAmount, int top_)
		{
			return GetByBetBaseAmount(betBaseAmount, top_, string.Empty, null);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByBetBaseAmountAsync(long betBaseAmount, int top_)
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
		public List<Dwp_bet_detailEO> GetByBetBaseAmount(long betBaseAmount, int top_, TransactionManager tm_)
		{
			return GetByBetBaseAmount(betBaseAmount, top_, string.Empty, tm_);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByBetBaseAmountAsync(long betBaseAmount, int top_, TransactionManager tm_)
		{
			return await GetByBetBaseAmountAsync(betBaseAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BetBaseAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betBaseAmount">实际下注金额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Dwp_bet_detailEO> GetByBetBaseAmount(long betBaseAmount, string sort_)
		{
			return GetByBetBaseAmount(betBaseAmount, 0, sort_, null);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByBetBaseAmountAsync(long betBaseAmount, string sort_)
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
		public List<Dwp_bet_detailEO> GetByBetBaseAmount(long betBaseAmount, string sort_, TransactionManager tm_)
		{
			return GetByBetBaseAmount(betBaseAmount, 0, sort_, tm_);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByBetBaseAmountAsync(long betBaseAmount, string sort_, TransactionManager tm_)
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
		public List<Dwp_bet_detailEO> GetByBetBaseAmount(long betBaseAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BetBaseAmount` = @BetBaseAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BetBaseAmount", betBaseAmount, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Dwp_bet_detailEO.MapDataReader);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByBetBaseAmountAsync(long betBaseAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BetBaseAmount` = @BetBaseAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BetBaseAmount", betBaseAmount, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Dwp_bet_detailEO.MapDataReader);
		}
		#endregion // GetByBetBaseAmount
		#region GetByBetMulitp
		
		/// <summary>
		/// 按 BetMulitp（字段） 查询
		/// </summary>
		/// /// <param name = "betMulitp">下注倍数</param>
		/// <return>实体对象集合</return>
		public List<Dwp_bet_detailEO> GetByBetMulitp(double betMulitp)
		{
			return GetByBetMulitp(betMulitp, 0, string.Empty, null);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByBetMulitpAsync(double betMulitp)
		{
			return await GetByBetMulitpAsync(betMulitp, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BetMulitp（字段） 查询
		/// </summary>
		/// /// <param name = "betMulitp">下注倍数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Dwp_bet_detailEO> GetByBetMulitp(double betMulitp, TransactionManager tm_)
		{
			return GetByBetMulitp(betMulitp, 0, string.Empty, tm_);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByBetMulitpAsync(double betMulitp, TransactionManager tm_)
		{
			return await GetByBetMulitpAsync(betMulitp, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BetMulitp（字段） 查询
		/// </summary>
		/// /// <param name = "betMulitp">下注倍数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Dwp_bet_detailEO> GetByBetMulitp(double betMulitp, int top_)
		{
			return GetByBetMulitp(betMulitp, top_, string.Empty, null);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByBetMulitpAsync(double betMulitp, int top_)
		{
			return await GetByBetMulitpAsync(betMulitp, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BetMulitp（字段） 查询
		/// </summary>
		/// /// <param name = "betMulitp">下注倍数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Dwp_bet_detailEO> GetByBetMulitp(double betMulitp, int top_, TransactionManager tm_)
		{
			return GetByBetMulitp(betMulitp, top_, string.Empty, tm_);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByBetMulitpAsync(double betMulitp, int top_, TransactionManager tm_)
		{
			return await GetByBetMulitpAsync(betMulitp, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BetMulitp（字段） 查询
		/// </summary>
		/// /// <param name = "betMulitp">下注倍数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Dwp_bet_detailEO> GetByBetMulitp(double betMulitp, string sort_)
		{
			return GetByBetMulitp(betMulitp, 0, sort_, null);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByBetMulitpAsync(double betMulitp, string sort_)
		{
			return await GetByBetMulitpAsync(betMulitp, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 BetMulitp（字段） 查询
		/// </summary>
		/// /// <param name = "betMulitp">下注倍数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Dwp_bet_detailEO> GetByBetMulitp(double betMulitp, string sort_, TransactionManager tm_)
		{
			return GetByBetMulitp(betMulitp, 0, sort_, tm_);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByBetMulitpAsync(double betMulitp, string sort_, TransactionManager tm_)
		{
			return await GetByBetMulitpAsync(betMulitp, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 BetMulitp（字段） 查询
		/// </summary>
		/// /// <param name = "betMulitp">下注倍数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Dwp_bet_detailEO> GetByBetMulitp(double betMulitp, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BetMulitp` = @BetMulitp", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BetMulitp", betMulitp, MySqlDbType.Double));
			return Database.ExecSqlList(sql_, paras_, tm_, Dwp_bet_detailEO.MapDataReader);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByBetMulitpAsync(double betMulitp, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BetMulitp` = @BetMulitp", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BetMulitp", betMulitp, MySqlDbType.Double));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Dwp_bet_detailEO.MapDataReader);
		}
		#endregion // GetByBetMulitp
		#region GetByBetTotalAmount
		
		/// <summary>
		/// 按 BetTotalAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betTotalAmount">本轮总下注</param>
		/// <return>实体对象集合</return>
		public List<Dwp_bet_detailEO> GetByBetTotalAmount(long betTotalAmount)
		{
			return GetByBetTotalAmount(betTotalAmount, 0, string.Empty, null);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByBetTotalAmountAsync(long betTotalAmount)
		{
			return await GetByBetTotalAmountAsync(betTotalAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BetTotalAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betTotalAmount">本轮总下注</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Dwp_bet_detailEO> GetByBetTotalAmount(long betTotalAmount, TransactionManager tm_)
		{
			return GetByBetTotalAmount(betTotalAmount, 0, string.Empty, tm_);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByBetTotalAmountAsync(long betTotalAmount, TransactionManager tm_)
		{
			return await GetByBetTotalAmountAsync(betTotalAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BetTotalAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betTotalAmount">本轮总下注</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Dwp_bet_detailEO> GetByBetTotalAmount(long betTotalAmount, int top_)
		{
			return GetByBetTotalAmount(betTotalAmount, top_, string.Empty, null);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByBetTotalAmountAsync(long betTotalAmount, int top_)
		{
			return await GetByBetTotalAmountAsync(betTotalAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BetTotalAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betTotalAmount">本轮总下注</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Dwp_bet_detailEO> GetByBetTotalAmount(long betTotalAmount, int top_, TransactionManager tm_)
		{
			return GetByBetTotalAmount(betTotalAmount, top_, string.Empty, tm_);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByBetTotalAmountAsync(long betTotalAmount, int top_, TransactionManager tm_)
		{
			return await GetByBetTotalAmountAsync(betTotalAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BetTotalAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betTotalAmount">本轮总下注</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Dwp_bet_detailEO> GetByBetTotalAmount(long betTotalAmount, string sort_)
		{
			return GetByBetTotalAmount(betTotalAmount, 0, sort_, null);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByBetTotalAmountAsync(long betTotalAmount, string sort_)
		{
			return await GetByBetTotalAmountAsync(betTotalAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 BetTotalAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betTotalAmount">本轮总下注</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Dwp_bet_detailEO> GetByBetTotalAmount(long betTotalAmount, string sort_, TransactionManager tm_)
		{
			return GetByBetTotalAmount(betTotalAmount, 0, sort_, tm_);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByBetTotalAmountAsync(long betTotalAmount, string sort_, TransactionManager tm_)
		{
			return await GetByBetTotalAmountAsync(betTotalAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 BetTotalAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betTotalAmount">本轮总下注</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Dwp_bet_detailEO> GetByBetTotalAmount(long betTotalAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BetTotalAmount` = @BetTotalAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BetTotalAmount", betTotalAmount, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Dwp_bet_detailEO.MapDataReader);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByBetTotalAmountAsync(long betTotalAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BetTotalAmount` = @BetTotalAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BetTotalAmount", betTotalAmount, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Dwp_bet_detailEO.MapDataReader);
		}
		#endregion // GetByBetTotalAmount
		#region GetByBetResultAmount
		
		/// <summary>
		/// 按 BetResultAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betResultAmount">本轮结果</param>
		/// <return>实体对象集合</return>
		public List<Dwp_bet_detailEO> GetByBetResultAmount(long betResultAmount)
		{
			return GetByBetResultAmount(betResultAmount, 0, string.Empty, null);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByBetResultAmountAsync(long betResultAmount)
		{
			return await GetByBetResultAmountAsync(betResultAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BetResultAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betResultAmount">本轮结果</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Dwp_bet_detailEO> GetByBetResultAmount(long betResultAmount, TransactionManager tm_)
		{
			return GetByBetResultAmount(betResultAmount, 0, string.Empty, tm_);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByBetResultAmountAsync(long betResultAmount, TransactionManager tm_)
		{
			return await GetByBetResultAmountAsync(betResultAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BetResultAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betResultAmount">本轮结果</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Dwp_bet_detailEO> GetByBetResultAmount(long betResultAmount, int top_)
		{
			return GetByBetResultAmount(betResultAmount, top_, string.Empty, null);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByBetResultAmountAsync(long betResultAmount, int top_)
		{
			return await GetByBetResultAmountAsync(betResultAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BetResultAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betResultAmount">本轮结果</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Dwp_bet_detailEO> GetByBetResultAmount(long betResultAmount, int top_, TransactionManager tm_)
		{
			return GetByBetResultAmount(betResultAmount, top_, string.Empty, tm_);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByBetResultAmountAsync(long betResultAmount, int top_, TransactionManager tm_)
		{
			return await GetByBetResultAmountAsync(betResultAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BetResultAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betResultAmount">本轮结果</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Dwp_bet_detailEO> GetByBetResultAmount(long betResultAmount, string sort_)
		{
			return GetByBetResultAmount(betResultAmount, 0, sort_, null);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByBetResultAmountAsync(long betResultAmount, string sort_)
		{
			return await GetByBetResultAmountAsync(betResultAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 BetResultAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betResultAmount">本轮结果</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Dwp_bet_detailEO> GetByBetResultAmount(long betResultAmount, string sort_, TransactionManager tm_)
		{
			return GetByBetResultAmount(betResultAmount, 0, sort_, tm_);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByBetResultAmountAsync(long betResultAmount, string sort_, TransactionManager tm_)
		{
			return await GetByBetResultAmountAsync(betResultAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 BetResultAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betResultAmount">本轮结果</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Dwp_bet_detailEO> GetByBetResultAmount(long betResultAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BetResultAmount` = @BetResultAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BetResultAmount", betResultAmount, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Dwp_bet_detailEO.MapDataReader);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByBetResultAmountAsync(long betResultAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BetResultAmount` = @BetResultAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BetResultAmount", betResultAmount, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Dwp_bet_detailEO.MapDataReader);
		}
		#endregion // GetByBetResultAmount
		#region GetByIsWin
		
		/// <summary>
		/// 按 IsWin（字段） 查询
		/// </summary>
		/// /// <param name = "isWin">是否中奖</param>
		/// <return>实体对象集合</return>
		public List<Dwp_bet_detailEO> GetByIsWin(bool isWin)
		{
			return GetByIsWin(isWin, 0, string.Empty, null);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByIsWinAsync(bool isWin)
		{
			return await GetByIsWinAsync(isWin, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 IsWin（字段） 查询
		/// </summary>
		/// /// <param name = "isWin">是否中奖</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Dwp_bet_detailEO> GetByIsWin(bool isWin, TransactionManager tm_)
		{
			return GetByIsWin(isWin, 0, string.Empty, tm_);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByIsWinAsync(bool isWin, TransactionManager tm_)
		{
			return await GetByIsWinAsync(isWin, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IsWin（字段） 查询
		/// </summary>
		/// /// <param name = "isWin">是否中奖</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Dwp_bet_detailEO> GetByIsWin(bool isWin, int top_)
		{
			return GetByIsWin(isWin, top_, string.Empty, null);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByIsWinAsync(bool isWin, int top_)
		{
			return await GetByIsWinAsync(isWin, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 IsWin（字段） 查询
		/// </summary>
		/// /// <param name = "isWin">是否中奖</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Dwp_bet_detailEO> GetByIsWin(bool isWin, int top_, TransactionManager tm_)
		{
			return GetByIsWin(isWin, top_, string.Empty, tm_);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByIsWinAsync(bool isWin, int top_, TransactionManager tm_)
		{
			return await GetByIsWinAsync(isWin, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IsWin（字段） 查询
		/// </summary>
		/// /// <param name = "isWin">是否中奖</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Dwp_bet_detailEO> GetByIsWin(bool isWin, string sort_)
		{
			return GetByIsWin(isWin, 0, sort_, null);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByIsWinAsync(bool isWin, string sort_)
		{
			return await GetByIsWinAsync(isWin, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 IsWin（字段） 查询
		/// </summary>
		/// /// <param name = "isWin">是否中奖</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Dwp_bet_detailEO> GetByIsWin(bool isWin, string sort_, TransactionManager tm_)
		{
			return GetByIsWin(isWin, 0, sort_, tm_);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByIsWinAsync(bool isWin, string sort_, TransactionManager tm_)
		{
			return await GetByIsWinAsync(isWin, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 IsWin（字段） 查询
		/// </summary>
		/// /// <param name = "isWin">是否中奖</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Dwp_bet_detailEO> GetByIsWin(bool isWin, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`IsWin` = @IsWin", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IsWin", isWin, MySqlDbType.Byte));
			return Database.ExecSqlList(sql_, paras_, tm_, Dwp_bet_detailEO.MapDataReader);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByIsWinAsync(bool isWin, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`IsWin` = @IsWin", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IsWin", isWin, MySqlDbType.Byte));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Dwp_bet_detailEO.MapDataReader);
		}
		#endregion // GetByIsWin
		#region GetByStar
		
		/// <summary>
		/// 按 Star（字段） 查询
		/// </summary>
		/// /// <param name = "star">星星数</param>
		/// <return>实体对象集合</return>
		public List<Dwp_bet_detailEO> GetByStar(int star)
		{
			return GetByStar(star, 0, string.Empty, null);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByStarAsync(int star)
		{
			return await GetByStarAsync(star, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Star（字段） 查询
		/// </summary>
		/// /// <param name = "star">星星数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Dwp_bet_detailEO> GetByStar(int star, TransactionManager tm_)
		{
			return GetByStar(star, 0, string.Empty, tm_);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByStarAsync(int star, TransactionManager tm_)
		{
			return await GetByStarAsync(star, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Star（字段） 查询
		/// </summary>
		/// /// <param name = "star">星星数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Dwp_bet_detailEO> GetByStar(int star, int top_)
		{
			return GetByStar(star, top_, string.Empty, null);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByStarAsync(int star, int top_)
		{
			return await GetByStarAsync(star, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Star（字段） 查询
		/// </summary>
		/// /// <param name = "star">星星数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Dwp_bet_detailEO> GetByStar(int star, int top_, TransactionManager tm_)
		{
			return GetByStar(star, top_, string.Empty, tm_);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByStarAsync(int star, int top_, TransactionManager tm_)
		{
			return await GetByStarAsync(star, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Star（字段） 查询
		/// </summary>
		/// /// <param name = "star">星星数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Dwp_bet_detailEO> GetByStar(int star, string sort_)
		{
			return GetByStar(star, 0, sort_, null);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByStarAsync(int star, string sort_)
		{
			return await GetByStarAsync(star, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Star（字段） 查询
		/// </summary>
		/// /// <param name = "star">星星数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Dwp_bet_detailEO> GetByStar(int star, string sort_, TransactionManager tm_)
		{
			return GetByStar(star, 0, sort_, tm_);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByStarAsync(int star, string sort_, TransactionManager tm_)
		{
			return await GetByStarAsync(star, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Star（字段） 查询
		/// </summary>
		/// /// <param name = "star">星星数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Dwp_bet_detailEO> GetByStar(int star, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Star` = @Star", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Star", star, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Dwp_bet_detailEO.MapDataReader);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByStarAsync(int star, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Star` = @Star", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Star", star, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Dwp_bet_detailEO.MapDataReader);
		}
		#endregion // GetByStar
		#region GetByCardIdx
		
		/// <summary>
		/// 按 CardIdx（字段） 查询
		/// </summary>
		/// /// <param name = "cardIdx">下注索引 10次一洗牌</param>
		/// <return>实体对象集合</return>
		public List<Dwp_bet_detailEO> GetByCardIdx(int cardIdx)
		{
			return GetByCardIdx(cardIdx, 0, string.Empty, null);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByCardIdxAsync(int cardIdx)
		{
			return await GetByCardIdxAsync(cardIdx, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CardIdx（字段） 查询
		/// </summary>
		/// /// <param name = "cardIdx">下注索引 10次一洗牌</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Dwp_bet_detailEO> GetByCardIdx(int cardIdx, TransactionManager tm_)
		{
			return GetByCardIdx(cardIdx, 0, string.Empty, tm_);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByCardIdxAsync(int cardIdx, TransactionManager tm_)
		{
			return await GetByCardIdxAsync(cardIdx, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CardIdx（字段） 查询
		/// </summary>
		/// /// <param name = "cardIdx">下注索引 10次一洗牌</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Dwp_bet_detailEO> GetByCardIdx(int cardIdx, int top_)
		{
			return GetByCardIdx(cardIdx, top_, string.Empty, null);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByCardIdxAsync(int cardIdx, int top_)
		{
			return await GetByCardIdxAsync(cardIdx, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CardIdx（字段） 查询
		/// </summary>
		/// /// <param name = "cardIdx">下注索引 10次一洗牌</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Dwp_bet_detailEO> GetByCardIdx(int cardIdx, int top_, TransactionManager tm_)
		{
			return GetByCardIdx(cardIdx, top_, string.Empty, tm_);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByCardIdxAsync(int cardIdx, int top_, TransactionManager tm_)
		{
			return await GetByCardIdxAsync(cardIdx, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CardIdx（字段） 查询
		/// </summary>
		/// /// <param name = "cardIdx">下注索引 10次一洗牌</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Dwp_bet_detailEO> GetByCardIdx(int cardIdx, string sort_)
		{
			return GetByCardIdx(cardIdx, 0, sort_, null);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByCardIdxAsync(int cardIdx, string sort_)
		{
			return await GetByCardIdxAsync(cardIdx, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 CardIdx（字段） 查询
		/// </summary>
		/// /// <param name = "cardIdx">下注索引 10次一洗牌</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Dwp_bet_detailEO> GetByCardIdx(int cardIdx, string sort_, TransactionManager tm_)
		{
			return GetByCardIdx(cardIdx, 0, sort_, tm_);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByCardIdxAsync(int cardIdx, string sort_, TransactionManager tm_)
		{
			return await GetByCardIdxAsync(cardIdx, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 CardIdx（字段） 查询
		/// </summary>
		/// /// <param name = "cardIdx">下注索引 10次一洗牌</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Dwp_bet_detailEO> GetByCardIdx(int cardIdx, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CardIdx` = @CardIdx", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CardIdx", cardIdx, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Dwp_bet_detailEO.MapDataReader);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByCardIdxAsync(int cardIdx, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CardIdx` = @CardIdx", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CardIdx", cardIdx, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Dwp_bet_detailEO.MapDataReader);
		}
		#endregion // GetByCardIdx
		#region GetByCard
		
		/// <summary>
		/// 按 Card（字段） 查询
		/// </summary>
		/// /// <param name = "card">卡牌点数</param>
		/// <return>实体对象集合</return>
		public List<Dwp_bet_detailEO> GetByCard(int card)
		{
			return GetByCard(card, 0, string.Empty, null);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByCardAsync(int card)
		{
			return await GetByCardAsync(card, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Card（字段） 查询
		/// </summary>
		/// /// <param name = "card">卡牌点数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Dwp_bet_detailEO> GetByCard(int card, TransactionManager tm_)
		{
			return GetByCard(card, 0, string.Empty, tm_);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByCardAsync(int card, TransactionManager tm_)
		{
			return await GetByCardAsync(card, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Card（字段） 查询
		/// </summary>
		/// /// <param name = "card">卡牌点数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Dwp_bet_detailEO> GetByCard(int card, int top_)
		{
			return GetByCard(card, top_, string.Empty, null);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByCardAsync(int card, int top_)
		{
			return await GetByCardAsync(card, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Card（字段） 查询
		/// </summary>
		/// /// <param name = "card">卡牌点数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Dwp_bet_detailEO> GetByCard(int card, int top_, TransactionManager tm_)
		{
			return GetByCard(card, top_, string.Empty, tm_);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByCardAsync(int card, int top_, TransactionManager tm_)
		{
			return await GetByCardAsync(card, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Card（字段） 查询
		/// </summary>
		/// /// <param name = "card">卡牌点数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Dwp_bet_detailEO> GetByCard(int card, string sort_)
		{
			return GetByCard(card, 0, sort_, null);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByCardAsync(int card, string sort_)
		{
			return await GetByCardAsync(card, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Card（字段） 查询
		/// </summary>
		/// /// <param name = "card">卡牌点数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Dwp_bet_detailEO> GetByCard(int card, string sort_, TransactionManager tm_)
		{
			return GetByCard(card, 0, sort_, tm_);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByCardAsync(int card, string sort_, TransactionManager tm_)
		{
			return await GetByCardAsync(card, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Card（字段） 查询
		/// </summary>
		/// /// <param name = "card">卡牌点数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Dwp_bet_detailEO> GetByCard(int card, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Card` = @Card", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Card", card, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Dwp_bet_detailEO.MapDataReader);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByCardAsync(int card, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Card` = @Card", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Card", card, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Dwp_bet_detailEO.MapDataReader);
		}
		#endregion // GetByCard
		#region GetByRoundIdx
		
		/// <summary>
		/// 按 RoundIdx（字段） 查询
		/// </summary>
		/// /// <param name = "roundIdx">回合数，总翻拍次数</param>
		/// <return>实体对象集合</return>
		public List<Dwp_bet_detailEO> GetByRoundIdx(int roundIdx)
		{
			return GetByRoundIdx(roundIdx, 0, string.Empty, null);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByRoundIdxAsync(int roundIdx)
		{
			return await GetByRoundIdxAsync(roundIdx, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RoundIdx（字段） 查询
		/// </summary>
		/// /// <param name = "roundIdx">回合数，总翻拍次数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Dwp_bet_detailEO> GetByRoundIdx(int roundIdx, TransactionManager tm_)
		{
			return GetByRoundIdx(roundIdx, 0, string.Empty, tm_);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByRoundIdxAsync(int roundIdx, TransactionManager tm_)
		{
			return await GetByRoundIdxAsync(roundIdx, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RoundIdx（字段） 查询
		/// </summary>
		/// /// <param name = "roundIdx">回合数，总翻拍次数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Dwp_bet_detailEO> GetByRoundIdx(int roundIdx, int top_)
		{
			return GetByRoundIdx(roundIdx, top_, string.Empty, null);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByRoundIdxAsync(int roundIdx, int top_)
		{
			return await GetByRoundIdxAsync(roundIdx, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RoundIdx（字段） 查询
		/// </summary>
		/// /// <param name = "roundIdx">回合数，总翻拍次数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Dwp_bet_detailEO> GetByRoundIdx(int roundIdx, int top_, TransactionManager tm_)
		{
			return GetByRoundIdx(roundIdx, top_, string.Empty, tm_);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByRoundIdxAsync(int roundIdx, int top_, TransactionManager tm_)
		{
			return await GetByRoundIdxAsync(roundIdx, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RoundIdx（字段） 查询
		/// </summary>
		/// /// <param name = "roundIdx">回合数，总翻拍次数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Dwp_bet_detailEO> GetByRoundIdx(int roundIdx, string sort_)
		{
			return GetByRoundIdx(roundIdx, 0, sort_, null);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByRoundIdxAsync(int roundIdx, string sort_)
		{
			return await GetByRoundIdxAsync(roundIdx, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 RoundIdx（字段） 查询
		/// </summary>
		/// /// <param name = "roundIdx">回合数，总翻拍次数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Dwp_bet_detailEO> GetByRoundIdx(int roundIdx, string sort_, TransactionManager tm_)
		{
			return GetByRoundIdx(roundIdx, 0, sort_, tm_);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByRoundIdxAsync(int roundIdx, string sort_, TransactionManager tm_)
		{
			return await GetByRoundIdxAsync(roundIdx, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 RoundIdx（字段） 查询
		/// </summary>
		/// /// <param name = "roundIdx">回合数，总翻拍次数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Dwp_bet_detailEO> GetByRoundIdx(int roundIdx, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RoundIdx` = @RoundIdx", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RoundIdx", roundIdx, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Dwp_bet_detailEO.MapDataReader);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByRoundIdxAsync(int roundIdx, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RoundIdx` = @RoundIdx", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RoundIdx", roundIdx, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Dwp_bet_detailEO.MapDataReader);
		}
		#endregion // GetByRoundIdx
		#region GetByJPTotalValue
		
		/// <summary>
		/// 按 JPTotalValue（字段） 查询
		/// </summary>
		/// /// <param name = "jPTotalValue">JP累计值</param>
		/// <return>实体对象集合</return>
		public List<Dwp_bet_detailEO> GetByJPTotalValue(int jPTotalValue)
		{
			return GetByJPTotalValue(jPTotalValue, 0, string.Empty, null);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByJPTotalValueAsync(int jPTotalValue)
		{
			return await GetByJPTotalValueAsync(jPTotalValue, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 JPTotalValue（字段） 查询
		/// </summary>
		/// /// <param name = "jPTotalValue">JP累计值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Dwp_bet_detailEO> GetByJPTotalValue(int jPTotalValue, TransactionManager tm_)
		{
			return GetByJPTotalValue(jPTotalValue, 0, string.Empty, tm_);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByJPTotalValueAsync(int jPTotalValue, TransactionManager tm_)
		{
			return await GetByJPTotalValueAsync(jPTotalValue, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 JPTotalValue（字段） 查询
		/// </summary>
		/// /// <param name = "jPTotalValue">JP累计值</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Dwp_bet_detailEO> GetByJPTotalValue(int jPTotalValue, int top_)
		{
			return GetByJPTotalValue(jPTotalValue, top_, string.Empty, null);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByJPTotalValueAsync(int jPTotalValue, int top_)
		{
			return await GetByJPTotalValueAsync(jPTotalValue, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 JPTotalValue（字段） 查询
		/// </summary>
		/// /// <param name = "jPTotalValue">JP累计值</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Dwp_bet_detailEO> GetByJPTotalValue(int jPTotalValue, int top_, TransactionManager tm_)
		{
			return GetByJPTotalValue(jPTotalValue, top_, string.Empty, tm_);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByJPTotalValueAsync(int jPTotalValue, int top_, TransactionManager tm_)
		{
			return await GetByJPTotalValueAsync(jPTotalValue, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 JPTotalValue（字段） 查询
		/// </summary>
		/// /// <param name = "jPTotalValue">JP累计值</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Dwp_bet_detailEO> GetByJPTotalValue(int jPTotalValue, string sort_)
		{
			return GetByJPTotalValue(jPTotalValue, 0, sort_, null);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByJPTotalValueAsync(int jPTotalValue, string sort_)
		{
			return await GetByJPTotalValueAsync(jPTotalValue, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 JPTotalValue（字段） 查询
		/// </summary>
		/// /// <param name = "jPTotalValue">JP累计值</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Dwp_bet_detailEO> GetByJPTotalValue(int jPTotalValue, string sort_, TransactionManager tm_)
		{
			return GetByJPTotalValue(jPTotalValue, 0, sort_, tm_);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByJPTotalValueAsync(int jPTotalValue, string sort_, TransactionManager tm_)
		{
			return await GetByJPTotalValueAsync(jPTotalValue, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 JPTotalValue（字段） 查询
		/// </summary>
		/// /// <param name = "jPTotalValue">JP累计值</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Dwp_bet_detailEO> GetByJPTotalValue(int jPTotalValue, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`JPTotalValue` = @JPTotalValue", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@JPTotalValue", jPTotalValue, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Dwp_bet_detailEO.MapDataReader);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByJPTotalValueAsync(int jPTotalValue, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`JPTotalValue` = @JPTotalValue", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@JPTotalValue", jPTotalValue, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Dwp_bet_detailEO.MapDataReader);
		}
		#endregion // GetByJPTotalValue
		#region GetByIsTriggerJP
		
		/// <summary>
		/// 按 IsTriggerJP（字段） 查询
		/// </summary>
		/// /// <param name = "isTriggerJP">是否触发JP大奖（触发不一定中）</param>
		/// <return>实体对象集合</return>
		public List<Dwp_bet_detailEO> GetByIsTriggerJP(bool isTriggerJP)
		{
			return GetByIsTriggerJP(isTriggerJP, 0, string.Empty, null);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByIsTriggerJPAsync(bool isTriggerJP)
		{
			return await GetByIsTriggerJPAsync(isTriggerJP, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 IsTriggerJP（字段） 查询
		/// </summary>
		/// /// <param name = "isTriggerJP">是否触发JP大奖（触发不一定中）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Dwp_bet_detailEO> GetByIsTriggerJP(bool isTriggerJP, TransactionManager tm_)
		{
			return GetByIsTriggerJP(isTriggerJP, 0, string.Empty, tm_);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByIsTriggerJPAsync(bool isTriggerJP, TransactionManager tm_)
		{
			return await GetByIsTriggerJPAsync(isTriggerJP, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IsTriggerJP（字段） 查询
		/// </summary>
		/// /// <param name = "isTriggerJP">是否触发JP大奖（触发不一定中）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Dwp_bet_detailEO> GetByIsTriggerJP(bool isTriggerJP, int top_)
		{
			return GetByIsTriggerJP(isTriggerJP, top_, string.Empty, null);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByIsTriggerJPAsync(bool isTriggerJP, int top_)
		{
			return await GetByIsTriggerJPAsync(isTriggerJP, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 IsTriggerJP（字段） 查询
		/// </summary>
		/// /// <param name = "isTriggerJP">是否触发JP大奖（触发不一定中）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Dwp_bet_detailEO> GetByIsTriggerJP(bool isTriggerJP, int top_, TransactionManager tm_)
		{
			return GetByIsTriggerJP(isTriggerJP, top_, string.Empty, tm_);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByIsTriggerJPAsync(bool isTriggerJP, int top_, TransactionManager tm_)
		{
			return await GetByIsTriggerJPAsync(isTriggerJP, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IsTriggerJP（字段） 查询
		/// </summary>
		/// /// <param name = "isTriggerJP">是否触发JP大奖（触发不一定中）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Dwp_bet_detailEO> GetByIsTriggerJP(bool isTriggerJP, string sort_)
		{
			return GetByIsTriggerJP(isTriggerJP, 0, sort_, null);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByIsTriggerJPAsync(bool isTriggerJP, string sort_)
		{
			return await GetByIsTriggerJPAsync(isTriggerJP, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 IsTriggerJP（字段） 查询
		/// </summary>
		/// /// <param name = "isTriggerJP">是否触发JP大奖（触发不一定中）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Dwp_bet_detailEO> GetByIsTriggerJP(bool isTriggerJP, string sort_, TransactionManager tm_)
		{
			return GetByIsTriggerJP(isTriggerJP, 0, sort_, tm_);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByIsTriggerJPAsync(bool isTriggerJP, string sort_, TransactionManager tm_)
		{
			return await GetByIsTriggerJPAsync(isTriggerJP, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 IsTriggerJP（字段） 查询
		/// </summary>
		/// /// <param name = "isTriggerJP">是否触发JP大奖（触发不一定中）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Dwp_bet_detailEO> GetByIsTriggerJP(bool isTriggerJP, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`IsTriggerJP` = @IsTriggerJP", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IsTriggerJP", isTriggerJP, MySqlDbType.Byte));
			return Database.ExecSqlList(sql_, paras_, tm_, Dwp_bet_detailEO.MapDataReader);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByIsTriggerJPAsync(bool isTriggerJP, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`IsTriggerJP` = @IsTriggerJP", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IsTriggerJP", isTriggerJP, MySqlDbType.Byte));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Dwp_bet_detailEO.MapDataReader);
		}
		#endregion // GetByIsTriggerJP
		#region GetByJPRewardIndex
		
		/// <summary>
		/// 按 JPRewardIndex（字段） 查询
		/// </summary>
		/// /// <param name = "jPRewardIndex">JP ID</param>
		/// <return>实体对象集合</return>
		public List<Dwp_bet_detailEO> GetByJPRewardIndex(int jPRewardIndex)
		{
			return GetByJPRewardIndex(jPRewardIndex, 0, string.Empty, null);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByJPRewardIndexAsync(int jPRewardIndex)
		{
			return await GetByJPRewardIndexAsync(jPRewardIndex, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 JPRewardIndex（字段） 查询
		/// </summary>
		/// /// <param name = "jPRewardIndex">JP ID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Dwp_bet_detailEO> GetByJPRewardIndex(int jPRewardIndex, TransactionManager tm_)
		{
			return GetByJPRewardIndex(jPRewardIndex, 0, string.Empty, tm_);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByJPRewardIndexAsync(int jPRewardIndex, TransactionManager tm_)
		{
			return await GetByJPRewardIndexAsync(jPRewardIndex, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 JPRewardIndex（字段） 查询
		/// </summary>
		/// /// <param name = "jPRewardIndex">JP ID</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Dwp_bet_detailEO> GetByJPRewardIndex(int jPRewardIndex, int top_)
		{
			return GetByJPRewardIndex(jPRewardIndex, top_, string.Empty, null);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByJPRewardIndexAsync(int jPRewardIndex, int top_)
		{
			return await GetByJPRewardIndexAsync(jPRewardIndex, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 JPRewardIndex（字段） 查询
		/// </summary>
		/// /// <param name = "jPRewardIndex">JP ID</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Dwp_bet_detailEO> GetByJPRewardIndex(int jPRewardIndex, int top_, TransactionManager tm_)
		{
			return GetByJPRewardIndex(jPRewardIndex, top_, string.Empty, tm_);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByJPRewardIndexAsync(int jPRewardIndex, int top_, TransactionManager tm_)
		{
			return await GetByJPRewardIndexAsync(jPRewardIndex, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 JPRewardIndex（字段） 查询
		/// </summary>
		/// /// <param name = "jPRewardIndex">JP ID</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Dwp_bet_detailEO> GetByJPRewardIndex(int jPRewardIndex, string sort_)
		{
			return GetByJPRewardIndex(jPRewardIndex, 0, sort_, null);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByJPRewardIndexAsync(int jPRewardIndex, string sort_)
		{
			return await GetByJPRewardIndexAsync(jPRewardIndex, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 JPRewardIndex（字段） 查询
		/// </summary>
		/// /// <param name = "jPRewardIndex">JP ID</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Dwp_bet_detailEO> GetByJPRewardIndex(int jPRewardIndex, string sort_, TransactionManager tm_)
		{
			return GetByJPRewardIndex(jPRewardIndex, 0, sort_, tm_);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByJPRewardIndexAsync(int jPRewardIndex, string sort_, TransactionManager tm_)
		{
			return await GetByJPRewardIndexAsync(jPRewardIndex, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 JPRewardIndex（字段） 查询
		/// </summary>
		/// /// <param name = "jPRewardIndex">JP ID</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Dwp_bet_detailEO> GetByJPRewardIndex(int jPRewardIndex, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`JPRewardIndex` = @JPRewardIndex", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@JPRewardIndex", jPRewardIndex, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Dwp_bet_detailEO.MapDataReader);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByJPRewardIndexAsync(int jPRewardIndex, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`JPRewardIndex` = @JPRewardIndex", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@JPRewardIndex", jPRewardIndex, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Dwp_bet_detailEO.MapDataReader);
		}
		#endregion // GetByJPRewardIndex
		#region GetByJPRewardValue
		
		/// <summary>
		/// 按 JPRewardValue（字段） 查询
		/// </summary>
		/// /// <param name = "jPRewardValue">JP 金额</param>
		/// <return>实体对象集合</return>
		public List<Dwp_bet_detailEO> GetByJPRewardValue(long jPRewardValue)
		{
			return GetByJPRewardValue(jPRewardValue, 0, string.Empty, null);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByJPRewardValueAsync(long jPRewardValue)
		{
			return await GetByJPRewardValueAsync(jPRewardValue, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 JPRewardValue（字段） 查询
		/// </summary>
		/// /// <param name = "jPRewardValue">JP 金额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Dwp_bet_detailEO> GetByJPRewardValue(long jPRewardValue, TransactionManager tm_)
		{
			return GetByJPRewardValue(jPRewardValue, 0, string.Empty, tm_);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByJPRewardValueAsync(long jPRewardValue, TransactionManager tm_)
		{
			return await GetByJPRewardValueAsync(jPRewardValue, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 JPRewardValue（字段） 查询
		/// </summary>
		/// /// <param name = "jPRewardValue">JP 金额</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Dwp_bet_detailEO> GetByJPRewardValue(long jPRewardValue, int top_)
		{
			return GetByJPRewardValue(jPRewardValue, top_, string.Empty, null);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByJPRewardValueAsync(long jPRewardValue, int top_)
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
		public List<Dwp_bet_detailEO> GetByJPRewardValue(long jPRewardValue, int top_, TransactionManager tm_)
		{
			return GetByJPRewardValue(jPRewardValue, top_, string.Empty, tm_);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByJPRewardValueAsync(long jPRewardValue, int top_, TransactionManager tm_)
		{
			return await GetByJPRewardValueAsync(jPRewardValue, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 JPRewardValue（字段） 查询
		/// </summary>
		/// /// <param name = "jPRewardValue">JP 金额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Dwp_bet_detailEO> GetByJPRewardValue(long jPRewardValue, string sort_)
		{
			return GetByJPRewardValue(jPRewardValue, 0, sort_, null);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByJPRewardValueAsync(long jPRewardValue, string sort_)
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
		public List<Dwp_bet_detailEO> GetByJPRewardValue(long jPRewardValue, string sort_, TransactionManager tm_)
		{
			return GetByJPRewardValue(jPRewardValue, 0, sort_, tm_);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByJPRewardValueAsync(long jPRewardValue, string sort_, TransactionManager tm_)
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
		public List<Dwp_bet_detailEO> GetByJPRewardValue(long jPRewardValue, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`JPRewardValue` = @JPRewardValue", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@JPRewardValue", jPRewardValue, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Dwp_bet_detailEO.MapDataReader);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByJPRewardValueAsync(long jPRewardValue, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`JPRewardValue` = @JPRewardValue", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@JPRewardValue", jPRewardValue, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Dwp_bet_detailEO.MapDataReader);
		}
		#endregion // GetByJPRewardValue
		#region GetByGameStatus
		
		/// <summary>
		/// 按 GameStatus（字段） 查询
		/// </summary>
		/// /// <param name = "gameStatus">roundIdx>0时，需要判断4种状态，1-star达到最大，2-betResult达到maxBet，3-balance小于baseBet，4-balance</param>
		/// <return>实体对象集合</return>
		public List<Dwp_bet_detailEO> GetByGameStatus(int gameStatus)
		{
			return GetByGameStatus(gameStatus, 0, string.Empty, null);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByGameStatusAsync(int gameStatus)
		{
			return await GetByGameStatusAsync(gameStatus, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 GameStatus（字段） 查询
		/// </summary>
		/// /// <param name = "gameStatus">roundIdx>0时，需要判断4种状态，1-star达到最大，2-betResult达到maxBet，3-balance小于baseBet，4-balance</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Dwp_bet_detailEO> GetByGameStatus(int gameStatus, TransactionManager tm_)
		{
			return GetByGameStatus(gameStatus, 0, string.Empty, tm_);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByGameStatusAsync(int gameStatus, TransactionManager tm_)
		{
			return await GetByGameStatusAsync(gameStatus, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 GameStatus（字段） 查询
		/// </summary>
		/// /// <param name = "gameStatus">roundIdx>0时，需要判断4种状态，1-star达到最大，2-betResult达到maxBet，3-balance小于baseBet，4-balance</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Dwp_bet_detailEO> GetByGameStatus(int gameStatus, int top_)
		{
			return GetByGameStatus(gameStatus, top_, string.Empty, null);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByGameStatusAsync(int gameStatus, int top_)
		{
			return await GetByGameStatusAsync(gameStatus, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 GameStatus（字段） 查询
		/// </summary>
		/// /// <param name = "gameStatus">roundIdx>0时，需要判断4种状态，1-star达到最大，2-betResult达到maxBet，3-balance小于baseBet，4-balance</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Dwp_bet_detailEO> GetByGameStatus(int gameStatus, int top_, TransactionManager tm_)
		{
			return GetByGameStatus(gameStatus, top_, string.Empty, tm_);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByGameStatusAsync(int gameStatus, int top_, TransactionManager tm_)
		{
			return await GetByGameStatusAsync(gameStatus, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 GameStatus（字段） 查询
		/// </summary>
		/// /// <param name = "gameStatus">roundIdx>0时，需要判断4种状态，1-star达到最大，2-betResult达到maxBet，3-balance小于baseBet，4-balance</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Dwp_bet_detailEO> GetByGameStatus(int gameStatus, string sort_)
		{
			return GetByGameStatus(gameStatus, 0, sort_, null);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByGameStatusAsync(int gameStatus, string sort_)
		{
			return await GetByGameStatusAsync(gameStatus, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 GameStatus（字段） 查询
		/// </summary>
		/// /// <param name = "gameStatus">roundIdx>0时，需要判断4种状态，1-star达到最大，2-betResult达到maxBet，3-balance小于baseBet，4-balance</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Dwp_bet_detailEO> GetByGameStatus(int gameStatus, string sort_, TransactionManager tm_)
		{
			return GetByGameStatus(gameStatus, 0, sort_, tm_);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByGameStatusAsync(int gameStatus, string sort_, TransactionManager tm_)
		{
			return await GetByGameStatusAsync(gameStatus, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 GameStatus（字段） 查询
		/// </summary>
		/// /// <param name = "gameStatus">roundIdx>0时，需要判断4种状态，1-star达到最大，2-betResult达到maxBet，3-balance小于baseBet，4-balance</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Dwp_bet_detailEO> GetByGameStatus(int gameStatus, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`GameStatus` = @GameStatus", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@GameStatus", gameStatus, MySqlDbType.Byte));
			return Database.ExecSqlList(sql_, paras_, tm_, Dwp_bet_detailEO.MapDataReader);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByGameStatusAsync(int gameStatus, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`GameStatus` = @GameStatus", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@GameStatus", gameStatus, MySqlDbType.Byte));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Dwp_bet_detailEO.MapDataReader);
		}
		#endregion // GetByGameStatus
		#region GetByOrderStatus
		
		/// <summary>
		/// 按 OrderStatus（字段） 查询
		/// </summary>
		/// /// <param name = "orderStatus">状态0-初始1-处理中2-成功3-失败4-已回滚5-异常且需处理6-异常已处理</param>
		/// <return>实体对象集合</return>
		public List<Dwp_bet_detailEO> GetByOrderStatus(int orderStatus)
		{
			return GetByOrderStatus(orderStatus, 0, string.Empty, null);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByOrderStatusAsync(int orderStatus)
		{
			return await GetByOrderStatusAsync(orderStatus, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OrderStatus（字段） 查询
		/// </summary>
		/// /// <param name = "orderStatus">状态0-初始1-处理中2-成功3-失败4-已回滚5-异常且需处理6-异常已处理</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Dwp_bet_detailEO> GetByOrderStatus(int orderStatus, TransactionManager tm_)
		{
			return GetByOrderStatus(orderStatus, 0, string.Empty, tm_);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByOrderStatusAsync(int orderStatus, TransactionManager tm_)
		{
			return await GetByOrderStatusAsync(orderStatus, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OrderStatus（字段） 查询
		/// </summary>
		/// /// <param name = "orderStatus">状态0-初始1-处理中2-成功3-失败4-已回滚5-异常且需处理6-异常已处理</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Dwp_bet_detailEO> GetByOrderStatus(int orderStatus, int top_)
		{
			return GetByOrderStatus(orderStatus, top_, string.Empty, null);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByOrderStatusAsync(int orderStatus, int top_)
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
		public List<Dwp_bet_detailEO> GetByOrderStatus(int orderStatus, int top_, TransactionManager tm_)
		{
			return GetByOrderStatus(orderStatus, top_, string.Empty, tm_);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByOrderStatusAsync(int orderStatus, int top_, TransactionManager tm_)
		{
			return await GetByOrderStatusAsync(orderStatus, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OrderStatus（字段） 查询
		/// </summary>
		/// /// <param name = "orderStatus">状态0-初始1-处理中2-成功3-失败4-已回滚5-异常且需处理6-异常已处理</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Dwp_bet_detailEO> GetByOrderStatus(int orderStatus, string sort_)
		{
			return GetByOrderStatus(orderStatus, 0, sort_, null);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByOrderStatusAsync(int orderStatus, string sort_)
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
		public List<Dwp_bet_detailEO> GetByOrderStatus(int orderStatus, string sort_, TransactionManager tm_)
		{
			return GetByOrderStatus(orderStatus, 0, sort_, tm_);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByOrderStatusAsync(int orderStatus, string sort_, TransactionManager tm_)
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
		public List<Dwp_bet_detailEO> GetByOrderStatus(int orderStatus, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OrderStatus` = @OrderStatus", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OrderStatus", orderStatus, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Dwp_bet_detailEO.MapDataReader);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByOrderStatusAsync(int orderStatus, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OrderStatus` = @OrderStatus", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OrderStatus", orderStatus, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Dwp_bet_detailEO.MapDataReader);
		}
		#endregion // GetByOrderStatus
		#region GetByHistory
		
		/// <summary>
		/// 按 History（字段） 查询
		/// </summary>
		/// /// <param name = "history">每回合历史记录</param>
		/// <return>实体对象集合</return>
		public List<Dwp_bet_detailEO> GetByHistory(string history)
		{
			return GetByHistory(history, 0, string.Empty, null);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByHistoryAsync(string history)
		{
			return await GetByHistoryAsync(history, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 History（字段） 查询
		/// </summary>
		/// /// <param name = "history">每回合历史记录</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Dwp_bet_detailEO> GetByHistory(string history, TransactionManager tm_)
		{
			return GetByHistory(history, 0, string.Empty, tm_);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByHistoryAsync(string history, TransactionManager tm_)
		{
			return await GetByHistoryAsync(history, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 History（字段） 查询
		/// </summary>
		/// /// <param name = "history">每回合历史记录</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Dwp_bet_detailEO> GetByHistory(string history, int top_)
		{
			return GetByHistory(history, top_, string.Empty, null);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByHistoryAsync(string history, int top_)
		{
			return await GetByHistoryAsync(history, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 History（字段） 查询
		/// </summary>
		/// /// <param name = "history">每回合历史记录</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Dwp_bet_detailEO> GetByHistory(string history, int top_, TransactionManager tm_)
		{
			return GetByHistory(history, top_, string.Empty, tm_);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByHistoryAsync(string history, int top_, TransactionManager tm_)
		{
			return await GetByHistoryAsync(history, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 History（字段） 查询
		/// </summary>
		/// /// <param name = "history">每回合历史记录</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Dwp_bet_detailEO> GetByHistory(string history, string sort_)
		{
			return GetByHistory(history, 0, sort_, null);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByHistoryAsync(string history, string sort_)
		{
			return await GetByHistoryAsync(history, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 History（字段） 查询
		/// </summary>
		/// /// <param name = "history">每回合历史记录</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Dwp_bet_detailEO> GetByHistory(string history, string sort_, TransactionManager tm_)
		{
			return GetByHistory(history, 0, sort_, tm_);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByHistoryAsync(string history, string sort_, TransactionManager tm_)
		{
			return await GetByHistoryAsync(history, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 History（字段） 查询
		/// </summary>
		/// /// <param name = "history">每回合历史记录</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Dwp_bet_detailEO> GetByHistory(string history, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`History` = @History", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@History", history, MySqlDbType.Text));
			return Database.ExecSqlList(sql_, paras_, tm_, Dwp_bet_detailEO.MapDataReader);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByHistoryAsync(string history, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`History` = @History", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@History", history, MySqlDbType.Text));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Dwp_bet_detailEO.MapDataReader);
		}
		#endregion // GetByHistory
		#region GetByRecDate
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <return>实体对象集合</return>
		public List<Dwp_bet_detailEO> GetByRecDate(DateTime? recDate)
		{
			return GetByRecDate(recDate, 0, string.Empty, null);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByRecDateAsync(DateTime? recDate)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Dwp_bet_detailEO> GetByRecDate(DateTime? recDate, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, string.Empty, tm_);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByRecDateAsync(DateTime? recDate, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Dwp_bet_detailEO> GetByRecDate(DateTime? recDate, int top_)
		{
			return GetByRecDate(recDate, top_, string.Empty, null);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByRecDateAsync(DateTime? recDate, int top_)
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
		public List<Dwp_bet_detailEO> GetByRecDate(DateTime? recDate, int top_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, top_, string.Empty, tm_);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByRecDateAsync(DateTime? recDate, int top_, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">记录时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Dwp_bet_detailEO> GetByRecDate(DateTime? recDate, string sort_)
		{
			return GetByRecDate(recDate, 0, sort_, null);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByRecDateAsync(DateTime? recDate, string sort_)
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
		public List<Dwp_bet_detailEO> GetByRecDate(DateTime? recDate, string sort_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, sort_, tm_);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByRecDateAsync(DateTime? recDate, string sort_, TransactionManager tm_)
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
		public List<Dwp_bet_detailEO> GetByRecDate(DateTime? recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(recDate.HasValue ? "`RecDate` = @RecDate" : "`RecDate` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (recDate.HasValue)
				paras_.Add(Database.CreateInParameter("@RecDate", recDate.Value, MySqlDbType.DateTime));
			return Database.ExecSqlList(sql_, paras_, tm_, Dwp_bet_detailEO.MapDataReader);
		}
		public async Task<List<Dwp_bet_detailEO>> GetByRecDateAsync(DateTime? recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(recDate.HasValue ? "`RecDate` = @RecDate" : "`RecDate` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (recDate.HasValue)
				paras_.Add(Database.CreateInParameter("@RecDate", recDate.Value, MySqlDbType.DateTime));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Dwp_bet_detailEO.MapDataReader);
		}
		#endregion // GetByRecDate
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
