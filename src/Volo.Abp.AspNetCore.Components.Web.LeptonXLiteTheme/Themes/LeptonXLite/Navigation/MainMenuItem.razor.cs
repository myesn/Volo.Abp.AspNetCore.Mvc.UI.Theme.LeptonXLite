using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using Volo.Abp.AspNetCore.Components.Web.Theming.Layout;

namespace Volo.Abp.AspNetCore.Components.Web.LeptonXLiteTheme.Themes.LeptonXLite.Navigation;

public partial class MainMenuItem : IDisposable
{
    [Inject] protected NavigationManager NavigationManager { get; set; }

    [Inject] protected PageLayout PageLayout { get; set; }

    [Inject] protected IJSRuntime JsRuntime { get; set; }

    [Parameter]
    public MenuViewModel Menu { get; set; }

    [Parameter]
    public MenuItemViewModel MenuItem { get; set; }

    protected override void OnParametersSet()
    {
        ActivateCurrentPage();
        PageLayout.PropertyChanged += (s, e) =>
        {
            if (e.PropertyName == nameof(PageLayout.MenuItemName))
            {
                ActivateCurrentPage();
            }
        };
    }

    protected override void OnInitialized()
    {
        NavigationManager.LocationChanged += OnLocationChanged;
    }

    protected virtual void OnLocationChanged(object sender, LocationChangedEventArgs e)
    {
        ActivateCurrentPage();
    }

    protected virtual void ActivateCurrentPage()
    {
        if (MenuItem.MenuItem.Url.IsNullOrEmpty())
        {
            return;
        }

        if (PageLayout.MenuItemName.IsNullOrEmpty())
        {
            var menuItemPath = MenuItem.MenuItem.Url.Replace("~/", string.Empty).Trim('/');
            var currentPagePath = new Uri(NavigationManager.Uri.TrimEnd('/')).AbsolutePath.Trim('/');

            if (menuItemPath.TrimEnd('/').Equals(currentPagePath, StringComparison.InvariantCultureIgnoreCase))
            {
                Menu.Activate(MenuItem);
            }
        }

        if (PageLayout.MenuItemName == MenuItem.MenuItem.Name)
        {
            Menu.Activate(MenuItem);
        }
    }

    protected virtual void ToggleMenu()
    {
        Menu.ToggleOpen(MenuItem);
    }

    public virtual void Dispose()
    {
        NavigationManager.LocationChanged -= OnLocationChanged;
    }
}
