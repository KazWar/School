using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            double c;

            Console.Write("Enter two numbers: \n");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

            c = (double)b / a;

            if (c * a == b)
            {
                Console.WriteLine("The 2nd number is is a multiple of the 1st number, outcome is {0}", c);
            }
            else
            {
                Console.WriteLine("The 2nd number is not a multiple of the 1st number, outcome is {0}", Math.Round(c,3));
            }

            Console.WriteLine("\nPress any key to contine ...");
            Console.ReadKey();
        }
    }
}
