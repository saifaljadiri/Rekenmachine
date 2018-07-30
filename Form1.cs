using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rekenmachine
{
    public partial class Form1 : Form
    {
        decimal inputOne;
        String arth_operator;

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void button12_Click(object sender, EventArgs e)
        {
            inputOne = Convert.ToDecimal(txtScreen.Text);
            txtScreen.Text = "";
            arth_operator = "+";
        }

        private void Num7_Click(object sender, EventArgs e)
        {
            txtScreen.Text = txtScreen.Text + "7";
        }

        private void Num1_Click(object sender, EventArgs e)
        {
            txtScreen.Text = txtScreen.Text + "1";
        }

        private void Num2_Click(object sender, EventArgs e)
        {
            txtScreen.Text = txtScreen.Text + "2";
        }

        private void Num3_Click(object sender, EventArgs e)
        {
            txtScreen.Text = txtScreen.Text + "3";
        }

        private void Num4_Click(object sender, EventArgs e)
        {
            txtScreen.Text = txtScreen.Text + "4";
        }

        private void Num5_Click(object sender, EventArgs e)
        {
            txtScreen.Text = txtScreen.Text + "5";
        }

        private void Num6_Click(object sender, EventArgs e)
        {
            txtScreen.Text = txtScreen.Text + "6";
        }

        private void Num8_Click(object sender, EventArgs e)
        {
            txtScreen.Text = txtScreen.Text + "8";
        }

        private void Num9_Click(object sender, EventArgs e)
        {
            txtScreen.Text = txtScreen.Text + "9";
        }

        private void Num0_Click(object sender, EventArgs e)
        {
            txtScreen.Text = txtScreen.Text + "0";
        }

        private void Opclear_Click(object sender, EventArgs e)
        {

            txtScreen.Text = "";
        }
        private void NumDot_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text.Contains(".") == false)
            {
                txtScreen.Text = txtScreen.Text + ".";
            }
            else
            {
                MessageBox.Show("Decimal point is already there");
            }
        }

        private void OpMinus_Click(object sender, EventArgs e)
        {
            inputOne = Convert.ToDecimal(txtScreen.Text);
            txtScreen.Text = "";
            arth_operator = "-";
        }

        private void OpMultiply_Click(object sender, EventArgs e)
        {
            inputOne = Convert.ToDecimal(txtScreen.Text);
            txtScreen.Text = "";
            arth_operator = "*";
        }

        private void OpDivide_Click(object sender, EventArgs e)
        {
            inputOne = Convert.ToDecimal(txtScreen.Text);
            txtScreen.Text = "";
            arth_operator = "/";
        }

        private void OpEquals_Click(object sender, EventArgs e)
        {
            decimal result = 0;
            if (arth_operator == "+")
            {
                result = inputOne + Convert.ToDecimal(txtScreen.Text);
            }
            else if (arth_operator == "-")
            {
                result = inputOne - Convert.ToDecimal(txtScreen.Text);
            }
            else if (arth_operator == "*")
            {
                result = inputOne * Convert.ToDecimal(txtScreen.Text);
            }
            else if (arth_operator == "/")
            {
                if (txtScreen.Text == "0")
                {
                    result = inputOne / Convert.ToDecimal(txtScreen.Text);
                }
                else
                    MessageBox.Show("Enter value other than 0");
            }
            txtScreen.Text = result.ToString();
        }
    }
}
