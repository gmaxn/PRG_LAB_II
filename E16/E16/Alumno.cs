using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E16
{
    public class Alumno
    {
        private string nombre;
        private string apellido;
        private int legajo;

        private byte _nota1;
        private byte _nota2;
        private float _notaFinal;

        public Alumno(int legajo, string apellido, string nombre)
        {
            this.legajo = legajo;
            this.apellido = apellido;
            this.nombre = nombre;
            this._notaFinal = -1;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Alumno: {0}, {1}\n", this.apellido, this.nombre);
            sb.AppendLine("Legajo: " + this.legajo);
            sb.AppendLine();
            sb.AppendLine("1º Parcial:   " + this._nota1);
            sb.AppendLine("2º Parcial:   " + this._nota2);
            sb.AppendLine("Examen final: " + ((this._notaFinal == -1) ? "Alumno desaprobado" : this._notaFinal.ToString()));
            return sb.ToString();
        }

        public void Estudiar(byte notaUno, byte notaDos)
        {
            this._nota1 = notaUno;
            this._nota2 = notaDos;
        }

        public void CalcularFinal()
        {
            if (this._nota1 >= 4 && this._nota2 >= 4)
                this._notaFinal = new Random().Next(1, 10);       
        }
    }
}
