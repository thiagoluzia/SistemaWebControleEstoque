<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Produto.aspx.cs" Inherits="Produto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Cadastro de Produtos" Font-Size="Larger"></asp:Label>
            <br />
            <br />
            <asp:Button ID="btnGravar" runat="server" Text="Gravar" />
            <br />
            <br />
        </div>
        <asp:Label ID="Label2" runat="server" Text="ID:"></asp:Label>
        &nbsp;&nbsp;
        <br />
        <asp:TextBox ID="txtID" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Nome:"></asp:Label>
&nbsp;&nbsp;
        <br />
        <asp:TextBox ID="txtNome" runat="server" Width="477px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Descrição:"></asp:Label>
&nbsp;&nbsp;
        <br />
        <asp:TextBox ID="txtDescricao" runat="server" Height="128px" TextMode="MultiLine" Width="457px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label5" runat="server" Text="Preço de Custo:"></asp:Label>
&nbsp;&nbsp;
        <br />
        <asp:TextBox ID="txtPrecoCusto" runat="server"></asp:TextBox>
&nbsp;&nbsp;
        <br />
        <br />
        <asp:Label ID="Label6" runat="server" Text="Preço de Venda:"></asp:Label>
        <br />
        <asp:TextBox ID="txtPrecoVenda" runat="server" Height="16px" Width="115px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label7" runat="server" Text="Quantidade:"></asp:Label>
&nbsp;&nbsp;
        <br />
        <asp:TextBox ID="txtQuantidade" runat="server" Width="57px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <asp:Label ID="Label8" runat="server" Text="Unidade de Medida:"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <br />
        <asp:TextBox ID="txtUnidadeMedida" runat="server" OnTextChanged="txtUnidadeMedida_TextChanged" Width="53px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <asp:Label ID="Label9" runat="server" Text="Categoria: "></asp:Label>
&nbsp;&nbsp;&nbsp;
        <br />
        <asp:DropDownList ID="ddlCategoriaProduto" runat="server">
        </asp:DropDownList>
        <br />
        <br />
        <asp:GridView ID="gridProdutos" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical" Width="743px">
            <AlternatingRowStyle BackColor="#CCCCCC" />
            <FooterStyle BackColor="#CCCCCC" />
            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#808080" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#383838" />
        </asp:GridView>
    </form>
</body>
</html>
