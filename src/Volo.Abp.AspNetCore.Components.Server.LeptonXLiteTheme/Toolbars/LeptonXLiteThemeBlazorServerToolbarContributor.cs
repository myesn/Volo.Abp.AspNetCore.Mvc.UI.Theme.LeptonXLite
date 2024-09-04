using System.Threading.Tasks;
using Volo.Abp.AspNetCore.Components.Server.LeptonXLiteTheme.Themes.LeptonXLite.Toolbar;
using Volo.Abp.AspNetCore.Components.Web.LeptonXLiteTheme.Toolbars;
using Volo.Abp.AspNetCore.Components.Web.Theming.Toolbars;

namespace Volo.Abp.AspNetCore.Components.Server.LeptonXLiteTheme.Toolbars;

public class LeptonXLiteThemeBlazorServerToolbarContributor : IToolbarContributor
{
    public Task ConfigureToolbarAsync(IToolbarConfigurationContext context)
    {
        if (context.Toolbar.Name == LeptonXLiteToolbars.Main)
        {
            context.Toolbar.Items.Add(new ToolbarItem(typeof(UserMenuComponent)));
        }

        if (context.Toolbar.Name == LeptonXLiteToolbars.MainMobile)
        {
            context.Toolbar.Items.Add(new ToolbarItem(typeof(MobileUserMenuComponent)));
        }

        return Task.CompletedTask;
    }
}
