using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monedas
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
        }
        public static float GetCotizacion
        {
            get { return Dolar.cotizRespectoDolar; }
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
            return ((double)da == (double)db);
        }
        public static bool operator !=(Dolar da, Dolar db)
        {
            return !(da == db);
        }

        public static Dolar operator +(Dolar d, Euro e)
        {
            return new Dolar((double)d + (double)(Dolar)e);
        }
        public static Dolar operator -(Dolar d, Euro e)
        {
            return new Dolar((double)d - (double)(Dolar)e);
        }
        public static bool operator ==(Dolar d, Euro e)
        {
            return (float)((double)d) == (float)((double)(Dolar)e);
        }
        public static bool operator !=(Dolar d, Euro e)
        {
            return !(d == e);
        }

        public static Dolar operator +(Dolar d, Peso p)
        {
            return new Dolar((double)d + (double)(Dolar)p);
        }
        public static Dolar operator -(Dolar d, Peso p)
        {
            return new Dolar((double)d - (double)(Dolar)p);
        }
        public static bool operator ==(Dolar d, Peso p)
        {
            return (float)((double)d) == (float)((double)(Dolar)p);
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
            return new Euro((double)d * double.Parse(Dolar.GetCotizacion.ToString())) / double.Parse(Euro.GetCotizacion.ToString());
        }
        public static explicit operator Peso(Dolar d)
        {
            return new Peso((double)d * double.Parse(Dolar.GetCotizacion.ToString())) / double.Parse(Peso.GetCotizacion.ToString());
        }
    }
}
