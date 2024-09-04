using System.Threading.Tasks;
using Volo.Abp.Localization;

namespace Volo.Abp.AspNetCore.Components.Web.LeptonXLiteTheme.Languages;

public interface ILanguagePlatformManager
{
    Task ChangeAsync(LanguageInfo newLanguage);

    Task<LanguageInfo> GetCurrentAsync();
}
