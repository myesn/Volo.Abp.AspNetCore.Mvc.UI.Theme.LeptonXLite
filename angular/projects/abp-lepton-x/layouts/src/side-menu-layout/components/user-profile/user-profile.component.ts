import { Component } from '@angular/core';
import { eThemeLeptonXComponents } from '@abp/ng.theme.lepton-x';

@Component({
  selector: 'abp-user-profile',
  templateUrl: './user-profile.component.html',
})
export class UserProfileComponent {
  key = eThemeLeptonXComponents.CurrentUser;
}
