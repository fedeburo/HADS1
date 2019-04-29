using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;
using accesoDatosSQL;

namespace ServiciosWeb
{
    /// <summary>
    /// Descripción breve de WebServiceValor
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceValor : System.Web.Services.WebService
    {
        

        [WebMethod]
        public int CalcularValorMedio(string asignatura)
        {
            int retorno = 0;
            try
            {
                SqlConnection conexion = new SqlConnection();
                conexion.ConnectionString = "Server=tcp:hads.database.windows.net,1433;Initial Catalog=Amigos;Persist Security Info=False;User ID=hads;Password=JAVadillo-2018;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30; ";
                conexion.Open();
                SqlCommand comando = new SqlCommand("select avg (ET.HReales) from EstudiantesTareas ET, Asignaturas A, TareasGenericas TG where A.Nombre = @asig and A.codigo = TG.CodAsig and TG.codigo = ET.CodTarea;", conexion);
                comando.Parameters.AddWithValue("@asig", asignatura);
                retorno = (int)comando.ExecuteScalar();
                conexion.Dispose();
            }
            catch
            {
                return -1;
            }

            return retorno;
        }
    }
}
