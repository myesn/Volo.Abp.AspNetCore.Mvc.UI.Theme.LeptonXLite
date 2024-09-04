import { Component } from '@angular/core';
import { AuthService } from '@abp/ng.core';

@Component({
  selector: 'abp-navigate-to-login',
  template: `
    <a href="#" class="nav-link" (click)="navigateToLogin($event)">
      <span>{{ 'AbpUi::Login' | lpxTranslate | async }}</span>
    </a>
  `,
})
export class NavigateToLoginComponent {
  constructor(public readonly authService: AuthService) {}

  navigateToLogin(event: MouseEvent) {
    event.preventDefault();
    this.authService.navigateToLogin();
  }
}
