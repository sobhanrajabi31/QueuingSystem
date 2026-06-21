using Newtonsoft.Json;
using Queuing_System_Alipour.Tool.Models;
using System;
using System.Globalization;
using System.IO;

namespace Queuing_System_Alipour.Tool
{
    public enum TimeFrame
    {
        ComboBoxText = 0, BeforeQueueDay, QueueDay, ExpireQueue
    }

    public enum QueueStatus
    {
        ComboBoxText = 0, Done, Canceled, Undone
    }

    public class Setting
    {
        public static TimeFrame? Default_TimeFrame => 0;
        public static QueueStatus? Default_QueueStatus => 0;
        public static int DEFAULT_PersonnelWaitTime => 3;
        public static bool DEFAULT_RememberMe => false;
        public static bool DEFAULT_PhotographMode => false;
        public static string DEFAULT_NetworkIP => "127.0.0.1";

        public static TimeFrame? TimeFrame { get; set; }
        public static QueueStatus? QueueStatus { get; set; }
        public static string NetworkPath { get; set; }
        public static int? PersonnelWaitTime { get; set; }
        public static bool? RememberMe { get; set; }
        public static bool PhotographMode { get; set; }
        public static string Username { get; set; }
        public static string Password { get; set; }
        public static string NetworkIP { get; set; }

        public static string RootDirName => "QueuingSystem";
        public static string UsersDirName => "Users";
        public static string ArchiveDirName => "Archive";
        public static string DbDirName => "Database";

        public static string SettingJson => "setting.json";
        public static string UsersJson => "users.json";
        public static string PersonnelJson => "personnel.json";
        public static string PersonnelTempJson => "personneltemp.json";
        public static string AtelierJson => "atelier.json";

        public static void Save(SettingModel model)
        {
            if (model.QueueStatus == null)
                model.QueueStatus = (Models.QueueStatus?)Setting.Default_QueueStatus;
            else
                Setting.QueueStatus = (QueueStatus?)model.QueueStatus;

            if (model.TimeFrame == null)
                model.TimeFrame = (Models.TimeFrame?)Setting.Default_TimeFrame;
            else
                Setting.TimeFrame = (TimeFrame?)model.TimeFrame;

            if (string.IsNullOrEmpty(model.NetworkPath))
                model.NetworkPath = Setting.NetworkPath;
            else
                Setting.NetworkPath = model.NetworkPath;

            if (model.PersonnelWaitTime == null)
                model.PersonnelWaitTime = Setting.DEFAULT_PersonnelWaitTime;
            else
                Setting.PersonnelWaitTime = model.PersonnelWaitTime.Value;

            if (model.NetworkIP.IsNull())
                model.NetworkIP = Setting.DEFAULT_NetworkIP;
            else
                Setting.NetworkIP = model.NetworkIP;

            if (model.RememberMe == null)
            {
                if (Setting.RememberMe == null)
                    model.RememberMe = Setting.DEFAULT_RememberMe;
                else
                {
                    model.RememberMe = Setting.RememberMe;
                    model.Username = Setting.Username;
                    model.Password = Setting.Password;
                }
            }
            else
            {
                Setting.RememberMe = model.RememberMe.Value;
                Setting.Username = model.Username;
                Setting.Password = model.Password;
            }

            if (model.PhotographMode == null)
                model.PhotographMode = Setting.DEFAULT_PhotographMode;
            else
                Setting.PhotographMode = model.PhotographMode.Value;

            string JsonString = JsonConvert.SerializeObject(model, Formatting.Indented);
            File.WriteAllText(Setting.SettingJson, JsonString);
        }

        public static bool CheckSetting()
        {
            var new_model = new SettingModel();
            if (File.Exists(Setting.SettingJson))
            {
                string JsonString = File.ReadAllText(Setting.SettingJson);
                var model = JsonConvert.DeserializeObject<SettingModel>(JsonString);

                if (JsonString.StartsWith("{") && JsonString.EndsWith("}")
                    && !string.IsNullOrWhiteSpace(model.NetworkPath)
                    && model.RememberMe != null
                    && model.PersonnelWaitTime != null
                    && model.QueueStatus != null
                    && model.TimeFrame != null
                    && model.PhotographMode != null
                    && !model.NetworkIP.IsNull())
                {
                    if (Directory.Exists(Path.Combine(model.NetworkPath, RootDirName)))
                    {
                        Setting.PhotographMode = model.PhotographMode.Value;
                        Setting.QueueStatus = (QueueStatus)model.QueueStatus;
                        Setting.TimeFrame = (TimeFrame)model.TimeFrame;
                        Setting.NetworkPath = model.NetworkPath;
                        Setting.RememberMe = model.RememberMe.Value;
                        Setting.Username = model.Username;
                        Setting.Password = model.Password;
                        Setting.NetworkIP = model.NetworkIP;

                        if (model.PersonnelWaitTime > 0)
                            Setting.PersonnelWaitTime = model.PersonnelWaitTime.Value;
                        else
                            Setting.PersonnelWaitTime = Setting.DEFAULT_PersonnelWaitTime;

                        return true;
                    }
                    else
                        new_model.NetworkPath = model.NetworkPath;
                }
                else
                    new_model.NetworkPath = string.Empty;
            }
            else
                new_model.NetworkPath = string.Empty;

            new_model.PhotographMode = Setting.DEFAULT_PhotographMode;
            new_model.QueueStatus = (Models.QueueStatus)Setting.Default_QueueStatus;
            new_model.TimeFrame = (Models.TimeFrame)Setting.Default_TimeFrame;
            new_model.PersonnelWaitTime = Setting.DEFAULT_PersonnelWaitTime;
            new_model.RememberMe = Setting.DEFAULT_RememberMe;
            new_model.Username = string.Empty;
            new_model.Password = string.Empty;
            new_model.NetworkIP = Setting.DEFAULT_NetworkIP;

            string JsonData = JsonConvert.SerializeObject(new_model, Formatting.Indented);
            File.WriteAllText(Setting.SettingJson, JsonData);

            return false;
        }

        public static string ConvertToFa_Date(DateTime dateTime)
        {
            PersianCalendar calendar = new PersianCalendar();

            string shamsiDate = string.Format("{0:0000}/{1:00}/{2:00}",
                calendar.GetYear(dateTime),
                calendar.GetMonth(dateTime),
                calendar.GetDayOfMonth(dateTime));

            return shamsiDate;
        }

        public static DateTime ConvertToEn_Date(string dateTime)
        {
            var cal = dateTime.Split('/');

            int year = int.Parse(cal[0]);
            int month = int.Parse(cal[1]);
            int day = int.Parse(cal[2]);

            return new DateTime(year, month, day, new PersianCalendar());
        }
    }
}
