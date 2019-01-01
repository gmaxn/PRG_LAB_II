using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace MiBiblioteca
{
    public class PersonaDAO
    {
        private static SqlConnection _conexion;
        private static SqlCommand _comandos;

        static string conectionSetting = @"Server=LAPTOP-MXN\SQLEXPRESS01;
                                           Database=Persona;
                                           Integrated Security=SSPI;";

        static PersonaDAO()
        {
            // 1. Genero la conexion, 2. Genero los Comandos
            PersonaDAO._conexion = new SqlConnection(conectionSetting);
            PersonaDAO._comandos = new SqlCommand();

            // 3. Determino el tipo de comando, 4. Establezco la Conexion
            PersonaDAO._comandos.CommandType = CommandType.Text;
            PersonaDAO._comandos.Connection = PersonaDAO._conexion;
        }
        private static bool EjecutarNonQuery(string cmd)
        {
            bool exito = false;

            try
            {
                PersonaDAO._conexion.Open();
                PersonaDAO._comandos.CommandText = cmd;
                PersonaDAO._comandos.ExecuteNonQuery();
                exito = true;
            }
            catch (Exception e)
            {
                exito = false;
            }
            finally
            {
               if (exito)
                    PersonaDAO._conexion.Close();
            }
            return exito;
        }

        public static List<Persona> ObtenerPersonas()
        {
            List<Persona> g = new List<Persona>();
            StringBuilder sb = new StringBuilder();

            try
            {
                sb.AppendFormat("select * FROM Personas");

                PersonaDAO._comandos.CommandText = sb.ToString();
                PersonaDAO._conexion.Open();

                SqlDataReader reader = PersonaDAO._comandos.ExecuteReader();

                while (reader.Read())
                {
                    g.Add(new Persona((int)reader["id"], reader["nombre"].ToString(), reader["apellido"].ToString()));

                }
            }
            catch (Exception e)
            {
                throw new Exception("Error al leer en la tabla Persona", e);
            }
            finally
            {
                PersonaDAO._conexion.Close();
            }
            return g;
        }
        //Leer
        public static Persona ObtienePersona()
        {
            Persona persona = null;
            bool exito = false;

            try
            {
                PersonaDAO._conexion.Open();
                PersonaDAO._comandos.CommandText = "SELECT TOP 1 id,nombre,apellido FROM Personas";

                SqlDataReader lectura = _comandos.ExecuteReader();

                // SI HAY REGISTROS...
                if (lectura.Read())
                {
                    // ACCEDO POR NOMBRE O POR INDICE
                    persona = new Persona(int.Parse(lectura["id"].ToString()),
                                                     lectura["nombre"].ToString(),
                                                     lectura["apellido"].ToString());
                }

                lectura.Close();
                exito = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (exito)
                    _conexion.Close();
            }
            return persona;
        }

        //Guardar
        public static bool InsertaPersona(Persona p)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("INSERT INTO Personas (nombre,apellido)");
            sb.AppendFormat("VALUES( '{0}', '{1}' )", p.Nombre, p.Apellido);

            return EjecutarNonQuery(sb.ToString());
        }

        //Modificar
        public static bool ModificaPersona(Persona original, Persona nuevo)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("UPDATE Personas SET ");
            sb.AppendFormat("nombre   = '{0}',", nuevo.Nombre);
            sb.AppendFormat("apellido = '{0}'", nuevo.Apellido);
            sb.AppendFormat("WHERE id = {0}", original.ID);

            return EjecutarNonQuery(sb.ToString());
        }

        //Borrar
        public static bool EliminaPersona(Persona p)
        {
            return EjecutarNonQuery(string.Format("DELETE FROM Personas WHERE id = {0}", p.ID));
        }

        //Leer por id
        public static Persona BuscaPorId(int id)
        {
            Persona persona = null;
            bool exito = false;

            try
            {
                PersonaDAO._conexion.Open();
                PersonaDAO._comandos.CommandText = string.Format("SELECT * FROM Personas WHERE id = {0}", id);

                SqlDataReader lectura = _comandos.ExecuteReader();

                // SI HAY REGISTROS...
                if (lectura.Read())
                {
                    // ACCEDO POR NOMBRE O POR INDICE
                    persona = new Persona(int.Parse(lectura["id"].ToString()),
                                                     lectura["nombre"].ToString(),
                                                     lectura["apellido"].ToString());
                }

                lectura.Close();
                exito = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (exito)
                    _conexion.Close();
            }
            return persona;
        }
    }
}
