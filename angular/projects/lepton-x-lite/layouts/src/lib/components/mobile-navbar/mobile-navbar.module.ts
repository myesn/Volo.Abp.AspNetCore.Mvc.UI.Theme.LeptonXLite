import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import {
  LpxBrandLogoModule,
  LpxIconModule,
  LpxNavbarModule,
} from '@volo/ngx-lepton-x.core';
import { LanguageSelectionModule } from '@volo/ngx-lepton-x.lite';
import { MobileNavbarComponent } from './mobile-navbar.component';

@NgModule({
  declarations: [MobileNavbarComponent],
  imports: [
    CommonModule,
    LpxBrandLogoModule,
    LpxIconModule,
    LanguageSelectionModule,
    LpxNavbarModule,
  ],
  exports: [MobileNavbarComponent],
})
export class LpxMobileNavbarModule {}
