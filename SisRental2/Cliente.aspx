<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cliente.aspx.cs" Inherits="SisRental2.Cliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">

    <link type="text/css" rel="stylesheet" href="content/bootstrap/bootstrap.css" />
    <link type="text/css" rel="stylesheet" href="content/style.css" />
    <script src="scripts/jquery-1.9.1.min.js"></script> 
    <script src="scripts/bootstrap.min.js"></script> 
    <script src="scripts/jquery.maskedinput-1.3.js"></script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<body>
    <!-- Fixed navbar -->
    <div class="panel panel-default fundo1">
      <div class="panel-heading">
        <h3 class="panel-title">Cadastro</h3>
      </div>
      <div class="panel-body">
        
            <div class="page-header">
              <h3>Geral</h3>
            </div>
            <div class="form-group">
                <label for="inputNome" class="col-lg-3 control-label">Nome</label>
                <div class="col-lg-3">
                    <input type="text" class="form-control" id="inputNome" placeholder="Nome" runat="server" readonly>
                    <input type="hidden" id="inputid" placeholder="id" runat="server"/>
                </div>
            </div>
            <div class="form-group">
                <label for="inputSobrenome" class="col-lg-3 control-label">Sobrenome</label>
                <div class="col-lg-3">
                    <input type="text" class="form-control" id="inputSobrenome" placeholder="Sobrenome" runat="server" readonly>
                </div>
            </div>
            <div class="form-group">
                <label for="inputCpf" class="col-lg-3 control-label">CPF</label>
                <div class="col-lg-3">
                   <input type="text" class="form-control" id="inputCpf" placeholder="CPF" runat="server" readonly>
                </div>
            </div>
            <div class="form-group">
                <label for="inputRg" class="col-lg-3 control-label">RG</label>
                <div class="col-lg-3">
                   <input type="text" class="form-control" id="inputRg" placeholder="RG" runat="server" readonly>
                </div>
            </div>
            <div class="form-group">
                <label for="inputCnh" class="col-lg-3 control-label">CNH</label>
                <div class="col-lg-3">
                   <input type="text" class="form-control" id="inputCnh" placeholder="CNH" runat="server" readonly>
                </div>
            </div>
            <div class="form-group">
                <label for="inputEmail" class="col-lg-3 control-label">Email</label>
                <div class="col-lg-3">
                    <input type="text" class="form-control" id="inputEmail" placeholder="Email" runat="server">
                </div>
            </div>
            <div class="form-group">
                <label for="inputTel" class="col-lg-3 control-label">Telefone</label>
                <div class="col-lg-3">
                    <input type="text" class="form-control" id="inputTel" placeholder="Telefone" runat="server">
                </div>
            </div>
            <div class="form-group">
                <label for="inputCel" class="col-lg-3 control-label">Celular</label>
                <div class="col-lg-3">
                    <input type="text" class="form-control" id="inputCel" placeholder="Celular" runat="server">
                </div>
            </div>
            <div class="form-group">
                <label for="inputCadEm" class="col-lg-3 control-label">Cadastrado em</label>
                <div class="col-lg-3">
                    <input type="text" name="data" class="form-control" id="inputdata" placeholder="Data" runat="server" readonly>
                </div>
            </div>
            <br />
            <div class="page-header">
              
            </div>
            <br />
            <div class="form-group">
            <p>
              <h3>Endereço</h3>
              </p>
                <label for="inputCep" class="col-lg-3 control-label">CEP</label>
                <div class="col-lg-3">
                    <input type="text" name="cep" class="form-control" id="inputCep" placeholder="CEP" runat="server">
                </div>
            </div>
            <div class="form-group">
                <label for="inputEnd" class="col-lg-3 control-label">Endereço</label>
                <div class="col-lg-3">
                    <input type="text" name="endereco" class="form-control" id="inputEnd" placeholder="Endereço" runat="server">
                </div>
            </div>
            <div class="form-group">
                <label for="inputNumero" class="col-lg-3 control-label">Numero</label>
                <div class="col-lg-3">
                    <input type="text" name="numero" class="form-control" id="inputNumero" placeholder="Numero" runat="server">
                </div>
            </div>
            <div class="form-group">
                <label for="inputComp" class="col-lg-3 control-label">Complemento</label>
                <div class="col-lg-3">
                    <input type="text" name="complemento" class="form-control" id="inputComp" placeholder="Complemento" runat="server">
                </div>
            </div>
            <div class="form-group">
                <label for="inputBairro" class="col-lg-3 control-label">Bairro</label>
                <div class="col-lg-3">
                    <input type="text" name="bairro" class="form-control" id="inputBairro" placeholder="Bairro" runat="server">
                </div>
            </div>
            <div class="form-group">
                <label for="inputCidade" class="col-lg-3 control-label">Cidade</label>
                <div class="col-lg-3">
                    <input type="text" name="cidade" class="form-control" id="inputCidade" placeholder="Cidade" runat="server">
                </div>
            </div>
            <div class="form-group">
                <label for="inputEstado" class="col-lg-3 control-label">Estado</label>
                <div class="col-lg-3">
                    <input type="text" name="estado" class="form-control" id="inputEstado" placeholder="Estado" runat="server">
                </div>
            </div>
            <asp:Label ID="Label1" runat="server" ></asp:Label>
            <br />
                    
          
      </div>
      <asp:Button ID="Button2" class="btn btn-primary" runat="server" Text="Salvar" 
            onclick="Button2_Click" />
    </div>    

    <script type="text/javascript">
        jQuery(function ($) {
            $("#inputCep").mask("99999-999");
            $("#inputTel").mask("(99) 9999-9999")
            $("#inputCpf").mask("999.999.999-99")
            $("#inputRg").mask("99.999.999-9")
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
