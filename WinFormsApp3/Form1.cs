namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnBMI_Click(object sender, EventArgs e)
        {
            double bmi, height, weight;
            height = Convert.ToDouble(txtHeight.Text);
            weight = Convert.ToDouble(txtWeight.Text);
            height = height / 100;
            bmi = weight / (height * height);
            lblOutput.Text = "§AªºBMI­È¬°" + bmi.ToString("F2");
        }
    }
}
