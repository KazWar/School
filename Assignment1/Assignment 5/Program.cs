using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double exchangeRate;
            int amountToExchange;
            decimal exchangedAmount;
            bool isValid = false;

            Console.Write("Enter the exchange rate (how many dollars do I get for 1 euro?): ");
            exchangeRate = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter 1 if you want to convert euros to dollars.");
            Console.WriteLine("Enter 2 if you want to convert dollars to euros.");

            while(!isValid)
            {
                Console.Write("\nEnter your choice now: ");
                var keyChoice = Console.ReadKey();

                switch (keyChoice.Key)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine("\n\nEuros to Dollars conversion.");
                        Console.Write("Enter the amount of money you want to exchange: ");
                        amountToExchange = Convert.ToInt32(Console.ReadLine());

                        exchangedAmount = Convert.ToDecimal(amountToExchange * exchangeRate);
                        Console.WriteLine("\nYou get {0} dollars for {1} euros.", Math.Round(exchangedAmount, 2),amountToExchange);

                        isValid = true;
                        break;

                    case ConsoleKey.D2:
                        Console.WriteLine("\n\nDollars to euros conversion.");
                        Console.Write("Enter the amount of money you want to exchange: ");
                        amountToExchange = Convert.ToInt32(Console.ReadLine());

                        exchangedAmount = Convert.ToDecimal(amountToExchange / exchangeRate);
                        Console.WriteLine("\n\nYou get {0} euros for {1} dollars.", Math.Round(exchangedAmount,2), amountToExchange);

                        isValid = true;
                        break;

                    default:
                        Console.WriteLine("\nPress either 1 or 2 to continue ...");
                        break;
                }
            }

            Console.WriteLine("\nPress any key to continue ...");
            Console.ReadKey();
        }
    }
}
