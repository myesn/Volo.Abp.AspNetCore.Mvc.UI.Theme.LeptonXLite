import { Component,ViewEncapsulation, inject } from '@angular/core';
import { LanguageService, LpxLanguage } from '@volo/ngx-lepton-x.core';
 
@Component({
  selector: 'lpx-mn-language-selection',
  templateUrl: './mn-language-selection.component.html',
  encapsulation: ViewEncapsulation.None,
  providers: [],
})
export class MnLanguageSelectionComponent {
  private service = inject(LanguageService) 
  langs$ = this.service.languages$
  selectedLanguage$ = this.service.selectedLanguage$;
  menuHidden = true;
 
  toggleMenu() {
    this.menuHidden = !this.menuHidden;
  }

  onLanguageSelection(lang: LpxLanguage) {
    this.service.setSelectedLanguage(lang);
  }
}
