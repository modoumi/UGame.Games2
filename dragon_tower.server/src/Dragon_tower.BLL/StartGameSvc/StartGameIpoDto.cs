namespace Dragon_tower.BLL
{
    public class StartGameIpo
    {
        public string UserId { get; set; }
        public string CurrencyId { get; set; }
        public decimal BaseBet { get; set; }
        public int Level { get; set; }
    }
    public class StartGameDto
    {
        public ResultInfo ResultInfo { get; set; } = new();
    }
    public class ResultInfo
    {
        public GameInfo GameInfo { get; set; } = new();
    }

}