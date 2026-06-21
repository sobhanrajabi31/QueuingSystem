using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Security;

namespace Queuing_System_Alipour.Tool.Handler
{
    public enum ErrorCode
    {
        InternalBufferOverflowException = 0x0001,
        IOException = 0x0002,
        ObjectDisposedException = 0x0003,
        ArgumentException = 0x0004,
        ArgumentNullException = 0x0005,
        UnauthorizedAccessException = 0x0006,
        PathTooLongException = 0x0007,
        DirectoryNotFoundException = 0x0008,
        FileNotFoundException = 0x0009,
        NotSupportedException = 0x0010,
        SecurityException = 0x0012,
        Unknown = 0x0013,
        NetworkError = 0x0014,
        FailurePing = 0x0015,
        TimeoutOrCanceled = 0x0016,
        InvalidOperation = 0x0017,
        InvalidInputType = 0x0018,
        InvalidDateInput = 0x0019,
        InvalidSettingFile = 0x0020,
        InvalidUsernameOrPassword = 0x0021,
        InvalidCurrentPassword = 0x0022,
        InvalidRepeatPassword = 0x0023,
        UsernameExists = 0x0024,
        DateTimeIsEmpty = 0x0025,
        FreeTimeNotFound = 0x0026,
        InvalidPersonnelRow = 0x0027,
        InvalidIP = 0x0028,
        InvalidPhoneNumber = 0x0029,
    }

    public static class ErrorHandler
    {
        private static readonly Dictionary<Type, ErrorCode> ExceptionToErrorCodeMap = new Dictionary<Type, ErrorCode>()
        {
            { typeof(InternalBufferOverflowException), ErrorCode.InternalBufferOverflowException },
            { typeof(IOException), ErrorCode.IOException },
            { typeof(ObjectDisposedException), ErrorCode.ObjectDisposedException },
            { typeof(ArgumentException), ErrorCode.ArgumentException },
            { typeof(UnauthorizedAccessException), ErrorCode.UnauthorizedAccessException },
            { typeof(PathTooLongException), ErrorCode.PathTooLongException },
            { typeof(ArgumentNullException), ErrorCode.ArgumentNullException },
            { typeof(DirectoryNotFoundException), ErrorCode.DirectoryNotFoundException },
            { typeof(FileNotFoundException), ErrorCode.FileNotFoundException },
            { typeof(NotSupportedException), ErrorCode.NotSupportedException },
            { typeof(SecurityException), ErrorCode.SecurityException },
            { typeof(PingException), ErrorCode.FailurePing },
            { typeof(SocketException), ErrorCode.NetworkError },
            { typeof(TaskCanceledException), ErrorCode.TimeoutOrCanceled },
            { typeof(InvalidOperationException), ErrorCode.InvalidOperation }
        };

        private static Dictionary<ErrorCode, string> ErrorMessage { get; set; } = null;

        private static void Initialize()
        {
            ErrorMessage = new Dictionary<ErrorCode, string>
            {
                { ErrorCode.InternalBufferOverflowException, "بافر داخلی برنامه پر شده است، با برنامه نویس برنامه تماس بگیرید" },
                { ErrorCode.IOException, "پایگاه داده برنامه در حال استفاده است، لطفا مجدد تلاش کنید" },
                { ErrorCode.ObjectDisposedException, "ردیاب پایگاه داده از بین رفته است و قابل استفاده نیست" },
                { ErrorCode.ArgumentException, "پایگاه داده سرور یافت نشد" },
                { ErrorCode.ArgumentNullException, "پایگاه داده سرور یافت نشد" },
                { ErrorCode.UnauthorizedAccessException, "دسترسی به پایگاه داده سرور ممکن نیست" },
                { ErrorCode.PathTooLongException, "مسیر پایگاه داده در سرور بیش از حد طولانی است" },
                { ErrorCode.DirectoryNotFoundException, "مسیر پایگاه داده سرور یافت نشد" },
                { ErrorCode.FileNotFoundException, "پایگاه داده یافت نشد" },
                { ErrorCode.NotSupportedException, "مسیر پایگاه داده سرور نامعتبر است" },
                { ErrorCode.SecurityException, "دسترسی لازم برای ارتباط با پایگاه داده وجود ندارد" },
                { ErrorCode.Unknown, "خطایی نامعلوم هنگام ارتباط با پایگاه داده سرور رخ داد" },
                { ErrorCode.NetworkError, "اتصال شبکه یافت نشد" },
                { ErrorCode.FailurePing, "خطایی هنگام دریافت اطلاعات از سرور رخ داد" },
                { ErrorCode.TimeoutOrCanceled, "تلاش برای برقراری ارتباط با پایگاه داده سرور بیش از اندازه طول کشید" },
                { ErrorCode.InvalidOperation, "(CrossThread) خطایی هنگام تلاش برای برقراری ارتباط با پایگاه داده سرور رخ داد" },
                { ErrorCode.InvalidInputType, "مقادیر وارد شده خالی یا نامعتبر می باشند" },
                { ErrorCode.InvalidDateInput, "شما مجاز به انتخاب تاریخ گذشته نیستید" },
                { ErrorCode.InvalidSettingFile, "فایل تنظیمات بارگیری شده نامعتبر است" },
                { ErrorCode.InvalidUsernameOrPassword, "نام کاربری یا رمز عبور اشتباه است" },
                { ErrorCode.InvalidCurrentPassword, "پسورد وارد شده با پسورد فعلی مطابقت ندارد" },
                { ErrorCode.InvalidRepeatPassword, "پسورد وارد شده با تکرار آن مطابقت ندارد" },
                { ErrorCode.UsernameExists, "نام کاربری وارد شده قبلا ثبت شده است" },
                { ErrorCode.DateTimeIsEmpty, "تاریخی انتخاب کنید" },
                { ErrorCode.FreeTimeNotFound, "زمان آزاد برای این روز وجود ندارد" },
                { ErrorCode.InvalidPersonnelRow, "برای حذف یک نوبت، باید اول آن را انتخاب کنید" },
                { ErrorCode.InvalidIP, "آدرس آی پی وارد شده معتبر نیست" },
                { ErrorCode.InvalidPhoneNumber, "شماره تلفن وارد شده معتبر نیست" }
            };
        }

        public static string GetMessage(ErrorCode errorCode)
        {
            if (ErrorMessage == null)
                Initialize();
            return ErrorMessage[errorCode];
        }

        public static ErrorCode GetErrorCode(Exception ex)
        {
            var exception = ex;
            var type = exception.GetType();

            if (ExceptionToErrorCodeMap.TryGetValue(type, out var errorCode))
                return errorCode;
            else
                return ErrorCode.Unknown;
        }
    }
}
