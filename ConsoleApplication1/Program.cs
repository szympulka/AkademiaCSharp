using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using EkaNetAppCore;
using EkaNetAppCore.Entities;

namespace ConsoleApplication1
{
    class Program
    {

        static void Main(string[] args)
        {
            DataContext db = new DataContext();
            User user = new User();

            ////user.Name = "Szymon";
            ////user.Adress = "dsafasdfasdfdsaf";
            ////user.Balance = 23;
            //////user.LastLogin = DateTime.Today;
            ////db.Users.Add(user);

            //var Payment = new PaymentInfo();
            //Payment.Date = DateTime.Now;
            //Payment.Amount = 8524;
            //Payment.UserId = 5;

            //db.PaymentInfos.Add(Payment);
            //db.SaveChanges();



            var User = db.Users.FirstOrDefault(x => x.Name == "Szymon");
            var pay = db.PaymentInfos.Where(x => x.Id == User.Id);


            foreach(var p in pay)
            {
                Console.WriteLine(p.Amount);
            }
            Console.ReadKey();



        }
    }
}
