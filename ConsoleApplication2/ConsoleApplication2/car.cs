using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class car
    {
        private int speed;
        private string model;

        public string Model
        {
            get { return model;}
            set { model = value; }
        }

        public int Speed
        {
            get { return speed;}
            set {
                if (speed>=0)
                    speed = value;
            }
        }

    }
}
