using System.Collections.Generic;
using Volo.Abp.AspNetCore.Mvc.UI.Bundling;
using Volo.Abp.Localization;

namespace Volo.Abp.AspNetCore.Components.Server.LeptonXLiteTheme.Bundling;

public class BlazorLeptonXLiteThemeStyleContributor : BundleContributor
{
    public override void ConfigureBundle(BundleConfigurationContext context)
    {
       context.Files.AddIfNotContains("/_content/Volo.Abp.AspNetCore.Components.Web.LeptonXLiteTheme/side-menu/libs/chart.js/Chart.min.css");
       context.Files.AddIfNotContains("/_content/Volo.Abp.AspNetCore.Components.Web.LeptonXLiteTheme/side-menu/libs/bootstrap-datepicker/css/bootstrap-datepicker.min.css");
       context.Files.AddIfNotContains("/_content/Volo.Abp.AspNetCore.Components.Web.LeptonXLiteTheme/side-menu/libs/bootstrap-icons/font/bootstrap-icons.css");

       var rtlPostfix = CultureHelper.IsRtl ? ".rtl" : string.Empty;
       
       context.Files.AddIfNotContains($"/_content/Volo.Abp.AspNetCore.Components.Web.LeptonXLiteTheme/side-menu/css/abp-bundle{rtlPostfix}.css");
       context.Files.AddIfNotContains($"/_content/Volo.Abp.AspNetCore.Components.Web.LeptonXLiteTheme/side-menu/css/blazor-bundle{rtlPostfix}.css");
       context.Files.AddIfNotContains($"/_content/Volo.Abp.AspNetCore.Components.Web.LeptonXLiteTheme/side-menu/css/bootstrap-dim{rtlPostfix}.css");
       context.Files.AddIfNotContains($"/_content/Volo.Abp.AspNetCore.Components.Web.LeptonXLiteTheme/side-menu/css/layout-bundle{rtlPostfix}.css");
       context.Files.AddIfNotContains($"/_content/Volo.Abp.AspNetCore.Components.Web.LeptonXLiteTheme/side-menu/css/font-bundle{rtlPostfix}.css");
    }
}
