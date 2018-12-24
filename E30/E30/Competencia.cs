using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E30
{
    public class Competencia
    {
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<AutoF1> competidores;

        private Competencia()
        {
            this.competidores = new List<AutoF1>();
        }
        public Competencia(short cantidadVueltas, short cantidadCompetidores)
            : this()
        {
            this.cantidadCompetidores = cantidadCompetidores;
            this.cantidadVueltas = cantidadVueltas;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Datos Competencia");
            sb.AppendLine("*****************");
            sb.AppendLine("Cantidad de competidores: " + this.cantidadCompetidores);
            sb.AppendLine("Cantidad de vueltas: " + this.cantidadVueltas);
            sb.AppendLine("");

            foreach (AutoF1 a in this.competidores)
            {
                sb.AppendLine(a.MostrarDatos());
                sb.AppendLine("----------------------");
            }
            return sb.ToString();
        }

        public static bool operator +(Competencia c, AutoF1 a)
        {
            if (c != a && c.competidores.Count < c.cantidadCompetidores)
            {
                c.competidores.Add(a);
                a.Estdo = true;
                a.Vueltas = c.cantidadVueltas;
                a.Combustible = (short)(new Random().Next(15, 100));
                return true;
            }
            return false;
        }
        public static bool operator -(Competencia c, AutoF1 a)
        {
            if (c == a && c.competidores.Count > 0)
            {
                c.competidores.Remove(a);
                a.Estdo = false;
                return true;
            }
            return false;
        }
        public static bool operator ==(Competencia c, AutoF1 a)
        {
            foreach (AutoF1 aux in c.competidores)
            {
                if (aux == a)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Competencia c, AutoF1 a)
        {
            return !(c == a);
        }
    }
}
