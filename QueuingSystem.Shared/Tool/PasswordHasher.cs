using System.Security.Cryptography;
using System.Text;

namespace QueuingSystem.Shared.Tool
{
    public class PasswordHasher
    {
        public static string Hash(string password)
        {
            var hashBytes = SHA256.HashData(Encoding.UTF8.GetBytes(password));

            return string.Concat(
                hashBytes.Select(x => x.ToString("x2")));
        }
    }
}
