namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt16(lblOutput.Text);
            num = num + 1;
            lblOutput.Text = num.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblOutput.Text = "0";
        }
    }
}
