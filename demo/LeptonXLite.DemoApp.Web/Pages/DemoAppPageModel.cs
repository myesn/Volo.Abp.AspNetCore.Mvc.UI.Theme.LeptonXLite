using LeptonXLite.DemoApp.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace LeptonXLite.DemoApp.Web.Pages
{
    public abstract class DemoAppPageModel : AbpPageModel
    {
        protected DemoAppPageModel()
        {
            LocalizationResourceType = typeof(DemoAppResource);
        }
    }
}