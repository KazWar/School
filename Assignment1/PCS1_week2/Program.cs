using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCS1_week2
{
    class Program
    {
        static void Main(string[] args)
        {
            int rent;
            int phone;
            int cable;
            int utilities;
            int monthlyCost;
            int yearlyCost;

            Console.WriteLine("Please enter your costs for: ");

            Console.Write("For rent or mortgage payment: ");
            rent = Convert.ToInt32(Console.ReadLine());

            Console.Write("For phones: ");
            phone = Convert.ToInt32(Console.ReadLine());

            Console.Write("For cable: ");
            cable = Convert.ToInt32(Console.ReadLine());

            Console.Write("For utilities: ");
            utilities = Convert.ToInt32(Console.ReadLine());

            monthlyCost = rent + phone + cable + utilities;
            yearlyCost = monthlyCost * 12;

            Console.Write("\n");
            Console.WriteLine("Your monthly cost: {0}", monthlyCost);
            Console.WriteLine("Your annual cost: {0}", yearlyCost);
            Console.ReadKey();
        }
    }
}
