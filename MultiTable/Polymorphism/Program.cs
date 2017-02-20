using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer printer;
            printer = new LaserPrinter()
            {
                Document = "abc"
            };
            printer.Do();
            printer = new InkPrinter();
            printer.Do();
            Console.ReadLine();
        }
    }
}
