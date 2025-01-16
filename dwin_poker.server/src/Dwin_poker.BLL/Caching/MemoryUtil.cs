using Dwin_poker.BLL.LoadSvc;
using Dwin_poker.DAL;
using TinyFx.Collections;
using TinyFx.DbCaching;
using Xxyy.Common;
using Xxyy.GameEAPI.Common;

namespace Dwin_poker.BLL.Caching
{
    public static class MemoryUtil
    {
        #region dwp_config

        //private static Dwp_configEO? _config;
        //private static Dwp_configEO Config
        //{
        //    get
        //    {
        //        if (_config == null)
        //        {
        //            _config = new Dwp_configMO().GetSingle();
        //        }
        //        return _config;
        //    }
        //}
        //private static readonly object _syncConfig = new();
        //private static Dictionary<string, Dwp_configEO>? _configDic;
        //private static Dictionary<string, Dwp_configEO> ConfigDic
        //{
        //    get
        //    {

        //        if (_configDic == null)
        //        {
        //            lock (_syncConfig)
        //            {
        //                if (_configDic == null)
        //                {
        //                    var values = new Dictionary<string, Dwp_configEO>();
        //                    foreach (var item in new Dwp_configMO().GetAll())
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

        //public static Dwp_configEO GetConfig(string operatorId, string currencyId) => ConfigDic[(operatorId + currencyId)];


        public static Dwp_configPO GetConfig(string operatorId, string currencyId)
        {
            var ret = DbCachingUtil.GetSingle<Dwp_configPO>(it => new { it.OperatorID, it.CurrencyID }, new Dwp_configPO
            {
                OperatorID = operatorId,
                CurrencyID = currencyId,
            });
            return ret;
        }

        #endregion

        #region dwp_config_chips

        //private static readonly object _sync = new();
        //private static Dictionary<int, Dwp_config_chipsEO>? _chipsDic;
        //private static Dictionary<int, Dwp_config_chipsEO> ChipsDic
        //{
        //    get
        //    {
        //        if (_chipsDic == null)
        //        {
        //            lock (_sync)
        //            {
        //                if (_chipsDic == null)
        //                {
        //                    var values = new Dictionary<int, Dwp_config_chipsEO>();
        //                    foreach (var item in new Dwp_config_chipsMO().GetAll())
        //                        values.Add(item.ChipsID, item);
        //                    _chipsDic = values;
        //                }
        //            }
        //        }
        //        return _chipsDic;
        //    }
        //}

        public static Dwp_config_chipsPO GetChips(int chipsId)
        {
            var ret = DbCachingUtil.GetSingle<Dwp_config_chipsPO>(it => new { it.ChipsID }, new Dwp_config_chipsPO
            {
                ChipsID = chipsId
            });
            return ret;
        }

        //private static List<Chips>? _metaChips;

        public static long GetJpRewardByIndex(int chipsId, int index)
        {
            Dwp_config_chipsPO chipsEo = GetChips(chipsId);

            if (chipsEo != null)
            {
                long[] arr = new long[] { chipsEo.JPMini, chipsEo.JPMajor, chipsEo.JPMega };
                return arr[index];
            }
            throw new Exception($"Dwp_config_chipsEO 无对应货币配置chips:{chipsId} ,index:{index}");
        }

        public static List<Chips> GetLoadChips(string currencyId)
        {
            List<Chips>? _metaChips = new List<Chips>();


            var values = new Dictionary<string, List<Chips>>();
            var items = DbCachingUtil.GetAllList<Dwp_config_chipsPO>().OrderBy(x => x.BetBaseAmount).ToList();
            foreach (var item in items)
            {
                var newValue = new Chips
                {
                    ChipsId = item.ChipsID,
                    Bet = XxyyUtil.AToM(item.BetBaseAmount, currencyId),
                    JpRewardList = new List<decimal> {
                                    XxyyUtil.AToM(item.JPMini, currencyId),
                                    XxyyUtil.AToM(item.JPMajor, currencyId),
                                    XxyyUtil.AToM(item.JPMega, currencyId),
                                }
                };
                _metaChips.Add(newValue);
            }

            return _metaChips;
        }
        #endregion

        #region dwp_config_star_weight
        //private static readonly object _syncStar = new();
        //private static Dictionary<string, Dwp_config_star_weightEO> _starDic;
        //private static Dictionary<string, Dwp_config_star_weightEO> StarDic
        //{
        //    get
        //    {
        //        if (_starDic == null)
        //        {
        //            lock (_syncStar)
        //            {
        //                if (_starDic == null)
        //                {
        //                    var values = new Dictionary<string, Dwp_config_star_weightEO>();
        //                    foreach (var item in new Dwp_config_star_weightMO().GetAll())
        //                    {
        //                        string key = item.StarNum.ToString();
        //                        if (!values.ContainsKey(key))
        //                            values.Add(key, item);
        //                    }
        //                    _starDic = values;
        //                }
        //            }
        //        }
        //        return _starDic;
        //    }
        //}

        private static List<Dwp_config_star_weightPO> StarDic => DbCachingUtil.GetAllList<Dwp_config_star_weightPO>();


        public static Dwp_config_star_weightPO GetStarWeight(int starNum)
        {
            //string key = starNum.ToString();
            //if (StarDic.ContainsKey(key))
            //{
            //    return StarDic[key];
            //}
            //return null;

           return StarDic.FirstOrDefault(a => a.StarNum == starNum);
        }
        public static int GetMaxStar() => StarDic.Count;
        #endregion

        #region dwp_config_rank

        //private static Dictionary<string, Dwp_config_rankEO> _rankDic;
        //private static Dictionary<string, Dwp_config_rankEO> RankDic
        //{
        //    get
        //    {
        //        if (_rankDic == null)
        //        {
        //            _rankDic = new();
        //            var list = new Dwp_config_rankMO().GetAll();
        //            foreach (var rank in list)
        //            {
        //                var key = rank.RankNo.ToString();
        //                _rankDic.Add(key, rank);
        //            }
        //        }
        //        return _rankDic;
        //    }
        //}

        private static List< Dwp_config_rankPO> RankDic=> DbCachingUtil.GetAllList<Dwp_config_rankPO>();

        public static Dwp_config_rankPO GetRank(int rankNo) => RankDic.FirstOrDefault(c=>c.RankNo==rankNo);
        public static Dwp_config_rankPO GetRankFrist()
        {
            return GetRank(1);
        }
        #endregion

        #region dwp_config_jackpot_weight
        //private static List<Dwp_config_jackpot_weightEO> _jpWeightList;
        //private static List<Dwp_config_jackpot_weightEO> JPWeightList
        //{
        //    get
        //    {
        //        if (_jpWeightList == null)
        //        {
        //            return new Dwp_config_jackpot_weightMO().GetAll();
        //        }
        //        return _jpWeightList;
        //    }
        //}

        private static List<Dwp_config_jackpot_weightPO> JPWeightList=> DbCachingUtil.GetAllList<Dwp_config_jackpot_weightPO>();

        public static List<Dwp_config_jackpot_weightPO> GeJPWeightList(int chipsId, int jpVal)
        {
            var list = JPWeightList.Where(x => x.ChipsId == chipsId && x.JPTotalValMin <= jpVal && jpVal < x.JPTotalValMax).OrderBy(x => x.JPRewardIndex);
            if (list.Any())
            {
                return list.ToList();
            }
            throw new Exception("配置Dwp_config_jackpot_weightEO 数据不存在！");
        }
        #endregion

        public static void Clear()
        {
            //_configDic = null;
            //_config = null;
            //_metaChips = null;
            //_chipsDic = null;
            //_starDic = null;
            //_rankDic = null;
            //_jpWeightList = null;
        }
    }
}
