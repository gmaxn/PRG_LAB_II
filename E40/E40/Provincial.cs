using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E40
{
    public class Provincial : Llamada
    {
        public enum Franja { Franja_1, Franja_2, Franja_3 }
        protected Franja _franjaHoraria;

        public override float CostoLlamada
        {
            get { return this.CalcularCosto(); }
        }

        public Provincial(string origen, string destino, float duracion, Franja miFranja)
            : base(origen, destino, duracion)
        {
            this._franjaHoraria = miFranja;
        }
        public Provincial(Llamada llamada, Franja miFranja)
            : this(llamada.NroOrigen, llamada.NroDestino, llamada.Duracion, miFranja)
        { }

        public override string ToString()
        {
            return this.Mostrar();
        }
        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Mostrar());
            sb.AppendLine("Franja:      " + this._franjaHoraria);
            sb.AppendLine("Costo:       $" + this.CalcularCosto());
            sb.AppendLine();
            return sb.ToString();
        }

        private float CalcularCosto()
        {
            float aux;

            switch (this._franjaHoraria)
            {
                case Franja.Franja_1:
                    aux = (base._duracion * 0.99F);
                    break;

                case Franja.Franja_2:
                    aux = (base._duracion * 1.25F);
                    break;

                case Franja.Franja_3:
                    aux = (base._duracion * 0.66F);
                    break;

                default:
                    throw new NotImplementedException("franja inexistente");
            }
            return aux;
        }

        public override bool Equals(object obj)
        {
            if (obj != null && obj is Provincial)
            {
                if ((this._nroOrigen.CompareTo(((Provincial)obj).NroOrigen) == 0)
                && (this._nroDestino.CompareTo(((Provincial)obj).NroDestino) == 0))
                    return true;
            }
            return false;
        }
    }
}
