using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Multiple_Document_Interface
{
    public partial class FormTestDelegados : Form
    {
        public delegate void DelegadoString(string s);
        public event DelegadoString delegado;
        public event DelegadoString delegado2;
        private string ruta;

        public FormTestDelegados()
        {
            InitializeComponent();
            this.openFieleDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            if (this.tbx_mostrar.Text != null)
                delegado(this.tbx_mostrar.Text);
            if (this.ruta != "")
                delegado2(this.ruta);
        }

        private void btn_buscarFoto_Click(object sender, EventArgs e)
        {
            this.openFieleDialog.ShowDialog();
            ruta = this.openFieleDialog.FileName;
            //this.delegado2(ruta);
        }
    }
}
