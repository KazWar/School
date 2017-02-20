using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int integerString;

            Console.Write("Enter one sequence of numbers (E.G. 532361): ");
            integerString = Convert.ToInt32(Console.ReadLine());

            while (integerString > 0)
            {
                var integer = integerString % 10;
                Console.Write("{0}, ", integer);
                integerString /= 10;
            }

            Console.WriteLine("\nPress any key to contine ...");
            Console.ReadKey();
        }
    }
}
