using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;

            Console.Write("Enter three integer values (E.G. 56,32,45): \n");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());


            if (a == b & a == c)
            {
                Console.WriteLine("The maximal value is {0}", a);
            } else {
                Console.WriteLine("The maximal value is {0}", Math.Max(Math.Max(a, b), c));
            }

            Console.WriteLine("\nPress any key to contine ...");
            Console.ReadKey();
        }
    }
}
