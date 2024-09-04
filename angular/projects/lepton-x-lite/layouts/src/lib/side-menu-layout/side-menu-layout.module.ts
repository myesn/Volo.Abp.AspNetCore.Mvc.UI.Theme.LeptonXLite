import { ModuleWithProviders, NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import {
  HasStyleFactory,
  LpxBrandLogoModule,
  LpxBreadcrumbModule,
  LpxFooterModule,
  LpxNavbarModule,
  LpxResponsiveModule,
  PanelsModule,
} from '@volo/ngx-lepton-x.core';
import {
  LanguageSelectionModule,
  UserProfileModule,
} from '@volo/ngx-lepton-x.lite';
import { LpxMobileNavbarModule } from '../components/mobile-navbar/mobile-navbar.module';

import { SettingsPanelDirective } from './panels/settings-panel.directive';
import { SideMenuLayoutComponent } from './side-menu-layout.component';
import { LanguageSelectionPanelDirective } from './panels/language-selection-panel.directive';
import { UserProfilePanelDirective } from './panels/user-profile-panel.directive';
import { TopbarContentPanelDirective } from './panels/topbar-content-panel.directive';
import { getSideMenuLayoutStylesProvider } from './providers';
import { MnUserProfileModule } from '../components';
import { MobileUserProfilePanelDirective } from './panels/mobile-user-profile-panel.directive';
import { MnLanguageSelectionModule } from '../components/mn-language-selection';
import { ToolbarContainerComponent } from '../components'
import { MobileLanguageSelectionDirective } from './panels/mobile-language-selection.directive';

export type LpxSideMenuLayoutOptions = HasStyleFactory;
const declarationsWithExports = [
  SideMenuLayoutComponent,
  SettingsPanelDirective,
  LanguageSelectionPanelDirective,
  TopbarContentPanelDirective,
  UserProfilePanelDirective,
  MobileUserProfilePanelDirective,
  MobileLanguageSelectionDirective,
];

@NgModule({
  declarations: [...declarationsWithExports],
  imports: [
    CommonModule,
    LpxNavbarModule,
    LpxBreadcrumbModule,
    LpxResponsiveModule,
    UserProfileModule,
    LanguageSelectionModule,
    LpxMobileNavbarModule,
    MnUserProfileModule,
    MnLanguageSelectionModule,
    LpxFooterModule,
    PanelsModule,
    LpxBrandLogoModule,
    ToolbarContainerComponent
  ],
  exports: [...declarationsWithExports],
})
export class LpxSideMenuLayoutModule {
  static forRoot(
    options?: LpxSideMenuLayoutOptions
  ): ModuleWithProviders<LpxSideMenuLayoutModule> {
    return {
      ngModule: LpxSideMenuLayoutModule,
      providers: [getSideMenuLayoutStylesProvider(options?.styleFactory)],
    };
  }
}
