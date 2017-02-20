using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount bankaccount;
            bankaccount = new BankAccount();

            bankaccount.AccountNumber = 138039;
            bankaccount.FirstName = "Kazik";

            Console.WriteLine(bankaccount.AccountNumber);
            Console.WriteLine(bankaccount.FirstName);

            Console.ReadKey();

        }
    }
}
