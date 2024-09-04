import { CommonModule } from '@angular/common';
import { Component, Input, TemplateRef, Type } from '@angular/core';
import { LpxIconModule } from '@volo/ngx-lepton-x.core';
import { Observable, of } from 'rxjs';

@Component({
  selector: 'lpx-toolbar-item',
  standalone: true,
  templateUrl: './toolbar-item.component.html',
  imports: [CommonModule, LpxIconModule],
})
export class ToolbarItemComponent {
  @Input()
  component?: Type<any>;

  @Input()
  template?: TemplateRef<any>;

  @Input()
  icon?: string;

  @Input()
  badge?: number | Observable<number>;

  @Input()
  html?: string;

  @Input()
  action?: () => void;

  get badge$(): Observable<number | undefined> {
    if (this.badge instanceof Observable) {
      return this.badge;
    }
    return of(this.badge);
  }

  actionClick(): void {
    if (this.action) {
      this.action();
    }
  }
}
