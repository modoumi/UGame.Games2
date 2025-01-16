namespace Dwin_poker.BLL
{
    public enum PokerUserStatus
    {
        Normal = 1,
        Locking = 2,
        Exception = 3
    }

    public enum CardType
    {
        Black = 1,
        Red = 2,
    }

    /// <summary>
    /// 游戏状态，初始为0，roundIdx>0时，需要判断4种状态，
    /// 1-star达到最大，2-betResult达到maxBet，
    /// 3-balance小于baseBet，4-balance小于betJpBonus中最小的下注值
    /// </summary>
    public enum GameStatus
    {
        Normal,
        MaxStar,
        MaxBet,
        NoBalance,
        LessBaseBetAmount,
    }
}
