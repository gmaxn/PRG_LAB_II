using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E8
{
    public class Empleado
    {
        // >> Campos
        private string nombre;
        private int antiguedad;
        private float valorHora;
        private int cantHorasTrabajadas;
        private float sueldo;

        // >> Propiedades
        public string Nombre
        {
            get { return this.nombre; }
        }
        public int Antiguedad
        {
            get { return this.antiguedad; }
        }
        public float ValorHora
        {
            get { return this.valorHora; }
        }
        public int CantHorasTrabajadas
        {
            get { return this.cantHorasTrabajadas; }
        }
        public float Sueldo
        {
            get { return this.sueldo; }
        }


        // >> Constructores
        public Empleado()
        { }
        public Empleado(string nombre, int antiguedad, float valorHora, int cantHorasTrabajadas)
        {
            this.nombre = nombre;
            this.antiguedad = antiguedad;
            this.valorHora = valorHora;
            this.cantHorasTrabajadas = cantHorasTrabajadas;
            this.sueldo = this.CalcularSueldo();
        }
        
        
        // >> Metodos
        private float CalcularSueldo()
        {
            float total;
            total = (this.valorHora * this.cantHorasTrabajadas);
            total += (this.antiguedad * 150);
            total -= (total * 13 / 100);
            return total;
        }
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Nombre: " + this.nombre);
            sb.AppendLine("Antiguedad: " + this.antiguedad);
            sb.AppendLine("Valor Hora: " + this.valorHora);
            sb.AppendLine("Cantidad de Horas trabajadas: " + this.cantHorasTrabajadas);
            sb.AppendLine("Sueldo: " + this.sueldo);
            return sb.ToString();
        }
    }
}
