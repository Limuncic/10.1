using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10._1_Rafael
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void trb1_Scroll(object sender, EventArgs e)
        {
            trb1.Minimum = 0;
            trb1.Maximum = 100;
            trb1.LargeChange = 1;

            tb1.Text = trb1.Value.ToString();
        }
    }
}
