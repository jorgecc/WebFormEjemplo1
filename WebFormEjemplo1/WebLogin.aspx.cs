using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebFormEjemplo1.base2;
using WebFormEjemplo1.dal;
using WebFormEjemplo1.servicio;

namespace WebFormEjemplo1
{
    public partial class WebLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonLogin_Click(object sender, EventArgs e)
        {
            // crear el objeto usuario usando la funcion factory y los dos cuadros de texto

            Usuario usuarioIngresado=UsuarioServicio.FactoryLogin(TxtUsuario,TxtClave);

            string encriptacion=Util.Base64Encode(  Util.Encriptar(TxtClave.Text));
            // clave admin= Pz8/P3E/YDE/Pz8/fj8BP394SgorPz8/Pz8/GT8be04=

            Usuario usuarioBase =UsuarioDAL.Validar(usuarioIngresado);

            if (usuarioBase==null)
            {
                PanelError.Visible=true;
            } else
            {
                PanelError.Visible = false;
                // guardar la sesion
                Session["usuario"]= usuarioBase; // genero una cookie

                Response.Redirect("WebListado.aspx");
            }


        }
    }
}