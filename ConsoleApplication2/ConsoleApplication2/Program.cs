using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create new object using the class template
            car myCar;
            myCar = new car();

            myCar.Model = "Audi";
            myCar.Speed = Convert.ToInt32("25");
            Console.WriteLine(myCar.Model);

            Console.WriteLine(myCar.Speed);

            Console.ReadKey();
            
        }
    }
}
