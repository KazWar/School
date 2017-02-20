using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCS2_Excercise_bankAccount
{
    public class Methods
    {
        public double Withdraw(int AccountNumber, double WithdrawValue = 0)
        {
            var BankAccount = new BankAccount();

            double NewBalance = BankAccount.Balance - WithdrawValue;

            // 1. Read current Balance
            // 2. Read given input
            // 3. Deduct input from Balance
            // 4. Return NEW balance
            return NewBalance;
        }

        public void Deposit ()
        {
            /*
             1. Read current balance
             2. Read given input
             3. Check validity of the input (Whether it's not negative)
             4. Add input to balance
             5. Return new Balance
             */
        }

        public void CreateBankAccount(string Accountname, double Balance = 0)
        {
            var BankAccount = new BankAccount();
            // 1. Read given inputs (Name + optional start balance)
            // 2. Auto Generate Account Number add it to the account
            // 3. Return object with
        }
    }
}
