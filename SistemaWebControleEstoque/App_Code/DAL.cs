using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


using System.Data;
using MySql.Data.MySqlClient;

/// <summary>
/// Cria as variaveis dos dados necessarios para string de conexao privadas fora do construtor.
/// ACESSO A DADOS SEGUEM OS SEGUINTES PASSOS: 
/// 1º variavel normal String de conexao, 
/// 2º Uma Variavel do tipo do provedor de conexao recebendo um variavel string de conexao, 
/// 3º Abertura do objeto criado com a variavel do tipo do provedor da conexão
/// 
/// RETORNO DOS DADOS SEGUEM OS SEGUINTES PASSOS:
/// 1º Um metodo do tipo data table"representa uma tabela na memoria" recebe um comando  string sql
/// 2º A crianção de um objeto do tipo datatbale"ou seja do retorno do metodo"
/// 3º Um objeto do tipo my sql command, pois ele trata de comandos sql, ele recebe string sql e uma string de conexão
/// 4º Um objeto do tipo data adapter, ele adapta o objeto command do tipo mysql command, de maneira que o .net compreenda
/// 5º Chamada do metodo fill"preenchimento "  do objeto da para preencher o objeto data table
/// 6º O return do data table devidamente preenchido
/// 
/// EXECUTAR COMANDOS SQL
/// 1º Criar uma função"metodo sem retorno", que recebe uma string sql
/// 2º Criar um objeto do tipo do provedor do banco"mysqlCommand" que recebe como parametro uma uma string sql"a mesma que e recebida pelo parametro da função"  e uma string de conexão a mesma ja criada na classe
/// 3º O objeto command agora com tudo que precisa ja devidamente carregado, ele chama o seu metodo ExecuteNonQuery "executar nao consultar"
/// </summary>
public class DAL
{
    private string server = "localhost";
    private string database = "estoque";
    private string user = "root";
    private string password = "";
    private string connectionString = "Server={0};Database={1};Uid={2};Pwd={3}";
    private MySqlConnection connection;

    //Cria conexão
    public DAL()
    {
        connectionString = string.Format(connectionString, server, database, user, password);
        connection = new MySqlConnection(connectionString);
        connection.Open();
    }

    //Retorna dados
    public DataTable RetDataTable(string sql)
    {
        DataTable dataTable = new DataTable();
        MySqlCommand command = new MySqlCommand(sql, connection);
        MySqlDataAdapter da = new MySqlDataAdapter(command);
        da.Fill(dataTable);
        return dataTable;
    }

    //Executa comandos
    public void ExecutarComandoSQL(string sql)
    {
        MySqlCommand command = new MySqlCommand(sql, connection);
        command.ExecuteNonQuery();
    }


}