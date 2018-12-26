using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E49
{
    public class CompetenciaNoDisponibleException : Exception
    {
        private string _nombre;
        private string _nombreMetodo;

        public string Nombre
        {
            get { return this._nombre; }
        }
        public string NombreMetodo
        {
            get { return this._nombreMetodo; }
        }
        public CompetenciaNoDisponibleException(string msj, string clase, string metodo)
            : base(msj)
        {
            this._nombre = clase;
            this._nombreMetodo = metodo;

        }
        public CompetenciaNoDisponibleException(string msj, string clase, string metodo, Exception innerException)
            : base(msj, innerException)

        {
            this._nombre = clase;
            this._nombreMetodo = metodo;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Excepción en el método {0} de la clase {1}: \n\n", this._nombreMetodo, this._nombre);
            if (base.InnerException != null)
                sb.AppendLine("\t" + base.InnerException.Message);
            return sb.ToString();
        }
    }
}
