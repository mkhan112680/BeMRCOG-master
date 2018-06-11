using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BeMRCOG.Models
{
    public class User
    {
        public bool RememberMe { get; set; }
        public bool Validated { get; set; }
        public bool Errored { get; set; }
        public string ErrorMessage { get; set; }
        public string UserID { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
        
        public User()
        {
        }
    }
}