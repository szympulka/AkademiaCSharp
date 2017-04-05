using EkaNetAppCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EkaNetAppWeb.Controllers
{
    
    public class AdminController : Controller
    {
        DataContext db = new DataContext();

        public ActionResult AdminPanel()
        {
            return View();
        }
        public ActionResult UsersDebts()
        {
            var users = db.Users.Where(x => x.Balance < 0);
            return View(users);
        }
    }
}