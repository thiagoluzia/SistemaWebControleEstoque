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
/// 
/// INSERIR PRODUTO
/// 1º Atraves do objProduto criado teremos acesso a suas propriedades, nas quais iremos preencher e depois enviar para BLL que por sua vez enviar para DAL
/// 1.1 Obj.Propriedade = campo.text,  ou seja a propriedade ira receber tudo que for digitado nos campos textBox criado na visão
/// 1.2 Como todos os campos da visão são do tipo texto e as propriedades são de tipos diferente, alguns campos terão que passar pelo processo Parse, ou seja o tipo da propriedade .Parse(e o campo do tipo text)
/// 1.3 Na categoria temos um detalhe a mais, alem do parse temos que passar o id da categoria selecionada da seguinte maneira, o nome do campo.SelectedValue.ToString(), ou seja o valor daquele campo que vem como id, porem mostramos o nome,
/// 2º Chamamos o metodo inserir produto que nao recebe nenhum parametro, mas ue ja leva consigo todas as propriedades preenchidas para inserir no banco, pois o mesmo envia o comando sql para a camada DAL  na qual tem um metodo para trabalhar com comandos sql
/// 
/// RETORNO PRODUTO BLL
/// 1º Semelhande ao carregar categoria.
/// 2º Criar uma função Carregar Data Grid
/// 2.1 O DataGrideProdutos atraves do data source, recebe o caminho para a base de dados que é o objeto produto que utiliza o metodo que retorna uma lista de produtos 
/// 2.2 E efetua a consolidação atraves do Bind
/// 3º Chamar a função dentro do page load, para sempre que a pagina for carregada, ele recarrega os dados
/// </summary>

public partial class Produto : System.Web.UI.Page
{
    ProdutoBLL objProduto = new ProdutoBLL();
    protected void Page_Load(object sender, EventArgs e)
    {
        CarregarCategorias();
        CarregarGridView();
    }

    private void CarregarCategorias()
    {
        ddlCategoriaProduto.DataSource = objProduto.RetornarCategoriaProduto();
        ddlCategoriaProduto.DataValueField = "id";
        ddlCategoriaProduto.DataTextField = "nome";
        ddlCategoriaProduto.DataBind();
    }

    private void CarregarGridView()
    {
        gridProdutos.DataSource = objProduto.RetListarProdutos();
        gridProdutos.DataBind();
    }

    protected void btnGravar_Click(object sender, EventArgs e)
    {
        objProduto.Nome = txtNome.Text;
        objProduto.Desscricao = txtDescricao.Text;
        objProduto.Preco_Custo = decimal.Parse(txtPrecoCusto.Text);
        objProduto.Preco_Venda = decimal.Parse(txtPrecoVenda.Text);
        objProduto.Quantidade = int.Parse(txtQuantidade.Text);
        objProduto.Unidade_Medida = txtUnidade_Medida.Text;
        objProduto.Categoria_ID = int.Parse(ddlCategoriaProduto.SelectedValue.ToString());
        objProduto.InserirProduto();
    }
}