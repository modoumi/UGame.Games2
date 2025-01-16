

namespace BestShooter.BLL.Services.Lucky
{
    public class LuckyNumDto
    {
        /// <summary>
        /// 是否获取lucky累计次数值
        /// </summary>
        public bool IsWin { get; set; } = false;

        /// <summary>
        /// 获得lucky次数
        /// </summary>
        public int LuckyNum { get; set; } = 0;
    }
}
