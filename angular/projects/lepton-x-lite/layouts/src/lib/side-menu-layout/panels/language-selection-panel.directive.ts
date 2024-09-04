import { Directive, TemplateRef } from '@angular/core';

@Directive({
  selector: 'ng-template[lpx-language-selection]',
})
export class LanguageSelectionPanelDirective {
  constructor(public template: TemplateRef<any>) {}
}
