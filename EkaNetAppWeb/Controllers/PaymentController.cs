using EkaNetAppCore;
using EkaNetAppCore.Entities;
using EkaNetAppWeb.Models;
using System;
using System.Linq;
using System.Web.Mvc;

namespace EkaNetAppWeb.Controllers
{
    [Authorize]
    public class PaymentController : Controller
    {
        DataContext db = new DataContext();
        // GET: Payment
        public ActionResult AddPayment(PaymentInfoModel model)
        {
            if(model.Event != null)
            {
                var paymentInfo = new PaymentInfo();
                var user = db.Users.FirstOrDefault(x => x.Email == HttpContext.User.Identity.Name);
                paymentInfo.Amount = model.Amount;
                paymentInfo.PaymentByBankTransfer = model.PaymentByBankTransfer;
                paymentInfo.Event = model.Event;
                paymentInfo.Date = DateTime.Now;
                paymentInfo.TitlePayment = model.TitlePayment;
                paymentInfo.PaymentDescription = model.PaymentDescription;

                if(user != null) paymentInfo.UserId = user.Id;

                db.PaymentInfos.Add(paymentInfo);
                db.SaveChanges();

                return RedirectToAction("Index", "Home");
            }
            return View();
        }
    }
}