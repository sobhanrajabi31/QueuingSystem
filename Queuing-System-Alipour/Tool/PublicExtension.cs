using System.Globalization;

public static class PublicExtension
{
    public static bool IsNull(this string str) => string.IsNullOrWhiteSpace(str);

    public static string ConvertToFa_Date(this DateTime dateTime)
    {
        var calendar = new PersianCalendar();

        string shamsiDate = string.Format("{0:0000}/{1:00}/{2:00}",
            calendar.GetYear(dateTime),
            calendar.GetMonth(dateTime),
            calendar.GetDayOfMonth(dateTime));

        return shamsiDate;
    }

    public static DateTime ConvertToEn_Date(this string dateTime)
    {
        var cal = dateTime.Split('/');

        int year = int.Parse(cal[0]);
        int month = int.Parse(cal[1]);
        int day = int.Parse(cal[2]);

        return new DateTime(year, month, day, new PersianCalendar());
    }
}

