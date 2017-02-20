using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double annualInterestRate;
            double monthlyInterestRate;
            int noMonthlyPayments;
            double loanAmount;
            double payment;
            decimal loanPaybackTotal;
            decimal loanInterest;

            Console.Write("Enter the annual interest rate: ");
            annualInterestRate = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the number of monthly payments: ");
            noMonthlyPayments = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the loan amount: ");
            loanAmount = Convert.ToInt32(Console.ReadLine());

            monthlyInterestRate = annualInterestRate / 12 / 100;
            payment = ((monthlyInterestRate * Math.Pow((1 + monthlyInterestRate), noMonthlyPayments)) / (Math.Pow((1 + monthlyInterestRate), noMonthlyPayments) - 1)) * loanAmount;
            loanPaybackTotal = noMonthlyPayments * Convert.ToDecimal(payment);
            loanInterest = loanPaybackTotal - Convert.ToDecimal(loanAmount);

            Console.WriteLine("\nLoan amount:                {0}",loanAmount);
            Console.WriteLine("Monthly Interest Rate:      {0}",monthlyInterestRate);
            Console.WriteLine("Number of monthly payments: {0}",noMonthlyPayments);
            Console.WriteLine("Monthly Payment:            {0}",Math.Round(payment,3));
            Console.WriteLine("Amount paid back:           {0}",Math.Round(loanPaybackTotal,2));
            Console.WriteLine("Interest Paid:              {0}",Math.Round(loanInterest,2));


            Console.ReadKey();

        }
    }
}
