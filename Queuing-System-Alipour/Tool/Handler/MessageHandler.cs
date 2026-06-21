using System.Collections.Generic;
using System.Windows.Forms;

namespace Queuing_System_Alipour.Tool.Handler
{
    public enum MessageCode
    {
        AccountCreated = 0x0000,
        SuccessPing = 0x0001,
        QueueAdded = 0x0002,
        QueueRemoved = 0x0003,
        LogoutQuestion = 0x0004,
        QueueDeleteQuestion = 0x0005,
        PasswordChanged = 0x0006,
        StatusToDoneQuestion = 0x0007,
        StatusToCancelQuestion = 0x0008,
        StatusToDone = 0x0009,
        StatusToCancel = 0x0010,
        PersonnelQueueRemoved = 0x0011,
    }

    public class MessageHandler
    {
        private static Dictionary<MessageCode, string> Message { get; set; } = null;

        private static void Initialize()
        {
            Message = new Dictionary<MessageCode, string>
            {
                { MessageCode.AccountCreated, "حساب کاربری شما با موفقیت ایجاد شد" },
                { MessageCode.QueueAdded, "نوبت مورد نظر اضافه شد" },
                { MessageCode.QueueRemoved, "نوبت مورد نظر حذف شد" },
                { MessageCode.LogoutQuestion, "آیا می خواهید از حساب کاربری خود خارج شوید؟" },
                { MessageCode.QueueDeleteQuestion, "آیا از حذف این نوبت اطمینان کامل دارید؟" },
                { MessageCode.PasswordChanged, "پسورد جدید با موفقیت ثبت شد" },
                { MessageCode.StatusToDoneQuestion, "آیا از تغییر وضعیت این نوبت به *انجام شده* اطمینان دارید؟" },
                { MessageCode.StatusToDone, "وضعیت این نوبت به *انجام شده* تغییر پیدا کرد" },
                { MessageCode.StatusToCancelQuestion, "آیا از تغییر وضعیت این نوبت به *کنسل شده* اطمینان دارید؟" },
                { MessageCode.StatusToCancel, "وضعیت این نوبت به *کنسل شده* تغییر پیدا کرد" },
                { MessageCode.PersonnelQueueRemoved, "نوبت مورد نظر با موفقیت حذف شد" }
            };
        }

        public static string GetMessage(MessageCode messageCode)
        {
            if (Message == null)
                Initialize();
            return Message[messageCode];
        }
    }
}
