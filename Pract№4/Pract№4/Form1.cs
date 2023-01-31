using System;
using System.Windows.Forms;

namespace Pract_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x0 = Convert.ToDouble(textBox1.Text);
            double xk = Convert.ToDouble(textBox2.Text);
            double dx = Convert.ToDouble(textBox3.Text);
            double a = Convert.ToDouble(textBox4.Text);
            double x = x0;
            while (x <= (xk + dx / 2.0))
            {
                double y = (Math.Pow(x, (5.0 / 2.0)) - a) * Math.Log(Math.Pow(x, 2) + 12, 7);
                textBox5.Text += "x=" + Convert.ToString(x) + "; y=" + Convert.ToString(y) + Environment.NewLine;
                x += dx;
            }
        }
    }
}
