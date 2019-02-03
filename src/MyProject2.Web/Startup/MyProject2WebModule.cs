using Abp.AspNetCore;
using Abp.AspNetCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MyProject2.Configuration;
using MyProject2.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace MyProject2.Web.Startup
{
    [DependsOn(
        typeof(MyProject2ApplicationModule), 
        typeof(MyProject2EntityFrameworkCoreModule), 
        typeof(AbpAspNetCoreModule))]
    public class MyProject2WebModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public MyProject2WebModule(IHostingEnvironment env)
        {
            _appConfiguration = AppConfigurations.Get(env.ContentRootPath, env.EnvironmentName);
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(MyProject2Consts.ConnectionStringName);

            Configuration.Navigation.Providers.Add<MyProject2NavigationProvider>();

            Configuration.Modules.AbpAspNetCore()
                .CreateControllersForAppServices(
                    typeof(MyProject2ApplicationModule).GetAssembly()
                );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MyProject2WebModule).GetAssembly());
        }
    }
}