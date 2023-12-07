using Microsoft.EntityFrameworkCore;

namespace ETicaret.Models
{
    public class MyDbContext:DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> opt):base(opt)
        {
                
        }
        public DbSet<Product> Products { get; set; }
    }
}
