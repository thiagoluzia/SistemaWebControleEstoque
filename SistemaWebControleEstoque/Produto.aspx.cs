using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

/// <summary>
/// RETORNO CATEGORIA BLL
/// 1º Dentro criar um objeto do tipo produto BLL, pois nela temos o metodo que comunica com o banco e pede para ele trazer um data table de retorno
/// 2º Criar uma função CarregarCategoria, pra ficar mais limpo o codigo
/// 3º Detalhes da função: vamos carregar um dropdowlist contendo os dados cadastrados no banco, 
/// 3.1 Chamar o campo criado no dropdowlist"ou seja o id criado pra ele", chamar um objeto DataSource"Busca a fonte de dados" no qual vai receber atraves do objeto criado pela ProdutoBLL invocando o metodo que retorna a categoria.
/// 3.2 Chamar o campo criado no dropdowlist, chamar um metodo que pega o valor do campo no qual obteve os dados e passar o id
/// 3.3 Chamar o campo criado no dropdowlist, chamar um metodo quepega o texto do campo no qual obteve  os dados e passar o nome
/// 3.4 Chamar o campo criado no dropdowlist, chamar um metodo data bind que vai consolidar  feito,
/// 3.5 DataSource pego o caminho, Produto.DataValueField pego o id da categoria no banco, DataTextField pego o texto de acordo com o id, DataBind consolidação do feito
/// 4 Chamar a função criada para carregar o dropdowlist dentro do Page Load, assim a cada load ele carrega
/// </summary>

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