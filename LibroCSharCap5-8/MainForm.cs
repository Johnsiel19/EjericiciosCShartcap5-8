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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Eje1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ejer1 frm = new ejer1();
            frm.Show();

        }

        private void Cap5ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Eje3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ejerciciocap8ejer3 frm = new ejerciciocap8ejer3();
            frm.Show();
        }

        private void Ejer5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ejerciciocap8ejer5 frm = new ejerciciocap8ejer5();
            frm.Show();
        }

        private void Ejer5ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ejerciciocap7ejer5 frm = new ejerciciocap7ejer5();
            frm.Show();
        }

        private void Ejer4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EjericiosCap5ejer4 frm = new EjericiosCap5ejer4();
            frm.Show();
        }
    }
}
