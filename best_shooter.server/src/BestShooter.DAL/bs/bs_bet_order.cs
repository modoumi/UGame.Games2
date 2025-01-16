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
	/// 下注订单表
	/// 【表 bs_bet_order 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class Bs_bet_orderEO : IRowMapper<Bs_bet_orderEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public Bs_bet_orderEO()
		{
			this.Bet = 0;
			this.BetDouble = 0;
			this.Multiple = 0;
			this.Place = 0;
			this.Amount = 0;
			this.IsSurprise = 0;
			this.Status = 0;
			this.RecDate = DateTime.Now;
		}
		#region 主键原始值 & 主键集合
	    
		/// <summary>
		/// 当前对象是否保存原始主键值，当修改了主键值时为 true
		/// </summary>
		public bool HasOriginal { get; protected set; }
		
		private string _originalBetOrderID;
		/// <summary>
		/// 【数据库中的原始主键 BetOrderID 值的副本，用于主键值更新】
		/// </summary>
		public string OriginalBetOrderID
		{
			get { return _originalBetOrderID; }
			set { HasOriginal = true; _originalBetOrderID = value; }
		}
	    /// <summary>
	    /// 获取主键集合。key: 数据库字段名称, value: 主键值
	    /// </summary>
	    /// <returns></returns>
	    public Dictionary<string, object> GetPrimaryKeys()
	    {
	        return new Dictionary<string, object>() { { "BetOrderID", BetOrderID }, };
	    }
	    /// <summary>
	    /// 获取主键集合JSON格式
	    /// </summary>
	    /// <returns></returns>
	    public string GetPrimaryKeysJson() => SerializerUtil.SerializeJson(GetPrimaryKeys());
		#endregion // 主键原始值
		#region 所有字段
		/// <summary>
		/// 下注订单编号Key
		/// 【主键 varchar(50)】
		/// </summary>
		[DataMember(Order = 1)]
		public string BetOrderID { get; set; }
		/// <summary>
		/// 主订单编号GUID
		/// 【字段 varchar(50)】
		/// </summary>
		[DataMember(Order = 2)]
		public string OrderID { get; set; }
		/// <summary>
		/// 赌注（值*100000）
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 3)]
		public long Bet { get; set; }
		/// <summary>
		/// 赌注加倍数（值*100）
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 4)]
		public int BetDouble { get; set; }
		/// <summary>
		/// 位置倍数（值*100）
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 5)]
		public int Multiple { get; set; }
		/// <summary>
		/// 位置
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 6)]
		public int Place { get; set; }
		/// <summary>
		/// 金额（值*100000）
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 7)]
		public long Amount { get; set; }
		/// <summary>
		/// 是否为惊喜奖励
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 8)]
		public int IsSurprise { get; set; }
		/// <summary>
		/// 状态（0-无效1-有效）
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 9)]
		public int Status { get; set; }
		/// <summary>
		/// 创建时间
		/// 【字段 datetime】
		/// </summary>
		[DataMember(Order = 10)]
		public DateTime RecDate { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public Bs_bet_orderEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static Bs_bet_orderEO MapDataReader(IDataReader reader)
		{
		    Bs_bet_orderEO ret = new Bs_bet_orderEO();
			ret.BetOrderID = reader.ToString("BetOrderID");
			ret.OriginalBetOrderID = ret.BetOrderID;
			ret.OrderID = reader.ToString("OrderID");
			ret.Bet = reader.ToInt64("Bet");
			ret.BetDouble = reader.ToInt32("BetDouble");
			ret.Multiple = reader.ToInt32("Multiple");
			ret.Place = reader.ToInt32("Place");
			ret.Amount = reader.ToInt64("Amount");
			ret.IsSurprise = reader.ToInt32("IsSurprise");
			ret.Status = reader.ToInt32("Status");
			ret.RecDate = reader.ToDateTime("RecDate");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 下注订单表
	/// 【表 bs_bet_order 的操作类】
	/// </summary>
	[Obsolete]
	public class Bs_bet_orderMO : MySqlTableMO<Bs_bet_orderEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`bs_bet_order`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public Bs_bet_orderMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public Bs_bet_orderMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public Bs_bet_orderMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(Bs_bet_orderEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(Bs_bet_orderEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(Bs_bet_orderEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`BetOrderID`, `OrderID`, `Bet`, `BetDouble`, `Multiple`, `Place`, `Amount`, `IsSurprise`, `Status`, `RecDate`) VALUE (@BetOrderID, @OrderID, @Bet, @BetDouble, @Multiple, @Place, @Amount, @IsSurprise, @Status, @RecDate);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetOrderID", item.BetOrderID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OrderID", item.OrderID, MySqlDbType.VarChar),
				Database.CreateInParameter("@Bet", item.Bet, MySqlDbType.Int64),
				Database.CreateInParameter("@BetDouble", item.BetDouble, MySqlDbType.Int32),
				Database.CreateInParameter("@Multiple", item.Multiple, MySqlDbType.Int32),
				Database.CreateInParameter("@Place", item.Place, MySqlDbType.Int32),
				Database.CreateInParameter("@Amount", item.Amount, MySqlDbType.Int64),
				Database.CreateInParameter("@IsSurprise", item.IsSurprise, MySqlDbType.Int32),
				Database.CreateInParameter("@Status", item.Status, MySqlDbType.Int32),
				Database.CreateInParameter("@RecDate", item.RecDate, MySqlDbType.DateTime),
			};
		}
		public int AddByBatch(IEnumerable<Bs_bet_orderEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<Bs_bet_orderEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<Bs_bet_orderEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`BetOrderID`, `OrderID`, `Bet`, `BetDouble`, `Multiple`, `Place`, `Amount`, `IsSurprise`, `Status`, `RecDate`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"('{item.BetOrderID}','{item.OrderID}',{item.Bet},{item.BetDouble},{item.Multiple},{item.Place},{item.Amount},{item.IsSurprise},{item.Status},'{item.RecDate.ToString("yyyy-MM-dd HH:mm:ss")}'),");
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
		/// /// <param name = "betOrderID">下注订单编号Key</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(string betOrderID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(betOrderID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(string betOrderID, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(betOrderID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(string betOrderID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `BetOrderID` = @BetOrderID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetOrderID", betOrderID, MySqlDbType.VarChar),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(Bs_bet_orderEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.BetOrderID, tm_);
		}
		public async Task<int> RemoveAsync(Bs_bet_orderEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.BetOrderID, tm_);
		}
		#endregion // RemoveByPK
		
		#region RemoveByXXX
		#region RemoveByOrderID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "orderID">主订单编号GUID</param>
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
		#region RemoveByBet
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "bet">赌注（值*100000）</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByBet(long bet, TransactionManager tm_ = null)
		{
			RepairRemoveByBetData(bet, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByBetAsync(long bet, TransactionManager tm_ = null)
		{
			RepairRemoveByBetData(bet, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByBetData(long bet, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `Bet` = @Bet";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Bet", bet, MySqlDbType.Int64));
		}
		#endregion // RemoveByBet
		#region RemoveByBetDouble
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "betDouble">赌注加倍数（值*100）</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByBetDouble(int betDouble, TransactionManager tm_ = null)
		{
			RepairRemoveByBetDoubleData(betDouble, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByBetDoubleAsync(int betDouble, TransactionManager tm_ = null)
		{
			RepairRemoveByBetDoubleData(betDouble, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByBetDoubleData(int betDouble, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `BetDouble` = @BetDouble";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BetDouble", betDouble, MySqlDbType.Int32));
		}
		#endregion // RemoveByBetDouble
		#region RemoveByMultiple
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "multiple">位置倍数（值*100）</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByMultiple(int multiple, TransactionManager tm_ = null)
		{
			RepairRemoveByMultipleData(multiple, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByMultipleAsync(int multiple, TransactionManager tm_ = null)
		{
			RepairRemoveByMultipleData(multiple, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByMultipleData(int multiple, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `Multiple` = @Multiple";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Multiple", multiple, MySqlDbType.Int32));
		}
		#endregion // RemoveByMultiple
		#region RemoveByPlace
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "place">位置</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPlace(int place, TransactionManager tm_ = null)
		{
			RepairRemoveByPlaceData(place, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPlaceAsync(int place, TransactionManager tm_ = null)
		{
			RepairRemoveByPlaceData(place, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByPlaceData(int place, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `Place` = @Place";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Place", place, MySqlDbType.Int32));
		}
		#endregion // RemoveByPlace
		#region RemoveByAmount
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "amount">金额（值*100000）</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByAmount(long amount, TransactionManager tm_ = null)
		{
			RepairRemoveByAmountData(amount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByAmountAsync(long amount, TransactionManager tm_ = null)
		{
			RepairRemoveByAmountData(amount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByAmountData(long amount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `Amount` = @Amount";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Amount", amount, MySqlDbType.Int64));
		}
		#endregion // RemoveByAmount
		#region RemoveByIsSurprise
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "isSurprise">是否为惊喜奖励</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByIsSurprise(int isSurprise, TransactionManager tm_ = null)
		{
			RepairRemoveByIsSurpriseData(isSurprise, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByIsSurpriseAsync(int isSurprise, TransactionManager tm_ = null)
		{
			RepairRemoveByIsSurpriseData(isSurprise, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByIsSurpriseData(int isSurprise, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `IsSurprise` = @IsSurprise";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IsSurprise", isSurprise, MySqlDbType.Int32));
		}
		#endregion // RemoveByIsSurprise
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
		public int Put(Bs_bet_orderEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(Bs_bet_orderEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(Bs_bet_orderEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `BetOrderID` = @BetOrderID, `OrderID` = @OrderID, `Bet` = @Bet, `BetDouble` = @BetDouble, `Multiple` = @Multiple, `Place` = @Place, `Amount` = @Amount, `IsSurprise` = @IsSurprise, `Status` = @Status WHERE `BetOrderID` = @BetOrderID_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetOrderID", item.BetOrderID, MySqlDbType.VarChar),
				Database.CreateInParameter("@OrderID", item.OrderID, MySqlDbType.VarChar),
				Database.CreateInParameter("@Bet", item.Bet, MySqlDbType.Int64),
				Database.CreateInParameter("@BetDouble", item.BetDouble, MySqlDbType.Int32),
				Database.CreateInParameter("@Multiple", item.Multiple, MySqlDbType.Int32),
				Database.CreateInParameter("@Place", item.Place, MySqlDbType.Int32),
				Database.CreateInParameter("@Amount", item.Amount, MySqlDbType.Int64),
				Database.CreateInParameter("@IsSurprise", item.IsSurprise, MySqlDbType.Int32),
				Database.CreateInParameter("@Status", item.Status, MySqlDbType.Int32),
				Database.CreateInParameter("@BetOrderID_Original", item.HasOriginal ? item.OriginalBetOrderID : item.BetOrderID, MySqlDbType.VarChar),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<Bs_bet_orderEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<Bs_bet_orderEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "betOrderID">下注订单编号Key</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string betOrderID, string set_, params object[] values_)
		{
			return Put(set_, "`BetOrderID` = @BetOrderID", ConcatValues(values_, betOrderID));
		}
		public async Task<int> PutByPKAsync(string betOrderID, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`BetOrderID` = @BetOrderID", ConcatValues(values_, betOrderID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "betOrderID">下注订单编号Key</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string betOrderID, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`BetOrderID` = @BetOrderID", tm_, ConcatValues(values_, betOrderID));
		}
		public async Task<int> PutByPKAsync(string betOrderID, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`BetOrderID` = @BetOrderID", tm_, ConcatValues(values_, betOrderID));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "betOrderID">下注订单编号Key</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(string betOrderID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@BetOrderID", betOrderID, MySqlDbType.VarChar),
	        };
			return Put(set_, "`BetOrderID` = @BetOrderID", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(string betOrderID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@BetOrderID", betOrderID, MySqlDbType.VarChar),
	        };
			return await PutAsync(set_, "`BetOrderID` = @BetOrderID", ConcatParameters(paras_, newParas_), tm_);
		}
		#endregion // PutByPK
		
		#region PutXXX
		#region PutOrderID
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "betOrderID">下注订单编号Key</param>
		/// /// <param name = "orderID">主订单编号GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOrderIDByPK(string betOrderID, string orderID, TransactionManager tm_ = null)
		{
			RepairPutOrderIDByPKData(betOrderID, orderID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutOrderIDByPKAsync(string betOrderID, string orderID, TransactionManager tm_ = null)
		{
			RepairPutOrderIDByPKData(betOrderID, orderID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutOrderIDByPKData(string betOrderID, string orderID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `OrderID` = @OrderID  WHERE `BetOrderID` = @BetOrderID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar),
				Database.CreateInParameter("@BetOrderID", betOrderID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "orderID">主订单编号GUID</param>
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
		#region PutBet
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "betOrderID">下注订单编号Key</param>
		/// /// <param name = "bet">赌注（值*100000）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBetByPK(string betOrderID, long bet, TransactionManager tm_ = null)
		{
			RepairPutBetByPKData(betOrderID, bet, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutBetByPKAsync(string betOrderID, long bet, TransactionManager tm_ = null)
		{
			RepairPutBetByPKData(betOrderID, bet, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutBetByPKData(string betOrderID, long bet, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Bet` = @Bet  WHERE `BetOrderID` = @BetOrderID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Bet", bet, MySqlDbType.Int64),
				Database.CreateInParameter("@BetOrderID", betOrderID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "bet">赌注（值*100000）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBet(long bet, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Bet` = @Bet";
			var parameter_ = Database.CreateInParameter("@Bet", bet, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutBetAsync(long bet, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Bet` = @Bet";
			var parameter_ = Database.CreateInParameter("@Bet", bet, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutBet
		#region PutBetDouble
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "betOrderID">下注订单编号Key</param>
		/// /// <param name = "betDouble">赌注加倍数（值*100）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBetDoubleByPK(string betOrderID, int betDouble, TransactionManager tm_ = null)
		{
			RepairPutBetDoubleByPKData(betOrderID, betDouble, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutBetDoubleByPKAsync(string betOrderID, int betDouble, TransactionManager tm_ = null)
		{
			RepairPutBetDoubleByPKData(betOrderID, betDouble, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutBetDoubleByPKData(string betOrderID, int betDouble, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `BetDouble` = @BetDouble  WHERE `BetOrderID` = @BetOrderID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetDouble", betDouble, MySqlDbType.Int32),
				Database.CreateInParameter("@BetOrderID", betOrderID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "betDouble">赌注加倍数（值*100）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutBetDouble(int betDouble, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `BetDouble` = @BetDouble";
			var parameter_ = Database.CreateInParameter("@BetDouble", betDouble, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutBetDoubleAsync(int betDouble, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `BetDouble` = @BetDouble";
			var parameter_ = Database.CreateInParameter("@BetDouble", betDouble, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutBetDouble
		#region PutMultiple
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "betOrderID">下注订单编号Key</param>
		/// /// <param name = "multiple">位置倍数（值*100）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutMultipleByPK(string betOrderID, int multiple, TransactionManager tm_ = null)
		{
			RepairPutMultipleByPKData(betOrderID, multiple, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutMultipleByPKAsync(string betOrderID, int multiple, TransactionManager tm_ = null)
		{
			RepairPutMultipleByPKData(betOrderID, multiple, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutMultipleByPKData(string betOrderID, int multiple, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Multiple` = @Multiple  WHERE `BetOrderID` = @BetOrderID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Multiple", multiple, MySqlDbType.Int32),
				Database.CreateInParameter("@BetOrderID", betOrderID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "multiple">位置倍数（值*100）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutMultiple(int multiple, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Multiple` = @Multiple";
			var parameter_ = Database.CreateInParameter("@Multiple", multiple, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutMultipleAsync(int multiple, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Multiple` = @Multiple";
			var parameter_ = Database.CreateInParameter("@Multiple", multiple, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutMultiple
		#region PutPlace
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "betOrderID">下注订单编号Key</param>
		/// /// <param name = "place">位置</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPlaceByPK(string betOrderID, int place, TransactionManager tm_ = null)
		{
			RepairPutPlaceByPKData(betOrderID, place, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutPlaceByPKAsync(string betOrderID, int place, TransactionManager tm_ = null)
		{
			RepairPutPlaceByPKData(betOrderID, place, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutPlaceByPKData(string betOrderID, int place, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Place` = @Place  WHERE `BetOrderID` = @BetOrderID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Place", place, MySqlDbType.Int32),
				Database.CreateInParameter("@BetOrderID", betOrderID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "place">位置</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPlace(int place, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Place` = @Place";
			var parameter_ = Database.CreateInParameter("@Place", place, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutPlaceAsync(int place, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Place` = @Place";
			var parameter_ = Database.CreateInParameter("@Place", place, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutPlace
		#region PutAmount
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "betOrderID">下注订单编号Key</param>
		/// /// <param name = "amount">金额（值*100000）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutAmountByPK(string betOrderID, long amount, TransactionManager tm_ = null)
		{
			RepairPutAmountByPKData(betOrderID, amount, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAmountByPKAsync(string betOrderID, long amount, TransactionManager tm_ = null)
		{
			RepairPutAmountByPKData(betOrderID, amount, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutAmountByPKData(string betOrderID, long amount, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Amount` = @Amount  WHERE `BetOrderID` = @BetOrderID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Amount", amount, MySqlDbType.Int64),
				Database.CreateInParameter("@BetOrderID", betOrderID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "amount">金额（值*100000）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutAmount(long amount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Amount` = @Amount";
			var parameter_ = Database.CreateInParameter("@Amount", amount, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutAmountAsync(long amount, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Amount` = @Amount";
			var parameter_ = Database.CreateInParameter("@Amount", amount, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutAmount
		#region PutIsSurprise
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "betOrderID">下注订单编号Key</param>
		/// /// <param name = "isSurprise">是否为惊喜奖励</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutIsSurpriseByPK(string betOrderID, int isSurprise, TransactionManager tm_ = null)
		{
			RepairPutIsSurpriseByPKData(betOrderID, isSurprise, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutIsSurpriseByPKAsync(string betOrderID, int isSurprise, TransactionManager tm_ = null)
		{
			RepairPutIsSurpriseByPKData(betOrderID, isSurprise, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutIsSurpriseByPKData(string betOrderID, int isSurprise, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `IsSurprise` = @IsSurprise  WHERE `BetOrderID` = @BetOrderID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@IsSurprise", isSurprise, MySqlDbType.Int32),
				Database.CreateInParameter("@BetOrderID", betOrderID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "isSurprise">是否为惊喜奖励</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutIsSurprise(int isSurprise, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `IsSurprise` = @IsSurprise";
			var parameter_ = Database.CreateInParameter("@IsSurprise", isSurprise, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutIsSurpriseAsync(int isSurprise, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `IsSurprise` = @IsSurprise";
			var parameter_ = Database.CreateInParameter("@IsSurprise", isSurprise, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutIsSurprise
		#region PutStatus
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "betOrderID">下注订单编号Key</param>
		/// /// <param name = "status">状态（0-无效1-有效）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutStatusByPK(string betOrderID, int status, TransactionManager tm_ = null)
		{
			RepairPutStatusByPKData(betOrderID, status, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutStatusByPKAsync(string betOrderID, int status, TransactionManager tm_ = null)
		{
			RepairPutStatusByPKData(betOrderID, status, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutStatusByPKData(string betOrderID, int status, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Status` = @Status  WHERE `BetOrderID` = @BetOrderID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Status", status, MySqlDbType.Int32),
				Database.CreateInParameter("@BetOrderID", betOrderID, MySqlDbType.VarChar),
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
		/// /// <param name = "betOrderID">下注订单编号Key</param>
		/// /// <param name = "recDate">创建时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRecDateByPK(string betOrderID, DateTime recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(betOrderID, recDate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutRecDateByPKAsync(string betOrderID, DateTime recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(betOrderID, recDate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutRecDateByPKData(string betOrderID, DateTime recDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `RecDate` = @RecDate  WHERE `BetOrderID` = @BetOrderID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime),
				Database.CreateInParameter("@BetOrderID", betOrderID, MySqlDbType.VarChar),
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
		public bool Set(Bs_bet_orderEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.BetOrderID) == null)
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
		public async Task<bool> SetAsync(Bs_bet_orderEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.BetOrderID) == null)
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
		/// /// <param name = "betOrderID">下注订单编号Key</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public Bs_bet_orderEO GetByPK(string betOrderID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(betOrderID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, Bs_bet_orderEO.MapDataReader);
		}
		public async Task<Bs_bet_orderEO> GetByPKAsync(string betOrderID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(betOrderID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Bs_bet_orderEO.MapDataReader);
		}
		private void RepairGetByPKData(string betOrderID, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`BetOrderID` = @BetOrderID", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetOrderID", betOrderID, MySqlDbType.VarChar),
			};
		}
		#endregion // GetByPK
		
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 OrderID（字段）
		/// </summary>
		/// /// <param name = "betOrderID">下注订单编号Key</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetOrderIDByPK(string betOrderID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetOrderID", betOrderID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`OrderID`", "`BetOrderID` = @BetOrderID", paras_, tm_);
		}
		public async Task<string> GetOrderIDByPKAsync(string betOrderID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetOrderID", betOrderID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`OrderID`", "`BetOrderID` = @BetOrderID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Bet（字段）
		/// </summary>
		/// /// <param name = "betOrderID">下注订单编号Key</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetBetByPK(string betOrderID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetOrderID", betOrderID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`Bet`", "`BetOrderID` = @BetOrderID", paras_, tm_);
		}
		public async Task<long> GetBetByPKAsync(string betOrderID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetOrderID", betOrderID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`Bet`", "`BetOrderID` = @BetOrderID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 BetDouble（字段）
		/// </summary>
		/// /// <param name = "betOrderID">下注订单编号Key</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetBetDoubleByPK(string betOrderID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetOrderID", betOrderID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`BetDouble`", "`BetOrderID` = @BetOrderID", paras_, tm_);
		}
		public async Task<int> GetBetDoubleByPKAsync(string betOrderID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetOrderID", betOrderID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`BetDouble`", "`BetOrderID` = @BetOrderID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Multiple（字段）
		/// </summary>
		/// /// <param name = "betOrderID">下注订单编号Key</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetMultipleByPK(string betOrderID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetOrderID", betOrderID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`Multiple`", "`BetOrderID` = @BetOrderID", paras_, tm_);
		}
		public async Task<int> GetMultipleByPKAsync(string betOrderID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetOrderID", betOrderID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`Multiple`", "`BetOrderID` = @BetOrderID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Place（字段）
		/// </summary>
		/// /// <param name = "betOrderID">下注订单编号Key</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetPlaceByPK(string betOrderID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetOrderID", betOrderID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`Place`", "`BetOrderID` = @BetOrderID", paras_, tm_);
		}
		public async Task<int> GetPlaceByPKAsync(string betOrderID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetOrderID", betOrderID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`Place`", "`BetOrderID` = @BetOrderID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Amount（字段）
		/// </summary>
		/// /// <param name = "betOrderID">下注订单编号Key</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetAmountByPK(string betOrderID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetOrderID", betOrderID, MySqlDbType.VarChar),
			};
			return (long)GetScalar("`Amount`", "`BetOrderID` = @BetOrderID", paras_, tm_);
		}
		public async Task<long> GetAmountByPKAsync(string betOrderID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetOrderID", betOrderID, MySqlDbType.VarChar),
			};
			return (long)await GetScalarAsync("`Amount`", "`BetOrderID` = @BetOrderID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 IsSurprise（字段）
		/// </summary>
		/// /// <param name = "betOrderID">下注订单编号Key</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetIsSurpriseByPK(string betOrderID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetOrderID", betOrderID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`IsSurprise`", "`BetOrderID` = @BetOrderID", paras_, tm_);
		}
		public async Task<int> GetIsSurpriseByPKAsync(string betOrderID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetOrderID", betOrderID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`IsSurprise`", "`BetOrderID` = @BetOrderID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Status（字段）
		/// </summary>
		/// /// <param name = "betOrderID">下注订单编号Key</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetStatusByPK(string betOrderID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetOrderID", betOrderID, MySqlDbType.VarChar),
			};
			return (int)GetScalar("`Status`", "`BetOrderID` = @BetOrderID", paras_, tm_);
		}
		public async Task<int> GetStatusByPKAsync(string betOrderID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetOrderID", betOrderID, MySqlDbType.VarChar),
			};
			return (int)await GetScalarAsync("`Status`", "`BetOrderID` = @BetOrderID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 RecDate（字段）
		/// </summary>
		/// /// <param name = "betOrderID">下注订单编号Key</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime GetRecDateByPK(string betOrderID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetOrderID", betOrderID, MySqlDbType.VarChar),
			};
			return (DateTime)GetScalar("`RecDate`", "`BetOrderID` = @BetOrderID", paras_, tm_);
		}
		public async Task<DateTime> GetRecDateByPKAsync(string betOrderID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@BetOrderID", betOrderID, MySqlDbType.VarChar),
			};
			return (DateTime)await GetScalarAsync("`RecDate`", "`BetOrderID` = @BetOrderID", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByOrderID
		
		/// <summary>
		/// 按 OrderID（字段） 查询
		/// </summary>
		/// /// <param name = "orderID">主订单编号GUID</param>
		/// <return>实体对象集合</return>
		public List<Bs_bet_orderEO> GetByOrderID(string orderID)
		{
			return GetByOrderID(orderID, 0, string.Empty, null);
		}
		public async Task<List<Bs_bet_orderEO>> GetByOrderIDAsync(string orderID)
		{
			return await GetByOrderIDAsync(orderID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OrderID（字段） 查询
		/// </summary>
		/// /// <param name = "orderID">主订单编号GUID</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_bet_orderEO> GetByOrderID(string orderID, TransactionManager tm_)
		{
			return GetByOrderID(orderID, 0, string.Empty, tm_);
		}
		public async Task<List<Bs_bet_orderEO>> GetByOrderIDAsync(string orderID, TransactionManager tm_)
		{
			return await GetByOrderIDAsync(orderID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OrderID（字段） 查询
		/// </summary>
		/// /// <param name = "orderID">主订单编号GUID</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Bs_bet_orderEO> GetByOrderID(string orderID, int top_)
		{
			return GetByOrderID(orderID, top_, string.Empty, null);
		}
		public async Task<List<Bs_bet_orderEO>> GetByOrderIDAsync(string orderID, int top_)
		{
			return await GetByOrderIDAsync(orderID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OrderID（字段） 查询
		/// </summary>
		/// /// <param name = "orderID">主订单编号GUID</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_bet_orderEO> GetByOrderID(string orderID, int top_, TransactionManager tm_)
		{
			return GetByOrderID(orderID, top_, string.Empty, tm_);
		}
		public async Task<List<Bs_bet_orderEO>> GetByOrderIDAsync(string orderID, int top_, TransactionManager tm_)
		{
			return await GetByOrderIDAsync(orderID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OrderID（字段） 查询
		/// </summary>
		/// /// <param name = "orderID">主订单编号GUID</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Bs_bet_orderEO> GetByOrderID(string orderID, string sort_)
		{
			return GetByOrderID(orderID, 0, sort_, null);
		}
		public async Task<List<Bs_bet_orderEO>> GetByOrderIDAsync(string orderID, string sort_)
		{
			return await GetByOrderIDAsync(orderID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 OrderID（字段） 查询
		/// </summary>
		/// /// <param name = "orderID">主订单编号GUID</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_bet_orderEO> GetByOrderID(string orderID, string sort_, TransactionManager tm_)
		{
			return GetByOrderID(orderID, 0, sort_, tm_);
		}
		public async Task<List<Bs_bet_orderEO>> GetByOrderIDAsync(string orderID, string sort_, TransactionManager tm_)
		{
			return await GetByOrderIDAsync(orderID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 OrderID（字段） 查询
		/// </summary>
		/// /// <param name = "orderID">主订单编号GUID</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_bet_orderEO> GetByOrderID(string orderID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OrderID` = @OrderID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Bs_bet_orderEO.MapDataReader);
		}
		public async Task<List<Bs_bet_orderEO>> GetByOrderIDAsync(string orderID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OrderID` = @OrderID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OrderID", orderID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Bs_bet_orderEO.MapDataReader);
		}
		#endregion // GetByOrderID
		#region GetByBet
		
		/// <summary>
		/// 按 Bet（字段） 查询
		/// </summary>
		/// /// <param name = "bet">赌注（值*100000）</param>
		/// <return>实体对象集合</return>
		public List<Bs_bet_orderEO> GetByBet(long bet)
		{
			return GetByBet(bet, 0, string.Empty, null);
		}
		public async Task<List<Bs_bet_orderEO>> GetByBetAsync(long bet)
		{
			return await GetByBetAsync(bet, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Bet（字段） 查询
		/// </summary>
		/// /// <param name = "bet">赌注（值*100000）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_bet_orderEO> GetByBet(long bet, TransactionManager tm_)
		{
			return GetByBet(bet, 0, string.Empty, tm_);
		}
		public async Task<List<Bs_bet_orderEO>> GetByBetAsync(long bet, TransactionManager tm_)
		{
			return await GetByBetAsync(bet, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Bet（字段） 查询
		/// </summary>
		/// /// <param name = "bet">赌注（值*100000）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Bs_bet_orderEO> GetByBet(long bet, int top_)
		{
			return GetByBet(bet, top_, string.Empty, null);
		}
		public async Task<List<Bs_bet_orderEO>> GetByBetAsync(long bet, int top_)
		{
			return await GetByBetAsync(bet, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Bet（字段） 查询
		/// </summary>
		/// /// <param name = "bet">赌注（值*100000）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_bet_orderEO> GetByBet(long bet, int top_, TransactionManager tm_)
		{
			return GetByBet(bet, top_, string.Empty, tm_);
		}
		public async Task<List<Bs_bet_orderEO>> GetByBetAsync(long bet, int top_, TransactionManager tm_)
		{
			return await GetByBetAsync(bet, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Bet（字段） 查询
		/// </summary>
		/// /// <param name = "bet">赌注（值*100000）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Bs_bet_orderEO> GetByBet(long bet, string sort_)
		{
			return GetByBet(bet, 0, sort_, null);
		}
		public async Task<List<Bs_bet_orderEO>> GetByBetAsync(long bet, string sort_)
		{
			return await GetByBetAsync(bet, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Bet（字段） 查询
		/// </summary>
		/// /// <param name = "bet">赌注（值*100000）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_bet_orderEO> GetByBet(long bet, string sort_, TransactionManager tm_)
		{
			return GetByBet(bet, 0, sort_, tm_);
		}
		public async Task<List<Bs_bet_orderEO>> GetByBetAsync(long bet, string sort_, TransactionManager tm_)
		{
			return await GetByBetAsync(bet, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Bet（字段） 查询
		/// </summary>
		/// /// <param name = "bet">赌注（值*100000）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_bet_orderEO> GetByBet(long bet, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Bet` = @Bet", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Bet", bet, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Bs_bet_orderEO.MapDataReader);
		}
		public async Task<List<Bs_bet_orderEO>> GetByBetAsync(long bet, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Bet` = @Bet", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Bet", bet, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Bs_bet_orderEO.MapDataReader);
		}
		#endregion // GetByBet
		#region GetByBetDouble
		
		/// <summary>
		/// 按 BetDouble（字段） 查询
		/// </summary>
		/// /// <param name = "betDouble">赌注加倍数（值*100）</param>
		/// <return>实体对象集合</return>
		public List<Bs_bet_orderEO> GetByBetDouble(int betDouble)
		{
			return GetByBetDouble(betDouble, 0, string.Empty, null);
		}
		public async Task<List<Bs_bet_orderEO>> GetByBetDoubleAsync(int betDouble)
		{
			return await GetByBetDoubleAsync(betDouble, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BetDouble（字段） 查询
		/// </summary>
		/// /// <param name = "betDouble">赌注加倍数（值*100）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_bet_orderEO> GetByBetDouble(int betDouble, TransactionManager tm_)
		{
			return GetByBetDouble(betDouble, 0, string.Empty, tm_);
		}
		public async Task<List<Bs_bet_orderEO>> GetByBetDoubleAsync(int betDouble, TransactionManager tm_)
		{
			return await GetByBetDoubleAsync(betDouble, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BetDouble（字段） 查询
		/// </summary>
		/// /// <param name = "betDouble">赌注加倍数（值*100）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Bs_bet_orderEO> GetByBetDouble(int betDouble, int top_)
		{
			return GetByBetDouble(betDouble, top_, string.Empty, null);
		}
		public async Task<List<Bs_bet_orderEO>> GetByBetDoubleAsync(int betDouble, int top_)
		{
			return await GetByBetDoubleAsync(betDouble, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 BetDouble（字段） 查询
		/// </summary>
		/// /// <param name = "betDouble">赌注加倍数（值*100）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_bet_orderEO> GetByBetDouble(int betDouble, int top_, TransactionManager tm_)
		{
			return GetByBetDouble(betDouble, top_, string.Empty, tm_);
		}
		public async Task<List<Bs_bet_orderEO>> GetByBetDoubleAsync(int betDouble, int top_, TransactionManager tm_)
		{
			return await GetByBetDoubleAsync(betDouble, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 BetDouble（字段） 查询
		/// </summary>
		/// /// <param name = "betDouble">赌注加倍数（值*100）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Bs_bet_orderEO> GetByBetDouble(int betDouble, string sort_)
		{
			return GetByBetDouble(betDouble, 0, sort_, null);
		}
		public async Task<List<Bs_bet_orderEO>> GetByBetDoubleAsync(int betDouble, string sort_)
		{
			return await GetByBetDoubleAsync(betDouble, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 BetDouble（字段） 查询
		/// </summary>
		/// /// <param name = "betDouble">赌注加倍数（值*100）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_bet_orderEO> GetByBetDouble(int betDouble, string sort_, TransactionManager tm_)
		{
			return GetByBetDouble(betDouble, 0, sort_, tm_);
		}
		public async Task<List<Bs_bet_orderEO>> GetByBetDoubleAsync(int betDouble, string sort_, TransactionManager tm_)
		{
			return await GetByBetDoubleAsync(betDouble, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 BetDouble（字段） 查询
		/// </summary>
		/// /// <param name = "betDouble">赌注加倍数（值*100）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_bet_orderEO> GetByBetDouble(int betDouble, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BetDouble` = @BetDouble", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BetDouble", betDouble, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Bs_bet_orderEO.MapDataReader);
		}
		public async Task<List<Bs_bet_orderEO>> GetByBetDoubleAsync(int betDouble, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`BetDouble` = @BetDouble", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@BetDouble", betDouble, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Bs_bet_orderEO.MapDataReader);
		}
		#endregion // GetByBetDouble
		#region GetByMultiple
		
		/// <summary>
		/// 按 Multiple（字段） 查询
		/// </summary>
		/// /// <param name = "multiple">位置倍数（值*100）</param>
		/// <return>实体对象集合</return>
		public List<Bs_bet_orderEO> GetByMultiple(int multiple)
		{
			return GetByMultiple(multiple, 0, string.Empty, null);
		}
		public async Task<List<Bs_bet_orderEO>> GetByMultipleAsync(int multiple)
		{
			return await GetByMultipleAsync(multiple, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Multiple（字段） 查询
		/// </summary>
		/// /// <param name = "multiple">位置倍数（值*100）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_bet_orderEO> GetByMultiple(int multiple, TransactionManager tm_)
		{
			return GetByMultiple(multiple, 0, string.Empty, tm_);
		}
		public async Task<List<Bs_bet_orderEO>> GetByMultipleAsync(int multiple, TransactionManager tm_)
		{
			return await GetByMultipleAsync(multiple, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Multiple（字段） 查询
		/// </summary>
		/// /// <param name = "multiple">位置倍数（值*100）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Bs_bet_orderEO> GetByMultiple(int multiple, int top_)
		{
			return GetByMultiple(multiple, top_, string.Empty, null);
		}
		public async Task<List<Bs_bet_orderEO>> GetByMultipleAsync(int multiple, int top_)
		{
			return await GetByMultipleAsync(multiple, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Multiple（字段） 查询
		/// </summary>
		/// /// <param name = "multiple">位置倍数（值*100）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_bet_orderEO> GetByMultiple(int multiple, int top_, TransactionManager tm_)
		{
			return GetByMultiple(multiple, top_, string.Empty, tm_);
		}
		public async Task<List<Bs_bet_orderEO>> GetByMultipleAsync(int multiple, int top_, TransactionManager tm_)
		{
			return await GetByMultipleAsync(multiple, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Multiple（字段） 查询
		/// </summary>
		/// /// <param name = "multiple">位置倍数（值*100）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Bs_bet_orderEO> GetByMultiple(int multiple, string sort_)
		{
			return GetByMultiple(multiple, 0, sort_, null);
		}
		public async Task<List<Bs_bet_orderEO>> GetByMultipleAsync(int multiple, string sort_)
		{
			return await GetByMultipleAsync(multiple, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Multiple（字段） 查询
		/// </summary>
		/// /// <param name = "multiple">位置倍数（值*100）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_bet_orderEO> GetByMultiple(int multiple, string sort_, TransactionManager tm_)
		{
			return GetByMultiple(multiple, 0, sort_, tm_);
		}
		public async Task<List<Bs_bet_orderEO>> GetByMultipleAsync(int multiple, string sort_, TransactionManager tm_)
		{
			return await GetByMultipleAsync(multiple, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Multiple（字段） 查询
		/// </summary>
		/// /// <param name = "multiple">位置倍数（值*100）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_bet_orderEO> GetByMultiple(int multiple, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Multiple` = @Multiple", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Multiple", multiple, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Bs_bet_orderEO.MapDataReader);
		}
		public async Task<List<Bs_bet_orderEO>> GetByMultipleAsync(int multiple, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Multiple` = @Multiple", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Multiple", multiple, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Bs_bet_orderEO.MapDataReader);
		}
		#endregion // GetByMultiple
		#region GetByPlace
		
		/// <summary>
		/// 按 Place（字段） 查询
		/// </summary>
		/// /// <param name = "place">位置</param>
		/// <return>实体对象集合</return>
		public List<Bs_bet_orderEO> GetByPlace(int place)
		{
			return GetByPlace(place, 0, string.Empty, null);
		}
		public async Task<List<Bs_bet_orderEO>> GetByPlaceAsync(int place)
		{
			return await GetByPlaceAsync(place, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Place（字段） 查询
		/// </summary>
		/// /// <param name = "place">位置</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_bet_orderEO> GetByPlace(int place, TransactionManager tm_)
		{
			return GetByPlace(place, 0, string.Empty, tm_);
		}
		public async Task<List<Bs_bet_orderEO>> GetByPlaceAsync(int place, TransactionManager tm_)
		{
			return await GetByPlaceAsync(place, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Place（字段） 查询
		/// </summary>
		/// /// <param name = "place">位置</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Bs_bet_orderEO> GetByPlace(int place, int top_)
		{
			return GetByPlace(place, top_, string.Empty, null);
		}
		public async Task<List<Bs_bet_orderEO>> GetByPlaceAsync(int place, int top_)
		{
			return await GetByPlaceAsync(place, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Place（字段） 查询
		/// </summary>
		/// /// <param name = "place">位置</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_bet_orderEO> GetByPlace(int place, int top_, TransactionManager tm_)
		{
			return GetByPlace(place, top_, string.Empty, tm_);
		}
		public async Task<List<Bs_bet_orderEO>> GetByPlaceAsync(int place, int top_, TransactionManager tm_)
		{
			return await GetByPlaceAsync(place, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Place（字段） 查询
		/// </summary>
		/// /// <param name = "place">位置</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Bs_bet_orderEO> GetByPlace(int place, string sort_)
		{
			return GetByPlace(place, 0, sort_, null);
		}
		public async Task<List<Bs_bet_orderEO>> GetByPlaceAsync(int place, string sort_)
		{
			return await GetByPlaceAsync(place, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Place（字段） 查询
		/// </summary>
		/// /// <param name = "place">位置</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_bet_orderEO> GetByPlace(int place, string sort_, TransactionManager tm_)
		{
			return GetByPlace(place, 0, sort_, tm_);
		}
		public async Task<List<Bs_bet_orderEO>> GetByPlaceAsync(int place, string sort_, TransactionManager tm_)
		{
			return await GetByPlaceAsync(place, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Place（字段） 查询
		/// </summary>
		/// /// <param name = "place">位置</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_bet_orderEO> GetByPlace(int place, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Place` = @Place", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Place", place, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Bs_bet_orderEO.MapDataReader);
		}
		public async Task<List<Bs_bet_orderEO>> GetByPlaceAsync(int place, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Place` = @Place", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Place", place, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Bs_bet_orderEO.MapDataReader);
		}
		#endregion // GetByPlace
		#region GetByAmount
		
		/// <summary>
		/// 按 Amount（字段） 查询
		/// </summary>
		/// /// <param name = "amount">金额（值*100000）</param>
		/// <return>实体对象集合</return>
		public List<Bs_bet_orderEO> GetByAmount(long amount)
		{
			return GetByAmount(amount, 0, string.Empty, null);
		}
		public async Task<List<Bs_bet_orderEO>> GetByAmountAsync(long amount)
		{
			return await GetByAmountAsync(amount, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Amount（字段） 查询
		/// </summary>
		/// /// <param name = "amount">金额（值*100000）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_bet_orderEO> GetByAmount(long amount, TransactionManager tm_)
		{
			return GetByAmount(amount, 0, string.Empty, tm_);
		}
		public async Task<List<Bs_bet_orderEO>> GetByAmountAsync(long amount, TransactionManager tm_)
		{
			return await GetByAmountAsync(amount, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Amount（字段） 查询
		/// </summary>
		/// /// <param name = "amount">金额（值*100000）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Bs_bet_orderEO> GetByAmount(long amount, int top_)
		{
			return GetByAmount(amount, top_, string.Empty, null);
		}
		public async Task<List<Bs_bet_orderEO>> GetByAmountAsync(long amount, int top_)
		{
			return await GetByAmountAsync(amount, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Amount（字段） 查询
		/// </summary>
		/// /// <param name = "amount">金额（值*100000）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_bet_orderEO> GetByAmount(long amount, int top_, TransactionManager tm_)
		{
			return GetByAmount(amount, top_, string.Empty, tm_);
		}
		public async Task<List<Bs_bet_orderEO>> GetByAmountAsync(long amount, int top_, TransactionManager tm_)
		{
			return await GetByAmountAsync(amount, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Amount（字段） 查询
		/// </summary>
		/// /// <param name = "amount">金额（值*100000）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Bs_bet_orderEO> GetByAmount(long amount, string sort_)
		{
			return GetByAmount(amount, 0, sort_, null);
		}
		public async Task<List<Bs_bet_orderEO>> GetByAmountAsync(long amount, string sort_)
		{
			return await GetByAmountAsync(amount, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Amount（字段） 查询
		/// </summary>
		/// /// <param name = "amount">金额（值*100000）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_bet_orderEO> GetByAmount(long amount, string sort_, TransactionManager tm_)
		{
			return GetByAmount(amount, 0, sort_, tm_);
		}
		public async Task<List<Bs_bet_orderEO>> GetByAmountAsync(long amount, string sort_, TransactionManager tm_)
		{
			return await GetByAmountAsync(amount, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Amount（字段） 查询
		/// </summary>
		/// /// <param name = "amount">金额（值*100000）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_bet_orderEO> GetByAmount(long amount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Amount` = @Amount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Amount", amount, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Bs_bet_orderEO.MapDataReader);
		}
		public async Task<List<Bs_bet_orderEO>> GetByAmountAsync(long amount, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Amount` = @Amount", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Amount", amount, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Bs_bet_orderEO.MapDataReader);
		}
		#endregion // GetByAmount
		#region GetByIsSurprise
		
		/// <summary>
		/// 按 IsSurprise（字段） 查询
		/// </summary>
		/// /// <param name = "isSurprise">是否为惊喜奖励</param>
		/// <return>实体对象集合</return>
		public List<Bs_bet_orderEO> GetByIsSurprise(int isSurprise)
		{
			return GetByIsSurprise(isSurprise, 0, string.Empty, null);
		}
		public async Task<List<Bs_bet_orderEO>> GetByIsSurpriseAsync(int isSurprise)
		{
			return await GetByIsSurpriseAsync(isSurprise, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 IsSurprise（字段） 查询
		/// </summary>
		/// /// <param name = "isSurprise">是否为惊喜奖励</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_bet_orderEO> GetByIsSurprise(int isSurprise, TransactionManager tm_)
		{
			return GetByIsSurprise(isSurprise, 0, string.Empty, tm_);
		}
		public async Task<List<Bs_bet_orderEO>> GetByIsSurpriseAsync(int isSurprise, TransactionManager tm_)
		{
			return await GetByIsSurpriseAsync(isSurprise, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IsSurprise（字段） 查询
		/// </summary>
		/// /// <param name = "isSurprise">是否为惊喜奖励</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Bs_bet_orderEO> GetByIsSurprise(int isSurprise, int top_)
		{
			return GetByIsSurprise(isSurprise, top_, string.Empty, null);
		}
		public async Task<List<Bs_bet_orderEO>> GetByIsSurpriseAsync(int isSurprise, int top_)
		{
			return await GetByIsSurpriseAsync(isSurprise, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 IsSurprise（字段） 查询
		/// </summary>
		/// /// <param name = "isSurprise">是否为惊喜奖励</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_bet_orderEO> GetByIsSurprise(int isSurprise, int top_, TransactionManager tm_)
		{
			return GetByIsSurprise(isSurprise, top_, string.Empty, tm_);
		}
		public async Task<List<Bs_bet_orderEO>> GetByIsSurpriseAsync(int isSurprise, int top_, TransactionManager tm_)
		{
			return await GetByIsSurpriseAsync(isSurprise, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IsSurprise（字段） 查询
		/// </summary>
		/// /// <param name = "isSurprise">是否为惊喜奖励</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Bs_bet_orderEO> GetByIsSurprise(int isSurprise, string sort_)
		{
			return GetByIsSurprise(isSurprise, 0, sort_, null);
		}
		public async Task<List<Bs_bet_orderEO>> GetByIsSurpriseAsync(int isSurprise, string sort_)
		{
			return await GetByIsSurpriseAsync(isSurprise, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 IsSurprise（字段） 查询
		/// </summary>
		/// /// <param name = "isSurprise">是否为惊喜奖励</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_bet_orderEO> GetByIsSurprise(int isSurprise, string sort_, TransactionManager tm_)
		{
			return GetByIsSurprise(isSurprise, 0, sort_, tm_);
		}
		public async Task<List<Bs_bet_orderEO>> GetByIsSurpriseAsync(int isSurprise, string sort_, TransactionManager tm_)
		{
			return await GetByIsSurpriseAsync(isSurprise, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 IsSurprise（字段） 查询
		/// </summary>
		/// /// <param name = "isSurprise">是否为惊喜奖励</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_bet_orderEO> GetByIsSurprise(int isSurprise, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`IsSurprise` = @IsSurprise", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IsSurprise", isSurprise, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Bs_bet_orderEO.MapDataReader);
		}
		public async Task<List<Bs_bet_orderEO>> GetByIsSurpriseAsync(int isSurprise, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`IsSurprise` = @IsSurprise", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IsSurprise", isSurprise, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Bs_bet_orderEO.MapDataReader);
		}
		#endregion // GetByIsSurprise
		#region GetByStatus
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态（0-无效1-有效）</param>
		/// <return>实体对象集合</return>
		public List<Bs_bet_orderEO> GetByStatus(int status)
		{
			return GetByStatus(status, 0, string.Empty, null);
		}
		public async Task<List<Bs_bet_orderEO>> GetByStatusAsync(int status)
		{
			return await GetByStatusAsync(status, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态（0-无效1-有效）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_bet_orderEO> GetByStatus(int status, TransactionManager tm_)
		{
			return GetByStatus(status, 0, string.Empty, tm_);
		}
		public async Task<List<Bs_bet_orderEO>> GetByStatusAsync(int status, TransactionManager tm_)
		{
			return await GetByStatusAsync(status, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态（0-无效1-有效）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Bs_bet_orderEO> GetByStatus(int status, int top_)
		{
			return GetByStatus(status, top_, string.Empty, null);
		}
		public async Task<List<Bs_bet_orderEO>> GetByStatusAsync(int status, int top_)
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
		public List<Bs_bet_orderEO> GetByStatus(int status, int top_, TransactionManager tm_)
		{
			return GetByStatus(status, top_, string.Empty, tm_);
		}
		public async Task<List<Bs_bet_orderEO>> GetByStatusAsync(int status, int top_, TransactionManager tm_)
		{
			return await GetByStatusAsync(status, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Status（字段） 查询
		/// </summary>
		/// /// <param name = "status">状态（0-无效1-有效）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Bs_bet_orderEO> GetByStatus(int status, string sort_)
		{
			return GetByStatus(status, 0, sort_, null);
		}
		public async Task<List<Bs_bet_orderEO>> GetByStatusAsync(int status, string sort_)
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
		public List<Bs_bet_orderEO> GetByStatus(int status, string sort_, TransactionManager tm_)
		{
			return GetByStatus(status, 0, sort_, tm_);
		}
		public async Task<List<Bs_bet_orderEO>> GetByStatusAsync(int status, string sort_, TransactionManager tm_)
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
		public List<Bs_bet_orderEO> GetByStatus(int status, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Status` = @Status", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Status", status, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Bs_bet_orderEO.MapDataReader);
		}
		public async Task<List<Bs_bet_orderEO>> GetByStatusAsync(int status, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Status` = @Status", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Status", status, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Bs_bet_orderEO.MapDataReader);
		}
		#endregion // GetByStatus
		#region GetByRecDate
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">创建时间</param>
		/// <return>实体对象集合</return>
		public List<Bs_bet_orderEO> GetByRecDate(DateTime recDate)
		{
			return GetByRecDate(recDate, 0, string.Empty, null);
		}
		public async Task<List<Bs_bet_orderEO>> GetByRecDateAsync(DateTime recDate)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">创建时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_bet_orderEO> GetByRecDate(DateTime recDate, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, string.Empty, tm_);
		}
		public async Task<List<Bs_bet_orderEO>> GetByRecDateAsync(DateTime recDate, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">创建时间</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Bs_bet_orderEO> GetByRecDate(DateTime recDate, int top_)
		{
			return GetByRecDate(recDate, top_, string.Empty, null);
		}
		public async Task<List<Bs_bet_orderEO>> GetByRecDateAsync(DateTime recDate, int top_)
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
		public List<Bs_bet_orderEO> GetByRecDate(DateTime recDate, int top_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, top_, string.Empty, tm_);
		}
		public async Task<List<Bs_bet_orderEO>> GetByRecDateAsync(DateTime recDate, int top_, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">创建时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Bs_bet_orderEO> GetByRecDate(DateTime recDate, string sort_)
		{
			return GetByRecDate(recDate, 0, sort_, null);
		}
		public async Task<List<Bs_bet_orderEO>> GetByRecDateAsync(DateTime recDate, string sort_)
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
		public List<Bs_bet_orderEO> GetByRecDate(DateTime recDate, string sort_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, sort_, tm_);
		}
		public async Task<List<Bs_bet_orderEO>> GetByRecDateAsync(DateTime recDate, string sort_, TransactionManager tm_)
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
		public List<Bs_bet_orderEO> GetByRecDate(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return Database.ExecSqlList(sql_, paras_, tm_, Bs_bet_orderEO.MapDataReader);
		}
		public async Task<List<Bs_bet_orderEO>> GetByRecDateAsync(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Bs_bet_orderEO.MapDataReader);
		}
		#endregion // GetByRecDate
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
