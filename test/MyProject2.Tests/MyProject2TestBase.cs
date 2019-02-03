using System;
using System.Threading.Tasks;
using Abp.TestBase;
using MyProject2.EntityFrameworkCore;
using MyProject2.Tests.TestDatas;

namespace MyProject2.Tests
{
    public class MyProject2TestBase : AbpIntegratedTestBase<MyProject2TestModule>
    {
        public MyProject2TestBase()
        {
            UsingDbContext(context => new TestDataBuilder(context).Build());
        }

        protected virtual void UsingDbContext(Action<MyProject2DbContext> action)
        {
            using (var context = LocalIocManager.Resolve<MyProject2DbContext>())
            {
                action(context);
                context.SaveChanges();
            }
        }

        protected virtual T UsingDbContext<T>(Func<MyProject2DbContext, T> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<MyProject2DbContext>())
            {
                result = func(context);
                context.SaveChanges();
            }

            return result;
        }

        protected virtual async Task UsingDbContextAsync(Func<MyProject2DbContext, Task> action)
        {
            using (var context = LocalIocManager.Resolve<MyProject2DbContext>())
            {
                await action(context);
                await context.SaveChangesAsync(true);
            }
        }

        protected virtual async Task<T> UsingDbContextAsync<T>(Func<MyProject2DbContext, Task<T>> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<MyProject2DbContext>())
            {
                result = await func(context);
                context.SaveChanges();
            }

            return result;
        }
    }
}
