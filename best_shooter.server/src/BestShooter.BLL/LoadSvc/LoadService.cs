using BestShooter.BLL.Caching;
using BestShooter.BLL.Common;
using BestShooter.BLL.Services;
using BestShooter.BLL.Services.Jackpot;
using BestShooter.BLL.Services.platform;
using BestShooter.BLL.Services.Star;
using BestShooter.BLL.Services.UserDCaches;
using BestShooter.BLL.Services.UserEx;
using BestShooter.DAL;
using TinyFx.Extensions.AutoMapper;
using Xxyy.Common.Caching;
using Xxyy.Common.Caching.Partner;
using Xxyy.GameEAPI.Common;
using Xxyy.GameEAPI.Core;
using Xxyy.GameEAPI.Services;

namespace BestShooter.BLL.LoadSvc
{
    public class LoadService : BaseApiGameService
    {
        //基础数据缓存服务
        private DCacheServices _dCacheService;

        //用户缓存服务
        private AppUserDCache _appUserDCache;

        //用户服务
        private UserExService _userExService = new();

        //奖池几率服务
        private JackpotOddsDCache _jackpotOddsDCache = new();

        //Jackpot奖池服务
        private JackpotService _jackpotService = new();

        //球星服务
        private StarService _starService = new();

        private readonly string _userId;

        private readonly AppLoginTokenDO appToken;

        private Bs_configEO _config { get; }
        public LoadService(string userId)
        {
            _dCacheService = new DCacheServices(userId);
            _appUserDCache = new AppUserDCache(userId);
            _userId = userId;
            appToken = GetLoginTokenDo(userId);
            _config = MemoryUtil.GetConfig(appToken.OperatorId, appToken.CurrencyId);
        }

        /// <summary>
        /// 游戏初始化加载用户数据
        /// </summary>
        /// <returns></returns>
        public async Task<LoadDto> Load()
        {
            Bs_user_extEO extEo = new();

            //查询当前用户是否存在
            extEo = await _userExService.GetUserExByPK(appToken.UserId);

            if (extEo == null || string.IsNullOrEmpty(extEo.UserID))
            {
                Bs_user_extEO userEx = new Bs_user_extEO()
                {
                    UserID = appToken.UserId,
                    RecDate = DateTime.UtcNow
                };
                await _userExService.AddUser(userEx);
            }

            UserService userService = new UserService();
            var user = await userService.GetByUserId(appToken.UserId);

            var _globalUserDCache = new GlobalUserDCache(appToken.UserId);

            await _globalUserDCache.SetBaseValues(user);

            await _appUserDCache.SetPlatformTokenAsync(appToken.Token);
            await _appUserDCache.SetAppIdAsync(appToken.AppId);
            await _appUserDCache.SetOperatorIdAsync(appToken.OperatorId);
            await _appUserDCache.SetProviderIdAsync(appToken.ProviderId);
            await _appUserDCache.SetCurrencyIdAsync(appToken.CurrencyId);
            await _appUserDCache.SetUserIdAsync(appToken.UserId);


            LoadDto dto = new LoadDto();
            //1、获取当前用户余额
            var balance = await GameEAPIUtil.GetBalance(_userId, appToken.AppId);

            //2、获取当前球星中奖几率数据
            var starList = MemoryUtil.GetStarList(appToken.OperatorId);
            var starOddsList = (await _dCacheService.GetAllStarOdds(appToken.OperatorId)).Where(d => d.OperatorID.Equals(appToken.OperatorId) && d.IsBaseMultiple == 1).ToList().Map<List<StarPositionMultiples>>();
            //【dto】基础数据：球星球门位置、倍数
            dto.starPositionMultiples = starOddsList.GroupBy(d => d.StarID).ToDictionary(d => d.Key, d => d.Where(m => m.StarID == d.Key).GroupBy(m => m.Multiples).Select(s => s.First()).OrderBy(o => o.Position).ToList());

            //3、获取随机球星
            var star = await _starService.GetOneRandomStar(await _appUserDCache.GetOperatorIdAsync());
            //4、获取系统配置

            //5、获取基础下注额对应的Jackpot奖金数据
            var jackpotOddsList = (await _jackpotOddsDCache.GetOrLoadAsync(appToken.OperatorId)).Value.Where(d => d.OperatorID.Equals(appToken.OperatorId)).ToList().Map<List<BetAmountMapJackpotBonus>>();
            //6、获取当前用户数据
            extEo = await _userExService.GetUserExByPK(_userId);
            //7、获取当前Jackpot奖池数据
            var jackpot = await _jackpotService.GetJackpotPool(appToken.OperatorId, appToken.CurrencyId);

            //用户缓存
            UserDCache userDCache = new UserDCache();

            userDCache.BaseBet = await _appUserDCache.GetBaseBetAsync();
            userDCache.PreBaseBet = await _appUserDCache.GetPreBaseBetAsync();
            userDCache.PreBet = await _appUserDCache.GetPreBetAsync();
            userDCache.PreBetMultiple = await _appUserDCache.GetPreBetMultipleAsync();
            userDCache.PrePlace = await _appUserDCache.GetPrePlaceAsync();
            userDCache.PreResultAmount = await _appUserDCache.GetPreResultAmountAsync();
            userDCache.WinAmount = await _appUserDCache.GetWinAmountAsync();
            userDCache.PreStarID = await _appUserDCache.GetPreStarIDAsync() < 1 ? star.StarID : await _appUserDCache.GetPreStarIDAsync();
            userDCache.GoalProgress = extEo.Goal;
            userDCache.LuckyValue = extEo.LuckyValue;
            userDCache.IsWin = await _appUserDCache.GetIsWinAsync();// _appUserDCache.IsWin;

            userDCache.UserId = await _appUserDCache.GetUserIdAsync();
            userDCache.PlatformToken = await _appUserDCache.GetPlatformTokenAsync();
            userDCache.AppId = await _appUserDCache.GetAppIdAsync();
            userDCache.OperatorId = await _appUserDCache.GetOperatorIdAsync();
            userDCache.ProviderId = await _appUserDCache.GetProviderIdAsync();
            userDCache.CurrencyId = await _appUserDCache.GetCurrencyIdAsync();
            userDCache.SumBetNum = extEo.Goal == 0 ? 0 : await _appUserDCache.GetSumBetNumAsync();
            userDCache.IsWinJackpot = await _appUserDCache.GetIsWinJackpotAsync();
            userDCache.JackpotRaffleAmount = await _appUserDCache.GetJackpotRaffleAmountAsync();
            userDCache.IsCollect = await _appUserDCache.GetIsCollectAsync();
            userDCache.IsTriggerJackpotRaffle = await _appUserDCache.GetIsTriggerJackpotRaffleAsync();

            //写入登录时的缓存，并初始化所有字段
            await WriteToUserDCache(userDCache);

            var currencyId = await _appUserDCache.GetCurrencyIdAsync();

            dto.Balance = Math.Round(balance.AToM(currencyId), 2, MidpointRounding.ToZero);
            dto.PreResultAmount = Math.Round((await _appUserDCache.GetPreResultAmountAsync()).AToM(currencyId), 2, MidpointRounding.ToZero);
            dto.WinAmount = Math.Round((await _appUserDCache.GetWinAmountAsync()).AToM(currencyId), 2, MidpointRounding.ToZero);
            dto.LuckyValue = userDCache.LuckyValue;
            dto.LuckyValueLimit = _config.LuckyCount;
            dto.IsTriggerLuck = dto.LuckyValue >= dto.LuckyValueLimit ? true : false;
            dto.GoalProgress = extEo.Goal;
            dto.MaxGoal = _config.MaxGoal;
            dto.MaxStake = Math.Round(_config.MaxStake.AToM(currencyId), 2, MidpointRounding.ToZero);
            dto.JackpotAmount = Math.Round(jackpot.Amount.AToM(currencyId), 2, MidpointRounding.ToZero);
            dto.SumBetNum = await _appUserDCache.GetSumBetNumAsync();
            dto.PreBet = Math.Round((await _appUserDCache.GetPreBetAsync()).AToM(currencyId), 2, MidpointRounding.ToZero);
            dto.PreBetMultiple = await _appUserDCache.GetPreBetMultipleAsync();
            dto.BaseBet = Math.Round((await _appUserDCache.GetBaseBetAsync()).AToM(currencyId), 2, MidpointRounding.ToZero);
            dto.IsWin = await _appUserDCache.GetIsWinAsync();
            dto.CountryId = appToken.CountryId;
            dto.PreBaseBet = Math.Round((await _appUserDCache.GetPreBaseBetAsync()).AToM(currencyId), 2, MidpointRounding.ToZero);
            //【dto】基础数据：下注值对应的Jackpot奖金
            dto.BetAmountMapJackpotBonus = jackpotOddsList.GroupBy(d => d.BetAmount).ToDictionary(d => d.Key, d => d.Where(m => d.Key == m.BetAmount).GroupBy(n => n.BonusAmount).Select(n => Math.Round(n.Key, MidpointRounding.ToZero)).OrderBy(d => d).ToList());
            dto.PreStarGrade = await _appUserDCache.GetPreStarIDAsync();
            dto.JackpotValue = Math.Round(extEo.JackpotValue.AToM(currencyId), 2, MidpointRounding.ToZero);
            dto.JackpotCfgValue = Math.Round(_config.JackpotCount.AToM(currencyId), 2, MidpointRounding.ToZero);
            dto.IsCollect = await _appUserDCache.GetIsCollectAsync();
            dto.IsTriggerJackpotRaffle = await _appUserDCache.GetIsTriggerJackpotRaffleAsync();

            return dto;
        }

        /// <summary>
        /// 游戏初始化
        /// </summary>
        /// <returns></returns>
        public async Task<LoadDto> Collect()
        {
            await _userExService.UpdateForCollect(_userId);

            await _appUserDCache.SetIsCollectAsync(false);
            await _appUserDCache.SetBaseBetAsync(0L);
            await _appUserDCache.SetPreBaseBetAsync(0L);
            await _appUserDCache.SetPreBetAsync(0L);
            await _appUserDCache.SetPreBetMultipleAsync(0.0m);
            await _appUserDCache.SetPrePlaceAsync(0);
            await _appUserDCache.SetPreResultAmountAsync(0L);
            await _appUserDCache.SetWinAmountAsync(0L);
            //_appUserDCache.IsWin = false;
            await _appUserDCache.SetIsWinAsync(false);
            await _appUserDCache.SetSumBetNumAsync(0);
            await _appUserDCache.SetIsWinJackpotAsync(false);
            await _appUserDCache.SetJackpotRaffleAmountAsync(0.0m);
            await _appUserDCache.SetIsTriggerJackpotRaffleAsync(false);

            LoadDto dto = await Load();

            return dto;
        }

        /// <summary>
        /// 写入用户缓存
        /// </summary>
        /// <param name="userDCache"></param>
        /// <returns></returns>
        public async Task WriteToUserDCache(UserDCache userDCache)
        {
            await _appUserDCache.SetValues(userDCache);
        }
    }
}
