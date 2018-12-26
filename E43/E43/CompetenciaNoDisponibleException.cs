using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E43
{
    public class CompetenciaNoDisponibleException : Exception
    {
        private string nombreClase;
        private string nombreMetodo;

        public string NombreClase
        {
            get { return this.nombreClase; }
        }

        public string NombreMetodo
        {
            get { return this.nombreMetodo; }
        }

        public CompetenciaNoDisponibleException(string msg, string clase, string metodo)
            : base(msg)
        {
            this.nombreClase = clase;
            this.nombreMetodo = metodo;
        }
        
        public CompetenciaNoDisponibleException(string msg, string clase, string metodo, Exception inner)
            : base(msg, inner)
        {
            this.nombreMetodo = metodo;
            this.nombreClase = clase;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            Exception ex;

            sb.AppendFormat("Excepción en el método: \"{0}\", de la clase: {1}\n\n", this.nombreMetodo, this.nombreClase);
            sb.AppendLine("Mensaje de la Excepcion: " + base.Message);

            ex = base.InnerException;

            while (ex != null)
            {
                sb.AppendLine("Mensaje de la InnerExceptio: " + ex.Message);
                ex = ex.InnerException;
            }

            return sb.ToString();

        }
    }
}
