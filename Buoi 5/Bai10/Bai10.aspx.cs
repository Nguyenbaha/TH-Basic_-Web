using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
namespace Bai10
{
    public partial class Bai10 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                string noiDung = Request.Form["txtNoiDung"];
                
                if (!String.IsNullOrEmpty(noiDung))
                {
                   
                    HttpPostedFile file = Request.Files["Folder"];
                    if (file != null && file.ContentLength > 0)
                    {
                       // Response.Write("Noi dung la: "+noiDung);
                        tcon.InnerHtml="Noi dung vua nhap : "+noiDung;
                        file.SaveAs(Path.Combine(Server.MapPath("~/App_Data"), Path.GetFileName(file.FileName)));
                        sucess.Controls.Add(new LiteralControl("Thành công"));
                    }
                    
                }
                
            }
        }

    }
}