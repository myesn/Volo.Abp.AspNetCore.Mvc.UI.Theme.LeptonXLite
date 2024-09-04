using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.AspNetCore.Components.Web.Theming.Toolbars;

namespace Volo.Abp.AspNetCore.Components.Web.LeptonXLiteTheme.Themes.LeptonXLite;
public partial class ToolbarItemsComponent
{
    [Inject] private IToolbarManager ToolbarManager { get; set; }

    [Parameter] public string Name { get; set; }

    private List<RenderFragment> ToolbarItemRenders { get; set; } = new List<RenderFragment>();

    protected override async Task OnInitializedAsync()
    {
        var toolbar = await ToolbarManager.GetAsync(Name ?? StandardToolbars.Main);

        ToolbarItemRenders.Clear();

        foreach (var item in toolbar.Items)
        {
            ToolbarItemRenders.Add(builder =>
            {
                builder.OpenComponent(0, item.ComponentType);
                builder.CloseComponent();
            });
        }
    }
}
