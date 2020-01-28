<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="SisRental2._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">

    <link type="text/css" rel="stylesheet" href="content/bootstrap/bootstrap.css" />
    <link type="text/css" rel="stylesheet" href="content/style.css" />
    <script src="scripts/jquery-1.9.1.min.js"></script> 
    <script src="scripts/bootstrap.min.js"></script> 

</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">


    <h2>
        <asp:Label ID="Label2" runat="server" style="font-size: medium; font-weight: 700"></asp:Label><br />

            <asp:Label ID="Label1" runat="server" style="font-size: medium; font-weight: 700; font-style: italic; color: #0000FF"></asp:Label>
    </h2>

    <h2>
        Sistema : SisRental Rent a Car
    </h2>
    <p>
        Seu companheiro nas viagens dentro e fora do Pais.
    </p>
    <p>
        
    </p>
</asp:Content>
