namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtMessage.SelectionStart = 0;
            txtMessage.SelectionLength = 6;
            txtMessage.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtOutput.Text = txtMessage.SelectedText + "/" + txtMessage.SelectionStart + "/" + txtMessage.SelectionLength;
            txtMessage.Focus();
        }
    }
}
