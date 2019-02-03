using Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MyProject2.EntityFrameworkCore
{
    public class MyProject2DbContext : AbpDbContext
    {
        //Add DbSet properties for your entities...

        public MyProject2DbContext(DbContextOptions<MyProject2DbContext> options) 
            : base(options)
        {

        }
    }
}
