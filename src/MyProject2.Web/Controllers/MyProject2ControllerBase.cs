using Abp.AspNetCore.Mvc.Controllers;

namespace MyProject2.Web.Controllers
{
    public abstract class MyProject2ControllerBase: AbpController
    {
        protected MyProject2ControllerBase()
        {
            LocalizationSourceName = MyProject2Consts.LocalizationSourceName;
        }
    }
}