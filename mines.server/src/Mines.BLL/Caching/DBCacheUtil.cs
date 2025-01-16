using Mines.DAL;
using TinyFx.DbCaching;

namespace Mines.BLL.Caching
{
    public static class DBCacheUtil
    {
        #region gsp_config
        //private static readonly object _syncConfig = new();
        //private static Dictionary<string, Mines_configEO>? _configDic;
        //private static Dictionary<string, Mines_configEO> ConfigDic
        //{
        //    get
        //    {

        //        if (_configDic == null)
        //        {
        //            lock (_syncConfig)
        //            {
        //                if (_configDic == null)
        //                {
        //                    var values = new Dictionary<string, Mines_configEO>();
        //                    foreach (var item in new Mines_configMO().GetAll())
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

        //public static Mines_configEO GetConfig(string operatorId, string currencyId) => ConfigDic[(operatorId + currencyId)];


        public static Mines_configPO GetConfig(string operatorId, string currencyId)
        {
            var ret = DbCachingUtil.GetSingle<Mines_configPO>(it => new { it.OperatorID, it.CurrencyID }, new Mines_configPO
            {
                OperatorID = operatorId,
                CurrencyID = currencyId,
            });
            return ret;
        }

        #endregion

        #region gsp_config_chips
        //private static readonly object _syncChips = new();
        //private static Dictionary<string, Mines_config_chipsEO>? _chipsDic;
        public static Dictionary<string, Mines_config_chipsEO> ChipsDic
        {
            get
            {

                Dictionary<string, Mines_config_chipsEO>? _chipsDic = new Dictionary<string, Mines_config_chipsEO>();
                var values = new Dictionary<string, Mines_config_chipsEO>();
                var v = DbCachingUtil.GetAllList<Mines_config_chipsPO>();

                foreach (var item in v)
                {
                    string key = $"{item.MinesNum}|{item.Diamod}";
                    values.Add(key, item);
                }
                _chipsDic = values;

                return _chipsDic;
            }
        }

        public static Mines_config_chipsEO GetChips(int mines, int diamod)
        {
            var key = $"{mines}|{diamod}";
            if (ChipsDic.ContainsKey(key))
            {
                return ChipsDic[key];
            }
            return null;
        }

        public static List<Mines_config_chipsEO> GetChipsList() => ChipsDic.Values.ToList();
        #endregion

        #region gsp_user_ext
        /* private static readonly object _syncExt = new();
         private static Dictionary<string, Mines_user_dataEO>? _userDataDic;
         private static Dictionary<string, Mines_user_dataEO> UserDataDic
         {
             get
             {
                 if (_userDataDic == null)
                 {
                     lock (_syncExt)
                     {
                         if (_userDataDic == null)
                         {
                             var values = new Dictionary<string, Mines_user_dataEO>();
                             foreach (var item in new Mines_user_dataMO().GetAll())
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
         public static List<Mines_user_dataEO> GetUserDataList(string userId)
         {
             Mines_user_dataMO _userMo = new();
             return _userMo.GetByUserID(userId);
         }
         public static Mines_user_dataEO? GetUserData(string userId, int chipsId)
         {
             return GetUserDataList(userId).FirstOrDefault(x => x.ChipsID == chipsId);
         }*/
        #endregion

        public static void Clear()
        {
            //_configDic = null;
            //_chipsDic = null;
            /* _lampList = null;
             _chipsList = null;
             _multipList = null;
             _weightAll = null;*/
        }
    }
}
