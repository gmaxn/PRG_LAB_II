using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Euro
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
            get { return Euro.cotizRespectoDolar; }
            //
        }

        //Constructores
        private Euro()
        {
            Euro.cotizRespectoDolar = (float)(1.3642);
        }
        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }
        public Euro(double cantidad, float cotizacion)
        {
            this.cantidad = cantidad;
            Euro.cotizRespectoDolar = cotizacion;
        }

        // Sobrecarga de Operadores
        public static Euro operator +(Euro e, Dolar d)
        {
            return new Euro((double)e + (double)(Euro)d);
        }
        public static Euro operator -(Euro e, Dolar d)
        {
            return new Euro((double)e - (double)(Euro)d);
        }
        public static bool operator ==(Euro e, Dolar d)
        {
            return (float)((double)e) == (float)((double)(Euro)d); 
        }
        public static bool operator !=(Euro e, Dolar d)
        {
            return !(e == d);
        }

        public static bool operator ==(Euro ea, Euro eb)
        {
            return ((double)ea == (double)eb);
        }
        public static bool operator !=(Euro ea, Euro eb)
        {
            return !(ea == eb);
        }

        public static Euro operator +(Euro e, Peso p)
        {
            return new Euro((double)e + (double)(Euro)p);
        }
        public static Euro operator -(Euro e, Peso p)
        {
            return new Euro((double)e - (double)(Euro)p);
        }
        public static bool operator ==(Euro e, Peso p)
        {
            return (float)((double)e) == (float)((double)(Euro)p); 
        }
        public static bool operator !=(Euro e, Peso p)
        {
            return !(e == p);
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
        public static implicit operator double(Euro e)
        {
            return e.cantidad;
        }
        public static implicit operator Euro(double d)
        {
            return new Euro(d);
            //
        }
        public static explicit operator Dolar(Euro e)
        {
            return new Dolar((double)e * double.Parse(Euro.GetCotizacion.ToString())) / double.Parse(Dolar.GetCotizacion.ToString());
        }
        public static explicit operator Peso(Euro e)
        {
            return new Peso((double)e * double.Parse(Euro.GetCotizacion.ToString())) / double.Parse(Peso.GetCotizacion.ToString());            
        }
    }
}
