using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AyuboDrive
{
    /// <summary>
    /// This class is reponsible for generating the key that is used when creating an account
    /// </summary>
    static class Viper
    {
        public static string GenerateKey()
        {
            Random random = new Random();
            int length = random.Next(10, 20);
            StringBuilder stringBuilder = new StringBuilder("", length);

            for (int i = 0; i <length; i ++)
            {
                stringBuilder.Insert(i, random.Next(10).ToString());
            }
            return stringBuilder.ToString();
        }
    }
}
