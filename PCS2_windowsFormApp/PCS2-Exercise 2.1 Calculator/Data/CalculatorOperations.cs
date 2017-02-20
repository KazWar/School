using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCS2_Exercise_2._1_Calculator.Data
{
    public class CalculatorOperations
    {
        public double Calculate(double value1, double value2, ArithmeticOperator operation)
        {
            var result = 0.0;
            switch (operation)
            {
                case ArithmeticOperator.Add:
                    result = value1 + value2;
                    break;
                case ArithmeticOperator.Subtract:
                    result = value1 - value2;
                    break;
                case ArithmeticOperator.Multiply:
                    result = value1 * value2;
                    break;
                case ArithmeticOperator.Divide:
                    result = value1 / value2;
                    break;
            }
            return result;
        }

    }
}
