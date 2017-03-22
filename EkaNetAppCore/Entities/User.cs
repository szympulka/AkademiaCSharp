using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkaNetAppCore.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Adress { get; set; }
        public string BankAccountNumber { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int PhoneNumber { get; set; }
        public DateTime? LastLogin { get; set; }
        public double Balance { get; set; }
        public string Role { get; set; }

        public ICollection<Return> Returns { get; set; }
        public ICollection<PaymentInfo> PaymentInfos { get; set; }

    }
}
