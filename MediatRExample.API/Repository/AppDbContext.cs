using MediatRExample.API.Entity;
using Microsoft.EntityFrameworkCore;

namespace MediatRExample.API.Repository
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions opt) : base(opt)
        {
            
        }

        public DbSet<Product> Products { get; set; }
    }
}
