
using Microsoft.EntityFrameworkCore;

namespace Net8_LoginPage.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
            
        }

        public DbSet<User> Users{ get; set; }
    }
}
