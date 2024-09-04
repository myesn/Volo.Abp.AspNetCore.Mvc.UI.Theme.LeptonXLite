import { Component, ViewEncapsulation, inject } from '@angular/core';
import { LpxNavbarItem, UserProfileService } from '@volo/ngx-lepton-x.core';
 
@Component({
  selector: 'lpx-mn-user-profile',
  templateUrl: './mn-user-profile.component.html',
  encapsulation: ViewEncapsulation.None,
})
export class MnUserProfileComponent {
  private service = inject(UserProfileService)
  user$ = this.service.user$;
  menuHidden = true;

  toggleMenu() {
    this.menuHidden = !this.menuHidden;
  }

  onActionClick(item: LpxNavbarItem) {
    item.action?.();
  }
}
