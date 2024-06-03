import { TestBed } from '@angular/core/testing';

import { CalculateServiceService } from './calculate-service.service';

describe('CalculateServiceService', () => {
  let service: CalculateServiceService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(CalculateServiceService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
