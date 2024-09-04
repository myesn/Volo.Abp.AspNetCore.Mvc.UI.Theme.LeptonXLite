using System.Collections.Generic;
using Volo.Abp.Localization;

namespace Volo.Abp.AspNetCore.Mvc.UI.Theme.LeptonXLite.Languages;
public class ThemeLanguageInfo
{
    public bool HasLanguages => Languages != null && Languages.Count > 1;

    public LanguageInfo CurrentLanguage { get; set; }

    public IReadOnlyList<LanguageInfo> Languages { get; set; }
}
