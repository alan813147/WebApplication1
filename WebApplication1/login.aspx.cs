using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
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
                    if (Request.Form["user"] == "alan" && Request.Form["passwd"] == "123456")
                    {
                        Application["count"] = Convert.ToInt32(Application["count"]) + 1;
                        Session["name"] = Request.Form["name"];
                        Session["logined"] = "1";
                        Response.Redirect("paper scissor stone");
                    }
                    else
                    {
                        loginresult.Text = "帳密錯誤";
                    }
                }
            }

        }
    }
}