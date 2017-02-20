using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCS2_Excercise_bankAccount
{
    public class BankAccount
    {
        public string Name { get; set; }
        public int AccountNumber { get; set; }
        public double Balance { get; private set; }

        public BankAccount(string BankAccountOwner, double BankAccountBalance)
        {
            Name = BankAccountOwner;
            Balance = BankAccountBalance;
        }

        public BankAccount()
        {

        }

        public void Withdraw(double amount)
        {
            this.Balance = this.Balance - amount;
        }
    }
}
