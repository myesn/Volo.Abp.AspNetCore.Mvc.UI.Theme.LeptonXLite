import { Inject, Injectable } from '@angular/core';
import { combineLatest, Observable, of } from 'rxjs';
import { filter } from 'rxjs/operators';

import {
  ConfigStateService,
  CurrentUserDto,
  NAVIGATE_TO_MANAGE_PROFILE,
} from '@abp/ng.core';
import { UserMenuService } from '@abp/ng.theme.shared';
import { UserProfileService } from '@volo/ngx-lepton-x.core';

@Injectable({
  providedIn: 'root',
})
export class AbpUserProfileService {
  currentUser$: Observable<CurrentUserDto> =
    this.configState.getOne$('currentUser');

  constructor(
    private configState: ConfigStateService,
    private userProfileService: UserProfileService,
    @Inject(NAVIGATE_TO_MANAGE_PROFILE) public navigateToManageProfile: any,
    private userMenuService: UserMenuService
  ) {}

  subscribeUser() {
    combineLatest([
      this.currentUser$.pipe(filter<CurrentUserDto>(Boolean)),
      this.userMenuService.items$,
    ]).subscribe(([user, userMenuItems]) => {
      const userActionGroups = userMenuItems.reduce(
        (acc, curr) => {
          const menuItem = {
            icon: curr.textTemplate?.icon,
            text: curr.textTemplate?.text,
            component: curr?.component,
            action: () => {
              curr.action();
              return of(true);
            },
          };
          acc[0].push(menuItem);
          return acc;
        },
        [[]]
      );

      this.userProfileService.setUser({
        id: user.id,
        isAuthenticated: user.isAuthenticated,
        fullName: user.name || user.userName || '',
        email: user.email || '',
        userName: user.userName || '',
        avatar: {
          type: 'icon',
          source: 'bi bi-person-circle',
        },
        userActionGroups,
      });
    });
  }
}
