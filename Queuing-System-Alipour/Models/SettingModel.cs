namespace Queuing_System_Alipour.Models
{
    public enum TimeFrame
    {
        ComboBoxText = 0, BeforeQueueDay, QueueDay, ExpireQueue
    }

    public enum QueueStatus
    {
        ComboBoxText = 0, Done, Canceled, Undone
    }

    public class SettingModel
    {
        public TimeFrame? TimeFrame { get; set; }
        public QueueStatus? QueueStatus { get; set; }
        public string NetworkPath { get; set; }
        public int? PersonnelWaitTime { get; set; }
        public bool? PhotographMode { get; set; }
        public bool? RememberMe { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string NetworkIP { get; set; }
    }
}
