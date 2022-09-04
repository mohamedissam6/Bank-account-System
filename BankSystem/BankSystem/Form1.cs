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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string name;
        double balance;
        double deposit;
        double withdraw;
        Accounts account;
        


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
            name = textBox1.Text;
                if (name == "") throw new ArithmeticException("Parameter cannot be null");
            }
            catch //(ArithmeticException )
            {
                MessageBox.Show( "name not entered");
            }
            
            try
            {
                balance = Convert.ToDouble(textBox2.Text);
            }
            catch (FormatException e2)
            {
                MessageBox.Show(e2.Message + "\r\n you must enter your starting balance (number)");
            }
            decimal age = (DateTime.Now.Year - dateTimePicker1.Value.Year );
            try
            {
                if (age < 18) throw new ArithmeticException("age must be over 18");
            }
            catch (ArithmeticException)
            {
                MessageBox.Show("you must be 18 or obove");
            }

            if (!radioButton1.Checked && !radioButton2.Checked)
            {
                    MessageBox.Show("you must choose account type");
            }
            else
            {
                if (radioButton2.Checked)
                {
                        account = new CheckingAccount(name, balance, age);
                }

                if (radioButton1.Checked)
                {
                    account = new SavingAccount(name, balance, age);


                }

                    textBoxResult.Text = account.ToString();
                    textBoxResult.Text = textBoxResult.Text + "\r\n\r\nBalance\t\t\t\t\t\t\t\tAction";

            }
           
            
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBoxResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                deposit = Convert.ToDouble(textBox4.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("enter your deposit amount please");
            }
            account.Deposit(deposit);
            textBoxResult.Text = textBoxResult.Text + "\r\n" + account.balance + "\t\t\t\t\t\t\t\t+ " + deposit;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                withdraw = Convert.ToDouble(textBox5.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("enter your withdraw amount please");
            }
            account.Withdraw(withdraw);
            textBoxResult.Text = textBoxResult.Text + "\r\n" + account.balance + "\t\t\t\t\t\t\t\t- " + withdraw;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (account is CheckingAccount)
            {
                ((CheckingAccount)account).applytaxes();
                textBoxResult.Text = textBoxResult.Text + "\r\n" + String.Format("{0:0.00}",account.balance) + "\t\t\t\t\t\t\t\t- " + ((CheckingAccount)account).tax();
            }
            else
            {
                ((SavingAccount)account).applytaxes();
                textBoxResult.Text = textBoxResult.Text + "\r\n" + String.Format("{0:0.00}", account.balance) + "\t\t\t\t\t\t\t\t- " + ((SavingAccount)account).tax();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (account is CheckingAccount)
            {
                ((CheckingAccount)account).applybenefits();
                textBoxResult.Text = textBoxResult.Text + "\r\n" + String.Format("{0:0.00}", account.balance) + "\t\t\t\t\t\t\t\t+ " + ((CheckingAccount)account).ben();
            }
            else
            {
                ((SavingAccount)account).applybenefits();
                textBoxResult.Text = textBoxResult.Text + "\r\n" + String.Format("{0:0.00}", account.balance) + "\t\t\t\t\t\t\t\t+ " + ((SavingAccount)account).ben();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {


           
        }
    }
}
