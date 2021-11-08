using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tuan6
{
    public partial class Xuly : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string name = Request.Form["name"];
            string gender = Request.Form["gender"];
            string dob = Request.Form["dob"];
            string email = Request.Form["email"];
            string phone = Request.Form["phone"];
            string address = Request.Form["address"];
            int tg = 0;
            Nhanvien nv1 = new Nhanvien(name, gender, dob, email, phone, address);
            List<Nhanvien> arr = (List<Nhanvien>)Session["danhsach"];
            if(arr == null)
            {
                arr = new List<Nhanvien>();
                
            }
            foreach (Nhanvien nv in arr)
            {
                if(nv.phone.Contains(nv1.phone) && nv.email.Contains(nv1.email))
                {
                    tg = 1;
                    break;
                }
            }
            
            if(tg==0)
            {
                arr.Add(nv1);
            }
            Session["danhsach"] = arr;
            int stt = 1;
            foreach (Nhanvien nv in arr)
            {
                TableRow row = new TableRow();
                TableCell cell1 = new TableCell();
                cell1.Text = stt.ToString();
                row.Cells.Add(cell1);

                TableCell cell2 = new TableCell();
                cell2.Text = nv.name;
                row.Cells.Add(cell2);

                TableCell cell3 = new TableCell();
                cell3.Text = nv.gender;
                row.Cells.Add(cell3);

                TableCell cell4 = new TableCell();
                cell4.Text = nv.dob;
                row.Cells.Add(cell4);

                TableCell cell5 = new TableCell();
                cell5.Text = nv.email;
                row.Cells.Add(cell5);

                TableCell cell6 = new TableCell();
                cell6.Text = nv.phone;
                row.Cells.Add(cell6);

                TableCell cell7 = new TableCell();
                cell7.Text = nv.address;
                row.Cells.Add(cell7);

                Table1.Rows.Add(row);
                stt++;
            }
        }
    }
}