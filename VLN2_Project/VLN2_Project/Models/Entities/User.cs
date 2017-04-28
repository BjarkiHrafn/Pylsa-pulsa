using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VLN2_Project.Models.Entities
{
    public class User
    {
        public int ID { get; set; }
        public string _userName { get; set; }
        public string _passWord { get; set; }
    }
}