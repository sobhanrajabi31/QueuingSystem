namespace Queuing_System_Alipour.Tool
{
    public enum MButton
    {
        OK = 0,
        OKCancel = 1,
        AbortRetryIgnore = 2,
        YesNoCancel = 3,
        YesNo = 4,
        RetryCancel = 5
    }

    public enum MIcon
    {
        None = 0,
        Error = 16,
        Question = 32,
        Warning = 48,
        Information = 64
    }

    public enum Caption
    {
        Message, Error, Question, Warning, Information
    }

    public static class Mbox
    {
        /// <summary>
        /// show mbox with custom icon
        /// </summary>
        public static DialogResult Show(string text, Caption caption, MButton button, MIcon icon) =>
            MessageBox.Show(text, GetCaption(caption), (MessageBoxButtons) button, (MessageBoxIcon) icon);

        /// <summary>
        /// show mbox without icon
        /// </summary>
        public static DialogResult None(string text, Caption caption, MButton button = MButton.OK) =>
            MessageBox.Show(text, GetCaption(caption), (MessageBoxButtons)button, MessageBoxIcon.None);

        /// <summary>
        /// show mbox with error icon
        /// </summary>
        public static DialogResult Error(string text, Caption caption, MButton button = MButton.OK) =>
            MessageBox.Show(text, GetCaption(caption), (MessageBoxButtons)button, MessageBoxIcon.Error);

        /// <summary>
        /// show mbox with question icon
        /// </summary>
        public static DialogResult Question(string text, Caption caption, MButton button = MButton.YesNo) =>
            MessageBox.Show(text, GetCaption(caption), (MessageBoxButtons)button, MessageBoxIcon.Question);

        /// <summary>
        /// show mbox with warning icon
        /// </summary>
        public static DialogResult Warning(string text, Caption caption, MButton button = MButton.OK) =>
            MessageBox.Show(text, GetCaption(caption), (MessageBoxButtons)button, MessageBoxIcon.Warning);

        /// <summary>
        /// show mbox with information icon
        /// </summary>
        public static DialogResult Information(string text, Caption caption, MButton button = MButton.OK) =>
            MessageBox.Show(text, GetCaption(caption), (MessageBoxButtons)button, MessageBoxIcon.Information);

        public static string GetCaption(Caption caption)
        {
            if (caption == Caption.Message)
                return "پیام";

            else if (caption == Caption.Error)
                return "خطا";

            else if (caption == Caption.Warning)
                return "هشدار";

            else if (caption == Caption.Question)
                return "سوال";

            else
                return "پیغام";
        }
    }
}
