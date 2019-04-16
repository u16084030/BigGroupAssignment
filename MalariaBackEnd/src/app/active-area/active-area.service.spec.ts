import { TestBed } from '@angular/core/testing';

import { ActiveAreaService } from './active-area.service';

describe('ActiveAreaService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: ActiveAreaService = TestBed.get(ActiveAreaService);
    expect(service).toBeTruthy();
  });
});
