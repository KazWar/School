using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_14
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sqrAndCubes = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("{0, 5}{1, 10}{2, 10}","x","square","cube");
            foreach (var number in sqrAndCubes)
            {
                Console.WriteLine("{0, 5}{1, 10}{2, 10}", number, Math.Pow(number,2), Math.Pow(number,3));
            }

            Console.WriteLine("\nPress any key to contine ...");
            Console.ReadKey();
        }
    }
}
