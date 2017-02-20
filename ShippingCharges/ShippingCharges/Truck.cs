using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingCharges
{
    class Truck
    {
        ShippingCategory letter;
        public Truck()
        {
            letter = new ShippingCategory("Letter", 1, 0, 2.89m , 200);
        }
        public string Type { get; set; }
    }
}
