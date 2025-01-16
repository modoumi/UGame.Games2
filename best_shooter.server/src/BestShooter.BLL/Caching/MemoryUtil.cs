using BestShooter.DAL;
using TinyFx.DbCaching;

namespace BestShooter.BLL.Caching
{
    public static class MemoryUtil
    {

        #region bs_config
        //private static readonly object _syncConfig = new();
        //private static Dictionary<string, Bs_configEO>? _configDic;
        //private static Dictionary<string, Bs_configEO> ConfigDic
        //{
        //    get
        //    {

        //        if (_configDic == null)
        //        {
        //            lock (_syncConfig)
        //            {
        //                if (_configDic == null)
        //                {
        //                    var values = new Dictionary<string, Bs_configEO>();
        //                    foreach (var item in new Bs_configMO().GetAll())
        //                    {
        //                        var key = $"{item.OperatorID}|{item.CurrencyID}";
        //                        values.Add(key, item);
        //                    }
        //                    _configDic = values;
        //                }
        //            }
        //        }
        //        return _configDic;
        //    }
        //}

        //public static Bs_configEO GetConfig(string operatorId, string currencyId) => ConfigDic[$"{operatorId}|{currencyId}"];

        public static Bs_configPO GetConfig(string operatorId, string currencyId)
        {
            var ret = DbCachingUtil.GetSingle<Bs_configPO>(it => new { it.OperatorID, it.CurrencyID }, new Bs_configPO
            {
                OperatorID = operatorId,
                CurrencyID = currencyId,
            });
            return ret;
        }


        #endregion
        #region bs_config_star
      
        private static List<Bs_config_starPO> StarList => DbCachingUtil.GetAllList<Bs_config_starPO>();



        public static List<Bs_config_starPO> GetStarList(string operatorId)
        {
            return StarList.Where(d => d.OperatorID.Equals(operatorId)).ToList(); 
        }
        #endregion
        //#region bs_config_lucky
        //private static readonly object _syncChips = new();
        //private static Dictionary<int, Bs_config_luckyEO>? _luckyDic;
        //public static Dictionary<int, Bs_config_luckyEO> LuckyDic
        //{
        //    get
        //    {

        //        if (_chipsDic == null)
        //        {
        //            lock (_syncChips)
        //            {
        //                if (_chipsDic == null)
        //                {
        //                    var values = new Dictionary<int, Mines_config_chipsEO>();
        //                    foreach (var item in new Mines_config_chipsMO().GetAll())
        //                    {
        //                        values.Add(item.ChipsID, item);
        //                    }
        //                    _chipsDic = values;
        //                }
        //            }
        //        }
        //        return _chipsDic;
        //    }
        //}

        //public static Mines_config_chipsEO GetChips(int chipsId) => ChipsDic[chipsId];

        //public static List<Mines_config_chipsEO> GetChipsList(string operatorId, string currencyId) => ChipsDic.Where(x => x.Value.OperatorID.Equals(operatorId) && x.Value.CurrencyID.Equals(currencyId)).Select(x => x.Value).ToList();

        //#endregion

        #region bs_config_lucky
      
        public static List<Bs_config_luckyPO> LuckyList=> DbCachingUtil.GetAllList<Bs_config_luckyPO>();

       // public static List<KeyValueWeight>? _luckyMultipList;
       // public static List<KeyValueWeight>? _luckyNumList;

        public class KeyValueWeight
        {
            public int Weight { get; set; }
            public int Val { get; set; }

        }
        public static List<KeyValueWeight> GetLuckyMultipList(string operatorId, string currencyId)
        {
            List<KeyValueWeight>? _luckyMultipList  = new();
            //if (_luckyMultipList == null)
            //{

            var _lucky = LuckyList.FirstOrDefault(x => x.OperatorID.Equals(operatorId) && x.CurrencyID.Equals(currencyId));
                var multipList = Array.ConvertAll(_lucky.MultipList.Split("|"), x => int.Parse(x));
                var weigthList = Array.ConvertAll(_lucky.MultipWeightList.Split("|"), x => int.Parse(x));
                int index = 0;
                foreach (var v in weigthList)
                {
                    _luckyMultipList.Add(new KeyValueWeight
                    {
                        Weight = v,
                        Val = multipList[index]
                    });
                    index++;
                }
            //}

            return _luckyMultipList;

        }
        public static List<KeyValueWeight> GetLuckyNumList(string operatorId, string currencyId)
        {

            List<KeyValueWeight>? _luckyNumList = new();
            var _lucky = LuckyList.FirstOrDefault(x => x.OperatorID.Equals(operatorId) && x.CurrencyID.Equals(currencyId));
                var multipList = Array.ConvertAll(_lucky.NumList.Split("|"), x => int.Parse(x));
                var weigthList = Array.ConvertAll(_lucky.NumWeightList.Split("|"), x => int.Parse(x));
                int index = 0;
                foreach (var v in weigthList)
                {
                    _luckyNumList.Add(new KeyValueWeight
                    {
                        Weight = v,
                        Val = multipList[index]
                    });
                    index++;
                }
           
            return _luckyNumList;
        }
        #endregion

        //#region gsp_config_multip
        //private static List<Mines_config_multipEO>? _multipList;
        //public static List<Mines_config_multipEO> MultipList
        //{
        //    get
        //    {
        //        _multipList ??= new Mines_config_multipMO().GetAll();
        //        return _multipList;
        //    }
        //}
        //public static List<Mines_config_multipEO> GetMultipList(string operatorId, string currencyId) => MultipList.Where(x => x.OperatorID.Equals(operatorId) && x.CurrencyID.Equals(currencyId)).ToList();
        //public static Mines_config_multipEO GetMultip(int itemId, string operatorId, string currencyId)
        //{
        //    try
        //    {
        //        return GetMultipList(operatorId, currencyId).First(x => x.ItemID == itemId);
        //    }
        //    catch (Exception e)
        //    {
        //        throw new Exception($"itemId:{itemId},ex:{e}");
        //    }

        //}
        //public static Mines_config_multipEO? GetMaxMultip(string operatorId, string currencyId)
        //{
        //    return GetMultipList(operatorId, currencyId).MaxBy(x => x.Multip5);
        //}
        //#endregion

        //#region gsp_config_weight  
        //private static List<Mines_config_weightEO>? _weightAll;
        //public static List<Mines_config_weightEO> WeightAll
        //{
        //    get
        //    {
        //        _weightAll ??= new Mines_config_weightMO().GetAll();
        //        return _weightAll;
        //    }
        //}

        //public static List<Mines_config_weightEO> GetWeightList(int itemType, string operatorId, string currencyId)
        //{
        //    return WeightAll.Where(x => x.ItemType == itemType && x.OperatorID.Equals(operatorId) && x.CurrencyID.Equals(currencyId))
        //        .OrderBy(x => x.ItemID).ToList();
        //}

        //#endregion

        /* #region gsp_user_ext
      private static readonly object _syncExt = new();
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
        }
       #endregion
        */
        //#endregion
        public static void Clear()
        {
            //_configDic = null;
            //_luckyList = null;
            //_luckyMultipList = null;
            //_luckyNumList = null;
        }
    }
}
