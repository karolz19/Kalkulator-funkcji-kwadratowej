namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c, ans1, ans2, d1;
            a = double.Parse(textBox3.Text);
            b = double.Parse(textBox2.Text);
            c = double.Parse(textBox1.Text);
            ans1 = (-1 * b + Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2  * a);
            ans2 = (-1 * b - Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2  * a);
            d1 = (Math.Pow(b, 2) - 4 * a * c);
            label6.Text = ans1.ToString("n2");
            label7.Text = ans2.ToString("n2");
            label9.Text = d1.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}