using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientatedProgramming
{
    public partial class Form1 : Form
    {
        BankAccount account1 = new BankAccount("Tom Mills");
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
            //account1 = new BankAccount();
            label2.Text = "Account created in the name of " + account1.GetAccount();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            decimal cash = Convert.ToDecimal(textBox1.Text);
            account1.Withdraw(cash);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            label2.Text = account1.Statement();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            decimal cash = Convert.ToDecimal(textBox1.Text);
            account1.Deposit(cash);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }
    }
}
