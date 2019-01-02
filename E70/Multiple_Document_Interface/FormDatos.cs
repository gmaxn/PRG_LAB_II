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
    public partial class FormDatos : Form
    {
        public FormDatos()
        {
            InitializeComponent();
        }

        public void ActualizarNombre(string nombre)
        {
            this.lbl_nombre.Text = nombre;
        }

        public void ActualizarFoto(string ruta)
        {
            this.pbx_imagen.ImageLocation = ruta;
        }

    }
}
