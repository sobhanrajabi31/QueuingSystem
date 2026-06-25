//using Newtonsoft.Json;
//using Queuing_System_Alipour.Models;
//using System;
//using System.Globalization;
//using System.IO;

//namespace Queuing_System_Alipour.Tool
//{
//    //public enum TimeFrame
//    //{
//    //    ComboBoxText = 0, BeforeQueueDay, QueueDay, ExpireQueue
//    //}

//    //public enum QueueStatus
//    //{
//    //    ComboBoxText = 0, Done, Canceled, Undone
//    //}

//    public class Setting
//    {


//        public static string ConvertToFa_Date(DateTime dateTime)
//        {
//            var calendar = new PersianCalendar();

//            string shamsiDate = string.Format("{0:0000}/{1:00}/{2:00}",
//                calendar.GetYear(dateTime),
//                calendar.GetMonth(dateTime),
//                calendar.GetDayOfMonth(dateTime));

//            return shamsiDate;
//        }

//        public static DateTime ConvertToEn_Date(string dateTime)
//        {
//            var cal = dateTime.Split('/');

//            int year = int.Parse(cal[0]);
//            int month = int.Parse(cal[1]);
//            int day = int.Parse(cal[2]);

//            return new DateTime(year, month, day, new PersianCalendar());
//        }
//    }
//}
