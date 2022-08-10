using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AyuboDrive
{
    class KeyGenerator
    {
        private static readonly Random random = new Random();

        public static string GenerateKey()
        {
            // Generate a random number that is greater than 60 and less than 100
            int length = random.Next(10, 20);
            string result = "";

            for(int i = 0; i <length; i ++)
            {
                // Repeatedly concateate a random number to the result
                result += random.Next(100).ToString();
            }
            return result;
        }
    }
}
