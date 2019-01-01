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
    public partial class FormTestDelegados : Form
    {
        public delegate void DelegadoString(string s);
        public event DelegadoString delegado;

        public FormTestDelegados()
        {
            InitializeComponent();
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            delegado(this.tbx_mostrar.Text);
        }
    }
}
