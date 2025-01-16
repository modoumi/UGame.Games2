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
	/// 球星概率表
	/// 【表 bs_config_star_odds 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class Bs_config_star_oddsEO : IRowMapper<Bs_config_star_oddsEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public Bs_config_star_oddsEO()
		{
			this.Goal = 0;
			this.IsBaseMultiple = 0;
			this.Surprise = 0;
			this.RecDate = DateTime.Now;
		}
		#region 主键原始值 & 主键集合
	    
		/// <summary>
		/// 当前对象是否保存原始主键值，当修改了主键值时为 true
		/// </summary>
		public bool HasOriginal { get; protected set; }
		
		private int _originalStarID;
		/// <summary>
		/// 【数据库中的原始主键 StarID 值的副本，用于主键值更新】
		/// </summary>
		public int OriginalStarID
		{
			get { return _originalStarID; }
			set { HasOriginal = true; _originalStarID = value; }
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
		
		private int _originalGoal;
		/// <summary>
		/// 【数据库中的原始主键 Goal 值的副本，用于主键值更新】
		/// </summary>
		public int OriginalGoal
		{
			get { return _originalGoal; }
			set { HasOriginal = true; _originalGoal = value; }
		}
		
		private int _originalPosition;
		/// <summary>
		/// 【数据库中的原始主键 Position 值的副本，用于主键值更新】
		/// </summary>
		public int OriginalPosition
		{
			get { return _originalPosition; }
			set { HasOriginal = true; _originalPosition = value; }
		}
		
		private int _originalMultiple;
		/// <summary>
		/// 【数据库中的原始主键 Multiple 值的副本，用于主键值更新】
		/// </summary>
		public int OriginalMultiple
		{
			get { return _originalMultiple; }
			set { HasOriginal = true; _originalMultiple = value; }
		}
	    /// <summary>
	    /// 获取主键集合。key: 数据库字段名称, value: 主键值
	    /// </summary>
	    /// <returns></returns>
	    public Dictionary<string, object> GetPrimaryKeys()
	    {
	        return new Dictionary<string, object>() { { "StarID", StarID },  { "OperatorID", OperatorID },  { "CurrencyID", CurrencyID },  { "Goal", Goal },  { "Position", Position },  { "Multiple", Multiple }, };
	    }
	    /// <summary>
	    /// 获取主键集合JSON格式
	    /// </summary>
	    /// <returns></returns>
	    public string GetPrimaryKeysJson() => SerializerUtil.SerializeJson(GetPrimaryKeys());
		#endregion // 主键原始值
		#region 所有字段
		/// <summary>
		/// 键Key
		/// 【主键 int】
		/// </summary>
		[DataMember(Order = 1)]
		public int StarID { get; set; }
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
		/// 用户进球累计值
		/// 【主键 int】
		/// </summary>
		[DataMember(Order = 4)]
		public int Goal { get; set; }
		/// <summary>
		/// 位置
		/// 【主键 int】
		/// </summary>
		[DataMember(Order = 5)]
		public int Position { get; set; }
		/// <summary>
		/// 倍数（倍数值*100）
		/// 【主键 int】
		/// </summary>
		[DataMember(Order = 6)]
		public int Multiple { get; set; }
		/// <summary>
		/// 概率（概率值*100000）
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 7)]
		public int Odds { get; set; }
		/// <summary>
		/// 是否基础倍数
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 8)]
		public int IsBaseMultiple { get; set; }
		/// <summary>
		/// 是否双倍奖励
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 9)]
		public int Surprise { get; set; }
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
		public Bs_config_star_oddsEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static Bs_config_star_oddsEO MapDataReader(IDataReader reader)
		{
		    Bs_config_star_oddsEO ret = new Bs_config_star_oddsEO();
			ret.StarID = reader.ToInt32("StarID");
			ret.OriginalStarID = ret.StarID;
			ret.OperatorID = reader.ToString("OperatorID");
			ret.OriginalOperatorID = ret.OperatorID;
			ret.CurrencyID = reader.ToString("CurrencyID");
			ret.OriginalCurrencyID = ret.CurrencyID;
			ret.Goal = reader.ToInt32("Goal");
			ret.OriginalGoal = ret.Goal;
			ret.Position = reader.ToInt32("Position");
			ret.OriginalPosition = ret.Position;
			ret.Multiple = reader.ToInt32("Multiple");
			ret.OriginalMultiple = ret.Multiple;
			ret.Odds = reader.ToInt32("Odds");
			ret.IsBaseMultiple = reader.ToInt32("IsBaseMultiple");
			ret.Surprise = reader.ToInt32("Surprise");
			ret.RecDate = reader.ToDateTime("RecDate");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 球星概率表
	/// 【表 bs_config_star_odds 的操作类】
	/// </summary>
	[Obsolete]
	public class Bs_config_star_oddsMO : MySqlTableMO<Bs_config_star_oddsEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`bs_config_star_odds`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public Bs_config_star_oddsMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public Bs_config_star_oddsMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public Bs_config_star_oddsMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(Bs_config_star_oddsEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(Bs_config_star_oddsEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(Bs_config_star_oddsEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`StarID`, `OperatorID`, `CurrencyID`, `Goal`, `Position`, `Multiple`, `Odds`, `IsBaseMultiple`, `Surprise`, `RecDate`) VALUE (@StarID, @OperatorID, @CurrencyID, @Goal, @Position, @Multiple, @Odds, @IsBaseMultiple, @Surprise, @RecDate);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@StarID", item.StarID, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", item.OperatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", item.CurrencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@Goal", item.Goal, MySqlDbType.Int32),
				Database.CreateInParameter("@Position", item.Position, MySqlDbType.Int32),
				Database.CreateInParameter("@Multiple", item.Multiple, MySqlDbType.Int32),
				Database.CreateInParameter("@Odds", item.Odds, MySqlDbType.Int32),
				Database.CreateInParameter("@IsBaseMultiple", item.IsBaseMultiple, MySqlDbType.Int32),
				Database.CreateInParameter("@Surprise", item.Surprise, MySqlDbType.Int32),
				Database.CreateInParameter("@RecDate", item.RecDate, MySqlDbType.DateTime),
			};
		}
		public int AddByBatch(IEnumerable<Bs_config_star_oddsEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<Bs_config_star_oddsEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<Bs_config_star_oddsEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`StarID`, `OperatorID`, `CurrencyID`, `Goal`, `Position`, `Multiple`, `Odds`, `IsBaseMultiple`, `Surprise`, `RecDate`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"({item.StarID},'{item.OperatorID}','{item.CurrencyID}',{item.Goal},{item.Position},{item.Multiple},{item.Odds},{item.IsBaseMultiple},{item.Surprise},'{item.RecDate.ToString("yyyy-MM-dd HH:mm:ss")}'),");
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
		/// /// <param name = "starID">键Key</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码</param>
		/// /// <param name = "goal">用户进球累计值</param>
		/// /// <param name = "position">位置</param>
		/// /// <param name = "multiple">倍数（倍数值*100）</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(int starID, string operatorID, string currencyID, int goal, int position, int multiple, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(starID, operatorID, currencyID, goal, position, multiple, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(int starID, string operatorID, string currencyID, int goal, int position, int multiple, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(starID, operatorID, currencyID, goal, position, multiple, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(int starID, string operatorID, string currencyID, int goal, int position, int multiple, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `StarID` = @StarID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID AND `Goal` = @Goal AND `Position` = @Position AND `Multiple` = @Multiple";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@StarID", starID, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@Goal", goal, MySqlDbType.Int32),
				Database.CreateInParameter("@Position", position, MySqlDbType.Int32),
				Database.CreateInParameter("@Multiple", multiple, MySqlDbType.Int32),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(Bs_config_star_oddsEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.StarID, item.OperatorID, item.CurrencyID, item.Goal, item.Position, item.Multiple, tm_);
		}
		public async Task<int> RemoveAsync(Bs_config_star_oddsEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.StarID, item.OperatorID, item.CurrencyID, item.Goal, item.Position, item.Multiple, tm_);
		}
		#endregion // RemoveByPK
		
		#region RemoveByXXX
		#region RemoveByStarID
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "starID">键Key</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByStarID(int starID, TransactionManager tm_ = null)
		{
			RepairRemoveByStarIDData(starID, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByStarIDAsync(int starID, TransactionManager tm_ = null)
		{
			RepairRemoveByStarIDData(starID, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByStarIDData(int starID, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `StarID` = @StarID";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@StarID", starID, MySqlDbType.Int32));
		}
		#endregion // RemoveByStarID
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
		#region RemoveByPosition
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "position">位置</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPosition(int position, TransactionManager tm_ = null)
		{
			RepairRemoveByPositionData(position, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPositionAsync(int position, TransactionManager tm_ = null)
		{
			RepairRemoveByPositionData(position, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByPositionData(int position, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `Position` = @Position";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Position", position, MySqlDbType.Int32));
		}
		#endregion // RemoveByPosition
		#region RemoveByMultiple
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "multiple">倍数（倍数值*100）</param>
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
		#region RemoveByOdds
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "odds">概率（概率值*100000）</param>
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
		#region RemoveByIsBaseMultiple
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "isBaseMultiple">是否基础倍数</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByIsBaseMultiple(int isBaseMultiple, TransactionManager tm_ = null)
		{
			RepairRemoveByIsBaseMultipleData(isBaseMultiple, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByIsBaseMultipleAsync(int isBaseMultiple, TransactionManager tm_ = null)
		{
			RepairRemoveByIsBaseMultipleData(isBaseMultiple, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByIsBaseMultipleData(int isBaseMultiple, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `IsBaseMultiple` = @IsBaseMultiple";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IsBaseMultiple", isBaseMultiple, MySqlDbType.Int32));
		}
		#endregion // RemoveByIsBaseMultiple
		#region RemoveBySurprise
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "surprise">是否双倍奖励</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveBySurprise(int surprise, TransactionManager tm_ = null)
		{
			RepairRemoveBySurpriseData(surprise, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveBySurpriseAsync(int surprise, TransactionManager tm_ = null)
		{
			RepairRemoveBySurpriseData(surprise, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveBySurpriseData(int surprise, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `Surprise` = @Surprise";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Surprise", surprise, MySqlDbType.Int32));
		}
		#endregion // RemoveBySurprise
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
		public int Put(Bs_config_star_oddsEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(Bs_config_star_oddsEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(Bs_config_star_oddsEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `StarID` = @StarID, `OperatorID` = @OperatorID, `CurrencyID` = @CurrencyID, `Goal` = @Goal, `Position` = @Position, `Multiple` = @Multiple, `Odds` = @Odds, `IsBaseMultiple` = @IsBaseMultiple, `Surprise` = @Surprise WHERE `StarID` = @StarID_Original AND `OperatorID` = @OperatorID_Original AND `CurrencyID` = @CurrencyID_Original AND `Goal` = @Goal_Original AND `Position` = @Position_Original AND `Multiple` = @Multiple_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@StarID", item.StarID, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", item.OperatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", item.CurrencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@Goal", item.Goal, MySqlDbType.Int32),
				Database.CreateInParameter("@Position", item.Position, MySqlDbType.Int32),
				Database.CreateInParameter("@Multiple", item.Multiple, MySqlDbType.Int32),
				Database.CreateInParameter("@Odds", item.Odds, MySqlDbType.Int32),
				Database.CreateInParameter("@IsBaseMultiple", item.IsBaseMultiple, MySqlDbType.Int32),
				Database.CreateInParameter("@Surprise", item.Surprise, MySqlDbType.Int32),
				Database.CreateInParameter("@StarID_Original", item.HasOriginal ? item.OriginalStarID : item.StarID, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID_Original", item.HasOriginal ? item.OriginalOperatorID : item.OperatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID_Original", item.HasOriginal ? item.OriginalCurrencyID : item.CurrencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@Goal_Original", item.HasOriginal ? item.OriginalGoal : item.Goal, MySqlDbType.Int32),
				Database.CreateInParameter("@Position_Original", item.HasOriginal ? item.OriginalPosition : item.Position, MySqlDbType.Int32),
				Database.CreateInParameter("@Multiple_Original", item.HasOriginal ? item.OriginalMultiple : item.Multiple, MySqlDbType.Int32),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<Bs_config_star_oddsEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<Bs_config_star_oddsEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "starID">键Key</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码</param>
		/// /// <param name = "goal">用户进球累计值</param>
		/// /// <param name = "position">位置</param>
		/// /// <param name = "multiple">倍数（倍数值*100）</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(int starID, string operatorID, string currencyID, int goal, int position, int multiple, string set_, params object[] values_)
		{
			return Put(set_, "`StarID` = @StarID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID AND `Goal` = @Goal AND `Position` = @Position AND `Multiple` = @Multiple", ConcatValues(values_, starID, operatorID, currencyID, goal, position, multiple));
		}
		public async Task<int> PutByPKAsync(int starID, string operatorID, string currencyID, int goal, int position, int multiple, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`StarID` = @StarID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID AND `Goal` = @Goal AND `Position` = @Position AND `Multiple` = @Multiple", ConcatValues(values_, starID, operatorID, currencyID, goal, position, multiple));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "starID">键Key</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码</param>
		/// /// <param name = "goal">用户进球累计值</param>
		/// /// <param name = "position">位置</param>
		/// /// <param name = "multiple">倍数（倍数值*100）</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(int starID, string operatorID, string currencyID, int goal, int position, int multiple, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`StarID` = @StarID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID AND `Goal` = @Goal AND `Position` = @Position AND `Multiple` = @Multiple", tm_, ConcatValues(values_, starID, operatorID, currencyID, goal, position, multiple));
		}
		public async Task<int> PutByPKAsync(int starID, string operatorID, string currencyID, int goal, int position, int multiple, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`StarID` = @StarID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID AND `Goal` = @Goal AND `Position` = @Position AND `Multiple` = @Multiple", tm_, ConcatValues(values_, starID, operatorID, currencyID, goal, position, multiple));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "starID">键Key</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码</param>
		/// /// <param name = "goal">用户进球累计值</param>
		/// /// <param name = "position">位置</param>
		/// /// <param name = "multiple">倍数（倍数值*100）</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(int starID, string operatorID, string currencyID, int goal, int position, int multiple, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@StarID", starID, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@Goal", goal, MySqlDbType.Int32),
				Database.CreateInParameter("@Position", position, MySqlDbType.Int32),
				Database.CreateInParameter("@Multiple", multiple, MySqlDbType.Int32),
	        };
			return Put(set_, "`StarID` = @StarID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID AND `Goal` = @Goal AND `Position` = @Position AND `Multiple` = @Multiple", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(int starID, string operatorID, string currencyID, int goal, int position, int multiple, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@StarID", starID, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@Goal", goal, MySqlDbType.Int32),
				Database.CreateInParameter("@Position", position, MySqlDbType.Int32),
				Database.CreateInParameter("@Multiple", multiple, MySqlDbType.Int32),
	        };
			return await PutAsync(set_, "`StarID` = @StarID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID AND `Goal` = @Goal AND `Position` = @Position AND `Multiple` = @Multiple", ConcatParameters(paras_, newParas_), tm_);
		}
		#endregion // PutByPK
		
		#region PutXXX
		#region PutStarID
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "starID">键Key</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutStarID(int starID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `StarID` = @StarID";
			var parameter_ = Database.CreateInParameter("@StarID", starID, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutStarIDAsync(int starID, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `StarID` = @StarID";
			var parameter_ = Database.CreateInParameter("@StarID", starID, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutStarID
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
		#region PutGoal
	 
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
		#region PutPosition
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "position">位置</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutPosition(int position, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Position` = @Position";
			var parameter_ = Database.CreateInParameter("@Position", position, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutPositionAsync(int position, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Position` = @Position";
			var parameter_ = Database.CreateInParameter("@Position", position, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutPosition
		#region PutMultiple
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "multiple">倍数（倍数值*100）</param>
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
		#region PutOdds
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "starID">键Key</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码</param>
		/// /// <param name = "goal">用户进球累计值</param>
		/// /// <param name = "position">位置</param>
		/// /// <param name = "multiple">倍数（倍数值*100）</param>
		/// /// <param name = "odds">概率（概率值*100000）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutOddsByPK(int starID, string operatorID, string currencyID, int goal, int position, int multiple, int odds, TransactionManager tm_ = null)
		{
			RepairPutOddsByPKData(starID, operatorID, currencyID, goal, position, multiple, odds, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutOddsByPKAsync(int starID, string operatorID, string currencyID, int goal, int position, int multiple, int odds, TransactionManager tm_ = null)
		{
			RepairPutOddsByPKData(starID, operatorID, currencyID, goal, position, multiple, odds, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutOddsByPKData(int starID, string operatorID, string currencyID, int goal, int position, int multiple, int odds, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Odds` = @Odds  WHERE `StarID` = @StarID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID AND `Goal` = @Goal AND `Position` = @Position AND `Multiple` = @Multiple";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Odds", odds, MySqlDbType.Int32),
				Database.CreateInParameter("@StarID", starID, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@Goal", goal, MySqlDbType.Int32),
				Database.CreateInParameter("@Position", position, MySqlDbType.Int32),
				Database.CreateInParameter("@Multiple", multiple, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "odds">概率（概率值*100000）</param>
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
		#region PutIsBaseMultiple
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "starID">键Key</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码</param>
		/// /// <param name = "goal">用户进球累计值</param>
		/// /// <param name = "position">位置</param>
		/// /// <param name = "multiple">倍数（倍数值*100）</param>
		/// /// <param name = "isBaseMultiple">是否基础倍数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutIsBaseMultipleByPK(int starID, string operatorID, string currencyID, int goal, int position, int multiple, int isBaseMultiple, TransactionManager tm_ = null)
		{
			RepairPutIsBaseMultipleByPKData(starID, operatorID, currencyID, goal, position, multiple, isBaseMultiple, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutIsBaseMultipleByPKAsync(int starID, string operatorID, string currencyID, int goal, int position, int multiple, int isBaseMultiple, TransactionManager tm_ = null)
		{
			RepairPutIsBaseMultipleByPKData(starID, operatorID, currencyID, goal, position, multiple, isBaseMultiple, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutIsBaseMultipleByPKData(int starID, string operatorID, string currencyID, int goal, int position, int multiple, int isBaseMultiple, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `IsBaseMultiple` = @IsBaseMultiple  WHERE `StarID` = @StarID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID AND `Goal` = @Goal AND `Position` = @Position AND `Multiple` = @Multiple";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@IsBaseMultiple", isBaseMultiple, MySqlDbType.Int32),
				Database.CreateInParameter("@StarID", starID, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@Goal", goal, MySqlDbType.Int32),
				Database.CreateInParameter("@Position", position, MySqlDbType.Int32),
				Database.CreateInParameter("@Multiple", multiple, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "isBaseMultiple">是否基础倍数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutIsBaseMultiple(int isBaseMultiple, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `IsBaseMultiple` = @IsBaseMultiple";
			var parameter_ = Database.CreateInParameter("@IsBaseMultiple", isBaseMultiple, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutIsBaseMultipleAsync(int isBaseMultiple, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `IsBaseMultiple` = @IsBaseMultiple";
			var parameter_ = Database.CreateInParameter("@IsBaseMultiple", isBaseMultiple, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutIsBaseMultiple
		#region PutSurprise
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "starID">键Key</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码</param>
		/// /// <param name = "goal">用户进球累计值</param>
		/// /// <param name = "position">位置</param>
		/// /// <param name = "multiple">倍数（倍数值*100）</param>
		/// /// <param name = "surprise">是否双倍奖励</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutSurpriseByPK(int starID, string operatorID, string currencyID, int goal, int position, int multiple, int surprise, TransactionManager tm_ = null)
		{
			RepairPutSurpriseByPKData(starID, operatorID, currencyID, goal, position, multiple, surprise, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutSurpriseByPKAsync(int starID, string operatorID, string currencyID, int goal, int position, int multiple, int surprise, TransactionManager tm_ = null)
		{
			RepairPutSurpriseByPKData(starID, operatorID, currencyID, goal, position, multiple, surprise, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutSurpriseByPKData(int starID, string operatorID, string currencyID, int goal, int position, int multiple, int surprise, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Surprise` = @Surprise  WHERE `StarID` = @StarID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID AND `Goal` = @Goal AND `Position` = @Position AND `Multiple` = @Multiple";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Surprise", surprise, MySqlDbType.Int32),
				Database.CreateInParameter("@StarID", starID, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@Goal", goal, MySqlDbType.Int32),
				Database.CreateInParameter("@Position", position, MySqlDbType.Int32),
				Database.CreateInParameter("@Multiple", multiple, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "surprise">是否双倍奖励</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutSurprise(int surprise, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Surprise` = @Surprise";
			var parameter_ = Database.CreateInParameter("@Surprise", surprise, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutSurpriseAsync(int surprise, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Surprise` = @Surprise";
			var parameter_ = Database.CreateInParameter("@Surprise", surprise, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutSurprise
		#region PutRecDate
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "starID">键Key</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码</param>
		/// /// <param name = "goal">用户进球累计值</param>
		/// /// <param name = "position">位置</param>
		/// /// <param name = "multiple">倍数（倍数值*100）</param>
		/// /// <param name = "recDate">创建时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRecDateByPK(int starID, string operatorID, string currencyID, int goal, int position, int multiple, DateTime recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(starID, operatorID, currencyID, goal, position, multiple, recDate, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutRecDateByPKAsync(int starID, string operatorID, string currencyID, int goal, int position, int multiple, DateTime recDate, TransactionManager tm_ = null)
		{
			RepairPutRecDateByPKData(starID, operatorID, currencyID, goal, position, multiple, recDate, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutRecDateByPKData(int starID, string operatorID, string currencyID, int goal, int position, int multiple, DateTime recDate, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `RecDate` = @RecDate  WHERE `StarID` = @StarID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID AND `Goal` = @Goal AND `Position` = @Position AND `Multiple` = @Multiple";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime),
				Database.CreateInParameter("@StarID", starID, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@Goal", goal, MySqlDbType.Int32),
				Database.CreateInParameter("@Position", position, MySqlDbType.Int32),
				Database.CreateInParameter("@Multiple", multiple, MySqlDbType.Int32),
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
		public bool Set(Bs_config_star_oddsEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.StarID, item.OperatorID, item.CurrencyID, item.Goal, item.Position, item.Multiple) == null)
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
		public async Task<bool> SetAsync(Bs_config_star_oddsEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.StarID, item.OperatorID, item.CurrencyID, item.Goal, item.Position, item.Multiple) == null)
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
		/// /// <param name = "starID">键Key</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码</param>
		/// /// <param name = "goal">用户进球累计值</param>
		/// /// <param name = "position">位置</param>
		/// /// <param name = "multiple">倍数（倍数值*100）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public Bs_config_star_oddsEO GetByPK(int starID, string operatorID, string currencyID, int goal, int position, int multiple, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(starID, operatorID, currencyID, goal, position, multiple, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, Bs_config_star_oddsEO.MapDataReader);
		}
		public async Task<Bs_config_star_oddsEO> GetByPKAsync(int starID, string operatorID, string currencyID, int goal, int position, int multiple, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(starID, operatorID, currencyID, goal, position, multiple, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Bs_config_star_oddsEO.MapDataReader);
		}
		private void RepairGetByPKData(int starID, string operatorID, string currencyID, int goal, int position, int multiple, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`StarID` = @StarID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID AND `Goal` = @Goal AND `Position` = @Position AND `Multiple` = @Multiple", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@StarID", starID, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@Goal", goal, MySqlDbType.Int32),
				Database.CreateInParameter("@Position", position, MySqlDbType.Int32),
				Database.CreateInParameter("@Multiple", multiple, MySqlDbType.Int32),
			};
		}
		#endregion // GetByPK
		
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 StarID（字段）
		/// </summary>
		/// /// <param name = "starID">键Key</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码</param>
		/// /// <param name = "goal">用户进球累计值</param>
		/// /// <param name = "position">位置</param>
		/// /// <param name = "multiple">倍数（倍数值*100）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetStarIDByPK(int starID, string operatorID, string currencyID, int goal, int position, int multiple, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@StarID", starID, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@Goal", goal, MySqlDbType.Int32),
				Database.CreateInParameter("@Position", position, MySqlDbType.Int32),
				Database.CreateInParameter("@Multiple", multiple, MySqlDbType.Int32),
			};
			return (int)GetScalar("`StarID`", "`StarID` = @StarID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID AND `Goal` = @Goal AND `Position` = @Position AND `Multiple` = @Multiple", paras_, tm_);
		}
		public async Task<int> GetStarIDByPKAsync(int starID, string operatorID, string currencyID, int goal, int position, int multiple, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@StarID", starID, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@Goal", goal, MySqlDbType.Int32),
				Database.CreateInParameter("@Position", position, MySqlDbType.Int32),
				Database.CreateInParameter("@Multiple", multiple, MySqlDbType.Int32),
			};
			return (int)await GetScalarAsync("`StarID`", "`StarID` = @StarID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID AND `Goal` = @Goal AND `Position` = @Position AND `Multiple` = @Multiple", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 OperatorID（字段）
		/// </summary>
		/// /// <param name = "starID">键Key</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码</param>
		/// /// <param name = "goal">用户进球累计值</param>
		/// /// <param name = "position">位置</param>
		/// /// <param name = "multiple">倍数（倍数值*100）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetOperatorIDByPK(int starID, string operatorID, string currencyID, int goal, int position, int multiple, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@StarID", starID, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@Goal", goal, MySqlDbType.Int32),
				Database.CreateInParameter("@Position", position, MySqlDbType.Int32),
				Database.CreateInParameter("@Multiple", multiple, MySqlDbType.Int32),
			};
			return (string)GetScalar("`OperatorID`", "`StarID` = @StarID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID AND `Goal` = @Goal AND `Position` = @Position AND `Multiple` = @Multiple", paras_, tm_);
		}
		public async Task<string> GetOperatorIDByPKAsync(int starID, string operatorID, string currencyID, int goal, int position, int multiple, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@StarID", starID, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@Goal", goal, MySqlDbType.Int32),
				Database.CreateInParameter("@Position", position, MySqlDbType.Int32),
				Database.CreateInParameter("@Multiple", multiple, MySqlDbType.Int32),
			};
			return (string)await GetScalarAsync("`OperatorID`", "`StarID` = @StarID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID AND `Goal` = @Goal AND `Position` = @Position AND `Multiple` = @Multiple", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 CurrencyID（字段）
		/// </summary>
		/// /// <param name = "starID">键Key</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码</param>
		/// /// <param name = "goal">用户进球累计值</param>
		/// /// <param name = "position">位置</param>
		/// /// <param name = "multiple">倍数（倍数值*100）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public string GetCurrencyIDByPK(int starID, string operatorID, string currencyID, int goal, int position, int multiple, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@StarID", starID, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@Goal", goal, MySqlDbType.Int32),
				Database.CreateInParameter("@Position", position, MySqlDbType.Int32),
				Database.CreateInParameter("@Multiple", multiple, MySqlDbType.Int32),
			};
			return (string)GetScalar("`CurrencyID`", "`StarID` = @StarID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID AND `Goal` = @Goal AND `Position` = @Position AND `Multiple` = @Multiple", paras_, tm_);
		}
		public async Task<string> GetCurrencyIDByPKAsync(int starID, string operatorID, string currencyID, int goal, int position, int multiple, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@StarID", starID, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@Goal", goal, MySqlDbType.Int32),
				Database.CreateInParameter("@Position", position, MySqlDbType.Int32),
				Database.CreateInParameter("@Multiple", multiple, MySqlDbType.Int32),
			};
			return (string)await GetScalarAsync("`CurrencyID`", "`StarID` = @StarID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID AND `Goal` = @Goal AND `Position` = @Position AND `Multiple` = @Multiple", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Goal（字段）
		/// </summary>
		/// /// <param name = "starID">键Key</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码</param>
		/// /// <param name = "goal">用户进球累计值</param>
		/// /// <param name = "position">位置</param>
		/// /// <param name = "multiple">倍数（倍数值*100）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetGoalByPK(int starID, string operatorID, string currencyID, int goal, int position, int multiple, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@StarID", starID, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@Goal", goal, MySqlDbType.Int32),
				Database.CreateInParameter("@Position", position, MySqlDbType.Int32),
				Database.CreateInParameter("@Multiple", multiple, MySqlDbType.Int32),
			};
			return (int)GetScalar("`Goal`", "`StarID` = @StarID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID AND `Goal` = @Goal AND `Position` = @Position AND `Multiple` = @Multiple", paras_, tm_);
		}
		public async Task<int> GetGoalByPKAsync(int starID, string operatorID, string currencyID, int goal, int position, int multiple, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@StarID", starID, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@Goal", goal, MySqlDbType.Int32),
				Database.CreateInParameter("@Position", position, MySqlDbType.Int32),
				Database.CreateInParameter("@Multiple", multiple, MySqlDbType.Int32),
			};
			return (int)await GetScalarAsync("`Goal`", "`StarID` = @StarID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID AND `Goal` = @Goal AND `Position` = @Position AND `Multiple` = @Multiple", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Position（字段）
		/// </summary>
		/// /// <param name = "starID">键Key</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码</param>
		/// /// <param name = "goal">用户进球累计值</param>
		/// /// <param name = "position">位置</param>
		/// /// <param name = "multiple">倍数（倍数值*100）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetPositionByPK(int starID, string operatorID, string currencyID, int goal, int position, int multiple, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@StarID", starID, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@Goal", goal, MySqlDbType.Int32),
				Database.CreateInParameter("@Position", position, MySqlDbType.Int32),
				Database.CreateInParameter("@Multiple", multiple, MySqlDbType.Int32),
			};
			return (int)GetScalar("`Position`", "`StarID` = @StarID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID AND `Goal` = @Goal AND `Position` = @Position AND `Multiple` = @Multiple", paras_, tm_);
		}
		public async Task<int> GetPositionByPKAsync(int starID, string operatorID, string currencyID, int goal, int position, int multiple, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@StarID", starID, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@Goal", goal, MySqlDbType.Int32),
				Database.CreateInParameter("@Position", position, MySqlDbType.Int32),
				Database.CreateInParameter("@Multiple", multiple, MySqlDbType.Int32),
			};
			return (int)await GetScalarAsync("`Position`", "`StarID` = @StarID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID AND `Goal` = @Goal AND `Position` = @Position AND `Multiple` = @Multiple", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Multiple（字段）
		/// </summary>
		/// /// <param name = "starID">键Key</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码</param>
		/// /// <param name = "goal">用户进球累计值</param>
		/// /// <param name = "position">位置</param>
		/// /// <param name = "multiple">倍数（倍数值*100）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetMultipleByPK(int starID, string operatorID, string currencyID, int goal, int position, int multiple, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@StarID", starID, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@Goal", goal, MySqlDbType.Int32),
				Database.CreateInParameter("@Position", position, MySqlDbType.Int32),
				Database.CreateInParameter("@Multiple", multiple, MySqlDbType.Int32),
			};
			return (int)GetScalar("`Multiple`", "`StarID` = @StarID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID AND `Goal` = @Goal AND `Position` = @Position AND `Multiple` = @Multiple", paras_, tm_);
		}
		public async Task<int> GetMultipleByPKAsync(int starID, string operatorID, string currencyID, int goal, int position, int multiple, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@StarID", starID, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@Goal", goal, MySqlDbType.Int32),
				Database.CreateInParameter("@Position", position, MySqlDbType.Int32),
				Database.CreateInParameter("@Multiple", multiple, MySqlDbType.Int32),
			};
			return (int)await GetScalarAsync("`Multiple`", "`StarID` = @StarID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID AND `Goal` = @Goal AND `Position` = @Position AND `Multiple` = @Multiple", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Odds（字段）
		/// </summary>
		/// /// <param name = "starID">键Key</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码</param>
		/// /// <param name = "goal">用户进球累计值</param>
		/// /// <param name = "position">位置</param>
		/// /// <param name = "multiple">倍数（倍数值*100）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetOddsByPK(int starID, string operatorID, string currencyID, int goal, int position, int multiple, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@StarID", starID, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@Goal", goal, MySqlDbType.Int32),
				Database.CreateInParameter("@Position", position, MySqlDbType.Int32),
				Database.CreateInParameter("@Multiple", multiple, MySqlDbType.Int32),
			};
			return (int)GetScalar("`Odds`", "`StarID` = @StarID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID AND `Goal` = @Goal AND `Position` = @Position AND `Multiple` = @Multiple", paras_, tm_);
		}
		public async Task<int> GetOddsByPKAsync(int starID, string operatorID, string currencyID, int goal, int position, int multiple, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@StarID", starID, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@Goal", goal, MySqlDbType.Int32),
				Database.CreateInParameter("@Position", position, MySqlDbType.Int32),
				Database.CreateInParameter("@Multiple", multiple, MySqlDbType.Int32),
			};
			return (int)await GetScalarAsync("`Odds`", "`StarID` = @StarID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID AND `Goal` = @Goal AND `Position` = @Position AND `Multiple` = @Multiple", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 IsBaseMultiple（字段）
		/// </summary>
		/// /// <param name = "starID">键Key</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码</param>
		/// /// <param name = "goal">用户进球累计值</param>
		/// /// <param name = "position">位置</param>
		/// /// <param name = "multiple">倍数（倍数值*100）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetIsBaseMultipleByPK(int starID, string operatorID, string currencyID, int goal, int position, int multiple, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@StarID", starID, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@Goal", goal, MySqlDbType.Int32),
				Database.CreateInParameter("@Position", position, MySqlDbType.Int32),
				Database.CreateInParameter("@Multiple", multiple, MySqlDbType.Int32),
			};
			return (int)GetScalar("`IsBaseMultiple`", "`StarID` = @StarID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID AND `Goal` = @Goal AND `Position` = @Position AND `Multiple` = @Multiple", paras_, tm_);
		}
		public async Task<int> GetIsBaseMultipleByPKAsync(int starID, string operatorID, string currencyID, int goal, int position, int multiple, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@StarID", starID, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@Goal", goal, MySqlDbType.Int32),
				Database.CreateInParameter("@Position", position, MySqlDbType.Int32),
				Database.CreateInParameter("@Multiple", multiple, MySqlDbType.Int32),
			};
			return (int)await GetScalarAsync("`IsBaseMultiple`", "`StarID` = @StarID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID AND `Goal` = @Goal AND `Position` = @Position AND `Multiple` = @Multiple", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 Surprise（字段）
		/// </summary>
		/// /// <param name = "starID">键Key</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码</param>
		/// /// <param name = "goal">用户进球累计值</param>
		/// /// <param name = "position">位置</param>
		/// /// <param name = "multiple">倍数（倍数值*100）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetSurpriseByPK(int starID, string operatorID, string currencyID, int goal, int position, int multiple, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@StarID", starID, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@Goal", goal, MySqlDbType.Int32),
				Database.CreateInParameter("@Position", position, MySqlDbType.Int32),
				Database.CreateInParameter("@Multiple", multiple, MySqlDbType.Int32),
			};
			return (int)GetScalar("`Surprise`", "`StarID` = @StarID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID AND `Goal` = @Goal AND `Position` = @Position AND `Multiple` = @Multiple", paras_, tm_);
		}
		public async Task<int> GetSurpriseByPKAsync(int starID, string operatorID, string currencyID, int goal, int position, int multiple, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@StarID", starID, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@Goal", goal, MySqlDbType.Int32),
				Database.CreateInParameter("@Position", position, MySqlDbType.Int32),
				Database.CreateInParameter("@Multiple", multiple, MySqlDbType.Int32),
			};
			return (int)await GetScalarAsync("`Surprise`", "`StarID` = @StarID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID AND `Goal` = @Goal AND `Position` = @Position AND `Multiple` = @Multiple", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 RecDate（字段）
		/// </summary>
		/// /// <param name = "starID">键Key</param>
		/// /// <param name = "operatorID">运营商编码</param>
		/// /// <param name = "currencyID">货币编码</param>
		/// /// <param name = "goal">用户进球累计值</param>
		/// /// <param name = "position">位置</param>
		/// /// <param name = "multiple">倍数（倍数值*100）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public DateTime GetRecDateByPK(int starID, string operatorID, string currencyID, int goal, int position, int multiple, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@StarID", starID, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@Goal", goal, MySqlDbType.Int32),
				Database.CreateInParameter("@Position", position, MySqlDbType.Int32),
				Database.CreateInParameter("@Multiple", multiple, MySqlDbType.Int32),
			};
			return (DateTime)GetScalar("`RecDate`", "`StarID` = @StarID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID AND `Goal` = @Goal AND `Position` = @Position AND `Multiple` = @Multiple", paras_, tm_);
		}
		public async Task<DateTime> GetRecDateByPKAsync(int starID, string operatorID, string currencyID, int goal, int position, int multiple, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@StarID", starID, MySqlDbType.Int32),
				Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar),
				Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar),
				Database.CreateInParameter("@Goal", goal, MySqlDbType.Int32),
				Database.CreateInParameter("@Position", position, MySqlDbType.Int32),
				Database.CreateInParameter("@Multiple", multiple, MySqlDbType.Int32),
			};
			return (DateTime)await GetScalarAsync("`RecDate`", "`StarID` = @StarID AND `OperatorID` = @OperatorID AND `CurrencyID` = @CurrencyID AND `Goal` = @Goal AND `Position` = @Position AND `Multiple` = @Multiple", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByStarID
		
		/// <summary>
		/// 按 StarID（字段） 查询
		/// </summary>
		/// /// <param name = "starID">键Key</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_star_oddsEO> GetByStarID(int starID)
		{
			return GetByStarID(starID, 0, string.Empty, null);
		}
		public async Task<List<Bs_config_star_oddsEO>> GetByStarIDAsync(int starID)
		{
			return await GetByStarIDAsync(starID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 StarID（字段） 查询
		/// </summary>
		/// /// <param name = "starID">键Key</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_star_oddsEO> GetByStarID(int starID, TransactionManager tm_)
		{
			return GetByStarID(starID, 0, string.Empty, tm_);
		}
		public async Task<List<Bs_config_star_oddsEO>> GetByStarIDAsync(int starID, TransactionManager tm_)
		{
			return await GetByStarIDAsync(starID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 StarID（字段） 查询
		/// </summary>
		/// /// <param name = "starID">键Key</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_star_oddsEO> GetByStarID(int starID, int top_)
		{
			return GetByStarID(starID, top_, string.Empty, null);
		}
		public async Task<List<Bs_config_star_oddsEO>> GetByStarIDAsync(int starID, int top_)
		{
			return await GetByStarIDAsync(starID, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 StarID（字段） 查询
		/// </summary>
		/// /// <param name = "starID">键Key</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_star_oddsEO> GetByStarID(int starID, int top_, TransactionManager tm_)
		{
			return GetByStarID(starID, top_, string.Empty, tm_);
		}
		public async Task<List<Bs_config_star_oddsEO>> GetByStarIDAsync(int starID, int top_, TransactionManager tm_)
		{
			return await GetByStarIDAsync(starID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 StarID（字段） 查询
		/// </summary>
		/// /// <param name = "starID">键Key</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_star_oddsEO> GetByStarID(int starID, string sort_)
		{
			return GetByStarID(starID, 0, sort_, null);
		}
		public async Task<List<Bs_config_star_oddsEO>> GetByStarIDAsync(int starID, string sort_)
		{
			return await GetByStarIDAsync(starID, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 StarID（字段） 查询
		/// </summary>
		/// /// <param name = "starID">键Key</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_star_oddsEO> GetByStarID(int starID, string sort_, TransactionManager tm_)
		{
			return GetByStarID(starID, 0, sort_, tm_);
		}
		public async Task<List<Bs_config_star_oddsEO>> GetByStarIDAsync(int starID, string sort_, TransactionManager tm_)
		{
			return await GetByStarIDAsync(starID, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 StarID（字段） 查询
		/// </summary>
		/// /// <param name = "starID">键Key</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_star_oddsEO> GetByStarID(int starID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`StarID` = @StarID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@StarID", starID, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Bs_config_star_oddsEO.MapDataReader);
		}
		public async Task<List<Bs_config_star_oddsEO>> GetByStarIDAsync(int starID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`StarID` = @StarID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@StarID", starID, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Bs_config_star_oddsEO.MapDataReader);
		}
		#endregion // GetByStarID
		#region GetByOperatorID
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_star_oddsEO> GetByOperatorID(string operatorID)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, null);
		}
		public async Task<List<Bs_config_star_oddsEO>> GetByOperatorIDAsync(string operatorID)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_star_oddsEO> GetByOperatorID(string operatorID, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, string.Empty, tm_);
		}
		public async Task<List<Bs_config_star_oddsEO>> GetByOperatorIDAsync(string operatorID, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_star_oddsEO> GetByOperatorID(string operatorID, int top_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, null);
		}
		public async Task<List<Bs_config_star_oddsEO>> GetByOperatorIDAsync(string operatorID, int top_)
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
		public List<Bs_config_star_oddsEO> GetByOperatorID(string operatorID, int top_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, top_, string.Empty, tm_);
		}
		public async Task<List<Bs_config_star_oddsEO>> GetByOperatorIDAsync(string operatorID, int top_, TransactionManager tm_)
		{
			return await GetByOperatorIDAsync(operatorID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 OperatorID（字段） 查询
		/// </summary>
		/// /// <param name = "operatorID">运营商编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_star_oddsEO> GetByOperatorID(string operatorID, string sort_)
		{
			return GetByOperatorID(operatorID, 0, sort_, null);
		}
		public async Task<List<Bs_config_star_oddsEO>> GetByOperatorIDAsync(string operatorID, string sort_)
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
		public List<Bs_config_star_oddsEO> GetByOperatorID(string operatorID, string sort_, TransactionManager tm_)
		{
			return GetByOperatorID(operatorID, 0, sort_, tm_);
		}
		public async Task<List<Bs_config_star_oddsEO>> GetByOperatorIDAsync(string operatorID, string sort_, TransactionManager tm_)
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
		public List<Bs_config_star_oddsEO> GetByOperatorID(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorID` = @OperatorID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Bs_config_star_oddsEO.MapDataReader);
		}
		public async Task<List<Bs_config_star_oddsEO>> GetByOperatorIDAsync(string operatorID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`OperatorID` = @OperatorID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@OperatorID", operatorID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Bs_config_star_oddsEO.MapDataReader);
		}
		#endregion // GetByOperatorID
		#region GetByCurrencyID
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币编码</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_star_oddsEO> GetByCurrencyID(string currencyID)
		{
			return GetByCurrencyID(currencyID, 0, string.Empty, null);
		}
		public async Task<List<Bs_config_star_oddsEO>> GetByCurrencyIDAsync(string currencyID)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币编码</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_star_oddsEO> GetByCurrencyID(string currencyID, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, 0, string.Empty, tm_);
		}
		public async Task<List<Bs_config_star_oddsEO>> GetByCurrencyIDAsync(string currencyID, TransactionManager tm_)
		{
			return await GetByCurrencyIDAsync(currencyID, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币编码</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_star_oddsEO> GetByCurrencyID(string currencyID, int top_)
		{
			return GetByCurrencyID(currencyID, top_, string.Empty, null);
		}
		public async Task<List<Bs_config_star_oddsEO>> GetByCurrencyIDAsync(string currencyID, int top_)
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
		public List<Bs_config_star_oddsEO> GetByCurrencyID(string currencyID, int top_, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, top_, string.Empty, tm_);
		}
		public async Task<List<Bs_config_star_oddsEO>> GetByCurrencyIDAsync(string currencyID, int top_, TransactionManager tm_)
		{
			return await GetByCurrencyIDAsync(currencyID, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 CurrencyID（字段） 查询
		/// </summary>
		/// /// <param name = "currencyID">货币编码</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_star_oddsEO> GetByCurrencyID(string currencyID, string sort_)
		{
			return GetByCurrencyID(currencyID, 0, sort_, null);
		}
		public async Task<List<Bs_config_star_oddsEO>> GetByCurrencyIDAsync(string currencyID, string sort_)
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
		public List<Bs_config_star_oddsEO> GetByCurrencyID(string currencyID, string sort_, TransactionManager tm_)
		{
			return GetByCurrencyID(currencyID, 0, sort_, tm_);
		}
		public async Task<List<Bs_config_star_oddsEO>> GetByCurrencyIDAsync(string currencyID, string sort_, TransactionManager tm_)
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
		public List<Bs_config_star_oddsEO> GetByCurrencyID(string currencyID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CurrencyID` = @CurrencyID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
			return Database.ExecSqlList(sql_, paras_, tm_, Bs_config_star_oddsEO.MapDataReader);
		}
		public async Task<List<Bs_config_star_oddsEO>> GetByCurrencyIDAsync(string currencyID, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`CurrencyID` = @CurrencyID", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@CurrencyID", currencyID, MySqlDbType.VarChar));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Bs_config_star_oddsEO.MapDataReader);
		}
		#endregion // GetByCurrencyID
		#region GetByGoal
		
		/// <summary>
		/// 按 Goal（字段） 查询
		/// </summary>
		/// /// <param name = "goal">用户进球累计值</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_star_oddsEO> GetByGoal(int goal)
		{
			return GetByGoal(goal, 0, string.Empty, null);
		}
		public async Task<List<Bs_config_star_oddsEO>> GetByGoalAsync(int goal)
		{
			return await GetByGoalAsync(goal, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Goal（字段） 查询
		/// </summary>
		/// /// <param name = "goal">用户进球累计值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_star_oddsEO> GetByGoal(int goal, TransactionManager tm_)
		{
			return GetByGoal(goal, 0, string.Empty, tm_);
		}
		public async Task<List<Bs_config_star_oddsEO>> GetByGoalAsync(int goal, TransactionManager tm_)
		{
			return await GetByGoalAsync(goal, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Goal（字段） 查询
		/// </summary>
		/// /// <param name = "goal">用户进球累计值</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_star_oddsEO> GetByGoal(int goal, int top_)
		{
			return GetByGoal(goal, top_, string.Empty, null);
		}
		public async Task<List<Bs_config_star_oddsEO>> GetByGoalAsync(int goal, int top_)
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
		public List<Bs_config_star_oddsEO> GetByGoal(int goal, int top_, TransactionManager tm_)
		{
			return GetByGoal(goal, top_, string.Empty, tm_);
		}
		public async Task<List<Bs_config_star_oddsEO>> GetByGoalAsync(int goal, int top_, TransactionManager tm_)
		{
			return await GetByGoalAsync(goal, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Goal（字段） 查询
		/// </summary>
		/// /// <param name = "goal">用户进球累计值</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_star_oddsEO> GetByGoal(int goal, string sort_)
		{
			return GetByGoal(goal, 0, sort_, null);
		}
		public async Task<List<Bs_config_star_oddsEO>> GetByGoalAsync(int goal, string sort_)
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
		public List<Bs_config_star_oddsEO> GetByGoal(int goal, string sort_, TransactionManager tm_)
		{
			return GetByGoal(goal, 0, sort_, tm_);
		}
		public async Task<List<Bs_config_star_oddsEO>> GetByGoalAsync(int goal, string sort_, TransactionManager tm_)
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
		public List<Bs_config_star_oddsEO> GetByGoal(int goal, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Goal` = @Goal", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Goal", goal, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Bs_config_star_oddsEO.MapDataReader);
		}
		public async Task<List<Bs_config_star_oddsEO>> GetByGoalAsync(int goal, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Goal` = @Goal", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Goal", goal, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Bs_config_star_oddsEO.MapDataReader);
		}
		#endregion // GetByGoal
		#region GetByPosition
		
		/// <summary>
		/// 按 Position（字段） 查询
		/// </summary>
		/// /// <param name = "position">位置</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_star_oddsEO> GetByPosition(int position)
		{
			return GetByPosition(position, 0, string.Empty, null);
		}
		public async Task<List<Bs_config_star_oddsEO>> GetByPositionAsync(int position)
		{
			return await GetByPositionAsync(position, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Position（字段） 查询
		/// </summary>
		/// /// <param name = "position">位置</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_star_oddsEO> GetByPosition(int position, TransactionManager tm_)
		{
			return GetByPosition(position, 0, string.Empty, tm_);
		}
		public async Task<List<Bs_config_star_oddsEO>> GetByPositionAsync(int position, TransactionManager tm_)
		{
			return await GetByPositionAsync(position, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Position（字段） 查询
		/// </summary>
		/// /// <param name = "position">位置</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_star_oddsEO> GetByPosition(int position, int top_)
		{
			return GetByPosition(position, top_, string.Empty, null);
		}
		public async Task<List<Bs_config_star_oddsEO>> GetByPositionAsync(int position, int top_)
		{
			return await GetByPositionAsync(position, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Position（字段） 查询
		/// </summary>
		/// /// <param name = "position">位置</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_star_oddsEO> GetByPosition(int position, int top_, TransactionManager tm_)
		{
			return GetByPosition(position, top_, string.Empty, tm_);
		}
		public async Task<List<Bs_config_star_oddsEO>> GetByPositionAsync(int position, int top_, TransactionManager tm_)
		{
			return await GetByPositionAsync(position, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Position（字段） 查询
		/// </summary>
		/// /// <param name = "position">位置</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_star_oddsEO> GetByPosition(int position, string sort_)
		{
			return GetByPosition(position, 0, sort_, null);
		}
		public async Task<List<Bs_config_star_oddsEO>> GetByPositionAsync(int position, string sort_)
		{
			return await GetByPositionAsync(position, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Position（字段） 查询
		/// </summary>
		/// /// <param name = "position">位置</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_star_oddsEO> GetByPosition(int position, string sort_, TransactionManager tm_)
		{
			return GetByPosition(position, 0, sort_, tm_);
		}
		public async Task<List<Bs_config_star_oddsEO>> GetByPositionAsync(int position, string sort_, TransactionManager tm_)
		{
			return await GetByPositionAsync(position, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Position（字段） 查询
		/// </summary>
		/// /// <param name = "position">位置</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_star_oddsEO> GetByPosition(int position, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Position` = @Position", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Position", position, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Bs_config_star_oddsEO.MapDataReader);
		}
		public async Task<List<Bs_config_star_oddsEO>> GetByPositionAsync(int position, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Position` = @Position", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Position", position, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Bs_config_star_oddsEO.MapDataReader);
		}
		#endregion // GetByPosition
		#region GetByMultiple
		
		/// <summary>
		/// 按 Multiple（字段） 查询
		/// </summary>
		/// /// <param name = "multiple">倍数（倍数值*100）</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_star_oddsEO> GetByMultiple(int multiple)
		{
			return GetByMultiple(multiple, 0, string.Empty, null);
		}
		public async Task<List<Bs_config_star_oddsEO>> GetByMultipleAsync(int multiple)
		{
			return await GetByMultipleAsync(multiple, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Multiple（字段） 查询
		/// </summary>
		/// /// <param name = "multiple">倍数（倍数值*100）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_star_oddsEO> GetByMultiple(int multiple, TransactionManager tm_)
		{
			return GetByMultiple(multiple, 0, string.Empty, tm_);
		}
		public async Task<List<Bs_config_star_oddsEO>> GetByMultipleAsync(int multiple, TransactionManager tm_)
		{
			return await GetByMultipleAsync(multiple, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Multiple（字段） 查询
		/// </summary>
		/// /// <param name = "multiple">倍数（倍数值*100）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_star_oddsEO> GetByMultiple(int multiple, int top_)
		{
			return GetByMultiple(multiple, top_, string.Empty, null);
		}
		public async Task<List<Bs_config_star_oddsEO>> GetByMultipleAsync(int multiple, int top_)
		{
			return await GetByMultipleAsync(multiple, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Multiple（字段） 查询
		/// </summary>
		/// /// <param name = "multiple">倍数（倍数值*100）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_star_oddsEO> GetByMultiple(int multiple, int top_, TransactionManager tm_)
		{
			return GetByMultiple(multiple, top_, string.Empty, tm_);
		}
		public async Task<List<Bs_config_star_oddsEO>> GetByMultipleAsync(int multiple, int top_, TransactionManager tm_)
		{
			return await GetByMultipleAsync(multiple, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Multiple（字段） 查询
		/// </summary>
		/// /// <param name = "multiple">倍数（倍数值*100）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_star_oddsEO> GetByMultiple(int multiple, string sort_)
		{
			return GetByMultiple(multiple, 0, sort_, null);
		}
		public async Task<List<Bs_config_star_oddsEO>> GetByMultipleAsync(int multiple, string sort_)
		{
			return await GetByMultipleAsync(multiple, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Multiple（字段） 查询
		/// </summary>
		/// /// <param name = "multiple">倍数（倍数值*100）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_star_oddsEO> GetByMultiple(int multiple, string sort_, TransactionManager tm_)
		{
			return GetByMultiple(multiple, 0, sort_, tm_);
		}
		public async Task<List<Bs_config_star_oddsEO>> GetByMultipleAsync(int multiple, string sort_, TransactionManager tm_)
		{
			return await GetByMultipleAsync(multiple, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Multiple（字段） 查询
		/// </summary>
		/// /// <param name = "multiple">倍数（倍数值*100）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_star_oddsEO> GetByMultiple(int multiple, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Multiple` = @Multiple", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Multiple", multiple, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Bs_config_star_oddsEO.MapDataReader);
		}
		public async Task<List<Bs_config_star_oddsEO>> GetByMultipleAsync(int multiple, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Multiple` = @Multiple", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Multiple", multiple, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Bs_config_star_oddsEO.MapDataReader);
		}
		#endregion // GetByMultiple
		#region GetByOdds
		
		/// <summary>
		/// 按 Odds（字段） 查询
		/// </summary>
		/// /// <param name = "odds">概率（概率值*100000）</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_star_oddsEO> GetByOdds(int odds)
		{
			return GetByOdds(odds, 0, string.Empty, null);
		}
		public async Task<List<Bs_config_star_oddsEO>> GetByOddsAsync(int odds)
		{
			return await GetByOddsAsync(odds, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Odds（字段） 查询
		/// </summary>
		/// /// <param name = "odds">概率（概率值*100000）</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_star_oddsEO> GetByOdds(int odds, TransactionManager tm_)
		{
			return GetByOdds(odds, 0, string.Empty, tm_);
		}
		public async Task<List<Bs_config_star_oddsEO>> GetByOddsAsync(int odds, TransactionManager tm_)
		{
			return await GetByOddsAsync(odds, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Odds（字段） 查询
		/// </summary>
		/// /// <param name = "odds">概率（概率值*100000）</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_star_oddsEO> GetByOdds(int odds, int top_)
		{
			return GetByOdds(odds, top_, string.Empty, null);
		}
		public async Task<List<Bs_config_star_oddsEO>> GetByOddsAsync(int odds, int top_)
		{
			return await GetByOddsAsync(odds, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Odds（字段） 查询
		/// </summary>
		/// /// <param name = "odds">概率（概率值*100000）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_star_oddsEO> GetByOdds(int odds, int top_, TransactionManager tm_)
		{
			return GetByOdds(odds, top_, string.Empty, tm_);
		}
		public async Task<List<Bs_config_star_oddsEO>> GetByOddsAsync(int odds, int top_, TransactionManager tm_)
		{
			return await GetByOddsAsync(odds, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Odds（字段） 查询
		/// </summary>
		/// /// <param name = "odds">概率（概率值*100000）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_star_oddsEO> GetByOdds(int odds, string sort_)
		{
			return GetByOdds(odds, 0, sort_, null);
		}
		public async Task<List<Bs_config_star_oddsEO>> GetByOddsAsync(int odds, string sort_)
		{
			return await GetByOddsAsync(odds, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Odds（字段） 查询
		/// </summary>
		/// /// <param name = "odds">概率（概率值*100000）</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_star_oddsEO> GetByOdds(int odds, string sort_, TransactionManager tm_)
		{
			return GetByOdds(odds, 0, sort_, tm_);
		}
		public async Task<List<Bs_config_star_oddsEO>> GetByOddsAsync(int odds, string sort_, TransactionManager tm_)
		{
			return await GetByOddsAsync(odds, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Odds（字段） 查询
		/// </summary>
		/// /// <param name = "odds">概率（概率值*100000）</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_star_oddsEO> GetByOdds(int odds, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Odds` = @Odds", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Odds", odds, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Bs_config_star_oddsEO.MapDataReader);
		}
		public async Task<List<Bs_config_star_oddsEO>> GetByOddsAsync(int odds, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Odds` = @Odds", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Odds", odds, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Bs_config_star_oddsEO.MapDataReader);
		}
		#endregion // GetByOdds
		#region GetByIsBaseMultiple
		
		/// <summary>
		/// 按 IsBaseMultiple（字段） 查询
		/// </summary>
		/// /// <param name = "isBaseMultiple">是否基础倍数</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_star_oddsEO> GetByIsBaseMultiple(int isBaseMultiple)
		{
			return GetByIsBaseMultiple(isBaseMultiple, 0, string.Empty, null);
		}
		public async Task<List<Bs_config_star_oddsEO>> GetByIsBaseMultipleAsync(int isBaseMultiple)
		{
			return await GetByIsBaseMultipleAsync(isBaseMultiple, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 IsBaseMultiple（字段） 查询
		/// </summary>
		/// /// <param name = "isBaseMultiple">是否基础倍数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_star_oddsEO> GetByIsBaseMultiple(int isBaseMultiple, TransactionManager tm_)
		{
			return GetByIsBaseMultiple(isBaseMultiple, 0, string.Empty, tm_);
		}
		public async Task<List<Bs_config_star_oddsEO>> GetByIsBaseMultipleAsync(int isBaseMultiple, TransactionManager tm_)
		{
			return await GetByIsBaseMultipleAsync(isBaseMultiple, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IsBaseMultiple（字段） 查询
		/// </summary>
		/// /// <param name = "isBaseMultiple">是否基础倍数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_star_oddsEO> GetByIsBaseMultiple(int isBaseMultiple, int top_)
		{
			return GetByIsBaseMultiple(isBaseMultiple, top_, string.Empty, null);
		}
		public async Task<List<Bs_config_star_oddsEO>> GetByIsBaseMultipleAsync(int isBaseMultiple, int top_)
		{
			return await GetByIsBaseMultipleAsync(isBaseMultiple, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 IsBaseMultiple（字段） 查询
		/// </summary>
		/// /// <param name = "isBaseMultiple">是否基础倍数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_star_oddsEO> GetByIsBaseMultiple(int isBaseMultiple, int top_, TransactionManager tm_)
		{
			return GetByIsBaseMultiple(isBaseMultiple, top_, string.Empty, tm_);
		}
		public async Task<List<Bs_config_star_oddsEO>> GetByIsBaseMultipleAsync(int isBaseMultiple, int top_, TransactionManager tm_)
		{
			return await GetByIsBaseMultipleAsync(isBaseMultiple, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 IsBaseMultiple（字段） 查询
		/// </summary>
		/// /// <param name = "isBaseMultiple">是否基础倍数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_star_oddsEO> GetByIsBaseMultiple(int isBaseMultiple, string sort_)
		{
			return GetByIsBaseMultiple(isBaseMultiple, 0, sort_, null);
		}
		public async Task<List<Bs_config_star_oddsEO>> GetByIsBaseMultipleAsync(int isBaseMultiple, string sort_)
		{
			return await GetByIsBaseMultipleAsync(isBaseMultiple, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 IsBaseMultiple（字段） 查询
		/// </summary>
		/// /// <param name = "isBaseMultiple">是否基础倍数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_star_oddsEO> GetByIsBaseMultiple(int isBaseMultiple, string sort_, TransactionManager tm_)
		{
			return GetByIsBaseMultiple(isBaseMultiple, 0, sort_, tm_);
		}
		public async Task<List<Bs_config_star_oddsEO>> GetByIsBaseMultipleAsync(int isBaseMultiple, string sort_, TransactionManager tm_)
		{
			return await GetByIsBaseMultipleAsync(isBaseMultiple, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 IsBaseMultiple（字段） 查询
		/// </summary>
		/// /// <param name = "isBaseMultiple">是否基础倍数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_star_oddsEO> GetByIsBaseMultiple(int isBaseMultiple, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`IsBaseMultiple` = @IsBaseMultiple", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IsBaseMultiple", isBaseMultiple, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Bs_config_star_oddsEO.MapDataReader);
		}
		public async Task<List<Bs_config_star_oddsEO>> GetByIsBaseMultipleAsync(int isBaseMultiple, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`IsBaseMultiple` = @IsBaseMultiple", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@IsBaseMultiple", isBaseMultiple, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Bs_config_star_oddsEO.MapDataReader);
		}
		#endregion // GetByIsBaseMultiple
		#region GetBySurprise
		
		/// <summary>
		/// 按 Surprise（字段） 查询
		/// </summary>
		/// /// <param name = "surprise">是否双倍奖励</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_star_oddsEO> GetBySurprise(int surprise)
		{
			return GetBySurprise(surprise, 0, string.Empty, null);
		}
		public async Task<List<Bs_config_star_oddsEO>> GetBySurpriseAsync(int surprise)
		{
			return await GetBySurpriseAsync(surprise, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Surprise（字段） 查询
		/// </summary>
		/// /// <param name = "surprise">是否双倍奖励</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_star_oddsEO> GetBySurprise(int surprise, TransactionManager tm_)
		{
			return GetBySurprise(surprise, 0, string.Empty, tm_);
		}
		public async Task<List<Bs_config_star_oddsEO>> GetBySurpriseAsync(int surprise, TransactionManager tm_)
		{
			return await GetBySurpriseAsync(surprise, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Surprise（字段） 查询
		/// </summary>
		/// /// <param name = "surprise">是否双倍奖励</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_star_oddsEO> GetBySurprise(int surprise, int top_)
		{
			return GetBySurprise(surprise, top_, string.Empty, null);
		}
		public async Task<List<Bs_config_star_oddsEO>> GetBySurpriseAsync(int surprise, int top_)
		{
			return await GetBySurpriseAsync(surprise, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Surprise（字段） 查询
		/// </summary>
		/// /// <param name = "surprise">是否双倍奖励</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_star_oddsEO> GetBySurprise(int surprise, int top_, TransactionManager tm_)
		{
			return GetBySurprise(surprise, top_, string.Empty, tm_);
		}
		public async Task<List<Bs_config_star_oddsEO>> GetBySurpriseAsync(int surprise, int top_, TransactionManager tm_)
		{
			return await GetBySurpriseAsync(surprise, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Surprise（字段） 查询
		/// </summary>
		/// /// <param name = "surprise">是否双倍奖励</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_star_oddsEO> GetBySurprise(int surprise, string sort_)
		{
			return GetBySurprise(surprise, 0, sort_, null);
		}
		public async Task<List<Bs_config_star_oddsEO>> GetBySurpriseAsync(int surprise, string sort_)
		{
			return await GetBySurpriseAsync(surprise, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Surprise（字段） 查询
		/// </summary>
		/// /// <param name = "surprise">是否双倍奖励</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_star_oddsEO> GetBySurprise(int surprise, string sort_, TransactionManager tm_)
		{
			return GetBySurprise(surprise, 0, sort_, tm_);
		}
		public async Task<List<Bs_config_star_oddsEO>> GetBySurpriseAsync(int surprise, string sort_, TransactionManager tm_)
		{
			return await GetBySurpriseAsync(surprise, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Surprise（字段） 查询
		/// </summary>
		/// /// <param name = "surprise">是否双倍奖励</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_star_oddsEO> GetBySurprise(int surprise, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Surprise` = @Surprise", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Surprise", surprise, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Bs_config_star_oddsEO.MapDataReader);
		}
		public async Task<List<Bs_config_star_oddsEO>> GetBySurpriseAsync(int surprise, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Surprise` = @Surprise", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Surprise", surprise, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Bs_config_star_oddsEO.MapDataReader);
		}
		#endregion // GetBySurprise
		#region GetByRecDate
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">创建时间</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_star_oddsEO> GetByRecDate(DateTime recDate)
		{
			return GetByRecDate(recDate, 0, string.Empty, null);
		}
		public async Task<List<Bs_config_star_oddsEO>> GetByRecDateAsync(DateTime recDate)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">创建时间</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_star_oddsEO> GetByRecDate(DateTime recDate, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, string.Empty, tm_);
		}
		public async Task<List<Bs_config_star_oddsEO>> GetByRecDateAsync(DateTime recDate, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">创建时间</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_star_oddsEO> GetByRecDate(DateTime recDate, int top_)
		{
			return GetByRecDate(recDate, top_, string.Empty, null);
		}
		public async Task<List<Bs_config_star_oddsEO>> GetByRecDateAsync(DateTime recDate, int top_)
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
		public List<Bs_config_star_oddsEO> GetByRecDate(DateTime recDate, int top_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, top_, string.Empty, tm_);
		}
		public async Task<List<Bs_config_star_oddsEO>> GetByRecDateAsync(DateTime recDate, int top_, TransactionManager tm_)
		{
			return await GetByRecDateAsync(recDate, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RecDate（字段） 查询
		/// </summary>
		/// /// <param name = "recDate">创建时间</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Bs_config_star_oddsEO> GetByRecDate(DateTime recDate, string sort_)
		{
			return GetByRecDate(recDate, 0, sort_, null);
		}
		public async Task<List<Bs_config_star_oddsEO>> GetByRecDateAsync(DateTime recDate, string sort_)
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
		public List<Bs_config_star_oddsEO> GetByRecDate(DateTime recDate, string sort_, TransactionManager tm_)
		{
			return GetByRecDate(recDate, 0, sort_, tm_);
		}
		public async Task<List<Bs_config_star_oddsEO>> GetByRecDateAsync(DateTime recDate, string sort_, TransactionManager tm_)
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
		public List<Bs_config_star_oddsEO> GetByRecDate(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return Database.ExecSqlList(sql_, paras_, tm_, Bs_config_star_oddsEO.MapDataReader);
		}
		public async Task<List<Bs_config_star_oddsEO>> GetByRecDateAsync(DateTime recDate, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RecDate` = @RecDate", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RecDate", recDate, MySqlDbType.DateTime));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Bs_config_star_oddsEO.MapDataReader);
		}
		#endregion // GetByRecDate
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
