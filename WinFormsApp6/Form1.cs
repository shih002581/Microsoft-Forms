namespace WinFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            const double RATE = 32.1;
            double result, amount;
            string str = "可換成台幣 = ";
            amount = Convert.ToDouble(txtAmountl.Text);

            result = amount * RATE;
            str += result;

            MessageBox.Show(str, "美金兌換金額:" + amount, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            const double 
        }
    }
}
