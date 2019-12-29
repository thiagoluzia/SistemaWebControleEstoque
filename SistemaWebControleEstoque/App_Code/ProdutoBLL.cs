﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;


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
/// RETORNRA CATEGORIA - SEMELHANDTE AO RETORNAR CATEGORIA - MUDA SOMENTE O SQL
/// 1º Com a Instancia  do tipo DAL já criada para acessar o banco de dados
/// 2º Criar um metodo do tipo data table.
/// 3º Fazer o retorno direto - utilizando o obj criado do tipo DAL, podemos acessar o metodo que retorna um data table do banco, ele recebe uma string sql como parametro  
/// </summary>
public class ProdutoBLL
{
    //Propriedades do produto - será preenchido na camada de visao
    #region(Propriedades)
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Desscricao { get; set; }
    public decimal Preco_Custo { get; set; }
    public decimal Preco_Venda { get; set; }
    public double Quantidade { get; set; }
    public string Unidade_Medida { get; set; }
    public int Categoria_ID { get; set; }
    //Deveria ter ficado isolada
    #endregion

    DAL objDAL = new DAL(); 
 
    //apaguei construtor

    //Carregar Categoria
    public DataTable RetornarCategoriaProduto()
    {
        return objDAL.RetDataTable("select * from categoria");
    }

    //Retornar produtos
    public DataTable RetListarProdutos()
    {
        return objDAL.RetDataTable("select * from Produto");
    }

    //Inserir Produto
    public void InserirProduto()
    {
        string sql = "Insert produto(nome, descricao, preco_custo, preco_venda, quantidade, unidade_medida, categoria_id)" +
                      "values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')";

        sql = string.Format(sql, Nome, Desscricao, Preco_Custo, Preco_Venda, Quantidade, Unidade_Medida, Categoria_ID);
        objDAL.ExecutarComandoSQL(sql);

    }


}