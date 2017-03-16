using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace EkaNetAppCore.Entities
{
    public class Return
    {
        public int Id { get; set; }
        public double Amount { get; set; }
        public DateTime Date { get; set; }
        public bool ReturnedByBankTransfer { get; set; }
        public int UserId { get; set; }
        public string Event { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }
    }
}
