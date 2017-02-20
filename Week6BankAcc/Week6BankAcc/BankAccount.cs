using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6BankAcc
{
    class BankAccount
    {
        private static int nextNumber = 36282;

        public int AccountNumber { get; private set; }
        public AccountType AccType { get; private set; }
        public string Name { get; set; }
        public double Balance { get;  private set; }
        public static double Interest = 1.05;

        public BankAccount(string name,AccountType at)
        {
            this.AccountNumber = nextNumber++;
            this.Name = name;
            this.Balance = 0;
            this.AccType = at;
        }

        public void Deposit(double amount)
        {
            this.Balance += amount;
        }

        public void GiveInterest()
        {
            Balance = Balance * Interest;
        }

        public void Withdraw( double amount)
        {
            this.Balance -= amount;
        }

        public string Info()
        {
            return this.Name + " " + this.AccountNumber.ToString() + this.AccType.ToString() +" : " + this.Balance.ToString();
        }

        public BankAccount()
        {

        }

    }
}
