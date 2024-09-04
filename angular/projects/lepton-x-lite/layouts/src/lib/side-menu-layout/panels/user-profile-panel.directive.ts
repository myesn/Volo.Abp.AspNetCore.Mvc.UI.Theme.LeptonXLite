import { Directive, TemplateRef } from '@angular/core';

@Directive({
  selector: 'ng-template[lpx-user-profile]',
})
export class UserProfilePanelDirective {
  constructor(public template: TemplateRef<any>) {}
}
