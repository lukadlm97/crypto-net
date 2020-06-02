using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace crypto_dotnet.RecommendedRandomGenerator
{
    class HashData
    {
        public static byte[] ComputeHashMd5(byte[] toBeHashed)
        {
            using (var md5 = MD5.Create())
            {
                return md5.ComputeHash(toBeHashed);
            }
        }
    }
}
