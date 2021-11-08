using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tuan6
{
    public class Nhanvien
    {
        public string name { get; set; }

        public string gender { get; set; }
        public string dob { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string address { get; set; }

        public Nhanvien()
        {

        }
        public Nhanvien(string name, string gender, string dob, string email, string phone, string address)
        {
            this.name = name;
            this.gender = gender;
            this.dob = dob;
            this.email = email;
            this.phone = phone;
            this.address = address;

        }
        public class ArrayList<Nhanvien>
        {
        }
    }
}