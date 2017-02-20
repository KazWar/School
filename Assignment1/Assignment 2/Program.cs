using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal purchase;
            decimal priceSaleTax;
            decimal priceCountryTax;
            decimal saleTax = 0.04m;
            decimal countryTax = 0.02m;
            decimal totalTax;

            Console.Write("Enter the purchase amount: ");
            purchase = Convert.ToDecimal(Console.ReadLine());

            priceSaleTax = purchase * saleTax;
            Console.WriteLine("Sale tax is: {0}", priceSaleTax);

            priceCountryTax = purchase * countryTax;
            Console.WriteLine("Country tax is: {0}", priceCountryTax);

            totalTax = priceCountryTax + priceSaleTax;
            Console.WriteLine("Total tax is: {0}\n", totalTax);
            Console.WriteLine("Enter any key to continue ...");
            Console.ReadKey();
        }
    }
}
