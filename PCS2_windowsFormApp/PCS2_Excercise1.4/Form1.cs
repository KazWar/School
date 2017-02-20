using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCS2_Excercise1._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public decimal exchangeRateValue
        {
            get { return exchangeRateValue;}
            set { exchangeRateValue = Convert.ToDecimal(numericUpDown1); }
        }
        
        private void ConvertTo_Click( object sender, EventArgs e)
        {
            var result = value1 * value2;
            this.textBoxValue2.Text = Convert.ToString(result);
        }
        protected void convertFrom_Click(object sender, EventArgs e)
        {
            var currency = new Currency();
            var result = currency.Euro * currency.Euro;
            this.textBoxValue2.Text = Convert.ToString(result);
        }
        protected void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
        public void textBoxValue1_TextChanged(object sender, EventArgs e)
        {
            
        }
        public int textBoxValue2_TextChanged(object sender, EventArgs e)
        {
            int valueTextBox2;
            valueTextBox2 = Convert.ToInt32(this.textBoxValue2.Text);
            return valueTextBox2;
        }

        protected void currencyDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*MessageBox.Show(Convert.ToString(comboBox1.SelectedIndex));
             0 = Dollar,1 = Yuan, 2 = Pound, 3 = Złoty */
        }

        /*Currency letter;
        public ()
        {
            letter = new Currency("Letter", 1);
        }*/
    }
}
