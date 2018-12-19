using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Monedas;


namespace E23
{
    public partial class Conversor : Form
    {
        private Euro eur;
        private Peso ars;
        private Dolar usd;

        public Conversor()
        {
            InitializeComponent();
            this.eur = new Euro(0, (float)1.14);
            this.ars = new Peso(0, (float)0.026);
            this.usd = new Dolar(0, (float)1);
        }

        private void btnEuro_Click(object sender, EventArgs e)
        {
            double aux;
            if (double.TryParse(txtBoxEuro.Text, out aux) && aux > 0)
            {
                this.eur = new Euro(aux);

                txtEuroEuro.Text = string.Format("{0:N3}", ((double)this.eur));
                txtEuroDolar.Text = string.Format("{0:N3}", ((double)(Dolar)this.eur));
                txtEuroPeso.Text = string.Format("{0:N3}", ((double)(Peso)this.eur));
            }
            else
                MessageBox.Show("ingrese un numero valido");

        }

        private void btnDolar_Click(object sender, EventArgs e)
        {
            double aux;
            if (double.TryParse(txtBoxDolar.Text, out aux) && aux > 0)
            {
                this.usd = new Dolar(aux);

                txtDolarDolar.Text = string.Format("{0:N3}", ((double)this.usd));
                txtDolarPeso.Text = string.Format("{0:N3}", ((double)(Peso)this.usd));
                txtDolarEuro.Text = string.Format("{0:N3}", ((double)(Euro)this.usd));
            }
            else
                MessageBox.Show("ingrese un numero valido");

        }

        private void btnPeso_Click(object sender, EventArgs e)
        {
            double aux;
            if (double.TryParse(txtBoxPeso.Text, out aux) && aux > 0)
            {
                this.ars = new Peso(aux);

                txtPesoPeso.Text = string.Format("{0:N3}", ((double)this.ars));
                txtPesoDolar.Text = string.Format("{0:N3}", ((double)(Dolar)this.ars));
                txtPesoEuro.Text = string.Format("{0:N3}", ((double)(Euro)this.ars));
            }
            else
                MessageBox.Show("ingrese un numero valido");
        }
    }
}
