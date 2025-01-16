using Dwin_poker.BLL.LoadSvc;
using Dwin_poker.DAL;
using Newtonsoft.Json;
using TinyFx;
using TinyFx.Caching;
using TinyFx.Configuration;
using TinyFx.Extensions.StackExchangeRedis;

namespace Dwin_poker.BLL.Caching
{
    public class UserDataRedis : RedisHashExpireClient<UserDataDO>
    {
        private int EXPIRE_MINUTES = 30;
        public string UserId { get; }
        private Dwp_bet_detailMO _detailMo = new();
        private Dwp_user_extMO _extMo = new();
        private int ChipsId { get; }

        public UserDataRedis(string userId, int chipsId)
        {
            ChipsId = chipsId;
            UserId = userId;
            RedisKey = GetProjectRedisKey(UserId); 
        }
        protected override async Task<CacheValue<CacheItem<UserDataDO>>> LoadValueWhenRedisNotExistsAsync(string field)
        {
            var list = await _detailMo.GetTopSortAsync("UserID = @UserId", 1, "RecDate desc", UserId);
           
            Dwp_user_extEO ext = _extMo.GetByPK(UserId);
            if (ext == null)
            {
                ext = new Dwp_user_extEO
                {
                    UserID = UserId,
                    RoundIdx = 0,
                    Star = 0,
                    JPTotalVal = 0,
                    UserStatus = (int)PokerUserStatus.Normal,
                    LastUpdateDate = DateTime.UtcNow,
                };
                _extMo.Add(ext);
            }
            var result = new CacheValue<CacheItem<UserDataDO>>();
            if (list != null && list.Count > 0)
            {
                //下注详情取一条最新记录
                var item = list.First();

                result.Value = new CacheItem<UserDataDO>(new UserDataDO
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
                });

            }
            else
            {
                result.Value = UserDataDoInit(ext);
            }
            result.HasValue = true;
            return result;
        }

        public CacheItem<UserDataDO> UserDataDoInit(Dwp_user_extEO ext)
        {
            ext.RoundIdx = 0;
            ext.Star = 0;
            ext.LastUpdateDate = DateTime.UtcNow;
            Dwp_config_chipsEO Chips = MemoryUtil.GetChips(ChipsId);

            var value = new CacheItem<UserDataDO>(new UserDataDO
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
            });

            SetUserDataDo(value.Value);
            return value;
        }

        public UserDataDO GetUserDataDo(bool enforce = false)
        {
            var ret = GetOrLoadAsync(UserId.ToString(), enforce);
            KeyExpireMinutesAsync(EXPIRE_MINUTES);
            return ret.Result.Value;
        }

        public void SetUserDataDo(UserDataDO value)
        {
            SetAsync(UserId, value);
        }
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
        public double Multip { get; set; }
        /// <summary>
        /// 总下注 = 基础下注* 倍数
        /// </summary>
        public long BetTotalAmount => (long)(BetBaseAmount * Multip);
        /// <summary>
        /// 结果，赢了就是totalBet*2，输了就是0
        /// </summary>
        public long BetResultAmount { get; set; }
        /// <summary>
        /// 游戏状态，初始为0，roundIdx>0时，需要判断4种状态，
        /// 1-star达到最大，2-betResult达到maxBet，
        /// 3-balance小于baseBet，4-balance小于betJpBonus中最小的下注值
        /// </summary>
        public GameStatus GameStatus { get; set; }
        /// <summary>
        /// 是否获胜
        /// </summary>
        public bool IsWin { get; set; }
        public string History { get; set; }
        /// <summary>
        /// 用户扩展属性
        /// </summary>
        public Dwp_user_extEO Ext { get; set; } = new Dwp_user_extEO();
    }
}
