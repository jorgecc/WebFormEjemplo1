using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using WebFormEjemplo1.base2;

namespace WebFormEjemplo1.servicio
{
    public class CompraFactory
    {
        public static Compras Factory(TextBox txtProducto
            ,TextBox txtCantidad,TextBox txtPrecio,Usuario usuarioSesion)
        {
            var compra=new Compras();
            compra.Producto=txtProducto.Text;
            compra.PrecioUnitario= Convert.ToInt32(txtPrecio.Text);
            compra.Cantidad=Convert.ToInt32(txtCantidad.Text);
            compra.UsuarioID= usuarioSesion.UsuarioId;

          
            return compra;
        }
    }
}