using Dwin_poker.BLL.LoadSvc;

namespace Dwin_poker.BLL
{
    public class JackpotIpo
    {
        public string UserId { get; set; }
        public string CurrencyId { get; set; }
    }
    public class JackpotDto
    {
        public JPInfo JpInfo { get; set; } = new();
    }
}