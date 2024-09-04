import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { NgbDropdownModule } from '@ng-bootstrap/ng-bootstrap';
import { LpxAvatarModule, LpxTranslateModule } from '@volo/ngx-lepton-x.core';
import { UserProfileComponent } from './user-profile.component';

@NgModule({
  declarations: [UserProfileComponent],
  imports: [
    CommonModule,
    LpxAvatarModule,
    NgbDropdownModule,
    RouterModule,
    LpxTranslateModule,
  ],
  exports: [UserProfileComponent],
})
export class UserProfileModule {}
