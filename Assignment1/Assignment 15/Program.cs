using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_15
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            List<int> listOfIntegers = new List<int>();

            Console.Write("Enter 5 numbers: ");
            for (int i = 0; i < 5; i++)
            {
                a = Convert.ToInt32(Console.ReadLine());
                listOfIntegers.Add(a);
            }

            listOfIntegers.Count()

            Console.WriteLine("\nPress any key to contine ...");
            Console.ReadKey();
        }
    }
}
