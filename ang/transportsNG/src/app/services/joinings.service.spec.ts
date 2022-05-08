import { TestBed } from '@angular/core/testing';

import { JoiningsService } from './joinings.service';

describe('JoiningsService', () => {
  let service: JoiningsService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(JoiningsService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
