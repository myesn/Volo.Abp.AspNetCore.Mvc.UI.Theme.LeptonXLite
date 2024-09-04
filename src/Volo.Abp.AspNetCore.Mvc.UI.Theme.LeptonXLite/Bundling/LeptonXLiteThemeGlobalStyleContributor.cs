using System.Collections.Generic;
using Volo.Abp.AspNetCore.Mvc.UI.Bundling;
using Volo.Abp.Localization;

namespace Volo.Abp.AspNetCore.Mvc.UI.Theme.LeptonXLite.Bundling;

public class LeptonXLiteThemeGlobalStyleContributor : BundleContributor
{
    private const string RootPath = "/Themes/LeptonXLite/Global";
    public override void ConfigureBundle(BundleConfigurationContext context)
    {
	    var rtlPostfix = CultureHelper.IsRtl ? ".rtl" : string.Empty;

        context.Files.Add($"{RootPath}/side-menu/css/js-bundle{rtlPostfix}.css");
        context.Files.Add($"{RootPath}/side-menu/css/layout-bundle{rtlPostfix}.css");
        context.Files.Add($"{RootPath}/side-menu/css/abp-bundle{rtlPostfix}.css");
        context.Files.Add($"{RootPath}/side-menu/css/font-bundle{rtlPostfix}.css");


        context.Files.ReplaceOne(x => x.FileName == "/libs/bootstrap/css/bootstrap.css", $"{RootPath}/side-menu/css/bootstrap-dim{rtlPostfix}.css");

        // Currently it doesn't exist. But ensure that it'll be replaced in the future too.
        context.Files.RemoveAll(x => x.FileName.EndsWith("bootstrap-icons.css"));
        context.Files.AddIfNotContains($"{RootPath}/side-menu/libs/bootstrap-icons/font/bootstrap-icons.css");
    }
}
