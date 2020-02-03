using System.Data;
using MySql.Data.MySqlClient;


/// <summary>
/// RETORNRA CATEGORIA
/// 1º InstAncia um objeto do tipo DAL para ter acesso ao banco de dados
/// 2º Criar um metodo do tipo data table.
/// 3º Fazer o retorno direto - utilizando o obj criado do tipo DAL, podemos acessar o metodo que retorna um data table do banco, ele recebe uma string sql como parametro 
/// 
/// INSERIR PRODUTO
/// 1º Criar as propriedades que representao os campos que temos no banco, pois o mesmo sera preenchido pelo usuario na camada de visão
/// 2º Criar o metodo inserir, que nao recebe nenhum parametro e nao tem nenhum retorno.
/// 2.1 Dentro do metodo, criar uma variavel que receberá uma string sql, na qual os valores serão passado pelas variaveis das propriedades
/// 2.2 Formatar a string sql para receber as strings
/// 2.3 chamar o objDAL e invocar o metodo que trabalha com comandos sql, e passar a string sql criada para inserir o produto, com todas as propriedades preenchidas pelo usuario
/// 
/// RETORNRA PRODUTO - SEMELHANDTE AO RETORNAR CATEGORIA - MUDA SOMENTE O SQL
/// 1º Com a Instancia  do tipo DAL já criada para acessar o banco de dados
/// 2º Criar um metodo do tipo data table.
/// 3º Fazer o retorno direto - utilizando o obj criado do tipo DAL, podemos acessar o metodo que retorna um data table do banco, ele recebe uma string sql como parametro  
/// 
/// RETORNA PRODUTO PELO ID
/// 1º Criar um metodo semelhante ao metodo lista que retorna produto, porem no sql iremos utilizar a clausula where
/// 1.1 Com a Instancia  do tipo DAL já criada para acessar o banco de dados
/// 1.2 Criar um metodo do tipo data table.
/// 1.3 Fazer o retorno direto - utilizando o obj criado do tipo DAL, podemos acessar o metodo que retorna um data table do banco, ele recebe uma string sql como parametro  
/// 
/// ALTERAR PRODUTO - SEMELHANTE AO INSERIR PRODUTO - POREM RECEBE UM PARAMETRO
/// 1º Criar o metodo AlterarProduto, que nao recebe um parametro para alterar o produto referente a esse parametro, "id".
/// 2º Dentro do metodo, criar uma variavel que receberá uma string sql, na qual os valores serão passado pelas variaveis das propriedades
/// 3º Formatar a string sql para receber as strings
/// 4º chamar o objDAL e invocar o metodo que trabalha com comandos sql, e passar a string sql criada para alterar o produto, com todas as propriedades redigidas pelo usuario
/// 
/// 
/// EXCLUIR PRODUTO
/// 1º Bloco de codigo 90% semelhante do metodo alterar.
/// 2º Unica mudança fica para o codigo sql 
/// </summary>
public class ProdutoBLL
{
    //Propriedades do produto - será preenchido na camada de visao
    #region(Propriedades)
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public decimal Preco_Custo { get; set; }
    public decimal Preco_Venda { get; set; }
    public double Quantidade { get; set; }
    public string Unidade_Medida { get; set; }
    public int Categoria_ID { get; set; }
    //Deveria ter ficado isolada
    #endregion

    DAL objDAL = new DAL();

    #region Metodos CRUD
    public DataTable RetListarProdutos()
    {
        MySqlCommand cmd = new MySqlCommand();
        cmd.CommandText = "select * from Produto";
        return objDAL.RetDataTable(cmd);
    }

    public DataTable CarregarProdutoPorId(string id)
    {
        MySqlCommand cmd = new MySqlCommand();

        cmd.CommandText = "select* from produto where id = @id";
        cmd.Parameters.AddWithValue("@id", id);
        
        return objDAL.RetDataTable(cmd);
    }

    public void InserirProduto()
    {
        MySqlCommand cmd = new MySqlCommand();
        cmd.CommandText = "insert into produto(nome, descricao, preco_custo, preco_venda, quantidade, unidade_medida, categoria_id)" +
                      "values(@nome,@descricao,@preco_custo,@preco_venda,@quantidade,@unidade_medida,@categoria_id)";

        cmd.Parameters.AddWithValue("@nome", Nome);
        cmd.Parameters.AddWithValue("@descricao", Descricao);
        cmd.Parameters.AddWithValue("@preco_venda", Preco_Venda);
        cmd.Parameters.AddWithValue("@preco_custo", Preco_Custo);
        cmd.Parameters.AddWithValue("@unidade_medida", Unidade_Medida);
        cmd.Parameters.AddWithValue("@quantidade", Quantidade);
        cmd.Parameters.AddWithValue("@categoria_id", Categoria_ID);

        objDAL.ExecutarComandoSQL(cmd);
    }

    public void AlterarProduto(string id)
    {
        MySqlCommand cmd = new MySqlCommand();

        cmd.CommandText = "update produto set nome = @nome, descricao = @descricao, " +
            "preco_custo = @preco_custo, preco_venda = @preco_venda, quantidade = @quantidade, " +
            "unidade_medida = @unidade_medida,  categoria_id = @categoria_id where id = @id";

        cmd.Parameters.AddWithValue("@nome", Nome);
        cmd.Parameters.AddWithValue("@descricao", Descricao);
        cmd.Parameters.AddWithValue("@preco_custo", Preco_Custo);
        cmd.Parameters.AddWithValue("@preco_venda", Preco_Venda);
        cmd.Parameters.AddWithValue("@quantidade", Quantidade);
        cmd.Parameters.AddWithValue("@unidade_medida", Unidade_Medida);
        cmd.Parameters.AddWithValue("@categoria_id", Categoria_ID);
        cmd.Parameters.AddWithValue("@id", Id);

        objDAL.ExecutarComandoSQL(cmd);
    }

    public void ExcluirProduto(string id)
    {
        MySqlCommand cmd = new MySqlCommand();

        cmd.CommandText = "delete from produto where id = @id";
        cmd.Parameters.AddWithValue("@id", id);

        objDAL.ExecutarComandoSQL(cmd);
    }
    #endregion

}