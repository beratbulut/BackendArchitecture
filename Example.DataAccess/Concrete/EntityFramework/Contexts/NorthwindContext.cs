using Example.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace Example.DataAccess.Concrete.EntityFramework.Contexts
{
    public class NorthwindContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-P4D8NV6;Database=NORTHWND;User Id=erd;Password=erd;");
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}
