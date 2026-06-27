namespace QueuingSystem.Client.Window
{
    public partial class FrmShowNote : Form
    {
        public FrmShowNote()
        {
            InitializeComponent();
        }

        public bool Write = false;

        private void FrmShowNote_Load(object sender, EventArgs e)
        {
            if (Write)
                txtbox_note.ReadOnly = false;
            else
                txtbox_note.ReadOnly = true;
            txtbox_note.SelectionStart = txtbox_note.Text.Length;
        }

        private void FrmShowNote_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }
    }
}
