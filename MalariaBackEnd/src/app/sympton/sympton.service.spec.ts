import { TestBed } from '@angular/core/testing';

import { SymptonService } from './sympton.service';

describe('SymptonService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: SymptonService = TestBed.get(SymptonService);
    expect(service).toBeTruthy();
  });
});
