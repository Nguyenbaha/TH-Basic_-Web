using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web12
{
    public class user
    {
        public string Nick { get; set; }
        public string color { get; set; }
        public user()
        {


        }
        public user(string Nick, string color)
        {
            this.Nick = Nick;
            this.color = color;

        }
    }
}