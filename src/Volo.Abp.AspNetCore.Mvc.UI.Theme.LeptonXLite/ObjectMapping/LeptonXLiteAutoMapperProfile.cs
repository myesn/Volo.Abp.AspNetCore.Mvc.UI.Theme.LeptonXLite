using AutoMapper;
using Volo.Abp.AspNetCore.Mvc.UI.Theme.LeptonXLite.Themes.LeptonXLite.Components.Menu;
using Volo.Abp.AutoMapper;
using Volo.Abp.UI.Navigation;

namespace Volo.Abp.AspNetCore.Mvc.UI.Theme.LeptonXLite.ObjectMapping;
public class LeptonXLiteAutoMapperProfile : Profile
{
    public LeptonXLiteAutoMapperProfile()
    {
        CreateMap<ApplicationMenu, MenuViewModel>()
            .ForMember(vm => vm.Menu, cnf => cnf.MapFrom(x => x));

        CreateMap<ApplicationMenuItem, MenuItemViewModel>()
            .ForMember(vm => vm.MenuItem, cnf => cnf.MapFrom(x => x))
            .Ignore(vm => vm.IsActive);
    }
}
