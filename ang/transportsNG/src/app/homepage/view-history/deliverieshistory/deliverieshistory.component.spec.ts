import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DeliverieshistoryComponent } from './deliverieshistory.component';

describe('DeliverieshistoryComponent', () => {
  let component: DeliverieshistoryComponent;
  let fixture: ComponentFixture<DeliverieshistoryComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DeliverieshistoryComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DeliverieshistoryComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
