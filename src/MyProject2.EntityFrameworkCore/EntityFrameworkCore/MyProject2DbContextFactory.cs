using MyProject2.Configuration;
using MyProject2.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace MyProject2.EntityFrameworkCore
{
    /* This class is needed to run EF Core PMC commands. Not used anywhere else */
    public class MyProject2DbContextFactory : IDesignTimeDbContextFactory<MyProject2DbContext>
    {
        public MyProject2DbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<MyProject2DbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            DbContextOptionsConfigurer.Configure(
                builder,
                configuration.GetConnectionString(MyProject2Consts.ConnectionStringName)
            );

            return new MyProject2DbContext(builder.Options);
        }
    }
}