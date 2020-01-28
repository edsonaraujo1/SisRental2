using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace SisRental2
{
    public partial class Pedido : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

             var var_1 = Usuario.Login;

            if (var_1 == null)
            {
                Response.Redirect("Login.aspx?login=erro");
            }


                string host = "EDSON_CPD\\SQLEXPRESS2";  // "EDSON_CPD\\SQLEXPRESS2";
                string usuario = "sa";
                string senha = "12345";
                string banco = "DB_ALUGUEL";

               // Busca Cliente

            var var_2 = Usuario.Login;
            //string id_cliente;
            //string cpf_cli;
            //id_cliente = "";

            this.txtdata.Text = DateTime.Now.ToString("d");
                

            string strSQL = "SELECT * FROM [DB_ALUGUEL].[dbo].[TB_CLIENTES] WHERE NOME_CLIENTE = '" + var_2 + "'";

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
                        this.id_cli.Value = dr["ID_CLIENTE"].ToString();
                        this.txtcpf.Text = dr["DOCUMENTO"].ToString();
                    }

                     
                    dr.Close();
                    conexao.Close();
                }
                catch
                { }
            }
            catch { }


               // Busca Veiculo
                
                string strSQL2 = "SELECT * FROM [DB_ALUGUEL].[dbo].[TB_VEICULOS]";

                SqlConnection conexao2 = new SqlConnection("Data Source=" + host + ";DATABASE=" + banco + ";UID=" + usuario + "; PWD=" + senha + ";");

                try
                {
                    conexao2.Open();
                    try
                    {

                        SqlCommand cmd2 = new SqlCommand(strSQL2, conexao2);
                        SqlDataReader dr22 = cmd2.ExecuteReader();

                        DropDownList1.DataSource = dr22;
                        DropDownList1.DataTextField = "MODELO_VEIC";
                        DropDownList1.DataValueField = "ID_VEICULO";
                        DropDownList1.DataBind();

                        dr22.Close();
                        conexao2.Close();
                    }
                    catch
                    { }

                }
                catch
                {  }

            }


         protected void Button2_Click(object sender, EventArgs e)
        {

            
                string host = "EDSON_CPD\\SQLEXPRESS2";  // "EDSON_CPD\\SQLEXPRESS2";
                string usuario = "sa";
                string senha = "12345";
                string banco = "DB_ALUGUEL";
                string VAL_VEIC = "";


                string strSQL2 = "SELECT * FROM [DB_ALUGUEL].[dbo].[TB_VEICULOS] WHERE MODELO_VEIC = '" + this.DropDownList1.SelectedItem.Text + "'";

                SqlConnection conexao2 = new SqlConnection("Data Source=" + host + ";DATABASE=" + banco + ";UID=" + usuario + "; PWD=" + senha + ";");

                try
                {
                    conexao2.Open();
                    try
                    {

                        SqlCommand cmd2 = new SqlCommand(strSQL2, conexao2);
                        SqlDataReader dr2 = cmd2.ExecuteReader();

                        while (dr2.Read())
                        {
                            VAL_VEIC = dr2["VALOR_ALUGUEL"].ToString();
                            this.txtvalor.Text = dr2["VALOR_ALUGUEL"].ToString();
                            
                            
                        }

                        
                        int qtd = Convert.ToInt32(this.txtqtd.Text);
                        int val = Convert.ToInt32(VAL_VEIC);
                        int tot = 0;
                        tot = val * qtd;

                        this.txttotal.Text = tot.ToString(); 


                        dr2.Close();
                        conexao2.Close();
                    }
                    catch
                    { }
                }
                catch { }



                int NUMERO_PEDIDO = 1;
                int ID_CLIENTE = Convert.ToInt32(this.id_cli.Value);
                int QTD_VEICULOS = Convert.ToInt32(this.txtqtd.Text);
                int VALOR_TOTAL_ALUGUEL = Convert.ToInt32(this.txttotal.Text);
                string DATA_INICIAL = this.txtinicio.Text;
                string DATA_FINAL = this.txtfim.Text;
                int ID_SITUACAO = 1;


                            string strSQLins = "INSERT INTO TB_ALUGUEL (     NUMERO_PEDIDO, " +
                                                                            "ID_CLIENTE, " +
                                                                            "QTDE_VEICULOS, " +
                                                                            "VALOR_TOTAL_ALUGUEL, " +
                                                                            "DATA_INICIAL, " +
                                                                            "DATA_FINAL, " +
                                                                            "ID_SITUACAO) " +

                                                                     "VALUES   (" + NUMERO_PEDIDO + ", " +
                                                                                "" + ID_CLIENTE + ", " +
                                                                                "" + QTD_VEICULOS + ", " +
                                                                                "" + VALOR_TOTAL_ALUGUEL + ", " +
                                                                                "'" + DATA_INICIAL + "', " +
                                                                                "'" + DATA_FINAL + "', " +
                                                                                "" + ID_SITUACAO + ")";


                            SqlConnection conexao = new SqlConnection("Data Source=" + host + ";DATABASE=" + banco + ";UID=" + usuario + "; PWD=" + senha + ";");

                            try
                            {
                                conexao.Open();
                                try
                                {

                                    SqlCommand cmd = new SqlCommand(strSQLins, conexao);
                                    cmd.ExecuteNonQuery();
                                    try
                                    {

                                        // fim


                                        //MessageBox.Show("Pedido Incluido com Sucesso !!!");

                                    }
                                    catch
                                    {
                                        //MessageBox.Show("ERRO 02: Não foi possivel Incluir !!!");
                                    }
                                    conexao.Close();
                                }
                                catch
                                {
                                    //MessageBox.Show("ERRO 03: Não foi possivel Incluir !!!");
                                }

                            }
                            catch
                            { }



        }
    }
}