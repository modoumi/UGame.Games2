//using BestShooter.BLL.Services.UserDCaches;
//using TinyFx.Caching;
//using TinyFx.Extensions.StackExchangeRedis;

//namespace BestShooter.BLL.Caching
//{
//    public class AppUserDCache : RedisHashExpireClient<AppUserDo>
//    {
//        private int EXPIRE_MINUTES = 30;
//        public AppUserDCache(string userId)
//        {
//            this.UserId = userId;
//            RedisKey = GetProjectRedisKey(userId);
//        }
//        protected override async Task<CacheValue<CacheItem<AppUserDo>>> LoadValueWhenRedisNotExistsAsync(string field)
//        {

//        }
//        public AppUserDo GetAppUserDCache(bool enforce = false)
//        {
//            var ret = GetOrLoadAsync(UserId.ToString(), enforce);
//            KeyExpireMinutesAsync(EXPIRE_MINUTES);
//            return ret.Result.Value;
//        }

//        public void SeAppUserDCache(AppUserDo value)
//        {
//            SetAsync(value.UserId, value);
//        }
//        /*
//                private const string Key_IsWin = "IsWin";
//                /// <summary>
//                /// 下注结果
//                /// </summary>
//                public bool IsWin
//                {
//                    get => GetOrDefault<bool>(Key_IsWin, false);
//                    set => Set(Key_IsWin, value);
//                }

//                private const string Key_WinAmount = "WinAmount";
//                /// <summary>
//                /// 上一次踢球结果金额（单踢球）
//                /// </summary>
//                public long WinAmount
//                {
//                    get => GetOrDefault<long>(Key_WinAmount, 0);
//                    set => Set(Key_WinAmount, value);
//                }

//                private const string Key_PreResultAmount = "PreResultAmount";
//                /// <summary>
//                /// 上一次踢球结果金额（踢球+JP奖励）
//                /// </summary>
//                public long PreResultAmount
//                {
//                    get => GetOrDefault<long>(Key_PreResultAmount, 0);
//                    set => Set(Key_PreResultAmount, value);
//                }

//                private const string Key_IsWinJackpot = "IsWinJackpot";
//                /// <summary>
//                /// 是否获得JP奖励
//                /// </summary>
//                public bool IsWinJackpot
//                {
//                    get => GetOrDefault<bool>(Key_IsWinJackpot, false);
//                    set => Set(Key_IsWinJackpot, value);
//                }

//                private const string Key_JackpotRaffleAmount = "JackpotRaffleAmount";
//                /// <summary>
//                /// 获得JP奖励金额
//                /// </summary>
//                public decimal JackpotRaffleAmount
//                {
//                    get => GetOrDefault<decimal>(Key_JackpotRaffleAmount, 0);
//                    set => Set(Key_JackpotRaffleAmount, value);
//                }

//                private const string Key_BaseBet = "BaseBet";
//                /// <summary>
//                /// 用户基础下注额
//                /// </summary>
//                public long BaseBet
//                {
//                    get => GetOrDefault<long>(Key_BaseBet, 0);
//                    set => Set(Key_BaseBet, value);
//                }

//                private const string Key_PreBaseBet = "PreBaseBet";
//                /// <summary>
//                /// 上一次基础下注额
//                /// </summary>
//                public long PreBaseBet
//                {
//                    get => GetOrDefault<long>(Key_PreBaseBet, 0);
//                    set => Set(Key_PreBaseBet, value);
//                }

//                private const string Key_PreBet = "PreBet";
//                /// <summary>
//                /// 用户上一次下注金额
//                /// </summary>
//                public long PreBet
//                {
//                    get => GetOrDefault<long>(Key_PreBet, 0);
//                    set => Set(Key_PreBet, value);
//                }

//                private const string Key_PreBetMultiple = "PreBetMultiple";
//                /// <summary>
//                /// 上一次下注加倍数
//                /// </summary>
//                public decimal PreBetMultiple
//                {
//                    get => GetOrDefault<decimal>(Key_PreBetMultiple, 0);
//                    set => Set(Key_PreBetMultiple, value);
//                }

//                private const string Key_PrePlace = "PrePlace";
//                /// <summary>
//                /// 上一次下注位置
//                /// </summary>
//                public int PrePlace
//                {
//                    get => GetOrDefault<int>(Key_PrePlace, 0);
//                    set => Set(Key_PrePlace, value);
//                }

//                private const string Key_GoalProgress = "GoalProgress";
//                /// <summary>
//                /// 目标进度
//                /// </summary>
//                public int GoalProgress
//                {
//                    get => GetOrDefault<int>(Key_GoalProgress, 0);
//                    set => Set(Key_GoalProgress, value);
//                }

//                private const string Key_LuckyValue = "LuckyValue";
//                /// <summary>
//                /// 当前用户Lucky值
//                /// </summary>
//                public int LuckyValue
//                {
//                    get => GetOrDefault<int>(Key_LuckyValue, 0);
//                    set => Set(Key_LuckyValue, value);
//                }

//                private const string Key_PreStarID = "PreStarID";
//                /// <summary>
//                /// 上一个球星id
//                /// </summary>
//                public int PreStarID
//                {
//                    get => GetOrDefault<int>(Key_PreStarID, 0);
//                    set => Set(Key_PreStarID, value);
//                }

//                private const string Key_SumBetNum = "SumBetNum";
//                /// <summary>
//                /// 累计踢球次数
//                /// </summary>
//                public int SumBetNum
//                {
//                    get => GetOrDefault<int>(Key_SumBetNum, 0);
//                    set => Set(Key_SumBetNum, value);
//                }

//                private const string Key_UserId = "UserId";
//                /// <summary>
//                /// userId
//                /// </summary>
//                public string UserId
//                {
//                    get => GetOrDefault<string>(Key_UserId, string.Empty);
//                    set => Set(Key_UserId, value);
//                }

//                private const string Key_PlatformToken = "PlatformToken";
//                /// <summary>
//                /// 访问平台的token
//                /// </summary>
//                public string PlatformToken
//                {
//                    get => GetOrDefault<string>(Key_PlatformToken, string.Empty);
//                    set => Set(Key_PlatformToken, value);
//                }

//                private const string Key_AppId = "AppId";
//                /// <summary>
//                /// AppId
//                /// </summary>
//                public string AppId
//                {
//                    get => GetOrDefault<string>(Key_AppId, string.Empty);
//                    set => Set(Key_AppId, value);
//                }

//                private const string Key_OperatorId = "OperatorId";
//                /// <summary>
//                /// OperatorId
//                /// </summary>
//                public string OperatorId
//                {
//                    get => GetOrDefault<string>(Key_OperatorId, string.Empty);
//                    set => Set(Key_OperatorId, value);
//                }

//                private const string Key_ProviderId = "ProviderId";
//                /// <summary>
//                /// ProviderId
//                /// </summary>
//                public string ProviderId
//                {
//                    get => GetOrDefault<string>(Key_ProviderId, string.Empty);
//                    set => Set(Key_ProviderId, value);
//                }

//                private const string Key_CurrencyId = "CurrencyId";
//                /// <summary>
//                /// CountryId
//                /// </summary>
//                public string CurrencyId
//                {
//                    get => GetOrDefault<string>(Key_CurrencyId, string.Empty);
//                    set => Set(Key_CurrencyId, value);
//                }

//                private const string Key_IsCollect = "IsCollect";
//                /// <summary>
//                /// 是否强制结算
//                /// </summary>
//                public bool IsCollect
//                {
//                    get => GetOrDefault<bool>(Key_IsCollect, false);
//                    set => Set(Key_IsCollect, value);
//                }


//                private const string Key_IsTriggerJackpotRaffle = "IsTriggerJackpotRaffle";
//                /// <summary>
//                /// 是否触发Jackpot抽奖
//                /// </summary>
//                public bool IsTriggerJackpotRaffle
//                {
//                    get => GetOrDefault<bool>(Key_IsTriggerJackpotRaffle, false);
//                    set => Set(Key_IsTriggerJackpotRaffle, value);
//                }

//                /// <summary>
//                /// 设置UserDCache
//                /// </summary>
//                /// <param name="user"></param>
//                /// <returns></returns>
//                public async Task SetValues(UserDCache user)
//                {
//                    var values = new Dictionary<string, object>
//                    {
//                        { Key_BaseBet,user.BaseBet },
//                        { Key_PreBaseBet,user.PreBaseBet },
//                        { Key_PreBet,user.PreBet },
//                        { Key_PreBetMultiple,user.PreBetMultiple },
//                        { Key_PrePlace,user.PrePlace },
//                        { Key_PreResultAmount,user.PreResultAmount },
//                        { Key_WinAmount,user.WinAmount },
//                        { Key_PreStarID,user.PreStarID },
//                        { Key_GoalProgress,user.GoalProgress },
//                        { Key_LuckyValue,user.LuckyValue },
//                        { Key_IsWin,user.IsWin },
//                        { Key_UserId,user.UserId },
//                        { Key_PlatformToken,user.PlatformToken },
//                        { Key_AppId,user.AppId },
//                        { Key_OperatorId,user.OperatorId },
//                        { Key_ProviderId,user.ProviderId },
//                        { Key_CurrencyId,user.CurrencyId },
//                        { Key_SumBetNum,user.SumBetNum },
//                        { Key_IsWinJackpot,user.IsWinJackpot },
//                        { Key_JackpotRaffleAmount,user.JackpotRaffleAmount },
//                        { Key_IsCollect,user.IsCollect },
//                        { Key_IsTriggerJackpotRaffle,user.IsTriggerJackpotRaffle}
//                    };
//                    await SetAsync(values);
//                }

//                public void MapFrom(UserDCache source)
//                {
//                    throw new NotImplementedException();
//                }*/
//    }

//    public class AppUserDo
//    {
//        /// <summary>
//        /// 下注结果
//        /// </summary>
//        public bool IsWin { get; set; }
//        /// <summary>
//        /// 上一次踢球结果金额（单踢球）
//        /// </summary>
//        public long WinAmount { get; set; }
//        /// <summary>
//        /// 上一次踢球结果金额（踢球+JP奖励）
//        /// </summary>
//        public long PreResultAmount { get; set; }
//        /// <summary>
//        /// 是否获得JP奖励
//        /// </summary>
//        public bool IsWinJackpot { get; set; }
//        /// <summary>
//        /// 获得JP奖励金额
//        /// </summary>
//        public decimal JackpotRaffleAmount { get; set; }

//        /// <summary>
//        /// 用户基础下注额
//        /// </summary>
//        public long BaseBet { get; set; }

//        /// <summary>
//        /// 上一次基础下注额
//        /// </summary>
//        public long PreBaseBet { get; set; }
//        /// <summary>
//        /// 用户上一次下注金额
//        /// </summary>
//        public long PreBet { get; set; }

//        /// <summary>
//        /// 上一次下注加倍数
//        /// </summary>
//        public decimal PreBetMultiple { get; set; }

//        /// <summary>
//        /// 上一次下注位置
//        /// </summary>
//        public int PrePlace { get; set; }

//        /// <summary>
//        /// 目标进度
//        /// </summary>
//        public int GoalProgress { get; set; }

//        /// <summary>
//        /// 当前用户Lucky值
//        /// </summary>
//        public int LuckyValue { get; set; }

//        /// <summary>
//        /// 上一个球星id
//        /// </summary>
//        public int PreStarID { get; set; }

//        /// <summary>
//        /// 累计踢球次数
//        /// </summary>
//        public int SumBetNum { get; set; }

//        /// <summary>
//        /// userId
//        /// </summary>
//        public string UserId { get; set; }
//        /// <summary>
//        /// 访问平台的token
//        /// </summary>
//        public string PlatformToken { get; set; }
//        /// <summary>
//        /// AppId
//        /// </summary>
//        public string AppId { get; set; }
//        /// <summary>
//        /// OperatorId
//        /// </summary>
//        public string OperatorId { get; set; }

//        /// <summary>
//        /// ProviderId
//        /// </summary>
//        public string ProviderId { get; set; }

//        /// <summary>
//        /// CountryId
//        /// </summary>
//        public string CurrencyId { get; set; }

//        /// <summary>
//        /// 是否强制结算
//        /// </summary>
//        public bool IsCollect { get; set; }

//        /// <summary>
//        /// 是否触发Jackpot抽奖
//        /// </summary>
//        public bool IsTriggerJackpotRaffle { get; set; }
//    }
//}




