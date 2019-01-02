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
            frmDelegados = new FormTestDelegados();
            frmDelegados.MdiParent = this;
            frmDatos = new FormDatos();
            //frmDatos.MdiParent = this;

        }

        private void ParentForm_Load(object sender, EventArgs e)
        {
            frmDelegados.delegado += frmDatos.ActualizarNombre;
            frmDelegados.delegado2 += frmDatos.ActualizarFoto;
        }

        private void testDelegadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(frmDelegados == null)
            {
                frmDelegados = new FormTestDelegados();
                frmDelegados.MdiParent = this;
                frmDelegados.delegado += frmDatos.ActualizarNombre;
                frmDelegados.delegado2 += frmDatos.ActualizarFoto;
            }
            frmDelegados.Show();
            MessageBox.Show("ingrese un nombre en TextBox de Form Test Delegados y pulse el botón btnActualizar");
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(frmDatos.IsDisposed)
            {
                frmDatos = new FormDatos();
                //frmDatos.MdiParent = this;
            }
            frmDatos.Show();
        }
    }
}
