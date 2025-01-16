/******************************************************
 * 此代码由代码生成器工具自动生成，请不要修改
 * TinyFx代码生成器核心库版本号：1.0.0.0
 * git: https://github.com/jh98net/TinyFx
 * 文档生成时间：2023-07-13 16: 28:46
 ******************************************************/
using MySql.Data.MySqlClient;
using System.Data;
using System.Runtime.Serialization;
using System.Text;
using TinyFx;
using TinyFx.Data;
using TinyFx.Data.MySql;

namespace Dragon_tower.DAL
{
    #region EO
    /// <summary>
    /// 用户扩展数据
    /// 【表 gdt_user_data 的实体类】
    /// </summary>
    [DataContract]
    public class Gdt_user_dataEO : IRowMapper<Gdt_user_dataEO>
    {
        /// <summary>
        /// 构造函数 
        /// </summary>
        public Gdt_user_dataEO()
        {
            this.ChipsID = 0;
            this.FreeSpinCount = 0;
            this.FreeSpinTotalReward = 0;
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

        private int _originalChipsID;
        /// <summary>
        /// 【数据库中的原始主键 ChipsID 值的副本，用于主键值更新】
        /// </summary>
        public int OriginalChipsID
        {
            get { return _originalChipsID; }
            set { HasOriginal = true; _originalChipsID = value; }
        }
        /// <summary>
        /// 获取主键集合。key: 数据库字段名称, value: 主键值
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, object> GetPrimaryKeys()
        {
            return new Dictionary<string, object>() { { "UserID", UserID }, { "ChipsID", ChipsID }, };
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
        /// 下注id
        /// 【主键 int】
        /// </summary>
        [DataMember(Order = 2)]
        public int ChipsID { get; set; }
        /// <summary>
        /// FreeSpin次数
        /// 【字段 int】
        /// </summary>
        [DataMember(Order = 3)]
        public int FreeSpinCount { get; set; }
        /// <summary>
        /// FreeSpin次数的总奖励
        /// 【字段 bigint】
        /// </summary>
        [DataMember(Order = 4)]
        public long FreeSpinTotalReward { get; set; }
        /// <summary>
        /// 记录最后记录时间
        /// 【字段 datetime】
        /// </summary>
        [DataMember(Order = 5)]
        public DateTime? LastRecDate { get; set; }
        #endregion // 所有列
        #region 实体映射

        /// <summary>
        /// 将IDataReader映射成实体对象
        /// </summary>
        /// <param name = "reader">只进结果集流</param>
        /// <return>实体对象</return>
        public Gdt_user_dataEO MapRow(IDataReader reader)
        {
            return MapDataReader(reader);
        }

        /// <summary>
        /// 将IDataReader映射成实体对象
        /// </summary>
        /// <param name = "reader">只进结果集流</param>
        /// <return>实体对象</return>
        public static Gdt_user_dataEO MapDataReader(IDataReader reader)
        {
            Gdt_user_dataEO ret = new Gdt_user_dataEO();
            ret.UserID = reader.ToString("UserID");
            ret.OriginalUserID = ret.UserID;
            ret.ChipsID = reader.ToInt32("ChipsID");
            ret.OriginalChipsID = ret.ChipsID;
            ret.FreeSpinCount = reader.ToInt32("FreeSpinCount");
            ret.FreeSpinTotalReward = reader.ToInt64("FreeSpinTotalReward");
            ret.LastRecDate = reader.ToDateTimeN("LastRecDate");
            return ret;
        }

        #endregion
    }
    #endregion // EO

    #region MO
    /// <summary>
    /// 用户扩展数据
    /// 【表 gdt_user_data 的操作类】
    /// </summary>
    public class Gdt_user_dataMO : MySqlTableMO<Gdt_user_dataEO>
    {
        /// <summary>
        /// 表名
        /// </summary>
        public override string TableName { get; set; } = "`gdt_user_data`";

        #region Constructors
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name = "database">数据来源</param>
        public Gdt_user_dataMO(MySqlDatabase database) : base(database) { }
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name = "connectionStringName">配置文件.config中定义的连接字符串名称</param>
        public Gdt_user_dataMO(string connectionStringName = null) : base(connectionStringName) { }
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="connectionString">数据库连接字符串，如server=192.168.1.1;database=testdb;uid=root;pwd=root</param>
        /// <param name="commandTimeout">CommandTimeout时间</param>
        public Gdt_user_dataMO(string connectionString, int commandTimeout) : base(connectionString, commandTimeout) { }
        #endregion // Constructors

        #region  Add
        /// <summary>
        /// 插入数据
        /// </summary>
        /// <param name = "item">要插入的实体对象</param>
        /// <param name="tm_">事务管理对象</param>
        /// <param name="useIgnore_">是否使用INSERT IGNORE</param>
        /// <return>受影响的行数</return>
        public override int Add(Gdt_user_dataEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
        {
            RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public override async Task<int> AddAsync(Gdt_user_dataEO item, TransactionManager tm_ = null, bool useIgnore_ = false)
        {
            RepairAddData(item, useIgnore_, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairAddData(Gdt_user_dataEO item, bool useIgnore_, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = useIgnore_ ? "INSERT IGNORE" : "INSERT";
            sql_ += $" INTO {TableName} (`UserID`, `ChipsID`, `FreeSpinCount`, `FreeSpinTotalReward`, `LastRecDate`) VALUE (@UserID, @ChipsID, @FreeSpinCount, @FreeSpinTotalReward, @LastRecDate);";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@UserID", item.UserID, MySqlDbType.VarChar),
                Database.CreateInParameter("@ChipsID", item.ChipsID, MySqlDbType.Int32),
                Database.CreateInParameter("@FreeSpinCount", item.FreeSpinCount, MySqlDbType.Int32),
                Database.CreateInParameter("@FreeSpinTotalReward", item.FreeSpinTotalReward, MySqlDbType.Int64),
                Database.CreateInParameter("@LastRecDate", item.LastRecDate.HasValue ? item.LastRecDate.Value : (object)DBNull.Value, MySqlDbType.DateTime),
            };
        }
        public int AddByBatch(IEnumerable<Gdt_user_dataEO> items, int batchCount, TransactionManager tm_ = null)
        {
            var ret = 0;
            foreach (var sql in BuildAddBatchSql(items, batchCount))
            {
                ret += Database.ExecSqlNonQuery(sql, tm_);
            }
            return ret;
        }
        public async Task<int> AddByBatchAsync(IEnumerable<Gdt_user_dataEO> items, int batchCount, TransactionManager tm_ = null)
        {
            var ret = 0;
            foreach (var sql in BuildAddBatchSql(items, batchCount))
            {
                ret += await Database.ExecSqlNonQueryAsync(sql, tm_);
            }
            return ret;
        }
        private IEnumerable<string> BuildAddBatchSql(IEnumerable<Gdt_user_dataEO> items, int batchCount)
        {
            var count = 0;
            var insertSql = $"INSERT INTO {TableName} (`UserID`, `ChipsID`, `FreeSpinCount`, `FreeSpinTotalReward`, `LastRecDate`) VALUES ";
            var sql = new StringBuilder();
            foreach (var item in items)
            {
                count++;
                sql.Append($"('{item.UserID}',{item.ChipsID},{item.FreeSpinCount},{item.FreeSpinTotalReward},'{item.LastRecDate?.ToString("yyyy-MM-dd HH:mm:ss")}'),");
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
        /// /// <param name = "chipsID">下注id</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByPK(string userID, int chipsID, TransactionManager tm_ = null)
        {
            RepiarRemoveByPKData(userID, chipsID, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByPKAsync(string userID, int chipsID, TransactionManager tm_ = null)
        {
            RepiarRemoveByPKData(userID, chipsID, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepiarRemoveByPKData(string userID, int chipsID, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `UserID` = @UserID AND `ChipsID` = @ChipsID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
                Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
            };
        }
        /// <summary>
        /// 删除指定实体对应的记录
        /// </summary>
        /// <param name = "item">要删除的实体</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int Remove(Gdt_user_dataEO item, TransactionManager tm_ = null)
        {
            return RemoveByPK(item.UserID, item.ChipsID, tm_);
        }
        public async Task<int> RemoveAsync(Gdt_user_dataEO item, TransactionManager tm_ = null)
        {
            return await RemoveByPKAsync(item.UserID, item.ChipsID, tm_);
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
        /// /// <param name = "chipsID">下注id</param>
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
        #region RemoveByFreeSpinCount
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "freeSpinCount">FreeSpin次数</param>
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
        #region RemoveByFreeSpinTotalReward
        /// <summary>
        /// 按字段删除
        /// </summary>
        /// /// <param name = "freeSpinTotalReward">FreeSpin次数的总奖励</param>
        /// <param name="tm_">事务管理对象</param>
        public int RemoveByFreeSpinTotalReward(long freeSpinTotalReward, TransactionManager tm_ = null)
        {
            RepairRemoveByFreeSpinTotalRewardData(freeSpinTotalReward, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> RemoveByFreeSpinTotalRewardAsync(long freeSpinTotalReward, TransactionManager tm_ = null)
        {
            RepairRemoveByFreeSpinTotalRewardData(freeSpinTotalReward, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairRemoveByFreeSpinTotalRewardData(long freeSpinTotalReward, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"DELETE FROM {TableName} WHERE `FreeSpinTotalReward` = @FreeSpinTotalReward";
            paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@FreeSpinTotalReward", freeSpinTotalReward, MySqlDbType.Int64));
        }
        #endregion // RemoveByFreeSpinTotalReward
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
        public int Put(Gdt_user_dataEO item, TransactionManager tm_ = null)
        {
            RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutAsync(Gdt_user_dataEO item, TransactionManager tm_ = null)
        {
            RepairPutData(item, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutData(Gdt_user_dataEO item, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `UserID` = @UserID, `ChipsID` = @ChipsID, `FreeSpinCount` = @FreeSpinCount, `FreeSpinTotalReward` = @FreeSpinTotalReward WHERE `UserID` = @UserID_Original AND `ChipsID` = @ChipsID_Original";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@UserID", item.UserID, MySqlDbType.VarChar),
                Database.CreateInParameter("@ChipsID", item.ChipsID, MySqlDbType.Int32),
                Database.CreateInParameter("@FreeSpinCount", item.FreeSpinCount, MySqlDbType.Int32),
                Database.CreateInParameter("@FreeSpinTotalReward", item.FreeSpinTotalReward, MySqlDbType.Int64),
                Database.CreateInParameter("@UserID_Original", item.HasOriginal ? item.OriginalUserID : item.UserID, MySqlDbType.VarChar),
                Database.CreateInParameter("@ChipsID_Original", item.HasOriginal ? item.OriginalChipsID : item.ChipsID, MySqlDbType.Int32),
            };
        }

        /// <summary>
        /// 更新实体集合到数据库
        /// </summary>
        /// <param name = "items">要更新的实体对象集合</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int Put(IEnumerable<Gdt_user_dataEO> items, TransactionManager tm_ = null)
        {
            int ret = 0;
            foreach (var item in items)
            {
                ret += Put(item, tm_);
            }
            return ret;
        }
        public async Task<int> PutAsync(IEnumerable<Gdt_user_dataEO> items, TransactionManager tm_ = null)
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
        /// /// <param name = "chipsID">下注id</param>
        /// <param name = "set_">更新的列数据</param>
        /// <param name="values_">参数值</param>
        /// <return>受影响的行数</return>
        public int PutByPK(string userID, int chipsID, string set_, params object[] values_)
        {
            return Put(set_, "`UserID` = @UserID AND `ChipsID` = @ChipsID", ConcatValues(values_, userID, chipsID));
        }
        public async Task<int> PutByPKAsync(string userID, int chipsID, string set_, params object[] values_)
        {
            return await PutAsync(set_, "`UserID` = @UserID AND `ChipsID` = @ChipsID", ConcatValues(values_, userID, chipsID));
        }
        /// <summary>
        /// 按主键更新指定列数据
        /// </summary>
        /// /// <param name = "userID">用户Id</param>
        /// /// <param name = "chipsID">下注id</param>
        /// <param name = "set_">更新的列数据</param>
        /// <param name="tm_">事务管理对象</param>
        /// <param name="values_">参数值</param>
        /// <return>受影响的行数</return>
        public int PutByPK(string userID, int chipsID, string set_, TransactionManager tm_, params object[] values_)
        {
            return Put(set_, "`UserID` = @UserID AND `ChipsID` = @ChipsID", tm_, ConcatValues(values_, userID, chipsID));
        }
        public async Task<int> PutByPKAsync(string userID, int chipsID, string set_, TransactionManager tm_, params object[] values_)
        {
            return await PutAsync(set_, "`UserID` = @UserID AND `ChipsID` = @ChipsID", tm_, ConcatValues(values_, userID, chipsID));
        }
        /// <summary>
        /// 按主键更新指定列数据
        /// </summary>
        /// /// <param name = "userID">用户Id</param>
        /// /// <param name = "chipsID">下注id</param>
        /// <param name = "set_">更新的列数据</param>
        /// <param name="paras_">参数值</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutByPK(string userID, int chipsID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
        {
            var newParas_ = new List<MySqlParameter>() {
                Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
                Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
            };
            return Put(set_, "`UserID` = @UserID AND `ChipsID` = @ChipsID", ConcatParameters(paras_, newParas_), tm_);
        }
        public async Task<int> PutByPKAsync(string userID, int chipsID, string set_, IEnumerable<MySqlParameter> paras_, TransactionManager tm_ = null)
        {
            var newParas_ = new List<MySqlParameter>() {
                Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
                Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
            };
            return await PutAsync(set_, "`UserID` = @UserID AND `ChipsID` = @ChipsID", ConcatParameters(paras_, newParas_), tm_);
        }
        #endregion // PutByPK

        #region PutXXX
        #region PutUserID

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
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "chipsID">下注id</param>
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
        #region PutFreeSpinCount
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "userID">用户Id</param>
        /// /// <param name = "chipsID">下注id</param>
        /// /// <param name = "freeSpinCount">FreeSpin次数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutFreeSpinCountByPK(string userID, int chipsID, int freeSpinCount, TransactionManager tm_ = null)
        {
            RepairPutFreeSpinCountByPKData(userID, chipsID, freeSpinCount, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutFreeSpinCountByPKAsync(string userID, int chipsID, int freeSpinCount, TransactionManager tm_ = null)
        {
            RepairPutFreeSpinCountByPKData(userID, chipsID, freeSpinCount, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutFreeSpinCountByPKData(string userID, int chipsID, int freeSpinCount, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `FreeSpinCount` = @FreeSpinCount  WHERE `UserID` = @UserID AND `ChipsID` = @ChipsID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@FreeSpinCount", freeSpinCount, MySqlDbType.Int32),
                Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
                Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "freeSpinCount">FreeSpin次数</param>
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
        #region PutFreeSpinTotalReward
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "userID">用户Id</param>
        /// /// <param name = "chipsID">下注id</param>
        /// /// <param name = "freeSpinTotalReward">FreeSpin次数的总奖励</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutFreeSpinTotalRewardByPK(string userID, int chipsID, long freeSpinTotalReward, TransactionManager tm_ = null)
        {
            RepairPutFreeSpinTotalRewardByPKData(userID, chipsID, freeSpinTotalReward, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutFreeSpinTotalRewardByPKAsync(string userID, int chipsID, long freeSpinTotalReward, TransactionManager tm_ = null)
        {
            RepairPutFreeSpinTotalRewardByPKData(userID, chipsID, freeSpinTotalReward, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutFreeSpinTotalRewardByPKData(string userID, int chipsID, long freeSpinTotalReward, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `FreeSpinTotalReward` = @FreeSpinTotalReward  WHERE `UserID` = @UserID AND `ChipsID` = @ChipsID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@FreeSpinTotalReward", freeSpinTotalReward, MySqlDbType.Int64),
                Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
                Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
            };
        }

        /// <summary>
        /// 更新一列数据
        /// </summary>
        /// /// <param name = "freeSpinTotalReward">FreeSpin次数的总奖励</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutFreeSpinTotalReward(long freeSpinTotalReward, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `FreeSpinTotalReward` = @FreeSpinTotalReward";
            var parameter_ = Database.CreateInParameter("@FreeSpinTotalReward", freeSpinTotalReward, MySqlDbType.Int64);
            return Database.ExecSqlNonQuery(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        public async Task<int> PutFreeSpinTotalRewardAsync(long freeSpinTotalReward, TransactionManager tm_ = null)
        {
            string sql_ = $"UPDATE {TableName} SET `FreeSpinTotalReward` = @FreeSpinTotalReward";
            var parameter_ = Database.CreateInParameter("@FreeSpinTotalReward", freeSpinTotalReward, MySqlDbType.Int64);
            return await Database.ExecSqlNonQueryAsync(sql_, new MySqlParameter[] { parameter_ }, tm_);
        }
        #endregion // PutFreeSpinTotalReward
        #region PutLastRecDate
        /// <summary>
        /// 按主键更新列数据
        /// </summary>
        /// /// <param name = "userID">用户Id</param>
        /// /// <param name = "chipsID">下注id</param>
        /// /// <param name = "lastRecDate">记录最后记录时间</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>受影响的行数</return>
        public int PutLastRecDateByPK(string userID, int chipsID, DateTime? lastRecDate, TransactionManager tm_ = null)
        {
            RepairPutLastRecDateByPKData(userID, chipsID, lastRecDate, out string sql_, out List<MySqlParameter> paras_);
            return Database.ExecSqlNonQuery(sql_, paras_, tm_);
        }
        public async Task<int> PutLastRecDateByPKAsync(string userID, int chipsID, DateTime? lastRecDate, TransactionManager tm_ = null)
        {
            RepairPutLastRecDateByPKData(userID, chipsID, lastRecDate, out string sql_, out List<MySqlParameter> paras_);
            return await Database.ExecSqlNonQueryAsync(sql_, paras_, tm_);
        }
        private void RepairPutLastRecDateByPKData(string userID, int chipsID, DateTime? lastRecDate, out string sql_, out List<MySqlParameter> paras_)
        {
            sql_ = $"UPDATE {TableName} SET `LastRecDate` = @LastRecDate  WHERE `UserID` = @UserID AND `ChipsID` = @ChipsID";
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@LastRecDate", lastRecDate.HasValue ? lastRecDate.Value : (object)DBNull.Value, MySqlDbType.DateTime),
                Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
                Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
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
        public bool Set(Gdt_user_dataEO item, TransactionManager tm = null)
        {
            bool ret = true;
            if (GetByPK(item.UserID, item.ChipsID) == null)
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
        public async Task<bool> SetAsync(Gdt_user_dataEO item, TransactionManager tm = null)
        {
            bool ret = true;
            if (GetByPK(item.UserID, item.ChipsID) == null)
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
        /// /// <param name = "chipsID">下注id</param>
        /// <param name="tm_">事务管理对象</param>
        /// <param name="isForUpdate_">是否使用FOR UPDATE锁行</param>
        /// <return></return>
        public Gdt_user_dataEO GetByPK(string userID, int chipsID, TransactionManager tm_ = null, bool isForUpdate_ = false)
        {
            RepairGetByPKData(userID, chipsID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_);
            return Database.ExecSqlSingle(sql_, paras_, tm_, Gdt_user_dataEO.MapDataReader);
        }
        public async Task<Gdt_user_dataEO> GetByPKAsync(string userID, int chipsID, TransactionManager tm_ = null, bool isForUpdate_ = false)
        {
            RepairGetByPKData(userID, chipsID, out string sql_, out List<MySqlParameter> paras_, isForUpdate_);
            return await Database.ExecSqlSingleAsync(sql_, paras_, tm_, Gdt_user_dataEO.MapDataReader);
        }
        private void RepairGetByPKData(string userID, int chipsID, out string sql_, out List<MySqlParameter> paras_, bool isForUpdate_ = false)
        {
            sql_ = BuildSelectSQL("`UserID` = @UserID AND `ChipsID` = @ChipsID", 0, null, null, isForUpdate_);
            paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
                Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
            };
        }
        #endregion // GetByPK

        #region GetXXXByPK

        /// <summary>
        /// 按主键查询 UserID（字段）
        /// </summary>
        /// /// <param name = "userID">用户Id</param>
        /// /// <param name = "chipsID">下注id</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public string GetUserIDByPK(string userID, int chipsID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
                Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
            };
            return (string)GetScalar("`UserID`", "`UserID` = @UserID AND `ChipsID` = @ChipsID", paras_, tm_);
        }
        public async Task<string> GetUserIDByPKAsync(string userID, int chipsID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
                Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
            };
            return (string)await GetScalarAsync("`UserID`", "`UserID` = @UserID AND `ChipsID` = @ChipsID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 ChipsID（字段）
        /// </summary>
        /// /// <param name = "userID">用户Id</param>
        /// /// <param name = "chipsID">下注id</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public int GetChipsIDByPK(string userID, int chipsID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
                Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
            };
            return (int)GetScalar("`ChipsID`", "`UserID` = @UserID AND `ChipsID` = @ChipsID", paras_, tm_);
        }
        public async Task<int> GetChipsIDByPKAsync(string userID, int chipsID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
                Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
            };
            return (int)await GetScalarAsync("`ChipsID`", "`UserID` = @UserID AND `ChipsID` = @ChipsID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 FreeSpinCount（字段）
        /// </summary>
        /// /// <param name = "userID">用户Id</param>
        /// /// <param name = "chipsID">下注id</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public int GetFreeSpinCountByPK(string userID, int chipsID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
                Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
            };
            return (int)GetScalar("`FreeSpinCount`", "`UserID` = @UserID AND `ChipsID` = @ChipsID", paras_, tm_);
        }
        public async Task<int> GetFreeSpinCountByPKAsync(string userID, int chipsID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
                Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
            };
            return (int)await GetScalarAsync("`FreeSpinCount`", "`UserID` = @UserID AND `ChipsID` = @ChipsID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 FreeSpinTotalReward（字段）
        /// </summary>
        /// /// <param name = "userID">用户Id</param>
        /// /// <param name = "chipsID">下注id</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public long GetFreeSpinTotalRewardByPK(string userID, int chipsID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
                Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
            };
            return (long)GetScalar("`FreeSpinTotalReward`", "`UserID` = @UserID AND `ChipsID` = @ChipsID", paras_, tm_);
        }
        public async Task<long> GetFreeSpinTotalRewardByPKAsync(string userID, int chipsID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
                Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
            };
            return (long)await GetScalarAsync("`FreeSpinTotalReward`", "`UserID` = @UserID AND `ChipsID` = @ChipsID", paras_, tm_);
        }

        /// <summary>
        /// 按主键查询 LastRecDate（字段）
        /// </summary>
        /// /// <param name = "userID">用户Id</param>
        /// /// <param name = "chipsID">下注id</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return></return>
        public DateTime? GetLastRecDateByPK(string userID, int chipsID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
                Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
            };
            return (DateTime?)GetScalar("`LastRecDate`", "`UserID` = @UserID AND `ChipsID` = @ChipsID", paras_, tm_);
        }
        public async Task<DateTime?> GetLastRecDateByPKAsync(string userID, int chipsID, TransactionManager tm_ = null)
        {
            var paras_ = new List<MySqlParameter>()
            {
                Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar),
                Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32),
            };
            return (DateTime?)await GetScalarAsync("`LastRecDate`", "`UserID` = @UserID AND `ChipsID` = @ChipsID", paras_, tm_);
        }
        #endregion // GetXXXByPK
        #region GetByXXX
        #region GetByUserID

        /// <summary>
        /// 按 UserID（字段） 查询
        /// </summary>
        /// /// <param name = "userID">用户Id</param>
        /// <return>实体对象集合</return>
        public List<Gdt_user_dataEO> GetByUserID(string userID)
        {
            return GetByUserID(userID, 0, string.Empty, null);
        }
        public async Task<List<Gdt_user_dataEO>> GetByUserIDAsync(string userID)
        {
            return await GetByUserIDAsync(userID, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 UserID（字段） 查询
        /// </summary>
        /// /// <param name = "userID">用户Id</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gdt_user_dataEO> GetByUserID(string userID, TransactionManager tm_)
        {
            return GetByUserID(userID, 0, string.Empty, tm_);
        }
        public async Task<List<Gdt_user_dataEO>> GetByUserIDAsync(string userID, TransactionManager tm_)
        {
            return await GetByUserIDAsync(userID, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 UserID（字段） 查询
        /// </summary>
        /// /// <param name = "userID">用户Id</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Gdt_user_dataEO> GetByUserID(string userID, int top_)
        {
            return GetByUserID(userID, top_, string.Empty, null);
        }
        public async Task<List<Gdt_user_dataEO>> GetByUserIDAsync(string userID, int top_)
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
        public List<Gdt_user_dataEO> GetByUserID(string userID, int top_, TransactionManager tm_)
        {
            return GetByUserID(userID, top_, string.Empty, tm_);
        }
        public async Task<List<Gdt_user_dataEO>> GetByUserIDAsync(string userID, int top_, TransactionManager tm_)
        {
            return await GetByUserIDAsync(userID, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 UserID（字段） 查询
        /// </summary>
        /// /// <param name = "userID">用户Id</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Gdt_user_dataEO> GetByUserID(string userID, string sort_)
        {
            return GetByUserID(userID, 0, sort_, null);
        }
        public async Task<List<Gdt_user_dataEO>> GetByUserIDAsync(string userID, string sort_)
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
        public List<Gdt_user_dataEO> GetByUserID(string userID, string sort_, TransactionManager tm_)
        {
            return GetByUserID(userID, 0, sort_, tm_);
        }
        public async Task<List<Gdt_user_dataEO>> GetByUserIDAsync(string userID, string sort_, TransactionManager tm_)
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
        public List<Gdt_user_dataEO> GetByUserID(string userID, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`UserID` = @UserID", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar));
            return Database.ExecSqlList(sql_, paras_, tm_, Gdt_user_dataEO.MapDataReader);
        }
        public async Task<List<Gdt_user_dataEO>> GetByUserIDAsync(string userID, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`UserID` = @UserID", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@UserID", userID, MySqlDbType.VarChar));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gdt_user_dataEO.MapDataReader);
        }
        #endregion // GetByUserID
        #region GetByChipsID

        /// <summary>
        /// 按 ChipsID（字段） 查询
        /// </summary>
        /// /// <param name = "chipsID">下注id</param>
        /// <return>实体对象集合</return>
        public List<Gdt_user_dataEO> GetByChipsID(int chipsID)
        {
            return GetByChipsID(chipsID, 0, string.Empty, null);
        }
        public async Task<List<Gdt_user_dataEO>> GetByChipsIDAsync(int chipsID)
        {
            return await GetByChipsIDAsync(chipsID, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 ChipsID（字段） 查询
        /// </summary>
        /// /// <param name = "chipsID">下注id</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gdt_user_dataEO> GetByChipsID(int chipsID, TransactionManager tm_)
        {
            return GetByChipsID(chipsID, 0, string.Empty, tm_);
        }
        public async Task<List<Gdt_user_dataEO>> GetByChipsIDAsync(int chipsID, TransactionManager tm_)
        {
            return await GetByChipsIDAsync(chipsID, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 ChipsID（字段） 查询
        /// </summary>
        /// /// <param name = "chipsID">下注id</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Gdt_user_dataEO> GetByChipsID(int chipsID, int top_)
        {
            return GetByChipsID(chipsID, top_, string.Empty, null);
        }
        public async Task<List<Gdt_user_dataEO>> GetByChipsIDAsync(int chipsID, int top_)
        {
            return await GetByChipsIDAsync(chipsID, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 ChipsID（字段） 查询
        /// </summary>
        /// /// <param name = "chipsID">下注id</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gdt_user_dataEO> GetByChipsID(int chipsID, int top_, TransactionManager tm_)
        {
            return GetByChipsID(chipsID, top_, string.Empty, tm_);
        }
        public async Task<List<Gdt_user_dataEO>> GetByChipsIDAsync(int chipsID, int top_, TransactionManager tm_)
        {
            return await GetByChipsIDAsync(chipsID, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 ChipsID（字段） 查询
        /// </summary>
        /// /// <param name = "chipsID">下注id</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Gdt_user_dataEO> GetByChipsID(int chipsID, string sort_)
        {
            return GetByChipsID(chipsID, 0, sort_, null);
        }
        public async Task<List<Gdt_user_dataEO>> GetByChipsIDAsync(int chipsID, string sort_)
        {
            return await GetByChipsIDAsync(chipsID, 0, sort_, null);
        }

        /// <summary>
        /// 按 ChipsID（字段） 查询
        /// </summary>
        /// /// <param name = "chipsID">下注id</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gdt_user_dataEO> GetByChipsID(int chipsID, string sort_, TransactionManager tm_)
        {
            return GetByChipsID(chipsID, 0, sort_, tm_);
        }
        public async Task<List<Gdt_user_dataEO>> GetByChipsIDAsync(int chipsID, string sort_, TransactionManager tm_)
        {
            return await GetByChipsIDAsync(chipsID, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 ChipsID（字段） 查询
        /// </summary>
        /// /// <param name = "chipsID">下注id</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gdt_user_dataEO> GetByChipsID(int chipsID, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`ChipsID` = @ChipsID", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32));
            return Database.ExecSqlList(sql_, paras_, tm_, Gdt_user_dataEO.MapDataReader);
        }
        public async Task<List<Gdt_user_dataEO>> GetByChipsIDAsync(int chipsID, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`ChipsID` = @ChipsID", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@ChipsID", chipsID, MySqlDbType.Int32));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gdt_user_dataEO.MapDataReader);
        }
        #endregion // GetByChipsID
        #region GetByFreeSpinCount

        /// <summary>
        /// 按 FreeSpinCount（字段） 查询
        /// </summary>
        /// /// <param name = "freeSpinCount">FreeSpin次数</param>
        /// <return>实体对象集合</return>
        public List<Gdt_user_dataEO> GetByFreeSpinCount(int freeSpinCount)
        {
            return GetByFreeSpinCount(freeSpinCount, 0, string.Empty, null);
        }
        public async Task<List<Gdt_user_dataEO>> GetByFreeSpinCountAsync(int freeSpinCount)
        {
            return await GetByFreeSpinCountAsync(freeSpinCount, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 FreeSpinCount（字段） 查询
        /// </summary>
        /// /// <param name = "freeSpinCount">FreeSpin次数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gdt_user_dataEO> GetByFreeSpinCount(int freeSpinCount, TransactionManager tm_)
        {
            return GetByFreeSpinCount(freeSpinCount, 0, string.Empty, tm_);
        }
        public async Task<List<Gdt_user_dataEO>> GetByFreeSpinCountAsync(int freeSpinCount, TransactionManager tm_)
        {
            return await GetByFreeSpinCountAsync(freeSpinCount, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 FreeSpinCount（字段） 查询
        /// </summary>
        /// /// <param name = "freeSpinCount">FreeSpin次数</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Gdt_user_dataEO> GetByFreeSpinCount(int freeSpinCount, int top_)
        {
            return GetByFreeSpinCount(freeSpinCount, top_, string.Empty, null);
        }
        public async Task<List<Gdt_user_dataEO>> GetByFreeSpinCountAsync(int freeSpinCount, int top_)
        {
            return await GetByFreeSpinCountAsync(freeSpinCount, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 FreeSpinCount（字段） 查询
        /// </summary>
        /// /// <param name = "freeSpinCount">FreeSpin次数</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gdt_user_dataEO> GetByFreeSpinCount(int freeSpinCount, int top_, TransactionManager tm_)
        {
            return GetByFreeSpinCount(freeSpinCount, top_, string.Empty, tm_);
        }
        public async Task<List<Gdt_user_dataEO>> GetByFreeSpinCountAsync(int freeSpinCount, int top_, TransactionManager tm_)
        {
            return await GetByFreeSpinCountAsync(freeSpinCount, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 FreeSpinCount（字段） 查询
        /// </summary>
        /// /// <param name = "freeSpinCount">FreeSpin次数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Gdt_user_dataEO> GetByFreeSpinCount(int freeSpinCount, string sort_)
        {
            return GetByFreeSpinCount(freeSpinCount, 0, sort_, null);
        }
        public async Task<List<Gdt_user_dataEO>> GetByFreeSpinCountAsync(int freeSpinCount, string sort_)
        {
            return await GetByFreeSpinCountAsync(freeSpinCount, 0, sort_, null);
        }

        /// <summary>
        /// 按 FreeSpinCount（字段） 查询
        /// </summary>
        /// /// <param name = "freeSpinCount">FreeSpin次数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gdt_user_dataEO> GetByFreeSpinCount(int freeSpinCount, string sort_, TransactionManager tm_)
        {
            return GetByFreeSpinCount(freeSpinCount, 0, sort_, tm_);
        }
        public async Task<List<Gdt_user_dataEO>> GetByFreeSpinCountAsync(int freeSpinCount, string sort_, TransactionManager tm_)
        {
            return await GetByFreeSpinCountAsync(freeSpinCount, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 FreeSpinCount（字段） 查询
        /// </summary>
        /// /// <param name = "freeSpinCount">FreeSpin次数</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gdt_user_dataEO> GetByFreeSpinCount(int freeSpinCount, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`FreeSpinCount` = @FreeSpinCount", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@FreeSpinCount", freeSpinCount, MySqlDbType.Int32));
            return Database.ExecSqlList(sql_, paras_, tm_, Gdt_user_dataEO.MapDataReader);
        }
        public async Task<List<Gdt_user_dataEO>> GetByFreeSpinCountAsync(int freeSpinCount, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`FreeSpinCount` = @FreeSpinCount", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@FreeSpinCount", freeSpinCount, MySqlDbType.Int32));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gdt_user_dataEO.MapDataReader);
        }
        #endregion // GetByFreeSpinCount
        #region GetByFreeSpinTotalReward

        /// <summary>
        /// 按 FreeSpinTotalReward（字段） 查询
        /// </summary>
        /// /// <param name = "freeSpinTotalReward">FreeSpin次数的总奖励</param>
        /// <return>实体对象集合</return>
        public List<Gdt_user_dataEO> GetByFreeSpinTotalReward(long freeSpinTotalReward)
        {
            return GetByFreeSpinTotalReward(freeSpinTotalReward, 0, string.Empty, null);
        }
        public async Task<List<Gdt_user_dataEO>> GetByFreeSpinTotalRewardAsync(long freeSpinTotalReward)
        {
            return await GetByFreeSpinTotalRewardAsync(freeSpinTotalReward, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 FreeSpinTotalReward（字段） 查询
        /// </summary>
        /// /// <param name = "freeSpinTotalReward">FreeSpin次数的总奖励</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gdt_user_dataEO> GetByFreeSpinTotalReward(long freeSpinTotalReward, TransactionManager tm_)
        {
            return GetByFreeSpinTotalReward(freeSpinTotalReward, 0, string.Empty, tm_);
        }
        public async Task<List<Gdt_user_dataEO>> GetByFreeSpinTotalRewardAsync(long freeSpinTotalReward, TransactionManager tm_)
        {
            return await GetByFreeSpinTotalRewardAsync(freeSpinTotalReward, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 FreeSpinTotalReward（字段） 查询
        /// </summary>
        /// /// <param name = "freeSpinTotalReward">FreeSpin次数的总奖励</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Gdt_user_dataEO> GetByFreeSpinTotalReward(long freeSpinTotalReward, int top_)
        {
            return GetByFreeSpinTotalReward(freeSpinTotalReward, top_, string.Empty, null);
        }
        public async Task<List<Gdt_user_dataEO>> GetByFreeSpinTotalRewardAsync(long freeSpinTotalReward, int top_)
        {
            return await GetByFreeSpinTotalRewardAsync(freeSpinTotalReward, top_, string.Empty, null);
        }

        /// <summary>
        /// 按 FreeSpinTotalReward（字段） 查询
        /// </summary>
        /// /// <param name = "freeSpinTotalReward">FreeSpin次数的总奖励</param>
        /// <param name = "top_">获取行数</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gdt_user_dataEO> GetByFreeSpinTotalReward(long freeSpinTotalReward, int top_, TransactionManager tm_)
        {
            return GetByFreeSpinTotalReward(freeSpinTotalReward, top_, string.Empty, tm_);
        }
        public async Task<List<Gdt_user_dataEO>> GetByFreeSpinTotalRewardAsync(long freeSpinTotalReward, int top_, TransactionManager tm_)
        {
            return await GetByFreeSpinTotalRewardAsync(freeSpinTotalReward, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 FreeSpinTotalReward（字段） 查询
        /// </summary>
        /// /// <param name = "freeSpinTotalReward">FreeSpin次数的总奖励</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Gdt_user_dataEO> GetByFreeSpinTotalReward(long freeSpinTotalReward, string sort_)
        {
            return GetByFreeSpinTotalReward(freeSpinTotalReward, 0, sort_, null);
        }
        public async Task<List<Gdt_user_dataEO>> GetByFreeSpinTotalRewardAsync(long freeSpinTotalReward, string sort_)
        {
            return await GetByFreeSpinTotalRewardAsync(freeSpinTotalReward, 0, sort_, null);
        }

        /// <summary>
        /// 按 FreeSpinTotalReward（字段） 查询
        /// </summary>
        /// /// <param name = "freeSpinTotalReward">FreeSpin次数的总奖励</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gdt_user_dataEO> GetByFreeSpinTotalReward(long freeSpinTotalReward, string sort_, TransactionManager tm_)
        {
            return GetByFreeSpinTotalReward(freeSpinTotalReward, 0, sort_, tm_);
        }
        public async Task<List<Gdt_user_dataEO>> GetByFreeSpinTotalRewardAsync(long freeSpinTotalReward, string sort_, TransactionManager tm_)
        {
            return await GetByFreeSpinTotalRewardAsync(freeSpinTotalReward, 0, sort_, tm_);
        }

        /// <summary>
        /// 按 FreeSpinTotalReward（字段） 查询
        /// </summary>
        /// /// <param name = "freeSpinTotalReward">FreeSpin次数的总奖励</param>
        /// <param name = "top_">获取行数</param>
        /// <param name = "sort_">排序表达式</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gdt_user_dataEO> GetByFreeSpinTotalReward(long freeSpinTotalReward, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`FreeSpinTotalReward` = @FreeSpinTotalReward", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@FreeSpinTotalReward", freeSpinTotalReward, MySqlDbType.Int64));
            return Database.ExecSqlList(sql_, paras_, tm_, Gdt_user_dataEO.MapDataReader);
        }
        public async Task<List<Gdt_user_dataEO>> GetByFreeSpinTotalRewardAsync(long freeSpinTotalReward, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL("`FreeSpinTotalReward` = @FreeSpinTotalReward", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            paras_.Add(Database.CreateInParameter("@FreeSpinTotalReward", freeSpinTotalReward, MySqlDbType.Int64));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gdt_user_dataEO.MapDataReader);
        }
        #endregion // GetByFreeSpinTotalReward
        #region GetByLastRecDate

        /// <summary>
        /// 按 LastRecDate（字段） 查询
        /// </summary>
        /// /// <param name = "lastRecDate">记录最后记录时间</param>
        /// <return>实体对象集合</return>
        public List<Gdt_user_dataEO> GetByLastRecDate(DateTime? lastRecDate)
        {
            return GetByLastRecDate(lastRecDate, 0, string.Empty, null);
        }
        public async Task<List<Gdt_user_dataEO>> GetByLastRecDateAsync(DateTime? lastRecDate)
        {
            return await GetByLastRecDateAsync(lastRecDate, 0, string.Empty, null);
        }

        /// <summary>
        /// 按 LastRecDate（字段） 查询
        /// </summary>
        /// /// <param name = "lastRecDate">记录最后记录时间</param>
        /// <param name="tm_">事务管理对象</param>
        /// <return>实体对象集合</return>
        public List<Gdt_user_dataEO> GetByLastRecDate(DateTime? lastRecDate, TransactionManager tm_)
        {
            return GetByLastRecDate(lastRecDate, 0, string.Empty, tm_);
        }
        public async Task<List<Gdt_user_dataEO>> GetByLastRecDateAsync(DateTime? lastRecDate, TransactionManager tm_)
        {
            return await GetByLastRecDateAsync(lastRecDate, 0, string.Empty, tm_);
        }

        /// <summary>
        /// 按 LastRecDate（字段） 查询
        /// </summary>
        /// /// <param name = "lastRecDate">记录最后记录时间</param>
        /// <param name = "top_">获取行数</param>
        /// <return>实体对象集合</return>
        public List<Gdt_user_dataEO> GetByLastRecDate(DateTime? lastRecDate, int top_)
        {
            return GetByLastRecDate(lastRecDate, top_, string.Empty, null);
        }
        public async Task<List<Gdt_user_dataEO>> GetByLastRecDateAsync(DateTime? lastRecDate, int top_)
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
        public List<Gdt_user_dataEO> GetByLastRecDate(DateTime? lastRecDate, int top_, TransactionManager tm_)
        {
            return GetByLastRecDate(lastRecDate, top_, string.Empty, tm_);
        }
        public async Task<List<Gdt_user_dataEO>> GetByLastRecDateAsync(DateTime? lastRecDate, int top_, TransactionManager tm_)
        {
            return await GetByLastRecDateAsync(lastRecDate, top_, string.Empty, tm_);
        }

        /// <summary>
        /// 按 LastRecDate（字段） 查询
        /// </summary>
        /// /// <param name = "lastRecDate">记录最后记录时间</param>
        /// <param name = "sort_">排序表达式</param>
        /// <return>实体对象集合</return>
        public List<Gdt_user_dataEO> GetByLastRecDate(DateTime? lastRecDate, string sort_)
        {
            return GetByLastRecDate(lastRecDate, 0, sort_, null);
        }
        public async Task<List<Gdt_user_dataEO>> GetByLastRecDateAsync(DateTime? lastRecDate, string sort_)
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
        public List<Gdt_user_dataEO> GetByLastRecDate(DateTime? lastRecDate, string sort_, TransactionManager tm_)
        {
            return GetByLastRecDate(lastRecDate, 0, sort_, tm_);
        }
        public async Task<List<Gdt_user_dataEO>> GetByLastRecDateAsync(DateTime? lastRecDate, string sort_, TransactionManager tm_)
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
        public List<Gdt_user_dataEO> GetByLastRecDate(DateTime? lastRecDate, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL(lastRecDate.HasValue ? "`LastRecDate` = @LastRecDate" : "`LastRecDate` IS NULL", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            if (lastRecDate.HasValue)
                paras_.Add(Database.CreateInParameter("@LastRecDate", lastRecDate.Value, MySqlDbType.DateTime));
            return Database.ExecSqlList(sql_, paras_, tm_, Gdt_user_dataEO.MapDataReader);
        }
        public async Task<List<Gdt_user_dataEO>> GetByLastRecDateAsync(DateTime? lastRecDate, int top_, string sort_, TransactionManager tm_)
        {
            var sql_ = BuildSelectSQL(lastRecDate.HasValue ? "`LastRecDate` = @LastRecDate" : "`LastRecDate` IS NULL", top_, sort_);
            var paras_ = new List<MySqlParameter>();
            if (lastRecDate.HasValue)
                paras_.Add(Database.CreateInParameter("@LastRecDate", lastRecDate.Value, MySqlDbType.DateTime));
            return await Database.ExecSqlListAsync(sql_, paras_, tm_, Gdt_user_dataEO.MapDataReader);
        }
        #endregion // GetByLastRecDate
        #endregion // GetByXXX
        #endregion // Get
    }
    #endregion // MO
}
