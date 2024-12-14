using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using QUIZ.Capa_Modelo;
using QUIZ.Capa_Logica;

namespace QUIZ.Capa_Vista
{
    public partial class ESCUELA : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LlenarGrid();
            LlenarGrid2();
        }

        public static void MostrarAlerta(Page page, string message)
        {
            string script = $"<script type='text/javascript'>alert('{message}');</script>";
            ClientScriptManager cs = page.ClientScript;
            cs.RegisterStartupScript(page.GetType(), "AlertScript", script);
        }

        //METODO PARA AGREGAR ESCUELAS
        protected void bAgregar_Click(object sender, EventArgs e)
        {

            clsSchool.SchoolName = tNombre.Text;
            clsSchool.Descripcion = tDescripcion.Text;
            clsSchool.Addres = tAddres.Text;
            clsSchool.Phone = tPhone.Text;
            clsSchool.PostCode = tPostCode.Text;
            clsSchool.PostAddress = tPostAddress.Text;
            if (School.AddSchool(clsSchool.SchoolName, clsSchool.Descripcion, clsSchool.Addres, clsSchool.Phone, clsSchool.PostCode, clsSchool.PostAddress) > 0)
            {
                MostrarAlerta(this, "----Escuela Ingresada Correctamente----");
                LlenarGrid();
            }
            else
            {
                MostrarAlerta(this, "Error al ingresar usuario :(...");
            }
        }
        //METODO PARA ELIMINAR ESCUELAS
        protected void bBorrar_Click(object sender, EventArgs e)
        {
            clsSchool.SchoolID = int.Parse(tID.Text);
            if (School.DelSchool(clsSchool.SchoolID) > 0)
            {
                MostrarAlerta(this, "----Escuela Eliminada Correctamente----");
                LlenarGrid();
            }
            else
            {
                MostrarAlerta(this, "Error al eliminar Escuela :(...");
            }
        }
        //METODO PARA MODIFICAR ESCUELAS
        protected void bModificar_Click(object sender, EventArgs e)
        {
            clsSchool.SchoolID = int.Parse(tID.Text);
            clsSchool.SchoolName = tNombre.Text;
            clsSchool.Descripcion = tDescripcion.Text;
            clsSchool.Addres = tAddres.Text;
            clsSchool.Phone = tPhone.Text;
            clsSchool.PostCode = tPostCode.Text;
            clsSchool.PostAddress = tPostAddress.Text;
            if (School.ModifSchool(clsSchool.SchoolID,clsSchool.SchoolName, clsSchool.Descripcion, clsSchool.Addres, clsSchool.Phone, clsSchool.PostCode, clsSchool.PostAddress) > 0)
            {
                MostrarAlerta(this, "----Escuela Modificada Correctamente----");
                LlenarGrid();
            }
            else
            {
                MostrarAlerta(this, "Error al Modificar Escuela :(...");
            }

        }
        //METODO PARA CONSULTAR ESCUELAS
        protected void bConsultar_Click(object sender, EventArgs e)
            {
            clsSchool.SchoolID = int.Parse(tID.Text);
            clsSchool.SchoolName = tNombre.Text;
            if (Class.ConsultarClass(clsSchool.SchoolID, clsSchool.SchoolName) > 0)
            {
                MostrarAlerta(this, "----Consulta Realizada Correctamente----");
                LlenarGrid2();
            }
            else
            {
                MostrarAlerta(this, "Error al Consultar Escuela :(...");
            }
        }
        

        //METODO PARA INGRESAR ClASES
        protected void bAgregar2_Click(object sender, EventArgs e)
        {
           
            clsClass.SchoolID = int.Parse(tSchoolID.Text);
            clsClass.ClassName = tClassName.Text;
            clsClass.Descripcion= tDescripcion2.Text;

            if (Class.AddClass(clsClass.SchoolID , clsClass.ClassName, clsClass.Descripcion) > 0)
            {
                MostrarAlerta(this, "----Clase Ingresada Correctamente----");
                LlenarGrid2();
            }
            else
            {
                MostrarAlerta(this, "Error al ingresar Clase :(...");
            }
        }
        //METODO PARA BORRAR CLASES
        protected void bBorrar2_Click(object sender, EventArgs e)
        {

            clsClass.ClassID = int.Parse(tID2.Text);
            if (Class.DelClass(clsClass.ClassID) > 0)
            {
                MostrarAlerta(this, "----Clase Elimanda Correctamente----");
                LlenarGrid2();
            }
            else
            {
                MostrarAlerta(this, "Error al Eliminar Clase :(...");
            }
        }
        //METODO PARA MODIFICAR CLASES
        protected void bModificar2_Click(object sender, EventArgs e)
        {
            clsClass.ClassID = int.Parse(tID2.Text);
            clsClass.SchoolID = int.Parse(tSchoolID.Text);
            clsClass.ClassName = tClassName.Text;
            clsClass.Descripcion = tDescripcion2.Text;

            if (Class.ModifClass(clsClass.ClassID, clsClass.SchoolID, clsClass.ClassName, clsClass.Descripcion) > 0)
            {
                MostrarAlerta(this, "----Tecnico Modificado Correctamente----");
                LlenarGrid2();
            }
            else
            {
                MostrarAlerta(this, "Error al Modificar tecnico :(...");
            }

        }

        //METODO PARA CONSULTAR CLASES

        protected void bConsultar2_Click(object sender, EventArgs e)
        {
            clsClass.ClassID = int.Parse(tID2.Text);
            clsClass.ClassName = tClassName.Text;
            if (Class.ConsultarClass(clsClass.ClassID, clsClass.ClassName) > 0)
            {
                MostrarAlerta(this, "----Consulta Realizada Correctamente----");
                LlenarGrid2();
            }
            else
            {
                MostrarAlerta(this, "Error al Consultar Clase :(...");
            }
        }






        protected void LlenarGrid()
        {
            string constr = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT *  FROM School"))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            GridView1.DataSource = dt;
                            GridView1.DataBind();//Refrescar
                        }
                    }
                }
            }
        }
        protected void LlenarGrid2()
        {
            string constr = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT *  FROM Class"))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            GridView2.DataSource = dt;
                            GridView2.DataBind();//Refrescar
                        }
                    }
                }
            }



        }

        

        
    }
}