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
            int gasTank = 20;
            double distTownPerGall = 21.5;
            double distHighwPerGall = 26.8;
            double totalDistanceTown;
            double totalDistanceHighw;

            totalDistanceTown = gasTank * distTownPerGall;
            Console.WriteLine("Distance the car can travel in a town: {0}", totalDistanceTown);

            totalDistanceHighw = gasTank * distHighwPerGall;
            Console.WriteLine("Distance the car can travel on a highway: {0}\n", totalDistanceHighw);
            Console.WriteLine("Press any key to continue ...");
            Console.ReadKey();
        }
    }
}
