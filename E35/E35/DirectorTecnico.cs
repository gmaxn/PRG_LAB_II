using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E35
{
    public class DirectorTecnico : Persona
    {
        private DateTime fechaDeNacimiento;

        private DirectorTecnico(string nombre)
            : base(nombre)
        {

        }
        private DirectorTecnico(string nombre, DateTime fechaDeNacimiento)
            : this(nombre)
        {
            this.fechaDeNacimiento = fechaDeNacimiento;
        }
        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.MostrarDatos());
            sb.AppendFormat("Fecha de nacimiento: {0}\n", this.fechaDeNacimiento);
            return sb.ToString();
        }
        public static bool operator ==(DirectorTecnico dt1, DirectorTecnico dt2)
        {
            return (dt1.DNI == dt2.DNI);
        }
        public static bool operator !=(DirectorTecnico dt1, DirectorTecnico dt2)
        {
            return !(dt1 == dt2);
        }
    }
}
