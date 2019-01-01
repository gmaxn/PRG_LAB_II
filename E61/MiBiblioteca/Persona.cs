using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


 
namespace MiBiblioteca
{
    public class Persona
    {
        private int id;
        private string nombre;
        private string apellido;

        #region Propiedades
        public int ID
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }
        public string Apellido
        {
            get { return this.apellido; }
            set { this.apellido = value; }
        }
        #endregion

        public Persona()
        {
            this.id = 0;
        }
        public Persona(string nombre, string apellido)
            : this()
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }
        public Persona(int id, string nombre, string apellido)
            : this(nombre, apellido)
        {
            this.id = id;
        }

        #region Base de datos
        public bool Guardar()
        {
            return PersonaDAO.InsertaPersona(this);
        }
        public bool Cargar()
        {
            Persona datos = PersonaDAO.ObtienePersona();

            if (datos == null)
                return false;
            else
            {
                this.id = datos.id;
                this.nombre = datos.nombre;
                this.apellido = datos.apellido;
                return true;
            }
        }
        //public bool Modificar()
        //{
        //    return PersonaDAO.ModificaPersona(this);
        //}
        public bool Eliminar()
        {
            return PersonaDAO.EliminaPersona(this);
        }
        #endregion

        public override string ToString()
        {
            return String.Format("{0} - {1} {2}", this.id, this.nombre, this.apellido);
        }
    }

  
}
