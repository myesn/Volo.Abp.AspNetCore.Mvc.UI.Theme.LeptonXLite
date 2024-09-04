import { Directive, TemplateRef } from '@angular/core';

@Directive({
  selector: 'ng-template[lpx-mn-language-selection]',
})
export class MobileLanguageSelectionDirective {
  constructor(public template: TemplateRef<any>) {}
}
