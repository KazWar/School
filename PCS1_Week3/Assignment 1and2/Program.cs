using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1and2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] carInformation = new string[4];
            int kmh;
            int targetSpeed;

            Console.WriteLine("Please provide the following car information.\n");

            Console.Write("Car model: ");
            carInformation[0] = Console.ReadLine();

            Console.Write("Car starting speed: ");
            carInformation[1] = Console.ReadLine();

            Console.Write("Car color: ");
            carInformation[2] = Console.ReadLine();

            Console.Write("Car mileage: ");
            carInformation[3] = Console.ReadLine();

            Car Car = new Car(carInformation[0], Convert.ToInt32(carInformation[1]), carInformation[2], Convert.ToInt32(carInformation[3]));
            Console.WriteLine("Your car is a {0}, has the color {1}, a start speed of {2} km/h and a mileage of {3} kilometers", Car.Model, Car.CarColor, Car.Speed, Car.Mileage);

            Console.Write("\nHow much km/h does the car go?: ");
            kmh = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nHow fast does the car need to go?: ");
            targetSpeed = Convert.ToInt32(Console.ReadLine());

            Car.Accelerate(targetSpeed, kmh);
            Car.Break(Convert.ToInt32(carInformation[1]), kmh);
            Car.Accelerate(70, kmh);
            Car.Break(12, 5);

            Console.WriteLine("\nPress any key to continue ...");
            Console.ReadKey();


        }

    }
}
