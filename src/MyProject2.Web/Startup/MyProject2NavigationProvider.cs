using Abp.Application.Navigation;
using Abp.Localization;

namespace MyProject2.Web.Startup
{
    /// <summary>
    /// This class defines menus for the application.
    /// </summary>
    public class MyProject2NavigationProvider : NavigationProvider
    {
        public override void SetNavigation(INavigationProviderContext context)
        {
            context.Manager.MainMenu
                .AddItem(
                    new MenuItemDefinition(
                        PageNames.Home,
                        L("HomePage"),
                        url: "",
                        icon: "fa fa-home"
                        )
                )
                .AddItem(
                    new MenuItemDefinition(
                        PageNames.Upload,
                        L("Upload"),
                        url: "Home/Upload",
                        icon: "fa fa-upload"
                        )
                )
                .AddItem(
                    new MenuItemDefinition(
                        PageNames.ProductList,
                        L("Product List"),
                        url: "Home/ProductList",
                        icon: "fa fa-list-ul"
                        )
                )
                .AddItem(
                    new MenuItemDefinition(
                        PageNames.About,
                        L("About"),
                        url: "Home/About",
                        icon: "fa fa-info"
                        )
                );
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, MyProject2Consts.LocalizationSourceName);
        }
    }
}
