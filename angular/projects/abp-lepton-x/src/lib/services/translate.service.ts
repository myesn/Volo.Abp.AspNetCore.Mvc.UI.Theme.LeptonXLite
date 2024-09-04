import { Injectable } from '@angular/core';
import { LocalizationService } from '@abp/ng.core';
import { TranslateService } from '@volo/ngx-lepton-x.core';
import { Observable, of } from 'rxjs';

@Injectable()
export class AbpTranslateService implements TranslateService {
  constructor(private localization: LocalizationService) {}

  get(key: string, defaultValue: string | undefined): string {
    const keyToTranslate = this.getKey(key);
    if (keyToTranslate) {
      return this.localization.instant({
        key: keyToTranslate,
        defaultValue,
      });
    }

    return defaultValue || key;
  }

  get$(key: string, defaultValue: string | undefined): Observable<string> {
    const keyToTranslate = this.getKey(key);
    if (keyToTranslate) {
      return this.localization.get({
        key: keyToTranslate,
        defaultValue,
      });
    }

    return of(defaultValue || key);
  }

  private getKey(key: string): string | undefined {
    return key.includes('::') ? key : undefined;
  }
}
