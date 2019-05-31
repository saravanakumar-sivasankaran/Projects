using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiToken.Models;

namespace WebApiToken.Controllers
{
    public static class AuthRepository
    {
        public static List<Usermodel> ValidateUser(string userName, string password)
        {
            var list = new List<Usermodel>();

            Usermodel user = new Usermodel();
            user.UserName = "Saravanan";
            user.Password = "Vidhu";
            list.Add(user);

            return list;
        }
    }
}