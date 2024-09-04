using LeptonXLite.DemoApp.Localization;
using Volo.Abp.AspNetCore.Components;

namespace LeptonXLite.DemoApp.Blazor
{
    public abstract class DemoAppComponentBase : AbpComponentBase
    {
        protected DemoAppComponentBase()
        {
            LocalizationResource = typeof(DemoAppResource);
        }
    }
}
