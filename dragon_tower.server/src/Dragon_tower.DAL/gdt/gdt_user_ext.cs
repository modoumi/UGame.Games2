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
	/// 用户扩展数据
	/// 【表 gdt_user_ext 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class Gdt_user_extEO : IRowMapper<Gdt_user_extEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public Gdt_user_extEO()
		{
			this.BetBaseAmount = 0;
			this.LevelId = 0;
			this.GameStatus = 0;
			this.LastRecDate = DateTime.Now;
		}
		#region 主键原始值 & 主键集合
	    
		/// <summary>
		/// 当前对象是否保存原始主键值，当修改了主键值时为 true
		/// </summary>
		public bool HasOriginal { get; protected set; }
		
		private string _originalUserID;
		/// <summary>
		/// 【数据库中的原始主键 UserID 值的副本，用于主键值更新】
		/// </summary>
		public string OriginalUserID
		{
			get { return _originalUserID; }
			set { HasOriginal = true; _originalUserID = value; }
		}
	    /// <summary>
	    /// 获取主键集合。key: 数据库字段名称, value: 主键值
	    /// </summary>
	    /// <returns></returns>
	    public Dictionary<string, object> GetPrimaryKeys()
	    {
	        return new Dictionary<string, object>() { { "UserID", UserID }, };
	    }
	    /// <summary>
	    /// 获取主键集合JSON格式
	    /// </summary>
	    /// <returns></returns>
	    public string GetPrimaryKeysJson() => SerializerUtil.SerializeJson(GetPrimaryKeys());
		#endregion // 主键原始值
		#region 所有字段
		/// <summary>
		/// 用户Id
		/// 【主键 varchar(38)】
		/// </summary>
		[DataMember(Order = 1)]
		public string UserID { get; set; }
		/// <summary>
		/// 初始下注额
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 2)]
		public long BetBaseAmount { get; set; }
		/// <summary>
		/// 总共赢的钱数
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 3)]
		public long WinAmount { get; set; }
		/// <summary>
		/// 选择的难度
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 4)]
		public int LevelId { get; set; }
		/// <summary>
		/// 爬到几层
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 5)]
		public int FloorNum { get; set; }
		/// <summary>
		/// 爬塔的信息
		/// 【字段 varchar(1000)】
		/// </summary>
		[DataMember(Order = 6)]
		public string FloorInfo { get; set; }
		/// <summary>
		/// 0-未开始,1-进行中, 2-已结束
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 7)]
		public int GameStatus { get; set; }
		/// <summary>
		/// 记录最后记录时间
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 8)]
		public DateTime? LastRecDate { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public Gdt_user_extEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static Gdt_user_extEO MapDataReader(IDataReader reader)
		{
		    Gdt_user_extEO ret = new Gdt_user_extEO();
			ret.UserID = reader.ToString("UserID");
			ret.OriginalUserID = ret.UserID;
			ret.BetBaseAmount = reader.ToInt64("BetBaseAmount");
			ret.WinAmount = reader.ToInt64("WinAmount");
			ret.LevelId = reader.ToInt32("LevelId");
			ret.FloorNum = reader.ToInt32("FloorNum");
			ret.FloorInfo = reader.ToString("FloorInfo");
			ret.GameStatus = reader.ToInt32("GameStatus");
			ret.LastRecDate = reader.ToDateTimeN("LastRecDate");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 用户扩展数据
	/// 【表 gdt_user_ext 的操作类】
	/// </summary>
	[Obsolete]
	public class Gdt_user_extMO : MySqlTableMO<Gdt_user_extEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`gdt_user_ext`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public Gdt_user_extMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public Gdt_user_extMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public Gdt_user_extMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(Gdt_user_extEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(Gdt_user_extEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(Gdt_user_extEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`UserID`, `BetBaseAmount`, `WinAmount`, `LevelId`, `FloorNum`, `FloorInfo`, `GameStatus`, `LastRecDate`) VALUE (@UserID, @BetBaseAmount, @WinAmount, @LevelId, @FloorNum, @FloorInfo, @GameStatus, @LastRecDate);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", item.UserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@BetBaseAmount", item.BetBaseAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@WinAmount", item.WinAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@LevelId", item.LevelId, MySqlDbType.Int32),
				Database.CreateInParameter("@FloorNum", item.FloorNum, MySqlDbType.Int32),
				Database.CreateInParameter("@FloorInfo", item.FloorInfo, MySqlDbType.VarChar),
				Database.CreateInParameter("@GameStatus", item.GameStatus, MySqlDbType.Int32),
				Database.CreateInParameter("@LastRecDate", item.LastRecDate.HasValue ? item.LastRecDate.Value : (object)DBNull.Value, MySqlDbType.DateTime),
			};
		}
		public int AddByBatch(IEnumerable<Gdt_user_extEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<Gdt_user_extEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<Gdt_user_extEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`UserID`, `BetBaseAmount`, `WinAmount`, `LevelId`, `FloorNum`, `FloorInfo`, `GameStatus`, `LastRecDate`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"('{item.UserID}',{item.BetBaseAmount},{item.WinAmount},{item.LevelId},{item.FloorNum},'{item.FloorInfo}',{item.GameStatus},'{item.LastRecDate?.ToString("yyyy-MM-dd HH:mm:ss")}'),");
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
		/// /// <param name = "userID">用户Id</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(string userID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(userID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(string userID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(userID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(string userID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(Gdt_user_extEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.UserID, tm_);
		}
		public async Task<int> RemoveAsync(Gdt_user_extEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.UserID, tm_);
		}
		#endregion // RemoveByPK
		
		#region RemoveByXXX
		#region RemoveByBetBaseAmount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "betBaseAmount">初始下注额</param>
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
		#region RemoveByWinAmount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "winAmount">总共赢的钱数</param>
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
		#region RemoveByLevelId
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "levelId">选择的难度</param>
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
		#region RemoveByFloorNum
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "floorNum">爬到几层</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByFloorNum(int floorNum, TransactionManager tm_ = null)
		{
			RepairRemoveByFloorNumData(floorNum, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByFloorNumAsync(int floorNum, TransactionManager tm_ = null)
		{
			RepairRemoveByFloorNumData(floorNum, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByFloorNumData(int floorNum, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `FloorNum` = @FloorNum";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FloorNum", floorNum, MySqlDbType.Int32));
		}
		#endregion // RemoveByFloorNum
		#region RemoveByFloorInfo
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "floorInfo">爬塔的信息</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByFloorInfo(string floorInfo, TransactionManager tm_ = null)
		{
			RepairRemoveByFloorInfoData(floorInfo, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByFloorInfoAsync(string floorInfo, TransactionManager tm_ = null)
		{
			RepairRemoveByFloorInfoData(floorInfo, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByFloorInfoData(string floorInfo, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `FloorInfo` = @FloorInfo";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FloorInfo", floorInfo, MySqlDbType.VarChar));
		}
		#endregion // RemoveByFloorInfo
		#region RemoveByGameStatus
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "gameStatus">0-未开始,1-进行中, 2-已结束</param>
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
			paras_.Add(Database.CreateInParameter("@GameStatus", gameStatus, MySqlDbType.Int32));
		}
		#endregion // RemoveByGameStatus
		#region RemoveByLastRecDate
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "lastRecDate">记录最后记录时间</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByLastRecDate(DateTime? lastRecDate, TransactionManager tm_ = null)
		{
			RepairRemoveByLastRecDateData(lastRecDate.Value, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByLastRecDateAsync(DateTime? lastRecDate, TransactionManager tm_ = null)
		{
			RepairRemoveByLastRecDateData(lastRecDate.Value, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByLastRecDateData(DateTime? lastRecDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (lastRecDate.HasValue ? "`LastRecDate` = @LastRecDate" : "`LastRecDate` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (lastRecDate.HasValue)
				paras_.Add(Database.CreateInParameter("@LastRecDate", lastRecDate.Value, MySqlDbType.DateTime));
		}
		#endregion // RemoveByLastRecDate
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
		public int Put(Gdt_user_extEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(Gdt_user_extEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(Gdt_user_extEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `UserID` = @UserID, `BetBaseAmount` = @BetBaseAmount, `WinAmount` = @WinAmount, `LevelId` = @LevelId, `FloorNum` = @FloorNum, `FloorInfo` = @FloorInfo, `GameStatus` = @GameStatus WHERE `UserID` = @UserID_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", item.UserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@BetBaseAmount", item.BetBaseAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@WinAmount", item.WinAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@LevelId", item.LevelId, MySqlDbType.Int32),
				Database.CreateInParameter("@FloorNum", item.FloorNum, MySqlDbType.Int32),
				Database.CreateInParameter("@FloorInfo", item.FloorInfo, MySqlDbType.VarChar),
				Database.CreateInParameter("@GameStatus", item.GameStatus, MySqlDbType.Int32),
				Database.CreateInParameter("@UserID_Original", item.HasOriginal ? item.OriginalUserID : item.UserID, MySqlDbType.VarChar),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<Gdt_user_extEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<Gdt_user_extEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "userID">用户Id</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string userID, string set_, params object[] values_)
		{
			return Put(set_, "`UserID` = @UserID", ConcatValues(values_, userID));
		}
		public async Task<int> PutByPKAsync(string userID, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`UserID` = @UserID", ConcatValues(values_, userID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "userID">用户Id</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string userID, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`UserID` = @UserID", tm_, ConcatValues(values_, userID));
		}
		public async Task<int> PutByPKAsync(string userID, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`UserID` = @UserID", tm_, ConcatValues(values_, userID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "userID">用户Id</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string userID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
	        };
			return Put(set_, "`UserID` = @UserID", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(string userID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
	        };
			return await PutAsync(set_, "`UserID` = @UserID", ConcatParameters(paras_, newParas_), tm_);
		}
		#endregion // PutByPK
		
		#region PutXXX
		#region PutBetBaseAmount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户Id</param>
		/// /// <param name = "betBaseAmount">初始下注额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBetBaseAmountByPK(string userID, long betBaseAmount, TransactionManager tm_ = null)
		{
			RepairPutBetBaseAmountByPKData(userID, betBaseAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutBetBaseAmountByPKAsync(string userID, long betBaseAmount, TransactionManager tm_ = null)
		{
			RepairPutBetBaseAmountByPKData(userID, betBaseAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutBetBaseAmountByPKData(string userID, long betBaseAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `BetBaseAmount` = @BetBaseAmount  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetBaseAmount", betBaseAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "betBaseAmount">初始下注额</param>
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
		#region PutWinAmount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户Id</param>
		/// /// <param name = "winAmount">总共赢的钱数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutWinAmountByPK(string userID, long winAmount, TransactionManager tm_ = null)
		{
			RepairPutWinAmountByPKData(userID, winAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutWinAmountByPKAsync(string userID, long winAmount, TransactionManager tm_ = null)
		{
			RepairPutWinAmountByPKData(userID, winAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutWinAmountByPKData(string userID, long winAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `WinAmount` = @WinAmount  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@WinAmount", winAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "winAmount">总共赢的钱数</param>
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
		#region PutLevelId
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户Id</param>
		/// /// <param name = "levelId">选择的难度</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutLevelIdByPK(string userID, int levelId, TransactionManager tm_ = null)
		{
			RepairPutLevelIdByPKData(userID, levelId, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutLevelIdByPKAsync(string userID, int levelId, TransactionManager tm_ = null)
		{
			RepairPutLevelIdByPKData(userID, levelId, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutLevelIdByPKData(string userID, int levelId, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `LevelId` = @LevelId  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LevelId", levelId, MySqlDbType.Int32),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "levelId">选择的难度</param>
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
		#region PutFloorNum
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户Id</param>
		/// /// <param name = "floorNum">爬到几层</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutFloorNumByPK(string userID, int floorNum, TransactionManager tm_ = null)
		{
			RepairPutFloorNumByPKData(userID, floorNum, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutFloorNumByPKAsync(string userID, int floorNum, TransactionManager tm_ = null)
		{
			RepairPutFloorNumByPKData(userID, floorNum, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutFloorNumByPKData(string userID, int floorNum, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `FloorNum` = @FloorNum  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@FloorNum", floorNum, MySqlDbType.Int32),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "floorNum">爬到几层</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutFloorNum(int floorNum, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `FloorNum` = @FloorNum";
			var parameter_ = Database.CreateInParameter("@FloorNum", floorNum, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutFloorNumAsync(int floorNum, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `FloorNum` = @FloorNum";
			var parameter_ = Database.CreateInParameter("@FloorNum", floorNum, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutFloorNum
		#region PutFloorInfo
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户Id</param>
		/// /// <param name = "floorInfo">爬塔的信息</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutFloorInfoByPK(string userID, string floorInfo, TransactionManager tm_ = null)
		{
			RepairPutFloorInfoByPKData(userID, floorInfo, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutFloorInfoByPKAsync(string userID, string floorInfo, TransactionManager tm_ = null)
		{
			RepairPutFloorInfoByPKData(userID, floorInfo, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutFloorInfoByPKData(string userID, string floorInfo, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `FloorInfo` = @FloorInfo  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@FloorInfo", floorInfo, MySqlDbType.VarChar),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "floorInfo">爬塔的信息</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutFloorInfo(string floorInfo, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `FloorInfo` = @FloorInfo";
			var parameter_ = Database.CreateInParameter("@FloorInfo", floorInfo, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutFloorInfoAsync(string floorInfo, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `FloorInfo` = @FloorInfo";
			var parameter_ = Database.CreateInParameter("@FloorInfo", floorInfo, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutFloorInfo
		#region PutGameStatus
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户Id</param>
		/// /// <param name = "gameStatus">0-未开始,1-进行中, 2-已结束</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutGameStatusByPK(string userID, int gameStatus, TransactionManager tm_ = null)
		{
			RepairPutGameStatusByPKData(userID, gameStatus, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutGameStatusByPKAsync(string userID, int gameStatus, TransactionManager tm_ = null)
		{
			RepairPutGameStatusByPKData(userID, gameStatus, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutGameStatusByPKData(string userID, int gameStatus, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `GameStatus` = @GameStatus  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@GameStatus", gameStatus, MySqlDbType.Int32),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "gameStatus">0-未开始,1-进行中, 2-已结束</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutGameStatus(int gameStatus, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `GameStatus` = @GameStatus";
			var parameter_ = Database.CreateInParameter("@GameStatus", gameStatus, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutGameStatusAsync(int gameStatus, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `GameStatus` = @GameStatus";
			var parameter_ = Database.CreateInParameter("@GameStatus", gameStatus, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutGameStatus
		#region PutLastRecDate
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户Id</param>
		/// /// <param name = "lastRecDate">记录最后记录时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutLastRecDateByPK(string userID, DateTime? lastRecDate, TransactionManager tm_ = null)
		{
			RepairPutLastRecDateByPKData(userID, lastRecDate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutLastRecDateByPKAsync(string userID, DateTime? lastRecDate, TransactionManager tm_ = null)
		{
			RepairPutLastRecDateByPKData(userID, lastRecDate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutLastRecDateByPKData(string userID, DateTime? lastRecDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `LastRecDate` = @LastRecDate  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LastRecDate", lastRecDate.HasValue ? lastRecDate.Value : (object)DBNull.Value, MySqlDbType.DateTime),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "lastRecDate">记录最后记录时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutLastRecDate(DateTime? lastRecDate, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `LastRecDate` = @LastRecDate";
			var parameter_ = Database.CreateInParameter("@LastRecDate", lastRecDate.HasValue ? lastRecDate.Value : (object)DBNull.Value, MySqlDbType.DateTime);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutLastRecDateAsync(DateTime? lastRecDate, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `LastRecDate` = @LastRecDate";
			var parameter_ = Database.CreateInParameter("@LastRecDate", lastRecDate.HasValue ? lastRecDate.Value : (object)DBNull.Value, MySqlDbType.DateTime);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutLastRecDate
		#endregion // PutXXX
		#endregion // Put
	   
		#region Set
		
		/// <summary>
		/// 插入或者更新数据
		/// </summary>
		/// <param name = "item">要更新的实体对象</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>true:插入操作；false:更新操作</return>
		public bool Set(Gdt_user_extEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.UserID) == null)
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
		public async Task<bool> SetAsync(Gdt_user_extEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.UserID) == null)
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
		/// /// <param name = "userID">用户Id</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public Gdt_user_extEO GetByPK(string userID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(userID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, Gdt_user_extEO.MapDataReader);
		}
		public async Task<Gdt_user_extEO> GetByPKAsync(string userID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(userID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Gdt_user_extEO.MapDataReader);
		}
		private void RepairGetByPKData(string userID, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`UserID` = @UserID", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
		#endregion // GetByPK
		
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 BetBaseAmount（字段）
		/// </summary>
		/// /// <param name = "userID">用户Id</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetBetBaseAmountByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`BetBaseAmount`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<long> GetBetBaseAmountByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`BetBaseAmount`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 WinAmount（字段）
		/// </summary>
		/// /// <param name = "userID">用户Id</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetWinAmountByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`WinAmount`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<long> GetWinAmountByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`WinAmount`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 LevelId（字段）
		/// </summary>
		/// /// <param name = "userID">用户Id</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetLevelIdByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`LevelId`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<int> GetLevelIdByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`LevelId`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 FloorNum（字段）
		/// </summary>
		/// /// <param name = "userID">用户Id</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetFloorNumByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`FloorNum`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<int> GetFloorNumByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`FloorNum`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 FloorInfo（字段）
		/// </summary>
		/// /// <param name = "userID">用户Id</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetFloorInfoByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`FloorInfo`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<string> GetFloorInfoByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`FloorInfo`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 GameStatus（字段）
		/// </summary>
		/// /// <param name = "userID">用户Id</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetGameStatusByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`GameStatus`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<int> GetGameStatusByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`GameStatus`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 LastRecDate（字段）
		/// </summary>
		/// /// <param name = "userID">用户Id</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime? GetLastRecDateByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (DateTime?)GetScalar("`LastRecDate`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<DateTime?> GetLastRecDateByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (DateTime?)await GetScalarAsync("`LastRecDate`", "`UserID` = @UserID", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByBetBaseAmount
		
		/// <summary>
		/// 按 BetBaseAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betBaseAmount">初始下注额</param>
		/// <return>实体对象集合</return>
		public List<Gdt_user_extEO> GetByBetBaseAmount(long betBaseAmount)
		{
			return GetByBetBaseAmount(betBaseAmount, 0, string.Empty, null);
		}
		public async Task<List<Gdt_user_extEO>> GetByBetBaseAmountAsync(long betBaseAmount)
		{
			return await GetByBetBaseAmountAsync(betBaseAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BetBaseAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betBaseAmount">初始下注额</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gdt_user_extEO> GetByBetBaseAmount(long betBaseAmount, TransactionManager tm_)
		{
			return GetByBetBaseAmount(betBaseAmount, 0, string.Empty, tm_);
		}
		public async Task<List<Gdt_user_extEO>> GetByBetBaseAmountAsync(long betBaseAmount, TransactionManager tm_)
		{
			return await GetByBetBaseAmountAsync(betBaseAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BetBaseAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betBaseAmount">初始下注额</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Gdt_user_extEO> GetByBetBaseAmount(long betBaseAmount, int top_)
		{
			return GetByBetBaseAmount(betBaseAmount, top_, string.Empty, null);
		}
		public async Task<List<Gdt_user_extEO>> GetByBetBaseAmountAsync(long betBaseAmount, int top_)
		{
			return await GetByBetBaseAmountAsync(betBaseAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BetBaseAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betBaseAmount">初始下注额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gdt_user_extEO> GetByBetBaseAmount(long betBaseAmount, int top_, TransactionManager tm_)
		{
			return GetByBetBaseAmount(betBaseAmount, top_, string.Empty, tm_);
		}
		public async Task<List<Gdt_user_extEO>> GetByBetBaseAmountAsync(long betBaseAmount, int top_, TransactionManager tm_)
		{
			return await GetByBetBaseAmountAsync(betBaseAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BetBaseAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betBaseAmount">初始下注额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Gdt_user_extEO> GetByBetBaseAmount(long betBaseAmount, string sort_)
		{
			return GetByBetBaseAmount(betBaseAmount, 0, sort_, null);
		}
		public async Task<List<Gdt_user_extEO>> GetByBetBaseAmountAsync(long betBaseAmount, string sort_)
		{
			return await GetByBetBaseAmountAsync(betBaseAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 BetBaseAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betBaseAmount">初始下注额</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gdt_user_extEO> GetByBetBaseAmount(long betBaseAmount, string sort_, TransactionManager tm_)
		{
			return GetByBetBaseAmount(betBaseAmount, 0, sort_, tm_);
		}
		public async Task<List<Gdt_user_extEO>> GetByBetBaseAmountAsync(long betBaseAmount, string sort_, TransactionManager tm_)
		{
			return await GetByBetBaseAmountAsync(betBaseAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 BetBaseAmount（字段） 查询
		/// </summary>
		/// /// <param name = "betBaseAmount">初始下注额</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gdt_user_extEO> GetByBetBaseAmount(long betBaseAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BetBaseAmount` = @BetBaseAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BetBaseAmount", betBaseAmount, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Gdt_user_extEO.MapDataReader);
		}
		public async Task<List<Gdt_user_extEO>> GetByBetBaseAmountAsync(long betBaseAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BetBaseAmount` = @BetBaseAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BetBaseAmount", betBaseAmount, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gdt_user_extEO.MapDataReader);
		}
		#endregion // GetByBetBaseAmount
		#region GetByWinAmount
		
		/// <summary>
		/// 按 WinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "winAmount">总共赢的钱数</param>
		/// <return>实体对象集合</return>
		public List<Gdt_user_extEO> GetByWinAmount(long winAmount)
		{
			return GetByWinAmount(winAmount, 0, string.Empty, null);
		}
		public async Task<List<Gdt_user_extEO>> GetByWinAmountAsync(long winAmount)
		{
			return await GetByWinAmountAsync(winAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 WinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "winAmount">总共赢的钱数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gdt_user_extEO> GetByWinAmount(long winAmount, TransactionManager tm_)
		{
			return GetByWinAmount(winAmount, 0, string.Empty, tm_);
		}
		public async Task<List<Gdt_user_extEO>> GetByWinAmountAsync(long winAmount, TransactionManager tm_)
		{
			return await GetByWinAmountAsync(winAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 WinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "winAmount">总共赢的钱数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Gdt_user_extEO> GetByWinAmount(long winAmount, int top_)
		{
			return GetByWinAmount(winAmount, top_, string.Empty, null);
		}
		public async Task<List<Gdt_user_extEO>> GetByWinAmountAsync(long winAmount, int top_)
		{
			return await GetByWinAmountAsync(winAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 WinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "winAmount">总共赢的钱数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gdt_user_extEO> GetByWinAmount(long winAmount, int top_, TransactionManager tm_)
		{
			return GetByWinAmount(winAmount, top_, string.Empty, tm_);
		}
		public async Task<List<Gdt_user_extEO>> GetByWinAmountAsync(long winAmount, int top_, TransactionManager tm_)
		{
			return await GetByWinAmountAsync(winAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 WinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "winAmount">总共赢的钱数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Gdt_user_extEO> GetByWinAmount(long winAmount, string sort_)
		{
			return GetByWinAmount(winAmount, 0, sort_, null);
		}
		public async Task<List<Gdt_user_extEO>> GetByWinAmountAsync(long winAmount, string sort_)
		{
			return await GetByWinAmountAsync(winAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 WinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "winAmount">总共赢的钱数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gdt_user_extEO> GetByWinAmount(long winAmount, string sort_, TransactionManager tm_)
		{
			return GetByWinAmount(winAmount, 0, sort_, tm_);
		}
		public async Task<List<Gdt_user_extEO>> GetByWinAmountAsync(long winAmount, string sort_, TransactionManager tm_)
		{
			return await GetByWinAmountAsync(winAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 WinAmount（字段） 查询
		/// </summary>
		/// /// <param name = "winAmount">总共赢的钱数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gdt_user_extEO> GetByWinAmount(long winAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`WinAmount` = @WinAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@WinAmount", winAmount, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Gdt_user_extEO.MapDataReader);
		}
		public async Task<List<Gdt_user_extEO>> GetByWinAmountAsync(long winAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`WinAmount` = @WinAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@WinAmount", winAmount, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gdt_user_extEO.MapDataReader);
		}
		#endregion // GetByWinAmount
		#region GetByLevelId
		
		/// <summary>
		/// 按 LevelId（字段） 查询
		/// </summary>
		/// /// <param name = "levelId">选择的难度</param>
		/// <return>实体对象集合</return>
		public List<Gdt_user_extEO> GetByLevelId(int levelId)
		{
			return GetByLevelId(levelId, 0, string.Empty, null);
		}
		public async Task<List<Gdt_user_extEO>> GetByLevelIdAsync(int levelId)
		{
			return await GetByLevelIdAsync(levelId, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LevelId（字段） 查询
		/// </summary>
		/// /// <param name = "levelId">选择的难度</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gdt_user_extEO> GetByLevelId(int levelId, TransactionManager tm_)
		{
			return GetByLevelId(levelId, 0, string.Empty, tm_);
		}
		public async Task<List<Gdt_user_extEO>> GetByLevelIdAsync(int levelId, TransactionManager tm_)
		{
			return await GetByLevelIdAsync(levelId, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LevelId（字段） 查询
		/// </summary>
		/// /// <param name = "levelId">选择的难度</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Gdt_user_extEO> GetByLevelId(int levelId, int top_)
		{
			return GetByLevelId(levelId, top_, string.Empty, null);
		}
		public async Task<List<Gdt_user_extEO>> GetByLevelIdAsync(int levelId, int top_)
		{
			return await GetByLevelIdAsync(levelId, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LevelId（字段） 查询
		/// </summary>
		/// /// <param name = "levelId">选择的难度</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gdt_user_extEO> GetByLevelId(int levelId, int top_, TransactionManager tm_)
		{
			return GetByLevelId(levelId, top_, string.Empty, tm_);
		}
		public async Task<List<Gdt_user_extEO>> GetByLevelIdAsync(int levelId, int top_, TransactionManager tm_)
		{
			return await GetByLevelIdAsync(levelId, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LevelId（字段） 查询
		/// </summary>
		/// /// <param name = "levelId">选择的难度</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Gdt_user_extEO> GetByLevelId(int levelId, string sort_)
		{
			return GetByLevelId(levelId, 0, sort_, null);
		}
		public async Task<List<Gdt_user_extEO>> GetByLevelIdAsync(int levelId, string sort_)
		{
			return await GetByLevelIdAsync(levelId, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 LevelId（字段） 查询
		/// </summary>
		/// /// <param name = "levelId">选择的难度</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gdt_user_extEO> GetByLevelId(int levelId, string sort_, TransactionManager tm_)
		{
			return GetByLevelId(levelId, 0, sort_, tm_);
		}
		public async Task<List<Gdt_user_extEO>> GetByLevelIdAsync(int levelId, string sort_, TransactionManager tm_)
		{
			return await GetByLevelIdAsync(levelId, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 LevelId（字段） 查询
		/// </summary>
		/// /// <param name = "levelId">选择的难度</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gdt_user_extEO> GetByLevelId(int levelId, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`LevelId` = @LevelId", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@LevelId", levelId, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Gdt_user_extEO.MapDataReader);
		}
		public async Task<List<Gdt_user_extEO>> GetByLevelIdAsync(int levelId, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`LevelId` = @LevelId", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@LevelId", levelId, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gdt_user_extEO.MapDataReader);
		}
		#endregion // GetByLevelId
		#region GetByFloorNum
		
		/// <summary>
		/// 按 FloorNum（字段） 查询
		/// </summary>
		/// /// <param name = "floorNum">爬到几层</param>
		/// <return>实体对象集合</return>
		public List<Gdt_user_extEO> GetByFloorNum(int floorNum)
		{
			return GetByFloorNum(floorNum, 0, string.Empty, null);
		}
		public async Task<List<Gdt_user_extEO>> GetByFloorNumAsync(int floorNum)
		{
			return await GetByFloorNumAsync(floorNum, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 FloorNum（字段） 查询
		/// </summary>
		/// /// <param name = "floorNum">爬到几层</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gdt_user_extEO> GetByFloorNum(int floorNum, TransactionManager tm_)
		{
			return GetByFloorNum(floorNum, 0, string.Empty, tm_);
		}
		public async Task<List<Gdt_user_extEO>> GetByFloorNumAsync(int floorNum, TransactionManager tm_)
		{
			return await GetByFloorNumAsync(floorNum, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FloorNum（字段） 查询
		/// </summary>
		/// /// <param name = "floorNum">爬到几层</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Gdt_user_extEO> GetByFloorNum(int floorNum, int top_)
		{
			return GetByFloorNum(floorNum, top_, string.Empty, null);
		}
		public async Task<List<Gdt_user_extEO>> GetByFloorNumAsync(int floorNum, int top_)
		{
			return await GetByFloorNumAsync(floorNum, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 FloorNum（字段） 查询
		/// </summary>
		/// /// <param name = "floorNum">爬到几层</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gdt_user_extEO> GetByFloorNum(int floorNum, int top_, TransactionManager tm_)
		{
			return GetByFloorNum(floorNum, top_, string.Empty, tm_);
		}
		public async Task<List<Gdt_user_extEO>> GetByFloorNumAsync(int floorNum, int top_, TransactionManager tm_)
		{
			return await GetByFloorNumAsync(floorNum, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FloorNum（字段） 查询
		/// </summary>
		/// /// <param name = "floorNum">爬到几层</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Gdt_user_extEO> GetByFloorNum(int floorNum, string sort_)
		{
			return GetByFloorNum(floorNum, 0, sort_, null);
		}
		public async Task<List<Gdt_user_extEO>> GetByFloorNumAsync(int floorNum, string sort_)
		{
			return await GetByFloorNumAsync(floorNum, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 FloorNum（字段） 查询
		/// </summary>
		/// /// <param name = "floorNum">爬到几层</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gdt_user_extEO> GetByFloorNum(int floorNum, string sort_, TransactionManager tm_)
		{
			return GetByFloorNum(floorNum, 0, sort_, tm_);
		}
		public async Task<List<Gdt_user_extEO>> GetByFloorNumAsync(int floorNum, string sort_, TransactionManager tm_)
		{
			return await GetByFloorNumAsync(floorNum, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 FloorNum（字段） 查询
		/// </summary>
		/// /// <param name = "floorNum">爬到几层</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gdt_user_extEO> GetByFloorNum(int floorNum, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`FloorNum` = @FloorNum", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FloorNum", floorNum, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Gdt_user_extEO.MapDataReader);
		}
		public async Task<List<Gdt_user_extEO>> GetByFloorNumAsync(int floorNum, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`FloorNum` = @FloorNum", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FloorNum", floorNum, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gdt_user_extEO.MapDataReader);
		}
		#endregion // GetByFloorNum
		#region GetByFloorInfo
		
		/// <summary>
		/// 按 FloorInfo（字段） 查询
		/// </summary>
		/// /// <param name = "floorInfo">爬塔的信息</param>
		/// <return>实体对象集合</return>
		public List<Gdt_user_extEO> GetByFloorInfo(string floorInfo)
		{
			return GetByFloorInfo(floorInfo, 0, string.Empty, null);
		}
		public async Task<List<Gdt_user_extEO>> GetByFloorInfoAsync(string floorInfo)
		{
			return await GetByFloorInfoAsync(floorInfo, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 FloorInfo（字段） 查询
		/// </summary>
		/// /// <param name = "floorInfo">爬塔的信息</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gdt_user_extEO> GetByFloorInfo(string floorInfo, TransactionManager tm_)
		{
			return GetByFloorInfo(floorInfo, 0, string.Empty, tm_);
		}
		public async Task<List<Gdt_user_extEO>> GetByFloorInfoAsync(string floorInfo, TransactionManager tm_)
		{
			return await GetByFloorInfoAsync(floorInfo, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FloorInfo（字段） 查询
		/// </summary>
		/// /// <param name = "floorInfo">爬塔的信息</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Gdt_user_extEO> GetByFloorInfo(string floorInfo, int top_)
		{
			return GetByFloorInfo(floorInfo, top_, string.Empty, null);
		}
		public async Task<List<Gdt_user_extEO>> GetByFloorInfoAsync(string floorInfo, int top_)
		{
			return await GetByFloorInfoAsync(floorInfo, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 FloorInfo（字段） 查询
		/// </summary>
		/// /// <param name = "floorInfo">爬塔的信息</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gdt_user_extEO> GetByFloorInfo(string floorInfo, int top_, TransactionManager tm_)
		{
			return GetByFloorInfo(floorInfo, top_, string.Empty, tm_);
		}
		public async Task<List<Gdt_user_extEO>> GetByFloorInfoAsync(string floorInfo, int top_, TransactionManager tm_)
		{
			return await GetByFloorInfoAsync(floorInfo, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 FloorInfo（字段） 查询
		/// </summary>
		/// /// <param name = "floorInfo">爬塔的信息</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Gdt_user_extEO> GetByFloorInfo(string floorInfo, string sort_)
		{
			return GetByFloorInfo(floorInfo, 0, sort_, null);
		}
		public async Task<List<Gdt_user_extEO>> GetByFloorInfoAsync(string floorInfo, string sort_)
		{
			return await GetByFloorInfoAsync(floorInfo, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 FloorInfo（字段） 查询
		/// </summary>
		/// /// <param name = "floorInfo">爬塔的信息</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gdt_user_extEO> GetByFloorInfo(string floorInfo, string sort_, TransactionManager tm_)
		{
			return GetByFloorInfo(floorInfo, 0, sort_, tm_);
		}
		public async Task<List<Gdt_user_extEO>> GetByFloorInfoAsync(string floorInfo, string sort_, TransactionManager tm_)
		{
			return await GetByFloorInfoAsync(floorInfo, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 FloorInfo（字段） 查询
		/// </summary>
		/// /// <param name = "floorInfo">爬塔的信息</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gdt_user_extEO> GetByFloorInfo(string floorInfo, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`FloorInfo` = @FloorInfo", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FloorInfo", floorInfo, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Gdt_user_extEO.MapDataReader);
		}
		public async Task<List<Gdt_user_extEO>> GetByFloorInfoAsync(string floorInfo, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`FloorInfo` = @FloorInfo", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@FloorInfo", floorInfo, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gdt_user_extEO.MapDataReader);
		}
		#endregion // GetByFloorInfo
		#region GetByGameStatus
		
		/// <summary>
		/// 按 GameStatus（字段） 查询
		/// </summary>
		/// /// <param name = "gameStatus">0-未开始,1-进行中, 2-已结束</param>
		/// <return>实体对象集合</return>
		public List<Gdt_user_extEO> GetByGameStatus(int gameStatus)
		{
			return GetByGameStatus(gameStatus, 0, string.Empty, null);
		}
		public async Task<List<Gdt_user_extEO>> GetByGameStatusAsync(int gameStatus)
		{
			return await GetByGameStatusAsync(gameStatus, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 GameStatus（字段） 查询
		/// </summary>
		/// /// <param name = "gameStatus">0-未开始,1-进行中, 2-已结束</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gdt_user_extEO> GetByGameStatus(int gameStatus, TransactionManager tm_)
		{
			return GetByGameStatus(gameStatus, 0, string.Empty, tm_);
		}
		public async Task<List<Gdt_user_extEO>> GetByGameStatusAsync(int gameStatus, TransactionManager tm_)
		{
			return await GetByGameStatusAsync(gameStatus, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 GameStatus（字段） 查询
		/// </summary>
		/// /// <param name = "gameStatus">0-未开始,1-进行中, 2-已结束</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Gdt_user_extEO> GetByGameStatus(int gameStatus, int top_)
		{
			return GetByGameStatus(gameStatus, top_, string.Empty, null);
		}
		public async Task<List<Gdt_user_extEO>> GetByGameStatusAsync(int gameStatus, int top_)
		{
			return await GetByGameStatusAsync(gameStatus, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 GameStatus（字段） 查询
		/// </summary>
		/// /// <param name = "gameStatus">0-未开始,1-进行中, 2-已结束</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gdt_user_extEO> GetByGameStatus(int gameStatus, int top_, TransactionManager tm_)
		{
			return GetByGameStatus(gameStatus, top_, string.Empty, tm_);
		}
		public async Task<List<Gdt_user_extEO>> GetByGameStatusAsync(int gameStatus, int top_, TransactionManager tm_)
		{
			return await GetByGameStatusAsync(gameStatus, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 GameStatus（字段） 查询
		/// </summary>
		/// /// <param name = "gameStatus">0-未开始,1-进行中, 2-已结束</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Gdt_user_extEO> GetByGameStatus(int gameStatus, string sort_)
		{
			return GetByGameStatus(gameStatus, 0, sort_, null);
		}
		public async Task<List<Gdt_user_extEO>> GetByGameStatusAsync(int gameStatus, string sort_)
		{
			return await GetByGameStatusAsync(gameStatus, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 GameStatus（字段） 查询
		/// </summary>
		/// /// <param name = "gameStatus">0-未开始,1-进行中, 2-已结束</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gdt_user_extEO> GetByGameStatus(int gameStatus, string sort_, TransactionManager tm_)
		{
			return GetByGameStatus(gameStatus, 0, sort_, tm_);
		}
		public async Task<List<Gdt_user_extEO>> GetByGameStatusAsync(int gameStatus, string sort_, TransactionManager tm_)
		{
			return await GetByGameStatusAsync(gameStatus, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 GameStatus（字段） 查询
		/// </summary>
		/// /// <param name = "gameStatus">0-未开始,1-进行中, 2-已结束</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gdt_user_extEO> GetByGameStatus(int gameStatus, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`GameStatus` = @GameStatus", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@GameStatus", gameStatus, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Gdt_user_extEO.MapDataReader);
		}
		public async Task<List<Gdt_user_extEO>> GetByGameStatusAsync(int gameStatus, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`GameStatus` = @GameStatus", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@GameStatus", gameStatus, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gdt_user_extEO.MapDataReader);
		}
		#endregion // GetByGameStatus
		#region GetByLastRecDate
		
		/// <summary>
		/// 按 LastRecDate（字段） 查询
		/// </summary>
		/// /// <param name = "lastRecDate">记录最后记录时间</param>
		/// <return>实体对象集合</return>
		public List<Gdt_user_extEO> GetByLastRecDate(DateTime? lastRecDate)
		{
			return GetByLastRecDate(lastRecDate, 0, string.Empty, null);
		}
		public async Task<List<Gdt_user_extEO>> GetByLastRecDateAsync(DateTime? lastRecDate)
		{
			return await GetByLastRecDateAsync(lastRecDate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LastRecDate（字段） 查询
		/// </summary>
		/// /// <param name = "lastRecDate">记录最后记录时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gdt_user_extEO> GetByLastRecDate(DateTime? lastRecDate, TransactionManager tm_)
		{
			return GetByLastRecDate(lastRecDate, 0, string.Empty, tm_);
		}
		public async Task<List<Gdt_user_extEO>> GetByLastRecDateAsync(DateTime? lastRecDate, TransactionManager tm_)
		{
			return await GetByLastRecDateAsync(lastRecDate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LastRecDate（字段） 查询
		/// </summary>
		/// /// <param name = "lastRecDate">记录最后记录时间</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Gdt_user_extEO> GetByLastRecDate(DateTime? lastRecDate, int top_)
		{
			return GetByLastRecDate(lastRecDate, top_, string.Empty, null);
		}
		public async Task<List<Gdt_user_extEO>> GetByLastRecDateAsync(DateTime? lastRecDate, int top_)
		{
			return await GetByLastRecDateAsync(lastRecDate, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LastRecDate（字段） 查询
		/// </summary>
		/// /// <param name = "lastRecDate">记录最后记录时间</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gdt_user_extEO> GetByLastRecDate(DateTime? lastRecDate, int top_, TransactionManager tm_)
		{
			return GetByLastRecDate(lastRecDate, top_, string.Empty, tm_);
		}
		public async Task<List<Gdt_user_extEO>> GetByLastRecDateAsync(DateTime? lastRecDate, int top_, TransactionManager tm_)
		{
			return await GetByLastRecDateAsync(lastRecDate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LastRecDate（字段） 查询
		/// </summary>
		/// /// <param name = "lastRecDate">记录最后记录时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Gdt_user_extEO> GetByLastRecDate(DateTime? lastRecDate, string sort_)
		{
			return GetByLastRecDate(lastRecDate, 0, sort_, null);
		}
		public async Task<List<Gdt_user_extEO>> GetByLastRecDateAsync(DateTime? lastRecDate, string sort_)
		{
			return await GetByLastRecDateAsync(lastRecDate, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 LastRecDate（字段） 查询
		/// </summary>
		/// /// <param name = "lastRecDate">记录最后记录时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gdt_user_extEO> GetByLastRecDate(DateTime? lastRecDate, string sort_, TransactionManager tm_)
		{
			return GetByLastRecDate(lastRecDate, 0, sort_, tm_);
		}
		public async Task<List<Gdt_user_extEO>> GetByLastRecDateAsync(DateTime? lastRecDate, string sort_, TransactionManager tm_)
		{
			return await GetByLastRecDateAsync(lastRecDate, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 LastRecDate（字段） 查询
		/// </summary>
		/// /// <param name = "lastRecDate">记录最后记录时间</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Gdt_user_extEO> GetByLastRecDate(DateTime? lastRecDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(lastRecDate.HasValue ? "`LastRecDate` = @LastRecDate" : "`LastRecDate` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (lastRecDate.HasValue)
				paras_.Add(Database.CreateInParameter("@LastRecDate", lastRecDate.Value, MySqlDbType.DateTime));
			return Database.ExecSqlList(sql_, paras_, tm_, Gdt_user_extEO.MapDataReader);
		}
		public async Task<List<Gdt_user_extEO>> GetByLastRecDateAsync(DateTime? lastRecDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(lastRecDate.HasValue ? "`LastRecDate` = @LastRecDate" : "`LastRecDate` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (lastRecDate.HasValue)
				paras_.Add(Database.CreateInParameter("@LastRecDate", lastRecDate.Value, MySqlDbType.DateTime));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gdt_user_extEO.MapDataReader);
		}
		#endregion // GetByLastRecDate
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
