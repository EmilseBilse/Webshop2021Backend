using BilseTech.Webshop2021.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace BilseTech.Webshop2021.DataAccess
{
    public class MainDbContext : DbContext
    {
        public MainDbContext(DbContextOptions<MainDbContext> options) : base(options)
        {
        }

        public DbSet<EntityProduct> Products { get; set; }
        
    }
}