using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Contador_de_palabras;

namespace E28
{
    public partial class MainForm : Form
    {
        Dictionary<string, int> diccionario;

        public MainForm()
        {
            InitializeComponent();

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            diccionario = Diccionarios.ContadorDePalabras(rtbContador.Text);
            diccionario = Diccionarios.OrdenarDiccionario(diccionario);
            rtbContador.Text = "";
            rtbContador.Text = Diccionarios.ShowDictionary(diccionario);
        }
    }
}
