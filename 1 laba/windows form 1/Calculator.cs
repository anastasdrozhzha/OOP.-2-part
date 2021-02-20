using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1.Windows_form
{
    
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
            radioButton1.CheckedChanged += new EventHandler(radioButton1_CheckedChanged);
            radioButton2.CheckedChanged += new EventHandler(radioButton2_CheckedChanged);
            radioButton3.CheckedChanged += new EventHandler(radioButton3_CheckedChanged);
            radioButton4.CheckedChanged += new EventHandler(radioButton4_CheckedChanged);
        }

        private int funcAnd(int a, int b)
        {
            return a & b;
        }

        private int funcOr(int a, int b)
        {
            return a | b;
        }

        private int funcXor(int a, int b)
        {
            return a ^ b;
        }

        private int funcNot(int a)
        {
            return ~a ;
        }
       
        private void button4_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(funcAnd(Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text)));
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(funcOr(Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text)));
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
           textBox1.Text = Convert.ToString(funcNot(Convert.ToInt32(textBox3.Text)));
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(funcXor(Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text)));
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                int i = Convert.ToInt32(textBox1.Text);
                textBox4.Text = Convert.ToString(i, 10);
            }
            catch (FormatException) { };
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            try 
            { 
                int i = Convert.ToInt32(textBox1.Text);
                textBox4.Text = Convert.ToString(i, 16);
            }
            catch (FormatException) { };
}
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                int i = Convert.ToInt32(textBox1.Text);
                textBox4.Text = Convert.ToString(i, 8);
            }
            catch (FormatException) { };
        }
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                int i = Convert.ToInt32(textBox1.Text);
                textBox4.Text = Convert.ToString(i, 2);
            }
            catch (FormatException) { };
        }

        private void textBox3_keyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                char number = e.KeyChar;
                if (!Char.IsDigit(number))
                {
                    e.Handled = true;
                    textBox3.BackColor = Color.Red;
                }
                else textBox3.BackColor = SystemColors.Window;
            }
            catch (FormatException)
            {
                MessageBox.Show("Error, you input wrong numbers!Try again");
            }
        }

        private void textBox2_keyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                char number = e.KeyChar;
                if (!Char.IsDigit(number))
                {
                    e.Handled = true;
                    textBox2.BackColor = Color.Red;
                }
                else textBox2.BackColor = SystemColors.Window;
            }
            catch (FormatException)
            {
                MessageBox.Show("Error, you input wrong numbers!Try again");
            }
        }
        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
           
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
