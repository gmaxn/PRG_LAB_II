using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E43
{
    public class MotoCross : VehiculoDeCarrera
    {
        private short _cilindrada;
        public short Cilindrada
        {
            get { return this._cilindrada; }
            set { this._cilindrada = value; }
        }
        public MotoCross(short numero, string escuderia, short cilindrada)
            : base(numero, escuderia)
        {
            this._cilindrada = cilindrada;
        }

        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine("Cilindrada: " + this._cilindrada);
            return sb.ToString();
        }

        public static bool operator ==(MotoCross m1, MotoCross m2)
        {
            if (m1.Numero == m2.Numero &&
                m1.Escuderia == m2.Escuderia &&
                m1.Cilindrada == m2.Cilindrada)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(MotoCross A1, MotoCross A2)
        {
            return !(A1 == A2);
        }
    }
}
