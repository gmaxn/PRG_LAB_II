using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscalasTemperatura
{
    public class Celsius
    {
        // Atributos
        private double cantidad;
        private static float equivalenteEnKelvin;

        // Getters - Setters - Indexers
        public double GetCantidad
        {
            get { return this.cantidad; }
            //
        }
        public static float GetEquivalencia
        {
            get { return Celsius.equivalenteEnKelvin; }
            //
        }

        // Constructores
        private Celsius()
        {
            Celsius.equivalenteEnKelvin = (float)(274.15);
        }
        public Celsius(double cantidad)
        {
            this.cantidad = cantidad;
        }

        // Sobrecarga de Operadores
        public static bool operator ==(Celsius ca, Celsius cb)
        {
            return (ca.GetCantidad == cb.GetCantidad);
            //
        }
        public static bool operator !=(Celsius ca, Celsius cb)
        {
            return !(ca == cb);
            //
        }

        public static Celsius operator +(Celsius c, Kelvin k)
        {
            double eqCelsius = double.Parse(Celsius.GetEquivalencia.ToString());
            double eqKelvin = double.Parse(Kelvin.GetEquivalencia.ToString());

            double aux = (((c.GetCantidad * eqCelsius) + (k.GetCantidad * eqKelvin)) / eqKelvin);
            return new Celsius(aux);

        }
        public static Celsius operator -(Celsius c, Kelvin k)
        {
            double cotizDolar = double.Parse(Dolar.GetCotizacion.ToString());
            double cotizEuro = double.Parse(Euro.GetCotizacion.ToString());

            double aux = (((d.GetCantidad * cotizDolar) - (e.GetCantidad * cotizEuro)) / cotizDolar);
            return new Dolar(aux);
            //double aux = d.GetCantidad * Dolar.GetCotizacion - e.GetCantidad * Euro.GetCotizacion;
            //return new Dolar((float)(aux / Dolar.GetCotizacion));
            //
        }
        public static bool operator ==(Celsius c, Kelvin k)
        {
            double cotizDolar = double.Parse(Dolar.GetCotizacion.ToString());
            double cotizEuro = double.Parse(Euro.GetCotizacion.ToString());
            return (float)(d.GetCantidad * cotizDolar) == (float)(e.GetCantidad * cotizEuro);
            //
        }
        public static bool operator !=(Celsius c, Kelvin k)
        {
            return !(d == e);
            //
        }

        public static Celsius operator +(Celsius c, Fahrenheit f)
        {
            double cotizDolar = double.Parse(Dolar.GetCotizacion.ToString());
            double cotizPeso = double.Parse(Peso.GetCotizacion.ToString());

            double aux = (((d.GetCantidad * cotizDolar) + (p.GetCantidad * cotizPeso)) / cotizDolar);
            return new Dolar(aux);
            //double aux = d.GetCantidad * Dolar.GetCotizacion + p.GetCantidad * Peso.GetCotizacion;
            //return new Dolar((float)(aux / Dolar.GetCotizacion));
            //
        }
        public static Celsius operator -(Celsius c, Fahrenheit f)
        {
            double cotizDolar = double.Parse(Dolar.GetCotizacion.ToString());
            double cotizPeso = double.Parse(Peso.GetCotizacion.ToString());

            double aux = (((d.GetCantidad * cotizDolar) - (p.GetCantidad * cotizPeso)) / cotizDolar);
            return new Dolar(aux);
            //double aux = d.GetCantidad * Dolar.GetCotizacion - p.GetCantidad * Peso.GetCotizacion;
            //return new Dolar((float)(aux / Dolar.GetCotizacion));   
            //
        }
        public static bool operator ==(Celsius c, Fahrenheit f)
        {
            double cotizDolar = double.Parse(Dolar.GetCotizacion.ToString());
            double cotizPeso = double.Parse(Peso.GetCotizacion.ToString());
            return (float)(d.GetCantidad * cotizDolar) == (float)(p.GetCantidad * cotizPeso);
            //
        }
        public static bool operator !=(Celsius c, Fahrenheit f)
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
        public static implicit operator double(Celsius c)
        {
            return d.cantidad;
        }
        public static implicit operator Celsius(double d)
        {
            return new Dolar(d);
            //
        }
        public static explicit operator Kelvin(Celsius c)
        {
            double cotizDolar = double.Parse(Dolar.GetCotizacion.ToString());
            double cotizEuro = double.Parse(Euro.GetCotizacion.ToString());
            double aux = (d.cantidad * cotizDolar) / cotizEuro;
            return new Euro(aux);
        }
        public static explicit operator Fahrenheit(Celsius c)
        {
            double cotizDolar = double.Parse(Dolar.GetCotizacion.ToString());
            double cotizPeso = double.Parse(Peso.GetCotizacion.ToString());
            double aux = (d.cantidad * cotizDolar) / cotizPeso;
            return new Peso(aux);
        }
    }
}
