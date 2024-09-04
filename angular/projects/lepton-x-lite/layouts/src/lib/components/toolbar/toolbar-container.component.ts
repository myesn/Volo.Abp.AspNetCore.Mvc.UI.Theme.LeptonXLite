import { Component } from '@angular/core';
import { ToolbarComponent } from './toolbar.component';

@Component({
  standalone: true,
  selector: 'lpx-toolbar-container',
  templateUrl: 'toolbar-container.component.html',
  imports: [ToolbarComponent],
})
export class ToolbarContainerComponent {}
