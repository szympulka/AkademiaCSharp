using System.Data.Entity;
using EkaNetAppCore.Entities;

namespace EkaNetAppCore
{
    public class DataContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Return> Returns { get; set; }
        public DbSet<PaymentInfo> PaymentInfos { get; set; }
    }
}
