using EkaNetAppCore;
using EkaNetAppWeb.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EkaNetAppWeb.Controllers
{

    public class UserController : Controller
    {
        DataContext db = new DataContext();
        // GET: User
        public ActionResult UserPanel()
        {
            return View();
        }

        public ActionResult GetLastPayments()
        {
            var user = db.Users.First(x => x.Email == HttpContext.User.Identity.Name);
            var payments = db.PaymentInfos.Where(w => w.UserId == user.Id );
            return View(payments);
        }
        public ActionResult GetLastFivePayments()
        {
            var payments = db.PaymentInfos.OrderByDescending(x=> x.Id).Take(5);
            return View(payments);
        }
    }
}