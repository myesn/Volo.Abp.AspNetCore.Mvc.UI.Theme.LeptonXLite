import { Component } from '@angular/core';
import { eThemeLeptonXComponents } from '@abp/ng.theme.lepton-x';

@Component({
  selector: 'abp-language-selection',
  templateUrl: './language-selection.component.html',
})
export class LanguageSelectionComponent {
  languageSelectionKey = eThemeLeptonXComponents.Languages;
}
