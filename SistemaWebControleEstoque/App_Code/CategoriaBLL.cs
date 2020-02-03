using MySql.Data.MySqlClient;
using System.Data;

public class CategoriaBLL
{
    public int Id { get; set; }
    public string Nome { get; set; }

    DAL objDAL = new DAL();

    //public DataTable RetornarCategoriaProduto()
    //{
    //    MySqlCommand cmd = new MySqlCommand();
    //    cmd.CommandText = "select * from categoria";
    //    return objDAL.RetDataTable(cmd);
    //}

    #region Metodos CRUD 

    public DataTable RetListarCategoria()
    {
        MySqlCommand cmd = new MySqlCommand();
        cmd.CommandText = "select * from categoria";
        return objDAL.RetDataTable(cmd);
    }

    public DataTable CarregarCategoriaPorId(string id)
    {
        MySqlCommand cmd = new MySqlCommand();
        cmd.CommandText = "select * from categoria where id = @id";
        cmd.Parameters.AddWithValue("@id", Id);
        return objDAL.RetDataTable(cmd);
    }

    public void InserirCategoria()
    {
        MySqlCommand cmd = new MySqlCommand();
        cmd.CommandText = "insert into categoria(nome) values(@nome)";
        cmd.Parameters.AddWithValue("@nome", Nome);
        objDAL.ExecutarComandoSQL(cmd);
    }

    public void AlterarCategoria(string id)
    {
        MySqlCommand cmd = new MySqlCommand();
        cmd.CommandText = "update categoria set nome = @nome where id = @id";
        cmd.Parameters.AddWithValue("@id", id);
        cmd.Parameters.AddWithValue("@nome", Nome);
        objDAL.ExecutarComandoSQL(cmd);
    }

    public void ExcluirCategoria(string id)
    {
        MySqlCommand cmd = new MySqlCommand();
        cmd.CommandText = "delete from categoria where id = @id";
        cmd.Parameters.AddWithValue("@id", id);
        objDAL.ExecutarComandoSQL(cmd);
    }

    #endregion
}