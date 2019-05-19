using System;
using System.Collections;
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
    public partial class ejerciciocap8ejer5 : Form
    {
        public ejerciciocap8ejer5()
        {
            InitializeComponent();
        }

        private void Ejerciciocap8ejer5_Load(object sender, EventArgs e)
        {


        }

        private void Button1_Click(object sender, EventArgs e)
        {


            ArrayList array = new ArrayList();
            array.Add(textBox1.Text);
            array.Add(textBox2.Text);
            array.Sort();

            int i = 0;
            foreach (String cadena in array)
            {
                Console.WriteLine("{0}", cadena);
                if (i == 0)
                {

                    textBox3.Text = cadena;
                }
                else
                {
                    textBox4.Text = cadena;

                }
                i = 1;
            
            }
                
         }
    }
}
