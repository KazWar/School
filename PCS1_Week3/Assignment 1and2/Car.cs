using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1and2
{
    public class Car
    {
        public string Model { get; set; }
        public int Speed { get; set; }
        public string CarColor { get; set; }
        public int Mileage { get; set; }

        public Car (string model, int speed, string carColor, int mileage)
        {
            Model = model;
            Speed = speed;
            CarColor = carColor;
            Mileage = mileage;
        }

        public void Accelerate(int targetSpeed, int step)
        {
            while (Speed <= targetSpeed)
            {
                Speed += step;
                Console.WriteLine("After accelerating by {0}, new speed of {1} is: {2}",step, Model, Speed);
            }
        }
        public void Break(int targetSpeed, int step)
        {
            while (Speed >= targetSpeed)
            {
                Speed -= step;
                Console.WriteLine("After decelerating by {0}, new speed of {1} is: {2}",step, Model, Speed);
            }
        }
    }
}
