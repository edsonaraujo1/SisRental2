<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Aluguel.aspx.cs" Inherits="SisRental2.Aluguel" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">

    <link type="text/css" rel="stylesheet" href="content/bootstrap/bootstrap.css" />
    <link type="text/css" rel="stylesheet" href="content/style.css" />
    <script src="scripts/jquery-1.9.1.min.js"></script> 
    <script src="scripts/bootstrap.min.js"></script> 

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<body>
    <!-- Fixed navbar -->
    <div class="panel panel-default fundo1">
      <div class="panel-heading">
        <h3 class="panel-title">Pedidos</h3>
      </div>
      <div class="panel-body">
        <div class="table-responsive">
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                Width="841px">
                <Columns>
                    <asp:BoundField DataField="ID_CLIENTE" HeaderText="Cliente" />
                    <asp:BoundField DataField="NUMERO_PEDIDO" HeaderText="N. Pedido" />
                    <asp:BoundField DataField="QTDE_VEICULOS" HeaderText="Qtd. Veiculo" />
                    <asp:BoundField DataField="VALOR_TOTAL_ALUGUEL" HeaderText="Valor" />
                    <asp:BoundField DataField="DATA_INICIAL" HeaderText="Inicio" />
                    <asp:BoundField DataField="DATA_FINAL" HeaderText="Fim" />
                </Columns>
            </asp:GridView>
            <br />
            <asp:Button ID="Button2" class="btn btn-primary" runat="server" Text="Fazer Pedido" 
            onclick="Button2_Click" />
        </div>
      </div>
    </div>    
</body>
</asp:Content>
