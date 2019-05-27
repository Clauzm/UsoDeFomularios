using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UsoDeFormularios.Clases;

namespace UsoDeFormularios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Text = "Uso de Formularios";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string palabra = txtPalabra.Text;

            for (int i = 0; i < palabra.Length; i++)
            {
                lstPalabras.Items.Add(palabra[i]);
            }

        }

        private void btnContar_Click(object sender, EventArgs e)
        {
            var contar = new Contar();
            var especiales = contar.ContarCaracteres(txtPalabra.Text);
           

            MessageBox.Show("La palabra: " + txtPalabra.Text + " tiene "
                + especiales + ((especiales == 1) ? " caracter especial " 
                : " caracteres especiales "));
        }
    }
}
