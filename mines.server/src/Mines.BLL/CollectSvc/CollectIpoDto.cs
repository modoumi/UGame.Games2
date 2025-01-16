namespace Mines.BLL
{
    public class CollectIpo
    {
        public string UserId { get; set; }
        public string CurrencyId { get; set; }
    }
    public class CollectDto
    {
        public PlayerInfo PlayerInfo { get; set; } = new();
        public GameInfo GameInfo { get; set; } = new();
    }
}