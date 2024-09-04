import { ModuleWithProviders, NgModule, Provider } from '@angular/core';
import {
  HasStyleFactory,
  LpxCoreModule,
  LpxCoreOptions,
} from '@volo/ngx-lepton-x.core';
import { getLpxLiteStyleProviders } from './providers';

export interface LpxOptions extends LpxCoreOptions, HasStyleFactory {}

@NgModule({
  imports: [LpxCoreModule],
})
export class LpxModule {
  static forRoot(options?: LpxOptions): ModuleWithProviders<LpxModule> {
    return {
      ngModule: LpxModule,
      providers: [
        getLpxLiteStyleProviders(options?.styleFactory),
        LpxCoreModule.forRoot(options).providers as Provider,
      ],
    };
  }
}
