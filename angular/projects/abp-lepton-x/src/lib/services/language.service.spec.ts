import { TestBed } from '@angular/core/testing';

import { AbpLanguageService } from './language.service';

describe('LanguageService', () => {
  let service: AbpLanguageService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(AbpLanguageService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
