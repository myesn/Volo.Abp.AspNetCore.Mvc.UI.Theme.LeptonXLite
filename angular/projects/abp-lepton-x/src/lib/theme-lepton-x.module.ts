import { ModuleWithProviders, NgModule, Provider } from '@angular/core';
import { LpxStyles } from '@volo/ngx-lepton-x.core';
import { LpxModule, LpxOptions } from '@volo/ngx-lepton-x.lite';
import { ValidationErrorModule } from './components/validation-error';
import { LPX_USER_PROVIDER } from './providers/user.provider';
import { LPX_LANGUAGE_PROVIDER } from './providers/language.provider';
import { LPX_TRANSLATE_PROVIDER } from './providers/translate.provider';
import { LEPTON_X_USER_MENU_PROVIDERS } from './providers/user-menu-service.provider';
import { LeptonXAbpCoreModule } from '@volo/abp.ng.lepton-x.core';
import { INIT_SERVICE_PROVIDER } from './providers';

export type ThemeLeptonXModuleOptions = LpxOptions;

@NgModule({
  declarations: [],
  imports: [LpxModule, ValidationErrorModule],
  exports: [],
})
export class ThemeLeptonXModule {
  static forRoot(
    options?: ThemeLeptonXModuleOptions
  ): ModuleWithProviders<ThemeLeptonXModule> {
    return {
      ngModule: ThemeLeptonXModule,
      providers: [
        LpxModule.forRoot(createLpxModuleOptions(options))
          .providers as Provider,
        ValidationErrorModule.forRoot().providers as Provider,
        LPX_USER_PROVIDER,
        LPX_LANGUAGE_PROVIDER,
        LPX_TRANSLATE_PROVIDER,
        LEPTON_X_USER_MENU_PROVIDERS,
        INIT_SERVICE_PROVIDER,
        LeptonXAbpCoreModule.forRoot().providers as Provider,
      ],
    };
  }
}

function createLpxModuleOptions(options?: ThemeLeptonXModuleOptions) {
  return {
    ...options,
    styleFactory: (styles: LpxStyles) => {
      styles.push({
        bundleName: 'abp-bundle',
      });
      if (options?.styleFactory) {
        return options.styleFactory(styles);
      }
      return styles;
    },
  };
}
