using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AspNetCore.Mvc.UI.Bundling;
using Volo.Abp.AspNetCore.Mvc.UI.MultiTenancy;
using Volo.Abp.AspNetCore.Mvc.UI.Theme.LeptonXLite.Bundling;
using Volo.Abp.AspNetCore.Mvc.UI.Theme.LeptonXLite.ObjectMapping;
using Volo.Abp.AspNetCore.Mvc.UI.Theme.LeptonXLite.Toolbars;
using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared;
using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Bundling;
using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Toolbars;
using Volo.Abp.AspNetCore.Mvc.UI.Theming;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace Volo.Abp.AspNetCore.Mvc.UI.Theme.LeptonXLite;

[DependsOn(
    typeof(AbpAspNetCoreMvcUiThemeSharedModule),
    typeof(AbpAspNetCoreMvcUiMultiTenancyModule),
    typeof(AbpAutoMapperModule)
    )]
public class AbpAspNetCoreMvcUiLeptonXLiteThemeModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(AbpAspNetCoreMvcUiLeptonXLiteThemeModule).Assembly);
        });
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAutoMapperObjectMapper<AbpAspNetCoreMvcUiLeptonXLiteThemeModule>();

        Configure<AbpAutoMapperOptions>(options =>
        {
            options.AddProfile<LeptonXLiteAutoMapperProfile>(validate: true);
        });

        Configure<AbpThemingOptions>(options =>
        {
            options.Themes.Add<LeptonXLiteTheme>();

            if (options.DefaultThemeName == null)
            {
                options.DefaultThemeName = LeptonXLiteTheme.Name;
            }
        });

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<AbpAspNetCoreMvcUiLeptonXLiteThemeModule>("Volo.Abp.AspNetCore.Mvc.UI.Theme.LeptonXLite");
        });

        Configure<AbpToolbarOptions>(options =>
        {
            options.Contributors.Add(new LeptonXLiteThemeMainTopToolbarContributor());
        });

        Configure<AbpBundlingOptions>(options =>
        {
            options
                .StyleBundles
                .Add(LeptonXLiteThemeBundles.Styles.Global, bundle =>
                {
                    bundle
                        .AddBaseBundles(StandardBundles.Styles.Global)
                        .AddContributors(typeof(LeptonXLiteThemeGlobalStyleContributor));
                });

            options
                .ScriptBundles
                .Add(LeptonXLiteThemeBundles.Scripts.Global, bundle =>
                {
                    bundle
                        .AddBaseBundles(StandardBundles.Scripts.Global)
                        .AddContributors(typeof(LeptonXLiteThemeGlobalScriptContributor));
                });
        });
    }
}
