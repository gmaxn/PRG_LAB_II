using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace E59
{
    public class Centralita : IGuardar<string>
    {
        protected string _razonSocial;
        private List<Llamada> _listaDeLlamadas;
        string rutaBitacora;

        public List<Llamada> Llmadas
        {
            get { return this._listaDeLlamadas; }
        }
        public float GananciasPorLocal
        {
            get { return this.CalcularGanancias(Llamada.TipoDeLlamada.Local); }
        }
        public float GananciasPorProvincial
        {
            get { return this.CalcularGanancias(Llamada.TipoDeLlamada.Provincial); }
        }
        public float GananciasPorTotal
        {
            get { return this.CalcularGanancias(Llamada.TipoDeLlamada.Todas); }
        }

        public string RutaDeArchivo
        {
            get
            {
                string fileLocation = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string fileName = string.Format("\\BitacoraCentralita.txt");
                StringBuilder path = new StringBuilder(fileLocation + fileName);
                this.rutaBitacora = path.ToString();
                return this.rutaBitacora;
            }
            set { this.rutaBitacora = value; }
        }

        public Centralita()
        {
            this._listaDeLlamadas = new List<Llamada>();
        }
        public Centralita(string nombreEmpresa)
            : this()
        {
            this._razonSocial = nombreEmpresa;
        }

        public static Centralita operator +(Centralita c, Llamada nuevaLLamada)
        {
            if (!(c == nuevaLLamada))
            {
                c.AgregarLlamada(nuevaLLamada);
                try
                {
                    c.Guardar();
                }
                catch (Exception e)
                {
                    throw new FallaLogException(e.Message, e.InnerException);
                }
            }
            else
            {
                throw new CentralitaException("no se ha podido agregar la llamada debido a que ya se encuentra en la lista");
            }
            return c;
        }
        public static bool operator ==(Centralita c, Llamada llamada)
        {
            return c._listaDeLlamadas.Contains(llamada);
        }
        public static bool operator !=(Centralita c, Llamada llamada)
        {
            return !(c == llamada);
        }
        public override string ToString()
        {
            return this.Mostrar();
        }

        private string Mostrar()
        {
            if (this.GananciasPorTotal > 0 && this._razonSocial != null)
            {
                StringBuilder Centralita = new StringBuilder();
                StringBuilder local = new StringBuilder();
                StringBuilder provincial = new StringBuilder();

                Centralita.AppendLine("CENTRAL TELEFONICA: " + this._razonSocial);
                Centralita.AppendLine("---------------------------------");
                Centralita.AppendLine("Llamadas loc:  $" + GananciasPorLocal);
                Centralita.AppendLine("Llamadas prov: $" + GananciasPorProvincial);
                Centralita.AppendLine("Ganancias:     $" + GananciasPorTotal);
                Centralita.AppendLine("\n");

                if (GananciasPorLocal > 0)
                {
                    local.AppendLine("RESUMEN DE LLAMADAS LOCALES");
                    local.AppendLine("---------------------------");
                }
                if (GananciasPorProvincial > 0)
                {
                    provincial.AppendLine("RESUMEN DE LLAMADAS PROVINCIALES");
                    provincial.AppendLine("--------------------------------");
                }

                foreach (Llamada l in this._listaDeLlamadas)
                {
                    if (l is Local)
                        local.Append(((Local)l).ToString());
                    if (l is Provincial)
                        provincial.Append(((Provincial)l).ToString());
                }

                return Centralita.Append(local.ToString() + provincial.ToString()).ToString();
            }
            else
            {
                return new StringBuilder().ToString();
            }
        }
        private void AgregarLlamada(Llamada llamada)
        {
            this._listaDeLlamadas.Add(llamada);
        }
        private void OrdenarLlamadas()
        {
            //INSERTION SORT
            Llamada aux;
            int i, j;

            for (i = 1; i < this._listaDeLlamadas.Count; i++)
            {
                aux = this._listaDeLlamadas[i];
                j = i + 1;

                while (j >= 0 && aux.OrdenarPorDuracion(aux, this._listaDeLlamadas[j]) > 0)
                {
                    this._listaDeLlamadas[j + 1] = this._listaDeLlamadas[j];
                    j = j - 1;
                }
                this._listaDeLlamadas[j + 1] = aux;
            }
        }
        private float CalcularGanancias(Llamada.TipoDeLlamada tipo)
        {
            float recaudacion = 0;

            switch (tipo)
            {
                case Llamada.TipoDeLlamada.Todas:
                    foreach (Llamada l in this._listaDeLlamadas)
                    {
                        if (l is Local)
                            recaudacion += ((Local)l).CostoLlamada;
                        else
                            recaudacion += ((Provincial)l).CostoLlamada;
                    }
                    break;

                case Llamada.TipoDeLlamada.Local:
                    foreach (Llamada l in this._listaDeLlamadas)
                    {
                        if (l is Local)
                            recaudacion += ((Local)l).CostoLlamada;
                    }
                    break;

                case Llamada.TipoDeLlamada.Provincial:
                    foreach (Llamada l in this._listaDeLlamadas)
                    {
                        if (l is Provincial)
                            recaudacion += ((Provincial)l).CostoLlamada;
                    }
                    break;
            }

            return recaudacion;
        }

        public bool Guardar()
        {

            StringBuilder data = new StringBuilder();

            bool exist = File.Exists(this.RutaDeArchivo); // archivo existe == true,  append : create
            try
            {
                using (StreamWriter file = new StreamWriter(this.RutaDeArchivo, exist))
                {
                    file.WriteLine(string.Format("{0} {1} - Se realizó una llamada.txt", DateTime.Now.ToLongDateString(), DateTime.Now.ToShortTimeString()));
                }
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public string Leer()
        {
            string datos;
            try
            {
                using (StreamReader file = new StreamReader(this.RutaDeArchivo))
                {
                    datos = file.ReadToEnd();
                }
                return datos;
            }
            catch (Exception e)
            {
                throw new FileNotFoundException();
            }
        }
    }
}
