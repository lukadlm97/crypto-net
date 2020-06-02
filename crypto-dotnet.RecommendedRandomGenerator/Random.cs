using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace crypto_dotnet.RecommendedRandomGenerator
{
    public class Random
    {
        public static byte[] GenerateRandomNumber(int lenght)
        {
            using(var randomGenerator = new RNGCryptoServiceProvider())
            {
                var randomNumber = new byte[lenght];
                randomGenerator.GetBytes(randomNumber);

                return randomNumber;
            }
        }
    }
}
