using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Volo.Abp.AspNetCore.Mvc.UI.Theme.LeptonXLite.Themes.LeptonXLite.Components.Menu;

public class MainMenuViewComponent : AbpViewComponent
{
    protected MenuViewModelProvider MenuViewModelProvider { get; }

    public MainMenuViewComponent(MenuViewModelProvider menuViewModelProvider)
    {
        MenuViewModelProvider = menuViewModelProvider;
    }

    public virtual async Task<IViewComponentResult> InvokeAsync()
    {
        var menu = await MenuViewModelProvider.GetMenuViewModelAsync();

        return View("~/Themes/LeptonXLite/Components/Menu/Default.cshtml", menu);
    }
}