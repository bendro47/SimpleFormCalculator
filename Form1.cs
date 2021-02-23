using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double result = 0.0;
        string input = string.Empty;
        string operand = string.Empty;
        string input2 = string.Empty;
        int num1, num2, a, b;


        private void button1_Click(object sender, EventArgs e)
        {
            if (operand == string.Empty)
            {
                input += "1";
                textBox1.Text += "1";
            }
            else
            {
                input2 += "1";
                textBox1.Text += "1";
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (operand == string.Empty)
            {
                input += "2";
                textBox1.Text += "2";
            }
            else
            {
                input2 += "2";
                textBox1.Text += "2";
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (operand == string.Empty)
            {
                input += "3";
                textBox1.Text += "3";
            }
            else
            {
                input2 += "3";
                textBox1.Text += "3";
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (operand == string.Empty)
            {
                input += "4";
                textBox1.Text += "4";
            }
            else
            {
                input2 += "4";
                textBox1.Text += "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (operand == string.Empty)
            {
                input += "5";
                textBox1.Text += "5";
            }
            else
            {
                input2 += "5";
                textBox1.Text += "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (operand == string.Empty)
            {
                input += "6";
                textBox1.Text += "6";
            }
            else
            {
                input2 += "6";
                textBox1.Text += "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (operand == string.Empty)
            {
                input += "7";
                textBox1.Text += "7";
            }
            else
            {
                input2 += "7";
                textBox1.Text += "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (operand == string.Empty)
            {
                textBox1.Text += "8";
                input += "8";
            }
            else
            {
                input2 += "8";
                textBox1.Text += "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (operand == string.Empty)
            {
                input += "9";
                textBox1.Text += "9";
            }
            else
            {
                input2 += "9";
                textBox1.Text += "9";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (operand == string.Empty)
            {
                input += "0";
                textBox1.Text += "0";
            }
            else
            {
                input2 += "0";
                textBox1.Text += "0";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            operand = "+";
            textBox1.Text += " + ";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            operand = "-";
            textBox1.Text += " - ";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            operand = "*";
            textBox1.Text += " * ";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            operand = "/";
            textBox1.Text += " / ";
        }

        private void button15_Click(object sender, EventArgs e)//Calculate input operand input2 
        {
            num1 = Convert.ToInt32(input);
            num2 = Convert.ToInt32(input2);
            switch (operand)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    result = num1 / num2;
                    break;
                default:
                    break;
            }
            textBox1.Text = ($"{num1} {operand} {num2} = {result}");
        }

        private void button16_Click(object sender, EventArgs e)//Doesn't work
        {
            a = num1 * num1;
            num1 = a;
            textBox1.Text += "^2";
            if (operand != string.Empty)
            {
                b = num2 * num2;
                num2 = b;
                textBox1.Text += "^2";
            }// input * input
        }

        private void button17_Click(object sender, EventArgs e)// Doesn't work
        {
            a = num1 * num1 * num1;
            num1 = a;
            textBox1.Text += "^3";
            if (operand != string.Empty)
            {
                b = num2 * num2 * num2;
                num2 = b;
                textBox1.Text += "^3";
            }// input * input * input
        }

        private void button18_Click(object sender, EventArgs e)//clear
        {

            textBox1.Text = string.Empty;
            input = string.Empty;
            input2 = string.Empty;
            operand = string.Empty;
            num1 = 0;
            num2 = 0;
            a = 0;
            b = 0;
            result = 0.0;
        }

        private void button19_Click(object sender, EventArgs e)// ( ) doesn't work
        {
            if (operand == string.Empty)
            {
                input += $"({num1})";
                textBox1.Text += $"({input})";// meed fist and last line of code for this to work
            }
            else
            {
                input2 += $"({num2})";
                textBox1.Text += $"({input2})";// meed fist and last line of code for this to work
            }

        }
    }
}