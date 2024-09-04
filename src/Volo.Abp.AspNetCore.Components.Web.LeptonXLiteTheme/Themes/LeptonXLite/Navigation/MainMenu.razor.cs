using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.AspNetCore.Components.Web.Security;

namespace Volo.Abp.AspNetCore.Components.Web.LeptonXLiteTheme.Themes.LeptonXLite.Navigation;

public partial class MainMenu : IDisposable
{
    [Inject] protected MainMenuProvider MainMenuProvider { get; set; }

    [Inject] protected ApplicationConfigurationChangedService ApplicationConfigurationChangedService { get; set; }

    [Parameter] public EventCallback OnClickCallback { get; set; }

    protected MenuViewModel Menu { get; set; }

    protected override async Task OnInitializedAsync()
    {
        Menu = await MainMenuProvider.GetMenuAsync();
        Menu.StateChanged += Menu_StateChanged;
        ApplicationConfigurationChangedService.Changed += ApplicationConfigurationChanged;
    }

    private void Menu_StateChanged(object sender, EventArgs e)
    {
        InvokeAsync(StateHasChanged);
    }

    private async void ApplicationConfigurationChanged()
    {
        if (Menu != null)
        {
            Menu.StateChanged -= Menu_StateChanged;
        }
        
        Menu = await MainMenuProvider.GetMenuAsync();
        Menu.StateChanged += Menu_StateChanged;
        await InvokeAsync(StateHasChanged);
    }

    public void Dispose()
    {
        if (Menu != null)
        {
            Menu.StateChanged -= Menu_StateChanged;
        }
        
        ApplicationConfigurationChangedService.Changed -= ApplicationConfigurationChanged;
    }
}
