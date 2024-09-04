using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;
using Volo.Abp.AspNetCore.Components.Web.LeptonXLiteTheme.Toolbars;
using Volo.Abp.AspNetCore.Components.Web.Theming.Toolbars;
using Volo.Abp.AspNetCore.Components.WebAssembly.LeptonXLiteTheme.Themes.LeptonXLite.Toolbar;

namespace Volo.Abp.AspNetCore.Components.WebAssembly.LeptonXLiteTheme.Toolbars;

public class LeptonXLiteThemeToolbarContributor : IToolbarContributor
{
    public virtual Task ConfigureToolbarAsync(IToolbarConfigurationContext context)
    {
        if (context.Toolbar.Name == LeptonXLiteToolbars.Main) 
        {
            //TODO: Can we find a different way to understand if authentication was configured or not?
            var authenticationStateProvider = context.ServiceProvider
                .GetService<AuthenticationStateProvider>();

            if (authenticationStateProvider != null)
            {
                context.Toolbar.Items.Add(new ToolbarItem(typeof(UserMenuComponent)));
            }
        }

        if (context.Toolbar.Name == LeptonXLiteToolbars.MainMobile)
        {
            var authenticationStateProvider = context.ServiceProvider
                .GetService<AuthenticationStateProvider>();

            if (authenticationStateProvider != null)
            {
                context.Toolbar.Items.Add(new ToolbarItem(typeof(MobileUserMenuComponent)));
            }
        }

        return Task.CompletedTask;
    }
}
