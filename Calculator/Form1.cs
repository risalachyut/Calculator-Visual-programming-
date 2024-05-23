using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        int value1,value2;
        char sign;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            textBox1.Text =  " ";
        }

        private void btnplus_Click(object sender, EventArgs e)
        {
            value1 = int.Parse(textBox1.Text);
            sign = '+';
            textBox1.Text = " ";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            value1 = int.Parse(textBox1.Text);
            sign = '-';
            textBox1.Text = " ";
        }

        private void btnmul_Click(object sender, EventArgs e)
        {
            value1 = int.Parse(textBox1.Text);
            sign = '*';
            textBox1.Text = " ";
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            value1 = int.Parse(textBox1.Text);
            sign = '/';
            textBox1.Text = " ";
        }

        private void btneql_Click(object sender, EventArgs e)
        {
            value2 = int.Parse(textBox1.Text);
            int result;
            if (sign == '+')
            {
                result = value1 + value2;
                textBox1.Text = result.ToString();
            }
            else if (sign == '-') 
            {
                result = value1 - value2;
                textBox1.Text = result.ToString();
            }
            else if(sign == '*')
            {
                result = value1 * value2;
                textBox1.Text = result.ToString();
            }
            else 
            {
                result = value1 / value2;
                textBox1.Text = result.ToString();
            }
            
        }
 
    }
}
