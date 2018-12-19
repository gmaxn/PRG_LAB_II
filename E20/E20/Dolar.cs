using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Dolar
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
            get { return Dolar.cotizRespectoDolar; }
            //
        }

        // Constructores
        private Dolar()
        {
            Dolar.cotizRespectoDolar = (float)(1);
        }
        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }
        public Dolar(double cantidad, float cotizacion)
        {
            this.cantidad = cantidad;
            Dolar.cotizRespectoDolar = cotizacion;
        }

        // Sobrecarga de Operadores
        public static bool operator ==(Dolar da, Dolar db)
        {
            return (da.GetCantidad == db.GetCantidad);
            //
        }
        public static bool operator !=(Dolar da, Dolar db)
        {
            return !(da == db);
            //
        }

        public static Dolar operator +(Dolar d, Euro e)
        {
            double cotizDolar = double.Parse(Dolar.GetCotizacion.ToString());
            double cotizEuro = double.Parse(Euro.GetCotizacion.ToString());

            double aux = (((d.GetCantidad * cotizDolar) + (e.GetCantidad * cotizEuro)) / cotizDolar);
            return new Dolar(aux);
            //double aux = d.GetCantidad * Dolar.GetCotizacion + e.GetCantidad * Euro.GetCotizacion;
            //return new Dolar((float)(aux / Dolar.GetCotizacion));
            //
        }
        public static Dolar operator -(Dolar d, Euro e)
        {
            double cotizDolar = double.Parse(Dolar.GetCotizacion.ToString());
            double cotizEuro = double.Parse(Euro.GetCotizacion.ToString());

            double aux = (((d.GetCantidad * cotizDolar) - (e.GetCantidad * cotizEuro)) / cotizDolar);
            return new Dolar(aux);
            //double aux = d.GetCantidad * Dolar.GetCotizacion - e.GetCantidad * Euro.GetCotizacion;
            //return new Dolar((float)(aux / Dolar.GetCotizacion));
            //
        }
        public static bool operator ==(Dolar d, Euro e)
        {
            double cotizDolar = double.Parse(Dolar.GetCotizacion.ToString());
            double cotizEuro = double.Parse(Euro.GetCotizacion.ToString());
            return (float)(d.GetCantidad * cotizDolar) == (float)(e.GetCantidad * cotizEuro);
            //
        }
        public static bool operator !=(Dolar d, Euro e)
        {
            return !(d == e);
            //
        }

        public static Dolar operator +(Dolar d, Peso p)
        {
            double cotizDolar = double.Parse(Dolar.GetCotizacion.ToString());
            double cotizPeso = double.Parse(Peso.GetCotizacion.ToString());

            double aux = (((d.GetCantidad * cotizDolar) + (p.GetCantidad * cotizPeso)) / cotizDolar);
            return new Dolar(aux);
            //double aux = d.GetCantidad * Dolar.GetCotizacion + p.GetCantidad * Peso.GetCotizacion;
            //return new Dolar((float)(aux / Dolar.GetCotizacion));
            //
        }
        public static Dolar operator -(Dolar d, Peso p)
        {
            double cotizDolar = double.Parse(Dolar.GetCotizacion.ToString());
            double cotizPeso = double.Parse(Peso.GetCotizacion.ToString());

            double aux = (((d.GetCantidad * cotizDolar) - (p.GetCantidad * cotizPeso)) / cotizDolar);
            return new Dolar(aux);
            //double aux = d.GetCantidad * Dolar.GetCotizacion - p.GetCantidad * Peso.GetCotizacion;
            //return new Dolar((float)(aux / Dolar.GetCotizacion));   
            //
        }
        public static bool operator ==(Dolar d, Peso p)
        {
            double cotizDolar = double.Parse(Dolar.GetCotizacion.ToString());
            double cotizPeso = double.Parse(Peso.GetCotizacion.ToString());
            return (float)(d.GetCantidad * cotizDolar) == (float)(p.GetCantidad * cotizPeso);
            //
        }
        public static bool operator !=(Dolar d, Peso p)
        {
            return !(d == p);
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
        public static implicit operator double(Dolar d)
        {
            return d.cantidad;
        }
        public static implicit operator Dolar(double d)
        {
            return new Dolar(d);
            //
        }
        public static explicit operator Euro(Dolar d)
        {
            double cotizDolar = double.Parse(Dolar.GetCotizacion.ToString());
            double cotizEuro = double.Parse(Euro.GetCotizacion.ToString());
            double aux = (d.cantidad * cotizDolar) / cotizEuro;
            return new Euro(aux);
        }
        public static explicit operator Peso(Dolar d)
        {
            double cotizDolar = double.Parse(Dolar.GetCotizacion.ToString());
            double cotizPeso = double.Parse(Peso.GetCotizacion.ToString());
            double aux = (d.cantidad * cotizDolar) / cotizPeso;
            return new Peso(aux);
        }
    }
    
}
