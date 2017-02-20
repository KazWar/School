using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week6BankAcc
{
    public partial class FormBank : Form
    {
        List<BankAccount> myBank; 

        public FormBank()
        {
            InitializeComponent();
            myBank = new List<BankAccount>();

        }

        private void Create_Click(object sender, EventArgs e)
        {
            BankAccount newAccount =null;
            if (rbSavings.Checked)
            {
                 newAccount = new BankAccount(tbName.Text, AccountType.Savings);
            }
            if (rbChecking.Checked)
            {
                 newAccount = new BankAccount(tbName.Text, AccountType.Checking);
            }
            if (rbDeposito.Checked)
            {
                 newAccount = new BankAccount(tbName.Text, AccountType.Deposito);
            }

            myBank.Add(newAccount);
            ShowMyBankAccounts();
        }

        private void ShowMyBankAccounts()
        {
            lbAccounts.Items.Clear();
            foreach (BankAccount b in myBank)
            {
                lbAccounts.Items.Add(b.Info());
            }
        }

        private void bDeposit_Click(object sender, EventArgs e)
        {
            // is an item selected?
               if (lbAccounts.SelectedIndex == -1)
            {
                MessageBox.Show("First select a bankaccount please");
            }
               else
            {
                // do the actual deposit
                myBank[lbAccounts.SelectedIndex].Deposit(Convert.ToDouble(tbAmount.Text));
                ShowMyBankAccounts();

                ////alternative
                //BankAccount b = myBank[lbAccounts.SelectedIndex];
                //b.Deposit(Convert.ToDouble(tbAmount.Text));

            }
            
        }

        private void bWithdraw_Click(object sender, EventArgs e)
        {
            // is an item selected?
            if (lbAccounts.SelectedIndex == -1)
            {
                MessageBox.Show("First select a bankaccount please");
            }
            else
            {
                // do the actual deposit
                myBank[lbAccounts.SelectedIndex].Withdraw(Convert.ToDouble(tbAmount.Text));
                ShowMyBankAccounts();
            }
        }

        private void bInterest_Click(object sender, EventArgs e)
        {
            foreach (var Account in myBank)
            {
                Account.GiveInterest();
            }
            ShowMyBankAccounts();
        }
    }
}
