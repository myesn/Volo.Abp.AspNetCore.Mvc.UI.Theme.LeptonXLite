import { ChangeDetectionStrategy, Component, Input } from '@angular/core';
import { LpxVisibleDirective, ToolbarItem } from '@volo/ngx-lepton-x.core';
import { ToolbarItemComponent } from './toolbar-item.component';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'lpx-toolbar-items',
  standalone: true,
  templateUrl: './toolbar-items.component.html',
  imports: [ToolbarItemComponent, CommonModule, LpxVisibleDirective],
  changeDetection: ChangeDetectionStrategy.OnPush,
})
export class ToolbarItemsComponent {
  @Input()
  items!: ToolbarItem[];
}
