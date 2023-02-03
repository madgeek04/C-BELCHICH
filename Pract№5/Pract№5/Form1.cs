using System;
using System.Drawing;
using System.Windows.Forms;
using Button = System.Windows.Forms.Button;
using TextBox = System.Windows.Forms.TextBox;

namespace Pract_5
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.ToString() == "К")
            {
                Button temp = new Button
                {
                    Text = "Кнопка",
                    Location = new Point(Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text))
                };
                this.Controls.Add(temp);
            }
            if (textBox1.Text.ToString() == "П")
            {
                TextBox boxtemp = new TextBox
                {
                    Text = "Поле ввода",
                    Location = new Point(Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text))
                };
                this.Controls.Add(boxtemp);
            }
            if (textBox1.Text.ToString() == "М")
            {
                Label label = new Label
                {
                    Text = "Метка",
                    Location = new Point(Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text))
                };
                this.Controls.Add(label);
            }
        }
    }
}
