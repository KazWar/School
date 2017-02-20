using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingCharges
{
    class Program
    {
        static void Main(string[] args)
        {
            var s1 = new ShippingCategory();
            s1.CategoryName = "abc";

            var s2 = new ShippingCategory("abc", 1, 2, 3, 4);
        }
    }
}
