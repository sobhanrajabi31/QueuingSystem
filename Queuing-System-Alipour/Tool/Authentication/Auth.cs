using Queuing_System_Alipour.Tool;
using Queuing_System_Alipour.Tool.Models;

namespace Queuing_System_Alipour.Tool.Authentication
{
    public static class Auth
    {
        public static bool IsAuthenticated { get; set; }

        public static bool? Login(string username, string password)
        {
            try
            {
                foreach (var model in Database.UsersModels)
                {
                    if (model.Username == username && model.Password == password)
                    {
                        IsAuthenticated = true;
                        return true;
                    }
                }

                return false;
            }
            catch
            {
                return null;
            }
        }

        public static bool? Register(string username, string password)
        {
            try
            {
                foreach (var model in Database.UsersModels)
                {
                    if (model.Username == username)
                        return false;
                }

                var UserModel = new UsersModel();
                UserModel.Username = username;
                UserModel.Password = PasswordHasher.Hash(password);

                Database.UsersModels.Add(UserModel);
                Database.Save<UsersModel>();

                return true;
            }
            catch
            {
                return null;
            }
        }
    }
}
