<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Pedido.aspx.cs" Inherits="SisRental2.Pedido" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <link type="text/css" rel="stylesheet" href="content/bootstrap/bootstrap.css" />
    <link type="text/css" rel="stylesheet" href="content/style.css" />
    <script src="scripts/jquery-1.9.1.min.js"></script> 
    <script src="scripts/bootstrap.min.js"></script> 

    <style type="text/css">
        .style1
        {
            width: 50px;
        }
    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<body>
    <!-- Fixed navbar -->
    <div class="panel panel-default fundo1">
      <div class="panel-heading">
        <h3 class="panel-title">Pedido reserva</h3>
      </div>
      <div style="width: 863px; text-align: left;" >


      <table width="350" border="0" cellspacing="10">
  <tr>
    <td class="style1"><asp:Label ID="Label3" runat="server" Text="CPF" ></asp:Label></td>
    <td><asp:TextBox ID="txtcpf" runat="server" class="form-control" Width="200px" ReadOnly></asp:TextBox>
    <input type="hidden" id="id_cli" runat="server" />
    </td>
    <td>&nbsp;</td>
    <td><asp:Label ID="Label4" runat="server" Text="Veiculo" ></asp:Label></td>
    <td><asp:DropDownList ID="DropDownList1" runat="server" Width="123px" class="form-control" ></asp:DropDownList></td>
  </tr>
  <tr>
    <td class="style1"><asp:Label ID="Label5" runat="server" Text="Retirada" ></asp:Label></td>
    <td><asp:TextBox ID="txtinicio" runat="server" class="form-control" Width="200px"></asp:TextBox></td>
    <td>&nbsp;</td>
    <td><asp:Label ID="Label6" runat="server" Text="Entrega" ></asp:Label></td>
    <td><asp:TextBox ID="txtfim" runat="server" class="form-control" Width="200px"></asp:TextBox></td>
  </tr>
  <tr>
    <td class="style1"><asp:Label ID="Label7" runat="server" Text="Qtd" ></asp:Label></td>
    <td><asp:TextBox ID="txtqtd" runat="server" class="form-control" Width="200px"></asp:TextBox></td>
    <td>&nbsp;</td>
    <td><asp:Label ID="Label8" runat="server" Text="Valor" ></asp:Label></td>
    <td><asp:TextBox ID="txtvalor" runat="server" class="form-control" Width="200px"></asp:TextBox></td>
  </tr>
  <tr>
    <td class="style1"><asp:Label ID="Label9" runat="server" Text="Total" ></asp:Label></td>
    <td><asp:TextBox ID="txttotal" runat="server" class="form-control" Width="200px"></asp:TextBox></td>
    <td>&nbsp;</td>
    <td><asp:Label ID="Label10" runat="server" Text="Data" ></asp:Label></td>
    <td><asp:TextBox ID="txtdata" runat="server" class="form-control" Width="200px" ReadOnly></asp:TextBox></td>
  </tr>
</table>



            <br />
                    
          
      </div>
      <asp:Button ID="Button2" class="btn btn-primary" runat="server" Text="Confirmar" 
            onclick="Button2_Click" />
    </div>    

    <script type="text/javascript">
        jQuery(function ($) {
            //$("#inputCep").mask("99999-999");
            //$("#inputTel").mask("(99) 9999-9999")
            //$("#inputCpf").mask("999.999.999-99")
            //$("#inputRg").mask("99.999.999-9")
        });
    </script>
    <script  type="text/javascript">
        $(function () {
            $('input[name="cep"]').blur(function () {
                var cep = $.trim($('input[name="cep"]').val().replace('-', ''));
                $.getScript("http://cep.republicavirtual.com.br/web_cep.php?formato=javascript&cep=" + cep, function () {
                    if (resultadoCEP["resultado"]) {
                        $('input[name="endereco"]').val(unescape(resultadoCEP["tipo_logradouro"]) + " " + unescape(resultadoCEP["logradouro"]));
                        $('input[name="cidade"]').val(unescape(resultadoCEP["cidade"]));
                        $('input[name="bairro"]').val(unescape(resultadoCEP["bairro"]));
                        $('input[name="estado"]').val(unescape(resultadoCEP["uf"]));
                        $('input[name="numero"]').focus();
                    }
                });
            });
        });
    </script>

</body>
</asp:Content>
