import { TestBed } from '@angular/core/testing';

import { OutbreakService } from './outbreak.service';

describe('OutbreakService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: OutbreakService = TestBed.get(OutbreakService);
    expect(service).toBeTruthy();
  });
});
