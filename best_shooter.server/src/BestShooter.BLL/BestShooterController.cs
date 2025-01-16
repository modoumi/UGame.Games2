using BestShooter.BLL.BetSvc;
using BestShooter.BLL.Caching;
using BestShooter.BLL.LoadSvc;
using BestShooter.BLL.Services.Lucky;
using Microsoft.AspNetCore.Mvc;
using TinyFx;
using TinyFx.AspNet;
using TinyFx.Caching;
using TinyFx.Extensions.StackExchangeRedis;
using Xxyy.GameEAPI.Common;
using Xxyy.GameEAPI.Core;

namespace BestShooter.BLL
{
    public class BestShooterController : TinyFxControllerBase
    {
        //下注服务
        private BetService _betService;
        //用户缓存
        private AppUserDCache _appUserDCache;
        //游戏初始化服务
        private LoadService _initLoadService;
        //lucky服务
        private LuckyService _luckyService;
        //自定义sql
        private SqlSink _sqlSink = new();

        /// <summary>
        /// 下注
        /// </summary>
        /// <param name="ipo"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<BetDto> Bet(BetIpo ipo)
        {
            var lockKey = $"best_shooter:{UserId}";
            using (var redlock = await RedisUtil.LockAsync(lockKey, CommonCodes.LockTime))
            {
                if (!redlock.IsLocked)
                {
                    redlock.Release();
                    throw new CustomException(CommonCodes.UserConcurrent, $"Request for lock failed.userId:{ipo.UserId}");
                }

                _appUserDCache = new AppUserDCache(UserId);
                _betService = new BetService(UserId);
                ipo.TotalBet = ipo.TotalBet.MToA(await _appUserDCache.GetCurrencyIdAsync());
                ipo.Bet = ipo.Bet.MToA(await _appUserDCache.GetCurrencyIdAsync());
                ipo.UserId = UserId;

                await _appUserDCache.SetBaseBetAsync(await _appUserDCache.GetBaseBetAsync() == 0 || await _appUserDCache.GetGoalProgressAsync() == 0 ? (long)ipo.Bet : await _appUserDCache.GetBaseBetAsync());

                return await _betService.Bet(ipo);
            }
        }

        /// <summary>
        /// 游戏加载
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public async Task<LoadDto> Load()
        {
            _initLoadService = new LoadService(UserId);

            return await _initLoadService.Load();
        }

        /// <summary>
        /// Collect结算
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public async Task<LoadDto> Collect()
        {
            _initLoadService = new LoadService(UserId);

            return await _initLoadService.Collect();
        }

        /// <summary>
        /// Lucky抽奖
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public async Task<LuckyRaffleDto> LuckyRaffle(LuckyIpo ipo)
        {
            ipo = new LuckyIpo();
            ipo.UserId = UserId;

            _luckyService = new LuckyService(UserId);

            _appUserDCache = new AppUserDCache(UserId);
            ipo.OperatorID = await _appUserDCache.GetCurrencyIdAsync();
            return await _luckyService.CalculationLuckyRaffle(ipo);
        }

        /// <summary>
        /// 获取Jackpot抽奖记录
        /// </summary>
        /// <param name="ipo"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<List<JackpotListDto>> JPList(JackpotListIpo ipo)
        {
            ipo.userId = UserId;
            _appUserDCache = new AppUserDCache(UserId);
            ipo.OperatorID = await _appUserDCache.GetCurrencyIdAsync();
            return await _sqlSink.GetJPHistoryList(ipo, await _appUserDCache.GetCurrencyIdAsync());
        }
    }
}
