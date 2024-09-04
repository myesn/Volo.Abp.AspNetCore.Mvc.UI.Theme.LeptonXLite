import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { LpxIconModule } from '@volo/ngx-lepton-x.core';
import { MnLanguageSelectionComponent } from './mn-language-selection.component';

@NgModule({
  declarations: [MnLanguageSelectionComponent],
  imports: [CommonModule, LpxIconModule],
  exports: [MnLanguageSelectionComponent],
})
export class MnLanguageSelectionModule {}
