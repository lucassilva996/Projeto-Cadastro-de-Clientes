<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Detalhes.aspx.cs" Inherits="Site.Pages.Detalhes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Detalhes</title>
         <link type="text/css" rel="stylesheet" href="Content/bootstrap.css" />
</head>
    <script src="Scripts/jquery-1.9.0.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>

<body>
    <form id="form1" runat="server">
        <div>
            <div class="container">
                <div class="row">
                    <h3 class="well">Detalhes do Cliente</h3>
                    
                   
                    Informe o Código: <br />
                    <asp:TextBox ID="txtCodigo" runat="server" CssClass="form-control" Width="15%" />
                    <br />
                    <asp:Button ID="btnPesquisa" runat="server" Text="Pesquisar" CssClass="btn btn-info btn-lg" OnClick="btnPesquisarCliente"/>
                    <a href="../Default.aspx" class="btn btn-default btn-lg">Voltar</a>
                    <br /><br /><br />
                    
                    <asp:Panel ID="pnlDados" runat="server">
                    Nome do Cliente: <br />
                    <asp:TextBox ID="txtNome" runat="server"  CssClass="form-control" Width="45%" />
                    <br /><br />

                    Endereço do Cliente: <br />
                    <asp:TextBox ID="txtEndereco" runat="server"  CssClass="form-control" Width="50%" />
                    <br /><br />

                    Email do Cliente: <br />
                    <asp:TextBox ID="txtEmail" runat="server"  CssClass="form-control" Width="50%" />
                    <br /> <br />

                   
                    
                    <asp:Button ID="btnExcluir" runat="server" Text="Excluir" CssClass="btn btn-danger btn-lg" OnClick="btnExcluirCliente"/>
                    <asp:Button ID="btnAtualizar" runat="server" Text="Atualizar" CssClass="btn btn-warning btn-lg" OnClick="btnAtualizarCliente"/>
                    
                   
                    
                    </asp:Panel>
                     <p>
                        <asp:Label ID="lblMensagem" runat="server" />
                    </p>
                    </div>
            </div>
        </div>
    </form>
</body>
</html>
