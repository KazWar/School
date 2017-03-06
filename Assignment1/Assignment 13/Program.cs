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
            Console.Write("Enter one sequence of numbers (E.G. 532361): ");
            string str = Console.ReadLine();
            for (int i = 0; i < str.Length; i++)
            {
                Console.Write("-" + str[i]);
            }

            //while (integerString > 0)
            //{
            //    var integer = integerString % 10;
            //    str = integer + ", " + str;
            //    integerString /= 10;
            //}
           

            Console.WriteLine("\nPress any key to contine ...");
            Console.ReadKey();
        }
    }
}
