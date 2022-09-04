using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            label2.Hide();
            label3.Hide();
            numericUpDown1.Hide();
            numericUpDown2.Hide();
            button1.Hide();
            
        }
        employee emp;
        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                label2.Show();
                numericUpDown1.Show();
                label3.Hide();
                numericUpDown2.Hide();
                button1.Show();

            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                label3.Show();
                numericUpDown2.Show();
                label2.Hide();
                numericUpDown1.Hide();
                button1.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                emp = new hourlyEmployee(textBox1.Text, Convert.ToDouble(numericUpDown1.Value));
            }
            if (radioButton2.Checked)
            {
                emp = new SalaredEmployee(textBox1.Text, Convert.ToDouble(numericUpDown2.Value));
            }
            textBox2.Text = "" + emp.earning();
        }
    }
}
