import {Component, inject} from '@angular/core';
import {AuthWrapperService} from '@abp/ng.account.core';
import {CommonModule} from '@angular/common';
import {TenantBoxComponent} from '../tenant-box/tenant-box.component';
import {LanguageSelectionModule} from '@volo/ngx-lepton-x.lite';
import {CoreModule, SubscriptionService} from '@abp/ng.core';
import {ThemeSharedModule} from '@abp/ng.theme.shared';
import {RouterOutlet} from '@angular/router';
import {AccountLayoutService} from "../../services/account-layout.service";

@Component({
  // eslint-disable-next-line @angular-eslint/component-selector
  selector: 'lpx-auth-wrapper',
  templateUrl: './auth-wrapper.component.html',
  standalone: true,
  imports: [
    CommonModule,
    CoreModule,
    ThemeSharedModule,
    TenantBoxComponent,
    LanguageSelectionModule,
    RouterOutlet
  ],
  providers: [AccountLayoutService],
})
export class AuthWrapperComponent {
  service = inject(AccountLayoutService)
}
