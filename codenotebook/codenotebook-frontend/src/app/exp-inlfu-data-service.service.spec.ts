import { TestBed } from '@angular/core/testing';

import { ExpInlfuDataServiceService } from './exp-inlfu-data-service.service';

describe('ExpInlfuDataServiceService', () => {
  let service: ExpInlfuDataServiceService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ExpInlfuDataServiceService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
