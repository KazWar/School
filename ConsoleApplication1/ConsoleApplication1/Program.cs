using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string myName;
            int myBirthYear;
            int myAge;

            Console.WriteLine("What is your name?");
            myName = Console.ReadLine();
            Console.WriteLine("\nHi {0} how are you?", myName);
            Console.WriteLine("What is your year of birth?");

            myBirthYear = Convert.ToInt32(Console.ReadLine());
            myAge = 2016 - myBirthYear;
            Console.WriteLine("So you're {0} years old {1}", myAge, myName);
        }
    }
}
