using System;
using System.Windows.Forms;

namespace Pract_2
{
    public partial class Pract2 : Form
    {
        public Pract2()
        {
            InitializeComponent();
        }

        private void Pract2_Load(object sender, EventArgs e)
        {
            string input = textBox1.Text;
            string input2 = textBox2.Text;
            string input3 = textBox3.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textBox1.Text);
            textBox4.Text += "X = " + x.ToString();
            double y = double.Parse(textBox2.Text);
            textBox4.Text += Environment.NewLine + "Y = " + y.ToString();
            double z = double.Parse(textBox3.Text);
            textBox4.Text += Environment.NewLine + "Z = " + z.ToString();
            double a = Math.Pow(y, x + 1) / (Math.Pow(Math.Abs(y - 2), (1.0 / 3.0)) + 3);
            double b = (x + (y / 2)) / (2 * Math.Abs(x + y));
            double c = Math.Pow(x + 1, -1 / Math.Sin(z));
            double g = a + b * c;
            textBox4.Text += Environment.NewLine + "Результат g = " + g.ToString();
        }
    }
}
