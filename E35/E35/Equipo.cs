using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E35
{
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
}
