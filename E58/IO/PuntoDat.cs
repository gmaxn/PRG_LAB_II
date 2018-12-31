using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace IO
{
    [Serializable] //--> para poder serializar hay que etiqutar a la clase padre.
    public class PuntoDat : Archivo, IArchivos<PuntoDat>
    {
        private string contenido;
        public string Contenido
        {
            get { return this.contenido; }
            set { this.contenido = value; }
        }

        public PuntoDat()
        {

        }

        public bool Guardar(string ruta, PuntoDat obj)
        {
            FileStream stream = new FileStream(ruta, FileMode.Create, FileAccess.Write, FileShare.None);
            BinaryFormatter formatter = new BinaryFormatter();

            try
            {
                formatter.Serialize(stream, obj);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
            finally
            {
                stream.Close();
            }
        }
        public PuntoDat Leer(string ruta)
        {
            FileStream stream = new FileStream(ruta, FileMode.Open, FileAccess.Read, FileShare.Read);
            BinaryFormatter formatter = new BinaryFormatter();

            try
            {
                return (PuntoDat)formatter.Deserialize(stream);
            }
            catch (Exception e)
            {
                return default(PuntoDat);
            }
            finally
            {
                stream.Close();
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
