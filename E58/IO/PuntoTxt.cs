using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IO
{
    public class PuntoTxt : Archivo, IArchivos<string>
    {
        public bool Guardar(string ruta, string obj)
        {
            try
            {
                using (StreamWriter file = new StreamWriter(ruta, false))
                {
                    file.WriteLine(obj);
                }
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public string Leer(string ruta)
        {
            string datos;
            try
            {
                using (StreamReader file = new StreamReader(ruta))
                {
                    datos = file.ReadToEnd();
                }
                return datos;
            }
            catch (Exception e)
            {
                throw new FileNotFoundException();
            }
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
