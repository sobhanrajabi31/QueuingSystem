namespace QueuingSystem.Shared.Handler
{
    public enum ErrorCode
    {
        InvalidInputType = 0x0018,
        InvalidDateInput = 0x0019,
        InvalidSettingFile = 0x0020,
        InvalidUsernameOrPassword = 0x0021,
        InvalidRepeatPassword = 0x0023,
        UsernameExists = 0x0024,
        DateTimeIsEmpty = 0x0025,
        FreeTimeNotFound = 0x0026,
        InvalidPersonnelRow = 0x0027,
        InvalidIP = 0x0028,
        InvalidPhoneNumber = 0x0029,

        DbConnectionFailed = 0,
        UsernameNotFound = 1,
        InvalidCurrentPassword = 2,
        QueueNotFound = 3,
        FailedToDeleteQueue = 4,
        FailedToUpdateQueue = 5,
        CannotSetQueueStatusAnymore = 6,
        FailedToCreateQueue = 7,
        FailedToCreateAccount = 8,
        SelectedTimeIsUnavailable = 9
    }

    public static class ErrorHandler
    {
        private static Dictionary<ErrorCode, string>? ErrorMessage;

        private static void Initialize()
        {
            ErrorMessage = new Dictionary<ErrorCode, string>
            {
                { ErrorCode.InvalidInputType, "مقادیر وارد شده خالی یا نامعتبر می باشند" },
                { ErrorCode.InvalidDateInput, "شما مجاز به انتخاب تاریخ گذشته نیستید" },
                { ErrorCode.InvalidSettingFile, "فایل تنظیمات بارگیری شده نامعتبر است" },
                { ErrorCode.InvalidUsernameOrPassword, "نام کاربری یا رمز عبور اشتباه است" },
                { ErrorCode.InvalidCurrentPassword, "پسورد وارد شده با پسورد فعلی مطابقت ندارد" },
                { ErrorCode.UsernameExists, "نام کاربری وارد شده قبلا ثبت شده است" },
                { ErrorCode.DateTimeIsEmpty, "تاریخی انتخاب کنید" },
                { ErrorCode.FreeTimeNotFound, "زمان آزاد برای این روز وجود ندارد" },
                { ErrorCode.InvalidPersonnelRow, "برای حذف یک نوبت، باید اول آن را انتخاب کنید" },
                { ErrorCode.InvalidIP, "آدرس آی پی وارد شده معتبر نیست" },
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
                { ErrorCode.SelectedTimeIsUnavailable, "مدت زمان انتخاب شده برای این نوبت موجود نیست" }
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
