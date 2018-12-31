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


namespace FrmContadorDePalabras
{
    public partial class Form1 : Form
    {
        private string rutaArchivoActual;
        int cursorPosition;
        public Form1()
        {
            InitializeComponent();
            this.tssl_numberOfChars.Text = "caracteres: 0 - " + this.rutaArchivoActual;
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "txt files (*.txt)|*.txt|dat files (*.dat)|*dat|All files (*.*)|*.*";
            ofd.ShowDialog();
            rutaArchivoActual = ofd.FileName;

            rtb_texto.Text = ArchivoTexto.Leer(rutaArchivoActual);
        }

        private void guardarCtrlSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rutaArchivoActual == null)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "txt files (*.txt)|*.txt|dat files (*.dat)|*dat|All files (*.*)|*.*";

                sfd.ShowDialog();
                rutaArchivoActual = sfd.FileName;
                ArchivoTexto.Guardar(rutaArchivoActual, rtb_texto.Text, false);
            }
            else
            {
                ArchivoTexto.Guardar(rutaArchivoActual, rtb_texto.Text, true);
            }
        }

        private void rtb_texto_TextChanged(object sender, EventArgs e)
        {
            this.tssl_numberOfChars.Text = string.Format("caracteres: {0} - {1}", rtb_texto.Text.Length, this.rutaArchivoActual);
        }

        private void guardarComoCtrlMayúsSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "txt files (*.txt)|*.txt|dat files (*.dat)|*dat|All files (*.*)|*.*";
            sfd.ShowDialog();
            rutaArchivoActual = sfd.FileName;
            ArchivoTexto.Guardar(rutaArchivoActual, rtb_texto.Text, false);

        }
    }
}
