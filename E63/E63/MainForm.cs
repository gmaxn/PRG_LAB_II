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

namespace E63
{
    public partial class MainForm : Form
    {
        Thread t;
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            // Asigno la hora al inicio
            this.AsignarHora();

            // Sin Threads
            //this.EjecutarAsignarHoraPorSegundo();


            // Con Timer
            //this.Timer.Enabled = true;


            // Con Threads
            t = new Thread(new ParameterizedThreadStart(this.EjecutarAsignarHoraPorSegundo));
            t.Start(1000);
        }


        private void EjecutarAsignarHoraPorSegundo(object sleep)
        {
            do
            {
                this.AsignarHora();
                Thread.Sleep((int)sleep);
            } while (true);
        }
        public void AsignarHora()
        {
            if (this.lblHora.InvokeRequired)
            {
                this.lblHora.BeginInvoke((MethodInvoker)delegate () { this.lblHora.Text = DateTime.Now.ToString(); });
            }
            else
            {
                this.lblHora.Text = DateTime.Now.ToString();
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (t.IsAlive)
                t.Abort();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.AsignarHora();
        }
    }
}
