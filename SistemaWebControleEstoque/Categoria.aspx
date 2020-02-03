<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Categoria.aspx.cs" Inherits="Categoria" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">

.label_tela {
    font-family: Algerian;
    font-size: larger;
    font-weight: 500;
}
.botao{
    font-family:Constantia;
    font-size:small;
    font-weight:500;
    background-color:#0094ff;
    color:white;
}
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <div style="margin-left: 40px">
            <asp:Label ID="Label1" runat="server" Text="Cadastro de Categorias" Font-Size="Larger" CssClass="label_tela"></asp:Label>
            <br />
            <br />
            <asp:Button ID="btnLimpar" runat="server" Text="Limpar" OnClick="btnLimpar_Click" CssClass="botao" Height="37px" Width="80px" />
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnGravar" runat="server" OnClick="btnGravar_Click" Text="Gravar" CssClass="botao" Height="37px" Width="80px" />
            &nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnCarregar" runat="server" OnClick="btnCarregar_Click" Text="Carregar" CssClass="botao" Height="37px" Width="80px" />
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnExluir" runat="server" OnClick="btnExluir_Click" Text="Excluir" CssClass="botao" Height="37px" Width="80px" />
            <br />
            <br />
        </div>
        <asp:Label ID="Label2" runat="server" Text="ID:" Width="120px"></asp:Label>
        <asp:TextBox ID="txtID" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Nome:" Width="120px"></asp:Label>
        <asp:TextBox ID="txtNome" runat="server" Width="457px"></asp:TextBox>
            <br />
            <br />
        <asp:GridView ID="gridCategorias" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical" Width="743px" OnSelectedIndexChanged="gridCategorias_SelectedIndexChanged">
            <AlternatingRowStyle BackColor="#CCCCCC" />
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
            </Columns>
            <FooterStyle BackColor="#CCCCCC" />
            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#808080" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#383838" />
        </asp:GridView>
            <br />
        </div>
    </form>
</body>
</html>
