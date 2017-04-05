using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EkaNetAppWeb.Helpers
{
    public class UserHelper
    {
        public static string UserName()
        {
            var userName = HttpContext.Current.User.Identity.Name;
            return userName;
        }
    }
}