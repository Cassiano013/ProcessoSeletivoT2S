<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="TesteT2S.Index" %>

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
            <br /><asp:Label ID="Label1" runat="server"><h1 class="H1"><b>Teste prático processo seletivo T2S</b></h1></asp:Label><br />
            <asp:Button ID="BtnCrudConteiner" class="btn btn-success" runat="server" Text="Crud de Contêiner" OnClick="BtnCrudConteiner_Click" />&nbsp
            <asp:Button ID="BtnCrudMovimentacao" class="btn btn-success" runat="server" Text="Crud de Movimentações" OnClick="BtnCrudMovimentacao_Click" />&nbsp
            <asp:Button ID="BtnRelatorio" class="btn btn-success" runat="server" Text="Relatório" OnClick="BtnRelatorio_Click" />
        </div>
        </div>
    </form>
    <script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.9.2/dist/umd/popper.min.js" integrity="sha384-IQsoLXl5PILFhosVNubq5LC7Qb9DXgDA9i+tQ8Zj3iwWAwPtgFTxbJ8NT4GN1R8p" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.min.js" integrity="sha384-cVKIPhGWiC2Al4u+LWgxfKTRIcfu0JTxR+EQDz/bgldoEyl4H0zUF0QKbrJ0EcQF" crossorigin="anonymous"></script>
</body>
</html>