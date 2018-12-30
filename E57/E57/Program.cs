using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

using System.Runtime.Serialization.Formatters.Binary;



namespace E57
{
    class Program
    {
        static void Main(string[] args)
        {
            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Persona";
            Persona p1 = new Persona("Luke", "Skywalker");

            Persona aux;

            Persona.Guardar(ruta, p1);
            aux = Persona.Leer(ruta);

            Console.WriteLine(aux.ToString());



        }
    }


    [Serializable]
    public class Persona
    {
        private string nombre;
        private string apellido;

        public string Nombre
        {
            get { return this.nombre; }
        }

        public string Apellido
        {
            get { return this.apellido; }
        }

        private Persona()
        { }

        public Persona(string nombre, string apellido)
            : base()
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public static bool Guardar(string ruta, Persona p)
        {
            FileStream stream = new FileStream(ruta, FileMode.Create, FileAccess.Write, FileShare.None);
            BinaryFormatter formatter = new BinaryFormatter();

            try
            {
                formatter.Serialize(stream, p);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Failed to serialize. Reason: " + e.Message);
                return false;
            }
            finally
            {
                stream.Close();
            }
        }
        public static Persona Leer(string ruta)
        {
            FileStream stream = new FileStream(ruta, FileMode.Open, FileAccess.Read, FileShare.Read);
            BinaryFormatter formatter = new BinaryFormatter();

            try
            {
                return (Persona)formatter.Deserialize(stream);
            }
            catch (Exception e)
            {
                return default(Persona);
            }
            finally
            {
                stream.Close();
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Nombre: {0}\n", this.Nombre);
            sb.AppendFormat("Apellido: {0}\n", this.Apellido);
           
            return sb.ToString();
        }
    }
}
