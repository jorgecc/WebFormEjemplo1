using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebFormEjemplo1.base2;

namespace WebFormEjemplo1
{
    public partial class MaestraBootstrap : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // leer la sesion
            Usuario usuario= (Usuario)Session["usuario"];

            string logout=Request.QueryString["logout"];
            if (logout!=null)
            {
                Session.Abandon();
                usuario=null;
            }

            // si el usuario no esta, redireccionar a la pagina de login
            if (usuario==null)
            {
                Response.Redirect("WebLogin.aspx",true);  
            } else
            {
                // si el usuario esta, lo muestro en el objeto literal.
                Literal1.Text=usuario.NombreCompleto;

            }






        }
    }
}