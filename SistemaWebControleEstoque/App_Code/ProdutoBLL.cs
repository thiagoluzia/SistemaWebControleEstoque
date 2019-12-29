using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;


/// <summary>
/// RETORNRA CATEGORIA
/// 1º Instncia um objeto do tipo DAL para ter acesso ao banco de dados
/// 2º Criar um metodo do tipo data table.
/// 3º Fazer o retorno direto - utilizando o obj criado do tipo DAL, podemos acessar o metodo que retorna um data table do banco, ele recebe uma string sql como parametro 
/// </summary>
public class ProdutoBLL
{
    DAL objDAL = new DAL();//instancia para trabalhar com banco dedados   
    public ProdutoBLL()
    {
        
    }

    public DataTable RetornarCategoriaProduto()
    {
        return objDAL.RetDataTable("select * from categoria");
    }


}