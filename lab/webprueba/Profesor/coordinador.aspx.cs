using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webprueba
{
    public partial class coordinador : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            usuarioNube.WebServiceValor sw = new usuarioNube.WebServiceValor();
            int valor = sw.CalcularValorMedio(DropDownList1.SelectedValue.ToString());
            if (valor == -1)
                lblValor.Text = "La materia seleccionada no tiene tareas terminadas por ningun alumno";
            else
            {
                lblValor.Text = valor.ToString();
            }

        }
    }
}