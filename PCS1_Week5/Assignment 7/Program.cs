using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_7
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfAgentSales = new List<int>();
            List<string> listOfAgentNames = new List<string>();
            int agentNumber = 1;
            int input;

            do
            {
                Console.Write("Enter the amount of sold products for agent nr {0}: ", agentNumber);
                input = Convert.ToInt32(Console.ReadLine());

                if (input >= 0)
                {
                    listOfAgentSales.Add(input);
                    Console.Write("Enter the name of the agent nr {0}: ", agentNumber++);
                    listOfAgentNames.Add(Console.ReadLine());
                }
            } while (input >= 0);

            Console.WriteLine("Loser {0} sold {1} products!", listOfAgentNames.ElementAt(listOfAgentSales.IndexOf(listOfAgentSales.Min())), listOfAgentSales.Min());
            Console.WriteLine("Winner {0} sold {1} products!", listOfAgentNames.ElementAt(listOfAgentSales.IndexOf(listOfAgentSales.Max())), listOfAgentSales.Max());

            Console.WriteLine("\n\nPress any key to continue...");
            Console.ReadKey();
        }
    }
}
