import { Component, ViewEncapsulation, inject } from '@angular/core';
import {
  LanguageService,
  LpxIconModule,
  LpxLanguage,
} from '@volo/ngx-lepton-x.core';
import { CommonModule } from '@angular/common';
import { NgbDropdownModule } from '@ng-bootstrap/ng-bootstrap';

@Component({
  selector: 'lpx-language-selection',
  standalone: true,
  imports: [CommonModule, NgbDropdownModule, LpxIconModule],
  templateUrl: './language-selection.component.html',
  encapsulation: ViewEncapsulation.None,
})
export class LanguageSelectionComponent {
  private service = inject(LanguageService);
  langs$ = this.service.languages$;
  selectedLanguage$ = this.service.selectedLanguage$;

  onLanguageSelection(lang: LpxLanguage) {
    this.service.setSelectedLanguage(lang);
  }
}
