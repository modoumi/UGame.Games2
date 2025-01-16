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
	/// lucky值奖励倍数几率表
	/// 【表 bs_config_lucky 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class Bs_config_luckyEO : IRowMapper<Bs_config_luckyEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public Bs_config_luckyEO()
		{
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
		/// 货币编码
		/// 【主键 varchar(5)】
		/// </summary>
		[DataMember(Order = 2)]
		public string CurrencyID { get; set; }
		/// <summary>
		/// 倍数
		/// 【字段 varchar(255)】
		/// </summary>
		[DataMember(Order = 3)]
		public string MultipList { get; set; }
		/// <summary>
		/// 倍数权重
		/// 【字段 varchar(255)】
		/// </summary>
		[DataMember(Order = 4)]
		public string MultipWeightList { get; set; }
		/// <summary>
		/// lucky奖励次数值
		/// 【字段 varchar(255)】
		/// </summary>
		[DataMember(Order = 5)]
		public string NumList { get; set; }
		/// <summary>
		/// lucky奖励次数值权重
		/// 【字段 varchar(255)】
		/// </summary>
		[DataMember(Order = 6)]
		public string NumWeightList { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public Bs_config_luckyEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static Bs_config_luckyEO MapDataReader(IDataReader reader)
		{
		    Bs_config_luckyEO ret = new Bs_config_luckyEO();
			ret.OperatorID = reader.ToString("OperatorID");
			ret.OriginalOperatorID = ret.OperatorID;
			ret.CurrencyID = reader.ToString("CurrencyID");
			ret.OriginalCurrencyID = ret.CurrencyID;
			ret.MultipList = reader.ToString("MultipList");
			ret.MultipWeightList = reader.ToString("MultipWeightList");
			ret.NumList = reader.ToString("NumList");
			ret.NumWeightList = reader.ToString("NumWeightList");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// lucky值奖励倍数几率表
	/// 【表 bs_config_lucky 的操作类】
	/// </summary>
	[Obsolete]
	public class Bs_config_luckyMO : MySqlTableMO<Bs_config_luckyEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`bs_config_lucky`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public Bs_config_luckyMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public Bs_config_luckyMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public Bs_config_luckyMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(Bs_config_luckyEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(Bs_config_luckyEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(Bs_config_luckyEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`OperatorID`, `CurrencyID`, `MultipList`, `MultipWeightList`, `NumList`, `NumWeightList`) VALUE (@OperatorID, @CurrencyID, @MultipList, @MultipWeightList, @NumList, @NumWeightList);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", item.OperatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", item.CurrencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@MultipList", item.MultipList != null ? item.MultipList : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@MultipWeightList", item.MultipWeightList != null ? item.MultipWeightList : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@NumList", item.NumList != null ? item.NumList : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@NumWeightList", item.NumWeightList != null ? item.NumWeightList : (object)DBNull.Value, MySqlDbType.VarChar),
			};
		}
		public int AddByBatch(IEnumerable<Bs_config_luckyEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<Bs_config_luckyEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<Bs_config_luckyEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`OperatorID`, `CurrencyID`, `MultipList`, `MultipWeightList`, `NumList`, `NumWeightList`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"('{item.OperatorID}','{item.CurrencyID}','{item.MultipList}','{item.MultipWeightList}','{item.NumList}','{item.NumWeightList}'),");
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
		/// /// <param name = "currencyID">货币编码</param>
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
		public int Remove(Bs_config_luckyEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.OperatorID, item.CurrencyID, tm_);
		}
		public async Task<int> RemoveAsync(Bs_config_luckyEO item, TransactionManager tm_ = null)
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
		#region RemoveByMultipList
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "multipList">倍数</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByMultipList(string multipList, TransactionManager tm_ = null)
		{
			RepairRemoveByMultipListData(multipList, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByMultipListAsync(string multipList, TransactionManager tm_ = null)
		{
			RepairRemoveByMultipListData(multipList, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByMultipListData(string multipList, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (multipList != null ? "`MultipList` = @MultipList" : "`MultipList` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (multipList != null)
				paras_.Add(Database.CreateInParameter("@MultipList", multipList, MySqlDbType.VarChar));
		}
		#endregion // RemoveByMultipList
		#region RemoveByMultipWeightList
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "multipWeightList">倍数权重</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByMultipWeightList(string multipWeightList, TransactionManager tm_ = null)
		{
			RepairRemoveByMultipWeightListData(multipWeightList, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByMultipWeightListAsync(string multipWeightList, TransactionManager tm_ = null)
		{
			RepairRemoveByMultipWeightListData(multipWeightList, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByMultipWeightListData(string multipWeightList, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (multipWeightList != null ? "`MultipWeightList` = @MultipWeightList" : "`MultipWeightList` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (multipWeightList != null)
				paras_.Add(Database.CreateInParameter("@MultipWeightList", multipWeightList, MySqlDbType.VarChar));
		}
		#endregion // RemoveByMultipWeightList
		#region RemoveByNumList
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "numList">lucky奖励次数值</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByNumList(string numList, TransactionManager tm_ = null)
		{
			RepairRemoveByNumListData(numList, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByNumListAsync(string numList, TransactionManager tm_ = null)
		{
			RepairRemoveByNumListData(numList, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByNumListData(string numList, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (numList != null ? "`NumList` = @NumList" : "`NumList` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (numList != null)
				paras_.Add(Database.CreateInParameter("@NumList", numList, MySqlDbType.VarChar));
		}
		#endregion // RemoveByNumList
		#region RemoveByNumWeightList
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "numWeightList">lucky奖励次数值权重</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByNumWeightList(string numWeightList, TransactionManager tm_ = null)
		{
			RepairRemoveByNumWeightListData(numWeightList, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByNumWeightListAsync(string numWeightList, TransactionManager tm_ = null)
		{
			RepairRemoveByNumWeightListData(numWeightList, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByNumWeightListData(string numWeightList, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE " + (numWeightList != null ? "`NumWeightList` = @NumWeightList" : "`NumWeightList` IS NULL");
			paras_ = new List<MySqlParameter>();
			if (numWeightList != null)
				paras_.Add(Database.CreateInParameter("@NumWeightList", numWeightList, MySqlDbType.VarChar));
		}
		#endregion // RemoveByNumWeightList
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
		public int Put(Bs_config_luckyEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(Bs_config_luckyEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(Bs_config_luckyEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `OperatorID` = @OperatorID, `CurrencyID` = @CurrencyID, `MultipList` = @MultipList, `MultipWeightList` = @MultipWeightList, `NumList` = @NumList, `NumWeightList` = @NumWeightList WHERE `OperatorID` = @OperatorID_Original AND `CurrencyID` = @CurrencyID_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", item.OperatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", item.CurrencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@MultipList", item.MultipList != null ? item.MultipList : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@MultipWeightList", item.MultipWeightList != null ? item.MultipWeightList : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@NumList", item.NumList != null ? item.NumList : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@NumWeightList", item.NumWeightList != null ? item.NumWeightList : (object)DBNull.Value, MySqlDbType.VarChar),
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
		public int Put(IEnumerable<Bs_config_luckyEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<Bs_config_luckyEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "currencyID">货币编码</param>
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
		/// /// <param name = "currencyID">货币编码</param>
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
		/// /// <param name = "currencyID">货币编码</param>
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
		#region PutMultipList
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码</param>
		/// /// <param name = "multipList">倍数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutMultipListByPK(string operatorID, string currencyID, string multipList, TransactionManager tm_ = null)
		{
			RepairPutMultipListByPKData(operatorID, currencyID, multipList, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutMultipListByPKAsync(string operatorID, string currencyID, string multipList, TransactionManager tm_ = null)
		{
			RepairPutMultipListByPKData(operatorID, currencyID, multipList, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutMultipListByPKData(string operatorID, string currencyID, string multipList, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `MultipList` = @MultipList  WHERE `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MultipList", multipList != null ? multipList : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "multipList">倍数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutMultipList(string multipList, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `MultipList` = @MultipList";
			var parameter_ = Database.CreateInParameter("@MultipList", multipList != null ? multipList : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutMultipListAsync(string multipList, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `MultipList` = @MultipList";
			var parameter_ = Database.CreateInParameter("@MultipList", multipList != null ? multipList : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutMultipList
		#region PutMultipWeightList
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码</param>
		/// /// <param name = "multipWeightList">倍数权重</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutMultipWeightListByPK(string operatorID, string currencyID, string multipWeightList, TransactionManager tm_ = null)
		{
			RepairPutMultipWeightListByPKData(operatorID, currencyID, multipWeightList, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutMultipWeightListByPKAsync(string operatorID, string currencyID, string multipWeightList, TransactionManager tm_ = null)
		{
			RepairPutMultipWeightListByPKData(operatorID, currencyID, multipWeightList, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutMultipWeightListByPKData(string operatorID, string currencyID, string multipWeightList, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `MultipWeightList` = @MultipWeightList  WHERE `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@MultipWeightList", multipWeightList != null ? multipWeightList : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "multipWeightList">倍数权重</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutMultipWeightList(string multipWeightList, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `MultipWeightList` = @MultipWeightList";
			var parameter_ = Database.CreateInParameter("@MultipWeightList", multipWeightList != null ? multipWeightList : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutMultipWeightListAsync(string multipWeightList, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `MultipWeightList` = @MultipWeightList";
			var parameter_ = Database.CreateInParameter("@MultipWeightList", multipWeightList != null ? multipWeightList : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutMultipWeightList
		#region PutNumList
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码</param>
		/// /// <param name = "numList">lucky奖励次数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutNumListByPK(string operatorID, string currencyID, string numList, TransactionManager tm_ = null)
		{
			RepairPutNumListByPKData(operatorID, currencyID, numList, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutNumListByPKAsync(string operatorID, string currencyID, string numList, TransactionManager tm_ = null)
		{
			RepairPutNumListByPKData(operatorID, currencyID, numList, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutNumListByPKData(string operatorID, string currencyID, string numList, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `NumList` = @NumList  WHERE `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@NumList", numList != null ? numList : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "numList">lucky奖励次数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutNumList(string numList, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `NumList` = @NumList";
			var parameter_ = Database.CreateInParameter("@NumList", numList != null ? numList : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutNumListAsync(string numList, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `NumList` = @NumList";
			var parameter_ = Database.CreateInParameter("@NumList", numList != null ? numList : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutNumList
		#region PutNumWeightList
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码</param>
		/// /// <param name = "numWeightList">lucky奖励次数值权重</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutNumWeightListByPK(string operatorID, string currencyID, string numWeightList, TransactionManager tm_ = null)
		{
			RepairPutNumWeightListByPKData(operatorID, currencyID, numWeightList, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutNumWeightListByPKAsync(string operatorID, string currencyID, string numWeightList, TransactionManager tm_ = null)
		{
			RepairPutNumWeightListByPKData(operatorID, currencyID, numWeightList, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutNumWeightListByPKData(string operatorID, string currencyID, string numWeightList, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `NumWeightList` = @NumWeightList  WHERE `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@NumWeightList", numWeightList != null ? numWeightList : (object)DBNull.Value, MySqlDbType.VarChar),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "numWeightList">lucky奖励次数值权重</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutNumWeightList(string numWeightList, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `NumWeightList` = @NumWeightList";
			var parameter_ = Database.CreateInParameter("@NumWeightList", numWeightList != null ? numWeightList : (object)DBNull.Value, MySqlDbType.VarChar);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutNumWeightListAsync(string numWeightList, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `NumWeightList` = @NumWeightList";
			var parameter_ = Database.CreateInParameter("@NumWeightList", numWeightList != null ? numWeightList : (object)DBNull.Value, MySqlDbType.VarChar);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutNumWeightList
		#endregion // PutXXX
		#endregion // Put
	   
		#region Set
		
		/// <summary>
		/// 插入或者更新数据
		/// </summary>
		/// <param name = "item">要更新的实体对象</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>true:插入操作；false:更新操作</return>
		public bool Set(Bs_config_luckyEO item, TransactionManager tm = null)
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
		public async Task<bool> SetAsync(Bs_config_luckyEO item, TransactionManager tm = null)
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
		/// /// <param name = "currencyID">货币编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public Bs_config_luckyEO GetByPK(string operatorID, string currencyID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(operatorID, currencyID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, Bs_config_luckyEO.MapDataReader);
		}
		public async Task<Bs_config_luckyEO> GetByPKAsync(string operatorID, string currencyID, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(operatorID, currencyID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Bs_config_luckyEO.MapDataReader);
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
		/// /// <param name = "currencyID">货币编码</param>
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
		/// /// <param name = "currencyID">货币编码</param>
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
		/// 按主键查询 MultipList（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetMultipListByPK(string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`MultipList`", "`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		public async Task<string> GetMultipListByPKAsync(string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`MultipList`", "`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 MultipWeightList（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetMultipWeightListByPK(string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`MultipWeightList`", "`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		public async Task<string> GetMultipWeightListByPKAsync(string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`MultipWeightList`", "`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 NumList（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetNumListByPK(string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`NumList`", "`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		public async Task<string> GetNumListByPKAsync(string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`NumList`", "`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 NumWeightList（字段）
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetNumWeightListByPK(string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (string)GetScalar("`NumWeightList`", "`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		public async Task<string> GetNumWeightListByPKAsync(string operatorID, string currencyID, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
			};
			return (string)await GetScalarAsync("`NumWeightList`", "`OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByOperatorID
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_luckyEO> GetByOperatorID(string operatorID)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, null);
		}
		public async Task<List<Bs_config_luckyEO>> GetByOperatorIDAsync(string operatorID)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_luckyEO> GetByOperatorID(string operatorID, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, tm_);
		}
		public async Task<List<Bs_config_luckyEO>> GetByOperatorIDAsync(string operatorID, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_luckyEO> GetByOperatorID(string operatorID, int top_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, null);
		}
		public async Task<List<Bs_config_luckyEO>> GetByOperatorIDAsync(string operatorID, int top_)
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
		public List<Bs_config_luckyEO> GetByOperatorID(string operatorID, int top_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, tm_);
		}
		public async Task<List<Bs_config_luckyEO>> GetByOperatorIDAsync(string operatorID, int top_, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_luckyEO> GetByOperatorID(string operatorID, string sort_)
		{
			return GetByOperatorID(operatorID, 0, sort_, null);
		}
		public async Task<List<Bs_config_luckyEO>> GetByOperatorIDAsync(string operatorID, string sort_)
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
		public List<Bs_config_luckyEO> GetByOperatorID(string operatorID, string sort_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, sort_, tm_);
		}
		public async Task<List<Bs_config_luckyEO>> GetByOperatorIDAsync(string operatorID, string sort_, TransactionManager tm_)
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
		public List<Bs_config_luckyEO> GetByOperatorID(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorID` = @OperatorID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Bs_config_luckyEO.MapDataReader);
		}
		public async Task<List<Bs_config_luckyEO>> GetByOperatorIDAsync(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorID` = @OperatorID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Bs_config_luckyEO.MapDataReader);
		}
		#endregion // GetByOperatorID
		#region GetByCurrencyID
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币编码</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_luckyEO> GetByCurrencyID(string currencyID)
		{
			return GetByCurrencyID(currencyID, 0, string.Empty, null);
		}
		public async Task<List<Bs_config_luckyEO>> GetByCurrencyIDAsync(string currencyID)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_luckyEO> GetByCurrencyID(string currencyID, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, 0, string.Empty, tm_);
		}
		public async Task<List<Bs_config_luckyEO>> GetByCurrencyIDAsync(string currencyID, TransactionManager tm_)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_luckyEO> GetByCurrencyID(string currencyID, int top_)
		{
			return GetByCurrencyID(currencyID, top_, string.Empty, null);
		}
		public async Task<List<Bs_config_luckyEO>> GetByCurrencyIDAsync(string currencyID, int top_)
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
		public List<Bs_config_luckyEO> GetByCurrencyID(string currencyID, int top_, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, top_, string.Empty, tm_);
		}
		public async Task<List<Bs_config_luckyEO>> GetByCurrencyIDAsync(string currencyID, int top_, TransactionManager tm_)
		{
			return await GetByCurrencyIDAsync(currencyID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_luckyEO> GetByCurrencyID(string currencyID, string sort_)
		{
			return GetByCurrencyID(currencyID, 0, sort_, null);
		}
		public async Task<List<Bs_config_luckyEO>> GetByCurrencyIDAsync(string currencyID, string sort_)
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
		public List<Bs_config_luckyEO> GetByCurrencyID(string currencyID, string sort_, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, 0, sort_, tm_);
		}
		public async Task<List<Bs_config_luckyEO>> GetByCurrencyIDAsync(string currencyID, string sort_, TransactionManager tm_)
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
		public List<Bs_config_luckyEO> GetByCurrencyID(string currencyID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CurrencyID` = @CurrencyID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Bs_config_luckyEO.MapDataReader);
		}
		public async Task<List<Bs_config_luckyEO>> GetByCurrencyIDAsync(string currencyID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CurrencyID` = @CurrencyID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Bs_config_luckyEO.MapDataReader);
		}
		#endregion // GetByCurrencyID
		#region GetByMultipList
		
		/// <summary>
		/// 按 MultipList（字段） 查询
		/// </summary>
		/// /// <param name = "multipList">倍数</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_luckyEO> GetByMultipList(string multipList)
		{
			return GetByMultipList(multipList, 0, string.Empty, null);
		}
		public async Task<List<Bs_config_luckyEO>> GetByMultipListAsync(string multipList)
		{
			return await GetByMultipListAsync(multipList, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 MultipList（字段） 查询
		/// </summary>
		/// /// <param name = "multipList">倍数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_luckyEO> GetByMultipList(string multipList, TransactionManager tm_)
		{
			return GetByMultipList(multipList, 0, string.Empty, tm_);
		}
		public async Task<List<Bs_config_luckyEO>> GetByMultipListAsync(string multipList, TransactionManager tm_)
		{
			return await GetByMultipListAsync(multipList, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 MultipList（字段） 查询
		/// </summary>
		/// /// <param name = "multipList">倍数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_luckyEO> GetByMultipList(string multipList, int top_)
		{
			return GetByMultipList(multipList, top_, string.Empty, null);
		}
		public async Task<List<Bs_config_luckyEO>> GetByMultipListAsync(string multipList, int top_)
		{
			return await GetByMultipListAsync(multipList, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 MultipList（字段） 查询
		/// </summary>
		/// /// <param name = "multipList">倍数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_luckyEO> GetByMultipList(string multipList, int top_, TransactionManager tm_)
		{
			return GetByMultipList(multipList, top_, string.Empty, tm_);
		}
		public async Task<List<Bs_config_luckyEO>> GetByMultipListAsync(string multipList, int top_, TransactionManager tm_)
		{
			return await GetByMultipListAsync(multipList, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 MultipList（字段） 查询
		/// </summary>
		/// /// <param name = "multipList">倍数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_luckyEO> GetByMultipList(string multipList, string sort_)
		{
			return GetByMultipList(multipList, 0, sort_, null);
		}
		public async Task<List<Bs_config_luckyEO>> GetByMultipListAsync(string multipList, string sort_)
		{
			return await GetByMultipListAsync(multipList, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 MultipList（字段） 查询
		/// </summary>
		/// /// <param name = "multipList">倍数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_luckyEO> GetByMultipList(string multipList, string sort_, TransactionManager tm_)
		{
			return GetByMultipList(multipList, 0, sort_, tm_);
		}
		public async Task<List<Bs_config_luckyEO>> GetByMultipListAsync(string multipList, string sort_, TransactionManager tm_)
		{
			return await GetByMultipListAsync(multipList, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 MultipList（字段） 查询
		/// </summary>
		/// /// <param name = "multipList">倍数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_luckyEO> GetByMultipList(string multipList, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(multipList != null ? "`MultipList` = @MultipList" : "`MultipList` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (multipList != null)
				paras_.Add(Database.CreateInParameter("@MultipList", multipList, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Bs_config_luckyEO.MapDataReader);
		}
		public async Task<List<Bs_config_luckyEO>> GetByMultipListAsync(string multipList, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(multipList != null ? "`MultipList` = @MultipList" : "`MultipList` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (multipList != null)
				paras_.Add(Database.CreateInParameter("@MultipList", multipList, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Bs_config_luckyEO.MapDataReader);
		}
		#endregion // GetByMultipList
		#region GetByMultipWeightList
		
		/// <summary>
		/// 按 MultipWeightList（字段） 查询
		/// </summary>
		/// /// <param name = "multipWeightList">倍数权重</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_luckyEO> GetByMultipWeightList(string multipWeightList)
		{
			return GetByMultipWeightList(multipWeightList, 0, string.Empty, null);
		}
		public async Task<List<Bs_config_luckyEO>> GetByMultipWeightListAsync(string multipWeightList)
		{
			return await GetByMultipWeightListAsync(multipWeightList, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 MultipWeightList（字段） 查询
		/// </summary>
		/// /// <param name = "multipWeightList">倍数权重</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_luckyEO> GetByMultipWeightList(string multipWeightList, TransactionManager tm_)
		{
			return GetByMultipWeightList(multipWeightList, 0, string.Empty, tm_);
		}
		public async Task<List<Bs_config_luckyEO>> GetByMultipWeightListAsync(string multipWeightList, TransactionManager tm_)
		{
			return await GetByMultipWeightListAsync(multipWeightList, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 MultipWeightList（字段） 查询
		/// </summary>
		/// /// <param name = "multipWeightList">倍数权重</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_luckyEO> GetByMultipWeightList(string multipWeightList, int top_)
		{
			return GetByMultipWeightList(multipWeightList, top_, string.Empty, null);
		}
		public async Task<List<Bs_config_luckyEO>> GetByMultipWeightListAsync(string multipWeightList, int top_)
		{
			return await GetByMultipWeightListAsync(multipWeightList, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 MultipWeightList（字段） 查询
		/// </summary>
		/// /// <param name = "multipWeightList">倍数权重</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_luckyEO> GetByMultipWeightList(string multipWeightList, int top_, TransactionManager tm_)
		{
			return GetByMultipWeightList(multipWeightList, top_, string.Empty, tm_);
		}
		public async Task<List<Bs_config_luckyEO>> GetByMultipWeightListAsync(string multipWeightList, int top_, TransactionManager tm_)
		{
			return await GetByMultipWeightListAsync(multipWeightList, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 MultipWeightList（字段） 查询
		/// </summary>
		/// /// <param name = "multipWeightList">倍数权重</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_luckyEO> GetByMultipWeightList(string multipWeightList, string sort_)
		{
			return GetByMultipWeightList(multipWeightList, 0, sort_, null);
		}
		public async Task<List<Bs_config_luckyEO>> GetByMultipWeightListAsync(string multipWeightList, string sort_)
		{
			return await GetByMultipWeightListAsync(multipWeightList, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 MultipWeightList（字段） 查询
		/// </summary>
		/// /// <param name = "multipWeightList">倍数权重</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_luckyEO> GetByMultipWeightList(string multipWeightList, string sort_, TransactionManager tm_)
		{
			return GetByMultipWeightList(multipWeightList, 0, sort_, tm_);
		}
		public async Task<List<Bs_config_luckyEO>> GetByMultipWeightListAsync(string multipWeightList, string sort_, TransactionManager tm_)
		{
			return await GetByMultipWeightListAsync(multipWeightList, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 MultipWeightList（字段） 查询
		/// </summary>
		/// /// <param name = "multipWeightList">倍数权重</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_luckyEO> GetByMultipWeightList(string multipWeightList, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(multipWeightList != null ? "`MultipWeightList` = @MultipWeightList" : "`MultipWeightList` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (multipWeightList != null)
				paras_.Add(Database.CreateInParameter("@MultipWeightList", multipWeightList, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Bs_config_luckyEO.MapDataReader);
		}
		public async Task<List<Bs_config_luckyEO>> GetByMultipWeightListAsync(string multipWeightList, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(multipWeightList != null ? "`MultipWeightList` = @MultipWeightList" : "`MultipWeightList` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (multipWeightList != null)
				paras_.Add(Database.CreateInParameter("@MultipWeightList", multipWeightList, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Bs_config_luckyEO.MapDataReader);
		}
		#endregion // GetByMultipWeightList
		#region GetByNumList
		
		/// <summary>
		/// 按 NumList（字段） 查询
		/// </summary>
		/// /// <param name = "numList">lucky奖励次数值</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_luckyEO> GetByNumList(string numList)
		{
			return GetByNumList(numList, 0, string.Empty, null);
		}
		public async Task<List<Bs_config_luckyEO>> GetByNumListAsync(string numList)
		{
			return await GetByNumListAsync(numList, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 NumList（字段） 查询
		/// </summary>
		/// /// <param name = "numList">lucky奖励次数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_luckyEO> GetByNumList(string numList, TransactionManager tm_)
		{
			return GetByNumList(numList, 0, string.Empty, tm_);
		}
		public async Task<List<Bs_config_luckyEO>> GetByNumListAsync(string numList, TransactionManager tm_)
		{
			return await GetByNumListAsync(numList, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 NumList（字段） 查询
		/// </summary>
		/// /// <param name = "numList">lucky奖励次数值</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_luckyEO> GetByNumList(string numList, int top_)
		{
			return GetByNumList(numList, top_, string.Empty, null);
		}
		public async Task<List<Bs_config_luckyEO>> GetByNumListAsync(string numList, int top_)
		{
			return await GetByNumListAsync(numList, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 NumList（字段） 查询
		/// </summary>
		/// /// <param name = "numList">lucky奖励次数值</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_luckyEO> GetByNumList(string numList, int top_, TransactionManager tm_)
		{
			return GetByNumList(numList, top_, string.Empty, tm_);
		}
		public async Task<List<Bs_config_luckyEO>> GetByNumListAsync(string numList, int top_, TransactionManager tm_)
		{
			return await GetByNumListAsync(numList, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 NumList（字段） 查询
		/// </summary>
		/// /// <param name = "numList">lucky奖励次数值</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_luckyEO> GetByNumList(string numList, string sort_)
		{
			return GetByNumList(numList, 0, sort_, null);
		}
		public async Task<List<Bs_config_luckyEO>> GetByNumListAsync(string numList, string sort_)
		{
			return await GetByNumListAsync(numList, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 NumList（字段） 查询
		/// </summary>
		/// /// <param name = "numList">lucky奖励次数值</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_luckyEO> GetByNumList(string numList, string sort_, TransactionManager tm_)
		{
			return GetByNumList(numList, 0, sort_, tm_);
		}
		public async Task<List<Bs_config_luckyEO>> GetByNumListAsync(string numList, string sort_, TransactionManager tm_)
		{
			return await GetByNumListAsync(numList, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 NumList（字段） 查询
		/// </summary>
		/// /// <param name = "numList">lucky奖励次数值</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_luckyEO> GetByNumList(string numList, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(numList != null ? "`NumList` = @NumList" : "`NumList` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (numList != null)
				paras_.Add(Database.CreateInParameter("@NumList", numList, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Bs_config_luckyEO.MapDataReader);
		}
		public async Task<List<Bs_config_luckyEO>> GetByNumListAsync(string numList, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(numList != null ? "`NumList` = @NumList" : "`NumList` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (numList != null)
				paras_.Add(Database.CreateInParameter("@NumList", numList, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Bs_config_luckyEO.MapDataReader);
		}
		#endregion // GetByNumList
		#region GetByNumWeightList
		
		/// <summary>
		/// 按 NumWeightList（字段） 查询
		/// </summary>
		/// /// <param name = "numWeightList">lucky奖励次数值权重</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_luckyEO> GetByNumWeightList(string numWeightList)
		{
			return GetByNumWeightList(numWeightList, 0, string.Empty, null);
		}
		public async Task<List<Bs_config_luckyEO>> GetByNumWeightListAsync(string numWeightList)
		{
			return await GetByNumWeightListAsync(numWeightList, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 NumWeightList（字段） 查询
		/// </summary>
		/// /// <param name = "numWeightList">lucky奖励次数值权重</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_luckyEO> GetByNumWeightList(string numWeightList, TransactionManager tm_)
		{
			return GetByNumWeightList(numWeightList, 0, string.Empty, tm_);
		}
		public async Task<List<Bs_config_luckyEO>> GetByNumWeightListAsync(string numWeightList, TransactionManager tm_)
		{
			return await GetByNumWeightListAsync(numWeightList, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 NumWeightList（字段） 查询
		/// </summary>
		/// /// <param name = "numWeightList">lucky奖励次数值权重</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_luckyEO> GetByNumWeightList(string numWeightList, int top_)
		{
			return GetByNumWeightList(numWeightList, top_, string.Empty, null);
		}
		public async Task<List<Bs_config_luckyEO>> GetByNumWeightListAsync(string numWeightList, int top_)
		{
			return await GetByNumWeightListAsync(numWeightList, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 NumWeightList（字段） 查询
		/// </summary>
		/// /// <param name = "numWeightList">lucky奖励次数值权重</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_luckyEO> GetByNumWeightList(string numWeightList, int top_, TransactionManager tm_)
		{
			return GetByNumWeightList(numWeightList, top_, string.Empty, tm_);
		}
		public async Task<List<Bs_config_luckyEO>> GetByNumWeightListAsync(string numWeightList, int top_, TransactionManager tm_)
		{
			return await GetByNumWeightListAsync(numWeightList, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 NumWeightList（字段） 查询
		/// </summary>
		/// /// <param name = "numWeightList">lucky奖励次数值权重</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_luckyEO> GetByNumWeightList(string numWeightList, string sort_)
		{
			return GetByNumWeightList(numWeightList, 0, sort_, null);
		}
		public async Task<List<Bs_config_luckyEO>> GetByNumWeightListAsync(string numWeightList, string sort_)
		{
			return await GetByNumWeightListAsync(numWeightList, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 NumWeightList（字段） 查询
		/// </summary>
		/// /// <param name = "numWeightList">lucky奖励次数值权重</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_luckyEO> GetByNumWeightList(string numWeightList, string sort_, TransactionManager tm_)
		{
			return GetByNumWeightList(numWeightList, 0, sort_, tm_);
		}
		public async Task<List<Bs_config_luckyEO>> GetByNumWeightListAsync(string numWeightList, string sort_, TransactionManager tm_)
		{
			return await GetByNumWeightListAsync(numWeightList, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 NumWeightList（字段） 查询
		/// </summary>
		/// /// <param name = "numWeightList">lucky奖励次数值权重</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_luckyEO> GetByNumWeightList(string numWeightList, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(numWeightList != null ? "`NumWeightList` = @NumWeightList" : "`NumWeightList` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (numWeightList != null)
				paras_.Add(Database.CreateInParameter("@NumWeightList", numWeightList, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Bs_config_luckyEO.MapDataReader);
		}
		public async Task<List<Bs_config_luckyEO>> GetByNumWeightListAsync(string numWeightList, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL(numWeightList != null ? "`NumWeightList` = @NumWeightList" : "`NumWeightList` IS NULL", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			if (numWeightList != null)
				paras_.Add(Database.CreateInParameter("@NumWeightList", numWeightList, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Bs_config_luckyEO.MapDataReader);
		}
		#endregion // GetByNumWeightList
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
