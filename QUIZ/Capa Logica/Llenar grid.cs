using QUIZ.Capa_Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace QUIZ.Capa_Logica
{
    //public static class Llenar_grid
    {

        //public static List<clsClass> ObtenerClasesFiltro(int codigo)
        {
            int retorno = 0;
            SqlConnection Conn = new SqlConnection();
            List<clsClass> clases = new List<clsClass>();
            try
            {

                using (Conn = DBconn.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("consultarfiltro", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@id", codigo));
                    retorno = cmd.ExecuteNonQuery();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            clsClass clase = new clsClass();
                            clase.ClassID = reader.GetInt32(0);
                            clase.ClassName = reader.GetString(1);
                            clases.Add(clase);
                        }

                    }
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                return clases;
            }
            finally
            {
                Conn.Close();
                Conn.Dispose();
            }

            return clases;
        }
    }
}