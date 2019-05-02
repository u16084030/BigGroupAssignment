import { TestBed } from '@angular/core/testing';

import { CauseService } from './cause.service';

describe('CauseService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: CauseService = TestBed.get(CauseService);
    expect(service).toBeTruthy();
  });
});
