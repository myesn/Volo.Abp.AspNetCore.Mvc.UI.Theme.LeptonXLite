using System.Collections.Generic;
using Volo.Abp.AspNetCore.Mvc.UI.Bundling;

namespace Volo.Abp.AspNetCore.Mvc.UI.Theme.LeptonXLite.Bundling;

public class LeptonXLiteThemeGlobalScriptContributor : BundleContributor
{
    private const string RootPath = "/Themes/LeptonXLite/Global";
    public override void ConfigureBundle(BundleConfigurationContext context)
    {
        context.Files.Add($"{RootPath}/side-menu/js/lepton-x.bundle.min.js");
        context.Files.Add($"{RootPath}/scripts/leptonx-mvc-ui-initializer.js");
    }
}
