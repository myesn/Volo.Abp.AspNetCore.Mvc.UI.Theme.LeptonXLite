import { Provider } from '@angular/core';
import { LPX_TRANSLATE_SERVICE_TOKEN } from '@volo/ngx-lepton-x.core';
import { AbpTranslateService } from '../services/translate.service';

export const LPX_TRANSLATE_PROVIDER: Provider = {
  provide: LPX_TRANSLATE_SERVICE_TOKEN,
  useClass: AbpTranslateService,
};
