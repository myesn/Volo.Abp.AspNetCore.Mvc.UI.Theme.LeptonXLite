using Volo.Abp.AspNetCore.Components.Server.LeptonXLiteTheme.Bundling;
using Volo.Abp.AspNetCore.Components.Server.LeptonXLiteTheme.Toolbars;
using Volo.Abp.AspNetCore.Components.Server.Theming;
using Volo.Abp.AspNetCore.Components.Server.Theming.Bundling;
using Volo.Abp.AspNetCore.Components.Web.LeptonXLiteTheme;
using Volo.Abp.AspNetCore.Components.Web.Theming.Toolbars;
using Volo.Abp.AspNetCore.Mvc.UI.Bundling;
using Volo.Abp.Modularity;

namespace Volo.Abp.AspNetCore.Components.Server.LeptonXLiteTheme;

[DependsOn(
    typeof(AbpAspNetCoreComponentsWebLeptonXLiteThemeModule),
    typeof(AbpAspNetCoreComponentsServerThemingModule)
    )]
public class AbpAspNetCoreComponentsServerLeptonXLiteThemeModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpToolbarOptions>(options =>
        {
            options.Contributors.Add(new LeptonXLiteThemeBlazorServerToolbarContributor());
        });

        Configure<AbpBundlingOptions>(options =>
        {
            options
                .StyleBundles
                .Add(BlazorLeptonXLiteThemeBundles.Styles.Global, bundle =>
                {
                    bundle
                        .AddBaseBundles(BlazorStandardBundles.Styles.Global)
                        .AddContributors(typeof(BlazorLeptonXLiteThemeStyleContributor));
                });

            options
                .ScriptBundles
                .Add(BlazorLeptonXLiteThemeBundles.Scripts.Global, bundle =>
                {
                    bundle
                        .AddBaseBundles(BlazorStandardBundles.Scripts.Global)
                        .AddContributors(typeof(BlazorLeptonXLiteThemeScriptContributor));
                });
        });
    }
}
