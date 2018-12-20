using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using EscalasTemperatrura;

namespace E24
{
    public partial class Conversor : Form
    {
        private Fahrenheit far;
        private Celsius cel;
        private Kelvin kel;


        public Conversor()
        {
            InitializeComponent();
            this.far = new Fahrenheit(0);
            this.cel = new Celsius(0);
            this.kel = new Kelvin(0);

        }

        private void btnFharenheit_Click(object sender, EventArgs e)
        {
            double aux;
            if (double.TryParse(txtFharenheit.Text, out aux) && aux > 0)
            {
                this.far = new Fahrenheit(aux);

                txtFharenheitFahrenheit.Text = string.Format("{0:N4}", ((double)this.far));
                txtFharenheitCelsius.Text = string.Format("{0:N4}", ((double)(Celsius)this.far));
                txtFharenheitKelvin.Text = string.Format("{0:N4}", ((double)(Kelvin)this.far));
            }
            else
                MessageBox.Show("ingrese un numero valido");
        }

        private void btnCelsius_Click(object sender, EventArgs e)
        {
            double aux;
            if (double.TryParse(txtCelsius.Text, out aux) && aux > 0)
            {
                this.cel = new Celsius(aux);

                txtCelsiusCelsius.Text = string.Format("{0:N4}", ((double)this.cel));
                txtCelsiusFharenheit.Text = string.Format("{0:N4}", ((double)(Fahrenheit)this.cel));
                txtCelsiusKelvin.Text = string.Format("{0:N4}", ((double)(Kelvin)this.cel));
            }
            else
                MessageBox.Show("ingrese un numero valido");
        }

        private void btnKelvin_Click(object sender, EventArgs e)
        {
            double aux;
            if (double.TryParse(txtKelvin.Text, out aux) && aux > 0)
            {
                this.kel = new Kelvin(aux);

                txtKelvinKelvin.Text = string.Format("{0:N4}", ((double)this.kel));
                txtKelvinCelsius.Text = string.Format("{0:N4}", ((double)(Celsius)this.kel));
                txtKelvinFharenheit.Text = string.Format("{0:N4}", ((double)(Fahrenheit)this.kel));
            }
            else
                MessageBox.Show("ingrese un numero valido");
        }
    }
}
