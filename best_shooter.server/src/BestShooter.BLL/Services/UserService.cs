using Xxyy.DAL;

namespace BestShooter.BLL.Services
{
    public class UserService
    {
        private S_userMO _userMo = new S_userMO();


        public async Task<S_userEO> GetByUserId(string userId)
        {
            return await _userMo.GetByPKAsync(userId);
        }

    }
}
