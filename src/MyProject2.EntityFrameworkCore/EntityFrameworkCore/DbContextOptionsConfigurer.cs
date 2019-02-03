using Microsoft.EntityFrameworkCore;

namespace MyProject2.EntityFrameworkCore
{
    public static class DbContextOptionsConfigurer
    {
        public static void Configure(
            DbContextOptionsBuilder<MyProject2DbContext> dbContextOptions, 
            string connectionString
            )
        {
            /* This is the single point to configure DbContextOptions for MyProject2DbContext */
            dbContextOptions.UseSqlServer(connectionString);
        }
    }
}
