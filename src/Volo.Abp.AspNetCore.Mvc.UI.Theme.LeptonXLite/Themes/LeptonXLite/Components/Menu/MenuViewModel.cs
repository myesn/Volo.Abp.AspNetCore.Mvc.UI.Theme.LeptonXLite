using System.Collections.Generic;
using Volo.Abp.UI.Navigation;

namespace Volo.Abp.AspNetCore.Mvc.UI.Theme.LeptonXLite.Themes.LeptonXLite.Components.Menu;
public class MenuViewModel
{
	public ApplicationMenu Menu { get; set; }

	public IList<MenuItemViewModel> Items { get; set; }
}