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
    public partial class ejerciciocap7ejer5 : Form
    {
        public ejerciciocap7ejer5()
        {
            InitializeComponent();
        }
        int cont = 0;
        string[] telefono = new string[100];
        string[] nombre = new string[100];
        private void Button1_Click(object sender, EventArgs e)
        {

            telefono[cont] = txtTelefono.Text ;
           nombre[cont]= txtNombre.Text ;

            txtNombre.Text = string.Empty;
            txtTelefono.Text = string.Empty;


            cont++;


        }
        
        private void Button2_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < cont; i++){
                if (nombre[i]== busqueda.Text)
                {
                    textBox4.Text = nombre[i];
                    textBox5.Text = telefono[i];

                }
            }
            
        }
    }
}
