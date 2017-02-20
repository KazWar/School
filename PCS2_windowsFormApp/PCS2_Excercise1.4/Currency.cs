using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCS2_Excercise1._4
{
    class Currency
    {
        public int value1;
        public int value2;
        int exchangeRate;

        public int Value1
        {
            get { return value1; }
            set { value1 = ; }
        }
        public int Value2
        {
            get { return value2; }
            set { value2 = ; }
        }

        public string CurrencyName { get; set; }
        public double CurrencyExchangeRate { get; set; }
        
        public Currency (string currencyName, double currencyExchangeRate)
        {
            CurrencyName = currencyName;
            CurrencyExchangeRate = currencyExchangeRate;
        }
        public Currency()
        {

        }
    }
}
