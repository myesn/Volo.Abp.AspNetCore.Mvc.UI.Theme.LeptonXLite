import { Component, ContentChild, OnDestroy } from '@angular/core';
import { NavbarService, LayoutService, LogoPanelDirective } from '@volo/ngx-lepton-x.core';

@Component({
  selector: 'lpx-mobile-navbar',
  templateUrl: './mobile-navbar.component.html',
  styles: [
    `
      .mobile-menu-opened :host {
        height: 100vh;
        display: block;
      }
    `,
  ],
})
export class MobileNavbarComponent implements OnDestroy {
  userMenuHidden = true;
  navItemsHidden = true;
  mobileMenuOpened = 'mobile-menu-opened';

  @ContentChild(LogoPanelDirective) logoPanel?: LogoPanelDirective;

  constructor(
    public navService: NavbarService,
    private layoutService: LayoutService
  ) {}

  ngOnDestroy() {
    this.layoutService.removeClass(this.mobileMenuOpened);
  }

  toggleUserMenu() {
    this.userMenuHidden = !this.userMenuHidden;
  }

  toggleNavbar() {
    this.navItemsHidden = !this.navItemsHidden;
    this.setLayoutClass();
  }

  setLayoutClass() {
    if (this.navItemsHidden) {
      this.layoutService.removeClass(this.mobileMenuOpened);
    } else {
      this.layoutService.addClass(this.mobileMenuOpened);
    }
  }
}
