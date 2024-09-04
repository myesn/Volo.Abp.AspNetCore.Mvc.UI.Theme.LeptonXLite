﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.RequestLocalization;
using Microsoft.Extensions.DependencyInjection;
using System.Globalization;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Localization;

namespace Volo.Abp.AspNetCore.Mvc.UI.Theme.LeptonXLite.Languages;

public class ThemeLanguageInfoProvider : ITransientDependency
{
	protected ILanguageProvider LanguageProvider { get; }
	protected IHttpContextAccessor HttpContextAccessor { get; }

    public ThemeLanguageInfoProvider(
		ILanguageProvider languageProvider,
		IHttpContextAccessor httpContextAccessor)
    {
        LanguageProvider = languageProvider;
        HttpContextAccessor = httpContextAccessor;
    }

    public virtual async Task<ThemeLanguageInfo> GetLanguageSwitchViewComponentModelAsync()
	{
		var languages = await LanguageProvider.GetLanguagesAsync();
		var currentLanguage = languages.FindByCulture(
			CultureInfo.CurrentCulture.Name,
			CultureInfo.CurrentUICulture.Name
		);

		if (currentLanguage == null)
		{
			var abpRequestLocalizationOptionsProvider = HttpContextAccessor.HttpContext.RequestServices.GetRequiredService<IAbpRequestLocalizationOptionsProvider>();
			var localizationOptions = await abpRequestLocalizationOptionsProvider.GetLocalizationOptionsAsync();
			if (localizationOptions?.DefaultRequestCulture != null)
			{
				currentLanguage = new LanguageInfo(
					localizationOptions.DefaultRequestCulture.Culture.Name,
					localizationOptions.DefaultRequestCulture.UICulture.Name,
					localizationOptions.DefaultRequestCulture.UICulture.DisplayName);
			}
			else
			{
				currentLanguage = new LanguageInfo(
					CultureInfo.CurrentCulture.Name,
					CultureInfo.CurrentUICulture.Name,
					CultureInfo.CurrentUICulture.DisplayName);
			}
		}

		return new ThemeLanguageInfo
		{
			CurrentLanguage = currentLanguage,
			Languages = languages
		};
	}
}
