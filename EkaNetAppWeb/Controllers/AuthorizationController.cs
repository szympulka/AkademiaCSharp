using System.Linq;
using EkaNetAppCore;
using EkaNetAppCore.Entities;
using System.Web.Mvc;
using System.Web.Security;
using EkaNetAppWeb.Helpers;
using EkaNetAppWeb.Models;
using System;

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
                var token = Guid.NewGuid().ToString();
                user.Password = HashPasswordHelper.HashPassword(user.Password);
                user.IsActive = false;
                user.PasswordToken = token;
                string message = "Hej to twój token: " + token;

                MailHelper.SendMail(user.Email,"Elo320",message);

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
                    if (User.Password == HashPasswordHelper.HashPassword(user.Password) && User.IsActive)
                    {
                        FormsAuthentication.SetAuthCookie(user.Email, false);
                        return RedirectToAction("Index", "Home");
                    }   
                }
            }
            return View();
        }
        public ActionResult UserLogout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }

        [Route("ActiveAccount/{token}")]
        public ActionResult ActiveAccount(string token)
        {
            var user = db.Users.SingleOrDefault(x => x.PasswordToken == token);
                if(user != null)
            {
                user.IsActive = true;
                db.SaveChanges();
            }
            return RedirectToAction("Index", "View");
        }

    }
}