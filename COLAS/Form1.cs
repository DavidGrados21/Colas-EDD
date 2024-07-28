using COLAS.EJERCICIO_C1;
using COLAS.EJERCICIO_C3;
using COLAS.EJERCICIO_C4;
using COLAS.EJERCICIO_C5;
using COLAS.EJERCICIO_C6;
using COLAS.EJERCICIO_C7;
using COLAS.EJERCICIO_C8;
using COLAS.EJERCICIO_C9;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COLAS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGrupo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Los integrantes son\n" +
    "\n- ARNOLD EMILIO CHOMBA SUAREZ" +
    "\n- DEYBY MAURICIO GRADOS SHUPINGAHUA" +
    "\n- KATHERINE LISBETH LLACCOLLA GAMBOA" +
    "\n- LAURA THALIA GARCIA LUJAN", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnC1_Click(object sender, EventArgs e)
        {
            Form ventana = new C1();
            ventana.Show();
        }

        private void btnC3_Click(object sender, EventArgs e)
        {
            Form ventana = new C3();
            ventana.Show();
        }

        private void btnC4_Click(object sender, EventArgs e)
        {
            Form ventana = new C4();
            ventana.Show();
        }

        private void btnC5_Click(object sender, EventArgs e)
        {
            Form ventana = new C5();
            ventana.Show();
        }

        private void btnC6_Click(object sender, EventArgs e)
        {
            Form ventana = new C6();
            ventana.Show();
        }

        private void btnC7_Click(object sender, EventArgs e)
        {
            Form ventana = new C7();
            ventana.Show();
        }

        private void btnC8_Click(object sender, EventArgs e)
        {
            Form ventana = new C8();
            ventana.Show();
        }

        private void btnC9_Click(object sender, EventArgs e)
        {
            Form ventana = new C9();
            ventana.Show();
        }
    }
}
