using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E36
{
    public class AutoF1 : VehiculoDeCarrera
    {
        private short _caballosDeFuerza;

        public short HorsePower
        {
            get { return this._caballosDeFuerza; }
            set { this._caballosDeFuerza = value; }
        }
        public AutoF1(short numero, string escuderia)
            : base(numero, escuderia)
        { }
        public AutoF1(short numero, string escuderia, short horsePower)
            : this(numero, escuderia)
        {
            this._caballosDeFuerza = horsePower;
        }

        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine("Caballos de Fuerza: " + this.HorsePower);
            return sb.ToString();
        }

        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            if (a1.Numero == a2.Numero &&
                a1.Escuderia == a2.Escuderia &&
                a1.HorsePower == a2.HorsePower)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(AutoF1 A1, AutoF1 A2)
        {
            return !(A1 == A2);
        }
    }
}
