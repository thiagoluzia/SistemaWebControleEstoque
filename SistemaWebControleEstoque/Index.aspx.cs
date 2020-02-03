using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnProdutos_Click(object sender, EventArgs e)
    {
        Response.Redirect("Produto.aspx");
    }

    protected void btnCategorias_Click(object sender, EventArgs e)
    {
        Response.Redirect("Categoria.aspx");
    }
}