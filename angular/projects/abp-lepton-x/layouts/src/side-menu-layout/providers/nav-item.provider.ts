import { APP_INITIALIZER, Injector, Provider } from '@angular/core';
import { NavItemsService } from '@abp/ng.theme.shared';
import { eThemeLeptonXComponents } from '@abp/ng.theme.lepton-x';
import { LanguageSelectionComponent } from '../components/language-selection/language-selection.component';
import { UserProfileComponent } from '../components/user-profile/user-profile.component';
import { OAuthService } from 'angular-oauth2-oidc';
import { NavigateToLoginComponent } from '../components';

export const NAV_ITEM_PROVIDER: Provider = {
  provide: APP_INITIALIZER,
  multi: true,
  useFactory: addNavItems,
  deps: [Injector],
};

export function addNavItems(injector: Injector) {
  return () => {
    const navItems = injector.get(NavItemsService);
    const oAuthService = injector.get(OAuthService);
    navItems.addItems([
      {
        id: eThemeLeptonXComponents.Login,
        order: 100,
        visible: () => !oAuthService.hasValidAccessToken(),
        component: NavigateToLoginComponent,
      },
      {
        id: eThemeLeptonXComponents.Languages,
        order: 100,
        component: LanguageSelectionComponent,
      },
      {
        id: eThemeLeptonXComponents.CurrentUser,
        order: 100,
        component: UserProfileComponent,
      },
    ]);
  };
}
