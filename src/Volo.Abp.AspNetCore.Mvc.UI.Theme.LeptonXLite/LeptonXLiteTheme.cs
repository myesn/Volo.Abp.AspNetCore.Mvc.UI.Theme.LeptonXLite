using Volo.Abp.AspNetCore.Mvc.UI.Theming;
using Volo.Abp.DependencyInjection;

namespace Volo.Abp.AspNetCore.Mvc.UI.Theme.LeptonXLite;

[ThemeName(Name)]
public class LeptonXLiteTheme : ITheme, ITransientDependency
{
    public const string Name = "LeptonXLite";

    public virtual string GetLayout(string name, bool fallbackToDefault = true)
    {
        switch (name)
        {
            case StandardLayouts.Application:
                return "~/Themes/LeptonXLite/Layouts/Application.cshtml";
            case StandardLayouts.Account:
                return "~/Themes/LeptonXLite/Layouts/Account.cshtml";
            case StandardLayouts.Empty:
                return "~/Themes/LeptonXLite/Layouts/Empty.cshtml";
            default:
                return fallbackToDefault ? "~/Themes/LeptonXLite/Layouts/Application.cshtml" : null;
        }
    }
}
