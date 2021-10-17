using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace fashion_store.Models
{
    public class User
    {
        [Key]
        public int uid { get; set; }
        public string fname { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string cpassword { get; set; }

    }
}