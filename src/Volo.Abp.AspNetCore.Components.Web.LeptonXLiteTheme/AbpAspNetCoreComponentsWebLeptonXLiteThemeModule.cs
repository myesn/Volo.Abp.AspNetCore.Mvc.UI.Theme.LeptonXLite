using Volo.Abp.AspNetCore.Components.Web.LeptonXLiteTheme.Toolbars;
using Volo.Abp.AspNetCore.Components.Web.Theming;
using Volo.Abp.AspNetCore.Components.Web.Theming.Layout;
using Volo.Abp.AspNetCore.Components.Web.Theming.Routing;
using Volo.Abp.AspNetCore.Components.Web.Theming.Theming;
using Volo.Abp.AspNetCore.Components.Web.Theming.Toolbars;
using Volo.Abp.Modularity;

namespace Volo.Abp.AspNetCore.Components.Web.LeptonXLiteTheme;

[DependsOn(
    typeof(AbpAspNetCoreComponentsWebThemingModule)
    )]
public class AbpAspNetCoreComponentsWebLeptonXLiteThemeModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        ConfigureToolbarOptions();
        ConfigureRouterOptions();
        ConfigurePageHeaderOptions();
        ConfigureLeptonXLiteTheme();
    }

    private void ConfigureToolbarOptions()
    {
        Configure<AbpToolbarOptions>(options =>
        {
            options.Contributors.Add(new LeptonXLiteThemeBlazorToolbarContributor());
        });
    }

    private void ConfigureRouterOptions()
    {
        Configure<AbpRouterOptions>(options =>
        {
            options.AdditionalAssemblies.Add(typeof(AbpAspNetCoreComponentsWebLeptonXLiteThemeModule).Assembly);
        });
    }

    private void ConfigurePageHeaderOptions()
    {
        Configure<PageHeaderOptions>(options =>
        {
            options.RenderBreadcrumbs = false;
        });
    }
    
    private void ConfigureLeptonXLiteTheme()
    {
        Configure<AbpThemingOptions>(options =>
        {
            options.Themes.Add<LeptonXLiteTheme>();
            
            if (options.DefaultThemeName == null)
            {
                options.DefaultThemeName = LeptonXLiteTheme.Name;
            }
        });
    }
}
