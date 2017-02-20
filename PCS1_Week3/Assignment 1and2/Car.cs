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

        public Car (string model, int speed)
        {
            model = this.Model;
            speed = this.Speed;
        }
    }
}
