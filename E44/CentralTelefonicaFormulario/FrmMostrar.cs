using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using E40;
using CentralTelefonicaFormulario;

namespace CentralTelefonicaFormulario
{
    public partial class FrmMostrar : Form
    {   // que sentido tiene que el form mostrar reciba la centralita si no tiene ningun evento
        // para llamar a sus metodos, mas coeherente seria que reciba un string en su constructor 
        // con la info a mostrar
        private Centralita centralita;
        public FrmMostrar(string text, Centralita c)
        {
            InitializeComponent();
            this.richTextBox1.Text = text;
            this.centralita = c;
        }

        private void btn_backToMain_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMenu menu = new FrmMenu(this.centralita);
            this.Close();
        }
    }
}
