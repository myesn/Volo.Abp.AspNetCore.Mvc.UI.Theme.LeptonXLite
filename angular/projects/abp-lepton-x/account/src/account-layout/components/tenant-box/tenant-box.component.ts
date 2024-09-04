import {Component, inject} from '@angular/core';
import {CommonModule} from '@angular/common';
import {CoreModule} from '@abp/ng.core';
import {ThemeSharedModule} from '@abp/ng.theme.shared';
import {AccountLayoutService} from "../../services/account-layout.service";

@Component({
  // eslint-disable-next-line @angular-eslint/component-selector
  selector: 'lpx-tenant-box',
  templateUrl: './tenant-box.component.html',
  standalone: true,
  imports: [CommonModule, CoreModule, ThemeSharedModule],
})
export class TenantBoxComponent {
  public service = inject(AccountLayoutService)
}
