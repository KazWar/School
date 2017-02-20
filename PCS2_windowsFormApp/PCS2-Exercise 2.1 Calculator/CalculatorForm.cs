using PCS2_Exercise_2._1_Calculator.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCS2_Exercise_2._1_Calculator
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
        }


        private void Calculator_Load(object sender, EventArgs e)
        {
            cbOperators.SelectedIndex = 0;
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            // type-cast the integer value into ArithmeticOperator enumeration
            var operation = (ArithmeticOperator)cbOperators.SelectedIndex;
        }
    }
}
