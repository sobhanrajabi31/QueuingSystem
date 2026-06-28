namespace QueuingSystem.Shared.Handler
{
    public enum ErrorCode
    {
        DbConnectionFailed = 0,
        UsernameNotFound = 1,
        InvalidCurrentPassword = 2,
        QueueNotFound = 3,
        FailedToDeleteQueue = 4,
        FailedToUpdateQueue = 5,
        CannotSetQueueStatusAnymore = 6,
        FailedToCreateQueue = 7,
        FailedToCreateAccount = 8,
        SelectedTimeIsUnavailable = 9,
        InvalidUsernameOrPassword = 10,
        InvalidRepeatPassword = 11,
        UsernameExists = 12,
        FreeTimeNotFound = 13,
        InvalidPhoneNumber = 14,
        InvalidDateInput = 15,
        ConnectionFailed = 16,
        ReconnectingToServer = 17,
        ConnectionClosed = 18,
        ConnectionFailedDuringFirstConnection = 19,
        ConnectionFailedDuringAtelierActivity = 20,
        ConnectionFailedDuringPersonnelActivity = 21,
        ConnectionFailedDuringEmployeeActivity = 22
    }

    public static class ErrorHandler
    {
        private static Dictionary<ErrorCode, string>? ErrorMessage;

        private static void Initialize()
        {
            ErrorMessage = new Dictionary<ErrorCode, string>
            {
                { ErrorCode.InvalidDateInput, "شما مجاز به انتخاب تاریخ گذشته نیستید" },
                { ErrorCode.InvalidUsernameOrPassword, "نام کاربری یا رمز عبور اشتباه است" },
                { ErrorCode.InvalidCurrentPassword, "پسورد وارد شده با پسورد فعلی مطابقت ندارد" },
                { ErrorCode.UsernameExists, "نام کاربری وارد شده قبلا ثبت شده است" },
                { ErrorCode.FreeTimeNotFound, "زمان آزاد برای این روز وجود ندارد" },
                { ErrorCode.InvalidPhoneNumber, "شماره تلفن وارد شده معتبر نیست" },

                { ErrorCode.DbConnectionFailed, "ارتباط با دیتابیس برقرار نشد" },
                { ErrorCode.UsernameNotFound, "نام کاربری مورد نظر یافت نشد" },
                { ErrorCode.InvalidRepeatPassword, "پسورد وارد شده با تکرار آن مطابقت ندارد" },
                { ErrorCode.QueueNotFound, "نوبت مورد نظر یافت نشد" },
                { ErrorCode.FailedToDeleteQueue, "خطایی هنگام حذف نوبت مورد نظر رخ داد" },
                { ErrorCode.FailedToUpdateQueue, "خطایی هنگام بروزرسانی وضعیت نوبت مورد نظر رخ داد" },
                { ErrorCode.CannotSetQueueStatusAnymore, "برای این نوبت قبلا تغییر وضعیت صورت گرفته و دیگر امکان پذیر نیست" },
                { ErrorCode.FailedToCreateQueue, "خطایی هنگام ایجاد نوبت رخ داد" },
                { ErrorCode.FailedToCreateAccount, "خطایی هنگام ساخت حساب کاربری رخ داد" },
                { ErrorCode.SelectedTimeIsUnavailable, "مدت زمان انتخاب شده برای این نوبت موجود نیست" },
                { ErrorCode.ConnectionFailed, "خطایی هنگام ارتباط با سرور رخ داد" },
                { ErrorCode.ReconnectingToServer, "درحال تلاش برای ارتباط مجدد با سرور" },
                { ErrorCode.ConnectionClosed, "ارتباط با سرور قطع شد، برنامه را مجدد باز کنید" },
                { ErrorCode.ConnectionFailedDuringFirstConnection, "خطایی هنگام برقراری اولین ارتباط با سرور رخ داد" },
                { ErrorCode.ConnectionFailedDuringAtelierActivity, "خطایی هنگام فعالیت در قسمت نوبت آتلیه در ارتباط با سرور رخ داد" },
                { ErrorCode.ConnectionFailedDuringPersonnelActivity, "خطایی هنگام فعالیت در قسمت نوبت پرسنلی در ارتباط با سرور رخ داد" },
                { ErrorCode.ConnectionFailedDuringEmployeeActivity, "خطایی هنگام فعالیت در قسمت کارمند در ارتباط با سرور رخ داد" }
            };
        }

        public static string GetMessage(ErrorCode errorCode)
        {
            if (ErrorMessage == null)
                Initialize();

            return ErrorMessage.TryGetValue(errorCode, out var message)
                ? message
                : "هنگام تبدیل کد خطا به پیام خطایی رخ داد";
        }
    }
}
