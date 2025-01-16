/******************************************************
 * 此代码由代码生成器工具自动生成，请不要修改
 * TinyFx代码生成器核心库版本号：1.0.0.0
 * git: https://github.com/jh98net/TinyFx
 * 文档生成时间：2023-12-09 15: 08:16
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
	/// 排行榜配置
	/// 【表 dwp_config_rank 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class Dwp_config_rankEO : IRowMapper<Dwp_config_rankEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public Dwp_config_rankEO()
		{
			this.RankNo = 0;
			this.RankReward = 0;
		}
		#region 主键原始值 & 主键集合
	    
		/// <summary>
		/// 当前对象是否保存原始主键值，当修改了主键值时为 true
		/// </summary>
		public bool HasOriginal { get; protected set; }
		
		private int _originalRankNo;
		/// <summary>
		/// 【数据库中的原始主键 RankNo 值的副本，用于主键值更新】
		/// </summary>
		public int OriginalRankNo
		{
			get { return _originalRankNo; }
			set { HasOriginal = true; _originalRankNo = value; }
		}
	    /// <summary>
	    /// 获取主键集合。key: 数据库字段名称, value: 主键值
	    /// </summary>
	    /// <returns></returns>
	    public Dictionary<string, object> GetPrimaryKeys()
	    {
	        return new Dictionary<string, object>() { { "RankNo", RankNo }, };
	    }
	    /// <summary>
	    /// 获取主键集合JSON格式
	    /// </summary>
	    /// <returns></returns>
	    public string GetPrimaryKeysJson() => SerializerUtil.SerializeJson(GetPrimaryKeys());
		#endregion // 主键原始值
		#region 所有字段
		/// <summary>
		/// 排名
		/// 【主键 int】
		/// </summary>
		[DataMember(Order = 1)]
		public int RankNo { get; set; }
		/// <summary>
		/// 排名奖金
		/// 【字段 bigint】
		/// </summary>
		[DataMember(Order = 2)]
		public long RankReward { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public Dwp_config_rankEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static Dwp_config_rankEO MapDataReader(IDataReader reader)
		{
		    Dwp_config_rankEO ret = new Dwp_config_rankEO();
			ret.RankNo = reader.ToInt32("RankNo");
			ret.OriginalRankNo = ret.RankNo;
			ret.RankReward = reader.ToInt64("RankReward");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 排行榜配置
	/// 【表 dwp_config_rank 的操作类】
	/// </summary>
	[Obsolete]
	public class Dwp_config_rankMO : MySqlTableMO<Dwp_config_rankEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`dwp_config_rank`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public Dwp_config_rankMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public Dwp_config_rankMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public Dwp_config_rankMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(Dwp_config_rankEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(Dwp_config_rankEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(Dwp_config_rankEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`RankNo`, `RankReward`) VALUE (@RankNo, @RankReward);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RankNo", item.RankNo, MySqlDbType.Int32),
				Database.CreateInParameter("@RankReward", item.RankReward, MySqlDbType.Int64),
			};
		}
		public int AddByBatch(IEnumerable<Dwp_config_rankEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<Dwp_config_rankEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<Dwp_config_rankEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`RankNo`, `RankReward`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"({item.RankNo},{item.RankReward}),");
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
		/// /// <param name = "rankNo">排名</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(int rankNo, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(rankNo, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(int rankNo, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(rankNo, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(int rankNo, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `RankNo` = @RankNo";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RankNo", rankNo, MySqlDbType.Int32),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(Dwp_config_rankEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.RankNo, tm_);
		}
		public async Task<int> RemoveAsync(Dwp_config_rankEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.RankNo, tm_);
		}
		#endregion // RemoveByPK
		
		#region RemoveByXXX
		#region RemoveByRankReward
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "rankReward">排名奖金</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByRankReward(long rankReward, TransactionManager tm_ = null)
		{
			RepairRemoveByRankRewardData(rankReward, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByRankRewardAsync(long rankReward, TransactionManager tm_ = null)
		{
			RepairRemoveByRankRewardData(rankReward, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByRankRewardData(long rankReward, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `RankReward` = @RankReward";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RankReward", rankReward, MySqlDbType.Int64));
		}
		#endregion // RemoveByRankReward
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
		public int Put(Dwp_config_rankEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(Dwp_config_rankEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(Dwp_config_rankEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `RankNo` = @RankNo, `RankReward` = @RankReward WHERE `RankNo` = @RankNo_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RankNo", item.RankNo, MySqlDbType.Int32),
				Database.CreateInParameter("@RankReward", item.RankReward, MySqlDbType.Int64),
				Database.CreateInParameter("@RankNo_Original", item.HasOriginal ? item.OriginalRankNo : item.RankNo, MySqlDbType.Int32),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<Dwp_config_rankEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<Dwp_config_rankEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "rankNo">排名</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(int rankNo, string set_, params object[] values_)
		{
			return Put(set_, "`RankNo` = @RankNo", ConcatValues(values_, rankNo));
		}
		public async Task<int> PutByPKAsync(int rankNo, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`RankNo` = @RankNo", ConcatValues(values_, rankNo));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "rankNo">排名</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(int rankNo, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`RankNo` = @RankNo", tm_, ConcatValues(values_, rankNo));
		}
		public async Task<int> PutByPKAsync(int rankNo, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`RankNo` = @RankNo", tm_, ConcatValues(values_, rankNo));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "rankNo">排名</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(int rankNo, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@RankNo", rankNo, MySqlDbType.Int32),
	        };
			return Put(set_, "`RankNo` = @RankNo", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(int rankNo, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@RankNo", rankNo, MySqlDbType.Int32),
	        };
			return await PutAsync(set_, "`RankNo` = @RankNo", ConcatParameters(paras_, newParas_), tm_);
		}
		#endregion // PutByPK
		
		#region PutXXX
		#region PutRankReward
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "rankNo">排名</param>
		/// /// <param name = "rankReward">排名奖金</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRankRewardByPK(int rankNo, long rankReward, TransactionManager tm_ = null)
		{
			RepairPutRankRewardByPKData(rankNo, rankReward, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutRankRewardByPKAsync(int rankNo, long rankReward, TransactionManager tm_ = null)
		{
			RepairPutRankRewardByPKData(rankNo, rankReward, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutRankRewardByPKData(int rankNo, long rankReward, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `RankReward` = @RankReward  WHERE `RankNo` = @RankNo";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RankReward", rankReward, MySqlDbType.Int64),
				Database.CreateInParameter("@RankNo", rankNo, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "rankReward">排名奖金</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutRankReward(long rankReward, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `RankReward` = @RankReward";
			var parameter_ = Database.CreateInParameter("@RankReward", rankReward, MySqlDbType.Int64);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutRankRewardAsync(long rankReward, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `RankReward` = @RankReward";
			var parameter_ = Database.CreateInParameter("@RankReward", rankReward, MySqlDbType.Int64);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutRankReward
		#endregion // PutXXX
		#endregion // Put
	   
		#region Set
		
		/// <summary>
		/// 插入或者更新数据
		/// </summary>
		/// <param name = "item">要更新的实体对象</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>true:插入操作；false:更新操作</return>
		public bool Set(Dwp_config_rankEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.RankNo) == null)
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
		public async Task<bool> SetAsync(Dwp_config_rankEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.RankNo) == null)
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
		/// /// <param name = "rankNo">排名</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public Dwp_config_rankEO GetByPK(int rankNo, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(rankNo, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, Dwp_config_rankEO.MapDataReader);
		}
		public async Task<Dwp_config_rankEO> GetByPKAsync(int rankNo, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(rankNo, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Dwp_config_rankEO.MapDataReader);
		}
		private void RepairGetByPKData(int rankNo, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`RankNo` = @RankNo", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RankNo", rankNo, MySqlDbType.Int32),
			};
		}
		#endregion // GetByPK
		
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 RankReward（字段）
		/// </summary>
		/// /// <param name = "rankNo">排名</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public long GetRankRewardByPK(int rankNo, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RankNo", rankNo, MySqlDbType.Int32),
			};
			return (long)GetScalar("`RankReward`", "`RankNo` = @RankNo", paras_, tm_);
		}
		public async Task<long> GetRankRewardByPKAsync(int rankNo, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@RankNo", rankNo, MySqlDbType.Int32),
			};
			return (long)await GetScalarAsync("`RankReward`", "`RankNo` = @RankNo", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByRankReward
		
		/// <summary>
		/// 按 RankReward（字段） 查询
		/// </summary>
		/// /// <param name = "rankReward">排名奖金</param>
		/// <return>实体对象集合</return>
		public List<Dwp_config_rankEO> GetByRankReward(long rankReward)
		{
			return GetByRankReward(rankReward, 0, string.Empty, null);
		}
		public async Task<List<Dwp_config_rankEO>> GetByRankRewardAsync(long rankReward)
		{
			return await GetByRankRewardAsync(rankReward, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RankReward（字段） 查询
		/// </summary>
		/// /// <param name = "rankReward">排名奖金</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Dwp_config_rankEO> GetByRankReward(long rankReward, TransactionManager tm_)
		{
			return GetByRankReward(rankReward, 0, string.Empty, tm_);
		}
		public async Task<List<Dwp_config_rankEO>> GetByRankRewardAsync(long rankReward, TransactionManager tm_)
		{
			return await GetByRankRewardAsync(rankReward, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RankReward（字段） 查询
		/// </summary>
		/// /// <param name = "rankReward">排名奖金</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Dwp_config_rankEO> GetByRankReward(long rankReward, int top_)
		{
			return GetByRankReward(rankReward, top_, string.Empty, null);
		}
		public async Task<List<Dwp_config_rankEO>> GetByRankRewardAsync(long rankReward, int top_)
		{
			return await GetByRankRewardAsync(rankReward, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 RankReward（字段） 查询
		/// </summary>
		/// /// <param name = "rankReward">排名奖金</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Dwp_config_rankEO> GetByRankReward(long rankReward, int top_, TransactionManager tm_)
		{
			return GetByRankReward(rankReward, top_, string.Empty, tm_);
		}
		public async Task<List<Dwp_config_rankEO>> GetByRankRewardAsync(long rankReward, int top_, TransactionManager tm_)
		{
			return await GetByRankRewardAsync(rankReward, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 RankReward（字段） 查询
		/// </summary>
		/// /// <param name = "rankReward">排名奖金</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Dwp_config_rankEO> GetByRankReward(long rankReward, string sort_)
		{
			return GetByRankReward(rankReward, 0, sort_, null);
		}
		public async Task<List<Dwp_config_rankEO>> GetByRankRewardAsync(long rankReward, string sort_)
		{
			return await GetByRankRewardAsync(rankReward, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 RankReward（字段） 查询
		/// </summary>
		/// /// <param name = "rankReward">排名奖金</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Dwp_config_rankEO> GetByRankReward(long rankReward, string sort_, TransactionManager tm_)
		{
			return GetByRankReward(rankReward, 0, sort_, tm_);
		}
		public async Task<List<Dwp_config_rankEO>> GetByRankRewardAsync(long rankReward, string sort_, TransactionManager tm_)
		{
			return await GetByRankRewardAsync(rankReward, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 RankReward（字段） 查询
		/// </summary>
		/// /// <param name = "rankReward">排名奖金</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Dwp_config_rankEO> GetByRankReward(long rankReward, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RankReward` = @RankReward", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RankReward", rankReward, MySqlDbType.Int64));
			return Database.ExecSqlList(sql_, paras_, tm_, Dwp_config_rankEO.MapDataReader);
		}
		public async Task<List<Dwp_config_rankEO>> GetByRankRewardAsync(long rankReward, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`RankReward` = @RankReward", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@RankReward", rankReward, MySqlDbType.Int64));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Dwp_config_rankEO.MapDataReader);
		}
		#endregion // GetByRankReward
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
