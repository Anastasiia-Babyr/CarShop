using Microsoft.EntityFrameworkCore;
using CarShop.Models;

namespace CarShop.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<CarOrder> CarOrders { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
    }
}
