using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desk2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string num1 = maskedTextBox1.Text;
            string num2 = maskedTextBox2.Text;
            MessageBox.Show((int.Parse(num1) + int.Parse(num2)).ToString());
            //string number1 = "123";
            //string number2 = "123";
            //MessageBox.Show((int.Parse(number1) + int.Parse(number2)).ToString());
            //string test1 = "456";
            //int test3 = 123;
            //int result;
            //bool success= int.TryParse(test1, out result);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string num1 = maskedTextBox1.Text;
            string num2 = maskedTextBox2.Text;
            MessageBox.Show((int.Parse(num1) - int.Parse(num2)).ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string num1 = maskedTextBox1.Text;
            string num2 = maskedTextBox2.Text;
            MessageBox.Show((int.Parse(num1) * int.Parse(num2)).ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string num1 = maskedTextBox1.Text;
            string num2 = maskedTextBox2.Text;
            MessageBox.Show((int.Parse(num1) / int.Parse(num2)).ToString());
        }
    }
}
