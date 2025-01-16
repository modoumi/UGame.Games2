using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Text.Json.Serialization;
using TinyFx.Data;

namespace BestShooter.BLL
{
    public class JackpotListIpo
    {
        /// <summary>
        /// 当前页码
        /// </summary>
        [Range(1, int.MaxValue)]
        public int pageIndex { get; set; }

        /// <summary>
        /// 页条数
        /// </summary>
        [Range(1, 20)]
        public int pageSize { get; set; }

        /// <summary>
        /// 用户id，程序内部流转使用
        /// </summary>
        [JsonIgnore]
        public string userId { get; set; }

        [JsonIgnore]
        public string OperatorID { get; set; }
    }

    public class JackpotListDto : IRowMapper<JackpotListDto>
    {
        /// <summary>
        /// 用户编码
        /// </summary>
        [JsonIgnore]
        public string UserId { get; set; }
        public string Mobile { get; set; } = string.Empty;

        public string UserName { get; set; } = string.Empty;

        public string Amount { get; set; }

        public string Date { get; set; }

        public long WinAmount { get; set; }

        public JackpotListDto MapRow(IDataReader reader)
        {
            JackpotListDto ret = new JackpotListDto();
            ret.UserId = reader.ToString("UserID");
            ret.WinAmount = reader.ToInt64("WinAmount");
            ret.Amount = string.Empty;
            ret.Date = reader.ToDateTime("RecDate").ToString("MM/dd/yyyy");
            return ret;
        }
    }
}
