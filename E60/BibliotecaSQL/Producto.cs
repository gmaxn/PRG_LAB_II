using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaSQL
{
    public class Producto
    {
        private string name;
        private int productNumber;

        #region Propiedades
        public int ProductNumber
        {
            get { return this.productNumber; }
            set { this.productNumber = value; }
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        #endregion

        public Producto()
        {
            this.productNumber = 0;
        }
        public Producto(string name, int productNumber)
            : this()
        {
            this.name = name;
            this.productNumber = productNumber;
        }

        #region Base de datos
        public bool Guardar()
        {
            return ProductoDAO.InsertaProducto(this);
        }
        //public bool Cargar()
        //{
        //    Producto datos = PersonaDAO.ObtienePersona();

        //    if (datos == null)
        //        return false;
        //    else
        //    {
        //        this.id = datos.id;
        //        this.nombre = datos.nombre;
        //        this.apellido = datos.apellido;
        //        this.dni = datos.dni;
        //        return true;
        //    }
        //}
        //public bool Modificar()
        //{
        //    return PersonaDAO.ModificaPersona(this);
        //}
        //public bool Eliminar()
        //{
        //    return PersonaDAO.EliminaPersona(this);
        //}
        #endregion

        public override string ToString()
        {
            return String.Format("{0}: {1}", this.name, this.productNumber);
        }
    }
}
