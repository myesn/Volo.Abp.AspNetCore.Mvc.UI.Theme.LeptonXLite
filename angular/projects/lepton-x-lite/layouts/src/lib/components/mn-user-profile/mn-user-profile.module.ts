import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { LpxAvatarModule, LpxTranslateModule } from '@volo/ngx-lepton-x.core';
import { RouterModule } from '@angular/router';
import { MnUserProfileComponent } from './mn-user-profile.component';

@NgModule({
  declarations: [MnUserProfileComponent],
  imports: [CommonModule, LpxAvatarModule, RouterModule, LpxTranslateModule],
  exports: [MnUserProfileComponent],
})
export class MnUserProfileModule {}
