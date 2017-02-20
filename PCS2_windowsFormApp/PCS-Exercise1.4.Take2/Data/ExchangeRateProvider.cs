using PCS_Exercise1._4.Take2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCS_Exercise1._4.Take2.Data
{
    public class ExchangeRateProvider
    {
        public List<ExchangeRate> GetAll()
        {
            var rates = new List<ExchangeRate>() {
                new ExchangeRate()
                {
                    From = "EUR",
                    To = "GBP",
                    ConversionRatio = 0.9m
                },
                new ExchangeRate()
                {
                    From = "EUR",
                    To = "USD",
                    ConversionRatio = 1.1m
                },
                new ExchangeRate()
                {
                    From = "EUR",
                    To = "PLN",
                    ConversionRatio = 1.3m
                },
                new ExchangeRate()
                {
                    From = "EUR",
                    To = "CNY",
                    ConversionRatio = 1.3m
                },
                new ExchangeRate()
                {
                    From = "GBP",
                    To = "CNY",
                    ConversionRatio = 1.3m
                },
                new ExchangeRate()
                {
                    From = "CNY",
                    To = "GBP",
                    ConversionRatio = 0.7m
                },
                new ExchangeRate()
                {
                    From = "GBP",
                    To = "USD",
                    ConversionRatio = 1.3m
                },
                new ExchangeRate()
                {
                    From = "GBP",
                    To = "PLN",
                    ConversionRatio = 1.3m
                },
                new ExchangeRate()
                {
                    From = "USD",
                    To = "CNY",
                    ConversionRatio = 1.3m
                },
                new ExchangeRate()
                {
                    From = "USD",
                    To = "PLN",
                    ConversionRatio = 1.3m
                },
                new ExchangeRate()
                {
                    From = "USD",
                    To = "EUR",
                    ConversionRatio = 0.7m
                }
            };
            return rates;
        }

        public ExchangeRate Get(string from, string to)
        {
            ExchangeRate result = null;
            // if same currencies, just return 1
            if (from == to)
            {
                result = new ExchangeRate()
                {
                    From = from,
                    To = from,
                    ConversionRatio = 1m
                };
            }
            else
            {
                // otherwise find in the list of available conversion rates
                foreach (var rate in GetAll())
                {
                    if (rate.From == from && rate.To == to)
                    {
                        result = rate;
                    }
                }
            }
            return result;
        }

        public List<string> GetCurrencies()
        {
            var currencies = new List<string>();
            foreach (var rate in GetAll())
            {
                if (!currencies.Contains(rate.From))
                    currencies.Add(rate.From);
            }
            return currencies;
        }

        public decimal Convert(string from, string to, decimal amount)
        {
            var result = 0.0m;
            if (from != null && to != null && amount != 0)
            {
                var rate = Get(from, to);
                if (rate != null)
                {
                    result = amount * rate.ConversionRatio;
                }
            }
            return result;
        }
    }

}
