using Abp.AspNetCore.Mvc.Views;

namespace MyProject2.Web.Views
{
    public abstract class MyProject2RazorPage<TModel> : AbpRazorPage<TModel>
    {
        protected MyProject2RazorPage()
        {
            LocalizationSourceName = MyProject2Consts.LocalizationSourceName;
        }
    }
}
