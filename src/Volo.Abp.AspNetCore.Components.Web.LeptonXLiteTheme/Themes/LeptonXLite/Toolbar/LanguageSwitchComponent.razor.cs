using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace Volo.Abp.AspNetCore.Components.Web.LeptonXLiteTheme.Themes.LeptonXLite.Toolbar;

public partial class LanguageSwitchComponent
{
    [Inject] public LanguageSwitchViewModel ViewModel { get; set; }

    protected override Task OnInitializedAsync()
    {
        ViewModel.OnInitialized += (s, e) => StateHasChanged();

        return Task.CompletedTask;
    }
}
