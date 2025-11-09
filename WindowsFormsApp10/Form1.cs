using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(Num1.Text);
            double num2 = Convert.ToDouble(Num2.Text);
            double result = num1 - num2;
            lblResult.Text = "Result: " + result;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(Num1.Text);
            double num2 = Convert.ToDouble(Num2.Text);
            double result = num1 + num2;
            lblResult.Text = "Result: " + result;
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(Num1.Text);
            double num2 = Convert.ToDouble(Num2.Text);
            double result = num1 * num2;
            lblResult.Text = "Result: " + result;
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(Num1.Text);
            double num2 = Convert.ToDouble(Num2.Text);

            if (num2 == 0)
            {
                MessageBox.Show("You cannot divide by zero!");
            }
            else
            {
                double result = num1 / num2;
                lblResult.Text = "Result: " + result;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
