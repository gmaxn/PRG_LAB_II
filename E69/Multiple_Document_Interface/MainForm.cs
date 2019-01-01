using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multiple_Document_Interface
{
    public partial class MainForm : Form
    {
        private FormTestDelegados frmDelegados;
        private FormDatos frmDatos;

        public MainForm()
        {
            InitializeComponent();
        }

        private void ParentForm_Load(object sender, EventArgs e)
        {
        }

        private void testDelegadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDelegados = new FormTestDelegados();
            frmDelegados.MdiParent = this;
            frmDelegados.Show();
            MessageBox.Show("ingrese un nombre en TextBox de Form Test Delegados y pulse el botón btnActualizar");
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDatos = new FormDatos();
            frmDelegados.delegado += frmDatos.ActualizarNombre;
            frmDatos.MdiParent = this;
            frmDatos.Show();
        }
    }
}
