using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkaNetAppCore.Entities
{
    public class UserInfo
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public long AccountNumber { get; set; }
        public int Balance { get; set; }
    }
}
