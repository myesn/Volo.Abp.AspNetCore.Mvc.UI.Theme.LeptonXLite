import { AsyncPipe } from '@angular/common';
import { ChangeDetectionStrategy, Component, inject } from '@angular/core';
import { ToolbarService } from '@volo/ngx-lepton-x.core';
import { ToolbarItemsComponent } from './toolbar-items.component';
@Component({
  selector: 'lpx-toolbar',
  templateUrl: 'toolbar.component.html',
  standalone: true,
  imports: [AsyncPipe, ToolbarItemsComponent],
  changeDetection: ChangeDetectionStrategy.OnPush,
})
export class ToolbarComponent {
  protected readonly toolbarService = inject(ToolbarService);
}
