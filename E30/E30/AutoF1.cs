using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E30
{
    public class AutoF1
    {
        private short _numero;
        private string _escuderia;
        private bool _enCompetencia;
        private short _cantidadCombustible;
        private short _vueltasRestantes;

        public short Combustible
        {
            get { return this._cantidadCombustible; }
            set { this._cantidadCombustible = value; }
        }
        public bool Estdo
        {
            get { return this._enCompetencia; }
            set { this._enCompetencia = value; }
        }
        public short Vueltas
        {
            get { return this._vueltasRestantes; }
            set { this._vueltasRestantes = value; }
        }

        public AutoF1(short numero, string escuderia)
        {
            this._numero = numero;
            this._escuderia = escuderia;
            this._enCompetencia = false;
            this._cantidadCombustible = 0;
            this._vueltasRestantes = 0;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Datos Auto F1 Nº: " + this._numero);
            sb.AppendLine("Escuderia: " + this._escuderia);
            sb.AppendFormat("Inscripto: {0}\n", this._enCompetencia ? "SI" : "NO");
            sb.AppendLine("Cantidad de Combustible: " + this._cantidadCombustible);
            sb.AppendLine("Vueltas Restantes: " + this._vueltasRestantes);
            return sb.ToString();
        }

        public static bool operator ==(AutoF1 A1, AutoF1 A2)
        {
            if (A1._numero == A2._numero &&
               A1._escuderia == A2._escuderia)
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
