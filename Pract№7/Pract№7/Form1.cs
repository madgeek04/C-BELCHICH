using System;
using System.Windows.Forms;

namespace Pract_7
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 7;
            dataGridView1.ColumnCount = 7;
            dataGridView2.RowCount = 7;
            dataGridView2.ColumnCount = 7;
            int[,] a = new int[7, 7];
            int i, j;
            Random rand = new Random();
            for (i = 0; i < 7; i++)
                for (j = 0; j < 7; j++)
                    a[i, j] = rand.Next(-100, 100);
            for (i = 0; i < 7; i++)
                for (j = 0; j < 7; j++)
                    dataGridView1.Rows[i].Cells[j].Value = a[i, j].ToString();
            int max2 = a[1, 1];
            int indmax2 = 0;
            for (i = 0; i < 7; i++)
            {
                if (a[i, 6 - i] > max2)
                {
                    max2 = a[i, 6 - i];
                    indmax2 = i;
                }
            }
            int max1 = a[1, 1];
            int indmax1 = 0;
            for (i = 0; i < 7; i++)
            {
                if (a[i, i] > max1)
                {
                    max1 = a[i, i];
                    indmax1 = i;
                }
            }
            textBox1.Text = Convert.ToString(Math.Max(max1, max2));
            for (i = 0; i < 7; i++)
                for (j = 0; j < 7; j++)
                    dataGridView2.Rows[i].Cells[j].Value = a[i, j].ToString();
            if (max1 >= max2) 
            {
                dataGridView2.Rows[3].Cells[3].Value = max1;
                dataGridView2.Rows[indmax1].Cells[indmax1].Value = dataGridView1.Rows[3].Cells[3].Value;
            }
            else
            {
                dataGridView2.Rows[3].Cells[3].Value = max2;
                dataGridView2.Rows[indmax2].Cells[6 - indmax2].Value = dataGridView1.Rows[3].Cells[3].Value;
            }
        }
    }
}
