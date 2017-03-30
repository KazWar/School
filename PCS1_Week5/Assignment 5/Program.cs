using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6
{
    class Program
    {

        static void Main(string[] args)
        {
            int value;
            int result = 0;
            int result2;
            int i;
            int difference;

            do
            {
                Console.Write("Enter a value higher than 10:  ");
                value = Convert.ToInt32(Console.ReadLine());

            } while (value <= 10);

            for (i = 1; result < value; i++)
            {
                result += i;
            }

            Console.WriteLine("1 + 2 + 3 + ... + {0} equals {1}", i - 2, result2 = result - (i-1));
            Console.WriteLine("{0} is less than {1}", result, result2);
            Console.WriteLine("1 + 2 + 3 + ... + {0} equals {1}", i - 1, result);

            difference = result - result2;
            Console.WriteLine("");
            Console.WriteLine("So the value asked for is: {0}", i);
            

            Console.WriteLine("\n\nPress any key to continue...");
            Console.ReadKey();
        }

    }
}
