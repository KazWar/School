using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;
            int d;
            int e;

            Console.Write("Enter five integer values (E.G. 56,32,45,65,23), press enter after each value:\n");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            d = Convert.ToInt32(Console.ReadLine());
            e = Convert.ToInt32(Console.ReadLine());

            int[] numbers = { a, b, c, d, e };

            Console.WriteLine("\nThe sum of the 5 integers is {0}", numbers.Sum());
            Console.WriteLine("The average of the 5 integers is {0}", numbers.Average());
            Console.WriteLine("The product of the 5 integers is {0}", numbers.Aggregate((x,y) => x * y));
            Console.WriteLine("The smallest of the 5 integers is {0}", numbers.Min());
            Console.WriteLine("The largest of the 5 integers is {0}", numbers.Max());

            Console.WriteLine("\nPress any key to contine ...");
            Console.ReadKey();
        }
    }
}
