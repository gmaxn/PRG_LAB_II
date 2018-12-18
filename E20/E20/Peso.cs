using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Peso
    {
        // Atributos
        private double cantidad;
        private static float cotizRespectoDolar;

        // Getters - Setters - Indexers
        public double GetCantidad
        {
            get { return this.cantidad; }
            //
        }
        public static float GetCotizacion
        {
            get { return Peso.cotizRespectoDolar; }
            //
        }

        //Constructores
        private Peso()
        {
            Peso.cotizRespectoDolar = (float)(37.16);
        }
        public Peso(double cantidad)
        {
            this.cantidad = cantidad;
        }
        public Peso(double cantidad, float cotizacion)
        {
            this.cantidad = cantidad;
            Peso.cotizRespectoDolar = cotizacion;
        }

        // Sobrecarga de Operadores
        public static Peso operator +(Peso p, Dolar d)
        {
            double cotizPeso = double.Parse(Peso.GetCotizacion.ToString());
            double cotizDolar = double.Parse(Dolar.GetCotizacion.ToString());

            double aux = (((p.GetCantidad * cotizPeso) + (p.GetCantidad * cotizDolar)) / cotizPeso);
            return new Peso(aux);
            //double aux = p.GetCantidad * Peso.GetCotizacion + d.GetCantidad * Dolar.GetCotizacion;
            //return new Peso((float)(aux / Peso.GetCotizacion));
            //
        }
        public static Peso operator -(Peso p, Dolar d)
        {
            double cotizPeso = double.Parse(Peso.GetCotizacion.ToString());
            double cotizDolar = double.Parse(Dolar.GetCotizacion.ToString());

            double aux = (((p.GetCantidad * cotizPeso) - (p.GetCantidad * cotizDolar)) / cotizPeso);
            return new Peso(aux);
            //double aux = p.GetCantidad * Peso.GetCotizacion + d.GetCantidad * Dolar.GetCotizacion;
            //return new Peso((float)(aux / Peso.GetCotizacion));
            //
        }
        public static bool operator ==(Peso p, Dolar d)
        {

            return (float)(p.GetCantidad * Peso.GetCotizacion) == (float)(d.GetCantidad * Dolar.GetCotizacion);
            //
        }
        public static bool operator !=(Peso p, Dolar d)
        {
            return !(p == d);
            //
        }

        public static Peso operator +(Peso p, Euro e)
        {
            double cotizPeso = double.Parse(Peso.GetCotizacion.ToString());
            double cotizEuro = double.Parse(Euro.GetCotizacion.ToString());

            double aux = (((p.GetCantidad * cotizPeso) + (e.GetCantidad * cotizEuro)) / cotizPeso);
            return new Peso(aux);
            /*
            double aux = p.GetCantidad * Peso.GetCotizacion + e.GetCantidad * Euro.GetCotizacion;
            return new Peso((float)(aux / Peso.GetCotizacion));*/
            //
        }
        public static Peso operator -(Peso p, Euro e)
        {
            double cotizPeso = double.Parse(Peso.GetCotizacion.ToString());
            double cotizEuro = double.Parse(Euro.GetCotizacion.ToString());

            double aux = (((p.GetCantidad * cotizPeso) - (e.GetCantidad * cotizEuro)) / cotizPeso);
            return new Peso(aux);
            //double aux = p.GetCantidad * Peso.GetCotizacion - e.GetCantidad * Euro.GetCotizacion;
            //return new Peso((float)(aux / Peso.GetCotizacion));
            //
        }
        public static bool operator ==(Peso p, Euro e)
        {
            return ((p.cantidad) == (e.GetCantidad / Peso.GetCotizacion));
            //
        }
        public static bool operator !=(Peso p, Euro e)
        {
            return !(p == e);
            //
        }

        public static bool operator ==(Peso pa, Peso pb)
        {
            return (pa.GetCantidad == pb.GetCantidad);
            //
        }
        public static bool operator !=(Peso pa, Peso pb)
        {
            return !(pa == pb);
            //
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        // Conversiones Explicitas / Implicitas
        public static implicit operator double(Peso p)
        {
            return p.cantidad;
        }
        public static implicit operator Peso(double d)
        {
            return new Peso(d);
            //
        }
        public static explicit operator Dolar(Peso p)
        {
            double cotizPeso = double.Parse(Peso.GetCotizacion.ToString());
            double cotizDolar = double.Parse(Dolar.GetCotizacion.ToString());
            double aux = (p.cantidad * cotizPeso) / cotizDolar;
            return new Dolar(aux);
        }
        public static explicit operator Euro(Peso p)
        {
            double cotizPeso = double.Parse(Peso.GetCotizacion.ToString());
            double cotizEuro = double.Parse(Euro.GetCotizacion.ToString());
            double aux = (p.cantidad * cotizPeso) / cotizEuro;
            return new Euro(aux);
        }
    }
}
