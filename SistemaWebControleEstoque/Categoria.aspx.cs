using System;
using System.Data;

public partial class Categoria : System.Web.UI.Page
{
    CategoriaBLL objCategoria = new CategoriaBLL();

    protected void Page_Load(object sender, EventArgs e)
    {
        CarregarGridView();
    }


    #region Metodos
    private void CarregarCategorias()
    {
        DataTable data = objCategoria.CarregarCategoriaPorId(txtID.Text);
        txtNome.Text = data.Rows[0]["nome"].ToString();
    }

    private void LimparTela()
    {
        txtID.Text = string.Empty;
        txtNome.Text = string.Empty;
    }

    private void CarregarGridView()
    {
        gridCategorias.DataSource = objCategoria.RetListarCategoria();
        gridCategorias.DataBind();
    }

    protected void gridCategorias_SelectedIndexChanged(object sender, EventArgs e)
    {
        txtID.Text = gridCategorias.SelectedRow.Cells[1].Text;
        CarregarCategorias();
    }
    #endregion

    #region Botões
    protected void btnLimpar_Click(object sender, EventArgs e)
    {
        LimparTela();
    }

    protected void btnGravar_Click(object sender, EventArgs e)
    {
        objCategoria.Nome = txtNome.Text;
        if (string.IsNullOrEmpty(txtID.Text))
        {
            objCategoria.InserirCategoria();
        }
        else
        {
            objCategoria.AlterarCategoria(txtID.Text);
        }
        LimparTela();
        CarregarGridView();
    }

    protected void btnCarregar_Click(object sender, EventArgs e)
    {
        CarregarCategorias();
    }

    protected void btnExluir_Click(object sender, EventArgs e)
    {
        objCategoria.ExcluirCategoria(txtID.Text);
        LimparTela();
        CarregarGridView();
    }
    #endregion
}