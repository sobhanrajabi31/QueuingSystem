using System.Collections.Generic;
using System.Windows.Forms;

namespace Queuing_System_Alipour.Tool.Handler
{
    public enum MessageCode
    {
        AccountCreated = 0,
        QueueAdded = 1,
        QueueRemoved = 2,
        LogoutQuestion = 3,
        QueueDeleteQuestion = 4,
        QueueStatusToDoneQuestion = 5,
        QueueStatusToCancelQuestion = 6,
        QueueStatusToDone = 7,
        QueueStatusToCancel = 8,
        PasswordChanged = 9,
    }

    public class MessageHandler
    {
        private static Dictionary<MessageCode, string> Message { get; set; } = null;

        private static void Initialize()
        {
            Message = new Dictionary<MessageCode, string>
            {
                { MessageCode.AccountCreated, "حساب کاربری شما با موفقیت ایجاد شد" },
                
                { MessageCode.LogoutQuestion, "آیا می خواهید از حساب کاربری خود خارج شوید؟" },
                { MessageCode.QueueDeleteQuestion, "آیا از حذف این نوبت اطمینان کامل دارید؟" },
                { MessageCode.QueueStatusToDoneQuestion, "آیا از تغییر وضعیت این نوبت به *انجام شده* اطمینان دارید؟" },
                { MessageCode.QueueStatusToDone, "وضعیت این نوبت به *انجام شده* تغییر پیدا کرد" },
                { MessageCode.QueueStatusToCancelQuestion, "آیا از تغییر وضعیت این نوبت به *کنسل شده* اطمینان دارید؟" },
                { MessageCode.QueueStatusToCancel, "وضعیت این نوبت به *کنسل شده* تغییر پیدا کرد" },

                { MessageCode.PasswordChanged, "پسورد جدید با موفقیت ثبت شد، لطفا مجددا لاگین کنید" },
                { MessageCode.QueueAdded, "نوبت مورد نظر اضافه شد" },
                { MessageCode.QueueRemoved, "نوبت مورد نظر حذف شد" },
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
