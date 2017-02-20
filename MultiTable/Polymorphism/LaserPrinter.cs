using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class LaserPrinter: Printer
    {
        public override bool Print()
        {
            Console.WriteLine("Laser printer received the document, thanks!");
            return true;
        }
    }
}
