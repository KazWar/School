using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCS2_windowsFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int A;
            int B;
            A = Convert.ToInt32(ValA.Text);
            B = Convert.ToInt32(ValB.Text);

            int Divided = ( A / B);
            int Modulo = (A % B);

            this.aDividedB.Text = Convert.ToString(Divided);
            this.AModuloB.Text = Convert.ToString(Modulo);
        }

        private void ValA_TextChanged(object sender, EventArgs e)
        {

        }

        private void ValB_TextChanged(object sender, EventArgs e)
        {

        }

        private void aDividedB_TextChanged(object sender, EventArgs e)
        {

        }

        private void AModuloB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
