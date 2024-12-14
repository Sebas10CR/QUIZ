using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace QUIZ.Capa_Logica
{
    public class School
    {

        public static int AddSchool(string SchoolName, string Descripcion, string Addres, string Phone, string PostCode, string PostAddress)
        {
            int retorno = 0;

            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = DBconn.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("AddSchool", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@SchoolName", SchoolName));
                    cmd.Parameters.Add(new SqlParameter("@Descripcion", Descripcion));
                    cmd.Parameters.Add(new SqlParameter("@Addres", Addres));
                    cmd.Parameters.Add(new SqlParameter("@Phone", Phone));
                    cmd.Parameters.Add(new SqlParameter("@PostCode", PostCode));
                    cmd.Parameters.Add(new SqlParameter("@PostAddress", PostAddress));



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

        public static int DelSchool(int SchoolID)
        {
            int retorno = 0;

            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = DBconn.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("DelSchool", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@SchoolID", SchoolID));




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

        public static int ModifSchool(int SchoolID,string SchoolName, string Descripcion, string Addres, string Phone, string PostCode, string PostAddress)
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
                    cmd.Parameters.Add(new SqlParameter("@SchoolID", SchoolID));
                    cmd.Parameters.Add(new SqlParameter("@SchoolName", SchoolName));
                    cmd.Parameters.Add(new SqlParameter("@Descripcion", Descripcion));
                    cmd.Parameters.Add(new SqlParameter("@Addres", Addres));
                    cmd.Parameters.Add(new SqlParameter("@Phone", Phone));
                    cmd.Parameters.Add(new SqlParameter("@PostCode", PostCode));
                    cmd.Parameters.Add(new SqlParameter("@PostAddress", PostAddress));



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


        public static int ConsultarSchool(int SchoolID, string SchoolName)
        {
            int retorno = 0;

            SqlConnection Conn = new SqlConnection();


            try
            {
                using (Conn = DBconn.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("ConsultarSchool", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@SchoolID", SchoolID));
                    cmd.Parameters.Add(new SqlParameter("@SchoolName", SchoolName));



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
}
