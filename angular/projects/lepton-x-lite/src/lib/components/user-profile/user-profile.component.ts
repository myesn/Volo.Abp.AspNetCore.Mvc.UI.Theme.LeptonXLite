import { Component, Injector, ViewEncapsulation, inject } from '@angular/core';
import { LpxNavbarItem, UserProfileService } from '@volo/ngx-lepton-x.core';

@Component({
  selector: 'lpx-user-profile',
  templateUrl: './user-profile.component.html',
  encapsulation: ViewEncapsulation.None
})
export class UserProfileComponent {
  private service = inject(UserProfileService);
  public injector = inject(Injector)
  user$ = this.service.user$;

  onActionClick(item: LpxNavbarItem) {
    item.action?.();
  }
}
