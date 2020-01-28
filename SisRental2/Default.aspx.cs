using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SisRental2
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {

                //MessageBox.Show("ERRO 01: Usuário de PERMISSÃO de Uso. !!!");
                var var_1 = Usuario.Login;

                if (var_1 != null)
                {
                    this.Label1.Text = "Usuário: <font size='10'>" + var_1 + "</font>";
                    this.Label2.Text = "Seja Bem Vindo..";
                }
                else
                {

                    Response.Redirect("Login.aspx?entrou=sair");
                    //this.Label1.Text = "Usuário: <font size='10'> Invalido!!! </font>";
                    //this.Label2.Text = "Seja Bem Vindo..";

                }
            }

        }
    }
}
