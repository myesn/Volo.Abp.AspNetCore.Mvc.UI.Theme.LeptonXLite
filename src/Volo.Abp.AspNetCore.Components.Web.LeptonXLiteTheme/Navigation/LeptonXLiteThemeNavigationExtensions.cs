using JetBrains.Annotations;
using System;
using Volo.Abp.UI.Navigation;

namespace Volo.Abp.AspNetCore.Components.Web.LeptonXLiteTheme.Navigation;
public static class LeptonXLiteThemeNavigationExtensions
{
    public const string CustomDataComponentKey = "LeptonXLiteTheme.CustomComponent";

    public static ApplicationMenuItem UseComponent(this ApplicationMenuItem applicationMenuItem, Type componentType)
    {
        return applicationMenuItem.WithCustomData(CustomDataComponentKey, componentType);
    }

    [CanBeNull]
    public static Type GetComponentTypeOrDefault(this ApplicationMenuItem applicationMenuItem)
    {
        if (applicationMenuItem.CustomData.TryGetValue(CustomDataComponentKey, out object componentType))
        {
            return componentType as Type;
        }

        return default;
    }
}
