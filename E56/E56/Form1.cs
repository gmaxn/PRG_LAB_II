using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MiBiblioteca;

namespace E56
{
    public partial class Form1 : Form
    {
        private string rutaArchivoActual;
        public Form1()
        {
            InitializeComponent();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            rutaArchivoActual = ofd.FileName;

            rtb_texto.Text = ArchivoTexto.Leer(rutaArchivoActual);
        }

        private void guardarCtrlSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rutaArchivoActual == null)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                if(sfd.ShowDialog() == DialogResult.Yes)
                {
                    ArchivoTexto.Guardar(rutaArchivoActual, rtb_texto.Text, false);
                }
                rutaArchivoActual = sfd.FileName;
            }
            else
            {
                ArchivoTexto.Guardar(rutaArchivoActual, rtb_texto.Text, true);
            }
        }
    }
}
