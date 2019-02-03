using Abp.Modules;
using Abp.Reflection.Extensions;
using MyProject2.Localization;

namespace MyProject2
{
    public class MyProject2CoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            MyProject2LocalizationConfigurer.Configure(Configuration.Localization);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MyProject2CoreModule).GetAssembly());
        }
    }
}