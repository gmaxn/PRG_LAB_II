using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Threading;

namespace E67
{
    public partial class MainForm : Form
    {
        Temporizador temporizador;

        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            temporizador = new Temporizador();
            temporizador.EventoTiempo += Temporizador_EventoTiempo;
            //temporizador.EventoNvo += Temporizador_EventoCoco;
            //temporizador.Activo = true;
        }
        private void MainForm_Load1(object sender, EventArgs e)
        {
            //this.Show;
            bool pasoUnSeg = true;
            DateTime hora = DateTime.Now;

            while (true)
            {
                if (pasoUnSeg)
                {
                    lblHora.Text = hora.ToString("DD/MM/YYYY HH:mm:ss");
                    pasoUnSeg = false;
                }
                if ((DateTime.Now - hora).TotalMilliseconds >= 1000)
                    pasoUnSeg = true;
            }
        }
        private void MainForm_Load2(object sender, EventArgs e)
        {
            this.Timer.Start();
        }
        private void MainForm_Load3(object sender, EventArgs e)
        {
            Thread hilito = new Thread(MostrarHora);

            hilito.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
        }
        private void Temporizador_EventoTiempo(object obj, EventArgs e)
        {
            MostrarHora();
        }
        private int Temporizador_EventoCoco(string str)
        {
            MessageBox.Show(str);
            return 1;
        }
        private void MostrarHora()
        {
            bool pasoUnSeg = true;
            DateTime hora = DateTime.Now;

            while (true)
            {
                if (pasoUnSeg)
                {
                    if (lblHora.InvokeRequired)
                    {
                        lblHora.BeginInvoke((MethodInvoker)delegate ()
                        {
                            lblHora.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
                        }
                        );
                    }
                    else
                    {
                        lblHora.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
                    }
                    pasoUnSeg = false;
                }

                if ((DateTime.Now - hora).TotalMilliseconds >= 1000)
                    pasoUnSeg = true;

                Thread.Sleep(1000);
            }
        }
        private void MostrarHora2()
        {

            DateTime hora = DateTime.Now;
            if (lblHora.InvokeRequired)
            {
                lblHora.BeginInvoke((MethodInvoker)delegate ()
                {
                    lblHora.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
                }
                );
            }
            else
            {
                lblHora.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
            }

        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            temporizador.KillThread();
        }
    }
}
