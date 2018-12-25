using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E32
{
    class Program
    {
        static void Main(string[] args)
        {
            Equipo e1 = new Equipo(4, "River Plate");
            Equipo e2 = new Equipo(5, "Boca Juniors");

            Jugador j0 = new Jugador(11111111, "Franco ARMANI", 50, 0);
            Jugador j1 = new Jugador(22222222, "Jonatan MAIDANA", 50, 10);
            Jugador j2 = new Jugador(33333333, "Bruno ZUCULINI", 50, 15);
            Jugador j3 = new Jugador(44444444, "Rodrigo MORA", 50, 8);
            Jugador j4 = new Jugador(55555555, "Rafael Santos BORRÉ", 50, 20);
            Jugador j5 = new Jugador(66666666, "Esteban Andrada", 50, 10);
            Jugador j6 = new Jugador(77777777, "Paolo Goltz", 50, 9);
            Jugador j7 = new Jugador(88888888, "Fernando Gago", 50, 26);
            Jugador j8 = new Jugador(99999999, "Carlos Tevez", 50, 35);
            Jugador j9 = new Jugador(99999999, "Darío Benedetto", 50, 24);

            Console.WriteLine(j0.MostrarDatos());
            Console.WriteLine(((e1 + j0) ? "jugador agregado" : "Error de carga"));

            Console.WriteLine(j1.MostrarDatos());
            Console.WriteLine(((e1 + j1) ? "jugador agregado" : "Error de carga"));

            Console.WriteLine(j2.MostrarDatos());
            Console.WriteLine(((e1 + j2) ? "jugador agregado" : "Error de carga"));

            Console.WriteLine(j3.MostrarDatos());
            Console.WriteLine(((e1 + j3) ? "jugador agregado" : "Error de carga"));

            Console.WriteLine(j4.MostrarDatos());
            Console.WriteLine(((e1 + j4) ? "jugador agregado" : "Error de carga"));

            Console.WriteLine(j5.MostrarDatos());
            Console.WriteLine(((e2 + j5) ? "jugador agregado" : "Error de carga"));

            Console.WriteLine(j6.MostrarDatos());
            Console.WriteLine(((e2 + j6) ? "jugador agregado" : "Error de carga"));

            Console.WriteLine(j7.MostrarDatos());
            Console.WriteLine(((e2 + j7) ? "jugador agregado" : "Error de carga"));

            Console.WriteLine(j8.MostrarDatos());
            Console.WriteLine(((e2 + j8) ? "jugador agregado" : "Error de carga"));

            Console.WriteLine(j9.MostrarDatos());
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
            if (e.jugadores.Count < e.cantidadDejugadores)
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
                if(partidosJugados != 0)
                    this.promedioGoles = totalGoles / partidosJugados;
                return this.promedioGoles;
            }
        }
        public int TotalGoles
        {
            get { return this.totalGoles; }
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
