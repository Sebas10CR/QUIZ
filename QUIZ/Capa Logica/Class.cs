using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using QUIZ.Capa_Modelo;

namespace QUIZ.Capa_Logica
{
    public class Class
    {

        public static int AddClass(int SchoolID, string ClassName, string Descripcion)
        {
            int retorno = 0;

            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = DBconn.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("AddClass", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@SchoolID", SchoolID));
                    cmd.Parameters.Add(new SqlParameter("@ClassName", ClassName));
                    cmd.Parameters.Add(new SqlParameter("@Descripcion", Descripcion));



                    retorno = cmd.ExecuteNonQuery();
                }
            }
            catch (System.Data.SqlClient.SqlException)
            {
                retorno = -1;
            }
            finally
            {
                Conn.Close();
            }

            return retorno;
        }

        public static int DelClass(int ClassID)
        {
            int retorno = 0;

            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = DBconn.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("DelClass", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@ClassID", ClassID));




                    retorno = cmd.ExecuteNonQuery();
                }
            }
            catch (System.Data.SqlClient.SqlException)
            {
                retorno = -1;
            }
            finally
            {
                Conn.Close();
            }

            return retorno;
        }

        public static int ModifClass(int ClassID, int SchoolID, string ClassName, string Descripcion)
        {
            int retorno = 0;

            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = DBconn.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("ModifSchool", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@ClassID", ClassID));
                    cmd.Parameters.Add(new SqlParameter("@SchoolID", SchoolID));
                    cmd.Parameters.Add(new SqlParameter("@ClassName", ClassName));
                    cmd.Parameters.Add(new SqlParameter("@Descripcion", Descripcion));



                    retorno = cmd.ExecuteNonQuery();
                }
            }
            catch (System.Data.SqlClient.SqlException)
            {
                retorno = -1;
            }
            finally
            {
                Conn.Close();
            }

            return retorno;
        }

        public static int ConsultarClass(int ClassID, string ClassName)
        {
            int retorno = 0;

            SqlConnection Conn = new SqlConnection();
         
           
            try
            {
                using (Conn = DBconn.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("ConsultarClass", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@ClassID", ClassID));
                    cmd.Parameters.Add(new SqlParameter("@ClassName", ClassName));



                    retorno = cmd.ExecuteNonQuery();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                     
                    }
                }
            }
            catch (System.Data.SqlClient.SqlException)
            {
                return -1;
            }
            finally
            {
                Conn.Close();
             
            }

            return retorno;
        }
    }
}