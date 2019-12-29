using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Produto : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //teste 
        DAL objDAL = new DAL();
        objDAL.ExecutarComandoSQL("insert into categoria(nome) values('Bebidas')");
    }

    protected void txtUnidadeMedida_TextChanged(object sender, EventArgs e)
    {

    }
}