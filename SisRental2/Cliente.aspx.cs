using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;


namespace SisRental2
{
    public partial class Cliente : System.Web.UI.Page
    {
        

        protected void Page_Load(object sender, EventArgs e)
        {
            var var_1 = Usuario.Login;
            //int cod_id;

            if (var_1 == null)
            {
                Response.Redirect("Login.aspx?login=erro");
            }


            if (!Page.IsPostBack)
            {

                string host = "EDSON_CPD\\SQLEXPRESS2";  // "EDSON_CPD\\SQLEXPRESS2";
                string usuario = "sa";
                string senha = "12345";
                string banco = "DB_ALUGUEL";
                //string id_busca = " ";
                //string id_busca = 0;
                //int seek_c = 0;
                //seek_c = Convert.ToInt32(this.textBox9.Text);

                
                this.Label1.Text = var_1;

                string strSQL = "SELECT * FROM [DB_ALUGUEL].[dbo].[TB_CLIENTES] WHERE NOME_CLIENTE = '" + var_1 + "'";

                SqlConnection conexao = new SqlConnection("Data Source=" + host + ";DATABASE=" + banco + ";UID=" + usuario + "; PWD=" + senha + ";");

                try
                {
                    conexao.Open();
                    try
                    {

                        SqlCommand cmd = new SqlCommand(strSQL, conexao);
                        SqlDataReader dr = cmd.ExecuteReader();

                        while (dr.Read())
                        {
                            this.inputid.Value = dr["ID_CLIENTE"].ToString();
                            this.inputdata.Value = dr["DATA_CADASTRO"].ToString();
                            this.inputCpf.Value = dr["DOCUMENTO"].ToString();
                            this.inputRg.Value = dr["RG_CLIENTE"].ToString();
                            this.inputNome.Value = dr["NOME_CLIENTE"].ToString();
                            this.inputSobrenome.Value = dr["SOBRE_NOME_CLIENTE"].ToString();
                            this.inputEmail.Value = dr["EMAIL_CLIENTE"].ToString();
                            this.inputTel.Value = dr["TEL_CLIENTE"].ToString();
                            this.inputCel.Value = dr["CEL_CLIENTE"].ToString();
                            this.inputCep.Value = dr["CEP"].ToString();
                            this.inputEnd.Value = dr["LOGRADOURO"].ToString() + " " + dr["ENDERECO"].ToString();
                            this.inputNumero.Value = dr["END_NUMERO"].ToString();
                            this.inputComp.Value = dr["COMPLEMENTO"].ToString();
                            this.inputBairro.Value = dr["BAIRRO"].ToString();
                            this.inputCidade.Value = dr["CIDADE"].ToString();
                            this.inputEstado.Value = dr["UF"].ToString();


                        }
                        dr.Close();
                        conexao.Close();
                    }
                    catch
                    {

                    }

                }
                catch
                {

                }

            }


        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            if (this.inputNome.Value != " ")
            {

                int seek_up = 0;
                seek_up = Convert.ToInt32(this.inputid.Value);
                int ID_CLIENTE = seek_up;
                string DATA_CADASTRO = this.inputdata.Value;
                //string DATA_INATIVACAO = this.textBox3.Text;
                string ID_SITUACAO = "1";
                string DOCUMENTO = this.inputCpf.Value;
                string RG_CLIENTE = this.inputRg.Value;
                string NOME_CLIENTE = this.inputNome.Value;
                string SOBRE_NOME_CLIENTE = this.inputSobrenome.Value;
                string EMAIL_CLIENTE = this.inputEmail.Value;
                string DDD_CLIENTE = "";
                string TEL_CLIENTE = this.inputCel.Value;
                string DDD_CEL_CLI = "";
                string CEL_CLIENTE = this.inputCel.Value;
                string CEP = this.inputCep.Value;
                string LOGRADOURO = "";
                string ENDERECO = this.inputEnd.Value;


                int val_1;
                if (this.inputNumero.Value == " ")
                {
                    val_1 = 0;
                }
                else
                {
                    val_1 = Convert.ToInt32(this.inputNumero.Value);
                }

                int END_NUMERO = val_1;
                string COMPLEMENTO = this.inputComp.Value;
                string BAIRRO = this.inputBairro.Value;
                string CIDADE = this.inputCidade.Value;
                string UF = this.inputEstado.Value;
                //string iEND_NOME = " ";
                //string iCOMPLEMENTO = " ";

                string host = "EDSON_CPD\\SQLEXPRESS2";
                string usuario = "sa";
                string senha = "12345";
                string banco = "DB_ALUGUEL";
                //string id_busca = "";

                string strSQLupd = "UPDATE TB_CLIENTES SET   DATA_CADASTRO = '" + DATA_CADASTRO + "'," +
                                                                "SITUACAO = " + ID_SITUACAO + "," +
                                                                "DOCUMENTO = '" + DOCUMENTO + "'," +
                                                                "RG_CLIENTE = '" + RG_CLIENTE + "'," +
                                                                "NOME_CLIENTE = '" + NOME_CLIENTE + "'," +
                                                                "SOBRE_NOME_CLIENTE = '" + SOBRE_NOME_CLIENTE + "'," +
                                                                "EMAIL_CLIENTE = '" + EMAIL_CLIENTE + "'," +
                                                                "TEL_CLIENTE = '" + TEL_CLIENTE + "'," +
                                                                "CEL_CLIENTE = '" + CEL_CLIENTE + "'," +
                                                                "CEP = '" + CEP + "'," +
                                                                "LOGRADOURO = '" + LOGRADOURO + "'," +
                                                                "ENDERECO = '" + ENDERECO + "'," +
                                                                "END_NUMERO = " + END_NUMERO + "," +
                                                                "COMPLEMENTO = '" + COMPLEMENTO + "'," +
                                                                "BAIRRO = '" + BAIRRO + "'," +
                                                                "CIDADE = '" + CIDADE + "'," +
                                                                "UF = '" + UF + "' WHERE ID_CLIENTE = " + seek_up + "";

                SqlConnection conexao = new SqlConnection("Data Source=" + host + ";DATABASE=" + banco + ";UID=" + usuario + "; PWD=" + senha + ";");

                try
                {
                    conexao.Open();
                    try
                    {

                        SqlCommand cmd = new SqlCommand(strSQLupd, conexao);
                        cmd.ExecuteNonQuery();
                        try
                        {
                            this.Label1.Text = "Alterado com Sucesso !!!";

                        }
                        catch
                        {
                            this.Label1.Text = "ERRO: Não foi possivel Alterar !!!";
                        }
                        conexao.Close();
                    }
                    catch
                    {
                        this.Label1.Text = "ERRO: Não foi possivel Alterar !!!";
                    }

                }
                catch
                {

                }
            }
            else
            {
                this.Label1.Text = "ERRO: Não foi possivel Alterar !!!";
            }


        }
    }
}