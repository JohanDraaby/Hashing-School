using System.Security.Cryptography;

namespace Hashing
{
    class HashData
    {
        public static byte[] ComputeHashSha512(byte[] toBeHashed)
        {
            using (var sha512 = SHA512.Create())
            {
                return sha512.ComputeHash(toBeHashed);
            }
        }
    }
}
