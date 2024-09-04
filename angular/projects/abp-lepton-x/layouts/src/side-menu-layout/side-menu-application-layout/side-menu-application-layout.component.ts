import { Component } from '@angular/core';
import { eThemeLeptonXComponents } from '@abp/ng.theme.lepton-x';

@Component({
  selector: 'abp-application-layout',
  templateUrl: './side-menu-application-layout.component.html',
})
export class SideMenuApplicationLayoutComponent {
  toolbarKey = eThemeLeptonXComponents.Toolbar;
  navbarKey = eThemeLeptonXComponents.Navbar;
  routesKey = eThemeLeptonXComponents.Routes;
  navItemsKey = eThemeLeptonXComponents.NavItems;
  breadcrumbKey = eThemeLeptonXComponents.Breadcrumb;
  footerKey = eThemeLeptonXComponents.Footer;
  mobileNavbarKey = eThemeLeptonXComponents.MobileNavbar;
  pageAlertContainerKey = eThemeLeptonXComponents.PageAlertContainer;
  logoKey = eThemeLeptonXComponents.Logo;
  currentUserKey = eThemeLeptonXComponents.CurrentUser;
  currentUserImageKey = eThemeLeptonXComponents.CurrentUserImage;
  languageKey = eThemeLeptonXComponents.Languages;
  mobileUserProfile = eThemeLeptonXComponents.MobileUserProfile;
  mobileLanguageSelection = eThemeLeptonXComponents.MobileLanguageSelection;
}
