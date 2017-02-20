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
            string one = "Welcome   to  ";
            string two = "Fontys   ";
            string three = "ICT   in    ";
            string four = "Eindhoven";

            Console.WriteLine("Welcome  to  Fontys  ICT in  Eindhoven.\n");

            Console.Write("Welcome  ");
            Console.Write("to  ");
            Console.Write("Fontys  ");
            Console.Write("ICT  ");
            Console.Write("in  ");
            Console.Write("Eindhoven\n  ");

            Console.WriteLine("\n{0}{1}{2}{3}",one ,two ,three ,four);
            Console.ReadKey();
        }
    }
}
