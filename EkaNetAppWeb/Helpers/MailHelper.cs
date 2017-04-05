using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Web;

namespace EkaNetAppWeb.Helpers
{
    public class MailHelper
    {
        public static bool SendMail(string userMail,string title, string content)
        {
            //ConfigurationSettings.AppSettings["SendMailGmail"];
            MailMessage mail = new MailMessage();
            mail.To.Add(userMail);
            mail.From = new MailAddress(userMail, title, Encoding.UTF8);
            mail.Subject = title;
            mail.SubjectEncoding = Encoding.UTF8;
            mail.Body = content;
            mail.BodyEncoding = Encoding.UTF8;
            mail.IsBodyHtml = true;
            mail.Priority = MailPriority.High;
            SmtpClient client = new SmtpClient();
            client.Credentials = new NetworkCredential("lkjdsaflk", "sdafasdf");
            client.Port = 587;
            client.Host = "smtp.gmail.com";
            client.EnableSsl = true;
            try
            {
                client.Send(mail);
                return true;

            }
            catch(Exception ex)
            {
                return false;
            }

        }
    }
}