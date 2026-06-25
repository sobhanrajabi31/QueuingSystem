internal sealed class Inputbox
{
    public static DialogResult Show(ref string input, string name, string text = "")
    {
        var size = new Size(200, 70);
        var inputBox = new Form
        {
            RightToLeft = RightToLeft.Yes,

            FormBorderStyle = FormBorderStyle.FixedDialog,
            ClientSize = size,
            StartPosition = FormStartPosition.CenterScreen,
            MinimizeBox = false,
            MaximizeBox = false,
            Text = name
        };

        var textBox = new TextBox
        {
            Size = new Size(size.Width - 10, 23),
            Location = new Point(5, 5),
            Text = input,
            MaxLength = 23
        };
        inputBox.Controls.Add(textBox);

        textBox.Font = new Font(new FontFamily("Vazirmatn ExtraBold"), 10, FontStyle.Regular);
        textBox.Text = text;

        var okButton = new Button
        {
            DialogResult = DialogResult.OK,
            Name = "okButton",
            Size = new Size(75, 23),
            Text = "&OK",
            Location = new Point(size.Width - 80 - 80, 39)
        };
        inputBox.Controls.Add(okButton);

        var cancelButton = new Button
        {
            DialogResult = DialogResult.Cancel,
            Name = "cancelButton",
            Size = new Size(75, 23),
            Text = "&Cancel",
            Location = new Point(size.Width - 80, 39)
        };
        inputBox.Controls.Add(cancelButton);

        inputBox.AcceptButton = okButton;
        inputBox.CancelButton = cancelButton;

        DialogResult result = inputBox.ShowDialog();
        input = textBox.Text;
        return result;
    }
}