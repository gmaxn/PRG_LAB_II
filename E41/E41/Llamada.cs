using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E41
{
    public abstract class Llamada
    {
        public enum TipoDeLlamada { Local, Provincial, Todas }

        protected string _nroOrigen;
        protected string _nroDestino;
        protected float _duracion;

        public abstract float CostoLlamada
        { get; }
        public string NroOrigen
        {
            get { return this._nroOrigen; }
        }
        public string NroDestino
        {
            get { return this._nroDestino; }
        }
        public float Duracion
        {
            get { return this._duracion; }
        }

        public Llamada(string nroOrigen, string nroDestino, float duracion)
        {
            this._nroOrigen = nroOrigen;
            this._nroDestino = nroDestino;
            this._duracion = duracion;
        }

        protected virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Nro Origen:  " + this._nroOrigen);
            sb.AppendLine("Nro Destino: " + this._nroDestino);
            sb.AppendLine("Duracion:    " + this._duracion + " seg.");
            return sb.ToString();
        }
        public int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            return llamada1._duracion.CompareTo(llamada2._duracion);
        }

        public static bool operator ==(Llamada a, Llamada b)
        {
            return Object.Equals(a, b);
        }
        public static bool operator !=(Llamada a, Llamada b)
        {
            return !(a == b);
        }
    }
}
