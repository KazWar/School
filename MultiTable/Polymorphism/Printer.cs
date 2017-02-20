using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public abstract class Printer
    {
        public string Document { get; set; }

        bool Preview()
        {
            return true;
        }

        public abstract bool Print();

        public bool Do()
        {
            if (Preview())
                return Print();
            else
                return false;
        }
    }
}
