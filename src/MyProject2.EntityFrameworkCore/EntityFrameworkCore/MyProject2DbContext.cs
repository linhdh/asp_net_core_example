using Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyProject2.Models;

namespace MyProject2.EntityFrameworkCore
{
    public class MyProject2DbContext : AbpDbContext
    {
        //Add DbSet properties for your entities...
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductGroup> Groups { get; set; }

        public MyProject2DbContext(DbContextOptions<MyProject2DbContext> options) 
            : base(options)
        {

        }
    }
}
