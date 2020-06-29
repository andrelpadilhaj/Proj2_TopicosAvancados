<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Presente.aspx.cs" Inherits="Proj2.Presente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Presentão</title>
    <link href="./Content/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <nav class="navbar navbar-expand-sm navbar-dark bg-dark">
        <a href="#" class="navbar-brand">Presentão</a>
        <button class="navbar-toggler" data-toggle="collapse" data-target="#menu">
            <span class="navbar-toggler-icon"></span>
        </button>
        <div class="collapse navbar-collapse" id="menu">
            <ul class="navbar-nav ml-auto">
            <li class="nav-item">
                <a class="nav-link" href="Finalidade.aspx">Finalidade</a>
            </li>
            <li class="nav-item">
                <a class="nav-link" href="Fornecedor.aspx">Fornecedor</a>
            </li>
            <li class="nav-item">
                <a class="nav-link" href="Marca.aspx">Marca</a>
            </li>
            <li class="nav-item">
                <a class="nav-link" href="#">Presente</a>
            </li>
            <li class="nav-item">
                <a class="nav-link" href="Tipo.aspx">Tipo</a>
            </li>
        </ul>
        </div>
    </nav>
    <form id="form1" runat="server">
        <div class="container">
            <div class="row">
                <div class="col">
                    <div class="form-group">
                        <label for="descricao">Descricao</label>
                        <asp:TextBox class="form-control" ID="descricao" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div class="col">
                    <div class="form-group">
                        <label for="fornecedor">Fornecedor</label>
                        <asp:DropDownList class="form-control" ID="fornecedor" runat="server"></asp:DropDownList>
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col">
                    <div class="form-group">
                        <label for="tipo">Tipo</label>
                        <asp:DropDownList class="form-control" ID="tipo" runat="server"></asp:DropDownList>
                    </div>
                </div>
                <div class="col">
                    <div class="form-group">
                        <label for="marca">Marca</label>
                        <asp:DropDownList class="form-control" ID="marca" runat="server"></asp:DropDownList>
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col">
                    <div class="form-group">
                        <label for="finalidade">Finalidade</label>
                        <asp:DropDownList class="form-control" ID="finalidade" runat="server"></asp:DropDownList>
                    </div>
                </div>
                <div class="col">
                    <div class="form-group">
                        <label for="cor">Cor</label>
                        <asp:TextBox class="form-control" ID="cor" runat="server"></asp:TextBox>
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col">
                    <div class="form-group">
                        <label for="tamanho">Tamanho</label>
                        <asp:TextBox class="form-control" ID="tamanho" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div class="col">
                    <div class="form-group">
                        <label for="preco">Preço</label>
                        <asp:TextBox class="form-control" ID="preco" runat="server"></asp:TextBox>
                    </div>
                </div>
            </div>
            <asp:Button class="btn btn-primary" id="save" runat="server" Text="Salvar" OnClick="Save"/>
            <hr />
            <div class="align-self-center">
                <asp:GridView ID="gridPessoas" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <EditRowStyle BackColor="#999999" />
                    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#E9E7E2" />
                    <SortedAscendingHeaderStyle BackColor="#506C8C" />
                    <SortedDescendingCellStyle BackColor="#FFFDF8" />
                    <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                </asp:GridView>
            </div>
            <hr />
            <div class="row">
                <div class="col-sm-1">
                    <asp:Button class="btn btn-primary" ID="delete" runat="server" Text="Delete" OnClick="Delete" />
                </div>
                <div class="col-sm-9">
                    <asp:TextBox class="form-control" ID="idelete" runat="server" placeholder="Id para deletar"></asp:TextBox>
                </div>
            </div>
        </div>
    <script src="https://code.jquery.com/jquery-3.5.1.slim.min.js" integrity="sha384-DfXdz2htPH0lsSSs5nCTpuj/zy4C+OGpamoFVy38MVBnE+IbbVYUew+OrCXaRkfj" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js" integrity="sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/js/bootstrap.min.js" integrity="sha384-OgVRvuATP1z7JjHLkuOU7Xw704+h835Lr+6QL9UvYjZE3Ipu6Tp75j7Bh/kR0JKI" crossorigin="anonymous"></script>
    </form>
    </body>
</html>
