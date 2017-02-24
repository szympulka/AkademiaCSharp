using System.Data.Entity;
using EkaNetAppCore.Entities;

namespace EkaNetAppCore
{
    public class DataContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<UserInfo> UserInfos { get; set; }
    }
}
