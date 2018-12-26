using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E36
{
    public class Competencia
    {
        private short _cantidadCompetidores;
        private short _cantidadVueltas;
        private List<VehiculoDeCarrera> _competidores;

        public short CantidadCompetidores
        {
            get { return this._cantidadCompetidores; }
            set { this._cantidadCompetidores = value; }
        }
        public short CantidadVueltas
        {
            get { return this._cantidadVueltas; }
            set { this._cantidadVueltas = value; }
        }
        public VehiculoDeCarrera this[int i]
        {
            get { return this._competidores[i]; }
        }

        private Competencia()
        {
            this._competidores = new List<VehiculoDeCarrera>();
        }
        public Competencia(short cantidadVueltas, short cantidadCompetidores)
            : this()
        {
            this._cantidadCompetidores = cantidadCompetidores;
            this._cantidadVueltas = cantidadVueltas;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Datos Competencia");
            sb.AppendLine("*****************");
            sb.AppendLine("Cantidad Maxima de competidores: " + this._cantidadCompetidores);
            sb.AppendLine("Cantidad de Inscriptos: " + this._competidores.Count);
            sb.AppendLine("Cantidad de vueltas: " + this._cantidadVueltas);
            sb.AppendLine("");

            foreach (VehiculoDeCarrera a in this._competidores)
            {
                sb.AppendLine(a.MostrarDatos());
                sb.AppendLine("----------------------");
            }
            return sb.ToString();
        }

        public static bool operator ==(Competencia c, VehiculoDeCarrera a)
        {
            if (c._competidores != null)
            {
                foreach (VehiculoDeCarrera aux in c._competidores)
                {
                    if (aux is AutoF1 && a is AutoF1)
                    {
                        return (AutoF1)aux == (AutoF1)a;
                    }
                    if (aux is MotoCross && a is MotoCross)
                    {
                        return (MotoCross)aux == (MotoCross)a;
                    }
                }
            }
            return false;// throw new Exception("Vehiculo no implementado");
        }
        public static bool operator !=(Competencia c, VehiculoDeCarrera a)
        {
            return !(c == a);
        }

        public static bool operator +(Competencia c, VehiculoDeCarrera a)
        {
            if (c != a && c._competidores.Count < c._cantidadCompetidores)
            {
                c._competidores.Add(a);
                a.EnCompetencia = true;
                a.Vueltas = c._cantidadVueltas;
                a.Combustible = (short)(new Random().Next(15, 100));
                return true;
            }
            return false;
        }
        public static bool operator -(Competencia c, VehiculoDeCarrera a)
        {
            if (c == a && c._competidores.Count > 0)
            {
                c._competidores.Remove(a);
                a.EnCompetencia = false;
                return true;
            }
            return false;
        }
    }
}
