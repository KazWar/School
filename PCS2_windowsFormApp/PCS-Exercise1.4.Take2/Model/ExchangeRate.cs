using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCS_Exercise1._4.Take2.Model
{
    public class ExchangeRate
    {
        public ExchangeRate()
        {
            ConversionRatio = 1;
        }

        public string From { get; set; }
        public string To { get; set; }
        public decimal ConversionRatio { get; set; }
    }
}
