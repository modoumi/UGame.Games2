using Gold_ggk.DAL;
using TinyFx.Configuration;
using TinyFx.Extensions.StackExchangeRedis;

namespace Gold_ggk.BLL.Caching
{
    public class UserDataRedis : RedisHashClient<UserDataDO>
    {
        private int EXPIRE_MINUTES = 30;
        public string UserId { get; }
        private Ggk_bet_detailMO _detailMo = new();
        private Ggk_user_extMO _extMo = new();
        private int ChipsId { get; }

        public UserDataRedis(string userId, int chipsId)
        {
            ChipsId = chipsId;
            UserId = userId;
            RedisKey = GetProjectRedisKey(UserId);
            EXPIRE_MINUTES = ConfigUtil.Environment.IsDebug 
                ? int.MaxValue : 30;
        }
        /*
        protected override bool LoadValueWhenRedisNotExists(string field, out UserDataDO value)
        {
            var list = _detailMo.GetByUserID(UserId);
            Ggk_user_extEO ext = _extMo.GetByPK(UserId);
            if (ext == null)
            {
                ext = new Ggk_user_extEO
                {
                    UserID = UserId,
                    RoundIdx = 0, FreeSpinCount = 0,
                     
                 
                    UserStatus = (int)UserStatus.Normal,
                    LastRecDate = DateTime.UtcNow,
                };
                _extMo.Add(ext);
            }
            if (list != null && list.Count > 0)
            {
                //下注详情取一条最新记录
                var item = list.OrderByDescending(o => o.RecDate).First();

                value = new UserDataDO
                {
                    ChipsId = item.ChipsID,
                    CardIdx = item.CardIdx,
                    BetBaseAmount = item.BetBaseAmount,
                    Multip = item.BetMulitp,
                    BetResultAmount = item.BetResultAmount,
                    GameStatus = (GameStatus)item.GameStatus,
                    IsWin = item.IsWin,
                    History = item.History,
                    Ext = ext,
                };
            }
            else
            {
                value = UserDataDoInit(ext);
            }
            return true;
        }

        public UserDataDO UserDataDoInit(Ggk_user_extEO ext)
        {
            ext.RoundIdx = 0;
            ext.Star = 0;
            ext.LastUpdateDate = DateTime.UtcNow;
            Dwp_config_chipsEO Chips = GgkDBCacheUtil.GetChips(ChipsId);
            UserDataDO value = new()
            {
                ChipsId = ChipsId,
                CardIdx = 0,
                BetBaseAmount = Chips.BetBaseAmount,
                Multip = 1,
                BetResultAmount = 0,
                GameStatus = 0,
                IsWin = false,
                History = SerializerUtil.SerializeJsonNet(new List<History>(), new JsonSerializerSettings() { Formatting = Formatting.None }),
                Ext = ext,
            };
            SetUserDataDo(value);
            return value;
        }

        public UserDataDO GetUserDataDo(bool enforce = false)
        {
            var ret = GetOrLoad(UserId.ToString(), enforce);
            // if (!ret.HasValue)
            //      throw new Exception($"UserBingoNumDCache不存在UserChipsDataDO。userId:{UserId} chipsId:{chipsId}");
            //ret.Value.BingoPanelNumTwoD = ArrayUtil.OneToTwoD(ret.Value.BingoPanelNums, 5);
            //ret.Value.BingoHitLineNums = SlotUtil.GetBingoLineNums(ret.Value.BingoPanelNumTwoD, ret.Value.BingoHitLine);
            KeyExpireMinutes(EXPIRE_MINUTES);
            return ret.Value;
        }

        public void SetUserDataDo(UserDataDO value)
        {
            Set(UserId, value);
        } */
    }

    public class UserDataDO
    {
        /// <summary>
        /// 上一次的第一轮基础下注值对应的配置项，初始化给0
        /// </summary>
        public int ChipsId { get; set; }
        /// <summary>
        ///  卡牌idx，每轮只抽10张牌，抽完或gameStatus>0时重新洗牌，cardIdx归0
        /// </summary>
        public int CardIdx { get; set; }
        /// <summary>
        /// 上一轮的基础下注
        /// </summary>
        public long BetBaseAmount { get; set; }
        /// <summary>
        /// 下注倍数
        /// </summary>
        public float Multip { get; set; }
        /// <summary>
        /// 总下注 = 基础下注* 倍数
        /// </summary>
        public long BetTotalAmount => (long)(BetBaseAmount * Multip);
        /// <summary>
        /// 结果，赢了就是totalBet*2，输了就是0
        /// </summary>
        public long BetResultAmount { get; set; }
        /// <summary>
        /// 是否获胜
        /// </summary>
        public bool IsWin { get; set; }
        public string History { get; set; }
        /// <summary>
        /// 用户扩展属性
        /// </summary>
        public Ggk_user_extEO Ext { get; set; } = new Ggk_user_extEO();
    }
}
