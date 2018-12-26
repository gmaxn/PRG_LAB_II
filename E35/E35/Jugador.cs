using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E35
{
    public class Jugador : Persona
    {
        private int partidosJugados;
        private int totalGoles;

        public int PartidosJugados
        {
            get
            {
                return this.partidosJugados;
            }
        }
        public float PromedioGoles
        {
            get
            {
                if (partidosJugados != 0)
                    return totalGoles / partidosJugados;
                return 0;
            }
        }
        public int TotalGoles
        {
            get { return this.totalGoles; }
        }

        public Jugador(string nombre, int totalGoles, int totalPartidos)
            : base(nombre)
        {
            this.totalGoles = totalGoles;
            this.partidosJugados = totalPartidos;
        }

        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.MostrarDatos());
            sb.AppendLine("");
            sb.AppendFormat("Partidos: {0}\n", this.partidosJugados);
            sb.AppendFormat("Total de Goles: {0}\n", this.totalGoles);
            sb.AppendFormat("Promedio de Goles: {0}\n", this.PromedioGoles);
            return sb.ToString();
        }

        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }
        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return (j1.DNI == j2.DNI);
        }
    }
}
