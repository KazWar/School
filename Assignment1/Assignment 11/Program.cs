using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int radius;
            double diameter;
            double circumReference;
            double area;

            Console.Write("Enter the radius of a circle numbers: ");
            radius = Convert.ToInt32(Console.ReadLine());

            diameter = 2 * radius;
            circumReference = 2 * radius * Math.PI;
            area = Math.PI * radius * radius;

            Console.WriteLine(@"The radius of the circle is: {0},
the diameter is:             {1},
the circumreference is:      {2},
the area is:                 {3}",radius ,Math.Round(diameter,3) ,Math.Round(circumReference,3) , Math.Round(area,3));

            Console.WriteLine("\nPress any key to contine ...");
            Console.ReadKey();
        }
    }
}
