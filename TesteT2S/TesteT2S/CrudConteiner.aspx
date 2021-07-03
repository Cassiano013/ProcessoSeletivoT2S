<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CrudConteiner.aspx.cs" Inherits="TesteT2S.CrudConteiner" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Teste prático processo seletivo T2S</title>
    <link href="main.css" rel="stylesheet" />
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous" />
</head>
<body id="grad">
    <form id="form1" runat="server">
        <div class="row justify-content-md-center">
        <div id="container" class="col-offset-1 col-8 col-offset-1">
        <div>
            <br /><asp:Label ID="Label1" runat="server"><h1 class="H1"><b>Teste prático processo seletivo T2S</b></h1></asp:Label><br />
            <br /><asp:Label ID="Label2" runat="server"><h2><b>Crud de Contêiner</b></h2></asp:Label><br />
            <asp:Button ID="BtnCadastrar" class="btn btn-secondary" runat="server" Text="Cadastar" Onclick="BtnCadastrar_Click" enabled="false" />&nbsp
            <asp:Button ID="BtnConsultar" class="btn btn-secondary" runat="server" Text="Consultar" OnClick="BtnConsultar_Click" />&nbsp
            <asp:Button ID="BtnAtualizar" class="btn btn-secondary" runat="server" Text="Atualizar" OnClick="BtnAtualizar_Click" />&nbsp
            <asp:Button ID="BtnExcluir" class="btn btn-secondary" runat="server" Text="Excluir" OnClick="BtnExcluir_Click" /><br /><br />
        </div>
            <div>
                <br /><asp:Label ID="LblCliente" runat="server" size="18" CssClass="" Style="display: inline"><b>Cliente: </b></asp:Label>
                <asp:TextBox ID="TxtCliente" MaxLength="40" runat="server" CssClass="input-small" class="form-control col-8" TabIndex="5" placeholder="Nome do Cliente..."></asp:TextBox>
            </div>
            <div>
                <br /><asp:Label ID="LblNumeroConteiner" runat="server" size="18" CssClass="" Style="display: inline"><b>Contêiner: </b></asp:Label>
                <asp:TextBox ID="TxtNumeroConteiner" MaxLength="11" runat="server" CssClass="input-small" class="form-control col-8" TabIndex="5" placeholder="Número do Contêiner..." aria-describedby="passwordHelpInline"></asp:TextBox>
                <small id="HelpInline" class="text-muted"><br />
                4 letras e 7 números. Ex: TEST1234567
                </small>
            </div>
            <div>
                <br /><asp:Label ID="LblTipo" size="18" runat="server"><b>Tipo Contêiner: </b></asp:Label><br />
                <asp:RadioButton ID="RbtTipo20" runat="server" Text=" 20 " GroupName="Group1" Checked="true"/><br />
                <asp:RadioButton ID="RbtTipo40" runat="server" Text=" 40 " GroupName="Group1"/>
            </div>
        <div class="dropdown">
            <br /><asp:Label ID="LblStatus" runat="server"><b>Status: </b></asp:Label><br />
            <asp:DropDownList ID="DpdStatus" class="btn btn-secondary dropdown-toggle" runat="server" >
                <asp:ListItem Text="Selecione..." Value="0"/>
                <asp:ListItem Text="Cheio" Value="C"/>
                <asp:ListItem Text="Vazio" Value="V"/>
            </asp:DropDownList>
        </div>
        <div class="dropdown">
            <br /><asp:Label ID="LblCategoria" runat="server"><b>Categoria: </b></asp:Label><br />
            <asp:DropDownList ID="DpdCategoria" class="btn btn-secondary dropdown-toggle" runat="server" >
                <asp:ListItem Text="Selecione..." Value="0"/>
                <asp:ListItem Text="Importação" Value="I"/>
                <asp:ListItem Text="Exportação" Value="E"/>
            </asp:DropDownList>
        </div>
        <div>
            <asp:GridView ID="GridConsultarConteiner" runat="server" Width="1217px"></asp:GridView>
        </div>
        <div>
           <br /><asp:Label ID="LblAviso" runat="server" Font-Size ="18"><b></b></asp:Label>
        </div>
        <div>
            <br /><br /><asp:Button ID="BtnCadastrarConteiner" class="btn btn-success" runat="server" Text="Cadastrar Contêiner" OnClick="BtnCadastrarConteiner_Click" />
        </div>
        <div>
            <br /><asp:Button ID="BtnVoltar" class="btn btn-primary" runat="server" Text="Voltar" OnClick="BtnVoltar_Click" />
        </div>
        </div>
        </div>
    </form>
    <script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.9.2/dist/umd/popper.min.js" integrity="sha384-IQsoLXl5PILFhosVNubq5LC7Qb9DXgDA9i+tQ8Zj3iwWAwPtgFTxbJ8NT4GN1R8p" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.min.js" integrity="sha384-cVKIPhGWiC2Al4u+LWgxfKTRIcfu0JTxR+EQDz/bgldoEyl4H0zUF0QKbrJ0EcQF" crossorigin="anonymous"></script>
</body>
</html>
