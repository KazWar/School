using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlashyBackground
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void rotateColors()
        {
            var Random = new Random();
            this.BackColor = Color.FromArgb(Random.Next(0, 256), Random.Next(0, 256), Random.Next(0, 256));
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            colorTimer.Stop();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            colorTimer.Start();
        }

        private void btnChangeColor_Click(object sender, EventArgs e)
        {
            rotateColors();
        }

        private void colorTimer_Tick(object sender, EventArgs e)
        {
            rotateColors();
            var IntervalTime = colorTimer.Interval;
            if (IntervalTime > 1000)
            {
                colorTimer.Interval -= 1000;
            }
        }
    }
}
