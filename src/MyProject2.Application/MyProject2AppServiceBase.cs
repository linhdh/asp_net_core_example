using Abp.Application.Services;

namespace MyProject2
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class MyProject2AppServiceBase : ApplicationService
    {
        protected MyProject2AppServiceBase()
        {
            LocalizationSourceName = MyProject2Consts.LocalizationSourceName;
        }
    }
}