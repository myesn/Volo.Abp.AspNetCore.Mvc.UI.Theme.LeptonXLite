import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MnLanguageSelectionComponent } from './mn-language-selection.component';

describe('MnLanguageSelectionComponent', () => {
  let component: MnLanguageSelectionComponent;
  let fixture: ComponentFixture<MnLanguageSelectionComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ MnLanguageSelectionComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(MnLanguageSelectionComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
