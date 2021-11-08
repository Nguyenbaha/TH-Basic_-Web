using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web12
{
    public partial class SendMsg : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string message = Request.Form["message"];
            string color = Session["color"].ToString();
            string username = Session["username"].ToString();
            string mes = String.Format("<p style=\"color:{0}\">{1}:{2}</p>",color, username,message);
            Application["message"] = Application["message"] + mes;
            Response.Redirect("PostMsg.html");

        }
    }
}