using System;
using Volo.Abp.AspNetCore.Components.Web.LeptonXLiteTheme.Themes.LeptonXLite;
using Volo.Abp.AspNetCore.Components.Web.Theming.Layout;
using Volo.Abp.AspNetCore.Components.Web.Theming.Theming;
using Volo.Abp.DependencyInjection;

namespace Volo.Abp.AspNetCore.Components.Web.LeptonXLiteTheme;

[ThemeName(Name)]
public class LeptonXLiteTheme : ITheme, ITransientDependency
{
    public const string Name = "LeptonXLite";
    
    public Type GetLayout(string name, bool fallbackToDefault = true)
    {
        switch (name)
        {
            case StandardLayouts.Application:
            case StandardLayouts.Account:
            case StandardLayouts.Empty:
                return typeof(MainLayout);
            default:
                return fallbackToDefault ? typeof(MainLayout) : typeof(NullLayout);
        }
    }
}