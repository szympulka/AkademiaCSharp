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
            var db = new DataContext();
            //User users = new User();
            //users.Email = "adssad";
            //users.LastLogin = DateTime.MaxValue;
            //users.UserName = "dsfasdf";
            //users.Password = "sadasd";
            //db.Users.Add(users);
            //db.SaveChanges();
            //User user = db.Users.FirstOrDefault(x => x.Id == 1); 

            var users = db.Users.Where(x => true);
            foreach (var user in users)
            {
                Console.WriteLine(user.UserName);
                
            }           
            Console.ReadKey();
        }
    }
}
