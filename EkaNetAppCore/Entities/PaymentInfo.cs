using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkaNetAppCore.Entities
{
     public class PaymentInfo
    {
        public int Id { get; set; }
        public double Amount { get; set; }
        public DateTime Date { get; set; }
        public bool PaymentByBankTransfer { get; set; }
        public int UserId { get; set; }


        [ForeignKey("UserId")]
        public virtual User User { get; set; }
    }
}
