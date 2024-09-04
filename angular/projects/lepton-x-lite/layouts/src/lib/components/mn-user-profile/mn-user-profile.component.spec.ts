import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MnUserProfileComponent } from './mn-user-profile.component';

describe('MnUserProfileComponent', () => {
  let component: MnUserProfileComponent;
  let fixture: ComponentFixture<MnUserProfileComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ MnUserProfileComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(MnUserProfileComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
