using System.Collections.Generic;
using Volo.Abp.AspNetCore.Mvc.UI.Bundling;

namespace Volo.Abp.AspNetCore.Components.Server.LeptonXLiteTheme.Bundling;

public class BlazorLeptonXLiteThemeScriptContributor : BundleContributor
{
    public override void ConfigureBundle(BundleConfigurationContext context)
    {
        context.Files.AddIfNotContains("/_content/Volo.Abp.AspNetCore.Components.Web.LeptonXLiteTheme/side-menu/libs/bootstrap/js/bootstrap.bundle.js");
        context.Files.AddIfNotContains("/_content/Volo.Abp.AspNetCore.Components.Web.LeptonXLiteTheme/side-menu/js/lepton-x.bundle.min.js");
        context.Files.AddIfNotContains("/_content/Volo.Abp.AspNetCore.Components.Web.LeptonXLiteTheme/side-menu/libs/jquery/jquery.min.js");
        context.Files.AddIfNotContains("/_content/Volo.Abp.AspNetCore.Components.Web.LeptonXLiteTheme/side-menu/libs/bootstrap-datepicker/js/bootstrap-datepicker.min.js");
        context.Files.AddIfNotContains("/_content/Volo.Abp.AspNetCore.Components.Web.LeptonXLiteTheme/scripts/style-initializer.js");
    }
}
