using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace к
{
    public partial class Form1 : Form
    {
        double a = 0, b = 0, c = 0;
        char z = '+';
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "0";
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Clear();
            textBox1.Text += (sender as Button).Text;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Clear();
            textBox1.Text += (sender as Button).Text;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Clear();
            textBox1.Text += (sender as Button).Text;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Clear();
            textBox1.Text += (sender as Button).Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Clear();
            textBox1.Text += (sender as Button).Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Clear();
            textBox1.Text += (sender as Button).Text;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Clear();
            textBox1.Text += (sender as Button).Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Clear();
            textBox1.Text += (sender as Button).Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Clear();
            textBox1.Text += (sender as Button).Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Clear();
            textBox1.Text += (sender as Button).Text;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text += (sender as Button).Text;
            }
            catch (Exception)
            {
                textBox1.Text = "Ошибка ввода";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                a = Convert.ToDouble(textBox1.Text);
                z = (sender as Button).Text[0];
                textBox1.Clear();
            }
            catch (Exception)
            {
                textBox1.Text = "Ошибка ввода";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                a = Convert.ToDouble(textBox1.Text);
                z = (sender as Button).Text[0];
                textBox1.Clear();
            }
            catch (Exception)
            {
                textBox1.Text = "Ошибка ввода";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                b = Convert.ToDouble(textBox1.Text);
                switch (z)
                {
                    case '+': c = a + b; break;
                    case '-': c = a - b; break;
                    case '*': c = a * b; break;
                    case '/': 
                        if(b != 0) c = a / b; 
                        else textBox1.Text = "Ошибка ввода";
                        break;
                }
                if (b != 0)  textBox1.Text = c.ToString();
            }
            catch (Exception)
            {
                textBox1.Text = "Ошибка ввода";
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "") textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            a = 0;
            b = 0;
            c = 0;
            textBox1.Text = "0";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text[0] == '-') textBox1.Text = textBox1.Text.Remove(0, 1);
                else textBox1.Text = '-' + textBox1.Text;
            }
            catch (Exception)
            {
                textBox1.Text = "Ошибка ввода";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                c = Convert.ToDouble(textBox1.Text);
                c /= 100;
                textBox1.Text = c.ToString();
            }
            catch (Exception)
            {
                textBox1.Text = "Ошибка ввода";
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            try
            {
                c = Convert.ToDouble(textBox1.Text);
                c = 1 / c;
                textBox1.Text = c.ToString();
            }
            catch (Exception)
            {
                textBox1.Text = "Ошибка ввода";
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            try
            {
                c = Convert.ToDouble(textBox1.Text);
                c *=c;
                textBox1.Text = c.ToString();
            }
            catch (Exception)
            {
                textBox1.Text = "Ошибка ввода";
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            try
            {
                c = Convert.ToDouble(textBox1.Text);
                c = Math.Sqrt(c);
                textBox1.Text = c.ToString();
            }
            catch (Exception)
            {
                textBox1.Text = "Ошибка ввода";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void инженерныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                a = Convert.ToDouble(textBox1.Text);
                z = (sender as Button).Text[0];
                textBox1.Clear();
            }
            catch (Exception)
            {
                textBox1.Text = "Ошибка ввода";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                a = Convert.ToDouble(textBox1.Text);
                z = (sender as Button).Text[0];
                textBox1.Clear();
            }
            catch (Exception)
            {
                textBox1.Text = "Ошибка ввода";
            }
        }
    }
}
