using Newtonsoft.Json;
using Queuing_System_Alipour.Models;
using Queuing_System_Alipour.Tool.Handler;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Threading.Tasks;

namespace Queuing_System_Alipour.Tool
{
    public static class Database
    {
        public static string AtelierJsonPath => Path.Combine(Setting.NetworkPath, Setting.RootDirName, Setting.DbDirName, Setting.AtelierJson);
        public static string PersonnelJsonPath => Path.Combine(Setting.NetworkPath, Setting.RootDirName, Setting.DbDirName, Setting.PersonnelJson);
        public static string PersonnelTempJsonPath => Path.Combine(Setting.NetworkPath, Setting.RootDirName, Setting.DbDirName, Setting.PersonnelTempJson);
        public static string UsersJsonPath => Path.Combine(Setting.NetworkPath, Setting.RootDirName, Setting.UsersDirName, Setting.UsersJson);

        public static Dictionary<string, List<AtelierModel>> AtelierModels;
        public static Dictionary<string, List<PersonnelModel>> PersonnelModels;
        public static List<PersonnelTempModel> PersonnelTempModels;
        public static List<UsersModel> UsersModels;

        public delegate void RefreshModelHandler<T>();
        public static event RefreshModelHandler<AtelierModel> OnRefreshAtelierModel;
        public static event RefreshModelHandler<PersonnelModel> OnRefreshPersonnelModel;
        public static event RefreshModelHandler<PersonnelModel> OnRefreshPersonnelTempModel;
        public static event RefreshModelHandler<UsersModel> OnRefreshUsersModel;

        public delegate void DatabaseErrorHandler(ErrorCode code);
        public static event DatabaseErrorHandler OnError;

        public delegate void SuccessfulPing();
        public static event SuccessfulPing OnSuccessfulPing;

        public delegate void FailurePing();
        public static event FailurePing OnFailurePing;

        static bool checkedPersonelTemp = false;


        /// <returns>If it is empty, it means that the type T is not correct.</returns>
        public static bool? Save<T>() where T : class
        {
            try
            {
                if (typeof(T).IsAssignableFrom(typeof(AtelierModel)))
                    File.WriteAllText(AtelierJsonPath, JsonConvert.SerializeObject(AtelierModels, Formatting.Indented));

                else if (typeof(T).IsAssignableFrom(typeof(PersonnelModel)))
                    File.WriteAllText(PersonnelJsonPath, JsonConvert.SerializeObject(PersonnelModels, Formatting.Indented));

                else if (typeof(T).IsAssignableFrom(typeof(PersonnelTempModel)))
                    File.WriteAllText(PersonnelTempJsonPath, JsonConvert.SerializeObject(PersonnelTempModels, Formatting.Indented));

                else if (typeof(T).IsAssignableFrom(typeof(UsersModel)))
                    File.WriteAllText(UsersJsonPath, JsonConvert.SerializeObject(UsersModels, Formatting.Indented));

                else
                    return null;

                return true;
            }
            catch (Exception ex)
            {
                var errorCode = ErrorHandler.GetErrorCode(ex);
                OnError?.Invoke(errorCode);

                return false;
            }
        }

        /// <returns>If it is empty, it means that the type T is not correct.</returns>
        public static bool? Refresh<T>() where T : class
        {
            try
            {
                if (typeof(AtelierModel).IsAssignableFrom(typeof(T)))
                {
                    AtelierModels = JsonConvert.DeserializeObject<Dictionary<string, List<AtelierModel>>>(File.ReadAllText(AtelierJsonPath));
                    OnRefreshAtelierModel?.Invoke();
                }
                else if (typeof(PersonnelModel).IsAssignableFrom(typeof(T)))
                {
                    PersonnelModels = JsonConvert.DeserializeObject<Dictionary<string, List<PersonnelModel>>>(File.ReadAllText(PersonnelJsonPath));
                    OnRefreshPersonnelModel?.Invoke();
                }
                else if (typeof(PersonnelTempModel).IsAssignableFrom(typeof(T)))
                {
                    PersonnelTempModels = JsonConvert.DeserializeObject<List<PersonnelTempModel>>(File.ReadAllText(PersonnelTempJsonPath));
                    // اطلاعات دیروز باید پاک شوند
                    if (!checkedPersonelTemp)
                    {
                        string modifyDate = File.GetLastWriteTime(Database.PersonnelTempJsonPath).ToString("yyyy/MM/dd", CultureInfo.InvariantCulture);
                        string todayDate = DateTime.Today.ToString("yyyy/MM/dd", CultureInfo.InvariantCulture);

                        if (modifyDate != todayDate)
                        {
                            PersonnelTempModels.Clear();
                            Save<PersonnelTempModel>();
                        }
                        checkedPersonelTemp = true;
                    }
                    OnRefreshPersonnelTempModel?.Invoke();
                }
                else if (typeof(UsersModel).IsAssignableFrom(typeof(T)))
                {
                    UsersModels = JsonConvert.DeserializeObject<List<UsersModel>>(File.ReadAllText(UsersJsonPath));
                    OnRefreshUsersModel?.Invoke();
                }
                else
                    return null;

                return true;
            }
            catch (Exception ex)
            {
                var errorCode = ErrorHandler.GetErrorCode(ex);
                OnError?.Invoke(errorCode);
                return false;
            }
        }

        static FileSystemWatcher DbWatcher = null;
        static FileSystemWatcher UsersWatcher = null;

        static bool onceAtelierDbChange = false;
        static bool oncePersonnelDbChange = false;
        static bool oncePersonnelTempDbChange = false;
        static bool onceUsersChange = false;

        public static void InitialWatchers()
        {
            if (DbWatcher == null)
            {
                DbWatcher = new FileSystemWatcher
                {
                    Path = Path.Combine(Setting.NetworkPath, Setting.RootDirName, Setting.DbDirName),
                    Filter = "*.*",
                    NotifyFilter = NotifyFilters.LastWrite | NotifyFilters.FileName
                };
                DbWatcher.Changed += (s, e) =>
                {
                    if (e.Name.ToLower() == Setting.AtelierJson)
                    {
                        if (onceAtelierDbChange)
                            onceAtelierDbChange = false;
                        else
                        {
                            onceAtelierDbChange = true;
                            return;
                        }
                        Refresh<AtelierModel>();
                    }
                    else if (e.Name.ToLower() == Setting.PersonnelJson)
                    {
                        if (oncePersonnelDbChange)
                            oncePersonnelDbChange = false;
                        else
                        {
                            oncePersonnelDbChange = true;
                            return;
                        }
                        Refresh<PersonnelModel>();
                    }
                    else if (e.Name.ToLower() == Setting.PersonnelTempJson)
                    {
                        if (oncePersonnelTempDbChange)
                            oncePersonnelTempDbChange = false;
                        else
                        {
                            oncePersonnelTempDbChange = true;
                            return;
                        }
                        Refresh<PersonnelTempModel>();
                    }
                };
                DbWatcher.Error += (s, e) =>
                {
                    var errorCode = ErrorHandler.GetErrorCode(e.GetException());
                    OnError?.Invoke(errorCode);
                };
                DbWatcher.EnableRaisingEvents = true;
            }

            if (UsersWatcher == null)
            {
                UsersWatcher = new FileSystemWatcher()
                {
                    Path = Path.Combine(Setting.NetworkPath, Setting.RootDirName, Setting.UsersDirName),
                    Filter = "*.*",
                    NotifyFilter = NotifyFilters.LastWrite | NotifyFilters.FileName
                };
                UsersWatcher.Changed += (s, e) =>
                {
                    if (e.Name.ToLower() == Setting.UsersJson)
                    {
                        if (onceUsersChange)
                            onceUsersChange = false;
                        else
                        {
                            onceUsersChange = true;
                            return;
                        }
                        Refresh<UsersModel>();
                    }
                };
                UsersWatcher.Error += (s, e) =>
                {
                    var errorCode = ErrorHandler.GetErrorCode(e.GetException());
                    OnError?.Invoke(errorCode);
                };
                UsersWatcher.EnableRaisingEvents = true;
            }
        }

        static bool failPing = false;
        public static async void CheckConnection()
        {
            var serverIP = IPAddress.Parse(Setting.NetworkIP);
            Ping ping = new Ping();

            while (true)
            {
                try
                {
                    var reply = await ping.SendPingAsync(serverIP, 5000, new byte[8]);

                    if (reply.Status != IPStatus.Success)
                    {
                        int pingTry = 3;
                        do
                        {
                            var replyTry = await ping.SendPingAsync(serverIP, 5000, new byte[8]);
                            if (replyTry.Status == IPStatus.Success)
                            {
                                failPing = false;
                                OnSuccessfulPing?.Invoke();
                                InitialWatchers();
                                break;
                            }
                            pingTry--;
                        } while (pingTry != 0);
                        if (pingTry == 0)
                        {
                            ping = new Ping();
                            failPing = true;
                            OnFailurePing?.Invoke();
                            DisposeWatchers();
                        }
                    }
                    else
                    {
                        if (failPing)
                        {
                            failPing = false;
                            OnSuccessfulPing?.Invoke();
                            InitialWatchers();
                        }
                    }
                    await Task.Delay(7500);
                }
                catch
                {
                    ping = new Ping();
                    failPing = true;
                    OnFailurePing.Invoke();
                    DisposeWatchers();
                }
            }

            void DisposeWatchers()
            {
                if (DbWatcher != null && UsersWatcher != null)
                {
                    DbWatcher.Dispose();
                    DbWatcher = null;

                    UsersWatcher.Dispose();
                    UsersWatcher = null;
                }
            }
        }

        public static async Task<Tuple<bool?, ErrorCode>> InitialConnectionCheck()
        {
            var serverIP = IPAddress.Parse(Setting.NetworkIP);
            Ping ping = new Ping();
            PingReply reply;
            try
            {
                reply = await ping.SendPingAsync(serverIP, 3500, new byte[8]);

                if (reply.Status != IPStatus.Success)
                {
                    int pingTry = 3;
                    do
                    {
                        reply = await ping.SendPingAsync(serverIP, 3500, new byte[8]);
                        if (reply.Status == IPStatus.Success)
                            return new Tuple<bool?, ErrorCode>(true, ErrorCode.Unknown);

                        pingTry--;
                    } while (pingTry != 0);

                    return new Tuple<bool?, ErrorCode>(false, ErrorCode.FailurePing);
                }
                else
                    return new Tuple<bool?, ErrorCode>(true, ErrorCode.Unknown);
            }
            catch (Exception ex)
            {
                return new Tuple<bool?, ErrorCode>(null, ErrorHandler.GetErrorCode(ex));
            }
        }
    }
}
