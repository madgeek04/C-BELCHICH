using System;
using System.Windows.Forms;

namespace Pract_8
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();

        private void button1_Click(object sender, EventArgs e)
        {
            double Xmin = double.Parse(textBoxXmin.Text);
            double Xmax = double.Parse(textBoxXmax.Text);
            double Step = double.Parse(textBoxStep.Text);
            double b = double.Parse(textBoxb.Text);
            int count = (int)Math.Ceiling((Xmax - Xmin) / Step) + 1;
            double[] x = new double[count];
            double[] y = new double[count];
            double[] y2 = new double[count];
            for (int i = 0; i < count; i++)
            {
                x[i] = Xmin + Step * i;
                y[i] = (Math.Pow(x[i], 5.0 / 2.0) - b) * Math.Log(Math.Pow(x[i], 2) + 12, 7);
                y2[i] = Math.Pow(x[i], 2);
            }
            chart1.ChartAreas[0].AxisX.Minimum = Xmin;
            chart1.ChartAreas[0].AxisX.Maximum = Xmax;
            chart1.ChartAreas[0].AxisX.MajorGrid.Interval = Step;
            chart1.Series[0].Points.DataBindXY(x, y);
            chart1.Series[1].Points.DataBindXY(x, y2);
        }
    }
}
