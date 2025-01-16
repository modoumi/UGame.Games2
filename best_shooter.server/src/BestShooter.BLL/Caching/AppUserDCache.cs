using BestShooter.BLL.Services.UserDCaches;
using TinyFx.Extensions.StackExchangeRedis;

namespace BestShooter.BLL.Caching
{
    public class AppUserDCache : RedisHashClient
    {

        public AppUserDCache(string userId)
        {
            RedisKey = GetProjectRedisKey(userId);
        }

        private const string Key_IsWin = "IsWin";

        public async Task<bool> GetIsWinAsync() => await GetOrDefaultAsync(Key_IsWin, false);
        public async Task<bool> SetIsWinAsync(bool value = true) => await SetAsync(Key_IsWin, value);


        private const string Key_WinAmount = "WinAmount";

        public async Task<long> GetWinAmountAsync() => await GetOrDefaultAsync(Key_WinAmount, 0L);
        public async Task<bool> SetWinAmountAsync(long value) => await SetAsync(Key_WinAmount, value);


        private const string Key_PreResultAmount = "PreResultAmount";

        public async Task<long> GetPreResultAmountAsync() => await GetOrDefaultAsync(Key_PreResultAmount, 0L);
        public async Task<bool> SetPreResultAmountAsync(long value) => await SetAsync(Key_PreResultAmount, value);

        private const string Key_IsWinJackpot = "IsWinJackpot";

        public async Task<bool> GetIsWinJackpotAsync() => await GetOrDefaultAsync(Key_IsWinJackpot, false);
        public async Task<bool> SetIsWinJackpotAsync(bool value = true) => await SetAsync(Key_IsWinJackpot, value);
        

        private const string Key_JackpotRaffleAmount = "JackpotRaffleAmount";

        public async Task<decimal> GetJackpotRaffleAmountAsync() => await GetOrDefaultAsync(Key_JackpotRaffleAmount, 0.0m);
        public async Task<bool> SetJackpotRaffleAmountAsync(decimal value) => await SetAsync(Key_JackpotRaffleAmount, value);

        private const string Key_BaseBet = "BaseBet";

        public async Task<long> GetBaseBetAsync() => await GetOrDefaultAsync(Key_BaseBet, 0L);
        public async Task<bool> SetBaseBetAsync(long value) => await SetAsync(Key_BaseBet, value);

        private const string Key_PreBaseBet = "PreBaseBet";

        public async Task<long> GetPreBaseBetAsync() => await GetOrDefaultAsync(Key_PreBaseBet, 0L);
        public async Task<bool> SetPreBaseBetAsync(long value) => await SetAsync(Key_PreBaseBet, value);

        private const string Key_PreBet = "PreBet";

        public async Task<long> GetPreBetAsync() => await GetOrDefaultAsync(Key_PreBet, 0L);
        public async Task<bool> SetPreBetAsync(long value) => await SetAsync(Key_PreBet, value);

        private const string Key_PreBetMultiple = "PreBetMultiple";

        public async Task<decimal> GetPreBetMultipleAsync() => await GetOrDefaultAsync(Key_PreBetMultiple, 0.0m);
        public async Task<bool> SetPreBetMultipleAsync(decimal value) => await SetAsync(Key_PreBetMultiple, value);

        private const string Key_PrePlace = "PrePlace";

        public async Task<int> GetPrePlaceAsync() => await GetOrDefaultAsync(Key_PrePlace, 0);
        public async Task<bool> SetPrePlaceAsync(int value) => await SetAsync(Key_PrePlace, value);

        private const string Key_GoalProgress = "GoalProgress";

        public async Task<int> GetGoalProgressAsync() => await GetOrDefaultAsync(Key_GoalProgress, 0);
        public async Task<bool> SetGoalProgressAsync(int value) => await SetAsync(Key_GoalProgress, value);

        private const string Key_LuckyValue = "LuckyValue";

        public async Task<int> GetLuckyValueAsync() => await GetOrDefaultAsync(Key_LuckyValue, 0);
        public async Task<bool> SetLuckyValueAsync(int value) => await SetAsync(Key_LuckyValue, value);

        private const string Key_PreStarID = "PreStarID";

        public async Task<int> GetPreStarIDAsync() => await GetOrDefaultAsync(Key_PreStarID, 0);
        public async Task<bool> SetPreStarIDAsync(int value) => await SetAsync(Key_PreStarID, value);

        private const string Key_SumBetNum = "SumBetNum";

        public async Task<int> GetSumBetNumAsync() => await GetOrDefaultAsync(Key_SumBetNum, 0);
        public async Task<bool> SetSumBetNumAsync(int value) => await SetAsync(Key_SumBetNum, value);

        private const string Key_UserId = "UserId";

        public async Task<string> GetUserIdAsync() => await GetOrDefaultAsync(Key_UserId, string.Empty);
        public async Task<bool> SetUserIdAsync(string value) => await SetAsync(Key_UserId, value);

        private const string Key_PlatformToken = "PlatformToken";

        public async Task<string> GetPlatformTokenAsync() => await GetOrDefaultAsync(Key_PlatformToken, string.Empty);
        public async Task<bool> SetPlatformTokenAsync(string value) => await SetAsync(Key_PlatformToken, value);

        private const string Key_AppId = "AppId";

        public async Task<string> GetAppIdAsync() => await GetOrDefaultAsync(Key_AppId, string.Empty);
        public async Task<bool> SetAppIdAsync(string value) => await SetAsync(Key_AppId, value);

        private const string Key_OperatorId = "OperatorId";

        public async Task<string> GetOperatorIdAsync() => await GetOrDefaultAsync(Key_OperatorId, string.Empty);
        public async Task<bool> SetOperatorIdAsync(string value) => await SetAsync(Key_OperatorId, value);

        private const string Key_ProviderId = "ProviderId";

        public async Task<string> GetProviderIdAsync() => await GetOrDefaultAsync(Key_ProviderId, string.Empty);
        public async Task<bool> SetProviderIdAsync(string value) => await SetAsync(Key_ProviderId, value);

        private const string Key_CurrencyId = "CurrencyId";

        public async Task<string> GetCurrencyIdAsync() => await GetOrDefaultAsync(Key_CurrencyId, string.Empty);
        public async Task<bool> SetCurrencyIdAsync(string value) => await SetAsync(Key_CurrencyId, value);

        private const string Key_IsCollect = "IsCollect";

        public async Task<bool> GetIsCollectAsync() => await GetOrDefaultAsync(Key_IsCollect, false);
        public async Task<bool> SetIsCollectAsync(bool value = true) => await SetAsync(Key_IsCollect, value);


        private const string Key_IsTriggerJackpotRaffle = "IsTriggerJackpotRaffle";

        public async Task<bool> GetIsTriggerJackpotRaffleAsync() => await GetOrDefaultAsync(Key_IsTriggerJackpotRaffle, false);
        public async Task<bool> SetIsTriggerJackpotRaffleAsync(bool value = true) => await SetAsync(Key_IsTriggerJackpotRaffle, value);

        /// <summary>
        /// 设置UserDCache
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public async Task SetValues(UserDCache user)
        {
            var values = new Dictionary<string, object>
            {
                { Key_BaseBet,user.BaseBet },
                { Key_PreBaseBet,user.PreBaseBet },
                { Key_PreBet,user.PreBet },
                { Key_PreBetMultiple,user.PreBetMultiple },
                { Key_PrePlace,user.PrePlace },
                { Key_PreResultAmount,user.PreResultAmount },
                { Key_WinAmount,user.WinAmount },
                { Key_PreStarID,user.PreStarID },
                { Key_GoalProgress,user.GoalProgress },
                { Key_LuckyValue,user.LuckyValue },
                { Key_IsWin,user.IsWin },
                { Key_UserId,user.UserId },
                { Key_PlatformToken,user.PlatformToken },
                { Key_AppId,user.AppId },
                { Key_OperatorId,user.OperatorId },
                { Key_ProviderId,user.ProviderId },
                { Key_CurrencyId,user.CurrencyId },
                { Key_SumBetNum,user.SumBetNum },
                { Key_IsWinJackpot,user.IsWinJackpot },
                { Key_JackpotRaffleAmount,user.JackpotRaffleAmount },
                { Key_IsCollect,user.IsCollect },
                { Key_IsTriggerJackpotRaffle,user.IsTriggerJackpotRaffle}
            };
            await SetAsync(values);
        }

        public void MapFrom(UserDCache source)
        {
            throw new NotImplementedException();
        }

        public async Task  SetAll(UserDCache userDCache ,AppUserDCache _appUserDCache) { 
        
        }
    }

}
