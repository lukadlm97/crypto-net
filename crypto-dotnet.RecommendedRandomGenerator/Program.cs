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

            //string originalMessage1 = " Message to hash";
            //string originalMessage2 = " Message to hash";

            //var md5HashedMessage1 = HashData.ComputeHashMd5(Encoding.UTF8.GetBytes(originalMessage1));
            //var md5HashedMessage2 = HashData.ComputeHashMd5(Encoding.UTF8.GetBytes(originalMessage2));

            //Console.WriteLine("Message 1 hash "+Convert.ToBase64String(md5HashedMessage1));
            //Console.WriteLine("Message 2 hash "+Convert.ToBase64String(md5HashedMessage2));

            const string originalMessage = "Message to hash";
            const string originalMessage2 = "M3ssage to hash";

            var sha1HashedMessage = HashData.ComputeHashSha1(Encoding.UTF8.GetBytes(originalMessage));
            var sha1HashedMessage2 = HashData.ComputeHashSha1(Encoding.UTF8.GetBytes(originalMessage2));

            var sha256HashedMessage = HashData.ComputeHashSha256(Encoding.UTF8.GetBytes(originalMessage));
            var sha256HashedMessage2 = HashData.ComputeHashSha256(Encoding.UTF8.GetBytes(originalMessage2));


            var sha512HashedMessage = HashData.ComputeHashSha512(Encoding.UTF8.GetBytes(originalMessage));
            var sha512HashedMessage2 = HashData.ComputeHashSha512(Encoding.UTF8.GetBytes(originalMessage2));

            Console.WriteLine();
            Console.WriteLine("SHA 1 Hashes");
            Console.WriteLine("Message 1 hash = "+Convert.ToBase64String(sha1HashedMessage));
            Console.WriteLine("Message 2 hash = "+Convert.ToBase64String(sha1HashedMessage2));

            Console.WriteLine("SHA 256 Hashes");
            Console.WriteLine("Message 1 hash = " + Convert.ToBase64String(sha256HashedMessage));
            Console.WriteLine("Message 2 hash = " + Convert.ToBase64String(sha256HashedMessage2));

            Console.WriteLine("SHA 512 Hashes");
            Console.WriteLine("Message 1 hash = " + Convert.ToBase64String(sha512HashedMessage));
            Console.WriteLine("Message 2 hash = " + Convert.ToBase64String(sha512HashedMessage2));

        }
    }
}
