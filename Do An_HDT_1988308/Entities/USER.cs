using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Do_An_HDT_1988308.Entities
{
    public class USER
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }

        public USER()
        {

        }
        public USER(int id, string name, string pass)
        {
            this.ID = id;
            this.UserName = name;
            this.PassWord = pass;
        }
    }
}