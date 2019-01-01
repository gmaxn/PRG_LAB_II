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

namespace E61
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            Persona p = new Persona(tbx_nombre.Text, tbx_apellido.Text);
            bool msj;
            msj = p.Guardar();
            MessageBox.Show(string.Format("{0}", msj == true ? "persona cargada" : "no se puedo cargar"));
            lbx_personas.Items.Add(p);
        }

        private void btn_leer_Click(object sender, EventArgs e)
        {
            lbx_personas.Items.Clear();
            List<Persona> lista = PersonaDAO.ObtenerPersonas();

            foreach(Persona p in lista)
            {
                lbx_personas.Items.Add(p);
            }
           

        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            PersonaDAO.ModificaPersona((Persona)lbx_personas.SelectedItem, new Persona(tbx_nombre.Text, tbx_apellido.Text));
            lbx_personas.Items.Clear();
            List<Persona> lista = PersonaDAO.ObtenerPersonas();
            foreach (Persona p in lista)
            {
                lbx_personas.Items.Add(p);
            }
        }
    

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            PersonaDAO.EliminaPersona((Persona)lbx_personas.SelectedItem);
            lbx_personas.Items.Clear();
            List<Persona> lista = PersonaDAO.ObtenerPersonas();
            foreach (Persona p in lista)
            {
                lbx_personas.Items.Add(p);
            }
        }
    }
}
