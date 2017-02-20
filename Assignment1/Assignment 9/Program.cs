using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;

            Console.Write("Enter one number: ");
            a = Convert.ToInt32(Console.ReadLine());

            a = a % 2;

            if (a == 0)
            {
                Console.WriteLine("The number is even, outcome is {0}",a);
            }
            else
            {
                Console.WriteLine("The number is uneven, outcome is {0}",a);
            }

            Console.WriteLine("\nPress any key to contine ...");
            Console.ReadKey();
        }
    }
}
