<%@ Page Title="About Us" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="About.aspx.cs" Inherits="SisRental2.About" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">

    <link type="text/css" rel="stylesheet" href="content/bootstrap/bootstrap.css" />
    <link type="text/css" rel="stylesheet" href="content/style.css" />
    <script src="scripts/jquery-1.9.1.min.js"></script> 
    <script src="scripts/bootstrap.min.js"></script> 

</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        <asp:Label ID="Label1" runat="server" Text="Sistema : SisRental Rent a Car"></asp:Label>
    </h2>
    <br />
    <div>                   
    <asp:Label ID="Label7" runat="server" style="color: #009933" ></asp:Label>
    </div>
    <asp:Image ID="Image1" runat="server" ImageUrl="~/imagens/DotNet.jpg" 
        Height="131px" Width="350px" />

    <br />
    <br />
    <asp:Label ID="Label2" runat="server" Text="Desenvolvedores/DBA : Marcos Oliveira" style="font-weight: 700; font-size: medium"></asp:Label><br />
    <asp:Label ID="Label3" runat="server" Text="Desenvolvedores/Desk/Web : Edson de Araujo"  style="font-weight: 700; font-size: medium"></asp:Label><br />
    <asp:Label ID="Label4" runat="server" Text="Desenvolvedores/Ducument : Paulo Thomaz" style="font-weight: 700; font-size: medium"></asp:Label><br />
    <asp:Label ID="Label5" runat="server" Text="Desenvolvedores/WEB : Rogerio Silva" style="font-weight: 700; font-size: medium"></asp:Label><br />
    <asp:Label ID="Label6" runat="server" Text="Desenvolvedores/Document : Marcos Faroni" style="font-weight: 700; font-size: medium"></asp:Label><br />



    <br />

    <asp:Button ID="Button2" class="btn btn-primary" runat="server" Text="Voltar" 
            onclick="Button2_Click" />
    <p>
        Em Desenvolvimento (PIM)
    </p>
</asp:Content>
