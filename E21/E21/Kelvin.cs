using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscalasTemperatura
{
    public class Kelvin
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
            get { return Kelvin.equivalenteEnKelvin; }
            //
        }

        // Constructores
        private Kelvin()
        {
            Kelvin.equivalenteEnKelvin = (float)(1);
        }
        public Kelvin(double cantidad)
        {
            this.cantidad = cantidad;
        }

        // Sobrecarga de Operadores
        public static bool operator ==(Kelvin ka, Kelvin kb)
        {
            return ((float)(double)ka == (float)(double)kb);
            //
        }
        public static bool operator !=(Kelvin ka, Kelvin kb)
        {
            return !(ka == kb);
            //
        }

        public static Kelvin operator +(Kelvin k, Celsius c)
        {
            return new Kelvin((double)k + (double)((Kelvin)c));
        }
        public static Kelvin operator -(Kelvin k, Celsius c)
        {
            return new Kelvin((double)k - (double)((Kelvin)c));
        }
        public static bool operator ==(Kelvin k, Celsius c)
        {
            return ((float)(double)k == (float)(double)((Kelvin)c));
        }
        public static bool operator !=(Kelvin k, Celsius c)
        {
            return !(k == c);
            //
        }

        public static Kelvin operator +(Kelvin k, Fahrenheit f)
        {
            return new Kelvin((double)k + (double)((Kelvin)f));
        }
        public static Kelvin operator -(Kelvin k, Fahrenheit f)
        {
            return new Kelvin((double)k - (double)((Kelvin)f));
        }
        public static bool operator ==(Kelvin k, Fahrenheit f)
        {
            return ((float)(double)k == (float)(double)((Kelvin)f));
        }
        public static bool operator !=(Kelvin k, Fahrenheit f)
        {
            return !(k == f);
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
        public static implicit operator double(Kelvin k)
        {
            return k.cantidad;
        }
        public static implicit operator Kelvin(double d)
        {
            return new Kelvin(d);
            //
        }
        public static explicit operator Celsius(Kelvin k)
        {
            return new Celsius((double)k - 273.15);
        }
        public static explicit operator Fahrenheit(Kelvin k)
        {
            return new Fahrenheit((((double)k - 273.15) * 9 / 5) + 32);
        }
    }
}
