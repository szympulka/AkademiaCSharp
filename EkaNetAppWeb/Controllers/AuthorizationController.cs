using System.Linq;
using EkaNetAppCore;
using EkaNetAppCore.Entities;
using System.Web.Mvc;
using System.Web.Security;
using EkaNetAppWeb.Helpers;
using EkaNetAppWeb.Models;

namespace EkaNetAppWeb.Controllers
{
 

    public class AuthorizationController : Controller
    {
        DataContext db = new DataContext();
        // GET: Authorization
        public ActionResult Registration(User user)
        {
            if(user.Email != null)
            {
                user.Password = HashPasswordHelper.HashPassword(user.Password);
                db.Users.Add(user);
            
                db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
        public ActionResult Login(LoginModel user)
        {
            if(user.Email != null && user.Password !=null)
            {
               var User = db.Users.FirstOrDefault(x => x.Email == user.Email);
                if (User != null)
                {
                    if (User.Password == HashPasswordHelper.HashPassword(user.Password))
                    {
                        FormsAuthentication.SetAuthCookie(user.Email, false);
                    }   
                }
            
            }
            return View();
        }
    }
}