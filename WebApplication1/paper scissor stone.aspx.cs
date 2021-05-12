using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class paper_scissor_stone : System.Web.UI.Page
    {
        static int ct=60;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["name"] == null)
            {
                Response.Redirect("login");
            }
            chatname.Text = Session["name"].ToString();
            countpeoplelabe.Text = "目前線上人數:" + Application["count"];
            
            
            if (Session["logined"] == null)
            {
                Response.Redirect("login");
            }
            
        }

        protected void Button_Click(object sender, ImageClickEventArgs e)
        {
            int user = 0;
            if (sender == ImageButton1)
            {
                user = 1;
                userResult.Text = "玩家出剪刀!";
            }else if (sender== ImageButton2)
            {
                user = 2;
                userResult.Text = "玩家出石頭!";
            }else if (sender== ImageButton3)
            {
                user = 3;
                userResult.Text = "玩家出布!";
            }
            Random rnd = new Random();
            int comp = rnd.Next(1,4);
            if (comp == 1)
            {
                compResult.Text = "電腦出剪刀!";
                comppic.ImageUrl = "~/pics/scissors.png";
            }else if (comp == 2)
            {
                compResult.Text = "電腦出石頭!";
                comppic.ImageUrl = "~/pics/stone.png";
            }
            else if (comp == 3)
            {
                compResult.Text = "電腦出布!";
                comppic.ImageUrl = "~/pics/paper.png";
            }
            if ((user == 1 && comp == 3) ||
                (user == 2 && comp == 1) ||
                (user == 3 && comp == 2))
                final.Text = "You Win";
            else if ((user == 1 && comp == 2) ||
                (user == 2 && comp == 3) ||
                (user == 3 && comp == 1))
                final.Text = "You Lose";
            else
                final.Text = "draw";
                
                
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            ct--;
            timelabel.Text = "倒數計時:" +ct.ToString();
            

            if (Application["message"] != null)
                chatlabel.Text = Application["message"].ToString();//聊天
        }
        protected void sendbtn_Click(object sender, EventArgs e)
        {
            string message = input_chat.Text;
            Application["message"] = Application["message"] + Session["name"].ToString() +":" + message + "<br>";

        }

        protected void logout_Click(object sender, EventArgs e)
        {
            Application["count"] = Convert.ToInt32(Application["count"]) - 1;
            Session.RemoveAll();
            Response.Redirect("logintest");
           
        }

        
    }
}