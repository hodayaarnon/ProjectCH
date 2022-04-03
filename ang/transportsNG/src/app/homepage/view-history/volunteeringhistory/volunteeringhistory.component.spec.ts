import { ComponentFixture, TestBed } from '@angular/core/testing';

import { VolunteeringhistoryComponent } from './volunteeringhistory.component';

describe('VolunteeringhistoryComponent', () => {
  let component: VolunteeringhistoryComponent;
  let fixture: ComponentFixture<VolunteeringhistoryComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ VolunteeringhistoryComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(VolunteeringhistoryComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
