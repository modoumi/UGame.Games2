/******************************************************
 * 此代码由代码生成器工具自动生成，请不要修改
 * TinyFx代码生成器核心库版本号：1.0.0.0
 * git: https://github.com/jh98net/TinyFx
 * 文档生成时间：2023-12-09 15: 08:17
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
	/// 星星对应权重
	/// 【表 dwp_config_star_weight 的实体类】
	/// </summary>
	[DataContract]
	[Obsolete]
	public class Dwp_config_star_weightEO : IRowMapper<Dwp_config_star_weightEO>
	{
		/// <summary>
		/// 构造函数 
		/// </summary>
		public Dwp_config_star_weightEO()
		{
			this.Multip = 0;
			this.HitRatio = 0d;
		}
		#region 主键原始值 & 主键集合
	    
		/// <summary>
		/// 当前对象是否保存原始主键值，当修改了主键值时为 true
		/// </summary>
		public bool HasOriginal { get; protected set; }
		
		private int _originalStarNum;
		/// <summary>
		/// 【数据库中的原始主键 StarNum 值的副本，用于主键值更新】
		/// </summary>
		public int OriginalStarNum
		{
			get { return _originalStarNum; }
			set { HasOriginal = true; _originalStarNum = value; }
		}
	    /// <summary>
	    /// 获取主键集合。key: 数据库字段名称, value: 主键值
	    /// </summary>
	    /// <returns></returns>
	    public Dictionary<string, object> GetPrimaryKeys()
	    {
	        return new Dictionary<string, object>() { { "StarNum", StarNum }, };
	    }
	    /// <summary>
	    /// 获取主键集合JSON格式
	    /// </summary>
	    /// <returns></returns>
	    public string GetPrimaryKeysJson() => SerializerUtil.SerializeJson(GetPrimaryKeys());
		#endregion // 主键原始值
		#region 所有字段
		/// <summary>
		/// 星星数-主键
		/// 【主键 int】
		/// </summary>
		[DataMember(Order = 1)]
		public int StarNum { get; set; }
		/// <summary>
		/// 倍数
		/// 【字段 int】
		/// </summary>
		[DataMember(Order = 2)]
		public int Multip { get; set; }
		/// <summary>
		/// 中奖率
		/// 【字段 double】
		/// </summary>
		[DataMember(Order = 3)]
		public double HitRatio { get; set; }
		#endregion // 所有列
		#region 实体映射
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public Dwp_config_star_weightEO MapRow(IDataReader reader)
		{
			return MapDataReader(reader);
		}
		
		/// <summary>
		/// 将IDataReader映射成实体对象
		/// </summary>
		/// <param name = "reader">只进结果集流</param>
		/// <return>实体对象</return>
		public static Dwp_config_star_weightEO MapDataReader(IDataReader reader)
		{
		    Dwp_config_star_weightEO ret = new Dwp_config_star_weightEO();
			ret.StarNum = reader.ToInt32("StarNum");
			ret.OriginalStarNum = ret.StarNum;
			ret.Multip = reader.ToInt32("Multip");
			ret.HitRatio = reader.ToDouble("HitRatio");
		    return ret;
		}
		
		#endregion
	}
	#endregion // EO

	#region MO
	/// <summary>
	/// 星星对应权重
	/// 【表 dwp_config_star_weight 的操作类】
	/// </summary>
	[Obsolete]
	public class Dwp_config_star_weightMO : MySqlTableMO<Dwp_config_star_weightEO>
	{
		/// <summary>
		/// 表名
		/// </summary>
	    public override string TableName { get; set; } = "`dwp_config_star_weight`";
	    
		#region Constructors
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "database">数据来源</param>
		public Dwp_config_star_weightMO(MySqlDatabase database) : base(database) { }
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
		public Dwp_config_star_weightMO(string connectionStringName = null) : base(connectionStringName) { }
	    /// <summary>
	    /// 构造函数
	    /// </summary>
	    /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
	    /// <param name="commandTimeout">CommandTimeout时间</param>
	    public Dwp_config_star_weightMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
		#endregion // Constructors
	    
	    #region  Add
		/// <summary>
		/// 插入数据
		/// </summary>
		/// <param name = "item">要插入的实体对象</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="useIgnore_">是否使用INSERT IGNORE</param>
		/// <return>受影响的行数</return>
		public override int Add(Dwp_config_star_weightEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_); 
		}
		public override async Task<int> AddAsync(Dwp_config_star_weightEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
		{
			RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_); 
		}
	    private void RepairAddData(Dwp_config_star_weightEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
			sql_ += $" INTO {TableName} (`StarNum`, `Multip`, `HitRatio`) VALUE (@StarNum, @Multip, @HitRatio);";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@StarNum", item.StarNum, MySqlDbType.Int32),
				Database.CreateInParameter("@Multip", item.Multip, MySqlDbType.Int32),
				Database.CreateInParameter("@HitRatio", item.HitRatio, MySqlDbType.Double),
			};
		}
		public int AddByBatch(IEnumerable<Dwp_config_star_weightEO> items, int batchCount, TransactionManager tm_ = null)
		{
			var ret = 0;
			foreach (var sql in BuildAddBatchSql(items, batchCount))
			{
				ret += Database.ExecSqlNonQuery(sql, tm_);
	        }
			return ret;
		}
	    public async Task<int> AddByBatchAsync(IEnumerable<Dwp_config_star_weightEO> items, int batchCount, TransactionManager tm_ = null)
	    {
	        var ret = 0;
	        foreach (var sql in BuildAddBatchSql(items, batchCount))
	        {
	            ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
	        }
	        return ret;
	    }
	    private IEnumerable<string> BuildAddBatchSql(IEnumerable<Dwp_config_star_weightEO> items, int batchCount)
		{
			var count = 0;
	        var insertSql = $"INSERT INTO {TableName} (`StarNum`, `Multip`, `HitRatio`) VALUES ";
			var sql = new StringBuilder();
	        foreach (var item in items)
			{
				count++;
				sql.Append($"({item.StarNum},{item.Multip},{item.HitRatio}),");
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
		/// /// <param name = "starNum">星星数-主键</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByPK(int starNum, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(starNum, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByPKAsync(int starNum, TransactionManager tm_ = null)
		{
			RepiarRemoveByPKData(starNum, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepiarRemoveByPKData(int starNum, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `StarNum` = @StarNum";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@StarNum", starNum, MySqlDbType.Int32),
			};
		}
		/// <summary>
		/// 删除指定实体对应的记录
		/// </summary>
		/// <param name = "item">要删除的实体</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Remove(Dwp_config_star_weightEO item, TransactionManager tm_ = null)
		{
			return RemoveByPK(item.StarNum, tm_);
		}
		public async Task<int> RemoveAsync(Dwp_config_star_weightEO item, TransactionManager tm_ = null)
		{
			return await RemoveByPKAsync(item.StarNum, tm_);
		}
		#endregion // RemoveByPK
		
		#region RemoveByXXX
		#region RemoveByMultip
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "multip">倍数</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByMultip(int multip, TransactionManager tm_ = null)
		{
			RepairRemoveByMultipData(multip, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByMultipAsync(int multip, TransactionManager tm_ = null)
		{
			RepairRemoveByMultipData(multip, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByMultipData(int multip, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `Multip` = @Multip";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Multip", multip, MySqlDbType.Int32));
		}
		#endregion // RemoveByMultip
		#region RemoveByHitRatio
		/// <summary>
		/// 按字段删除
		/// </summary>
		/// /// <param name = "hitRatio">中奖率</param>
		/// <param name="tm_">事务管理对象</param>
		public int RemoveByHitRatio(double hitRatio, TransactionManager tm_ = null)
		{
			RepairRemoveByHitRatioData(hitRatio, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> RemoveByHitRatioAsync(double hitRatio, TransactionManager tm_ = null)
		{
			RepairRemoveByHitRatioData(hitRatio, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairRemoveByHitRatioData(double hitRatio, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"DELETE FROM {TableName} WHERE `HitRatio` = @HitRatio";
			paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@HitRatio", hitRatio, MySqlDbType.Double));
		}
		#endregion // RemoveByHitRatio
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
		public int Put(Dwp_config_star_weightEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutAsync(Dwp_config_star_weightEO item, TransactionManager tm_ = null)
		{
			RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutData(Dwp_config_star_weightEO item, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `StarNum` = @StarNum, `Multip` = @Multip, `HitRatio` = @HitRatio WHERE `StarNum` = @StarNum_Original";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@StarNum", item.StarNum, MySqlDbType.Int32),
				Database.CreateInParameter("@Multip", item.Multip, MySqlDbType.Int32),
				Database.CreateInParameter("@HitRatio", item.HitRatio, MySqlDbType.Double),
				Database.CreateInParameter("@StarNum_Original", item.HasOriginal ? item.OriginalStarNum : item.StarNum, MySqlDbType.Int32),
			};
		}
		
		/// <summary>
		/// 更新实体集合到数据库
		/// </summary>
		/// <param name = "items">要更新的实体对象集合</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int Put(IEnumerable<Dwp_config_star_weightEO> items, TransactionManager tm_ = null)
		{
			int ret = 0;
			foreach (var item in items)
			{
		        ret += Put(item, tm_);
			}
			return ret;
		}
		public async Task<int> PutAsync(IEnumerable<Dwp_config_star_weightEO> items, TransactionManager tm_ = null)
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
		/// /// <param name = "starNum">星星数-主键</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(int starNum, string set_, params object[] values_)
		{
			return Put(set_, "`StarNum` = @StarNum", ConcatValues(values_, starNum));
		}
		public async Task<int> PutByPKAsync(int starNum, string set_, params object[] values_)
		{
			return await PutAsync(set_, "`StarNum` = @StarNum", ConcatValues(values_, starNum));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "starNum">星星数-主键</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="values_">参数值</param>
		/// <return>受影响的行数</return>
		public int PutByPK(int starNum, string set_, TransactionManager tm_, params object[] values_)
		{
			return Put(set_, "`StarNum` = @StarNum", tm_, ConcatValues(values_, starNum));
		}
		public async Task<int> PutByPKAsync(int starNum, string set_, TransactionManager tm_, params object[] values_)
		{
			return await PutAsync(set_, "`StarNum` = @StarNum", tm_, ConcatValues(values_, starNum));
		}
		/// <summary>
		/// 按主键更新指定列数据
		/// </summary>
		/// /// <param name = "starNum">星星数-主键</param>
		/// <param name = "set_">更新的列数据</param>
		/// <param name="paras_">参数值</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutByPK(int starNum, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@StarNum", starNum, MySqlDbType.Int32),
	        };
			return Put(set_, "`StarNum` = @StarNum", ConcatParameters(paras_, newParas_), tm_);
		}
		public async Task<int> PutByPKAsync(int starNum, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
		{
			var newParas_ = new List<MySqlParameter>() {
				Database.CreateInParameter("@StarNum", starNum, MySqlDbType.Int32),
	        };
			return await PutAsync(set_, "`StarNum` = @StarNum", ConcatParameters(paras_, newParas_), tm_);
		}
		#endregion // PutByPK
		
		#region PutXXX
		#region PutMultip
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "starNum">星星数-主键</param>
		/// /// <param name = "multip">倍数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutMultipByPK(int starNum, int multip, TransactionManager tm_ = null)
		{
			RepairPutMultipByPKData(starNum, multip, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutMultipByPKAsync(int starNum, int multip, TransactionManager tm_ = null)
		{
			RepairPutMultipByPKData(starNum, multip, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutMultipByPKData(int starNum, int multip, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `Multip` = @Multip  WHERE `StarNum` = @StarNum";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@Multip", multip, MySqlDbType.Int32),
				Database.CreateInParameter("@StarNum", starNum, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "multip">倍数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutMultip(int multip, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Multip` = @Multip";
			var parameter_ = Database.CreateInParameter("@Multip", multip, MySqlDbType.Int32);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutMultipAsync(int multip, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `Multip` = @Multip";
			var parameter_ = Database.CreateInParameter("@Multip", multip, MySqlDbType.Int32);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutMultip
		#region PutHitRatio
		/// <summary>
		/// 按主键更新列数据
		/// </summary>
		/// /// <param name = "starNum">星星数-主键</param>
		/// /// <param name = "hitRatio">中奖率</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutHitRatioByPK(int starNum, double hitRatio, TransactionManager tm_ = null)
		{
			RepairPutHitRatioByPKData(starNum, hitRatio, out string sql_, out List<MySqlParameter> paras_);
			return Database.ExecSqlNonQuery(sql_, paras_, tm_);
		}
		public async Task<int> PutHitRatioByPKAsync(int starNum, double hitRatio, TransactionManager tm_ = null)
		{
			RepairPutHitRatioByPKData(starNum, hitRatio, out string sql_, out List<MySqlParameter> paras_);
			return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
		}
		private void RepairPutHitRatioByPKData(int starNum, double hitRatio, out string sql_, out List<MySqlParameter> paras_)
		{
			sql_ = $"UPDATE {TableName} SET `HitRatio` = @HitRatio  WHERE `StarNum` = @StarNum";
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@HitRatio", hitRatio, MySqlDbType.Double),
				Database.CreateInParameter("@StarNum", starNum, MySqlDbType.Int32),
			};
		}
	 
		/// <summary>
		/// 更新一列数据
		/// </summary>
		/// /// <param name = "hitRatio">中奖率</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>受影响的行数</return>
		public int PutHitRatio(double hitRatio, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `HitRatio` = @HitRatio";
			var parameter_ = Database.CreateInParameter("@HitRatio", hitRatio, MySqlDbType.Double);
			return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		public async Task<int> PutHitRatioAsync(double hitRatio, TransactionManager tm_ = null)
		{
			string sql_ = $"UPDATE {TableName} SET `HitRatio` = @HitRatio";
			var parameter_ = Database.CreateInParameter("@HitRatio", hitRatio, MySqlDbType.Double);
			return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
		}
		#endregion // PutHitRatio
		#endregion // PutXXX
		#endregion // Put
	   
		#region Set
		
		/// <summary>
		/// 插入或者更新数据
		/// </summary>
		/// <param name = "item">要更新的实体对象</param>
		/// <param name="tm">事务管理对象</param>
		/// <return>true:插入操作；false:更新操作</return>
		public bool Set(Dwp_config_star_weightEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.StarNum) == null)
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
		public async Task<bool> SetAsync(Dwp_config_star_weightEO item, TransactionManager tm = null)
		{
			bool ret = true;
			if(GetByPK(item.StarNum) == null)
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
		/// /// <param name = "starNum">星星数-主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
		/// <return></return>
		public Dwp_config_star_weightEO GetByPK(int starNum, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(starNum, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return Database.ExecSqlSingle(sql_, paras_, tm_, Dwp_config_star_weightEO.MapDataReader);
		}
		public async Task<Dwp_config_star_weightEO> GetByPKAsync(int starNum, TransactionManager tm_ = null, bool isForUpdate_ = false)
		{
			RepairGetByPKData(starNum, out string sql_, out List<MySqlParameter> paras_, isForUpdate_, tm_);
			return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Dwp_config_star_weightEO.MapDataReader);
		}
		private void RepairGetByPKData(int starNum, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false, TransactionManager tm_ = null)
		{
			sql_ = BuildSelectSQL("`StarNum` = @StarNum", 0, null, null, isForUpdate_);
			paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@StarNum", starNum, MySqlDbType.Int32),
			};
		}
		#endregion // GetByPK
		
		#region GetXXXByPK
		
		/// <summary>
		/// 按主键查询 Multip（字段）
		/// </summary>
		/// /// <param name = "starNum">星星数-主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public int GetMultipByPK(int starNum, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@StarNum", starNum, MySqlDbType.Int32),
			};
			return (int)GetScalar("`Multip`", "`StarNum` = @StarNum", paras_, tm_);
		}
		public async Task<int> GetMultipByPKAsync(int starNum, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@StarNum", starNum, MySqlDbType.Int32),
			};
			return (int)await GetScalarAsync("`Multip`", "`StarNum` = @StarNum", paras_, tm_);
		}
		
		/// <summary>
		/// 按主键查询 HitRatio（字段）
		/// </summary>
		/// /// <param name = "starNum">星星数-主键</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return></return>
		public double GetHitRatioByPK(int starNum, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@StarNum", starNum, MySqlDbType.Int32),
			};
			return (double)GetScalar("`HitRatio`", "`StarNum` = @StarNum", paras_, tm_);
		}
		public async Task<double> GetHitRatioByPKAsync(int starNum, TransactionManager tm_ = null)
		{
			var paras_ = new List<MySqlParameter>() 
			{
				Database.CreateInParameter("@StarNum", starNum, MySqlDbType.Int32),
			};
			return (double)await GetScalarAsync("`HitRatio`", "`StarNum` = @StarNum", paras_, tm_);
		}
		#endregion // GetXXXByPK
		#region GetByXXX
		#region GetByMultip
		
		/// <summary>
		/// 按 Multip（字段） 查询
		/// </summary>
		/// /// <param name = "multip">倍数</param>
		/// <return>实体对象集合</return>
		public List<Dwp_config_star_weightEO> GetByMultip(int multip)
		{
			return GetByMultip(multip, 0, string.Empty, null);
		}
		public async Task<List<Dwp_config_star_weightEO>> GetByMultipAsync(int multip)
		{
			return await GetByMultipAsync(multip, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Multip（字段） 查询
		/// </summary>
		/// /// <param name = "multip">倍数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Dwp_config_star_weightEO> GetByMultip(int multip, TransactionManager tm_)
		{
			return GetByMultip(multip, 0, string.Empty, tm_);
		}
		public async Task<List<Dwp_config_star_weightEO>> GetByMultipAsync(int multip, TransactionManager tm_)
		{
			return await GetByMultipAsync(multip, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Multip（字段） 查询
		/// </summary>
		/// /// <param name = "multip">倍数</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Dwp_config_star_weightEO> GetByMultip(int multip, int top_)
		{
			return GetByMultip(multip, top_, string.Empty, null);
		}
		public async Task<List<Dwp_config_star_weightEO>> GetByMultipAsync(int multip, int top_)
		{
			return await GetByMultipAsync(multip, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 Multip（字段） 查询
		/// </summary>
		/// /// <param name = "multip">倍数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Dwp_config_star_weightEO> GetByMultip(int multip, int top_, TransactionManager tm_)
		{
			return GetByMultip(multip, top_, string.Empty, tm_);
		}
		public async Task<List<Dwp_config_star_weightEO>> GetByMultipAsync(int multip, int top_, TransactionManager tm_)
		{
			return await GetByMultipAsync(multip, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 Multip（字段） 查询
		/// </summary>
		/// /// <param name = "multip">倍数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Dwp_config_star_weightEO> GetByMultip(int multip, string sort_)
		{
			return GetByMultip(multip, 0, sort_, null);
		}
		public async Task<List<Dwp_config_star_weightEO>> GetByMultipAsync(int multip, string sort_)
		{
			return await GetByMultipAsync(multip, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 Multip（字段） 查询
		/// </summary>
		/// /// <param name = "multip">倍数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Dwp_config_star_weightEO> GetByMultip(int multip, string sort_, TransactionManager tm_)
		{
			return GetByMultip(multip, 0, sort_, tm_);
		}
		public async Task<List<Dwp_config_star_weightEO>> GetByMultipAsync(int multip, string sort_, TransactionManager tm_)
		{
			return await GetByMultipAsync(multip, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 Multip（字段） 查询
		/// </summary>
		/// /// <param name = "multip">倍数</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Dwp_config_star_weightEO> GetByMultip(int multip, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Multip` = @Multip", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Multip", multip, MySqlDbType.Int32));
			return Database.ExecSqlList(sql_, paras_, tm_, Dwp_config_star_weightEO.MapDataReader);
		}
		public async Task<List<Dwp_config_star_weightEO>> GetByMultipAsync(int multip, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`Multip` = @Multip", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@Multip", multip, MySqlDbType.Int32));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Dwp_config_star_weightEO.MapDataReader);
		}
		#endregion // GetByMultip
		#region GetByHitRatio
		
		/// <summary>
		/// 按 HitRatio（字段） 查询
		/// </summary>
		/// /// <param name = "hitRatio">中奖率</param>
		/// <return>实体对象集合</return>
		public List<Dwp_config_star_weightEO> GetByHitRatio(double hitRatio)
		{
			return GetByHitRatio(hitRatio, 0, string.Empty, null);
		}
		public async Task<List<Dwp_config_star_weightEO>> GetByHitRatioAsync(double hitRatio)
		{
			return await GetByHitRatioAsync(hitRatio, 0, string.Empty, null);
		}
		
		/// <summary>
		/// 按 HitRatio（字段） 查询
		/// </summary>
		/// /// <param name = "hitRatio">中奖率</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Dwp_config_star_weightEO> GetByHitRatio(double hitRatio, TransactionManager tm_)
		{
			return GetByHitRatio(hitRatio, 0, string.Empty, tm_);
		}
		public async Task<List<Dwp_config_star_weightEO>> GetByHitRatioAsync(double hitRatio, TransactionManager tm_)
		{
			return await GetByHitRatioAsync(hitRatio, 0, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 HitRatio（字段） 查询
		/// </summary>
		/// /// <param name = "hitRatio">中奖率</param>
		/// <param name = "top_">获取行数</param>
		/// <return>实体对象集合</return>
		public List<Dwp_config_star_weightEO> GetByHitRatio(double hitRatio, int top_)
		{
			return GetByHitRatio(hitRatio, top_, string.Empty, null);
		}
		public async Task<List<Dwp_config_star_weightEO>> GetByHitRatioAsync(double hitRatio, int top_)
		{
			return await GetByHitRatioAsync(hitRatio, top_, string.Empty, null);
		}
		
		/// <summary>
		/// 按 HitRatio（字段） 查询
		/// </summary>
		/// /// <param name = "hitRatio">中奖率</param>
		/// <param name = "top_">获取行数</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Dwp_config_star_weightEO> GetByHitRatio(double hitRatio, int top_, TransactionManager tm_)
		{
			return GetByHitRatio(hitRatio, top_, string.Empty, tm_);
		}
		public async Task<List<Dwp_config_star_weightEO>> GetByHitRatioAsync(double hitRatio, int top_, TransactionManager tm_)
		{
			return await GetByHitRatioAsync(hitRatio, top_, string.Empty, tm_);
		}
		
		/// <summary>
		/// 按 HitRatio（字段） 查询
		/// </summary>
		/// /// <param name = "hitRatio">中奖率</param>
		/// <param name = "sort_">排序表达式</param>
		/// <return>实体对象集合</return>
		public List<Dwp_config_star_weightEO> GetByHitRatio(double hitRatio, string sort_)
		{
			return GetByHitRatio(hitRatio, 0, sort_, null);
		}
		public async Task<List<Dwp_config_star_weightEO>> GetByHitRatioAsync(double hitRatio, string sort_)
		{
			return await GetByHitRatioAsync(hitRatio, 0, sort_, null);
		}
		
		/// <summary>
		/// 按 HitRatio（字段） 查询
		/// </summary>
		/// /// <param name = "hitRatio">中奖率</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Dwp_config_star_weightEO> GetByHitRatio(double hitRatio, string sort_, TransactionManager tm_)
		{
			return GetByHitRatio(hitRatio, 0, sort_, tm_);
		}
		public async Task<List<Dwp_config_star_weightEO>> GetByHitRatioAsync(double hitRatio, string sort_, TransactionManager tm_)
		{
			return await GetByHitRatioAsync(hitRatio, 0, sort_, tm_);
		}
		
		/// <summary>
		/// 按 HitRatio（字段） 查询
		/// </summary>
		/// /// <param name = "hitRatio">中奖率</param>
		/// <param name = "top_">获取行数</param>
		/// <param name = "sort_">排序表达式</param>
		/// <param name="tm_">事务管理对象</param>
		/// <return>实体对象集合</return>
		public List<Dwp_config_star_weightEO> GetByHitRatio(double hitRatio, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`HitRatio` = @HitRatio", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@HitRatio", hitRatio, MySqlDbType.Double));
			return Database.ExecSqlList(sql_, paras_, tm_, Dwp_config_star_weightEO.MapDataReader);
		}
		public async Task<List<Dwp_config_star_weightEO>> GetByHitRatioAsync(double hitRatio, int top_, string sort_, TransactionManager tm_)
		{
			var sql_ = BuildSelectSQL("`HitRatio` = @HitRatio", top_, sort_);
			var paras_ = new List<MySqlParameter>();
			paras_.Add(Database.CreateInParameter("@HitRatio", hitRatio, MySqlDbType.Double));
			return await Database.ExecSqlListAsync(sql_, paras_, tm_, Dwp_config_star_weightEO.MapDataReader);
		}
		#endregion // GetByHitRatio
		#endregion // GetByXXX
		#endregion // Get
	}
	#endregion // MO
}
