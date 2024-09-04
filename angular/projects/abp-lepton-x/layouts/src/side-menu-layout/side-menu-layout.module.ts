import { ModuleWithProviders, NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { CoreModule } from '@abp/ng.core';
import { LpxSideMenuLayoutModule } from '@volo/ngx-lepton-x.lite/layouts';
import {
  LpxFooterModule,
  LpxNavbarModule,
  LpxTranslateModule,
  PanelsModule,
} from '@volo/ngx-lepton-x.core';
import {
  LanguageSelectionModule,
  UserProfileModule,
} from '@volo/ngx-lepton-x.lite';

import { SideMenuApplicationLayoutComponent } from './side-menu-application-layout/side-menu-application-layout.component';
import { LPX_LAYOUT_PROVIDER } from './providers/layout.provider';
import { NAV_ITEM_PROVIDER } from './providers/nav-item.provider';
import { NavItemsComponent } from './components/nav-items/nav-items.component';
import { LanguageSelectionComponent } from './components/language-selection/language-selection.component';
import { UserProfileComponent } from './components/user-profile/user-profile.component';
import { NavigateToLoginComponent } from './components/navigate-to-login/navigate-to-login.component';
import { LeptonXAbpCoreModule } from '@volo/abp.ng.lepton-x.core';

@NgModule({
  declarations: [
    SideMenuApplicationLayoutComponent,
    NavItemsComponent,
    LanguageSelectionComponent,
    UserProfileComponent,
    NavigateToLoginComponent,
  ],
  imports: [
    CommonModule,
    LpxSideMenuLayoutModule,
    RouterModule,
    LpxNavbarModule,
    CoreModule,
    LeptonXAbpCoreModule,
    PanelsModule,
    UserProfileModule,
    LanguageSelectionModule,
    LpxTranslateModule,
    LpxFooterModule,
  ],
})
export class SideMenuLayoutModule {
  static forRoot(): ModuleWithProviders<SideMenuLayoutModule> {
    return {
      ngModule: SideMenuLayoutModule,
      providers: [
        LPX_LAYOUT_PROVIDER,
        NAV_ITEM_PROVIDER,
        LpxSideMenuLayoutModule.forRoot().providers,
      ],
    };
  }
}
