using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace IO
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class ArchivoIncorrectoException : Exception
    {
        public ArchivoIncorrectoException(string mensaje)
            : base(mensaje)
        {

        }
        public ArchivoIncorrectoException(string mensaje, Exception innerException)
            : base(mensaje, innerException)
        {

        }
    }
    public interface IArchivos<T>
    {
        bool Guardar(string ruta, T obj);
        T Leer(string ruta);
    }
    public abstract class Archivo
    {
        protected virtual bool ValidarArchivo(string ruta)
        {
            if(!File.Exists(ruta))
            {
                throw new FileNotFoundException();
            }
            return true;
        }
    }
    public class PuntoDat : Archivo, IArchivos<PuntoDat>
    {
        string contenido;
        public string Contenido
        {
            get { return this.contenido; }
            set { this.contenido = value; }
        }

        public bool Guardar(string ruta, PuntoDat obj)
        {
            throw new NotImplementedException();
        }

        public PuntoDat Leer(string ruta)
        {
            throw new NotImplementedException();
        }

        protected override bool ValidarArchivo(string ruta)
        {
            try
            {
                base.ValidarArchivo(ruta);
                if (Path.GetExtension(ruta) == ".dat")
                {
                    return true;
                }
                throw new ArchivoIncorrectoException("El archivo no es un dat.");
            }
            catch (Exception ex)
            {
                throw new ArchivoIncorrectoException("El archivo no es correcto.", ex.InnerException);
            }
        }

    }
    public class PuntoTxt : Archivo, IArchivos<string>
    {
        public bool Guardar(string ruta, string obj)
        {
            throw new NotImplementedException();
        }

        public string Leer(string ruta)
        {
            throw new NotImplementedException();
        }

        protected override bool ValidarArchivo(string ruta)
        {
            try
            {
                base.ValidarArchivo(ruta);
                if (Path.GetExtension(ruta) == ".dat")
                {
                    return true;
                }
                throw new ArchivoIncorrectoException("El archivo no es un dat.");
            }
            catch (Exception ex)
            {
                throw new ArchivoIncorrectoException("El archivo no es correcto.", ex.InnerException);
            }
        }
    }
}
