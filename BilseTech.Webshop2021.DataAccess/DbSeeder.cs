using System.Collections.Generic;
using BilseTech.Webshop2021.DataAccess.Entities;

namespace BilseTech.Webshop2021.DataAccess
{
    public class DbSeeder
    {
        private readonly MainDbContext _ctx;

        public DbSeeder(MainDbContext ctx)
        {
            _ctx = ctx;
        }
        
        public void SeedDevelopment(){
            _ctx.Database.EnsureDeleted();
            _ctx.Database.EnsureCreated();
            _ctx.Products.AddRange(new List<EntityProduct>
            {
                new EntityProduct {Name = "Product 1"},
                new EntityProduct {Name = "Product 2"},
                new EntityProduct {Name = "Product 3"},
            });
            _ctx.SaveChanges();
        }

        public void SeedProduction()
        {
            _ctx.Database.EnsureCreated();
            
        }
    }
}