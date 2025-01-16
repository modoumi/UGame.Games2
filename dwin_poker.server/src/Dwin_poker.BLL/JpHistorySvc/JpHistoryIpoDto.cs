namespace Dwin_poker.BLL
{
    public class JpHistoryIpo
    {
        public string UserId { get; set; }
        public string CurrencyId { get; set; }
        public int PageIdx { get; set; }
        public int PageSize { get; set; }
    }
    public class JpHistoryDto
    {
        public int PageIdx { get; set; }
        public List<JpHistory> JpHistoryList { get; set; } = new();
    }

    public class JpHistory
    {
        public long RecDate { get; set; }
        public string Mobile { get; set; }
        public decimal Win { get; set; }
    }
}