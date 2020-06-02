using System;
using System.Text;

namespace crypto_dotnet.RecommendedRandomGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            //for(int i = 0; i < 20; i++)
            //{
            //    string randomNumber =
            //        Convert.ToBase64String(Random.GenerateRandomNumber(20));
            //    Console.WriteLine(randomNumber);
            //}

            string originalMessage1 = " Message to hash";
            string originalMessage2 = " Message to hash";

            var md5HashedMessage1 = HashData.ComputeHashMd5(Encoding.UTF8.GetBytes(originalMessage1));
            var md5HashedMessage2 = HashData.ComputeHashMd5(Encoding.UTF8.GetBytes(originalMessage2));

            Console.WriteLine("Message 1 hash "+Convert.ToBase64String(md5HashedMessage1));
            Console.WriteLine("Message 2 hash "+Convert.ToBase64String(md5HashedMessage2));

        }
    }
}
