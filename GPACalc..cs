using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please enter a numerical value for Class 1.");
            }
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Please enter a numerical value for Class 2.");
            }
            if (string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Please Enter a numerical value for Class 3.");
            }
            if (string.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("Please enter a numerical value for Class 4.");
            }
            if (string.IsNullOrEmpty(textBox5.Text))
            {
                MessageBox.Show("Please enter a numerical value for Class 5.");
            }
            if (string.IsNullOrEmpty(textBox6.Text))
            {
                MessageBox.Show("Please enter a numerical value for Class 6.");
            }
            if (string.IsNullOrEmpty(textBox7.Text))
            {
                MessageBox.Show("Please enter a numerical value for Class 7.");
            }
            double Class1 = (Convert.ToDouble(textBox1.Text));
            double Class2 = (Convert.ToDouble(textBox2.Text));
            double Class3 = (Convert.ToDouble(textBox3.Text));
            double Class4 = (Convert.ToDouble(textBox4.Text));
            double Class5 = (Convert.ToDouble(textBox5.Text));
            double Class6 = (Convert.ToDouble(textBox6.Text));
            double Class7 = (Convert.ToDouble(textBox7.Text));
            double Total = Class1 + Class2 + Class3 + Class4 + Class5 + Class6 + Class7;
            double Average = Total / 7;
            if (Average > 95)
            {
                MessageBox.Show("Your average is: " + Average + "%!" + Environment.NewLine + "You have made High Honor Roll!");
            }
            else if (Average > 85)
            {
                MessageBox.Show("Your average is: " + Average + "%!" + Environment.NewLine + "You have made Honor Roll!");
            }
            else
            {
                MessageBox.Show("Your average is: " + Average + "%!" + Environment.NewLine + "You have not made the Honor Roll.");
            }
            

        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
