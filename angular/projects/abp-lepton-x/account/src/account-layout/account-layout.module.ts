import {
  APP_INITIALIZER,
  Injector,
  ModuleWithProviders,
  NgModule,
} from '@angular/core';
import { AccountLayoutComponent } from './account-layout.component';
import { TenantBoxComponent } from './components/tenant-box/tenant-box.component';
import { AuthWrapperComponent } from './components/auth-layout/auth-wrapper.component';
import { CoreModule, ReplaceableComponentsService } from '@abp/ng.core';
import { LpxSideMenuLayoutModule } from '@volo/ngx-lepton-x.lite/layouts';
import { LanguageSelectionModule } from '@volo/ngx-lepton-x.lite';
import { RouterModule } from '@angular/router';
import { ThemeSharedModule } from '@abp/ng.theme.shared';
import { PageAlertContainerModule } from '@volo/abp.ng.lepton-x.core';

@NgModule({
  declarations: [
    AccountLayoutComponent,
  ],
  imports: [
    RouterModule,
    CoreModule,
    LpxSideMenuLayoutModule,
    ThemeSharedModule,
    PageAlertContainerModule,
    LanguageSelectionModule,
    TenantBoxComponent,
    AuthWrapperComponent,
  ],
})
export class AccountLayoutModule {
  static forRoot(): ModuleWithProviders<AccountLayoutModule> {
    return {
      ngModule: AccountLayoutModule,
      providers: [
        {
          provide: APP_INITIALIZER,
          useFactory: initAccountLayout,
          deps: [Injector],
          multi: true,
        },
      ],
    };
  }
}

export function initAccountLayout(injector: Injector) {
  function init() {
    const replaceableComponents = injector.get(ReplaceableComponentsService);
    replaceableComponents.add({
      key: 'Theme.AccountLayoutComponent',
      component: AccountLayoutComponent,
    });
  }

  return init;
}
