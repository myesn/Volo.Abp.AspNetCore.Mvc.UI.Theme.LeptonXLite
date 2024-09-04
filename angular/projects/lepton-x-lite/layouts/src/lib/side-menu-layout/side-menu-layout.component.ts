import {
  ChangeDetectionStrategy,
  Component,
  ContentChild,
  inject,
} from '@angular/core';
import {
  BreadcrumbPanelDirective,
  ContentPanelDirective,
  FooterPanelDirective,
  LayoutService,
  LogoPanelDirective,
  MobileNavbarPanelDirective,
  NavbarPanelDirective,
  NavitemPanelDirective,
} from '@volo/ngx-lepton-x.core';
import { SettingsPanelDirective } from './panels/settings-panel.directive';
import { LanguageSelectionPanelDirective } from './panels/language-selection-panel.directive';
import { UserProfilePanelDirective } from './panels/user-profile-panel.directive';
import { TopbarContentPanelDirective } from './panels/topbar-content-panel.directive';
import { MobileUserProfilePanelDirective } from './panels/mobile-user-profile-panel.directive';
import { MobileLanguageSelectionDirective } from './panels/mobile-language-selection.directive';

@Component({
  selector: 'lpx-layout',
  templateUrl: './side-menu-layout.component.html',
  changeDetection: ChangeDetectionStrategy.OnPush,
})
export class SideMenuLayoutComponent {
  public layoutService = inject(LayoutService);

  @ContentChild(NavbarPanelDirective) navbarPanel?: NavbarPanelDirective;
  @ContentChild(MobileNavbarPanelDirective)
  mobileNavbarPanel?: MobileNavbarPanelDirective;
  @ContentChild(BreadcrumbPanelDirective)
  breadcrumbPanel?: BreadcrumbPanelDirective;
  @ContentChild(SettingsPanelDirective) settingsPanel?: SettingsPanelDirective;
  @ContentChild(LanguageSelectionPanelDirective)
  languageSelectionPanelDirective?: LanguageSelectionPanelDirective;
  @ContentChild(TopbarContentPanelDirective)
  topbarContentPanelDirective?: TopbarContentPanelDirective;
  @ContentChild(TopbarContentPanelDirective)
  navItemsPanelDirective?: TopbarContentPanelDirective;
  @ContentChild(UserProfilePanelDirective)
  userProfilePanelDirective?: UserProfilePanelDirective;
  @ContentChild(FooterPanelDirective)
  footerPanelDirective?: FooterPanelDirective;
  @ContentChild(NavitemPanelDirective)
  navitemPanelDirective?: NavitemPanelDirective;
  @ContentChild(MobileUserProfilePanelDirective)
  mobileUserProfilePanelDirective?: MobileUserProfilePanelDirective;
  @ContentChild(MobileLanguageSelectionDirective)
  mobileLanguageSelectionDirective?: MobileLanguageSelectionDirective;
  @ContentChild(LogoPanelDirective) logoPanel?: LogoPanelDirective;
  @ContentChild(ContentPanelDirective) contentPanel?: ContentPanelDirective;
}
