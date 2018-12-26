using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E37
{
    public class Provincial : Llamada
    {
        public enum Franja { Franja_1, Franja_2, Franja_3 }

        protected Franja _franjaHoraria;
        public float CostoLlamada
        {
            get { return this.CalcularCosto(); }
        }
        public Provincial(Llamada llamada, Franja miFranja)
            : base(llamada.NroOrigen, llamada.NroDestino, llamada.Duracion)
        {
            this._franjaHoraria = miFranja;
        }
        public Provincial(string origen, string destino, float duracion, Franja miFranja)
            : this(new Llamada(origen, destino, duracion), miFranja)
        { }

        public override string Mostrar()
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
                    aux = (this._duracion * 0.99F);
                    break;

                case Franja.Franja_2:
                    aux = (this._duracion * 1.25F);
                    break;

                case Franja.Franja_3:
                    aux = (this._duracion * 0.66F);
                    break;

                default:
                    throw new NotImplementedException("franja inexistente");
            }
            return aux;
        }
    }
}
