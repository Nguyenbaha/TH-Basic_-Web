using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web12
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(IsPostBack)
            {
                int tg = 0;
                string vl1 = Request.Form["user"];
                string vl2 = Request.Form["color"];
                    user u1 = new user(vl1,vl2);
                List<user> arr = (List<user>)Application["checkmember"];
                if (arr == null)
                {arr = new List<user>();}
                foreach (user u in arr)
                {
                    if (u.Nick.Contains(u1.Nick) && u.color.Contains(u1.color))
                    {
                        Session["username"] = u.Nick;
                        Session["color"] = u.color;
                        tg = 1;
                        break;
                    }
                }
                if (tg == 0)
                {
                    Session["username"] = Request.Form["user"];
                    Session["color"] = Request.Form["color"];
                    string color = Session["color"].ToString();
                    string username = Session["username"].ToString();
                    string member = String.Format("<p style=\"color:{0}\">{1}</p>", color, username);
                    Application["member"] = Application["member"] + member;
                    arr.Add(u1);
                }
                Application["checkmember"] = arr;
                Response.Redirect("FrameSet.html", true);
                
               
                
                
               
               
            }
        }
    }
}