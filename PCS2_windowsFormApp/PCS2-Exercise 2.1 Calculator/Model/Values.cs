using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCS2_Exercise_2._1_Calculator.Data
{
    public class Values
    {
        public int operAnd1 { get; set; }
        public int operAnd2 { get; set; }
        public char operatorChoice { get; set; }


        public Values()
        {

        }
        public Values(char OperatorChoice)
        {
            OperatorChoice = operatorChoice;
        }

    }
}
