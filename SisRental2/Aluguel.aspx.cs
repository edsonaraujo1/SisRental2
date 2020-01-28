using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;


namespace SisRental2
{
    public partial class Aluguel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            var var_1 = Usuario.Login;

            if (var_1 == null)
            {
                Response.Redirect("Login.aspx?login=erro");
            }

            BindData();

        }

        protected void BindData()
        {

            string host = "EDSON_CPD\\SQLEXPRESS2";  // "EDSON_CPD\\SQLEXPRESS2";
            string usuario = "sa";
            string senha = "12345";
            string banco = "DB_ALUGUEL";
            var var_2 = Usuario.Login;
            string id_cliente;
            id_cliente = "";


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
                        id_cliente = dr["ID_CLIENTE"].ToString();
                    }
                    dr.Close();
                    conexao.Close();
                }
                catch
                { }
            }
            catch { }




            //String query = "";
            //query = "SELECT codigo, left(descricao,20), left(fornecedor,15),data,vencimento,qtd_estq FROM estoque";
            int busc = Convert.ToInt32(id_cliente);

            string strSQL2 = "SELECT ID_CLIENTE, NUMERO_PEDIDO, QTDE_VEICULOS, VALOR_TOTAL_ALUGUEL, DATA_INICIAL, DATA_FINAL FROM [DB_ALUGUEL].[dbo].[TB_ALUGUEL] WHERE ID_CLIENTE = " + busc + "";

            
            SqlCommand cmd2 = new SqlCommand(strSQL2, conexao);
            SqlDataAdapter datadd = new SqlDataAdapter(strSQL2, conexao);
            DataSet ds2 = new DataSet();
            datadd.Fill(ds2);   
            
            GridView1.DataSource = ds2;
            GridView1.DataBind();
            //con.Close();
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Pedido.aspx");
        }
    }
}