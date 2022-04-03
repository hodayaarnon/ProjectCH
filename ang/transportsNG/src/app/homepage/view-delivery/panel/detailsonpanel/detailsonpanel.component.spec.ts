import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DetailsonpanelComponent } from './detailsonpanel.component';

describe('DetailsonpanelComponent', () => {
  let component: DetailsonpanelComponent;
  let fixture: ComponentFixture<DetailsonpanelComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DetailsonpanelComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DetailsonpanelComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
