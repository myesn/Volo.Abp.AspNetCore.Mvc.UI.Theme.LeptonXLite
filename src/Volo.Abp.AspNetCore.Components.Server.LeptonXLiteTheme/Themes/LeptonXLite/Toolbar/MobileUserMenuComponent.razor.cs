using Localization.Resources.AbpUi;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.Extensions.Localization;
using System;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.MultiTenancy;
using Volo.Abp.UI.Navigation;
using Volo.Abp.Users;

namespace Volo.Abp.AspNetCore.Components.Server.LeptonXLiteTheme.Themes.LeptonXLite.Toolbar;

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
    protected IStringLocalizer<AbpUiResource> L { get; set; }

    protected ApplicationMenu UserMenu { get; set; }

    protected string TenantName { get; set; }

    protected string UserFullName { get; set; }

    protected override async Task OnInitializedAsync()
    {
        UserMenu = await MenuManager.GetAsync(StandardMenus.User);

        UserFullName = CalculateUserFullName();

        TenantName = CurrentTenant.Name;

        Navigation.LocationChanged += OnLocationChanged;
    }

    protected virtual void OnLocationChanged(object sender, LocationChangedEventArgs e)
    {
        InvokeAsync(StateHasChanged);
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
                fullName.Append(' ');
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
    }
}
