using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class logintest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["logined"] != null && Session["logined"].ToString() == "1")
            {
                Response.Redirect("paper scissor stone");
            }
            else
            {
                if (Request.Form["user"] != null && Request.Form["passwd"] != null)
                {

                    string s_data = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["AccountDbConnectionString"].ConnectionString;


                    SqlConnection connection = new SqlConnection(s_data);

                    string sqlTest = "select * from accountInfo where account='" + Request.Form["user"] + "'";


                    SqlCommand Command = new SqlCommand(sqlTest, connection);

                    connection.Open();


                    SqlDataReader Reader = Command.ExecuteReader();


                    if (Reader.HasRows)
                    {

                        if (Reader.Read())
                        {
                            //loginresult.Text = Reader["passwd"].ToString();
                            
                            if (Reader["passwd"].ToString() == Request.Form["passwd"])
                            {
                                Application["count"] = Convert.ToInt32(Application["count"]) + 1;
                                Session["name"] = Request.Form["name"];
                                Session["logined"] = "1";
                                Response.Redirect("paper scissor stone");
                            
                            }
                            else
                            {
                                loginresult.Text = "密碼錯誤";
                            }
                            
                        }
                    }
                    else
                    {
                        loginresult.Text = "無此帳號";
                    }


                    connection.Close();



                }
                else
                {
                    Response.Write("error");
                }
            }
        }
    }
}