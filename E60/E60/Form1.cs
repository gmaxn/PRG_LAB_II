using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BibliotecaSQL;

namespace E60
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            Producto p = new Producto(this.tbx_nombre_producto.Text, int.Parse(this.tbx_numero_identificacion_producto.Text));
            bool cargaOk = p.Guardar();
            MessageBox.Show(string.Format("cargo producto: {0}", cargaOk));
        }
    }
}
