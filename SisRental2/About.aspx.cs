using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SisRental2
{
    public partial class About : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var var_1 = Usuario.Login;

            if (var_1 != null)
            {
                this.Label7.Text = "Logado como: <font size='5'><i>" + var_1 + "</i></font>";
            }
            else
            {
                this.Label7.Text = "";
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}
