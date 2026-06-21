using System.Drawing;
using System.Windows.Forms;

internal sealed class Inputbox
{
    public static DialogResult Show(ref string input, string name, string text = "")
    {
        Size size = new Size(200, 70);
        Form inputBox = new Form();
        inputBox.RightToLeft = RightToLeft.Yes;

        inputBox.FormBorderStyle = FormBorderStyle.FixedDialog;
        inputBox.ClientSize = size;
        inputBox.StartPosition = FormStartPosition.CenterScreen;
        inputBox.MinimizeBox = false;
        inputBox.MaximizeBox = false;
        inputBox.Text = name;

        TextBox textBox = new TextBox();
        textBox.Size = new Size(size.Width - 10, 23);
        textBox.Location = new Point(5, 5);
        textBox.Text = input;
        textBox.MaxLength = 23;
        inputBox.Controls.Add(textBox);

        textBox.Font = new Font(new FontFamily("Vazirmatn ExtraBold"), 10, FontStyle.Regular);
        textBox.Text = text;

        Button okButton = new Button();
        okButton.DialogResult = DialogResult.OK;
        okButton.Name = "okButton";
        okButton.Size = new Size(75, 23);
        okButton.Text = "&OK";
        okButton.Location = new Point(size.Width - 80 - 80, 39);
        inputBox.Controls.Add(okButton);

        Button cancelButton = new Button();
        cancelButton.DialogResult = DialogResult.Cancel;
        cancelButton.Name = "cancelButton";
        cancelButton.Size = new Size(75, 23);
        cancelButton.Text = "&Cancel";
        cancelButton.Location = new Point(size.Width - 80, 39);
        inputBox.Controls.Add(cancelButton);

        inputBox.AcceptButton = okButton;
        inputBox.CancelButton = cancelButton;

        DialogResult result = inputBox.ShowDialog();
        input = textBox.Text;
        return result;
    }
}