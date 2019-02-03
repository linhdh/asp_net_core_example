using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace MyProject2
{
    [DependsOn(
        typeof(MyProject2CoreModule), 
        typeof(AbpAutoMapperModule))]
    public class MyProject2ApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MyProject2ApplicationModule).GetAssembly());
        }
    }
}