using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using E55;
using CentralTelefonicaFormulario;

namespace CentralTelefonicaFormulario
{
    public partial class FrmLlamador : Form
    {
        Centralita centralita;
        string numeroOrigenAleatorio = new Random().Next(42883086, 42884000).ToString();
        public Centralita Centralita
        {
            get { return this.centralita; }
        }

        public FrmLlamador(Centralita c)
        {
            InitializeComponent();
            this.centralita = c;
            cmbFranja.DataSource = Enum.GetValues(typeof(Provincial.Franja));
            cmbFranja.Enabled = false;
            //cmbFranja.Items.Add(Franja.Franja_1);
            //cmbFranja.Items.Add(Franja.Franja_2);
            //cmbFranja.Items.Add(Franja.Franja_3);
            btn_Boton1.Click += new EventHandler(btn_Button_Click);
            btn_Boton2.Click += new EventHandler(btn_Button_Click);
            btn_Boton3.Click += new EventHandler(btn_Button_Click);
            btn_Boton4.Click += new EventHandler(btn_Button_Click);
            btn_Boton5.Click += new EventHandler(btn_Button_Click);
            btn_Boton6.Click += new EventHandler(btn_Button_Click);
            btn_Boton7.Click += new EventHandler(btn_Button_Click);
            btn_Boton8.Click += new EventHandler(btn_Button_Click);
            btn_Boton9.Click += new EventHandler(btn_Button_Click);
            btn_Boton0.Click += new EventHandler(btn_Button_Click);
            btn_BotonAsterisco.Click += new EventHandler(btn_Button_Click);
            btn_BotonNumeral.Click += new EventHandler(btn_Button_Click);
            
        }


        private void btn_Button_Click(object sender, EventArgs e)
        {
            if (txt_NroDestino.Text == "Nro Destino")
                txt_NroDestino.Text = string.Empty;
            try
            {
                Button btn = sender as Button;

                switch (btn.Name)
                {
                    case "btn_Boton1":
                        txt_NroDestino.Text += "1";
                        break;
                    case "btn_Boton2":
                        txt_NroDestino.Text += "2";
                        break;
                    case "btn_Boton3":
                        txt_NroDestino.Text += "3";
                        break;
                    case "btn_Boton4":
                        txt_NroDestino.Text += "4";
                        break;
                    case "btn_Boton5":
                        txt_NroDestino.Text += "5";
                        break;
                    case "btn_Boton6":
                        txt_NroDestino.Text += "6";
                        break;
                    case "btn_Boton7":
                        txt_NroDestino.Text += "7";
                        break;
                    case "btn_Boton8":
                        txt_NroDestino.Text += "8";
                        break;
                    case "btn_Boton9":
                        txt_NroDestino.Text += "9";
                        break;
                    case "btn_Boton0":
                        txt_NroDestino.Text += "0";
                        break;
                    case "btn_BotonAsterisco":
                        txt_NroDestino.Text += "*";
                        break;
                    case "btn_BotonNumeral":
                        txt_NroDestino.Text += "#";
                        if (txt_NroDestino.Text.Length == 1)
                        {
                            cmbFranja.Enabled = true;
                        }
                        break;
                    case "btnDot":
                        if (!txt_NroDestino.Text.Contains("."))
                            txt_NroDestino.Text += ".";
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry for the inconvenience, Unexpected error occured. Details: " + ex.Message);
            }
        }
        private void txt_NroDestino_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                case '0':
                case '*':
                case '#':
                    //case '+': 
                    //case '-': 
                    //case '*': 
                    //case '/': 
                    //case '.': 
                    break;
                default:
                    e.Handled = true;
                    MessageBox.Show("Only numbers, +, -, ., *, / are allowed");
                    break;
            }
        }







        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Hide();            
            FrmMenu menu = new FrmMenu(this.Centralita);
            menu.Show();
            this.Close();
        }

        private void btn_Llamar_Click(object sender, EventArgs e)
        {
            Provincial.Franja franjas;
            Enum.TryParse<Provincial.Franja>(cmbFranja.SelectedValue.ToString(), out franjas);
            txt_NroOrigen.Text = this.numeroOrigenAleatorio;

            if (txt_NroDestino.Text[0] == '#')
            {
                this.centralita += new Provincial(txt_NroOrigen.Text, txt_NroDestino.Text, (float)(new Random().Next(1, 50)), (Provincial.Franja)cmbFranja.SelectedItem);
            }
            else
            {
                this.centralita += new Local(txt_NroOrigen.Text, txt_NroDestino.Text, (float)(new Random().Next(1, 50)), (float)(new Random().Next(1, 50)));
            }
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            txt_NroDestino.Text = string.Empty;
            txt_NroDestino.Text = "Nro Destino";
            txt_NroOrigen.Text = "Nro Origen";
            cmbFranja.Enabled = false;
        }
    }
}
