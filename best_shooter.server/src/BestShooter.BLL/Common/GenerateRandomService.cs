using TinyFx.Randoms;

namespace BestShooter.BLL.Common
{
    public class GenerateRandomService
    {
        /// <summary>
        /// [min, max) 返回大于等于min且小于max的随机数
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public int NextInt(int min, int max)
        {
            RandomUtil.DefaultProvider = RandomProviderFactory.CreateDefaultProvider();
            return RandomUtil.NextInt(min, max);
        }

    }
}
