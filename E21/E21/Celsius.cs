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
            return ((float)(double)ca == (float)(double)cb);
            //
        }
        public static bool operator !=(Celsius ca, Celsius cb)
        {
            return !(ca == cb);
            //
        }

        public static Celsius operator +(Celsius c, Kelvin k)
        {
            return new Celsius((double)c + (double)((Celsius)k));
        }
        public static Celsius operator -(Celsius c, Kelvin k)
        {
            return new Celsius((double)c - (double)((Celsius)k));
        }
        public static bool operator ==(Celsius c, Kelvin k)
        {
            return ((double)(double)c == (double)(double)((Celsius)k));
        }
        public static bool operator !=(Celsius c, Kelvin k)
        {
            return !(c == k);
            //
        }

        public static Celsius operator +(Celsius c, Fahrenheit f)
        {
            return new Celsius((double)c + (double)((Celsius)f));
        }
        public static Celsius operator -(Celsius c, Fahrenheit f)
        {
            return new Celsius((double)c - (double)((Celsius)f));
        }
        public static bool operator ==(Celsius c, Fahrenheit f)
        {
            return ((float)(double)c == (float)(double)((Celsius)f));
        }
        public static bool operator !=(Celsius c, Fahrenheit f)
        {
            return !(c == f);
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
            return c.cantidad;
        }
        public static implicit operator Celsius(double d)
        {
            return new Celsius(d);
            //
        }
        public static explicit operator Kelvin(Celsius c)
        {
            return new Kelvin((double)c + 273.15);
        }
        public static explicit operator Fahrenheit(Celsius c)
        {
            return new Fahrenheit(((double)c * 9/5) + 32);
        }
    }
}
