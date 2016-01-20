using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TheBest.Models.Authorization
{
    public class LoginInputModel
    {
        public string Name { get; set; }

        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}