using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiBiblioteca
{
    public abstract class Equipo
    {
        private string nombre;
        private DateTime fechaDeCreacion;

        public string Nombre
        {
            get { return this.nombre; }
        }

        public Equipo(string nombreEquipo, DateTime fechaDeCreacion)
        {
            this.nombre = nombreEquipo;
            this.fechaDeCreacion = fechaDeCreacion;
        }
        public Equipo(Equipo e)
            : this(e.nombre, e.fechaDeCreacion)
        { }

        public static bool operator ==(Equipo e1, Equipo e2)
        {
            if (e1.nombre == e2.nombre)
                if (e1.fechaDeCreacion == e2.fechaDeCreacion)
                    return true;
            return false;
        }
        public static bool operator !=(Equipo e1, Equipo e2)
        {
            return !(e1 == e2);
        }

        public string Ficha()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.Nombre + " Fundado el " + this.fechaDeCreacion.ToShortDateString());
            return sb.ToString();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.Ficha());
            return sb.ToString();
        }
    }
}
