using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiBiblioteca
{
    public class Torneo<T> 
        where T : Equipo
    {
        private List<T> equipos;
        private string nombre;

        public string JugarParido
        {
            get
            {
                int equipo1 = new Random().Next(0, this.equipos.Count);
                System.Threading.Thread.Sleep(100);
                int equipo2 = new Random().Next(0, this.equipos.Count);
                System.Threading.Thread.Sleep(100);

                return this.CalcualrPartido(equipos[equipo1], equipos[equipo2]);
            }
        }

        private Torneo()
        {
            this.equipos = new List<T>();
        }
        public Torneo(string nombreTorneo)
            : this()
        {
            this.nombre = nombreTorneo;
        }

        public static Torneo<T> operator +(Torneo<T> torneo, T equipo)
        {
            if (torneo != equipo)
                torneo.equipos.Add(equipo);
            return torneo;
        }
        public static bool operator ==(Torneo<T> torneo, T equipo)
        {
            return torneo.equipos.Contains(equipo);
        }
        public static bool operator !=(Torneo<T> torneo, T equipo)
        {
            return !(torneo == equipo);
        }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Torneo: " + this.nombre);
            sb.AppendLine();
            sb.AppendLine("Equipos participantes: ");
            foreach (Equipo e in this.equipos)
                sb.Append(e.Ficha());

            return sb.ToString();
        }
        public override string ToString()
        {
            return new StringBuilder(this.Mostrar()).ToString();
        }
        private string CalcualrPartido(T equipoA, T equipoB)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("{0}: {1} - {2}: {3}",
                equipoA.Nombre, (new Random()).Next(0, 10),
                equipoB.Nombre, (new Random()).Next(0, 10));

            return sb.ToString();
        }
    }
}
