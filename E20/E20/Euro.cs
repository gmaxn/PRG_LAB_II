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
            double cotizEuro = double.Parse(Euro.GetCotizacion.ToString());
            double cotizDolar = double.Parse(Dolar.GetCotizacion.ToString());

            double aux = (((e.GetCantidad * cotizEuro) + (d.GetCantidad * cotizDolar))/cotizEuro);
            return new Euro(aux);
            //return new Euro((float)(aux / Euro.GetCotizacion));
        }
        public static Euro operator -(Euro e, Dolar d)
        {
            double cotizEuro = double.Parse(Euro.GetCotizacion.ToString());
            double cotizDolar = double.Parse(Dolar.GetCotizacion.ToString());

            double aux = (((e.GetCantidad * cotizEuro) - (d.GetCantidad * cotizDolar)) / cotizEuro);
            return new Euro(aux);

            //double aux = e.GetCantidad * Euro.GetCotizacion + d.GetCantidad * Dolar.GetCotizacion;
            //return new Euro((float)(aux / Euro.GetCotizacion));
            //
        }
        public static bool operator ==(Euro e, Dolar d)
        {
            return (float)(e.GetCantidad * Euro.GetCotizacion) == (float)(d.GetCantidad * Dolar.GetCotizacion);
            //
        }
        public static bool operator !=(Euro e, Dolar d)
        {
            return !(e == d);
            //
        }

        public static bool operator ==(Euro ea, Euro eb)
        {
            return (ea.GetCantidad == eb.GetCantidad);
            //
        }
        public static bool operator !=(Euro ea, Euro eb)
        {
            return !(ea == eb);
            //
        }

        public static Euro operator +(Euro e, Peso p)
        {
            double cotizEuro = double.Parse(Euro.GetCotizacion.ToString());
            double cotizDolar = double.Parse(Peso.GetCotizacion.ToString());

            double aux = (((e.GetCantidad * cotizEuro) + (p.GetCantidad * cotizDolar)) / cotizEuro);
            return new Euro(aux);
            //double aux = e.GetCantidad * Euro.GetCotizacion + p.GetCantidad * Peso.GetCotizacion;
            //return new Euro((float)(aux / Euro.GetCotizacion));
            //
        }
        public static Euro operator -(Euro e, Peso p)
        {
            double cotizEuro = double.Parse(Euro.GetCotizacion.ToString());
            double cotizDolar = double.Parse(Peso.GetCotizacion.ToString());

            double aux = (((e.GetCantidad * cotizEuro) - (p.GetCantidad * cotizDolar)) / cotizEuro);
            return new Euro(aux);
            //double aux = e.GetCantidad * Euro.GetCotizacion - p.GetCantidad * Peso.GetCotizacion;
            //return new Euro((float)(aux / Euro.GetCotizacion));            
            //
        }
        public static bool operator ==(Euro e, Peso p)
        {
            throw new NotImplementedException();
            //
        }
        public static bool operator !=(Euro e, Peso p)
        {
            return !(e == p);
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
            throw new NotImplementedException();
            //
        }
        public static explicit operator Peso(Euro e)
        {
            throw new NotImplementedException();
            //
        }
    }
}
