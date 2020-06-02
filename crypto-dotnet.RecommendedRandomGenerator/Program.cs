using System;

namespace crypto_dotnet.RecommendedRandomGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 20; i++)
            {
                string randomNumber =
                    Convert.ToBase64String(Random.GenerateRandomNumber(20));
                Console.WriteLine(randomNumber);
            }
        }
    }
}
