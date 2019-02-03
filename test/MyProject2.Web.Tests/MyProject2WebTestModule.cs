using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MyProject2.Web.Startup;
namespace MyProject2.Web.Tests
{
    [DependsOn(
        typeof(MyProject2WebModule),
        typeof(AbpAspNetCoreTestBaseModule)
        )]
    public class MyProject2WebTestModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MyProject2WebTestModule).GetAssembly());
        }
    }
}