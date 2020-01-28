<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SisRental2.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <link type="text/css" rel="stylesheet" href="content/bootstrap/bootstrap.css" />
    <link type="text/css" rel="stylesheet" href="content/style.css" />
    <script src="scripts/jquery-1.9.1.min.js"></script> 
    <script src="scripts/bootstrap.min.js"></script> 

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<fieldset>


<body>
    <!-- Fixed navbar -->
    <div class="panel panel-default fundo1" align="center">
      
      <div style="width: 400px; text-align: left;" >

    <div class="container">
      
        <h2 class="form-signin-heading text-center">SisRental</h2>
        <br />
        <asp:Label ID="Label1" runat="server" style="color: #FF0000; font-weight: 700"></asp:Label>
        <br />
        <!--<input type="text" class="form-control" placeholder="E-mail" autofocus>
        <input type="password" class="form-control" placeholder="Senha">-->
        <asp:TextBox ID="TextBox1" runat="server" class="form-control" 
            placeholder="E-mail" autofocus Width="359px"></asp:TextBox>
        <asp:TextBox ID="TextBox2" runat="server" class="form-control" 
            placeholder="Senha" Width="359px"></asp:TextBox>
        <label class="checkbox">
          <input type="checkbox" value="remember-me"> Lembrar
          <a class="pull-right" href="Cliente.aspx">Cadastrar</a>
        </label>
        <asp:Button ID="Button1" class="btn btn-lg btn-primary btn-block" runat="server" Text="Entrar" OnClick="Button1_Click" />
          <br />
          </div>
          </div>
          </div>
</body>


    


</fieldset>

</asp:Content>
