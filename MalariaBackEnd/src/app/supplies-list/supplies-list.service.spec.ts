import { TestBed } from '@angular/core/testing';

import { SuppliesListService } from './supplies-list.service';

describe('SuppliesListService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: SuppliesListService = TestBed.get(SuppliesListService);
    expect(service).toBeTruthy();
  });
});
