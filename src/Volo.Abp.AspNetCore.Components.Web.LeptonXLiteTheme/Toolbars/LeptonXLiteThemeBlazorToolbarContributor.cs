using System.Threading.Tasks;
using Volo.Abp.AspNetCore.Components.Web.LeptonXLiteTheme.Themes.LeptonXLite.Toolbar;
using Volo.Abp.AspNetCore.Components.Web.Theming.Toolbars;

namespace Volo.Abp.AspNetCore.Components.Web.LeptonXLiteTheme.Toolbars;

public class LeptonXLiteThemeBlazorToolbarContributor : IToolbarContributor
{
    public virtual Task ConfigureToolbarAsync(IToolbarConfigurationContext context)
    {
        if (context.Toolbar.Name == LeptonXLiteToolbars.Main)
        {
            context.Toolbar.Items.Add(new ToolbarItem(typeof(LanguageSwitchComponent)));
        }

        if (context.Toolbar.Name == LeptonXLiteToolbars.MainMobile)
        {
            context.Toolbar.Items.Add(new ToolbarItem(typeof(MobileLanguageSwitchComponent)));
        }

        return Task.CompletedTask;
    }
}
