using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E68
{
    public delegate void DelegadoString(string msg);

    public class Persona
    {

        private string nombre;
        private string apellido;

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }
        public string Apellido
        {
            get { return this.apellido; }
            set { this.apellido = value; }
        }

        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("nombre: " + this.nombre);
            sb.AppendLine("apellido: " + this.apellido);
            return sb.ToString();
        }

        
    }
}
