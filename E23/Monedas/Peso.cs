using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monedas
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
            return new Peso((double)p + (double)(Peso)d);
        }
        public static Peso operator -(Peso p, Dolar d)
        {
            return new Peso((double)p - (double)(Peso)d);
        }
        public static bool operator ==(Peso p, Dolar d)
        {
            return (float)((double)p) == (float)((double)(Peso)d);
        }
        public static bool operator !=(Peso p, Dolar d)
        {
            return !(p == d);
        }


        public static Peso operator +(Peso p, Euro e)
        {
            return new Peso((double)p + (double)(Peso)e);
        }
        public static Peso operator -(Peso p, Euro e)
        {
            return new Peso((double)p - (double)(Peso)e);
        }
        public static bool operator ==(Peso p, Euro e)
        {
            return (float)((double)p) == (float)((double)(Peso)e);
        }
        public static bool operator !=(Peso p, Euro e)
        {
            return !(p == e);
        }


        public static bool operator ==(Peso pa, Peso pb)
        {
            return ((double)pa == (double)pb);
        }
        public static bool operator !=(Peso pa, Peso pb)
        {
            return !(pa == pb);
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
        }
        public static explicit operator Dolar(Peso p)
        {
            return new Dolar((double)p * double.Parse(Peso.GetCotizacion.ToString())) / double.Parse(Dolar.GetCotizacion.ToString());
        }
        public static explicit operator Euro(Peso p)
        {
            return new Euro((double)p * double.Parse(Peso.GetCotizacion.ToString())) / double.Parse(Euro.GetCotizacion.ToString());
        }
    }
}
