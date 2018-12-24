using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E29
{
    class Program
    {
        static void Main(string[] args)
        {
            Equipo e1 = new Equipo(4, "River Plate");
            Equipo e2 = new Equipo(5, "Boca Juniors");

            Jugador j0 = new Jugador(11111111, "Franco ARMANI");
            Jugador j1 = new Jugador(22222222, "Jonatan MAIDANA");
            Jugador j2 = new Jugador(33333333, "Bruno ZUCULINI");
            Jugador j3 = new Jugador(44444444, "Rodrigo MORA");
            Jugador j4 = new Jugador(55555555, "Rafael Santos BORRÉ");
            Jugador j5 = new Jugador(66666666, "Esteban Andrada");
            Jugador j6 = new Jugador(77777777, "Paolo Goltz");
            Jugador j7 = new Jugador(88888888, "Fernando Gago");
            Jugador j8 = new Jugador(99999999, "Carlos Tevez");
            Jugador j9 = new Jugador(99999999, "Darío Benedetto");

            Console.WriteLine(((e1 + j0) ? "jugador agregado" : "Error de carga"));
            Console.WriteLine(((e1 + j1) ? "jugador agregado" : "Error de carga"));
            Console.WriteLine(((e1 + j2) ? "jugador agregado" : "Error de carga"));
            Console.WriteLine(((e1 + j3) ? "jugador agregado" : "Error de carga"));
            Console.WriteLine(((e1 + j4) ? "jugador agregado" : "Error de carga"));
            Console.WriteLine(((e2 + j5) ? "jugador agregado" : "Error de carga"));
            Console.WriteLine(((e2 + j6) ? "jugador agregado" : "Error de carga"));
            Console.WriteLine(((e2 + j7) ? "jugador agregado" : "Error de carga"));
            Console.WriteLine(((e2 + j8) ? "jugador agregado" : "Error de carga"));
            Console.WriteLine(((e2 + j9) ? "jugador agregado" : "Error de carga"));
        }
    }

    public class Equipo
    {
        private string nombre;
        private short cantidadDejugadores;
        private List<Jugador> jugadores;

        private Equipo()
        {
            this.jugadores = new List<Jugador>();
        }
        public Equipo(short cantidad, string nombre)
            : this()
        {
            this.cantidadDejugadores = cantidad;
            this.nombre = nombre;
        }
        public static bool operator +(Equipo e, Jugador j)
        {
            bool retorno = false;
            if(e.jugadores.Count < e.cantidadDejugadores)
            {
                foreach (Jugador aux in e.jugadores)
                {
                    if (aux == j)
                        return false;
                }
                e.jugadores.Add(j);
                retorno = true;
            }
            return retorno;
        }
    }
    public class Jugador
    {
        private string nombre;
        private long dni;
        private int partidosJugados;
        private float promedioGoles;
        private int totalGoles;

        public float GetPromedioGoles()
        {
            this.promedioGoles = totalGoles / partidosJugados;
            return this.promedioGoles;
        }

        private Jugador()
        {
            this.partidosJugados = 0;
            this.promedioGoles = 0;
            this.totalGoles = 0;
        }
        public Jugador(int dni, string nombre)
        {
            this.dni = dni;
            this.nombre = nombre;
        }
        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos)
            : this(dni, nombre)
        {
            this.totalGoles = totalGoles;
            this.partidosJugados = totalPartidos;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Jugador: {0}, {1}\n", this.nombre, this.dni);
            sb.AppendFormat("Partidos: {0}\n", this.partidosJugados);
            sb.AppendFormat("Promedio de Goles: {0}\n", GetPromedioGoles());
            sb.AppendFormat("Total de Goles: {0}\n", this.totalGoles);
            return sb.ToString();
        }

        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }
        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return (j1.dni == j2.dni);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
