import { Directive, TemplateRef } from '@angular/core';

@Directive({
  selector: 'ng-template[lpx-mn-user-profile-panel]',
})
export class MobileUserProfilePanelDirective {
  constructor(public template: TemplateRef<any>) {}
}
