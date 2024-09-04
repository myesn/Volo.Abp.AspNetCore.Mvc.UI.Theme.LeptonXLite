using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc.UI.Theme.LeptonXLite.Themes.LeptonXLite.Components.Toolbar.LanguageSwitch;
using Volo.Abp.AspNetCore.Mvc.UI.Theme.LeptonXLite.Themes.LeptonXLite.Components.Toolbar.MobileLanguageSwitch;
using Volo.Abp.AspNetCore.Mvc.UI.Theme.LeptonXLite.Themes.LeptonXLite.Components.Toolbar.MobileLoginLink;
using Volo.Abp.AspNetCore.Mvc.UI.Theme.LeptonXLite.Themes.LeptonXLite.Components.Toolbar.MobileUserMenu;
using Volo.Abp.AspNetCore.Mvc.UI.Theme.LeptonXLite.Themes.LeptonXLite.Components.Toolbar.UserMenu;
using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Toolbars;
using Volo.Abp.Users;

namespace Volo.Abp.AspNetCore.Mvc.UI.Theme.LeptonXLite.Toolbars;

public class LeptonXLiteThemeMainTopToolbarContributor : IToolbarContributor
{
    public async Task ConfigureToolbarAsync(IToolbarConfigurationContext context)
    {
        if (!(context.Theme is LeptonXLiteTheme))
        {
            return;
        }

        if (context.Toolbar.Name == LeptonXLiteToolbars.Main)
        {
            context.Toolbar.Items.Add(new ToolbarItem(typeof(LanguageSwitchViewComponent)));

            if (context.ServiceProvider.GetRequiredService<ICurrentUser>().IsAuthenticated)
            {
                context.Toolbar.Items.Add(new ToolbarItem(typeof(UserMenuViewComponent)));
            }
        }

        if (context.Toolbar.Name == LeptonXLiteToolbars.MainMobile)
        {
            context.Toolbar.Items.Add(new ToolbarItem(typeof(MobileLanguageSwitchViewComponent)));

            if (context.ServiceProvider.GetRequiredService<ICurrentUser>().IsAuthenticated)
            {
                context.Toolbar.Items.Add(new ToolbarItem(typeof(MobileUserMenuViewComponent)));
            }
            else
            {
                context.Toolbar.Items.Add(new ToolbarItem(typeof(MobileLoginLinkViewComponent)));
            }
        }
    }
}
