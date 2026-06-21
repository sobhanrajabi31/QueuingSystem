using System;
using System.Security.Cryptography;
using System.Text;

namespace Queuing_System_Alipour.Tool.PasswordHasher
{
    public class PasswordHasher
    {
        public static string Hash(string password)
        {
            var sha256 = SHA256.Create();
            var hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
            sha256.Dispose();
            return BitConverter.ToString(hashBytes).Replace("-", "");
        }
    }
}
