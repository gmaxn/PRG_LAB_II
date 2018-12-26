using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E37
{
    public class Local : Llamada
    {
        protected float _costo;

        public float CostoLlamada
        {
            get { return this.CalcularCosto(); }
        }

        public Local(Llamada llamada, float costo)
            : base(llamada.NroOrigen, llamada.NroDestino, llamada.Duracion)
        {
            this._costo = costo;
        }
        public Local(string origen, string destino, float duracion, float costo)
            : this(new Llamada(origen, destino, duracion), costo)
        { }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Mostrar());
            sb.AppendLine("Costo:       $" + this.CalcularCosto());
            sb.AppendLine();
            return sb.ToString();
        }

        private float CalcularCosto()
        {
            return (base._duracion * this._costo);
        }
    }
}
