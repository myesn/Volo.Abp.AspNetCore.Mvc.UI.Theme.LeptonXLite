using System.Threading.Tasks;

namespace Volo.Abp.AspNetCore.Components.Web.LeptonXLiteTheme.Themes.LeptonXLite.Toolbar;

public partial class MobileLanguageSwitchComponent
{
    public LanguageSwitchViewModel ViewModel { get; }

    public MobileLanguageSwitchComponent(LanguageSwitchViewModel viewModel)
    {
        ViewModel = viewModel;
    }
}