using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;

namespace WebApiToken.Models
{
    public class Usermodel
    {
        internal ClaimsIdentity username;

        public string UserName { get; set; }
        public string Password { get; set; }
    }
}