using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E49
{
    public class Competencia<T> where T : VehiculoDeCarrera
    {
        private short _cantidadCompetidores;
        private short _cantidadVueltas;
        private List<T> _competidores;

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
            this._competidores = new List<T>();
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

        public static bool operator ==(Competencia<T> c, T a)
        {
            bool auxReturn = false;

            if (c._competidores != null && c._competidores.Count > 0)
            {
                foreach (T aux in c._competidores)
                {
                    if (aux is AutoF1 && a is AutoF1)
                    {
                        AutoF1 copia = (AutoF1)Convert.ChangeType(aux, typeof(AutoF1));
                        AutoF1 copia2 = (AutoF1)Convert.ChangeType(a, typeof(AutoF1));
                        if (copia == copia2)
                        {
                            auxReturn = true;
                        }
                    }
                    else if (aux is MotoCross && a is MotoCross)
                    {
                        MotoCross copia = (MotoCross)Convert.ChangeType(aux, typeof(MotoCross));
                        MotoCross copia2 = (MotoCross)Convert.ChangeType(a, typeof(MotoCross));
                        if (copia == copia2)
                        {
                            auxReturn = true;
                        }
                    }
                    else
                    {
                        throw new CompetenciaNoDisponibleException("El vehículo no corresponde a la competencia", typeof(Competencia<T>).Name, "operador ==");
                    }

                }
            }
            return auxReturn;
        }
        public static bool operator !=(Competencia<T> c, T a)
        {
            return !(c == a);
        }

        public static bool operator +(Competencia<T> c, T a)
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
        public static bool operator -(Competencia<T> c, T a)
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
