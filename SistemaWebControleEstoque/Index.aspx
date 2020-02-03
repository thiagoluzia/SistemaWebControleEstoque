<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Font-Size="XX-Large" ForeColor="Blue" Text="Sistema Controle de Estoque Web"></asp:Label>
            <br />
            <asp:Label ID="Label2" runat="server" Font-Size="Large" Text="Programando em Camadas  Com C# Asp Net"></asp:Label>
            <br />
            <br />
            <asp:Button ID="btnProdutos" runat="server" OnClick="btnProdutos_Click" Text="Produtos" />
&nbsp;
            <asp:Button ID="btnCategorias" runat="server" OnClick="btnCategorias_Click" Text="Categorias" />
            <br />
        </div>
    </form>
</body>
</html>
