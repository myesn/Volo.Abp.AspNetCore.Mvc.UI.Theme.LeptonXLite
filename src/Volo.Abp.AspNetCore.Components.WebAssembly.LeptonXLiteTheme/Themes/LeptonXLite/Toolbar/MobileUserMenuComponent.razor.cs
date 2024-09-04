using Localization.Resources.AbpUi;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Options;
using System;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.AspNetCore.Components.Web.Security;
using Volo.Abp.Http.Client;
using Volo.Abp.MultiTenancy;
using Volo.Abp.UI.Navigation;
using Volo.Abp.Users;

namespace Volo.Abp.AspNetCore.Components.WebAssembly.LeptonXLiteTheme.Themes.LeptonXLite.Toolbar;

public partial class MobileUserMenuComponent : IDisposable
{
    [Inject]
    protected IMenuManager MenuManager { get; set; }

    [Inject]
    protected ICurrentUser CurrentUser { get; set; }

    [Inject]
    protected ICurrentTenant CurrentTenant { get; set; }

    [Inject]
    protected NavigationManager Navigation { get; set; }

    [Inject]
    protected ApplicationConfigurationChangedService ApplicationConfigurationChangedService { get; set; }

    [Inject]
    protected IStringLocalizer<AbpUiResource> L { get; set; }

    [Inject]
    protected IOptions<AbpRemoteServiceOptions> RemoteServiceOptions { get; set; }

    protected ApplicationMenu UserMenu { get; set; }

    protected string UserFullName { get; set; }

    protected string TenantName { get; set; }

    protected override async Task OnInitializedAsync()
    {
        await SetUserMenuAndProfileAsync();

        Navigation.LocationChanged += OnLocationChanged;
        ApplicationConfigurationChangedService.Changed += ApplicationConfigurationChanged;
    }
    private async Task SetUserMenuAndProfileAsync()
    {
        UserMenu = await MenuManager.GetAsync(StandardMenus.User);

        UserFullName = CalculateUserFullName();
        TenantName = CurrentTenant.Name;
    }

    protected virtual void OnLocationChanged(object sender, LocationChangedEventArgs e)
    {
        InvokeAsync(StateHasChanged);
    }

    private async void ApplicationConfigurationChanged()
    {
        UserMenu = await MenuManager.GetAsync(StandardMenus.User);
        await InvokeAsync(StateHasChanged);
    }

    protected virtual string CalculateUserFullName()
    {
        //TODO: Should we move this logic to some extension method for the ICurrentUser?
        var fullName = new StringBuilder();

        if (!CurrentUser.Name.IsNullOrEmpty())
        {
            fullName.Append(CurrentUser.Name);
        }

        if (!CurrentUser.SurName.IsNullOrEmpty())
        {
            if (fullName.Length > 0)
            {
                fullName.Append(" ");
            }

            fullName.Append(CurrentUser.SurName);
        }

        if (fullName.Length == 0)
        {
            fullName.Append(CurrentUser.UserName);
        }

        return fullName.ToString();
    }

    public void Dispose()
    {
        Navigation.LocationChanged -= OnLocationChanged;
        ApplicationConfigurationChangedService.Changed -= ApplicationConfigurationChanged;
    }
}
