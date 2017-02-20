using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class InkPrinter : Printer
    {
        public override bool Print()
        {
            Console.WriteLine("Ink printer received the document, thanks");
            return true;
        }
    }
}
