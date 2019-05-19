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
    public partial class EjericiosCap5ejer4 : Form
    {
        public EjericiosCap5ejer4()
        {
            InitializeComponent();
        }

        private void CalcularButton_Click(object sender, EventArgs e)
        {
            float resultado = 1, i;

            float cantidad = float.Parse(CantidadTextBox.Text);

            for (i = 1; i <= cantidad; i++)
            {
                resultado = i * resultado;
            }
            resultadoTextBox.Text = resultado.ToString();
        }
    }
}
