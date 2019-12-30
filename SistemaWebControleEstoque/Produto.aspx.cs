using System;
using System.Data;

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
/// INSERIR PRODUTO BLL
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
/// 
/// RETORNO PRODUTO PREENCHENDO OS CAMPOS BLL
/// 1º Importar o System Data
/// 2º Criar um evento click no botão para buscar um produto por id
/// 3º Criar um objeto do tipo Data Table para trabalhar com os dados retornador do banco de dados
/// 4º Atribuir o retorno dos valores de forma ordenada em seus campos
/// 4.1 O campo no qual o valor retornado do banco, sera preenchido deverá receber uma atribuição da seguinte maneira
/// 4.2 O objet data criado acessa um metodo proprio"data.Rows" que retorna uma coleção de linhas, onde deve ser passado por indexadores[indece baseado na linha da tabela a ser retornada][nome da coluna onde deseja recuperar os dados]
/// 
/// ALETRAR PRODUTO BLL
/// 1º Inserir uma logica no botão de gravar.
/// 2º caso o parametro escolhido nao for nulo ou vazio, siguinifica que vamos Gravar um novo registro no banco, basta chamar o metodo Gravar
/// 3º Caso contrario, siguinifica que vamos alterar, como isso chamamos o metodo alterar
/// 4º Al termino chamaremos o metodo que carrega o grid view para ter uma atualização do que foi feito
/// 
/// EXCLUIR PRODUTO BLL
/// 1º Uma das operações mais simples, basta criar um botão e chamar o metodo excluir produto passando o txtId como parametro
/// 2º Chamar o metodo carregar grid para ver a tabela atualizada
/// 
/// CRIANDO UMA FUNÇÃO PARA LIMPAR CAMPOS DA CAMADA DE VISÃO
/// 1º A cada operação que acontece os campos serão limpos
/// 2º Criar uma função limpar campos que nao retorna nada
/// 3º Cada campo txt deve receber uma string empty
/// 4º Chame o metodo em um novo botao limpar, e antes de carregar o grid em operações de inserir e excluir
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

        if (string.IsNullOrEmpty(txtID.Text))
        {
            objProduto.InserirProduto();
        }
        else
        {
            objProduto.AlterarProduto(txtID.Text);
        }

        LimparTela();
        CarregarGridView();

    }

    protected void btnCarregar_Click(object sender, EventArgs e)
    {
        DataTable data = objProduto.CarregarProdutoPorId(txtID.Text);
        txtNome.Text = data.Rows[0]["nome"].ToString();
        txtDescricao.Text = data.Rows[0]["descricao"].ToString();
        txtPrecoCusto.Text = data.Rows[0]["preco_custo"].ToString();
        txtPrecoVenda.Text = data.Rows[0]["preco_venda"].ToString();
        txtQuantidade.Text = data.Rows[0]["quantidade"].ToString();
        txtUnidade_Medida.Text = data.Rows[0]["unidade_medida"].ToString();
        ddlCategoriaProduto.Text = data.Rows[0]["categoria_id"].ToString();
    }

    protected void btnExluir_Click(object sender, EventArgs e)
    {
        objProduto.ExcluirProduto(txtID.Text);
        LimparTela();
        CarregarGridView();
    }

    private void LimparTela()
    {
        txtID.Text = string.Empty;
        txtNome.Text = string.Empty;
        txtDescricao.Text = string.Empty;
        txtPrecoCusto.Text = string.Empty;
        txtPrecoVenda.Text = string.Empty;
        txtQuantidade.Text = string.Empty;
        txtUnidade_Medida.Text = string.Empty;
    }

    protected void btnLimpar_Click(object sender, EventArgs e)
    {
        LimparTela();
    }
}