import { Injectable } from '@angular/core';
import { NavigationEnd, Router } from '@angular/router';
import { NavbarService } from '../navbar/navbar.service';
import { BreadcrumbItem, BreadcrumbService } from './breadcrumb.service';
import { combineLatest } from 'rxjs';
import { filter } from 'rxjs/operators';
import { LpxNavbarItem } from '../navbar';

interface BreadCrumbNavigation extends LpxNavbarItem {
  siblings: BreadCrumbNavigation[];
}

@Injectable({
  providedIn: 'root',
})
export class BreadcrumbRouteListenerService {
  constructor(
    private navbarService: NavbarService,
    private router: Router,
    private breadcrumbService: BreadcrumbService,
  ) {}

  subscribeRoute(): void {
    combineLatest([
      this.router.events.pipe(
        filter((event) => event instanceof NavigationEnd),
      ),
      this.navbarService.navbarItems$.pipe(filter((items) => !!items.length)),
    ]).subscribe(([event, items]) => {
      let activeItem = this.navbarService.findByLink(
        (event as NavigationEnd).url,
      );

      if (!activeItem.item) {
        activeItem = this.navbarService.findByLink('/');
      }

      const breadCrumbItems = activeItem.location.reduce((acc, itemIndex) => {
        const parent = acc[acc.length - 1]?.children || items;
        const item = parent[itemIndex];

        return [
          ...acc,
          { ...item, siblings: parent as BreadCrumbNavigation[] },
        ];
      }, [] as BreadCrumbNavigation[]);

      this.breadcrumbService.setItems(
        this.mapNavbarItemToBreadcrumbItem(breadCrumbItems),
      );
    });
  }

  private mapNavbarItemToBreadcrumbItem(
    items: BreadCrumbNavigation[],
  ): BreadcrumbItem[] {
    return items.map(({ breadcrumbText, text, link, icon, siblings }) => ({
      text: breadcrumbText || text || '',
      link,
      icon,
      children: this.mapNavbarItemToBreadcrumbItem(siblings || []),
    }));
  }
}
