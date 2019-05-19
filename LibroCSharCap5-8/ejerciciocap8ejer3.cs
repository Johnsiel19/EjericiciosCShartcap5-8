using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibroCSharCap5_8
{
    public partial class ejerciciocap8ejer3 : Form
    {
        public ejerciciocap8ejer3()
        {
            InitializeComponent();
            timer1.Enabled = true;

        }

        private void Ejerciciocap8ejer3_Load(object sender, EventArgs e)
        {
       
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString("hh:mm tt yyyy/dd/MM");
        }
    }
}
