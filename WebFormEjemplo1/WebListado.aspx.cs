using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebFormEjemplo1.dal;

namespace WebFormEjemplo1
{
    public partial class WebListado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataSource=UsuarioDAL.ListarTodo();
            GridView1.DataBind();

        }
    }
}