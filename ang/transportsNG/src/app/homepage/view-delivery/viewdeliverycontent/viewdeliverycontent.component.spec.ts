import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ViewdeliverycontentComponent } from './viewdeliverycontent.component';

describe('ViewdeliverycontentComponent', () => {
  let component: ViewdeliverycontentComponent;
  let fixture: ComponentFixture<ViewdeliverycontentComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ViewdeliverycontentComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ViewdeliverycontentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
