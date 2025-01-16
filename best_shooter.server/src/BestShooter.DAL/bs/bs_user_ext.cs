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
	/// 用户扩展表
	/// 【表 bs_user_ext 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class Bs_user_extEO : IRowMapper<Bs_user_extEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public Bs_user_extEO()
		{
			this.LuckySumAmount = 0;
			this.LuckyValue = 0;
			this.ThisLuckyAmount = 0;
			this.JackpotValue = 0;
			this.Goal = 0;
			this.RecDate = DateTime.Now;
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
		/// 用户id
		/// 【主键 varchar(50)】
		/// </summary>
		[DataMember(Order = 1)]
		public string UserID { get; set; }
		/// <summary>
		/// 用户Lucky奖池总金额（值*100000）
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 2)]
		public long LuckySumAmount { get; set; }
		/// <summary>
		/// 用户累计Lucky值
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 3)]
		public int LuckyValue { get; set; }
		/// <summary>
		/// 用户当前累计Lucky值金额（值*100000）
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 4)]
		public long ThisLuckyAmount { get; set; }
		/// <summary>
		/// 用户累计Jackpot值（值*100000）
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 5)]
		public long JackpotValue { get; set; }
		/// <summary>
		/// 用户进球累计值
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 6)]
		public int Goal { get; set; }
		/// <summary>
		/// 创建时间
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 7)]
		public DateTime RecDate { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public Bs_user_extEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static Bs_user_extEO MapDataReader(IDataReader reader)
		{
		    Bs_user_extEO ret = new Bs_user_extEO();
			ret.UserID = reader.ToString("UserID");
			ret.OriginalUserID = ret.UserID;
			ret.LuckySumAmount = reader.ToInt64("LuckySumAmount");
			ret.LuckyValue = reader.ToInt32("LuckyValue");
			ret.ThisLuckyAmount = reader.ToInt64("ThisLuckyAmount");
			ret.JackpotValue = reader.ToInt64("JackpotValue");
			ret.Goal = reader.ToInt32("Goal");
			ret.RecDate = reader.ToDateTime("RecDate");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 用户扩展表
	/// 【表 bs_user_ext 的操作类】
	/// </summary>
	[Obsolete]
	public class Bs_user_extMO : MySqlTableMO<Bs_user_extEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`bs_user_ext`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public Bs_user_extMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public Bs_user_extMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public Bs_user_extMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(Bs_user_extEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(Bs_user_extEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(Bs_user_extEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`UserID`, `LuckySumAmount`, `LuckyValue`, `ThisLuckyAmount`, `JackpotValue`, `Goal`, `RecDate`) VALUE (@UserID, @LuckySumAmount, @LuckyValue, @ThisLuckyAmount, @JackpotValue, @Goal, @RecDate);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", item.UserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LuckySumAmount", item.LuckySumAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@LuckyValue", item.LuckyValue, MySqlDbType.Int32),
				Database.CreateInParameter("@ThisLuckyAmount", item.ThisLuckyAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@JackpotValue", item.JackpotValue, MySqlDbType.Int64),
				Database.CreateInParameter("@Goal", item.Goal, MySqlDbType.Int32),
				Database.CreateInParameter("@RecDate", item.RecDate, MySqlDbType.DateTime),
			};
		}
		public int AddByBatch(IEnumerable<Bs_user_extEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<Bs_user_extEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<Bs_user_extEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`UserID`, `LuckySumAmount`, `LuckyValue`, `ThisLuckyAmount`, `JackpotValue`, `Goal`, `RecDate`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"('{item.UserID}',{item.LuckySumAmount},{item.LuckyValue},{item.ThisLuckyAmount},{item.JackpotValue},{item.Goal},'{item.RecDate.ToString("yyyy-MM-dd HH:mm:ss")}'),");
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
		/// /// <param name = "userID">用户id</param>
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
		public int Remove(Bs_user_extEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.UserID, tm_);
		}
		public async Task<int> RemoveAsync(Bs_user_extEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.UserID, tm_);
		}
		#endregion // RemoveByPK
		
		#region RemoveByXXX
		#region RemoveByLuckySumAmount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "luckySumAmount">用户Lucky奖池总金额（值*100000）</param>
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
		#region RemoveByLuckyValue
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "luckyValue">用户累计Lucky值</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByLuckyValue(int luckyValue, TransactionManager tm_ = null)
		{
			RepairRemoveByLuckyValueData(luckyValue, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByLuckyValueAsync(int luckyValue, TransactionManager tm_ = null)
		{
			RepairRemoveByLuckyValueData(luckyValue, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByLuckyValueData(int luckyValue, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `LuckyValue` = @LuckyValue";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@LuckyValue", luckyValue, MySqlDbType.Int32));
		}
		#endregion // RemoveByLuckyValue
		#region RemoveByThisLuckyAmount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "thisLuckyAmount">用户当前累计Lucky值金额（值*100000）</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByThisLuckyAmount(long thisLuckyAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByThisLuckyAmountData(thisLuckyAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByThisLuckyAmountAsync(long thisLuckyAmount, TransactionManager tm_ = null)
		{
			RepairRemoveByThisLuckyAmountData(thisLuckyAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByThisLuckyAmountData(long thisLuckyAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `ThisLuckyAmount` = @ThisLuckyAmount";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ThisLuckyAmount", thisLuckyAmount, MySqlDbType.Int64));
		}
		#endregion // RemoveByThisLuckyAmount
		#region RemoveByJackpotValue
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "jackpotValue">用户累计Jackpot值（值*100000）</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByJackpotValue(long jackpotValue, TransactionManager tm_ = null)
		{
			RepairRemoveByJackpotValueData(jackpotValue, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByJackpotValueAsync(long jackpotValue, TransactionManager tm_ = null)
		{
			RepairRemoveByJackpotValueData(jackpotValue, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByJackpotValueData(long jackpotValue, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `JackpotValue` = @JackpotValue";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@JackpotValue", jackpotValue, MySqlDbType.Int64));
		}
		#endregion // RemoveByJackpotValue
		#region RemoveByGoal
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "goal">用户进球累计值</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByGoal(int goal, TransactionManager tm_ = null)
		{
			RepairRemoveByGoalData(goal, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByGoalAsync(int goal, TransactionManager tm_ = null)
		{
			RepairRemoveByGoalData(goal, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByGoalData(int goal, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `Goal` = @Goal";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Goal", goal, MySqlDbType.Int32));
		}
		#endregion // RemoveByGoal
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
		public int Put(Bs_user_extEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(Bs_user_extEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(Bs_user_extEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `UserID` = @UserID, `LuckySumAmount` = @LuckySumAmount, `LuckyValue` = @LuckyValue, `ThisLuckyAmount` = @ThisLuckyAmount, `JackpotValue` = @JackpotValue, `Goal` = @Goal WHERE `UserID` = @UserID_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", item.UserID, MySqlDbType.VarChar),
				Database.CreateInParameter("@LuckySumAmount", item.LuckySumAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@LuckyValue", item.LuckyValue, MySqlDbType.Int32),
				Database.CreateInParameter("@ThisLuckyAmount", item.ThisLuckyAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@JackpotValue", item.JackpotValue, MySqlDbType.Int64),
				Database.CreateInParameter("@Goal", item.Goal, MySqlDbType.Int32),
				Database.CreateInParameter("@UserID_Original", item.HasOriginal ? item.OriginalUserID : item.UserID, MySqlDbType.VarChar),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<Bs_user_extEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<Bs_user_extEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "userID">用户id</param>
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
		/// /// <param name = "userID">用户id</param>
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
		/// /// <param name = "userID">用户id</param>
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
		#region PutLuckySumAmount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户id</param>
		/// /// <param name = "luckySumAmount">用户Lucky奖池总金额（值*100000）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutLuckySumAmountByPK(string userID, long luckySumAmount, TransactionManager tm_ = null)
		{
			RepairPutLuckySumAmountByPKData(userID, luckySumAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutLuckySumAmountByPKAsync(string userID, long luckySumAmount, TransactionManager tm_ = null)
		{
			RepairPutLuckySumAmountByPKData(userID, luckySumAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutLuckySumAmountByPKData(string userID, long luckySumAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `LuckySumAmount` = @LuckySumAmount  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LuckySumAmount", luckySumAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "luckySumAmount">用户Lucky奖池总金额（值*100000）</param>
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
		#region PutLuckyValue
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户id</param>
		/// /// <param name = "luckyValue">用户累计Lucky值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutLuckyValueByPK(string userID, int luckyValue, TransactionManager tm_ = null)
		{
			RepairPutLuckyValueByPKData(userID, luckyValue, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutLuckyValueByPKAsync(string userID, int luckyValue, TransactionManager tm_ = null)
		{
			RepairPutLuckyValueByPKData(userID, luckyValue, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutLuckyValueByPKData(string userID, int luckyValue, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `LuckyValue` = @LuckyValue  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@LuckyValue", luckyValue, MySqlDbType.Int32),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "luckyValue">用户累计Lucky值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutLuckyValue(int luckyValue, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `LuckyValue` = @LuckyValue";
			var parameter_ = Database.CreateInParameter("@LuckyValue", luckyValue, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutLuckyValueAsync(int luckyValue, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `LuckyValue` = @LuckyValue";
			var parameter_ = Database.CreateInParameter("@LuckyValue", luckyValue, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutLuckyValue
		#region PutThisLuckyAmount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户id</param>
		/// /// <param name = "thisLuckyAmount">用户当前累计Lucky值金额（值*100000）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutThisLuckyAmountByPK(string userID, long thisLuckyAmount, TransactionManager tm_ = null)
		{
			RepairPutThisLuckyAmountByPKData(userID, thisLuckyAmount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutThisLuckyAmountByPKAsync(string userID, long thisLuckyAmount, TransactionManager tm_ = null)
		{
			RepairPutThisLuckyAmountByPKData(userID, thisLuckyAmount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutThisLuckyAmountByPKData(string userID, long thisLuckyAmount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `ThisLuckyAmount` = @ThisLuckyAmount  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@ThisLuckyAmount", thisLuckyAmount, MySqlDbType.Int64),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "thisLuckyAmount">用户当前累计Lucky值金额（值*100000）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutThisLuckyAmount(long thisLuckyAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ThisLuckyAmount` = @ThisLuckyAmount";
			var parameter_ = Database.CreateInParameter("@ThisLuckyAmount", thisLuckyAmount, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutThisLuckyAmountAsync(long thisLuckyAmount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `ThisLuckyAmount` = @ThisLuckyAmount";
			var parameter_ = Database.CreateInParameter("@ThisLuckyAmount", thisLuckyAmount, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutThisLuckyAmount
		#region PutJackpotValue
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户id</param>
		/// /// <param name = "jackpotValue">用户累计Jackpot值（值*100000）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutJackpotValueByPK(string userID, long jackpotValue, TransactionManager tm_ = null)
		{
			RepairPutJackpotValueByPKData(userID, jackpotValue, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutJackpotValueByPKAsync(string userID, long jackpotValue, TransactionManager tm_ = null)
		{
			RepairPutJackpotValueByPKData(userID, jackpotValue, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutJackpotValueByPKData(string userID, long jackpotValue, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `JackpotValue` = @JackpotValue  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@JackpotValue", jackpotValue, MySqlDbType.Int64),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "jackpotValue">用户累计Jackpot值（值*100000）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutJackpotValue(long jackpotValue, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `JackpotValue` = @JackpotValue";
			var parameter_ = Database.CreateInParameter("@JackpotValue", jackpotValue, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutJackpotValueAsync(long jackpotValue, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `JackpotValue` = @JackpotValue";
			var parameter_ = Database.CreateInParameter("@JackpotValue", jackpotValue, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutJackpotValue
		#region PutGoal
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户id</param>
		/// /// <param name = "goal">用户进球累计值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutGoalByPK(string userID, int goal, TransactionManager tm_ = null)
		{
			RepairPutGoalByPKData(userID, goal, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutGoalByPKAsync(string userID, int goal, TransactionManager tm_ = null)
		{
			RepairPutGoalByPKData(userID, goal, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutGoalByPKData(string userID, int goal, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Goal` = @Goal  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Goal", goal, MySqlDbType.Int32),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "goal">用户进球累计值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutGoal(int goal, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Goal` = @Goal";
			var parameter_ = Database.CreateInParameter("@Goal", goal, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutGoalAsync(int goal, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Goal` = @Goal";
			var parameter_ = Database.CreateInParameter("@Goal", goal, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutGoal
		#region PutRecDate
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "userID">用户id</param>
		/// /// <param name = "recDate">创建时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRecDateByPK(string userID, DateTime recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(userID, recDate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutRecDateByPKAsync(string userID, DateTime recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(userID, recDate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutRecDateByPKData(string userID, DateTime recDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `RecDate` = @RecDate  WHERE `UserID` = @UserID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime),
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
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
		public bool Set(Bs_user_extEO item, TransactionManager tm = null)
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
		public async Task<bool> SetAsync(Bs_user_extEO item, TransactionManager tm = null)
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
		/// /// <param name = "userID">用户id</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public Bs_user_extEO GetByPK(string userID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(userID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, Bs_user_extEO.MapDataReader);
		}
		public async Task<Bs_user_extEO> GetByPKAsync(string userID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(userID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Bs_user_extEO.MapDataReader);
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
		/// 按主键查询 LuckySumAmount（字段）
		/// </summary>
		/// /// <param name = "userID">用户id</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetLuckySumAmountByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`LuckySumAmount`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<long> GetLuckySumAmountByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`LuckySumAmount`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 LuckyValue（字段）
		/// </summary>
		/// /// <param name = "userID">用户id</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetLuckyValueByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`LuckyValue`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<int> GetLuckyValueByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`LuckyValue`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 ThisLuckyAmount（字段）
		/// </summary>
		/// /// <param name = "userID">用户id</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetThisLuckyAmountByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`ThisLuckyAmount`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<long> GetThisLuckyAmountByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`ThisLuckyAmount`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 JackpotValue（字段）
		/// </summary>
		/// /// <param name = "userID">用户id</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetJackpotValueByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`JackpotValue`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<long> GetJackpotValueByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`JackpotValue`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Goal（字段）
		/// </summary>
		/// /// <param name = "userID">用户id</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetGoalByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`Goal`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<int> GetGoalByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`Goal`", "`UserID` = @UserID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 RecDate（字段）
		/// </summary>
		/// /// <param name = "userID">用户id</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime GetRecDateByPK(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (DateTime)GetScalar("`RecDate`", "`UserID` = @UserID", paras_, tm_);
		}
		public async Task<DateTime> GetRecDateByPKAsync(string userID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
			};
			return (DateTime)await GetScalarAsync("`RecDate`", "`UserID` = @UserID", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByLuckySumAmount
		
		/// <summary>
		/// 按 LuckySumAmount（字段） 查询
		/// </summary>
		/// /// <param name = "luckySumAmount">用户Lucky奖池总金额（值*100000）</param>
		/// <return>实体对象集合</return>
		public List<Bs_user_extEO> GetByLuckySumAmount(long luckySumAmount)
		{
			return GetByLuckySumAmount(luckySumAmount, 0, string.Empty, null);
		}
		public async Task<List<Bs_user_extEO>> GetByLuckySumAmountAsync(long luckySumAmount)
		{
			return await GetByLuckySumAmountAsync(luckySumAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LuckySumAmount（字段） 查询
		/// </summary>
		/// /// <param name = "luckySumAmount">用户Lucky奖池总金额（值*100000）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_user_extEO> GetByLuckySumAmount(long luckySumAmount, TransactionManager tm_)
		{
			return GetByLuckySumAmount(luckySumAmount, 0, string.Empty, tm_);
		}
		public async Task<List<Bs_user_extEO>> GetByLuckySumAmountAsync(long luckySumAmount, TransactionManager tm_)
		{
			return await GetByLuckySumAmountAsync(luckySumAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LuckySumAmount（字段） 查询
		/// </summary>
		/// /// <param name = "luckySumAmount">用户Lucky奖池总金额（值*100000）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Bs_user_extEO> GetByLuckySumAmount(long luckySumAmount, int top_)
		{
			return GetByLuckySumAmount(luckySumAmount, top_, string.Empty, null);
		}
		public async Task<List<Bs_user_extEO>> GetByLuckySumAmountAsync(long luckySumAmount, int top_)
		{
			return await GetByLuckySumAmountAsync(luckySumAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LuckySumAmount（字段） 查询
		/// </summary>
		/// /// <param name = "luckySumAmount">用户Lucky奖池总金额（值*100000）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_user_extEO> GetByLuckySumAmount(long luckySumAmount, int top_, TransactionManager tm_)
		{
			return GetByLuckySumAmount(luckySumAmount, top_, string.Empty, tm_);
		}
		public async Task<List<Bs_user_extEO>> GetByLuckySumAmountAsync(long luckySumAmount, int top_, TransactionManager tm_)
		{
			return await GetByLuckySumAmountAsync(luckySumAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LuckySumAmount（字段） 查询
		/// </summary>
		/// /// <param name = "luckySumAmount">用户Lucky奖池总金额（值*100000）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Bs_user_extEO> GetByLuckySumAmount(long luckySumAmount, string sort_)
		{
			return GetByLuckySumAmount(luckySumAmount, 0, sort_, null);
		}
		public async Task<List<Bs_user_extEO>> GetByLuckySumAmountAsync(long luckySumAmount, string sort_)
		{
			return await GetByLuckySumAmountAsync(luckySumAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 LuckySumAmount（字段） 查询
		/// </summary>
		/// /// <param name = "luckySumAmount">用户Lucky奖池总金额（值*100000）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_user_extEO> GetByLuckySumAmount(long luckySumAmount, string sort_, TransactionManager tm_)
		{
			return GetByLuckySumAmount(luckySumAmount, 0, sort_, tm_);
		}
		public async Task<List<Bs_user_extEO>> GetByLuckySumAmountAsync(long luckySumAmount, string sort_, TransactionManager tm_)
		{
			return await GetByLuckySumAmountAsync(luckySumAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 LuckySumAmount（字段） 查询
		/// </summary>
		/// /// <param name = "luckySumAmount">用户Lucky奖池总金额（值*100000）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_user_extEO> GetByLuckySumAmount(long luckySumAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`LuckySumAmount` = @LuckySumAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@LuckySumAmount", luckySumAmount, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Bs_user_extEO.MapDataReader);
		}
		public async Task<List<Bs_user_extEO>> GetByLuckySumAmountAsync(long luckySumAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`LuckySumAmount` = @LuckySumAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@LuckySumAmount", luckySumAmount, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Bs_user_extEO.MapDataReader);
		}
		#endregion // GetByLuckySumAmount
		#region GetByLuckyValue
		
		/// <summary>
		/// 按 LuckyValue（字段） 查询
		/// </summary>
		/// /// <param name = "luckyValue">用户累计Lucky值</param>
		/// <return>实体对象集合</return>
		public List<Bs_user_extEO> GetByLuckyValue(int luckyValue)
		{
			return GetByLuckyValue(luckyValue, 0, string.Empty, null);
		}
		public async Task<List<Bs_user_extEO>> GetByLuckyValueAsync(int luckyValue)
		{
			return await GetByLuckyValueAsync(luckyValue, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LuckyValue（字段） 查询
		/// </summary>
		/// /// <param name = "luckyValue">用户累计Lucky值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_user_extEO> GetByLuckyValue(int luckyValue, TransactionManager tm_)
		{
			return GetByLuckyValue(luckyValue, 0, string.Empty, tm_);
		}
		public async Task<List<Bs_user_extEO>> GetByLuckyValueAsync(int luckyValue, TransactionManager tm_)
		{
			return await GetByLuckyValueAsync(luckyValue, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LuckyValue（字段） 查询
		/// </summary>
		/// /// <param name = "luckyValue">用户累计Lucky值</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Bs_user_extEO> GetByLuckyValue(int luckyValue, int top_)
		{
			return GetByLuckyValue(luckyValue, top_, string.Empty, null);
		}
		public async Task<List<Bs_user_extEO>> GetByLuckyValueAsync(int luckyValue, int top_)
		{
			return await GetByLuckyValueAsync(luckyValue, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 LuckyValue（字段） 查询
		/// </summary>
		/// /// <param name = "luckyValue">用户累计Lucky值</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_user_extEO> GetByLuckyValue(int luckyValue, int top_, TransactionManager tm_)
		{
			return GetByLuckyValue(luckyValue, top_, string.Empty, tm_);
		}
		public async Task<List<Bs_user_extEO>> GetByLuckyValueAsync(int luckyValue, int top_, TransactionManager tm_)
		{
			return await GetByLuckyValueAsync(luckyValue, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 LuckyValue（字段） 查询
		/// </summary>
		/// /// <param name = "luckyValue">用户累计Lucky值</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Bs_user_extEO> GetByLuckyValue(int luckyValue, string sort_)
		{
			return GetByLuckyValue(luckyValue, 0, sort_, null);
		}
		public async Task<List<Bs_user_extEO>> GetByLuckyValueAsync(int luckyValue, string sort_)
		{
			return await GetByLuckyValueAsync(luckyValue, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 LuckyValue（字段） 查询
		/// </summary>
		/// /// <param name = "luckyValue">用户累计Lucky值</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_user_extEO> GetByLuckyValue(int luckyValue, string sort_, TransactionManager tm_)
		{
			return GetByLuckyValue(luckyValue, 0, sort_, tm_);
		}
		public async Task<List<Bs_user_extEO>> GetByLuckyValueAsync(int luckyValue, string sort_, TransactionManager tm_)
		{
			return await GetByLuckyValueAsync(luckyValue, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 LuckyValue（字段） 查询
		/// </summary>
		/// /// <param name = "luckyValue">用户累计Lucky值</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_user_extEO> GetByLuckyValue(int luckyValue, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`LuckyValue` = @LuckyValue", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@LuckyValue", luckyValue, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Bs_user_extEO.MapDataReader);
		}
		public async Task<List<Bs_user_extEO>> GetByLuckyValueAsync(int luckyValue, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`LuckyValue` = @LuckyValue", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@LuckyValue", luckyValue, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Bs_user_extEO.MapDataReader);
		}
		#endregion // GetByLuckyValue
		#region GetByThisLuckyAmount
		
		/// <summary>
		/// 按 ThisLuckyAmount（字段） 查询
		/// </summary>
		/// /// <param name = "thisLuckyAmount">用户当前累计Lucky值金额（值*100000）</param>
		/// <return>实体对象集合</return>
		public List<Bs_user_extEO> GetByThisLuckyAmount(long thisLuckyAmount)
		{
			return GetByThisLuckyAmount(thisLuckyAmount, 0, string.Empty, null);
		}
		public async Task<List<Bs_user_extEO>> GetByThisLuckyAmountAsync(long thisLuckyAmount)
		{
			return await GetByThisLuckyAmountAsync(thisLuckyAmount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ThisLuckyAmount（字段） 查询
		/// </summary>
		/// /// <param name = "thisLuckyAmount">用户当前累计Lucky值金额（值*100000）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_user_extEO> GetByThisLuckyAmount(long thisLuckyAmount, TransactionManager tm_)
		{
			return GetByThisLuckyAmount(thisLuckyAmount, 0, string.Empty, tm_);
		}
		public async Task<List<Bs_user_extEO>> GetByThisLuckyAmountAsync(long thisLuckyAmount, TransactionManager tm_)
		{
			return await GetByThisLuckyAmountAsync(thisLuckyAmount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ThisLuckyAmount（字段） 查询
		/// </summary>
		/// /// <param name = "thisLuckyAmount">用户当前累计Lucky值金额（值*100000）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Bs_user_extEO> GetByThisLuckyAmount(long thisLuckyAmount, int top_)
		{
			return GetByThisLuckyAmount(thisLuckyAmount, top_, string.Empty, null);
		}
		public async Task<List<Bs_user_extEO>> GetByThisLuckyAmountAsync(long thisLuckyAmount, int top_)
		{
			return await GetByThisLuckyAmountAsync(thisLuckyAmount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 ThisLuckyAmount（字段） 查询
		/// </summary>
		/// /// <param name = "thisLuckyAmount">用户当前累计Lucky值金额（值*100000）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_user_extEO> GetByThisLuckyAmount(long thisLuckyAmount, int top_, TransactionManager tm_)
		{
			return GetByThisLuckyAmount(thisLuckyAmount, top_, string.Empty, tm_);
		}
		public async Task<List<Bs_user_extEO>> GetByThisLuckyAmountAsync(long thisLuckyAmount, int top_, TransactionManager tm_)
		{
			return await GetByThisLuckyAmountAsync(thisLuckyAmount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 ThisLuckyAmount（字段） 查询
		/// </summary>
		/// /// <param name = "thisLuckyAmount">用户当前累计Lucky值金额（值*100000）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Bs_user_extEO> GetByThisLuckyAmount(long thisLuckyAmount, string sort_)
		{
			return GetByThisLuckyAmount(thisLuckyAmount, 0, sort_, null);
		}
		public async Task<List<Bs_user_extEO>> GetByThisLuckyAmountAsync(long thisLuckyAmount, string sort_)
		{
			return await GetByThisLuckyAmountAsync(thisLuckyAmount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 ThisLuckyAmount（字段） 查询
		/// </summary>
		/// /// <param name = "thisLuckyAmount">用户当前累计Lucky值金额（值*100000）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_user_extEO> GetByThisLuckyAmount(long thisLuckyAmount, string sort_, TransactionManager tm_)
		{
			return GetByThisLuckyAmount(thisLuckyAmount, 0, sort_, tm_);
		}
		public async Task<List<Bs_user_extEO>> GetByThisLuckyAmountAsync(long thisLuckyAmount, string sort_, TransactionManager tm_)
		{
			return await GetByThisLuckyAmountAsync(thisLuckyAmount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 ThisLuckyAmount（字段） 查询
		/// </summary>
		/// /// <param name = "thisLuckyAmount">用户当前累计Lucky值金额（值*100000）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_user_extEO> GetByThisLuckyAmount(long thisLuckyAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ThisLuckyAmount` = @ThisLuckyAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ThisLuckyAmount", thisLuckyAmount, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Bs_user_extEO.MapDataReader);
		}
		public async Task<List<Bs_user_extEO>> GetByThisLuckyAmountAsync(long thisLuckyAmount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`ThisLuckyAmount` = @ThisLuckyAmount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@ThisLuckyAmount", thisLuckyAmount, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Bs_user_extEO.MapDataReader);
		}
		#endregion // GetByThisLuckyAmount
		#region GetByJackpotValue
		
		/// <summary>
		/// 按 JackpotValue（字段） 查询
		/// </summary>
		/// /// <param name = "jackpotValue">用户累计Jackpot值（值*100000）</param>
		/// <return>实体对象集合</return>
		public List<Bs_user_extEO> GetByJackpotValue(long jackpotValue)
		{
			return GetByJackpotValue(jackpotValue, 0, string.Empty, null);
		}
		public async Task<List<Bs_user_extEO>> GetByJackpotValueAsync(long jackpotValue)
		{
			return await GetByJackpotValueAsync(jackpotValue, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 JackpotValue（字段） 查询
		/// </summary>
		/// /// <param name = "jackpotValue">用户累计Jackpot值（值*100000）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_user_extEO> GetByJackpotValue(long jackpotValue, TransactionManager tm_)
		{
			return GetByJackpotValue(jackpotValue, 0, string.Empty, tm_);
		}
		public async Task<List<Bs_user_extEO>> GetByJackpotValueAsync(long jackpotValue, TransactionManager tm_)
		{
			return await GetByJackpotValueAsync(jackpotValue, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 JackpotValue（字段） 查询
		/// </summary>
		/// /// <param name = "jackpotValue">用户累计Jackpot值（值*100000）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Bs_user_extEO> GetByJackpotValue(long jackpotValue, int top_)
		{
			return GetByJackpotValue(jackpotValue, top_, string.Empty, null);
		}
		public async Task<List<Bs_user_extEO>> GetByJackpotValueAsync(long jackpotValue, int top_)
		{
			return await GetByJackpotValueAsync(jackpotValue, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 JackpotValue（字段） 查询
		/// </summary>
		/// /// <param name = "jackpotValue">用户累计Jackpot值（值*100000）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_user_extEO> GetByJackpotValue(long jackpotValue, int top_, TransactionManager tm_)
		{
			return GetByJackpotValue(jackpotValue, top_, string.Empty, tm_);
		}
		public async Task<List<Bs_user_extEO>> GetByJackpotValueAsync(long jackpotValue, int top_, TransactionManager tm_)
		{
			return await GetByJackpotValueAsync(jackpotValue, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 JackpotValue（字段） 查询
		/// </summary>
		/// /// <param name = "jackpotValue">用户累计Jackpot值（值*100000）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Bs_user_extEO> GetByJackpotValue(long jackpotValue, string sort_)
		{
			return GetByJackpotValue(jackpotValue, 0, sort_, null);
		}
		public async Task<List<Bs_user_extEO>> GetByJackpotValueAsync(long jackpotValue, string sort_)
		{
			return await GetByJackpotValueAsync(jackpotValue, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 JackpotValue（字段） 查询
		/// </summary>
		/// /// <param name = "jackpotValue">用户累计Jackpot值（值*100000）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_user_extEO> GetByJackpotValue(long jackpotValue, string sort_, TransactionManager tm_)
		{
			return GetByJackpotValue(jackpotValue, 0, sort_, tm_);
		}
		public async Task<List<Bs_user_extEO>> GetByJackpotValueAsync(long jackpotValue, string sort_, TransactionManager tm_)
		{
			return await GetByJackpotValueAsync(jackpotValue, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 JackpotValue（字段） 查询
		/// </summary>
		/// /// <param name = "jackpotValue">用户累计Jackpot值（值*100000）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_user_extEO> GetByJackpotValue(long jackpotValue, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`JackpotValue` = @JackpotValue", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@JackpotValue", jackpotValue, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Bs_user_extEO.MapDataReader);
		}
		public async Task<List<Bs_user_extEO>> GetByJackpotValueAsync(long jackpotValue, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`JackpotValue` = @JackpotValue", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@JackpotValue", jackpotValue, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Bs_user_extEO.MapDataReader);
		}
		#endregion // GetByJackpotValue
		#region GetByGoal
		
		/// <summary>
		/// 按 Goal（字段） 查询
		/// </summary>
		/// /// <param name = "goal">用户进球累计值</param>
		/// <return>实体对象集合</return>
		public List<Bs_user_extEO> GetByGoal(int goal)
		{
			return GetByGoal(goal, 0, string.Empty, null);
		}
		public async Task<List<Bs_user_extEO>> GetByGoalAsync(int goal)
		{
			return await GetByGoalAsync(goal, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Goal（字段） 查询
		/// </summary>
		/// /// <param name = "goal">用户进球累计值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_user_extEO> GetByGoal(int goal, TransactionManager tm_)
		{
			return GetByGoal(goal, 0, string.Empty, tm_);
		}
		public async Task<List<Bs_user_extEO>> GetByGoalAsync(int goal, TransactionManager tm_)
		{
			return await GetByGoalAsync(goal, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Goal（字段） 查询
		/// </summary>
		/// /// <param name = "goal">用户进球累计值</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Bs_user_extEO> GetByGoal(int goal, int top_)
		{
			return GetByGoal(goal, top_, string.Empty, null);
		}
		public async Task<List<Bs_user_extEO>> GetByGoalAsync(int goal, int top_)
		{
			return await GetByGoalAsync(goal, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Goal（字段） 查询
		/// </summary>
		/// /// <param name = "goal">用户进球累计值</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_user_extEO> GetByGoal(int goal, int top_, TransactionManager tm_)
		{
			return GetByGoal(goal, top_, string.Empty, tm_);
		}
		public async Task<List<Bs_user_extEO>> GetByGoalAsync(int goal, int top_, TransactionManager tm_)
		{
			return await GetByGoalAsync(goal, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Goal（字段） 查询
		/// </summary>
		/// /// <param name = "goal">用户进球累计值</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Bs_user_extEO> GetByGoal(int goal, string sort_)
		{
			return GetByGoal(goal, 0, sort_, null);
		}
		public async Task<List<Bs_user_extEO>> GetByGoalAsync(int goal, string sort_)
		{
			return await GetByGoalAsync(goal, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Goal（字段） 查询
		/// </summary>
		/// /// <param name = "goal">用户进球累计值</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_user_extEO> GetByGoal(int goal, string sort_, TransactionManager tm_)
		{
			return GetByGoal(goal, 0, sort_, tm_);
		}
		public async Task<List<Bs_user_extEO>> GetByGoalAsync(int goal, string sort_, TransactionManager tm_)
		{
			return await GetByGoalAsync(goal, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Goal（字段） 查询
		/// </summary>
		/// /// <param name = "goal">用户进球累计值</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_user_extEO> GetByGoal(int goal, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Goal` = @Goal", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Goal", goal, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Bs_user_extEO.MapDataReader);
		}
		public async Task<List<Bs_user_extEO>> GetByGoalAsync(int goal, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Goal` = @Goal", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Goal", goal, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Bs_user_extEO.MapDataReader);
		}
		#endregion // GetByGoal
		#region GetByRecDate
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">创建时间</param>
		/// <return>实体对象集合</return>
		public List<Bs_user_extEO> GetByRecDate(DateTime recDate)
		{
			return GetByRecDate(recDate, 0, string.Empty, null);
		}
		public async Task<List<Bs_user_extEO>> GetByRecDateAsync(DateTime recDate)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">创建时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_user_extEO> GetByRecDate(DateTime recDate, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, string.Empty, tm_);
		}
		public async Task<List<Bs_user_extEO>> GetByRecDateAsync(DateTime recDate, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">创建时间</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Bs_user_extEO> GetByRecDate(DateTime recDate, int top_)
		{
			return GetByRecDate(recDate, top_, string.Empty, null);
		}
		public async Task<List<Bs_user_extEO>> GetByRecDateAsync(DateTime recDate, int top_)
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
		public List<Bs_user_extEO> GetByRecDate(DateTime recDate, int top_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, top_, string.Empty, tm_);
		}
		public async Task<List<Bs_user_extEO>> GetByRecDateAsync(DateTime recDate, int top_, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">创建时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Bs_user_extEO> GetByRecDate(DateTime recDate, string sort_)
		{
			return GetByRecDate(recDate, 0, sort_, null);
		}
		public async Task<List<Bs_user_extEO>> GetByRecDateAsync(DateTime recDate, string sort_)
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
		public List<Bs_user_extEO> GetByRecDate(DateTime recDate, string sort_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, sort_, tm_);
		}
		public async Task<List<Bs_user_extEO>> GetByRecDateAsync(DateTime recDate, string sort_, TransactionManager tm_)
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
		public List<Bs_user_extEO> GetByRecDate(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return Database.ExecSqlList(sql_, paras_, tm_, Bs_user_extEO.MapDataReader);
		}
		public async Task<List<Bs_user_extEO>> GetByRecDateAsync(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Bs_user_extEO.MapDataReader);
		}
		#endregion // GetByRecDate
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
