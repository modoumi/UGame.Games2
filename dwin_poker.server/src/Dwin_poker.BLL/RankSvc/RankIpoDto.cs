namespace Dwin_poker.BLL
{
    public class RankIpo
    {
        public string UserId { get; set; }
        public string CurrencyId { get; set; }
    }
    public class RankDto
    {
        public List<RankInfo> RankInfoArr { get; set; } = new();
    }

    public class RankInfo
    {
        public long EndTime { get; set; }
        public List<RankDetail> RankDetailList { get; set; } = new();
    }
    public class RankDetail
    {
        public int Rank { get; set; }
        public string Mobile { get; set; }
        public decimal Win { get; set; }

    }
}