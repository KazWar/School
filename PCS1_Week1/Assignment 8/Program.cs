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
            int x;
            int y;
            int z;
            int q;

            Console.Write("Please, enter a value for x: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nPlease, enter a value for y: ");
            y = Convert.ToInt32(Console.ReadLine());

            q = x;
            z = y;
            
            Console.WriteLine("\nYour initial values are x = {0} and {1}\n", x, y);
            Console.WriteLine("At the end: x = {0} and y = {1}", z, q);

            Console.ReadKey();
        }
    }
}
