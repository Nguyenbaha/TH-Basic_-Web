using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web12
{
    public partial class MessageList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string mes = Application["message"].ToString();
            Response.Write(mes);
        }
    }
}