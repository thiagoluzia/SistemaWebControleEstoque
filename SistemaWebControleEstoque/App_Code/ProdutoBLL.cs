using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;


/// <summary>
/// RETORNRA CATEGORIA
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