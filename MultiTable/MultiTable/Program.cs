using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiTable
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice;
            int numChoice;
            do
            {
                Console.Clear();
                Console.WriteLine("What method type do you want to use?");
                Console.WriteLine("1 = FOR method, 2 = WHILE method, 3 = DO method, 4 = Stop");
                choice = Console.ReadLine();
                if (Int32.TryParse(choice, out numChoice))
                {
                    switch (numChoice)
                    {
                        case 1:
                            forMethod.forLoop();
                            break;
                        case 2:
                            whileMethod.whileLoop();
                            break;
                        case 3:
                            doMethod.doLoop();
                            break;
                        case 4:
                            break;
                        default:
                            Console.WriteLine("Please input a number lower than 5.");
                            break;
                    }
                } else {
                    Console.WriteLine("Enter a number.....");
                }

                if (numChoice != 4)
                {
                    Console.WriteLine();
                    Console.WriteLine("Press ENTER to return to menu ...");
                    Console.ReadLine();
                }
            } while (numChoice != 4);
        }
    }
}

