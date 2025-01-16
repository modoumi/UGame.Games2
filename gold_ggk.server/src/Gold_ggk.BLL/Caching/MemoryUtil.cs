using Gold_ggk.BLL.LoadSvc;
using Gold_ggk.DAL;
using StackExchange.Redis;
using TinyFx;
using TinyFx.Collections;
using TinyFx.DbCaching;
using Xxyy.Common;
using Xxyy.GameEAPI.Common;

namespace Gold_ggk.BLL.Caching
{
    public static class MemoryUtil
    {
        #region ggk_config

        //private static Ggk_configEO? _config;
        //private static Ggk_configEO Config
        //{
        //    get
        //    {
        //        if (_config == null)
        //        {
        //            _config = new Ggk_configMO().GetSingle();
        //        }
        //        return _config;
        //    }
        //}
        //private static readonly object _syncConfig = new();
        //private static Dictionary<string, Ggk_configEO>? _configDic;
        //private static Dictionary<string, Ggk_configEO> ConfigDic
        //{
        //    get
        //    {

        //        if (_configDic == null)
        //        {
        //            lock (_syncConfig)
        //            {
        //                if (_configDic == null)
        //                {
        //                    var values = new Dictionary<string, Ggk_configEO>();
        //                    foreach (var item in new Ggk_configMO().GetAll())
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

        //public static Ggk_configEO GetConfig(string operatorId, string currencyId) => ConfigDic[(operatorId + currencyId)];


        public static Ggk_configPO GetConfig(string operatorId, string currencyId)
        {
            var ret = DbCachingUtil.GetSingle<Ggk_configPO>(it => new { it.OperatorID, it.CurrencyID }, new Ggk_configPO
            {
                OperatorID = operatorId,
                CurrencyID = currencyId,
            });
            return ret;
        }

        #endregion

        #region ggk_config_chips

        public class Config_Chips
        {
            public int ChipsId { get; set; }
            public long BetAmount { get; set; }
            public List<long> PrizeAmount { get; set; }
            public List<long> JackpotAmount { get; set; }
            public long JpRewardAmount { get; set; }
            public long MaxRewardAmount { get; set; }
        }

        //private static readonly object _sync = new();
        //private static Dictionary<int, Config_Chips>? _chipsDic;
        private static Dictionary<int, Config_Chips> ChipsDic
        {
            get
            {
                Dictionary<int, Config_Chips>? _chipsDic = new Dictionary<int, Config_Chips>();

                var v = DbCachingUtil.GetAllList<Ggk_config_chipsPO>();
                var values = new Dictionary<int, Config_Chips>();
                foreach (var item in v)
                    values.Add(item.ChipsID, new Config_Chips
                    {
                        ChipsId = item.ChipsID,
                        BetAmount = item.BetAmount,
                        PrizeAmount = item.PrizeAmount.Split("|").Select(x => x.ToInt64()).ToList(),
                        JackpotAmount = item.JackpotAmount.Split("|").Select(x => x.ToInt64()).ToList(),
                        JpRewardAmount = item.JpRewardAmount,
                        MaxRewardAmount = item.MaxRewardAmount,
                    });

                _chipsDic = values;

                return _chipsDic;
            }
        }

        public static Config_Chips GetChips(int chipsId) => ChipsDic[chipsId];

      //  private static List<Chips>? _metaChipsList;

        public static Chips GetMetaChipsByChipsId(int chipsId, string currencyId)
        {
            return GetMetaChips(currencyId).Where(x => x.ChipsId == chipsId).First();
        }
        public static List<Chips> GetMetaChips(string currencyId)
        {
            
              var  _metaChipsList = new List<Chips>();
                var items = ChipsDic.Values.OrderBy(x => x.BetAmount).ToList();
                foreach (var item in items)
                {
                    var key = item.ChipsId;
                    Chips newValues = new()
                    {
                        ChipsId = item.ChipsId,
                        Bet = item.BetAmount.AToM(currencyId),
                        BetResultList = ChangeDecimal(item.PrizeAmount, currencyId),
                        JpBonusList = ChangeDecimal(item.JackpotAmount, currencyId),
                        JpReward = item.JpRewardAmount.AToM(currencyId),
                        MaxReward = item.MaxRewardAmount.AToM(currencyId),
                    };
                    _metaChipsList.Add(newValues);
                }
            
            return _metaChipsList;
        }

        private static List<decimal> ChangeDecimal(List<long> arrs, string currencyId)
        {
            var list = new List<decimal>();
            foreach (var i in arrs)
            {
                list.Add(i.AToM(currencyId));
            }
            return list;
        }
        #endregion

        #region ggk_user_ext
        private static readonly object _syncExt = new();
        private static Dictionary<string, Ggk_user_extEO>? _userExtDic;
        private static Dictionary<string, Ggk_user_extEO> UserExtDic
        {
            get
            {
                if (_userExtDic == null)
                {
                    lock (_syncExt)
                    {
                        if (_userExtDic == null)
                        {
                            var values = new Dictionary<string, Ggk_user_extEO>();
                            foreach (var item in new Ggk_user_extMO().GetAll())
                            {
                                string key = item.UserID + "_" + item.ChipsID;
                                if (!values.ContainsKey(key))
                                    values.Add(key, item);
                            }
                            _userExtDic = values;
                        }
                    }
                }
                return _userExtDic;
            }
        }
        public static List<Ggk_user_extEO> GetUserExtList(string userId)
        {
            Ggk_user_extMO _userMo = new Ggk_user_extMO();
            return _userMo.GetByUserID(userId);
        }
        public static Ggk_user_extEO? GetUserExt(string userId, int chipsId)
        {
            return GetUserExtList(userId).FirstOrDefault(x => x.ChipsID == chipsId);
        }
        #endregion

        #region ggk_config_weight
         
        private static List<Ggk_config_weightPO> WeightList => DbCachingUtil.GetAllList<Ggk_config_weightPO>();


        public static List<Ggk_config_weightPO> GetWeightList()
        {
            return WeightList;
        }

        public static Ggk_config_weightPO GetMulitp()
        {   //中奖几率随机数 [0,100)
            List<Ggk_config_weightPO> list = GetWeightList();
            var count = list.Sum(x => x.Weight);
            var random = new Random().Next(count);
            int startNum = 0;
            foreach (var item in list)
            {
                if (random >= startNum && random < (item.Weight + startNum))
                {
                    return item;
                }
                startNum += item.Weight;
            }
            throw new Exception("权重读取Ggk_config_weightEO 数据不存在！");
        }
        #endregion

        #region ggk_config_chips_group
        public class Config_Chips_Group
        {
            public int ChipsId { get; set; }
            public string OperatorId { get; set; }
            public string CurrencyId { get; set; }
            public long BetTotalAmount { get; set; }
            public List<string> Group { get; set; }
        }
        //private static readonly object _syncChipsGroup = new();
        //private static Dictionary<string, Config_Chips_Group>? _chipsGroupDic;
        private static Dictionary<string, Config_Chips_Group> ChipsGroupDic
        {
            get
            {

                Dictionary<string, Config_Chips_Group>? _chipsGroupDic=new Dictionary<string, Config_Chips_Group> ();
              
                            var values = new Dictionary<string, Config_Chips_Group>();
                            var v = DbCachingUtil.GetAllList<Ggk_config_chips_groupPO>();


                            foreach (var item in v)
                                values.Add($"{item.ChipsID}|{item.BetTotalAmount}", new Config_Chips_Group
                                {
                                    ChipsId = item.ChipsID,
                                    BetTotalAmount = item.BetTotalAmount,
                                    Group = item.Group.Split("|").ToList(),
                                });

                            _chipsGroupDic = values;
              
                return _chipsGroupDic;
            }
        }

        public static List<string> GetChipsGroup(int chipsId, long betTotalAmount)
        {
            string key = $"{chipsId}|{betTotalAmount}";
            if (ChipsGroupDic[key] == null)
            {
                throw new Exception("彩票奖金配置错误,key:" + key);
            }
            return ChipsGroupDic[key].Group;
        }
        #endregion

        #region ggk_config_weight_jackpot
        //private static readonly object _jackpotSync = new();
        //private static Dictionary<int, Ggk_config_weight_jackpotEO>? _jackpotDic;
        private static Dictionary<int, Ggk_config_weight_jackpotEO> JackpotDic
        {
            get
            {
                Dictionary<int, Ggk_config_weight_jackpotEO>? _jackpotDic = new Dictionary<int, Ggk_config_weight_jackpotEO>();

                var values = new Dictionary<int, Ggk_config_weight_jackpotEO>();

                var v = DbCachingUtil.GetAllList<Ggk_config_weight_jackpotPO>();

                foreach (var item in v)
                    values.Add(item.JPID, new Ggk_config_weight_jackpotEO
                    {
                        JPID = item.JPID,
                        Mulitp = item.Mulitp,
                        Weight = item.Weight,
                        Group = item.Group,
                    });

                _jackpotDic = values;

                return _jackpotDic;
            }
        }
        //private static List<Ggk_config_weight_jackpotEO>? _jpweightList;
        private static List<Ggk_config_weight_jackpotPO> JpWeightList
        {
            get
            {
                //if (_jpweightList == null)
                //{
                //    return new Ggk_config_weight_jackpotMO().GetAll();
                //}
                //return _jpweightList;

                return DbCachingUtil.GetAllList<Ggk_config_weight_jackpotPO>();
            }
        }

        public static List<Ggk_config_weight_jackpotPO> GetWeightJpList()
        {
            return JpWeightList;
        }
        public static Ggk_config_weight_jackpotPO GetMulitpJackPot()
        {   //中奖几率随机数 [0,100)
            List<Ggk_config_weight_jackpotPO> list = GetWeightJpList();
            var count = list.Sum(x => x.Weight);
            var random = new Random().Next(count);
            int startNum = 0;
            foreach (var item in list)
            {
                if (random >= startNum && random < (item.Weight + startNum))
                {
                    return item;
                }
                startNum += item.Weight;
            }
            throw new Exception("权重读取Ggk_config_weightEO 数据不存在！");
        }
        #endregion


        public static void Clear()
        {
            //_config = null;
            //_metaChipsList = null;
            //_chipsDic = null;
            _userExtDic = null;
            //_chipsGroupDic = null;
            //_weightList = null;
            //_jpweightList = null;
        }
    }
}
