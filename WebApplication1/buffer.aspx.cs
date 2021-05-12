using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class buffer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.BufferOutput = false;
            Response.Flush();
            for(int i = 1; i <= 20; i++)
            {
                Response.Write("(" + i.ToString() + ")");
                System.Threading.Thread.Sleep(400);
                
            }
            Response.End();
        }
    }
}