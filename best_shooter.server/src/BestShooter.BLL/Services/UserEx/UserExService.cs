using BestShooter.DAL;
using TinyFx.Data;

namespace BestShooter.BLL.Services.UserEx
{
    public class UserExService
    {
        private Bs_user_extMO _userExMo = new();

        /// <summary>
        /// 新增用户，只在登录时使用
        /// </summary>
        /// <param name="userExEo"></param>
        /// <returns></returns>
        public async Task<bool> AddUser(Bs_user_extEO userExEo)
        {
            return await _userExMo.AddAsync(userExEo) > 0;
        }

        /// <summary>
        /// 获取当前用户UserEx
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<Bs_user_extEO> GetUserExByPK(string userId, TransactionManager tm = null)
        {
            return await _userExMo.GetByPKAsync(userId, tm);
        }

        /// <summary>
        /// 更新user_ex
        /// </summary>
        /// <param name="userEx"></param>
        /// <returns></returns>
        public async Task<bool> UpdateUserEx(Bs_user_extEO userEx, TransactionManager tm)
        {
            return await _userExMo.PutAsync(userEx, tm) > 0;
        }

        /// <summary>
        /// lucky抽奖后，更新gbs_user_ex表相关字段
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<bool> UpdateUserExForLuckyDraw(string userId, long luckyWinAmount, TransactionManager tm)
        {
            string set = $"LuckySumAmount = LuckySumAmount - @luckyWinAmount , LuckyValue = 0 , ThisLuckyAmount = 0 , RecDate = @RecDate";
            string where = "UserID = @UserId and 0 <= LuckySumAmount - @luckyWinAmount1";
            return await _userExMo.PutAsync(set, where, tm, luckyWinAmount, DateTime.UtcNow, userId, luckyWinAmount) > 0;
        }

        /// <summary>
        /// Jackpot抽奖后，更新gbs_user_ex表相关字段
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="tm"></param>
        /// <returns></returns>
        public async Task<bool> UpdateUserExFormJackpotRaffle(string userId, TransactionManager tm)
        {
            string set = $"JackpotValue = 0 , RecDate = @RecDate";
            string where = "UserID = @UserId";
            return await _userExMo.PutAsync(set, where, tm, DateTime.UtcNow, userId) > 0;
        }

        /// <summary>
        /// 下注后更新gbs_user_ex
        /// </summary>
        /// <param name="isWin">是否进球</param>
        /// <param name="maxLuckyValue">Lucky阈值</param>
        /// <param name="maxGoal">goal阈值</param>
        /// <param name="addLuckyValue">LuckyValue增加值</param>
        /// <param name="addLuckAmount">LuckySumAmount、ThisLuckyAmount增加值</param>
        /// <param name="addJackpotValue">JackpotValue增加值</param>
        /// <param name="userId">userId</param>
        /// <param name="IsClearJackpotValue">是否清空Jackpot累计值</param>
        /// <param name="tm">事务</param>
        /// <returns></returns>
        public async Task<bool> UpdateUserExForBetAfter(
            bool isWin,
            int maxLuckyValue,
            int maxGoal,
            int addLuckyValue,
            long addLuckAmount,
            long addJackpotValue,
            string userId,
            bool IsClearJackpotValue,
            TransactionManager tm)
        {
            var set = $@"LuckyValue = 
                            case 
	                            when @maxLuckyValue1 < LuckyValue + @addLuckyValue1 then @maxLuckyValue2
	                            else LuckyValue + @addLuckyValue2
                            end,
                            Goal = 
                            case
	                            when @maxGoal1 < Goal + @IsWin1 then @maxGoal2
                                when @maxGoal3 = Goal + @IsWin2 then 0
	                            else Goal + @IsWin3
                            end,
                            LuckySumAmount = LuckySumAmount + @addLuckAmount1,
                            ThisLuckyAmount = ThisLuckyAmount + @addLuckAmount2,
                            JackpotValue = JackpotValue + @addJackpotValue2,
                            RecDate = @RecDate";

            if (IsClearJackpotValue)
                set += ",JackpotValue = 0";

            return (await _userExMo.PutAsync(
                                            set,
                                            "UserID = @UserID",
                                            tm,
                                            maxLuckyValue,
                                            addLuckyValue,
                                            maxLuckyValue,
                                            addLuckyValue,
                                            maxGoal,
                                            isWin ? 1 : 0,
                                            maxGoal,
                                            maxGoal,
                                            isWin ? 1 : 0,
                                            isWin ? 1 : 0,
                                            addLuckAmount,
                                            addLuckAmount,
                                            addJackpotValue,
                                            DateTime.UtcNow,
                                            userId
                                            )
                ) > 0;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<bool> UpdateForCollect(string userId)
        {
            return (await _userExMo.PutAsync($"Goal = 0", "UserID = @UserID", userId)) > 0;
        }

    }
}
