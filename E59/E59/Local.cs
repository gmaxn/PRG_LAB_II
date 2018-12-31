using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E59
{
    public class Local : Llamada, IGuardar<Local>
    {
        protected float _costo;
        public override float CostoLlamada
        {
            get { return this.CalcularCosto(); }
        }

        public string RutaDeArchivo
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public Local(string origen, string destino, float duracion, float costo)
            : base(origen, destino, duracion)
        {
            this._costo = costo;
        }
        public Local(Llamada llamada, float costo)
            : this(llamada.NroOrigen, llamada.NroDestino, llamada.Duracion, costo)
        { }

        public override string ToString()
        {
            return this.Mostrar();
        }
        protected override string Mostrar()
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

        public override bool Equals(object obj)
        {
            if (obj != null && obj is Local)
            {
                if ((this._nroOrigen.CompareTo(((Local)obj).NroOrigen) == 0)
                && (this._nroDestino.CompareTo(((Local)obj).NroDestino) == 0))
                    return true;
            }
            return false;
        }

        public bool Guardar()
        {
            throw new NotImplementedException();
        }

        public Local Leer()
        {
            throw new NotImplementedException();
        }
    }
}
