using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_Machine_Software
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void Btn_withdraw_Click(object sender, EventArgs e)
        {
            TransactionShow();

        }

        private void TransactionShow()
        {
            this.Hide();
            Transaction transaction = new Transaction();
            transaction.Show();
        }

        private void Btn_deposit_Click(object sender, EventArgs e)
        {
            TransactionShow();
        }

        private void Btn_changePin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Change_PIN changePin = new Change_PIN();
            changePin.Show();
        }

        private void Link_recentTransactions_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Recent_Transactions recentTransactions = new Recent_Transactions();
            recentTransactions.Show();
        }

        private void Btn_balance_Click(object sender, EventArgs e)
        {
            string balance = EnterPin.newDS.Tables[0].Rows[0]["Balance"].ToString().Replace(",","");
            Form1.balance = int.Parse(balance);
            MessageBox.Show(Convert.ToString("Your Current Account Balance Is $"+Form1.balance), "Balance");
        }
    }
}
