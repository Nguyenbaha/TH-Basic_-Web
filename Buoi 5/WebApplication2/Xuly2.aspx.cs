using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class Xuly2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            string TenVXL = Request.QueryString["txtTenVXL"];
            string Hang = Request.QueryString["txtHang"];
            string NgayRaMat = Request.QueryString["txtNgayRaMat"];
            string Gia = Request.QueryString["txtGia"];
            Response.ContentType = "text/xml";
            string XML = "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
                         "<XuLy>" +
                         "<Ten>" + TenVXL + "</Ten>" +
                         "<Hang>" + Hang + "</Hang>" +
                         "<NgayRaMat>" + NgayRaMat + "</NgayRaMat>" +
                         "<Gia>" + Gia + "</Gia>" +
                         "</XuLy>";
            Response.Write(XML);
            Response.End();

        }
    }
}