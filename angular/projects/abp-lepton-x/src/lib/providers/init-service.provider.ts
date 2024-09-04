import { APP_INITIALIZER, Provider, inject } from '@angular/core';
import { AbpNavbarService, AbpToolbarService } from '@volo/abp.ng.lepton-x.core';

export const INIT_SERVICE_PROVIDER: Provider = {
  provide: APP_INITIALIZER,
  useFactory: initServices,
  multi: true,
};

export function initServices() {
  const abpToolbarService = inject(AbpToolbarService);
  const abpNavbarService = inject(AbpNavbarService);

  return () => {
    abpToolbarService.listenNavItems();
    abpNavbarService.initRoutes();
  }
}
