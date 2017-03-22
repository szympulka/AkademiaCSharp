using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EkaNetAppWeb.Models
{
    public class PaymentInfoModel
    {
        public double Amount { get; set; }
        public bool PaymentByBankTransfer { get; set; }
        public string Event { get; set; }
        public string TitlePayment { get; set; }
        public string PaymentDescription { get; set; }

    }
}