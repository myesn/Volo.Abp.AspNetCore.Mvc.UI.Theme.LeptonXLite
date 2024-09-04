import { Directive, TemplateRef } from '@angular/core';

@Directive({
  selector: 'ng-template[lpx-topbar-content]',
})
export class TopbarContentPanelDirective {
  constructor(public template: TemplateRef<any>) {}
}
