using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcu
{
    public partial class Calculator : Form
    {
        double nomber1 , nomber2 , result ;
        char operation;

        public Calculator()
        {
            InitializeComponent();
        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {  
            
            nomber2 = double.Parse(clicked.Text);
            switch (operation)
            {

                case '+':
                    result = nomber1 + nomber2;
                    break;

                case '-':
                    result = nomber1 - nomber2;
                    break;

                case '*':
                    result = nomber1 * nomber2;
                    break;

                case '/':
                    result = nomber1 / nomber2;
                    break;

            }
            clicked.Text = Convert.ToString(result);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            clicked.Text += "1";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            clicked.Text += "2";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            clicked.Text += "3";
            

        }

        private void button6_Click(object sender, EventArgs e)
        {
            clicked.Text += "4";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            clicked.Text += "5";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            clicked.Text += "6";

        }

        private void button9_Click(object sender, EventArgs e)
        {
            clicked.Text += "7";

        }

        private void button8_Click(object sender, EventArgs e)
        {
            clicked.Text += "8";

        }

        private void button7_Click(object sender, EventArgs e)
        {
            clicked.Text += "9";

        }

        private void button12_Click(object sender, EventArgs e)
        {
            clicked.Text += "0";

        }

        private void button15_Click(object sender, EventArgs e)
        {
            nomber1 = double.Parse(clicked.Text);
            operation = '*';
            clicked.Clear();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            nomber1 = double.Parse(clicked.Text);
            operation = '/';
            clicked.Clear();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            nomber1 = double.Parse(clicked.Text);
            operation = '+';
            clicked.Clear();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            nomber1 = double.Parse(clicked.Text);
            operation = '-';
            clicked.Clear();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            clicked.Text += ".";

        }

        private void button10_Click(object sender, EventArgs e)
        {
            clicked.Clear();
        }
    }
}
