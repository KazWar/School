using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int PCS1;
            int PCS2;
            int PCS3;
            int PCS4;
            int total;

            Console.WriteLine("Hello!\n");
            Console.WriteLine("Calculate the total PCS EC's for an ICT student: PCS1 + PCS2 + PCS3 + PCS4");
            Console.WriteLine("For each PCS course a student can earn either: ");
            Console.WriteLine("         3 EC's (passed the exam) or");
            Console.WriteLine("         0 EC's (failed the exam).\n");

            Console.Write("Please, enter a value for PCS1: ");
            PCS1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nPlease, enter a value for PCS2: ");
            PCS2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nPlease, enter a value for PCS3: ");
            PCS3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nPlease, enter a value for PCS4: ");
            PCS4 = Convert.ToInt32(Console.ReadLine());

            total = PCS1 + PCS2 + PCS3 + PCS4;

            Console.WriteLine("\nBased on the earned EC's for PCS1 ({0}), PCS2 ({1}), PCS3 ({2}), and PCS4 ({3}), the total earned EC's for PCS is ({4})! \n", PCS1, PCS2, PCS3, PCS4, total);
            Console.WriteLine("Enter any key to continue ...!");
            Console.ReadKey();


        }
    }
}
