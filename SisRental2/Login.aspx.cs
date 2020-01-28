using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace SisRental2
{
    public partial class Login : System.Web.UI.Page
    {

        int IsLogin = 0;
        int IsPremis = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["entrou"] == "sair")
            {

                Usuario.Login = null;
                IsLogin = 0;
                IsPremis = 0; // Permissao

                this.TextBox1.Text = "";
                this.TextBox2.Text = "";

                Response.Redirect("Login.aspx");

            }
            else
            {

                if (!Page.IsPostBack)
                {
                    Usuario.Login = null;
                    IsLogin = 0;
                    IsPremis = 0; // Permissao

                    this.TextBox1.Text = "";
                    this.TextBox2.Text = "";

                }

                //Response.Redirect("Default.aspx");

            }

            

        }

        protected void Button1_Click(object sender, EventArgs e)
        {


            {


                string host = "EDSON_CPD\\SQLEXPRESS2";
                string usuario = "sa";
                string senha = "12345";
                string banco = "DB_ALUGUEL";


                //string host = "NOTEBOOK\\SQLEXPRESS";
                //string usuario = "sa";
                //string senha = "101216";
                //string banco = "DB_ALUGUEL";

                string strSQL = "SELECT * FROM [DB_ALUGUEL].[dbo].[TB_USUARIOS_CLIENTES] WHERE USUARIO = '" + this.TextBox1.Text + "' AND SENHA = '" + this.TextBox2.Text + "' AND SITUACAO = 1";

                SqlConnection conexao = new SqlConnection("Data Source=" + host + ";DATABASE=" + banco + ";UID=" + usuario + "; PWD=" + senha + ";");

                try
                {
                    conexao.Open();
                    try
                    {

                        SqlCommand cmd = new SqlCommand(strSQL, conexao);
                        SqlDataReader dr = cmd.ExecuteReader();
                        try
                        {


                            if (dr.Read())
                            {

                                //verifica se o login e senha e atribuir o
                                //nome do usuário e perfil ás variáveis globais
                                Usuario.Login = this.TextBox1.Text;
                                IsLogin = 1;
                                IsPremis = 1; // Permissao
                                //Response.Write("Entradou !!!");
                                Response.Redirect("Default.aspx?login=entrou");
                                //this.Close();

                            }

                            if (dr.HasRows)
                            {
                                dr.Close();
                            }
                            else
                            {
                                Usuario.Login = null;
                                IsLogin = 0;
                                IsPremis = 0; // Permissao
                                //Response.Write("Usuário ou Senha Invalidos !!!");
                                this.TextBox1.Text = "";
                                this.TextBox2.Text = "";
                                this.Label1.Text = "Usuário ou Senha Invalido !!!";
                                this.TextBox1.Focus();
                                //Application.Exit();
                                //Response.Redirect("Default.aspx?login=falhou");
                            }
                            dr.Close();
                            conexao.Close();
                        }
                        catch
                        {
                            //Response.Write("Usuário ou Senha Invalidos !!!");
                            this.TextBox1.Text = "";
                            this.TextBox2.Text = "";
                            this.TextBox1.Focus();
                            //Application.Exit();
                        }
                    }
                    catch
                    {


                        //Response.Write("Usuário ou Senha Invalidos !!!");
                        this.TextBox1.Text = "";
                        this.TextBox2.Text = "";
                        this.TextBox1.Focus();
                        //Application.Exit();
                    }

                }
                catch
                {
                    //Response.Write("Usuário ou Senha Invalidos !!!");
                    this.TextBox1.Text = "";
                    this.TextBox2.Text = "";
                    this.TextBox1.Focus();
                    //Application.Exit();
                }



            } //Fim Button1
        }
    }
}