using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using E59;

namespace CentralTelefonicaFormulario
{
    public partial class FrmMenu : Form
    {
        public Centralita centralita;
        public FrmMenu()
        {
            InitializeComponent();
            this.centralita = new Centralita();
        }
        public FrmMenu(Centralita c)
        {
            InitializeComponent();
            this.centralita = c;
        }

        private void btn_GenerarLLamada_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLlamador llamador = new FrmLlamador(this.centralita);
            llamador.ShowDialog();
        }
        private void btn_FacturacionTotal_Click(object sender, EventArgs e)
        {
            this.Hide();       
            FrmMostrar mostrar = new FrmMostrar(this.centralita.ToString(), this.centralita);
            mostrar.ShowDialog();
        }

        private void btn_FacturacionLocal_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("FACTURACION POR LLAMADAS LOCALES");
            sb.AppendLine("********************************");

            foreach (Llamada l in this.centralita.Llmadas)
            {
                if(l is Local)
                {
                    sb.AppendLine(l.ToString());
                    sb.AppendLine("--------------------------------");
                }
            }

            FrmMostrar mostrar = new FrmMostrar(sb.ToString(), this.centralita);
            this.Hide();
            mostrar.ShowDialog();
        }

        private void btn_FacturacionProvincial_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("FACTURACION POR LLAMADAS PROVINCIALES");
            sb.AppendLine("*************************************");

            foreach (Llamada l in this.centralita.Llmadas)
            {
                if (l is Provincial)
                {
                    sb.AppendLine(l.ToString());
                    sb.AppendLine("--------------------------------");
                }
            }

            FrmMostrar mostrar = new FrmMostrar(sb.ToString(), centralita);
            this.Hide();
            mostrar.ShowDialog();
        }
        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
