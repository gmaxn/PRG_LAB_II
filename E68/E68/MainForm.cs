using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E68
{
    public partial class MainForm : Form
    {
        private Persona p;
        private event DelegadoString ds;

        public MainForm()
        {
            InitializeComponent();
        }

        public void NotificarCambio(string msg)
        {
            MessageBox.Show(msg);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ds += NotificarCambio;
        }

        private void btn_crear_Click(object sender, EventArgs e)
        {
            if(p == null)
            {
                p = new Persona(tbx_nombre.Text, tbx_apellido.Text);
                this.btn_crear.Text = "Actualizar";
                ds("se ha creado una persona");

            }
            else if (p != null)
            {
                this.p.Nombre = tbx_nombre.Text;
                this.p.Apellido = tbx_apellido.Text;
                ds("se han modificado nombre y apellido");
            }

            MessageBox.Show(p.Mostrar());
        }
    }
}
