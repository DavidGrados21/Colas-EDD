﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COLAS.EJERCICIO_C7
{
    public partial class C7 : Form
    {
        cola7 cola = new cola7();
        PilaC7 pila = new PilaC7();
        public C7()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                string numero = txtNumero.Text;
                int n = numero.Length;
                if (n != 0)
                {
                    if (pila.Palindromo(numero, n, pila, cola))
                    {
                        MessageBox.Show("La palabra es Palindroma", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtNumero.Clear();
                        txtNumero.Focus();

                    }
                    else
                    {
                        MessageBox.Show("La palabra no es Palindroma", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtNumero.Clear();
                        txtNumero.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Por favor introduca un caracter valido", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNumero.Clear();
                    txtNumero.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Hubo un error", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNumero.Clear();
                txtNumero.Focus();
            }
        }
    }
}
