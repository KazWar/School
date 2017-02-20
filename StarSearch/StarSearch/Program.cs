using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Talent talent;
            talent = new Talent();

            Console.WriteLine("@Welcome to Star Search 2016!");
            Console.WriteLine("What is your name?");
            talent.FirstName = Console.ReadLine();
            
        }
    }
}
