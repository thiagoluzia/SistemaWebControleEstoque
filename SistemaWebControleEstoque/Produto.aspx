﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Produto.aspx.cs" Inherits="Produto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="stylesheet" href="StyleSheet.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Cadastro de Produtos" Font-Size="Larger" CssClass="label_tela"></asp:Label>
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
        <asp:Label ID="Label4" runat="server" Text="Descrição:" Width="120px"></asp:Label>
        <asp:TextBox ID="txtDescricao" runat="server" Height="58px" TextMode="MultiLine" Width="457px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label5" runat="server" Text="Preço de Custo:" Width="120px"></asp:Label>
        <asp:TextBox ID="txtPrecoCusto" runat="server" Width="115px"></asp:TextBox>
&nbsp;&nbsp;
        <br />
        <asp:Label ID="Label6" runat="server" Text="Preço de Venda:" Width="120px"></asp:Label>
        <asp:TextBox ID="txtPrecoVenda" runat="server" Height="16px" Width="115px"></asp:TextBox>
        <br />
        <asp:Label ID="Label7" runat="server" Text="Quantidade:" Width="120px"></asp:Label>
        <asp:TextBox ID="txtQuantidade" runat="server" Width="57px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <br />
        <asp:Label ID="Label8" runat="server" Text="Unidade de Medida:" Width="120px"></asp:Label>
        <asp:TextBox ID="txtUnidade_Medida" runat="server" Width="57px"></asp:TextBox>
        <br />
        <asp:Label ID="Label9" runat="server" Text="Categoria: " Width="120px"></asp:Label>
        <asp:DropDownList ID="ddlCategoriaProduto" runat="server">
        </asp:DropDownList>
        <br />
        <br />
        <asp:GridView ID="gridProdutos" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical" Width="743px" OnSelectedIndexChanged="gridProdutos_SelectedIndexChanged">
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
    </form>
</body>
</html>
