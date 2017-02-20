using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            int height;
            int weight;

            Console.WriteLine("Hello!");

            Console.Write("Please, enter your age: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nPlease, enter your height: ");
            height = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nPlease, enter your weight: ");
            weight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nYou are {0} years old, you are {1} tall and your weight is {2} kg. \n", age ,height ,weight);
            Console.WriteLine("Enter any key to continue ...");
            Console.ReadKey();
        }
    }
}
