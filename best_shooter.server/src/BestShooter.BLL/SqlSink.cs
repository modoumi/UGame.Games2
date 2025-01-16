using BestShooter.DAL;
using MySql.Data.MySqlClient;
using TinyFx;
using Xxyy.DAL;
using Xxyy.GameEAPI.Common;

namespace BestShooter.BLL
{
    public class SqlSink
    {
        private S_userMO _userMo = new();

        /// <summary>
        /// 分页sql
        /// </summary>
        /// <param name="stringBuilder"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        private string PagerSql(int pageIndex, int pageSize)
        {
            return $" limit {pageSize} offset ({pageIndex} - 1) * {pageSize}";
        }

        #region 获取Jackpot抽奖记录

        private string JackpotHistorySelectSql(JackpotListIpo ipo)
        {
            return $@"select * 
                        from bs_order_raffle where OrderType = 2
                        order by RecDate desc
                        limit @pageSize offset @offset";
        }

        public async Task<List<JackpotListDto>> GetJPHistoryList(JackpotListIpo ipo, string currencyId)
        {
            var selectSql = JackpotHistorySelectSql(ipo);

            List<MySqlParameter> paramList = new()
            {
                new MySqlParameter("@OperatorID",ipo.OperatorID),
                new MySqlParameter("@pageSize",ipo.pageSize),
                new MySqlParameter("@offset",(ipo.pageIndex - 1) * ipo.pageSize)
            };

            var result = await DbSink.GameDb.ExecSqlListAsync<Bs_order_raffleEO>(selectSql, paramList);

            List<JackpotListDto> ret = new List<JackpotListDto>();
            if (result.Any())
            {
                foreach (var item in result)
                {

                    ret.Add(new JackpotListDto()
                    {
                        Mobile = item.UserNickName,
                        Amount = string.Format("{0:N2}", Math.Round(item.WinAmount.AToM(currencyId), 2, MidpointRounding.ToZero)),
                        Date = item.RecDate.ToString("MM/dd/yyyy"),
                    });
                }
            }
            return ret;
        }

        #endregion
        public static async Task<string> GetNickName(S_userEO user)
        {
            string nickName = string.Empty;
            if (user != null)
            {
                if (user.Mobile != null)
                {
                    nickName = user.Mobile;
                }
                else if (user.Nickname != null)
                {
                    nickName = user.Nickname;
                }
                else
                {
                    nickName = user.Username;
                }
                if (!string.IsNullOrEmpty(nickName))
                {
                    if (nickName.Length > 8)
                    {
                        nickName = nickName[..8];
                    }
                    nickName = nickName.HideFixedLength(nickName.Length, 0, 3);
                }
            }
            return nickName;
        }

    }




}
