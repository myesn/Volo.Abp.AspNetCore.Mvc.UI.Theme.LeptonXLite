using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;
using Volo.Abp.UI.Navigation;

namespace Volo.Abp.AspNetCore.Components.Web.LeptonXLiteTheme.Themes.LeptonXLite.Navigation;
public class MainMenuProvider : IScopedDependency
{
    private readonly IMenuManager _menuManager;

    private MenuViewModel Menu { get; set; }

    public MainMenuProvider(
        IMenuManager menuManager)
    {
        _menuManager = menuManager;
    }

    public virtual async Task<MenuViewModel> GetMenuAsync()
    {
        var menu = await _menuManager.GetMainMenuAsync();

        Menu = new MenuViewModel
        {
            Menu = menu,
            Items = menu.Items.Select(CreateMenuItemViewModel).ToList()
        };
        Menu.SetParents();

        return Menu;
    }

    private MenuItemViewModel CreateMenuItemViewModel(ApplicationMenuItem applicationMenuItem)
    {
        var viewModel = new MenuItemViewModel
        {
            MenuItem = applicationMenuItem,
        };

        viewModel.Items = new List<MenuItemViewModel>();

        foreach (var item in applicationMenuItem.Items)
        {
            viewModel.Items.Add(CreateMenuItemViewModel(item));
        }

        return viewModel;
    }
}
