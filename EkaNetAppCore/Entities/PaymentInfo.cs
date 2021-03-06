﻿using System;
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
        public string TitlePayment { get; set; }
        public string PaymentDescription { get; set; }
        public double Amount { get; set; }
        public DateTime Date { get; set; }
        public bool PaymentByBankTransfer { get; set; }
        public int UserId { get; set; }
        public string Event { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }
    }
}
