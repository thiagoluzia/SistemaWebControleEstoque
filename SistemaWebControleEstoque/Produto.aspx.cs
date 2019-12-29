using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Produto : System.Web.UI.Page
{
    ProdutoBLL objProduto = new ProdutoBLL();
    protected void Page_Load(object sender, EventArgs e)
    {
        CarregarCategorias();
    }

    private void CarregarCategorias()
    {
        //sempre é executado a cada carregamento
        ddlCategoriaProduto.DataSource = objProduto.RetornarCategoriaProduto();//a fonte de dados do drop dal list é o data table que e retornado pelo metodo do produto bll, atraves do obj criado a partir do produto bll
        ddlCategoriaProduto.DataValueField = "id";
        ddlCategoriaProduto.DataTextField = "nome";
        ddlCategoriaProduto.DataBind();
    }

    protected void txtUnidadeMedida_TextChanged(object sender, EventArgs e)
    {

    }

}