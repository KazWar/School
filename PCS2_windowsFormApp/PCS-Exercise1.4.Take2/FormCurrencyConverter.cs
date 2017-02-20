using PCS_Exercise1._4.Take2.Data;
using PCS_Exercise1._4.Take2.Model;
using System;
using System.Windows.Forms;

namespace PCS_Exercise1._4.Take2
{
    public partial class FormCurrencyConverter : Form
    {
        ExchangeRate userExchangeRate = new ExchangeRate();
        public FormCurrencyConverter()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var rateProvider = new ExchangeRateProvider();
            var currencies = rateProvider.GetCurrencies();
            foreach (var currency in currencies)
            {
                listFromCurrency.Items.Add(currency);
                listToCurrency.Items.Add(currency);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            FormAbout form = new FormAbout();
            form.Show();
        }

        private void btnTo_Click(object sender, EventArgs e)
        {
            if (listFromCurrency.SelectedItem != null && listToCurrency.SelectedItem != null)
            {
                var rateProvider = new ExchangeRateProvider();
                textToAmount.Value = rateProvider.Convert(listFromCurrency.SelectedItem.ToString(), listToCurrency.SelectedItem.ToString(), textFromAmount.Value);

            }
        }

        private void btnFrom_Click(object sender, EventArgs e)
        {
            if (listFromCurrency.SelectedItem != null && listToCurrency.SelectedItem != null)
            {
                var rateProvider = new ExchangeRateProvider();
                textFromAmount.Value = rateProvider.Convert(listToCurrency.SelectedItem.ToString(), listFromCurrency.SelectedItem.ToString(), textToAmount.Value);
            }
        }

        private void listCurrencyFrom_SelectedValueChanged(object sender, EventArgs e)
        {
            textConversionToRatio.Value = 0.0m;
            textConversionFromRatio.Value = 0.0m;

            if (listFromCurrency.SelectedItem != null && listToCurrency.SelectedItem != null)
            {
                var rateProvider = new ExchangeRateProvider();
                var fromCurrency = listFromCurrency.SelectedItem.ToString();
                var toCurrency = listToCurrency.SelectedItem.ToString();

                var rate = rateProvider.Get(fromCurrency, toCurrency);
                if (rate != null)
                {
                    textConversionToRatio.Value = rate.ConversionRatio;
                }

                rate = rateProvider.Get(toCurrency, fromCurrency);
                if (rate != null)
                {
                    textConversionFromRatio.Value = rate.ConversionRatio;
                }
            }
        }
    }
}
