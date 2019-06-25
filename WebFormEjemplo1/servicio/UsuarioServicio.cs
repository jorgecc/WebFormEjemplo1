using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using WebFormEjemplo1.base2;

namespace WebFormEjemplo1.servicio
{
    public class UsuarioServicio
    {
        public static Usuario FactoryLogin(TextBox txtUsuario,TextBox txtClave)
        {
            var usuario=new Usuario();
            usuario.NombreCuenta=txtUsuario.Text;
            usuario.Clave=txtClave.Text;
            return usuario;
        }
    }
}