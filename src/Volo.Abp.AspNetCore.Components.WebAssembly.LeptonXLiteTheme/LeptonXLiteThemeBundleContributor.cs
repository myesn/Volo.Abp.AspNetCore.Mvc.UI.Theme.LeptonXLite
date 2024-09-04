using Volo.Abp.Bundling;

namespace Volo.Abp.AspNetCore.Components.WebAssembly.LeptonXLiteTheme;

public class LeptonXLiteThemeBundleContributor : IBundleContributor
{
    public void AddScripts(BundleContext context)
    {
        if (!context.InteractiveAuto)
        {
            context.Add("_content/Volo.Abp.AspNetCore.Components.Web.LeptonXLiteTheme/side-menu/libs/bootstrap/js/bootstrap.bundle.js");
        }

        context.Add("_content/Volo.Abp.AspNetCore.Components.Web.LeptonXLiteTheme/side-menu/js/lepton-x.bundle.min.js");
        context.Add("_content/Volo.Abp.AspNetCore.Components.Web.LeptonXLiteTheme/side-menu/libs/jquery/jquery.min.js");
        context.Add("_content/Volo.Abp.AspNetCore.Components.Web.LeptonXLiteTheme/side-menu/libs/bootstrap-datepicker/js/bootstrap-datepicker.min.js");
        context.Add("_content/Volo.Abp.AspNetCore.Components.Web.LeptonXLiteTheme/scripts/style-initializer.js");
        context.Add("_content/Volo.Abp.AspNetCore.Components.WebAssembly.LeptonXLiteTheme/scripts/style-initializer.js");
    }

    public void AddStyles(BundleContext context)
    {
        context.Add("_content/Volo.Abp.AspNetCore.Components.Web.LeptonXLiteTheme/side-menu/libs/chart.js/Chart.min.css");
        context.Add("_content/Volo.Abp.AspNetCore.Components.Web.LeptonXLiteTheme/side-menu/libs/bootstrap-datepicker/css/bootstrap-datepicker.min.css");
        context.Add("_content/Volo.Abp.AspNetCore.Components.Web.LeptonXLiteTheme/side-menu/libs/bootstrap-icons/font/bootstrap-icons.css");
    }
}
