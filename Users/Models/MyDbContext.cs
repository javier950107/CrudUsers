using Microsoft.EntityFrameworkCore;

namespace CRUDUsers.Models
{
    public class MyDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }
    }
}
