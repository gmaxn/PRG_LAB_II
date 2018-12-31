using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

namespace BibliotecaSQL
{
    public static class ProductoDAO
    {
        private static SqlConnection _conexion;
        private static SqlCommand _comandos;

        static string conectionSetting = @"Server=LAPTOP-MXN\SQLEXPRESS01;
                                           Database=Production.Product;
                                           Integrated Security=SSPI;";

        static ProductoDAO()
        {
            // 1. Genero la conexion, 2. Genero los Comandos
            ProductoDAO._conexion = new SqlConnection(conectionSetting);
            ProductoDAO._comandos = new SqlCommand();

            // 3. Determino el tipo de comando, 4. Establezco la Conexion
            ProductoDAO._comandos.CommandType = CommandType.Text;
            ProductoDAO._comandos.Connection = ProductoDAO._conexion;
        }
        private static bool EjecutarNonQuery(string cmd)
        {
            bool exito = false;

            try
            {
                ProductoDAO._conexion.Open();
                ProductoDAO._comandos.CommandText = cmd;
                ProductoDAO._comandos.ExecuteNonQuery();
                exito = true;
            }
            catch (Exception e)
            {
                exito = false;
            }
            finally
            {
                if (exito)
                    ProductoDAO._conexion.Close();
            }
            return exito;
        }
        //public static Objeto ObtienePersona()
        //{
        //    Objeto persona = null;
        //    bool exito = false;

        //    try
        //    {
        //        ObjetoDAO._conexion.Open();
        //        ObjetoDAO._comandos.CommandText = "SELECT TOP 1 Name, ProductNumber, MakeFlag, FinishedGoodsFlag, Color, SafetyStockLevel, RecorderPoint, StandardCost, ListPrice, Size, Weight, DaysToManufacture, ProductLine, Class, Style, SellStartDate, SellEndDate, DiscontinuedDate, rowguid, ModifiedDate FROM Producto.Product";

        //        SqlDataReader lectura = _comandos.ExecuteReader();

        //        // SI HAY REGISTROS...
        //        if (lectura.Read())
        //        {
        //            // ACCEDO POR NOMBRE O POR INDICE
        //            persona = new Objeto(int.Parse(lectura["id"].ToString()),
        //                                             lectura["nombre"].ToString(),
        //                                             lectura["apellido"].ToString(),
        //                                  int.Parse(lectura["dni"].ToString()));
        //        }

        //        lectura.Close();
        //        exito = true;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    finally
        //    {
        //        if (exito)
        //            _conexion.Close();
        //    }
        //    return persona;
        //}
        public static bool InsertaProducto(Producto p)
        {
            DateTime dt = new DateTime(2009, 07, 28);
            string dt2 = string.Format("fecha: {0}", dt.ToUniversalTime());
            StringBuilder sb = new StringBuilder();
            sb.Append("INSERT INTO Production.CountryRegion(CountryRegionCode,Name,ModifiedDate)");
            
            sb.AppendFormat("VALUES('{0}','{1}','{2}')","AR", "Argentina", "2008-04-30 00:00:00.000");
            

            return EjecutarNonQuery(sb.ToString());
        }
        //public static bool ModificaPersona(Objeto p)
        //{
        //    StringBuilder sb = new StringBuilder();
        //    sb.Append("UPDATE Personas SET ");
        //    sb.AppendFormat("nombre   = '{0}',", p.Nombre);
        //    sb.AppendFormat("apellido = '{0}',", p.Apellido);
        //    sb.AppendFormat("dni      =  {0} ,", p.DNI.ToString());
        //    sb.AppendFormat("WHERE id =  {0}  ", p.ID.ToString());

        //    return EjecutarNonQuery(sb.ToString());
        //}
        //public static bool EliminaPersona(Objeto p)
        //{
        //    StringBuilder sb = new StringBuilder();
        //    sb.Append("DELETE FROM Personas WHERE id = " + p.ID.ToString());

        //    return EjecutarNonQuery(sb.ToString());
        //}
    }
}
