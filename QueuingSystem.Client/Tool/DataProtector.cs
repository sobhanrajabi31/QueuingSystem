using Newtonsoft.Json;
using QueuingSystem.Shared.DTOs.Employee;
using System.Security.Cryptography;
using System.Text;

namespace QueuingSystem.Client.Tool
{
    public static class DataProtector
    {
        public static void Encrypt(LoginDto employee)
        {
            string json = JsonConvert.SerializeObject(employee);

            byte[] data = Encoding.UTF8.GetBytes(json);
            byte[] encrypted = ProtectedData.Protect(data, null, DataProtectionScope.CurrentUser);

            File.WriteAllBytes(AppState.TokenFileName, encrypted);
        }

        public static LoginDto Decrypt()
        {
            if (File.Exists(AppState.TokenFileName) && File.ReadAllBytes(AppState.TokenFileName).Length != 0)
            {
                byte[] encrypted = File.ReadAllBytes(AppState.TokenFileName);
                byte[] decrypted = ProtectedData.Unprotect(encrypted, null, DataProtectionScope.CurrentUser);

                string json = Encoding.UTF8.GetString(decrypted);
                return JsonConvert.DeserializeObject<LoginDto>(json);
            }

            else
                return null;
        }
    }
}
