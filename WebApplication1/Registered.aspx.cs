using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Registered : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string s_data = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["accountInfoConnectionString"].ConnectionString;

            SqlConnection connection = new SqlConnection(s_data);

            string sql = $"insert into [accountform](account,passwd,name)values('" + Request.Form["user"] + "','" + Request.Form["passwd"] + "','" + Request.Form["name"] + "')";

            connection.Open();

            SqlCommand Command = new SqlCommand(sql, connection);


            Command.ExecuteNonQuery();

            connection.Close();
        }
    }
}