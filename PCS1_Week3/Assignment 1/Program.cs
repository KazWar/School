using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Possible to initialize a list of objects using a constructor to give a custom name?
            Car Audi = new Car("Audi", 25);
            Car Mercedes = new Car("Mercedes", 75);
            Car BMW = new Car("BMW", 54);
            Car Toyota = new Car("Toyota", 33);

            Console.WriteLine("Starting speed of {0} is:  {1} km/h",Audi.Model,Audi.Speed);
            Console.WriteLine("\nNow some speed changing ...\n");
            Console.WriteLine("After setting to 50, new speed of {0} is:  {1} km/h", Audi.Model, Audi.Speed = 50);
            Console.WriteLine("After setting to 51, new speed of {0} is:  {1} km/h", Audi.Model, Audi.Speed = 51);
            Console.WriteLine("After setting to -98, new speed of {0} is:  {1} km/h", Audi.Model, Audi.Speed = -98);
            Console.WriteLine("After setting to 698, new speed of {0} is:  {1} km/h", Audi.Model, Audi.Speed = 698);
            Console.WriteLine("After setting to 5, new speed of {0} is:  {1} km/h", Audi.Model, Audi.Speed = 5);

            Console.WriteLine("\nOther car models are: \n");
            Console.WriteLine("Model: {0}, speed: {1}", Mercedes.Model,Mercedes.Speed);
            Console.WriteLine("Model: {0}, speed: {1}", BMW.Model, BMW.Speed);
            Console.WriteLine("Model: {0}, speed: {1}", Toyota.Model, Toyota.Speed);


            Console.WriteLine("\nPress any key to continue ...");
            Console.ReadKey();
        }
    }
}
