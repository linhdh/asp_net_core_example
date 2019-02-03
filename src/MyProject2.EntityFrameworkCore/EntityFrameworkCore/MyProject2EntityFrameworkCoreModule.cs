using Abp.EntityFrameworkCore;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace MyProject2.EntityFrameworkCore
{
    [DependsOn(
        typeof(MyProject2CoreModule), 
        typeof(AbpEntityFrameworkCoreModule))]
    public class MyProject2EntityFrameworkCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MyProject2EntityFrameworkCoreModule).GetAssembly());
        }
    }
}