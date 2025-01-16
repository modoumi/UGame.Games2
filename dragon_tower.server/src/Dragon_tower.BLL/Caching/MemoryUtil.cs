using Dragon_tower.DAL;
using TinyFx.DbCaching;

namespace Dragon_tower.BLL.Caching
{
    public static class MemoryUtil
    {
        #region gdt_config
        //private static readonly object _syncConfig = new();
        //private static Dictionary<string, Gdt_configEO>? _configDic;
        //private static Dictionary<string, Gdt_configEO> ConfigDic
        //{
        //    get
        //    {

        //        if (_configDic == null)
        //        {
        //            lock (_syncConfig)
        //            {
        //                if (_configDic == null)
        //                {
        //                    var values = new Dictionary<string, Gdt_configEO>();
        //                    foreach (var item in new Gdt_configMO().GetAll())
        //                    {
        //                        var key = item.OperatorID + item.CurrencyID;
        //                        values.Add(key, item);
        //                    }
        //                    _configDic = values;
        //                }
        //            }
        //        }
        //        return _configDic;
        //    }
        //}

        //public static Gdt_configEO GetConfig(string operatorId, string currencyId) => ConfigDic[(operatorId + currencyId)];

        public static Gdt_configPO GetConfig(string operatorId, string currencyId)
        {
            var ret = DbCachingUtil.GetSingle<Gdt_configPO>(it => new { it.OperatorID, it.CurrencyID }, new Gdt_configPO
            {
                OperatorID = operatorId,
                CurrencyID = currencyId,
            });
            return ret;
        }

        #endregion

        #region gdt_config_level
        private static readonly object _syncLevel = new();
        //private static Dictionary<int, Gdt_config_levelEO>? _levelDic;
        public static List<Gdt_config_levelPO> LevelDic => DbCachingUtil.GetAllList<Gdt_config_levelPO>();


        public static Gdt_config_levelPO GetLevelByPk(int levelId) => LevelDic.FirstOrDefault(c=>c.LevelID==levelId);

        public static List<Gdt_config_levelPO> GetLevelList => LevelDic;

        #endregion

        #region gdt_user_ext
        /* private static readonly object _syncExt = new();
         private static Dictionary<string, Gdt_user_dataEO>? _userDataDic;
         private static Dictionary<string, Gdt_user_dataEO> UserDataDic
         {
             get
             {
                 if (_userDataDic == null)
                 {
                     lock (_syncExt)
                     {
                         if (_userDataDic == null)
                         {
                             var values = new Dictionary<string, Gdt_user_dataEO>();
                             foreach (var item in new Gdt_user_dataMO().GetAll())
                             {
                                 string key = item.UserID + "_" + item.ChipsID;
                                 if (!values.ContainsKey(key))
                                     values.Add(key, item);
                             }
                             _userDataDic = values;
                         }
                     }
                 }
                 return _userDataDic;
             }
         }
         public static List<Gdt_user_dataEO> GetUserDataList(string userId)
         {
             Gdt_user_dataMO _userMo = new();
             return _userMo.GetByUserID(userId);
         }
         public static Gdt_user_dataEO? GetUserData(string userId, int levelId)
         {
             return GetUserDataList(userId).FirstOrDefault(x => x.ChipsID == levelId);
         }*/
        #endregion


        /// <summary>
        /// List分页处理
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="_list"></param>
        /// <param name="PageIndex"></param>
        /// <param name="PageSize"></param>
        /// <returns></returns>
        public static List<T> SplitList<T>(List<T> _list, int PageIndex, int PageSize)
        {
            int _PageIndex = PageIndex == 0 ? 1 : PageIndex;
            int _PageSize = PageSize == 0 ? 20 : PageSize;
            int PageConut = (int)Math.Ceiling(Convert.ToDecimal(_list.Count) / _PageSize);
            if (PageConut >= _PageIndex)
            {
                List<T> list = new List<T>();
                list = _list.Skip((_PageIndex - 1) * _PageSize).Take(_PageSize).ToList();
                return list;
            }
            else
                return _list;
        }
        //#endregion
        public static void Clear()
        {
            //_configDic = null;
            //_levelDic = null;
            /* _lampList = null;
             _lineList = null;
             _multipList = null;
             _weightAll = null;*/
        }
    }
    public class WeightColumn
    {
        public int WeightId { get; set; }
        public int IconType { get; set; }
        public int WeightVal { get; set; }
    }
}
