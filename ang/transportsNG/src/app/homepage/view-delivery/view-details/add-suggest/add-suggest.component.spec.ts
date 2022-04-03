import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AddSuggestComponent } from './add-suggest.component';

describe('AddSuggestComponent', () => {
  let component: AddSuggestComponent;
  let fixture: ComponentFixture<AddSuggestComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AddSuggestComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AddSuggestComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
